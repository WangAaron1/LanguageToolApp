using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

public static class LanguageTool
{
    public enum eLanguageType
    {
        ZH_CN = 0,  //简体中文
        ZH_TW,  //繁体中文
        EN_US,  //英文
        JA_JP,  //日文
        KO_KR,  //韩文
    }
    public static void Replace(eLanguageType langType, string path)
    {

        string workPath = Path.GetFullPath(Path.Combine(path, "..", "..", "..", "Tools", "multi_lang"));

        string originPath = Path.GetFullPath(Path.Combine(path, "..", "..", "..", "ExcelData"));
        string translatePath = Path.GetFullPath(Path.Combine(path, "..", "..", "..", "Tools", "multi_lang", "ExcelDataTranslate", langType.ToString()));
        string outputPath = Path.GetFullPath(Path.Combine(path, "..", "..", "..", "Tools", "multi_lang", "ExcelDataOutput"));

        string arguments = $"-m=config_replace -s={originPath} -d={translatePath} -o={outputPath}";

        Process p = new Process();
        p.StartInfo.FileName = Path.Combine(path, "language_tools.exe");
        p.StartInfo.WorkingDirectory = workPath;
        p.StartInfo.Arguments = arguments;
        p.StartInfo.UseShellExecute = false;
        p.StartInfo.CreateNoWindow = true;
        p.StartInfo.RedirectStandardOutput = true;
        p.StartInfo.RedirectStandardError = true;
        //p.EnableRaisingEvents = true;
        //p.Exited += ProcessEnded;
        p.OutputDataReceived += new DataReceivedEventHandler(p_OutputDataReceived);
        p.ErrorDataReceived += new DataReceivedEventHandler(p_ErrorDataReceived);

        p.Start();
        //开始异步读取输出
        p.BeginOutputReadLine();
        p.BeginErrorReadLine();
        //调用WaitForExit会等待Exited事件完成后再继续往下执行。
        p.WaitForExit();
        int code = p.ExitCode;
        p.Close();
        if (code != 0)
        {
            MessageBox.Show("错误", $"[{langType}]处理配置表多语言文本替换失败，请前往控制台查看错误信息!");
        }
        MessageBox.Show($"[{langType}]处理配置表多语言文本替换成功!");
    }

    private static void p_ErrorDataReceived(object sender, DataReceivedEventArgs e)
    {

    }

    private static void p_OutputDataReceived(object sender, DataReceivedEventArgs e)
    {

    }
}
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

public static class LanguageTool
{
    public enum eLanguageType
    {
        ZH_CN = 0,  //��������
        ZH_TW,  //��������
        EN_US,  //Ӣ��
        JA_JP,  //����
        KO_KR,  //����
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
        //��ʼ�첽��ȡ���
        p.BeginOutputReadLine();
        p.BeginErrorReadLine();
        //����WaitForExit��ȴ�Exited�¼���ɺ��ټ�������ִ�С�
        p.WaitForExit();
        int code = p.ExitCode;
        p.Close();
        if (code != 0)
        {
            MessageBox.Show("����", $"[{langType}]�������ñ�������ı��滻ʧ�ܣ���ǰ������̨�鿴������Ϣ!");
        }
        MessageBox.Show($"[{langType}]�������ñ�������ı��滻�ɹ�!");
    }

    private static void p_ErrorDataReceived(object sender, DataReceivedEventArgs e)
    {

    }

    private static void p_OutputDataReceived(object sender, DataReceivedEventArgs e)
    {

    }
}
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace HelperTool
{
    public class SVN_Command
    {
        public virtual void RevertFiles(Form window)
        {
            var revertWindow = Process.Start($"TortoiseProc.exe", $"/command:revert /path:{PathConst.RootFolder} /closeonend:3");
            revertWindow.WaitForExit();
            ExcelPathConst.LoadAllExcelData();
        }
        public void OpenExcelPath()
        {
            if (PathConst.RootFolder == null) return;
            Process.Start("explorer.exe", PathConst.RootFolder);
        }

        public void LockFiles(string[] pathsConst)
        {
            string paths = string.Empty;
            foreach (string item in pathsConst)
            {
                paths = String.Concat(paths, $"*{item}");
            }
            Process.Start($"TortoiseProc.exe", $"/command:lock /path:{paths} /closeonend:3");
        }

    }
}

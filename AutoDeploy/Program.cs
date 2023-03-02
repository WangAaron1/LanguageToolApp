using AutoDeploy;
using System;
using System.Windows.Forms;

namespace LanguageToolApp
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new IntroLogin());
        }
    }
}
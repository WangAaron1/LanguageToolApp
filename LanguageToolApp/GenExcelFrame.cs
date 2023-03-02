using Sunny.UI;
using System;
using System.Windows.Forms;

namespace LanguageToolApp
{
    public partial class GenExcelFrame : UIPage
    {
        public GenExcelFrame()
        {
            InitializeComponent();
        }

        private void Fmain_Load(object sender, EventArgs e)
        {

        }

        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            if (transFolderViewer.ShowDialog() == DialogResult.OK)
            {
                tex_transRoot.Text = transFolderViewer.SelectedPath;
            }
        }

        private void uiSymbolButton2_Click(object sender, EventArgs e)
        {
            LanguageTool.eLanguageType type = LanguageTool.eLanguageType.ZH_CN;
            switch (check_languageSelect.SelectedItem.ToString())
            {
                case "ZH_CN":

                    break;
                case "JA_JP":
                    type = LanguageTool.eLanguageType.JA_JP;
                    break;
                case "EN_US":
                    type = LanguageTool.eLanguageType.EN_US;
                    break;
                case "KO_KR":
                    type = LanguageTool.eLanguageType.KO_KR;
                    break;
                case "ZH_TW":
                    type = LanguageTool.eLanguageType.ZH_TW;
                    break;
                default:
                    MessageBox.Show("请选择正确的语言设置");
                    break;
            }
            LanguageTool.Replace(type, tex_transRoot.Text);
        }
    }
}

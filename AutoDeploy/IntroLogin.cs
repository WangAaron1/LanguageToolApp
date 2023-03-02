using HelperTool;
using Sunny.UI;
using System;
using System.IO;
using System.Windows.Forms;

namespace AutoDeploy
{
    public partial class IntroLogin : UIForm
    {
        public static IntroLogin Instance { get; set; }
        private UserDataJsonUtil json_UserData { get; set; }

        public IntroLogin()
        {
            json_UserData = new UserDataJsonUtil();
            if (Instance == null)
            {
                Instance = this;
            }
            this.ControlBox = false;
            InitializeComponent();
            Tex_ExcelPathSetting.Text = json_UserData.GetPath(Environment.UserName);
        }

        private void IntroLogin_Load(object sender, EventArgs e)
        {

        }
        private void Btn_Explore_Click(object sender, EventArgs e)
        {
            if (Bro_ExcelPath.ShowDialog() == DialogResult.OK)
            {
                Tex_ExcelPathSetting.Text = Bro_ExcelPath.SelectedPath;
            }
        }

        private void Btn_Confirm_Click(object sender, EventArgs e)
        {
            json_UserData.CheckUser(Environment.UserName, Tex_ExcelPathSetting.Text);
            json_UserData.Save();
            if (Directory.Exists(Tex_ExcelPathSetting.Text))
            {
                var error = ExcelPathConst.LoadAllExcelData();
                if (error.IsNullOrEmpty())
                {
                    this.Visible = false;
                    new MainIntro().ShowDialog();
                    this.Close();
                }
                MessageBox.Show("请检查Excel是否被占用");
            }
            else
            {
                MessageBox.Show("请选择正确的路径");
            }
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

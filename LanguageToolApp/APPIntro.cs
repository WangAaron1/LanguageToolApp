using Sunny.UI;
using System;
using System.Windows.Forms;

namespace LanguageToolApp
{
    public partial class APPIntro : UIHeaderAsideMainFrame
    {
        public APPIntro()
        {
            InitializeComponent();
            int pageIndex = 1000;
            var genPage = AddPage(new GenExcelFrame());
            var replacePage = AddPage(new ReplaceExcelFrame());

            //设置初始化节点
            TreeNode genExcel = Aside.CreateNewNode("生成Excel (gen)", 61451, 24, pageIndex++, genPage);
            Aside.SelectFirst();
            TreeNode replaceExcel = Aside.CreateNewNode("替换Excel (replace)", 61449, 24, pageIndex++, replacePage);
            TreeNode l2e = Aside.CreateNewNode("lua转AvgExcel", 61450, 24, pageIndex++, replacePage);
            TreeNode diff = Aside.CreateNewNode("找不同", 61456, 24, pageIndex++, replacePage);
        }

        private void MainFrame_Load(object sender, EventArgs e)
        {

        }

        private void Aside_MenuItemClick(TreeNode node, NavMenuItem item, int pageIndex)
        {

        }

        private void Header_MenuItemClick(string itemText, int menuIndex, int pageIndex)
        {

        }

    }
}

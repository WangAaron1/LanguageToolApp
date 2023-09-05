using AutoDeployExcelDataForDesigner;
using Sunny.UI;
using System.Windows.Forms;

namespace AutoDeploy
{
    public partial class MainIntro : UIAsideMainFrame
    {
        public static MainIntro Instance { get; set; }
        public MainIntro()
        {
            if (Instance == null)
            {
                Instance = this;
            }

            InitializeComponent();
            int pageIndex = 1000;
            var skinFrame = AddPage(new SkinFrame());
            var heroDataFrame = AddPage(new HeroDataFrame());
            var battlePassFrame = AddPage(new BattlePassFrame());
#if DEBUG
            var testFrame = AddPage(new TestFrame());
            TreeNode TTTTTestNode = Aside.CreateNewNode("测试用窗口", 61448, 24, pageIndex++, testFrame);
#endif
            //设置初始化节点
            TreeNode battlePassNode = Aside.CreateNewNode("新增战令", 61442, 24, pageIndex++, battlePassFrame);
            Aside.SelectFirst();
            TreeNode skinNode = Aside.CreateNewNode("皮肤配置", 61451, 24, pageIndex++, skinFrame);
            TreeNode heroDataNode = Aside.CreateNewNode("新增角色配置", 61449, 24, pageIndex++, heroDataFrame);
        }

        private void Aside_MenuItemClick(TreeNode node, NavMenuItem item, int pageIndex)
        {

        }

        private void Header_MenuItemClick(string itemText, int menuIndex, int pageIndex)
        {

        }

        private void MainIntro_Load(object sender, System.EventArgs e)
        {

        }
        private void MainIntro_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrameHelper.FlushMemory();
            Application.Exit();
        }
    }
}

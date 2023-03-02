using HelperTool;
using Sunny.UI;

namespace AutoDeploy.UIPages
{
    public partial class TestFrame : UIPage
    {
        public TestFrame()
        {
            InitializeComponent();
            uiTextBox1.Multiline = true;
            uiTextBox1.TextChanged += new System.EventHandler(StringExtension.SetLineMark);

        }

        private void uiSymbolButton1_Click(object sender, System.EventArgs e)
        {
            var skinSheet = ExcelPathConst.e_Skin.WorkSheets.GetWorksheet("skin");
            var skinHeader = skinSheet.GetHeaderDic();
            var text = uiTextBox1.Text.LineProcessor();
            ExcelHelper.SetCell(text, skinSheet.GetRowByID(300101).index, skinHeader["describe"] + 1, ExcelPathConst.e_Skin.WorkSheets?[0], ExcelPathConst.e_Skin.PathInfo, ExcelPathConst.e_Skin.Package);

        }
    }
}

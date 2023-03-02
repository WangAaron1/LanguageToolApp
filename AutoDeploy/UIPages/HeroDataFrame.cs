using AutoDeployExcelDataForDesigner.Scripts.AutoModes;
using HelperTool;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace AutoDeployExcelDataForDesigner
{
    public partial class HeroDataFrame : UIPage
    {
        public static HeroDataFrame Instance;
        public List<Action> DeployActions;
        SVN_Command Svn;

        public HeroDataFrame()
        {
            InitializeComponent();
            Svn = new SVN_Command();
            if (Instance == null)
            {
                Instance = this;
            }

            DeployActions = new List<Action>();

        }

        public HeroDataFrame(bool isLoadData) : this()
        {
            if (isLoadData)
                this.LoadControlData();
        }
        private void CharacterDataFrame_Load(object sender, EventArgs e)
        {
            Instance = this;
            ExcelPathConst.LoadAllExcelData();
            InitUI();

        }
        private void InitUI()
        {
            RowData biggestHeroIdData = ExcelPathConst.e_Herodata.RowDatas.GetMaxNum(1, 1001);
            var biggestID = biggestHeroIdData[0].ToInt32() + 1;
            HeroIDBox.Text = biggestID.ToString();

            HeroZHNameBox.AutoFillInputArea("请输入名称");


        }
        private void RegisterFunctions()
        {
            ///部署配置方法
            DeployActions.Add(HeroDataClass.Deploy_Item);
            DeployActions.Add(HeroDataClass.Deploy_HeroData);
            DeployActions.Add(HeroDataClass.Deploy_HeroData_HeroStarSheet);
            if (!ShipGridView.IsGridEmpty())
                DeployActions.Add(HeroDataClass.Deploy_HeroData_HeroRelationship);
            if (LikeGiftList.CheckedIndices.Count != 0 && HateGiftList.CheckedIndices.Count != 0)
                DeployActions.Add(HeroDataClass.Deploy_HeroData_HeroFriendShipGift);
            DeployActions.Add(HeroDataClass.Deploy_Skin);
            DeployActions.Add(HeroDataClass.Deploy_Protrait);
            DeployActions.Add(HeroDataClass.Deploy_OasisBuilding);

        }

        private void DeployClick(object sender, EventArgs e)
        {
            StringBuilder usedFunctionsNames = new StringBuilder();

            Instance = this;

            RegisterFunctions();

            for (int i = 0; i < DeployActions.Count; i++)
            {
                DeployActions[i].Invoke();
                var type = DeployActions[i].GetMethodInfo();
                usedFunctionsNames.AppendLine(type.Name);
            }

            DeployActions.Clear();
            if (DeployActions?.Count == 0)
            {
                MessageBox.Show($"以下配置表已完成完成:\n{usedFunctionsNames}");
                Svn.OpenExcelPath();
                this.Close();
                FrameHelper.FlushMemory();

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void HeroCompanyBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void HeroDataFrame_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrameHelper.FlushMemory();
            this.SaveControlData();
            ExcelPathConst.DisposeAllExcel();

        }
    }
}

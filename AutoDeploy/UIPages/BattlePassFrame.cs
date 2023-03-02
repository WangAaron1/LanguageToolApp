using AutoDeployExcelDataForDesigner.Scripts.AutoModes;
using AutoDeployExcelDataForDesigner.Scripts.FactoryCenter;
using HelperTool;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AutoDeployExcelDataForDesigner
{
    public partial class BattlePassFrame : UIPage
    {
        private bool IsEndTime;
        private bool IsNextEndTime;
        private bool IsStartTime;
        private bool IsExistID = false;

        private SVN_Command Svn;
        private Queue<Action> DeployActions;
        private List<RowData> HeroIDs;

        public int ActivityLatestID = 0;
        public int HasDeployFuncs = 1;
        public DateTime ActivityTimeStart;
        public DateTime ActivityTimeEnd;
        public DateTime ActivityTimeNextEnd;


        public static BattlePassFrame Instance;

        public BattlePassFrame()
        {
            InitializeComponent();
            DeployActions = new Queue<Action>();
            Svn = new SVN_Command();
            RefreshUI();
            RegisterFunctions();
            if (Instance == null)
            {
                Instance = this;
            }
        }

        public BattlePassFrame(bool isLoadData) : this()
        {
            if (isLoadData)
                this.LoadControlData(RefreshUI);
        }
        private void BattlePassFrame_Load(object sender, EventArgs e)
        {
            HeroID.Text = "1001";
            Svn = new SVN_Command();
            Instance = this;
            HeroIDs = ExcelPathConst.e_Herodata.WorkSheets?[0].GetRowDatas(6);
            CheckHeroIDExist();
        }

        private void RefreshUI()
        {
            ActivityLatestID = 0;

            FillMaxID();
            MuteUiState();

        }

        //算个活动最大ID
        private void FillMaxID()
        {
            var latestId = GameDataCenter.Activity_1_MaXID();
            this.LatestActivityID.Text = string.Format("目前最新活动ID : {0} 下一活动ID : {1}（除开回归活动）", latestId, latestId + 1);
        }

        private void MuteUiState()
        {
            HeadIconIDLabel.Enabled = false;
            InfoPageIDLabel.Enabled = false;
            BPHeroSkinID.Enabled = false;
            BPSkinLabel.Enabled = false;
            FurnitureIDLabel.Enabled = false;
            HeadIconIDLabel.Enabled = false;
            InfoPageIDLabel.Enabled = false;
            FunitureID.Enabled = false;
            HeadIconIDBox.Enabled = false;
            InfoPageIDBox.Enabled = false;
            StartTimelabel.Enabled = false;
            EndTimeLabel.Enabled = false;
            StartTimeBox.Enabled = false;
            EndTimeBox.Enabled = false;
            HeadIconNameBox.Enabled = false;
            BPSkinDesBox.Enabled = false;
            FurnitureNameLabel.Enabled = false;
            HeadIconNameLabel.Enabled = false;
            BPSkinNameLabel.Enabled = false;
            InfoPageNameLabel.Enabled = false;
            BPSkinNameBox.Enabled = false;
            FurnitureNameBox.Enabled = false;
            InfoPageNameBox.Enabled = false;
            NextEndTimeLabel.Enabled = false;
            NextEndTimeBox.Enabled = false;
            BPSkinDesLabel.Enabled = false;
            BPSkinDesBox.Enabled = false;
            HeadIconDesBox.Enabled = false;
            HeadIconDesLabel.Enabled = false;
            InfoPageDesBox.Enabled = false;
            InfoPageDesLabel.Enabled = false;
            FurnitureDesBox.Enabled = false;
            FurnitureDesLabel.Enabled = false;
        }

        public void RegisterFunctions()
        {
            if (DeployActions == null)
                DeployActions = new Queue<Action>();

            DeployActions.Enqueue(BattlePassClass.DeployActivity);
            DeployActions.Enqueue(BattlePassClass.DeployItem);
            DeployActions.Enqueue(BattlePassClass.DeployBattlePass);
            DeployActions.Enqueue(BattlePassClass.DeployHeroData);
            DeployActions.Enqueue(BattlePassClass.DeployProtrait);
            DeployActions.Enqueue(BattlePassClass.DeployPayData);
            DeployActions.Enqueue(BattlePassClass.DeployTipData);
            DeployActions.Enqueue(BattlePassClass.DeployGift);
            DeployActions.Enqueue(BattlePassClass.DeploySkinData);
            DeployActions.Enqueue(BattlePassClass.DeployShopData);

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            if (IsStartTime)
            {
                ActivityTimeStart = monthCalendar1.SelectionEnd;
                ActivityTimeStart = new DateTime(ActivityTimeStart.Year, ActivityTimeStart.Month, ActivityTimeStart.Day, 5, 00, 00);
                StartTimeBox.Text = ActivityTimeStart.ToString();
            }
            else if (IsEndTime)
            {
                ActivityTimeEnd = monthCalendar1.SelectionEnd;
                ActivityTimeEnd = new DateTime(ActivityTimeEnd.Year, ActivityTimeEnd.Month, ActivityTimeEnd.Day, 3, 59, 59);
                EndTimeBox.Text = ActivityTimeEnd.ToString();
            }
            else if (IsNextEndTime)
            {
                ActivityTimeNextEnd = monthCalendar1.SelectionEnd;
                ActivityTimeNextEnd = new DateTime(ActivityTimeNextEnd.Year, ActivityTimeNextEnd.Month, ActivityTimeNextEnd.Day, 3, 59, 59);
                NextEndTimeBox.Text = ActivityTimeNextEnd.ToString();
            }
        }

        public void RegisterCalendar()
        {
            monthCalendar1.Visible = true;
            monthCalendar1.MouseLeave += MonthCalendar_MouseLeave;
        }

        public void CancelCalendar()
        {
            if (IsStartTime)
            {
                monthCalendar1.MinDate = monthCalendar1.SelectionEnd;
            }
            IsStartTime = false;
            IsEndTime = false;
            IsNextEndTime = false;
            monthCalendar1.Visible = false;
            monthCalendar1.MouseLeave -= MonthCalendar_MouseLeave;
        }

        /// <summary>
        /// 接近文本框后显示日期选择 离开后消失
        /// </summary>
        private void StartTimeBox_Click(object sender, EventArgs e)
        {
            monthCalendar1.Location = StartTimeBox.Location + new Size(0, 25);
            monthCalendar1.MinDate = new DateTime(1970, 1, 1);
            IsStartTime = true;
            RegisterCalendar();
        }

        private void EndTimeBox_Click(object sender, EventArgs e)
        {
            monthCalendar1.Location = EndTimeBox.Location + new Size(0, 25);
            IsEndTime = true;
            RegisterCalendar();
        }
        private void NextEndTimeBox_Click(object sender, EventArgs e)
        {
            monthCalendar1.Location = NextEndTimeBox.Location + new Size(0, 25);
            IsNextEndTime = true;
            RegisterCalendar();
        }
        private void MonthCalendar_MouseLeave(object sender, EventArgs e)
        {
            CancelCalendar();
        }


        private void NestID_Click(object sender, EventArgs e)
        {
            if (!IsExistID)
            {
                MessageBox.Show("请先确保HeroID是存在的！");
                return;
            }

            UpdateUI();
            ChangeUIState();
        }


        void ChangeUIState()
        {

            Btn_GenID.Visible = false;

            HeroID.Enabled = false;
            FurnitureNameLabel.Enabled = true;
            HeadIconNameLabel.Enabled = true;
            BPSkinNameLabel.Enabled = true;
            InfoPageNameLabel.Enabled = true;
            HeadIconIDLabel.Enabled = true;
            InfoPageIDLabel.Enabled = true;
            BPHeroSkinID.Enabled = true;
            BPSkinLabel.Enabled = true;
            FurnitureIDLabel.Enabled = true;
            HeadIconIDLabel.Enabled = true;
            InfoPageIDLabel.Enabled = true;
            FunitureID.Enabled = true;
            HeadIconIDBox.Enabled = true;
            InfoPageIDBox.Enabled = true;
            StartTimelabel.Enabled = true;
            EndTimeLabel.Enabled = true;
            StartTimeBox.Enabled = true;
            EndTimeBox.Enabled = true;
            BPSkinNameBox.Enabled = true;
            HeadIconNameBox.Enabled = true;
            FurnitureNameBox.Enabled = true;
            InfoPageNameBox.Enabled = true;

            NextEndTimeLabel.Enabled = true;
            NextEndTimeBox.Enabled = true;
            BPSkinDesLabel.Enabled = true;
            BPSkinDesBox.Enabled = true;
            HeadIconDesBox.Enabled = true;
            HeadIconDesLabel.Enabled = true;
            InfoPageDesBox.Enabled = true;
            InfoPageDesLabel.Enabled = true;
            FurnitureDesBox.Enabled = true;
            FurnitureDesLabel.Enabled = true;
        }
        void UpdateUI()
        {

            //——————————皮肤———————————— 
            if (BattlePassFrame.Instance == null) return;
            BattlePassFrame instance = BattlePassFrame.Instance;
            int _heroID = Convert.ToInt32(instance.HeroID.Text);
            int _baseHeroSkinID = _heroID + 2000;
            string _heroSkinID = _baseHeroSkinID.ToString() + "01";
            int _realId = Convert.ToInt32(_heroSkinID);

            if (ExcelPathConst.e_Item.WorkSheets == null) return;
            List<RowData> itemsData = ExcelPathConst.e_Item.WorkSheets[0].GetRowDatas(6);
            if (itemsData == null) return;
            RowData biggestData = itemsData.GetMaxNum(_baseHeroSkinID, _realId);
            if (biggestData.ColTexts == null) return;
            var biggestID = Convert.ToInt32(biggestData[0]);
            int newestHeroSkinID = biggestID + 1;
            instance.BPHeroSkinID.Text = newestHeroSkinID.ToString();


            //——————————家具———————————— 
            List<RowData> funitureData = ExcelPathConst.e_Item.WorkSheets?.GetWorksheet("item").GetRowDatas(6);
            RowData biggestfunitureData = funitureData.GetMaxNum(721, 721001);
            if (biggestfunitureData.ColTexts == null) return;
            var biggestfunitureID = Convert.ToInt32(biggestfunitureData[0]);
            int newestfunitureID = biggestfunitureID + 1;
            FunitureID.Text = newestfunitureID.ToString();

            //——————————资料页———————————— 
            List<RowData> InfoData = ExcelPathConst.e_Item.WorkSheets?.GetWorksheet("item").GetRowDatas(6);
            RowData biggestInfoData = InfoData.GetMaxNum(410, 410001);
            if (biggestInfoData.ColTexts == null) return;
            var biggestInfoID = Convert.ToInt32(biggestInfoData[0]);
            int newestInfoID = biggestInfoID + 1;
            InfoPageIDBox.Text = newestInfoID.ToString();

            //——————————头像框————————————
            List<RowData> headIconData = ExcelPathConst.e_Item.WorkSheets?[0].GetRowDatas(6);
            RowData biggestHeadFrameData = headIconData.GetMaxNum(400, 400001);
            if (biggestHeadFrameData.ColTexts == null) return;
            var biggestHeadFrameID = Convert.ToInt32(biggestHeadFrameData[0]);
            int newestHeadFrameID = biggestHeadFrameID + 1;
            HeadIconIDBox.Text = newestHeadFrameID.ToString();
        }

        private void HeroID_TextChanged(object sender, EventArgs e)
        {
            CheckHeroIDExist();
        }

        public void CheckHeroIDExist()
        {

            for (int i = 0; i < HeroIDs?.Count; i++)
            {
                if (Convert.ToInt32(HeroID.Text) != Convert.ToInt32(HeroIDs[i][0]))
                {
                    HeroIDlabel.ForeColor = Color.Red;
                    HeroIDlabel.Text = $"该ID不存在!!(范围1001-{HeroIDs[HeroIDs.Count - 1][0]})";
                    HeroID.ForeColor = Color.Red;
                    IsExistID = false;
                }
                else
                {
                    HeroIDlabel.ForeColor = Color.Black;
                    HeroIDlabel.Text = "本期角色";
                    HeroID.ForeColor = Color.Black;
                    IsExistID = true;
                    break;
                }
            }

        }

        private void EndTimeBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void Btn_Deploy_Click(object sender, EventArgs e)
        {
            if (HeroID.Text == "" || BPHeroSkinID.Text == "" || FunitureID.Text == "" || HeadIconIDBox.Text == "" || InfoPageIDBox.Text == "" || StartTimeBox.Text == "" || EndTimeBox.Text == "")
            {
                MessageBox.Show("请先确保所有ID填写正确！");
                return;
            }
            if (!IsExistID)
            {
                MessageBox.Show("请先确保HeroID是存在的！");
                return;
            }
            ///解耦用回调
            BaseFactory.FramBeginDeploy?.Invoke();

            int functionsCount = DeployActions.Count;
            for (int i = 0; i < functionsCount; i++)
            {
                DeployActions.Dequeue().Invoke();
            }
            if (HasDeployFuncs <= DeployActions?.Count)
            {
                HasDeployFuncs++;
                RefreshUI();
            }

            this.SaveControlData();

            if (DeployActions?.Count == 0)
            {
                MessageBox.Show("配置完成");
                Svn.OpenExcelPath();
                ExcelPathConst.LoadAllExcelData();
                RegisterFunctions();
            }
        }

        private void BattlePassFrame_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void BattlePassFrame_FormClosing(object sender, FormClosingEventArgs e)
        {
            ExcelPathConst.DisposeAllExcel();
        }
    }
}

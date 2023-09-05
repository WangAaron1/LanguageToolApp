using AutoDeployExcelDataForDesigner.Scripts.AutoModes;
using HelperTool;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AutoDeployExcelDataForDesigner
{
    public partial class SkinFrame : UIPage
    {
        public static SkinFrame Instance;

        private Queue<Action<int, string, string, string, string, int, bool>> DeployActions;

        private SVN_Command SVN;

        public SkinFrame()
        {
            InitializeComponent();
            InitUI();
            SVN = new SVN_Command();
            DeployActions = new Queue<Action<int, string, string, string, string, int, bool>>();
            if (Instance == null)
            {
                Instance = this;
            }
        }

        public SkinFrame(bool isLoadData) : this()
        {

            if (isLoadData)
                this.LoadControlData();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SkinFrame_Load(object sender, EventArgs e)
        {
            Instance = this;
            ExcelPathConst.LoadAllExcelData();
        }
        void InitUI()
        {

            ///初始化设置
            HaveTheEx.FalseValue = false;
            HaveTheEx.TrueValue = true;
            HaveTheEx.IndeterminateValue = false;

            ///部署UI
            SkinBoxName.AutoFillInputArea("请输入皮肤主题名称");
            SkinBoxDes.AutoFillInputArea("请输入主题描述");
            SkinTip.AutoFillInputArea();
            textBox1.AutoFillInputArea();

            //
            InitDataGridView();
        }

        private void RegisterFunctions()
        {

            ///部署配置方法
            DeployActions.Enqueue(SkinClass.DeployItem);
            DeployActions.Enqueue(SkinClass.DeploySkinData);
            DeployActions.Enqueue(SkinClass.DeployHeroData);
            DeployActions.Enqueue(SkinClass.DeployShopData);
        }

        private void InitDataGridView()
        {
            // 创建DataGridViewComboBoxColumn对象
            DataGridViewComboBoxColumn cmbColumn = new DataGridViewComboBoxColumn();
            // 设置下拉框的数据源
            cmbColumn.DataSource = new int[] { 58, 68, 78 };
            cmbColumn.Name = "CurrentPrice";
            cmbColumn.ValueType = typeof(int);
            // 添加到DataGridView控件中
            Skindatas.Columns.Insert(3, cmbColumn);
            Skindatas.Columns[3].HeaderText = "当前价位";

            //列的数据可以插入换行的
            Skindatas.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithAutoHeaderText;

        }



        /// <summary>
        /// 配置按钮按下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeployButton_Click(object sender, EventArgs e)
        {
            try
            {
                RegisterFunctions();
                List<RowData> rowDatas = Skindatas.ConvertDataGrid2RowData();
                if (rowDatas.Count == 0)
                {
                    MessageBox.Show("请至少有一行数据填入");
                    return;
                }

                int functionCount = DeployActions.Count;

                for (int t = 0; t < rowDatas.Count; t++)
                {
                    var row = rowDatas[t];
                    functionCount = DeployActions.Count;
                    for (int i = 0; i < functionCount; i++)
                    {
                        if (row[0] == null) row[0] = 1001;
                        var heroId = row[0].ToInt32();
                        string heroSkinName = null;
                        string skinDes = null;
                        string currentPrice = null;
                        string achieve = null;
                        bool haveMovie = false;
                        if (row[4] != null)
                            haveMovie = (bool)row[4];
                        ///防止不填写Live2D
                        if (row[5] == null) row[5] = 0;
                        var live2dLevel = Convert.ToInt32(row[5]);

                        if (row[1] != null) heroSkinName = row[1].ToString();
                        if (row[2] != null) skinDes = row[2].ToString().LineProcessor();
                        if (row[3] != null) currentPrice = row[3].ToString();
                        if (row[6] != null) achieve = row[6].ToString();

                        if (achieve == string.Empty || achieve == null) achieve = "";
                        if (heroSkinName == null || skinDes == null || currentPrice == null || achieve == null)
                        {
                            MessageBox.Show("至少一行内的各项数据不能是空的");
                            return;
                        }
                        DeployActions.Dequeue().Invoke(heroId, heroSkinName, skinDes, currentPrice, achieve, live2dLevel, haveMovie);

                    }
                    RegisterFunctions();
                }
                if (!string.IsNullOrEmpty(SkinBoxName.Text) || !string.IsNullOrEmpty(Instance.SkinBoxDes.Text))
                {
                    SkinClass.DeployTheme();
                }

                if (MessageBox.Show("配置完成", "ok") == DialogResult.OK)
                {
                    RegisterFunctions();
                    SVN.OpenExcelPath();
                }
            }
            catch (Exception ce)
            {
                this.SaveControlData();
                if (MessageBox.Show("配置异常,请重新开启") == DialogResult.OK)
                {
                    Close();
                }
            }
        }

        private void monthSelectMode1_Load(object sender, EventArgs e)
        {

        }

        private void SkinBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void SkinFrame_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrameHelper.FlushMemory();
            ExcelPathConst.DisposeAllExcel();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SkinFrame_Initialize(object sender, EventArgs e)
        {

        }

        private void SkinTip_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

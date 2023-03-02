
namespace ADBPushApkTool
{
    partial class ApkPush_Tool
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApkPush_Tool));
            this.selectApk = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.Devices = new System.Windows.Forms.ComboBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.selectRAR = new System.Windows.Forms.OpenFileDialog();
            this.CmdInfoWin = new System.Windows.Forms.TextBox();
            this.BundleNames = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SimulatorsCheckPoint = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.Btn_InstallApk = new Sunny.UI.UISymbolButton();
            this.Btn_TarandPush = new Sunny.UI.UISymbolButton();
            this.Btn_Push = new Sunny.UI.UISymbolButton();
            this.Btn_LasyPush = new Sunny.UI.UISymbolButton();
            this.Btn_Connect2Sim = new Sunny.UI.UISymbolButton();
            this.SuspendLayout();
            // 
            // selectApk
            // 
            this.selectApk.FileName = "apkFileSelect";
            this.selectApk.Filter = "|*.apk";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "目前所选的设备";
            // 
            // Devices
            // 
            this.Devices.DisplayMember = "未检测到头为sunborn的包体";
            this.Devices.FormattingEnabled = true;
            this.Devices.Items.AddRange(new object[] {
            "未检测到设备"});
            this.Devices.Location = new System.Drawing.Point(9, 64);
            this.Devices.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Devices.Name = "Devices";
            this.Devices.Size = new System.Drawing.Size(179, 29);
            this.Devices.TabIndex = 6;
            this.Devices.ValueMember = "未检测到头为sunborn的包体";
            this.Devices.SelectedIndexChanged += new System.EventHandler(this.Devices_SelectedIndexChanged);
            // 
            // selectRAR
            // 
            this.selectRAR.FileName = "selectRAR";
            this.selectRAR.Filter = "*.rar,*.zip|";
            // 
            // CmdInfoWin
            // 
            this.CmdInfoWin.AllowDrop = true;
            this.CmdInfoWin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CmdInfoWin.Location = new System.Drawing.Point(218, 49);
            this.CmdInfoWin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmdInfoWin.Multiline = true;
            this.CmdInfoWin.Name = "CmdInfoWin";
            this.CmdInfoWin.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.CmdInfoWin.Size = new System.Drawing.Size(576, 356);
            this.CmdInfoWin.TabIndex = 10;
            this.CmdInfoWin.TextChanged += new System.EventHandler(this.CmdInfoWin_TextChanged);
            // 
            // BundleNames
            // 
            this.BundleNames.DisplayMember = "未检测到头为sunborn的包体";
            this.BundleNames.FormattingEnabled = true;
            this.BundleNames.Items.AddRange(new object[] {
            "未检测到头为sunborn的包体"});
            this.BundleNames.Location = new System.Drawing.Point(9, 118);
            this.BundleNames.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BundleNames.Name = "BundleNames";
            this.BundleNames.Size = new System.Drawing.Size(179, 29);
            this.BundleNames.TabIndex = 11;
            this.BundleNames.ValueMember = "未检测到头为sunborn的包体";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 21);
            this.label3.TabIndex = 12;
            this.label3.Text = "设备中所含包体";
            // 
            // SimulatorsCheckPoint
            // 
            this.SimulatorsCheckPoint.DisplayMember = "未检测到头为sunborn的包体";
            this.SimulatorsCheckPoint.FormattingEnabled = true;
            this.SimulatorsCheckPoint.Items.AddRange(new object[] {
            "7555(MuMu)",
            "62001(夜神)",
            "26944(海马)",
            "21503(逍遥)",
            "6555(天天)",
            "5555(雷电)"});
            this.SimulatorsCheckPoint.Location = new System.Drawing.Point(10, 314);
            this.SimulatorsCheckPoint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SimulatorsCheckPoint.Name = "SimulatorsCheckPoint";
            this.SimulatorsCheckPoint.Size = new System.Drawing.Size(178, 29);
            this.SimulatorsCheckPoint.TabIndex = 14;
            this.SimulatorsCheckPoint.Text = "7555(MuMu)";
            this.SimulatorsCheckPoint.ValueMember = "未检测到头为sunborn的包体";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 21);
            this.label5.TabIndex = 15;
            this.label5.Text = "选择要连接的模拟器";
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.Location = new System.Drawing.Point(5, 384);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(146, 21);
            this.uiLabel1.Style = Sunny.UI.UIStyle.Gray;
            this.uiLabel1.TabIndex = 16;
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // Btn_InstallApk
            // 
            this.Btn_InstallApk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_InstallApk.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.Btn_InstallApk.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.Btn_InstallApk.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.Btn_InstallApk.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.Btn_InstallApk.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.Btn_InstallApk.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_InstallApk.Location = new System.Drawing.Point(9, 152);
            this.Btn_InstallApk.MinimumSize = new System.Drawing.Size(1, 1);
            this.Btn_InstallApk.Name = "Btn_InstallApk";
            this.Btn_InstallApk.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.Btn_InstallApk.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.Btn_InstallApk.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.Btn_InstallApk.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.Btn_InstallApk.Size = new System.Drawing.Size(179, 29);
            this.Btn_InstallApk.Style = Sunny.UI.UIStyle.Gray;
            this.Btn_InstallApk.Symbol = 362831;
            this.Btn_InstallApk.SymbolOffset = new System.Drawing.Point(-11, 0);
            this.Btn_InstallApk.TabIndex = 17;
            this.Btn_InstallApk.Text = "选择Apk安装  ";
            this.Btn_InstallApk.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_InstallApk.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.Btn_InstallApk.Click += new System.EventHandler(this.Btn_InstallApk_Click);
            // 
            // Btn_TarandPush
            // 
            this.Btn_TarandPush.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_TarandPush.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.Btn_TarandPush.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.Btn_TarandPush.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.Btn_TarandPush.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.Btn_TarandPush.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.Btn_TarandPush.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_TarandPush.Location = new System.Drawing.Point(10, 222);
            this.Btn_TarandPush.MinimumSize = new System.Drawing.Size(1, 1);
            this.Btn_TarandPush.Name = "Btn_TarandPush";
            this.Btn_TarandPush.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.Btn_TarandPush.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.Btn_TarandPush.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.Btn_TarandPush.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.Btn_TarandPush.Size = new System.Drawing.Size(179, 29);
            this.Btn_TarandPush.Style = Sunny.UI.UIStyle.Gray;
            this.Btn_TarandPush.Symbol = 362830;
            this.Btn_TarandPush.TabIndex = 18;
            this.Btn_TarandPush.Text = "分包解压+Push";
            this.Btn_TarandPush.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_TarandPush.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.Btn_TarandPush.Click += new System.EventHandler(this.Btn_TarandPush_Click);
            // 
            // Btn_Push
            // 
            this.Btn_Push.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Push.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.Btn_Push.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.Btn_Push.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.Btn_Push.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.Btn_Push.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.Btn_Push.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Push.Location = new System.Drawing.Point(9, 187);
            this.Btn_Push.MinimumSize = new System.Drawing.Size(1, 1);
            this.Btn_Push.Name = "Btn_Push";
            this.Btn_Push.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.Btn_Push.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.Btn_Push.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.Btn_Push.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.Btn_Push.Size = new System.Drawing.Size(179, 29);
            this.Btn_Push.Style = Sunny.UI.UIStyle.Gray;
            this.Btn_Push.Symbol = 362836;
            this.Btn_Push.SymbolOffset = new System.Drawing.Point(-37, 0);
            this.Btn_Push.TabIndex = 19;
            this.Btn_Push.Text = "Push";
            this.Btn_Push.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Push.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.Btn_Push.Click += new System.EventHandler(this.Btn_Push_Click);
            // 
            // Btn_LasyPush
            // 
            this.Btn_LasyPush.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_LasyPush.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.Btn_LasyPush.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.Btn_LasyPush.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.Btn_LasyPush.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.Btn_LasyPush.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.Btn_LasyPush.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_LasyPush.Location = new System.Drawing.Point(10, 259);
            this.Btn_LasyPush.MinimumSize = new System.Drawing.Size(1, 1);
            this.Btn_LasyPush.Name = "Btn_LasyPush";
            this.Btn_LasyPush.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.Btn_LasyPush.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.Btn_LasyPush.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.Btn_LasyPush.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.Btn_LasyPush.Size = new System.Drawing.Size(179, 29);
            this.Btn_LasyPush.Style = Sunny.UI.UIStyle.Gray;
            this.Btn_LasyPush.Symbol = 362973;
            this.Btn_LasyPush.SymbolOffset = new System.Drawing.Point(5, 0);
            this.Btn_LasyPush.TabIndex = 20;
            this.Btn_LasyPush.Text = "安装+解压+Push";
            this.Btn_LasyPush.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_LasyPush.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.Btn_LasyPush.Click += new System.EventHandler(this.Btn_LasyPush_Click);
            // 
            // Btn_Connect2Sim
            // 
            this.Btn_Connect2Sim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Connect2Sim.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.Btn_Connect2Sim.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.Btn_Connect2Sim.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.Btn_Connect2Sim.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.Btn_Connect2Sim.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.Btn_Connect2Sim.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Connect2Sim.Location = new System.Drawing.Point(9, 352);
            this.Btn_Connect2Sim.MinimumSize = new System.Drawing.Size(1, 1);
            this.Btn_Connect2Sim.Name = "Btn_Connect2Sim";
            this.Btn_Connect2Sim.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.Btn_Connect2Sim.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.Btn_Connect2Sim.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.Btn_Connect2Sim.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.Btn_Connect2Sim.Size = new System.Drawing.Size(179, 29);
            this.Btn_Connect2Sim.Style = Sunny.UI.UIStyle.Gray;
            this.Btn_Connect2Sim.Symbol = 361723;
            this.Btn_Connect2Sim.TabIndex = 21;
            this.Btn_Connect2Sim.Text = "连接至指定模拟器";
            this.Btn_Connect2Sim.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Connect2Sim.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.Btn_Connect2Sim.Click += new System.EventHandler(this.Btn_Connect2Sim_Click);
            // 
            // ApkPush_Tool
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(805, 419);
            this.ControlBoxFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.Controls.Add(this.Btn_Connect2Sim);
            this.Controls.Add(this.Btn_LasyPush);
            this.Controls.Add(this.Btn_Push);
            this.Controls.Add(this.Btn_TarandPush);
            this.Controls.Add(this.Btn_InstallApk);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SimulatorsCheckPoint);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BundleNames);
            this.Controls.Add(this.CmdInfoWin);
            this.Controls.Add(this.Devices);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(630, 236);
            this.Name = "ApkPush_Tool";
            this.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.Style = Sunny.UI.UIStyle.Gray;
            this.Text = "ApkPush_Tool";
            this.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 669, 354);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.OpenFileDialog selectApk;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBox3;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog selectRAR;
        public System.Windows.Forms.TextBox CmdInfoWin;
        private System.Windows.Forms.ComboBox BundleNames;
        public System.Windows.Forms.ComboBox Devices;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox SimulatorsCheckPoint;
        public System.Windows.Forms.Label label5;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UISymbolButton Btn_InstallApk;
        private Sunny.UI.UISymbolButton Btn_TarandPush;
        private Sunny.UI.UISymbolButton Btn_Push;
        private Sunny.UI.UISymbolButton Btn_LasyPush;
        private Sunny.UI.UISymbolButton Btn_Connect2Sim;
    }
}


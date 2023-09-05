using System.Windows.Forms;

namespace AutoDeployExcelDataForDesigner
{
    partial class BattlePassFrame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.StartTimelabel = new System.Windows.Forms.Label();
            this.EndTimeLabel = new System.Windows.Forms.Label();
            this.StartTimeBox = new System.Windows.Forms.TextBox();
            this.EndTimeBox = new System.Windows.Forms.TextBox();
            this.LatestActivityID = new System.Windows.Forms.Label();
            this.HeroIDlabel = new System.Windows.Forms.Label();
            this.HeroID = new System.Windows.Forms.TextBox();
            this.BPHeroSkinID = new System.Windows.Forms.TextBox();
            this.BPSkinLabel = new System.Windows.Forms.Label();
            this.HeadIconIDLabel = new System.Windows.Forms.Label();
            this.FurnitureIDLabel = new System.Windows.Forms.Label();
            this.InfoPageIDLabel = new System.Windows.Forms.Label();
            this.FunitureID = new System.Windows.Forms.TextBox();
            this.HeadIconIDBox = new System.Windows.Forms.TextBox();
            this.InfoPageIDBox = new System.Windows.Forms.TextBox();
            this.Btn_Deploy = new System.Windows.Forms.Button();
            this.FurnitureNameBox = new System.Windows.Forms.TextBox();
            this.FurnitureNameLabel = new System.Windows.Forms.Label();
            this.HeadIconNameBox = new System.Windows.Forms.TextBox();
            this.HeadIconNameLabel = new System.Windows.Forms.Label();
            this.BPSkinNameBox = new System.Windows.Forms.TextBox();
            this.BPSkinNameLabel = new System.Windows.Forms.Label();
            this.InfoPageNameBox = new System.Windows.Forms.TextBox();
            this.InfoPageNameLabel = new System.Windows.Forms.Label();
            this.BPSkinDesBox = new System.Windows.Forms.TextBox();
            this.BPSkinDesLabel = new System.Windows.Forms.Label();
            this.FurnitureDesLabel = new System.Windows.Forms.Label();
            this.FurnitureDesBox = new System.Windows.Forms.TextBox();
            this.HeadIconDesLabel = new System.Windows.Forms.Label();
            this.HeadIconDesBox = new System.Windows.Forms.TextBox();
            this.InfoPageDesLabel = new System.Windows.Forms.Label();
            this.InfoPageDesBox = new System.Windows.Forms.TextBox();
            this.NextEndTimeBox = new System.Windows.Forms.TextBox();
            this.NextEndTimeLabel = new System.Windows.Forms.Label();
            this.Btn_GenID = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.Color.Aqua;
            this.monthCalendar1.Location = new System.Drawing.Point(11, 275);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(0);
            this.monthCalendar1.MaxSelectionCount = 1111;
            this.monthCalendar1.MinDate = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.SelectionRange = new System.Windows.Forms.SelectionRange(new System.DateTime(2022, 11, 12, 0, 0, 0, 0), new System.DateTime(2022, 11, 18, 0, 0, 0, 0));
            this.monthCalendar1.ShowToday = false;
            this.monthCalendar1.ShowTodayCircle = false;
            this.monthCalendar1.TabIndex = 1;
            this.monthCalendar1.Visible = false;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // StartTimelabel
            // 
            this.StartTimelabel.AutoSize = true;
            this.StartTimelabel.Location = new System.Drawing.Point(143, 30);
            this.StartTimelabel.Name = "StartTimelabel";
            this.StartTimelabel.Size = new System.Drawing.Size(106, 21);
            this.StartTimelabel.TabIndex = 2;
            this.StartTimelabel.Text = "活动开始日期";
            // 
            // EndTimeLabel
            // 
            this.EndTimeLabel.AutoSize = true;
            this.EndTimeLabel.Location = new System.Drawing.Point(338, 30);
            this.EndTimeLabel.Name = "EndTimeLabel";
            this.EndTimeLabel.Size = new System.Drawing.Size(106, 21);
            this.EndTimeLabel.TabIndex = 3;
            this.EndTimeLabel.Text = "活动结束日期";
            // 
            // StartTimeBox
            // 
            this.StartTimeBox.Location = new System.Drawing.Point(147, 53);
            this.StartTimeBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StartTimeBox.Name = "StartTimeBox";
            this.StartTimeBox.Size = new System.Drawing.Size(185, 29);
            this.StartTimeBox.TabIndex = 4;
            this.StartTimeBox.Click += new System.EventHandler(this.StartTimeBox_Click);
            // 
            // EndTimeBox
            // 
            this.EndTimeBox.Location = new System.Drawing.Point(342, 53);
            this.EndTimeBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EndTimeBox.Name = "EndTimeBox";
            this.EndTimeBox.Size = new System.Drawing.Size(185, 29);
            this.EndTimeBox.TabIndex = 5;
            this.EndTimeBox.Click += new System.EventHandler(this.EndTimeBox_Click);
            this.EndTimeBox.TextChanged += new System.EventHandler(this.EndTimeBox_TextChanged);
            // 
            // LatestActivityID
            // 
            this.LatestActivityID.AutoSize = true;
            this.LatestActivityID.Location = new System.Drawing.Point(7, 6);
            this.LatestActivityID.Name = "LatestActivityID";
            this.LatestActivityID.Size = new System.Drawing.Size(403, 21);
            this.LatestActivityID.TabIndex = 6;
            this.LatestActivityID.Text = "目前最新活动ID : {0} 下一活动ID : {1}（除开回归活动）";
            // 
            // HeroIDlabel
            // 
            this.HeroIDlabel.AutoSize = true;
            this.HeroIDlabel.Location = new System.Drawing.Point(12, 30);
            this.HeroIDlabel.Name = "HeroIDlabel";
            this.HeroIDlabel.Size = new System.Drawing.Size(74, 21);
            this.HeroIDlabel.TabIndex = 10;
            this.HeroIDlabel.Text = "本期角色";
            // 
            // HeroID
            // 
            this.HeroID.Location = new System.Drawing.Point(11, 53);
            this.HeroID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HeroID.Name = "HeroID";
            this.HeroID.Size = new System.Drawing.Size(82, 29);
            this.HeroID.TabIndex = 11;
            this.HeroID.Text = "1001";
            this.HeroID.TextChanged += new System.EventHandler(this.HeroID_TextChanged);
            // 
            // BPHeroSkinID
            // 
            this.BPHeroSkinID.BackColor = System.Drawing.Color.White;
            this.BPHeroSkinID.Location = new System.Drawing.Point(11, 119);
            this.BPHeroSkinID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BPHeroSkinID.Name = "BPHeroSkinID";
            this.BPHeroSkinID.Size = new System.Drawing.Size(83, 29);
            this.BPHeroSkinID.TabIndex = 13;
            this.BPHeroSkinID.Text = "1001";
            // 
            // BPSkinLabel
            // 
            this.BPSkinLabel.AutoSize = true;
            this.BPSkinLabel.Location = new System.Drawing.Point(7, 91);
            this.BPSkinLabel.Name = "BPSkinLabel";
            this.BPSkinLabel.Size = new System.Drawing.Size(59, 21);
            this.BPSkinLabel.TabIndex = 12;
            this.BPSkinLabel.Text = "皮肤ID";
            // 
            // HeadIconIDLabel
            // 
            this.HeadIconIDLabel.AutoSize = true;
            this.HeadIconIDLabel.Location = new System.Drawing.Point(375, 91);
            this.HeadIconIDLabel.Name = "HeadIconIDLabel";
            this.HeadIconIDLabel.Size = new System.Drawing.Size(58, 21);
            this.HeadIconIDLabel.TabIndex = 14;
            this.HeadIconIDLabel.Text = "头像框";
            // 
            // FurnitureIDLabel
            // 
            this.FurnitureIDLabel.AutoSize = true;
            this.FurnitureIDLabel.Location = new System.Drawing.Point(195, 91);
            this.FurnitureIDLabel.Name = "FurnitureIDLabel";
            this.FurnitureIDLabel.Size = new System.Drawing.Size(42, 21);
            this.FurnitureIDLabel.TabIndex = 15;
            this.FurnitureIDLabel.Text = "家具";
            // 
            // InfoPageIDLabel
            // 
            this.InfoPageIDLabel.AutoSize = true;
            this.InfoPageIDLabel.Location = new System.Drawing.Point(564, 91);
            this.InfoPageIDLabel.Name = "InfoPageIDLabel";
            this.InfoPageIDLabel.Size = new System.Drawing.Size(58, 21);
            this.InfoPageIDLabel.TabIndex = 16;
            this.InfoPageIDLabel.Text = "资料页";
            // 
            // FunitureID
            // 
            this.FunitureID.BackColor = System.Drawing.Color.White;
            this.FunitureID.Location = new System.Drawing.Point(199, 119);
            this.FunitureID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FunitureID.Name = "FunitureID";
            this.FunitureID.Size = new System.Drawing.Size(72, 29);
            this.FunitureID.TabIndex = 17;
            this.FunitureID.Text = "1001";
            // 
            // HeadIconIDBox
            // 
            this.HeadIconIDBox.BackColor = System.Drawing.Color.White;
            this.HeadIconIDBox.Location = new System.Drawing.Point(379, 119);
            this.HeadIconIDBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HeadIconIDBox.Name = "HeadIconIDBox";
            this.HeadIconIDBox.Size = new System.Drawing.Size(84, 29);
            this.HeadIconIDBox.TabIndex = 18;
            this.HeadIconIDBox.Text = "1001";
            // 
            // InfoPageIDBox
            // 
            this.InfoPageIDBox.BackColor = System.Drawing.Color.White;
            this.InfoPageIDBox.Location = new System.Drawing.Point(568, 119);
            this.InfoPageIDBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InfoPageIDBox.Name = "InfoPageIDBox";
            this.InfoPageIDBox.Size = new System.Drawing.Size(83, 29);
            this.InfoPageIDBox.TabIndex = 19;
            this.InfoPageIDBox.Text = "1001";
            // 
            // Btn_Deploy
            // 
            this.Btn_Deploy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_Deploy.Location = new System.Drawing.Point(623, 358);
            this.Btn_Deploy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Deploy.Name = "Btn_Deploy";
            this.Btn_Deploy.Size = new System.Drawing.Size(116, 35);
            this.Btn_Deploy.TabIndex = 21;
            this.Btn_Deploy.Text = "配置";
            this.Btn_Deploy.UseVisualStyleBackColor = true;
            this.Btn_Deploy.Click += new System.EventHandler(this.Btn_Deploy_Click);
            // 
            // FurnitureNameBox
            // 
            this.FurnitureNameBox.BackColor = System.Drawing.Color.White;
            this.FurnitureNameBox.Location = new System.Drawing.Point(277, 119);
            this.FurnitureNameBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FurnitureNameBox.Name = "FurnitureNameBox";
            this.FurnitureNameBox.Size = new System.Drawing.Size(93, 29);
            this.FurnitureNameBox.TabIndex = 23;
            this.FurnitureNameBox.Text = "BP临时";
            // 
            // FurnitureNameLabel
            // 
            this.FurnitureNameLabel.AutoSize = true;
            this.FurnitureNameLabel.Location = new System.Drawing.Point(273, 91);
            this.FurnitureNameLabel.Name = "FurnitureNameLabel";
            this.FurnitureNameLabel.Size = new System.Drawing.Size(90, 21);
            this.FurnitureNameLabel.TabIndex = 22;
            this.FurnitureNameLabel.Text = "家具包装名";
            // 
            // HeadIconNameBox
            // 
            this.HeadIconNameBox.BackColor = System.Drawing.Color.White;
            this.HeadIconNameBox.Location = new System.Drawing.Point(469, 119);
            this.HeadIconNameBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HeadIconNameBox.Name = "HeadIconNameBox";
            this.HeadIconNameBox.Size = new System.Drawing.Size(93, 29);
            this.HeadIconNameBox.TabIndex = 25;
            this.HeadIconNameBox.Text = "BP临时";
            // 
            // HeadIconNameLabel
            // 
            this.HeadIconNameLabel.AutoSize = true;
            this.HeadIconNameLabel.Location = new System.Drawing.Point(465, 91);
            this.HeadIconNameLabel.Name = "HeadIconNameLabel";
            this.HeadIconNameLabel.Size = new System.Drawing.Size(90, 21);
            this.HeadIconNameLabel.TabIndex = 24;
            this.HeadIconNameLabel.Text = "头像框包装";
            // 
            // BPSkinNameBox
            // 
            this.BPSkinNameBox.BackColor = System.Drawing.Color.White;
            this.BPSkinNameBox.Location = new System.Drawing.Point(100, 119);
            this.BPSkinNameBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BPSkinNameBox.Name = "BPSkinNameBox";
            this.BPSkinNameBox.Size = new System.Drawing.Size(93, 29);
            this.BPSkinNameBox.TabIndex = 27;
            this.BPSkinNameBox.Text = "BP临时";
            // 
            // BPSkinNameLabel
            // 
            this.BPSkinNameLabel.AutoSize = true;
            this.BPSkinNameLabel.Location = new System.Drawing.Point(96, 91);
            this.BPSkinNameLabel.Name = "BPSkinNameLabel";
            this.BPSkinNameLabel.Size = new System.Drawing.Size(58, 21);
            this.BPSkinNameLabel.TabIndex = 26;
            this.BPSkinNameLabel.Text = "皮肤名";
            // 
            // InfoPageNameBox
            // 
            this.InfoPageNameBox.BackColor = System.Drawing.Color.White;
            this.InfoPageNameBox.Location = new System.Drawing.Point(657, 119);
            this.InfoPageNameBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InfoPageNameBox.Name = "InfoPageNameBox";
            this.InfoPageNameBox.Size = new System.Drawing.Size(93, 29);
            this.InfoPageNameBox.TabIndex = 29;
            this.InfoPageNameBox.Text = "BP临时";
            // 
            // InfoPageNameLabel
            // 
            this.InfoPageNameLabel.AutoSize = true;
            this.InfoPageNameLabel.Location = new System.Drawing.Point(653, 91);
            this.InfoPageNameLabel.Name = "InfoPageNameLabel";
            this.InfoPageNameLabel.Size = new System.Drawing.Size(90, 21);
            this.InfoPageNameLabel.TabIndex = 28;
            this.InfoPageNameLabel.Text = "资料页包装";
            // 
            // BPSkinDesBox
            // 
            this.BPSkinDesBox.Location = new System.Drawing.Point(11, 175);
            this.BPSkinDesBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BPSkinDesBox.Multiline = true;
            this.BPSkinDesBox.Name = "BPSkinDesBox";
            this.BPSkinDesBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.BPSkinDesBox.Size = new System.Drawing.Size(182, 89);
            this.BPSkinDesBox.TabIndex = 30;
            this.BPSkinDesBox.Text = "BP临时";
            // 
            // BPSkinDesLabel
            // 
            this.BPSkinDesLabel.AutoSize = true;
            this.BPSkinDesLabel.Location = new System.Drawing.Point(11, 152);
            this.BPSkinDesLabel.Name = "BPSkinDesLabel";
            this.BPSkinDesLabel.Size = new System.Drawing.Size(126, 21);
            this.BPSkinDesLabel.TabIndex = 31;
            this.BPSkinDesLabel.Text = "BP皮肤包装描述";
            // 
            // FurnitureDesLabel
            // 
            this.FurnitureDesLabel.AutoSize = true;
            this.FurnitureDesLabel.Location = new System.Drawing.Point(199, 152);
            this.FurnitureDesLabel.Name = "FurnitureDesLabel";
            this.FurnitureDesLabel.Size = new System.Drawing.Size(106, 21);
            this.FurnitureDesLabel.TabIndex = 33;
            this.FurnitureDesLabel.Text = "家具包装描述";
            // 
            // FurnitureDesBox
            // 
            this.FurnitureDesBox.Location = new System.Drawing.Point(199, 175);
            this.FurnitureDesBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FurnitureDesBox.Multiline = true;
            this.FurnitureDesBox.Name = "FurnitureDesBox";
            this.FurnitureDesBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.FurnitureDesBox.Size = new System.Drawing.Size(171, 89);
            this.FurnitureDesBox.TabIndex = 32;
            this.FurnitureDesBox.Text = "BP临时";
            // 
            // HeadIconDesLabel
            // 
            this.HeadIconDesLabel.AutoSize = true;
            this.HeadIconDesLabel.Location = new System.Drawing.Point(375, 152);
            this.HeadIconDesLabel.Name = "HeadIconDesLabel";
            this.HeadIconDesLabel.Size = new System.Drawing.Size(122, 21);
            this.HeadIconDesLabel.TabIndex = 35;
            this.HeadIconDesLabel.Text = "头像框包装描述";
            // 
            // HeadIconDesBox
            // 
            this.HeadIconDesBox.Location = new System.Drawing.Point(375, 176);
            this.HeadIconDesBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HeadIconDesBox.Multiline = true;
            this.HeadIconDesBox.Name = "HeadIconDesBox";
            this.HeadIconDesBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.HeadIconDesBox.Size = new System.Drawing.Size(187, 89);
            this.HeadIconDesBox.TabIndex = 34;
            this.HeadIconDesBox.Text = "BP临时";
            // 
            // InfoPageDesLabel
            // 
            this.InfoPageDesLabel.AutoSize = true;
            this.InfoPageDesLabel.Location = new System.Drawing.Point(568, 151);
            this.InfoPageDesLabel.Name = "InfoPageDesLabel";
            this.InfoPageDesLabel.Size = new System.Drawing.Size(122, 21);
            this.InfoPageDesLabel.TabIndex = 37;
            this.InfoPageDesLabel.Text = "资料页包装描述";
            // 
            // InfoPageDesBox
            // 
            this.InfoPageDesBox.Location = new System.Drawing.Point(568, 175);
            this.InfoPageDesBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InfoPageDesBox.Multiline = true;
            this.InfoPageDesBox.Name = "InfoPageDesBox";
            this.InfoPageDesBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.InfoPageDesBox.Size = new System.Drawing.Size(182, 89);
            this.InfoPageDesBox.TabIndex = 36;
            this.InfoPageDesBox.Text = "BP临时";
            // 
            // NextEndTimeBox
            // 
            this.NextEndTimeBox.Location = new System.Drawing.Point(535, 53);
            this.NextEndTimeBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NextEndTimeBox.Name = "NextEndTimeBox";
            this.NextEndTimeBox.Size = new System.Drawing.Size(215, 29);
            this.NextEndTimeBox.TabIndex = 39;
            this.NextEndTimeBox.Click += new System.EventHandler(this.NextEndTimeBox_Click);
            // 
            // NextEndTimeLabel
            // 
            this.NextEndTimeLabel.AutoSize = true;
            this.NextEndTimeLabel.Location = new System.Drawing.Point(531, 30);
            this.NextEndTimeLabel.Name = "NextEndTimeLabel";
            this.NextEndTimeLabel.Size = new System.Drawing.Size(106, 21);
            this.NextEndTimeLabel.TabIndex = 38;
            this.NextEndTimeLabel.Text = "下期活动结束";
            // 
            // Btn_GenID
            // 
            this.Btn_GenID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_GenID.Location = new System.Drawing.Point(623, 358);
            this.Btn_GenID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_GenID.Name = "Btn_GenID";
            this.Btn_GenID.Size = new System.Drawing.Size(116, 35);
            this.Btn_GenID.TabIndex = 40;
            this.Btn_GenID.Text = "生成最新ID";
            this.Btn_GenID.UseVisualStyleBackColor = true;
            this.Btn_GenID.Click += new System.EventHandler(this.NestID_Click);
            // 
            // BattlePassFrame
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(793, 484);
            this.ControlBoxFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.Controls.Add(this.Btn_GenID);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.InfoPageDesLabel);
            this.Controls.Add(this.InfoPageDesBox);
            this.Controls.Add(this.HeadIconDesLabel);
            this.Controls.Add(this.HeadIconDesBox);
            this.Controls.Add(this.FurnitureDesLabel);
            this.Controls.Add(this.FurnitureDesBox);
            this.Controls.Add(this.BPSkinDesLabel);
            this.Controls.Add(this.BPSkinDesBox);
            this.Controls.Add(this.InfoPageNameBox);
            this.Controls.Add(this.InfoPageNameLabel);
            this.Controls.Add(this.BPSkinNameBox);
            this.Controls.Add(this.BPSkinNameLabel);
            this.Controls.Add(this.HeadIconNameBox);
            this.Controls.Add(this.HeadIconNameLabel);
            this.Controls.Add(this.FurnitureNameBox);
            this.Controls.Add(this.FurnitureNameLabel);
            this.Controls.Add(this.Btn_Deploy);
            this.Controls.Add(this.HeroID);
            this.Controls.Add(this.LatestActivityID);
            this.Controls.Add(this.EndTimeBox);
            this.Controls.Add(this.StartTimeBox);
            this.Controls.Add(this.EndTimeLabel);
            this.Controls.Add(this.StartTimelabel);
            this.Controls.Add(this.BPHeroSkinID);
            this.Controls.Add(this.BPSkinLabel);
            this.Controls.Add(this.HeroIDlabel);
            this.Controls.Add(this.InfoPageIDBox);
            this.Controls.Add(this.HeadIconIDBox);
            this.Controls.Add(this.FunitureID);
            this.Controls.Add(this.InfoPageIDLabel);
            this.Controls.Add(this.FurnitureIDLabel);
            this.Controls.Add(this.HeadIconIDLabel);
            this.Controls.Add(this.NextEndTimeBox);
            this.Controls.Add(this.NextEndTimeLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "BattlePassFrame";
            this.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.Style = Sunny.UI.UIStyle.Gray;
            this.Text = "BattlePassFrame";
            this.Initialize += new System.EventHandler(this.BattlePassFrame_Initialize);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BattlePassFrame_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BattlePassFrame_FormClosed);
            this.Load += new System.EventHandler(this.BattlePassFrame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        public MonthCalendar monthCalendar1;
        public Label StartTimelabel;
        public Label EndTimeLabel;
        public TextBox StartTimeBox;
        public TextBox EndTimeBox;
        public Label LatestActivityID;
        public Label HeroIDlabel;
        public TextBox HeroID;
        public TextBox BPHeroSkinID;
        public Label BPSkinLabel;
        public Label HeadIconIDLabel;
        public Label FurnitureIDLabel;
        public Label InfoPageIDLabel;
        public TextBox FunitureID;
        public TextBox HeadIconIDBox;
        public TextBox InfoPageIDBox;
        public Button Btn_Deploy;
        public TextBox FurnitureNameBox;
        public Label FurnitureNameLabel;
        public TextBox HeadIconNameBox;
        public Label HeadIconNameLabel;
        public TextBox BPSkinNameBox;
        public Label BPSkinNameLabel;
        public TextBox InfoPageNameBox;
        public Label InfoPageNameLabel;
        public TextBox BPSkinDesBox;
        public Label BPSkinDesLabel;
        public Label FurnitureDesLabel;
        public TextBox FurnitureDesBox;
        public Label HeadIconDesLabel;
        public TextBox HeadIconDesBox;
        public Label InfoPageDesLabel;
        public TextBox InfoPageDesBox;
        public TextBox NextEndTimeBox;
        public Label NextEndTimeLabel;
        public Button Btn_GenID;
    }
}
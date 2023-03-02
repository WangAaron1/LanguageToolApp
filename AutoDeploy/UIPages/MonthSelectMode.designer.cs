using System.Windows.Forms;

    partial class MonthSelectMode
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.EndTimeBox = new System.Windows.Forms.TextBox();
            this.StartTimeBox = new System.Windows.Forms.TextBox();
            this.EndTimeLabel = new System.Windows.Forms.Label();
            this.StartTimelabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.Color.Aqua;
            this.monthCalendar1.Location = new System.Drawing.Point(12, 46);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(0);
            this.monthCalendar1.MaxSelectionCount = 1111;
            this.monthCalendar1.MinDate = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.SelectionRange = new System.Windows.Forms.SelectionRange(new System.DateTime(2022, 11, 12, 0, 0, 0, 0), new System.DateTime(2022, 11, 18, 0, 0, 0, 0));
            this.monthCalendar1.ShowToday = false;
            this.monthCalendar1.ShowTodayCircle = false;
            this.monthCalendar1.TabIndex = 23;
            this.monthCalendar1.Visible = false;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // EndTimeBox
            // 
            this.EndTimeBox.Location = new System.Drawing.Point(202, 24);
            this.EndTimeBox.Margin = new System.Windows.Forms.Padding(0);
            this.EndTimeBox.Name = "EndTimeBox";
            this.EndTimeBox.Size = new System.Drawing.Size(171, 29);
            this.EndTimeBox.TabIndex = 27;
            this.EndTimeBox.Click += new System.EventHandler(this.EndTimeBox_Click);
            // 
            // StartTimeBox
            // 
            this.StartTimeBox.Location = new System.Drawing.Point(12, 24);
            this.StartTimeBox.Margin = new System.Windows.Forms.Padding(0);
            this.StartTimeBox.Name = "StartTimeBox";
            this.StartTimeBox.Size = new System.Drawing.Size(171, 29);
            this.StartTimeBox.TabIndex = 26;
            this.StartTimeBox.Click += new System.EventHandler(this.StartTimeBox_Click);
            this.StartTimeBox.TextChanged += new System.EventHandler(this.StartTimeBox_TextChanged);
            // 
            // EndTimeLabel
            // 
            this.EndTimeLabel.AutoSize = true;
            this.EndTimeLabel.Location = new System.Drawing.Point(198, 3);
            this.EndTimeLabel.Margin = new System.Windows.Forms.Padding(0);
            this.EndTimeLabel.Name = "EndTimeLabel";
            this.EndTimeLabel.Size = new System.Drawing.Size(106, 21);
            this.EndTimeLabel.TabIndex = 25;
            this.EndTimeLabel.Text = "活动结束日期";
            // 
            // StartTimelabel
            // 
            this.StartTimelabel.AutoSize = true;
            this.StartTimelabel.Location = new System.Drawing.Point(8, 3);
            this.StartTimelabel.Margin = new System.Windows.Forms.Padding(0);
            this.StartTimelabel.Name = "StartTimelabel";
            this.StartTimelabel.Size = new System.Drawing.Size(106, 21);
            this.StartTimelabel.TabIndex = 24;
            this.StartTimelabel.Text = "活动开始日期";
            // 
            // MonthSelectMode
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.EndTimeBox);
            this.Controls.Add(this.StartTimeBox);
            this.Controls.Add(this.EndTimeLabel);
            this.Controls.Add(this.StartTimelabel);
            this.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "MonthSelectMode";
            this.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.Size = new System.Drawing.Size(380, 232);
            this.Style = Sunny.UI.UIStyle.Custom;
            this.Load += new System.EventHandler(this.MonthControler_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public MonthCalendar monthCalendar1;
        public TextBox EndTimeBox;
        public TextBox StartTimeBox;
        public Label EndTimeLabel;
        public Label StartTimelabel;
    }


using Sunny.UI;
using System.Windows.Forms;

namespace AutoDeployExcelDataForDesigner
{
    partial class SkinFrame
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Skindatas = new Sunny.UI.UIDataGridView();
            this.DeployButton = new System.Windows.Forms.Button();
            this.SkinBoxName = new System.Windows.Forms.TextBox();
            this.HeroIDlabel = new System.Windows.Forms.Label();
            this.SkinBoxDes = new System.Windows.Forms.TextBox();
            this.labeskin = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SkinTip = new System.Windows.Forms.TextBox();
            this.monthSelectMode1 = new MonthSelectMode();
            this.HeroIDIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SkinBoxTextWithEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SkinDesBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HaveTheEx = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.live2dLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.achieve_des = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Skindatas)).BeginInit();
            this.SuspendLayout();
            // 
            // Skindatas
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.Skindatas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Skindatas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.Skindatas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Skindatas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Skindatas.ColumnHeadersHeight = 32;
            this.Skindatas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Skindatas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HeroIDIndex,
            this.SkinBoxTextWithEN,
            this.SkinDesBox,
            this.HaveTheEx,
            this.live2dLevel,
            this.achieve_des});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Skindatas.DefaultCellStyle = dataGridViewCellStyle4;
            this.Skindatas.EnableHeadersVisualStyles = false;
            this.Skindatas.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Skindatas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.Skindatas.Location = new System.Drawing.Point(12, 65);
            this.Skindatas.Name = "Skindatas";
            this.Skindatas.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.Skindatas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Skindatas.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Skindatas.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.Skindatas.RowTemplate.Height = 25;
            this.Skindatas.ScrollBarBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.Skindatas.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.Skindatas.ScrollBarRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.Skindatas.SelectedIndex = -1;
            this.Skindatas.Size = new System.Drawing.Size(778, 180);
            this.Skindatas.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.Skindatas.Style = Sunny.UI.UIStyle.Gray;
            this.Skindatas.TabIndex = 0;
            this.Skindatas.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.Skindatas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // DeployButton
            // 
            this.DeployButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.DeployButton.Location = new System.Drawing.Point(615, 425);
            this.DeployButton.Name = "DeployButton";
            this.DeployButton.Size = new System.Drawing.Size(149, 47);
            this.DeployButton.TabIndex = 1;
            this.DeployButton.Text = " 配置";
            this.DeployButton.UseVisualStyleBackColor = true;
            this.DeployButton.Click += new System.EventHandler(this.DeployButton_Click);
            // 
            // SkinBoxName
            // 
            this.SkinBoxName.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.SkinBoxName.Location = new System.Drawing.Point(11, 272);
            this.SkinBoxName.Name = "SkinBoxName";
            this.SkinBoxName.Size = new System.Drawing.Size(149, 29);
            this.SkinBoxName.TabIndex = 13;
            this.SkinBoxName.Tag = "请输入主题名称";
            this.SkinBoxName.Text = "请输入名称";
            this.SkinBoxName.TextChanged += new System.EventHandler(this.SkinBoxName_TextChanged);
            // 
            // HeroIDlabel
            // 
            this.HeroIDlabel.AutoSize = true;
            this.HeroIDlabel.Location = new System.Drawing.Point(8, 248);
            this.HeroIDlabel.Name = "HeroIDlabel";
            this.HeroIDlabel.Size = new System.Drawing.Size(152, 21);
            this.HeroIDlabel.TabIndex = 12;
            this.HeroIDlabel.Text = "本期皮肤\"主题\"包装";
            // 
            // SkinBoxDes
            // 
            this.SkinBoxDes.Location = new System.Drawing.Point(12, 399);
            this.SkinBoxDes.Multiline = true;
            this.SkinBoxDes.Name = "SkinBoxDes";
            this.SkinBoxDes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.SkinBoxDes.Size = new System.Drawing.Size(152, 73);
            this.SkinBoxDes.TabIndex = 15;
            this.SkinBoxDes.Text = "临时";
            // 
            // labeskin
            // 
            this.labeskin.AutoSize = true;
            this.labeskin.Location = new System.Drawing.Point(8, 375);
            this.labeskin.Name = "labeskin";
            this.labeskin.Size = new System.Drawing.Size(120, 21);
            this.labeskin.TabIndex = 14;
            this.labeskin.Text = "\"主题\"包装描述";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 21);
            this.label1.TabIndex = 17;
            this.label1.Text = "备注(例:白情二期,可不填";
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox1.Location = new System.Drawing.Point(12, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(149, 29);
            this.textBox1.TabIndex = 20;
            this.textBox1.Tag = "请输入主题名称";
            this.textBox1.Text = "请输入名称";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 21);
            this.label2.TabIndex = 19;
            this.label2.Text = "本期皮肤备注(例:帕斯卡_白情二期)";
            // 
            // SkinTip
            // 
            this.SkinTip.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.SkinTip.Location = new System.Drawing.Point(12, 328);
            this.SkinTip.Name = "SkinTip";
            this.SkinTip.Size = new System.Drawing.Size(148, 29);
            this.SkinTip.TabIndex = 21;
            this.SkinTip.Tag = "请输入主题名称";
            this.SkinTip.Text = "请输入名称";
            // 
            // monthSelectMode1
            // 
            this.monthSelectMode1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.monthSelectMode1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.monthSelectMode1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.monthSelectMode1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.monthSelectMode1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.monthSelectMode1.Location = new System.Drawing.Point(167, 248);
            this.monthSelectMode1.Margin = new System.Windows.Forms.Padding(0);
            this.monthSelectMode1.MinimumSize = new System.Drawing.Size(1, 1);
            this.monthSelectMode1.Name = "monthSelectMode1";
            this.monthSelectMode1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.monthSelectMode1.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.monthSelectMode1.Size = new System.Drawing.Size(427, 224);
            this.monthSelectMode1.Style = Sunny.UI.UIStyle.Gray;
            this.monthSelectMode1.TabIndex = 22;
            this.monthSelectMode1.Text = "monthSelectMode1";
            this.monthSelectMode1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.monthSelectMode1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // HeroIDIndex
            // 
            this.HeroIDIndex.HeaderText = "英雄ID";
            this.HeroIDIndex.Name = "HeroIDIndex";
            this.HeroIDIndex.Width = 83;
            // 
            // SkinBoxTextWithEN
            // 
            this.SkinBoxTextWithEN.HeaderText = "皮肤包装名称ZH_EN";
            this.SkinBoxTextWithEN.Name = "SkinBoxTextWithEN";
            this.SkinBoxTextWithEN.ToolTipText = "如果有英文可以加_(ZH_EN)";
            this.SkinBoxTextWithEN.Width = 181;
            // 
            // SkinDesBox
            // 
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SkinDesBox.DefaultCellStyle = dataGridViewCellStyle3;
            this.SkinDesBox.FillWeight = 120F;
            this.SkinDesBox.HeaderText = "皮肤描述包装               ";
            this.SkinDesBox.MinimumWidth = 11;
            this.SkinDesBox.Name = "SkinDesBox";
            this.SkinDesBox.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.SkinDesBox.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.SkinDesBox.Width = 205;
            // 
            // HaveTheEx
            // 
            this.HaveTheEx.FalseValue = "false";
            this.HaveTheEx.HeaderText = "必杀技动画";
            this.HaveTheEx.IndeterminateValue = "false";
            this.HaveTheEx.Name = "HaveTheEx";
            this.HaveTheEx.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.HaveTheEx.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.HaveTheEx.TrueValue = "true";
            this.HaveTheEx.Width = 114;
            // 
            // live2dLevel
            // 
            this.live2dLevel.HeaderText = "Live2D等级";
            this.live2dLevel.Name = "live2dLevel";
            this.live2dLevel.Width = 116;
            // 
            // achieve_des
            // 
            this.achieve_des.HeaderText = "获取方式(默认不填)";
            this.achieve_des.Name = "achieve_des";
            this.achieve_des.ToolTipText = "默认为空来着";
            this.achieve_des.Width = 172;
            // 
            // SkinFrame
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(793, 484);
            this.ControlBoxFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.Controls.Add(this.DeployButton);
            this.Controls.Add(this.monthSelectMode1);
            this.Controls.Add(this.SkinTip);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SkinBoxDes);
            this.Controls.Add(this.labeskin);
            this.Controls.Add(this.SkinBoxName);
            this.Controls.Add(this.HeroIDlabel);
            this.Controls.Add(this.Skindatas);
            this.Name = "SkinFrame";
            this.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.Style = Sunny.UI.UIStyle.Gray;
            this.Text = "SkinDataFrame";
            this.Initialize += new System.EventHandler(this.SkinFrame_Initialize);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SkinFrame_FormClosed);
            this.Load += new System.EventHandler(this.SkinFrame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Skindatas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public UIDataGridView Skindatas;
        public Button DeployButton;
        public TextBox SkinBoxName;
        public Label HeroIDlabel;
        public TextBox SkinBoxDes;
        public Label labeskin;
        public Label label1;
        public TextBox textBox1;
        public Label label2;
        public TextBox SkinTip;
        public MonthSelectMode monthSelectMode1;
        private DataGridViewTextBoxColumn HeroIDIndex;
        private DataGridViewTextBoxColumn SkinBoxTextWithEN;
        private DataGridViewTextBoxColumn SkinDesBox;
        private DataGridViewCheckBoxColumn HaveTheEx;
        private DataGridViewTextBoxColumn live2dLevel;
        private DataGridViewTextBoxColumn achieve_des;
    }
}
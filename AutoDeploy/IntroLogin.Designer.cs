namespace AutoDeploy
{
    partial class IntroLogin
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
            this.tex_excelPath = new Sunny.UI.UILabel();
            this.Tex_ExcelPathSetting = new Sunny.UI.UITextBox();
            this.Btn_Cancel = new Sunny.UI.UISymbolButton();
            this.Btn_Confirm = new Sunny.UI.UISymbolButton();
            this.Bro_ExcelPath = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // tex_excelPath
            // 
            this.tex_excelPath.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tex_excelPath.Location = new System.Drawing.Point(42, 75);
            this.tex_excelPath.Name = "tex_excelPath";
            this.tex_excelPath.Size = new System.Drawing.Size(102, 30);
            this.tex_excelPath.Style = Sunny.UI.UIStyle.Gray;
            this.tex_excelPath.TabIndex = 1;
            this.tex_excelPath.Text = "Excel路径:";
            this.tex_excelPath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tex_excelPath.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // Tex_ExcelPathSetting
            // 
            this.Tex_ExcelPathSetting.ButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.Tex_ExcelPathSetting.ButtonFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.Tex_ExcelPathSetting.ButtonFillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.Tex_ExcelPathSetting.ButtonRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.Tex_ExcelPathSetting.ButtonRectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.Tex_ExcelPathSetting.ButtonRectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.Tex_ExcelPathSetting.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Tex_ExcelPathSetting.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.Tex_ExcelPathSetting.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Tex_ExcelPathSetting.Location = new System.Drawing.Point(132, 75);
            this.Tex_ExcelPathSetting.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Tex_ExcelPathSetting.MinimumSize = new System.Drawing.Size(1, 16);
            this.Tex_ExcelPathSetting.Name = "Tex_ExcelPathSetting";
            this.Tex_ExcelPathSetting.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.Tex_ExcelPathSetting.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.Tex_ExcelPathSetting.ShowButton = true;
            this.Tex_ExcelPathSetting.ShowText = false;
            this.Tex_ExcelPathSetting.Size = new System.Drawing.Size(274, 30);
            this.Tex_ExcelPathSetting.Style = Sunny.UI.UIStyle.Gray;
            this.Tex_ExcelPathSetting.TabIndex = 2;
            this.Tex_ExcelPathSetting.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.Tex_ExcelPathSetting.Watermark = "";
            this.Tex_ExcelPathSetting.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.Tex_ExcelPathSetting.ButtonClick += new System.EventHandler(this.Btn_Explore_Click);
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Cancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.Btn_Cancel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.Btn_Cancel.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.Btn_Cancel.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.Btn_Cancel.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.Btn_Cancel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Cancel.Location = new System.Drawing.Point(57, 120);
            this.Btn_Cancel.MinimumSize = new System.Drawing.Size(1, 1);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.Btn_Cancel.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.Btn_Cancel.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.Btn_Cancel.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.Btn_Cancel.Size = new System.Drawing.Size(87, 35);
            this.Btn_Cancel.Style = Sunny.UI.UIStyle.Gray;
            this.Btn_Cancel.Symbol = 61453;
            this.Btn_Cancel.TabIndex = 3;
            this.Btn_Cancel.Text = "取消";
            this.Btn_Cancel.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Cancel.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // Btn_Confirm
            // 
            this.Btn_Confirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Confirm.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.Btn_Confirm.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.Btn_Confirm.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.Btn_Confirm.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.Btn_Confirm.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.Btn_Confirm.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Confirm.Location = new System.Drawing.Point(286, 120);
            this.Btn_Confirm.MinimumSize = new System.Drawing.Size(1, 1);
            this.Btn_Confirm.Name = "Btn_Confirm";
            this.Btn_Confirm.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.Btn_Confirm.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.Btn_Confirm.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.Btn_Confirm.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.Btn_Confirm.Size = new System.Drawing.Size(87, 35);
            this.Btn_Confirm.Style = Sunny.UI.UIStyle.Gray;
            this.Btn_Confirm.TabIndex = 4;
            this.Btn_Confirm.Text = "确认";
            this.Btn_Confirm.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Confirm.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.Btn_Confirm.Click += new System.EventHandler(this.Btn_Confirm_Click);
            // 
            // IntroLogin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(460, 186);
            this.ControlBoxFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.Controls.Add(this.Btn_Confirm);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.Tex_ExcelPathSetting);
            this.Controls.Add(this.tex_excelPath);
            this.EscClose = true;
            this.Name = "IntroLogin";
            this.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.ShowIcon = false;
            this.Style = Sunny.UI.UIStyle.Gray;
            this.Text = "IntroLogin";
            this.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 800, 450);
            this.Load += new System.EventHandler(this.IntroLogin_Load);
            this.ResumeLayout(false);

        }

        #endregion
        public Sunny.UI.UILabel tex_excelPath;
        public Sunny.UI.UITextBox Tex_ExcelPathSetting;
        public Sunny.UI.UISymbolButton Btn_Cancel;
        public Sunny.UI.UISymbolButton Btn_Confirm;
        private System.Windows.Forms.FolderBrowserDialog Bro_ExcelPath;
    }
}
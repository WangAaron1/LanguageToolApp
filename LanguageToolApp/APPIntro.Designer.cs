namespace LanguageToolApp
{
    partial class APPIntro
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
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("翻译");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("屏蔽");
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("生成中间表", new System.Windows.Forms.TreeNode[] {
            treeNode25,
            treeNode26});
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("替换Excel");
            this.uiNavMenu1 = new Sunny.UI.UINavMenu();
            this.SuspendLayout();
            // 
            // Aside
            // 
            this.Aside.LineColor = System.Drawing.Color.Black;
            this.Aside.Location = new System.Drawing.Point(0, 35);
            this.Aside.Size = new System.Drawing.Size(206, 415);
            this.Aside.Style = Sunny.UI.UIStyle.Black;
            this.Aside.StyleCustomMode = true;
            this.Aside.MenuItemClick += new Sunny.UI.UINavMenu.OnMenuItemClick(this.Aside_MenuItemClick);
            // 
            // Header
            // 
            this.Header.Margin = new System.Windows.Forms.Padding(0);
            this.Header.Size = new System.Drawing.Size(800, 0);
            this.Header.Style = Sunny.UI.UIStyle.Black;
            this.Header.MenuItemClick += new Sunny.UI.UINavBar.OnMenuItemClick(this.Header_MenuItemClick);
            // 
            // uiNavMenu1
            // 
            this.uiNavMenu1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.uiNavMenu1.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawAll;
            this.uiNavMenu1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiNavMenu1.FullRowSelect = true;
            this.uiNavMenu1.ItemHeight = 50;
            this.uiNavMenu1.Location = new System.Drawing.Point(0, 35);
            this.uiNavMenu1.Margin = new System.Windows.Forms.Padding(0);
            this.uiNavMenu1.Name = "uiNavMenu1";
            treeNode25.Name = "节点1";
            treeNode25.Text = "翻译";
            treeNode26.Name = "节点2";
            treeNode26.Text = "屏蔽";
            treeNode27.Checked = true;
            treeNode27.ImageIndex = -2;
            treeNode27.Name = "节点0";
            treeNode27.Text = "生成中间表";
            treeNode28.Name = "节点4";
            treeNode28.Text = "替换Excel";
            this.uiNavMenu1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode27,
            treeNode28});
            this.uiNavMenu1.ShowLines = false;
            this.uiNavMenu1.Size = new System.Drawing.Size(166, 415);
            this.uiNavMenu1.Style = Sunny.UI.UIStyle.Black;
            this.uiNavMenu1.TabIndex = 0;
            this.uiNavMenu1.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiNavMenu1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // APPIntro
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBoxFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Controls.Add(this.uiNavMenu1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "APPIntro";
            this.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(58)))), ((int)(((byte)(92)))));
            this.Style = Sunny.UI.UIStyle.Black;
            this.Text = "LanguageTools整合";
            this.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 800, 450);
            this.Load += new System.EventHandler(this.MainFrame_Load);
            this.Controls.SetChildIndex(this.uiNavMenu1, 0);
            this.Controls.SetChildIndex(this.Header, 0);
            this.Controls.SetChildIndex(this.Aside, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UINavMenu uiNavMenu1;
    }
}
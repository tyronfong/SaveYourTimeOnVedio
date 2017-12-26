namespace SaveYourTimeOnVedio
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.decryptBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newCategoryMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.categoryView = new System.Windows.Forms.TreeView();
            this.decryptedFileView = new System.Windows.Forms.TreeView();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // decryptBtn
            // 
            resources.ApplyResources(this.decryptBtn, "decryptBtn");
            this.decryptBtn.Name = "decryptBtn";
            this.decryptBtn.UseVisualStyleBackColor = true;
            this.decryptBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newCategoryMenu});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // newCategoryMenu
            // 
            this.newCategoryMenu.Name = "newCategoryMenu";
            resources.ApplyResources(this.newCategoryMenu, "newCategoryMenu");
            this.newCategoryMenu.Click += new System.EventHandler(this.newCategoryMenu_Click);
            // 
            // statusStrip1
            // 
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Name = "statusStrip1";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // categoryView
            // 
            resources.ApplyResources(this.categoryView, "categoryView");
            this.categoryView.Name = "categoryView";
            this.categoryView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            ((System.Windows.Forms.TreeNode)(resources.GetObject("categoryView.Nodes"))),
            ((System.Windows.Forms.TreeNode)(resources.GetObject("categoryView.Nodes1"))),
            ((System.Windows.Forms.TreeNode)(resources.GetObject("categoryView.Nodes2"))),
            ((System.Windows.Forms.TreeNode)(resources.GetObject("categoryView.Nodes3"))),
            ((System.Windows.Forms.TreeNode)(resources.GetObject("categoryView.Nodes4")))});
            this.categoryView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // decryptedFileView
            // 
            resources.ApplyResources(this.decryptedFileView, "decryptedFileView");
            this.decryptedFileView.Name = "decryptedFileView";
            this.decryptedFileView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            ((System.Windows.Forms.TreeNode)(resources.GetObject("decryptedFileView.Nodes"))),
            ((System.Windows.Forms.TreeNode)(resources.GetObject("decryptedFileView.Nodes1"))),
            ((System.Windows.Forms.TreeNode)(resources.GetObject("decryptedFileView.Nodes2"))),
            ((System.Windows.Forms.TreeNode)(resources.GetObject("decryptedFileView.Nodes3"))),
            ((System.Windows.Forms.TreeNode)(resources.GetObject("decryptedFileView.Nodes4")))});
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.decryptedFileView);
            this.Controls.Add(this.categoryView);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.decryptBtn);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button decryptBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newCategoryMenu;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.TreeView categoryView;
        private System.Windows.Forms.TreeView decryptedFileView;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}


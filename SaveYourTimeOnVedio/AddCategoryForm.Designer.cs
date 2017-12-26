namespace SaveYourTimeOnVedio
{
    partial class AddCategoryForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.categoryNameTextBox = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.selectFileBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.fileListBox = new System.Windows.Forms.ListBox();
            this.categoryAddCancelBtn = new System.Windows.Forms.Button();
            this.categoryAddOkBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Category Name:";
            // 
            // categoryNameTextBox
            // 
            this.categoryNameTextBox.Location = new System.Drawing.Point(107, 34);
            this.categoryNameTextBox.Name = "categoryNameTextBox";
            this.categoryNameTextBox.Size = new System.Drawing.Size(344, 21);
            this.categoryNameTextBox.TabIndex = 1;
            this.categoryNameTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Multiselect = true;
            // 
            // selectFileBtn
            // 
            this.selectFileBtn.Location = new System.Drawing.Point(360, 384);
            this.selectFileBtn.Name = "selectFileBtn";
            this.selectFileBtn.Size = new System.Drawing.Size(91, 23);
            this.selectFileBtn.TabIndex = 3;
            this.selectFileBtn.Text = "Select File";
            this.selectFileBtn.UseVisualStyleBackColor = true;
            this.selectFileBtn.Click += new System.EventHandler(this.selectFileBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "File List:";
            // 
            // fileListBox
            // 
            this.fileListBox.FormattingEnabled = true;
            this.fileListBox.ItemHeight = 12;
            this.fileListBox.Location = new System.Drawing.Point(107, 74);
            this.fileListBox.Name = "fileListBox";
            this.fileListBox.Size = new System.Drawing.Size(344, 304);
            this.fileListBox.TabIndex = 6;
            // 
            // categoryAddCancelBtn
            // 
            this.categoryAddCancelBtn.Location = new System.Drawing.Point(456, 433);
            this.categoryAddCancelBtn.Name = "categoryAddCancelBtn";
            this.categoryAddCancelBtn.Size = new System.Drawing.Size(75, 23);
            this.categoryAddCancelBtn.TabIndex = 7;
            this.categoryAddCancelBtn.Text = "Cancel";
            this.categoryAddCancelBtn.UseVisualStyleBackColor = true;
            // 
            // categoryAddOkBtn
            // 
            this.categoryAddOkBtn.Location = new System.Drawing.Point(375, 433);
            this.categoryAddOkBtn.Name = "categoryAddOkBtn";
            this.categoryAddOkBtn.Size = new System.Drawing.Size(75, 23);
            this.categoryAddOkBtn.TabIndex = 8;
            this.categoryAddOkBtn.Text = "OK";
            this.categoryAddOkBtn.UseVisualStyleBackColor = true;
            // 
            // AddCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 468);
            this.Controls.Add(this.categoryAddOkBtn);
            this.Controls.Add(this.categoryAddCancelBtn);
            this.Controls.Add(this.fileListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.selectFileBtn);
            this.Controls.Add(this.categoryNameTextBox);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "AddCategoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Category";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox categoryNameTextBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button selectFileBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox fileListBox;
        private System.Windows.Forms.Button categoryAddCancelBtn;
        private System.Windows.Forms.Button categoryAddOkBtn;
    }
}
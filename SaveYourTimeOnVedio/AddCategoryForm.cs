using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaveYourTimeOnVedio
{
    public partial class AddCategoryForm : Form
    {
        public AddCategoryForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void selectFileBtn_Click(object sender, EventArgs e)
        {
           
            DialogResult result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                string[] selectFiles = openFileDialog.FileNames;
                foreach (string file in selectFiles)
                {
                    fileListBox.Items.Add(file);
                }
           
            }
        }
    }
}

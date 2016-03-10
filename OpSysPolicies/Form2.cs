using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpSysPolicies
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        String path = "";
        String value = "";
        String filename = "New Text File";
        Boolean isModified = false;
        private void save()
        {
            if (isModified)
            {
                
            }
            MessageBox.Show("Save Successful");
        }

        private void saveAs()
        {
            
        }

        private bool isEmpty(String path)
        {
            path.Trim();
            if (path.Length == 0)
            {
                return true;
            }
            return false;
        }

        private void open()
        {
            ofd.ShowDialog();
            path = ofd.FileName;
            if (File.Exists(path))
            {
                StreamReader sr = new StreamReader(path);
                rtb.Text = sr.ReadToEnd();
                filename = ofd.SafeFileName;
                this.Text = filename;
                sr.Close();
                isModified = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            save();
            value = rtb.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            createNew();
        }

        private void createNew()
        {
            rtb.Clear();
            filename = "New Text File";
            this.Text = filename;
            path = "";
        }

        private void rtb_TextChanged(object sender, EventArgs e)
        {
            isModified = true;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            open();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            save();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createNew();
        }


    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SwiftyProject
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                webBrowser1.Navigate(openFileDialog.FileName);
                //webBrowser1.Document.InvokeScript("SetVariable", new Object[] { "VarText1=6" });
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.Document.InvokeScript("SetVariable", new Object[] { "VarText1=6" });
        }
    }
}

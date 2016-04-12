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

        private void OpenFile_Click(object sender, EventArgs e)
        {
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                webBrowser.Navigate(openFileDialog.FileName);
                //webBrowser1.Document.InvokeScript("SetVariable", new Object[] { "VarText1=6" });
            }
        }

        private void ExampleSetVariable_Click(object sender, EventArgs e)
        {
            webBrowser.Document.InvokeScript("SetVariable", new Object[] { "VarText1=6" });
        }
    }
}

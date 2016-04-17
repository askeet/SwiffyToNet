using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SwiftyProject.Lib;

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
                SwiftyProject.Lib.ImportLib.OpenFile(webBrowser, openFileDialog.FileName);
            }
        }

        int i = 0;
        private void ExampleSetVariable_Click(object sender, EventArgs e)
        {
            Lib.MovieClip mc = new Lib.MovieClip(webBrowser, "MovieClip1");

            mc._x += 1;
            //mc.gotoAndStop((byte)i++);
            ExampleSetVariable.Text = mc._totalframes.ToString();
            //mc.enabled = !mc.enabled;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lib.MovieClip mc = new Lib.MovieClip(webBrowser, "MovieClip1");
            //Convert.
            ImportLib.SetVariable(webBrowser, "VarText2",100.ToString());
            button1.Text = ImportLib.GetData(webBrowser, "_root.VarText2");
         
           // ImportLib()


        }





    }
}

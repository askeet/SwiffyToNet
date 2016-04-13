﻿using System;
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

            mc._x = i++;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lib.MovieClip mc = new Lib.MovieClip(webBrowser, "MovieClip1");
            webBrowser.Document.InvokeScript("SetVariable", new Object[] { "VarText1=" + mc._x });
        
             
        }





    }
}

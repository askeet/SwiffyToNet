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
            i++;
            mc._x += 1;
            //mc.gotoAndStop((byte)i++);
            ExampleSetVariable.Text = mc._totalframes.ToString();
            //mc.enabled = !mc.enabled;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lib.MovieClip mc = new Lib.MovieClip(webBrowser, "");
            // Создаем мувиклип-родитель для контейнера
            Lib.MovieClip logo_mc = mc.createEmptyMovieClip("logo_mc", mc.getNextHighestDepth());
            // Создаем контейнер внутри "mc_1"
            // в этот мувиклип будет загружено изображение
            Lib.MovieClip container_mc = logo_mc.createEmptyMovieClip("container_mc", 0);
            container_mc.loadMovie("http://www.macromedia.com/images/shared/product_boxes/80x92/studio_flashpro.jpg");


        }





    }
}

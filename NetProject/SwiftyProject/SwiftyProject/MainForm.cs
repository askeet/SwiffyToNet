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
                ImportLib.ME.onMouseMoved += ME_onMouseMoved;

            }
        }

        private void ME_onMouseMoved(object sender, MouseEventArgs e)
        {
            Lib.MovieClip mc = new MovieClip(webBrowser, "square_mc");
            Console.WriteLine(mc.hitTest(e.X,e.Y,true));
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
            //Lib.MovieClip logo_mc = mc.createEmptyMovieClip("logo_mc", mc.getNextHighestDepth());
            //// Создаем контейнер внутри "mc_1"
            //// в этот мувиклип будет загружено изображение
            //Lib.MovieClip container_mc = logo_mc.createEmptyMovieClip("container_mc", mc.getNextHighestDepth());
            //container_mc.loadMovie("http://www.macromedia.com/images/shared/product_boxes/80x92/studio_flashpro.jpg");
         

            Lib.MovieClip square_mc = mc.createEmptyMovieClip("square_mc", 1);
            //Lib.MovieClip square_mc = new MovieClip(webBrowser, "MovieClip1");
            square_mc._x = 10;
            square_mc._y = 10;
            square_mc.beginFill(0xFF0000);
            square_mc.moveTo(0, 0);
            square_mc.lineTo(100, 0);
            square_mc.lineTo(100, 100);
            square_mc.lineTo(0, 100);
            square_mc.lineTo(0, 0);
            square_mc.endFill();

            Lib.MovieClip.RBounds b = square_mc.getBounds("_root");



            button1.Text = b.yMax.ToString();
                //mc.getBounds("MovieClip1").yMax; //mc.getInstanceAtDepth(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Lib.MovieClip mc = new MovieClip(webBrowser, "MovieClip1");
            PointF f = mc.localToGlobal(new PointF(11, 10));
            Console.WriteLine("X=" + f.X + " Y=" + f.Y);
            f = mc.globalToLocal(new PointF(f.X, f.Y));      
            Console.WriteLine("X1="+f.X +" Y1=" + f.Y);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser.ShowSaveAsDialog();
            //System.IO.File.WriteAllText(@"E:\GitHub\SwiffyToNet\Flash\saveDocument.html", webBrowser.Document..Parent.OuterHtml, Encoding.GetEncoding(webBrowser.Document.Encoding));
        }
    }
}

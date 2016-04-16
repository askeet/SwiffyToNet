using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace SwiftyProject.Lib
{
    class MovieClip
    {
        WebBrowser webBrowser;
        string nameMovie = "";
        public MovieClip(WebBrowser webBrowser, string nameMovie) {
            this.webBrowser = webBrowser;
            this.nameMovie = nameMovie;    
        }

        

        //Уровень прозрачности мувиклипа.
        public byte _alpha;

        //Только для чтения; номер кадра, в котором в данный момент находится воспроизводящая головка.
        public int _currentframe;

        //Только для чтения; абсолютный путь в слэш-нотации к мувиклипу, на который перетаскиваемый мувиклип был "брошен".
        public int _droptarget;

        //Булева величина, показывающая, доступен или нет(enabled) мувиклип.
        public bool enabled;

        //Булева величина, показывающая, может ли мувиклип получать фокус.        
        public bool focusEnabled;

        //Булева величина, показывающая, отображается ли желтый прямоугольник вокруг мувиклипа, когда он находится в фокусе.
        public bool _focusrect;

        //Только для чтения; число уже загруженных кадров в загружаемом SWF файле.
        public int _framesloaded;

        //Высота мувиклипа в пикселах.
        public int _height;

        //Ссылка на мувиклип, служащая как "горячая зона" (hit area) для другого мувиклипа при проверке методом hitTest().
        public string hitArea;

        //Определяет, на что ссылается ключевое слово _root(на главный Таймлайн ролика-родителя или загруженного ролика) при загрузке SWF файла в мувиклип.
        public string _lockroot;

        //Объект, связывающий объект класса ContextMenu с мувиклипом.
        public string menu;

       // Имя экземпляра мувиклипа.
        public string _name;

        //cсылка на мувиклип-родитель данного мувиклипа.
        public string _parent;

        //Строка, отображающая качество рендеринга мувиклипа.
        public string _quality;

        //Угол поворота мувиклипа в градусах.
        public string _rotation;

        //Количество секунд буферизации перед воспроизведением потокового звука.
        public int _soundbuftime;


        //Булева величина, показывающая, включаются ли мувиклипы, вложенные в данный, в обход по клавише Tab.
        public bool tabChildren;

        //Булева величина, показывающая, включается ли мувиклип в обход по клавише Tab.
        public bool tabEnabled;

        //Порядковый номер мувиклипа в обходе по клавише Tab.
        public int tabIndex;

        //Только для чтения; путь к мувиклипу.
        public string _target;

        //Только для чтения; общее количество кадров в мувиклипе.
        public int _totalframes;

        //Булева величина, показывающая, получают ли все прочие мувиклипы, помимо данного, оповещение при отпускании левой кнопки мыши.
        public bool trackAsMenu;

        //Только для чтения; URL, с которого SWF файл, содержащий данный мувиклип, был загружен.
        public string _url;

        //Булева величина, определяющая, превращается ли курсор в изображение руки при наведении его на мувиклип.
        public bool useHandCursor;

        //Булева величина, определяющая, скрыт или видим мувиклип.
        public  bool _visible;

        //Ширина мувиклипа в пикселах.
        public int _width
        {
            set { ImportLib.SetField(webBrowser, nameMovie, "_width", value.ToString()); }             
        }

        //Координата x мувиклипа.
        public float _x 
        {
            set { ImportLib.SetField(webBrowser, nameMovie, "_x",value.ToString()); }
            get {
                string Var = ImportLib.GetData(webBrowser, nameMovie, "_x");
                if (Var == String.Empty) { Var = "-1"; };
                return Convert.ToSingle(Var);
            }
        }

        //Только для чтения ; координата x указателя мыши в системе координат мувиклипа.
        public int _xmouse;

        //Горизонтальный маштаб мувиклипа.
        public int _xscale;

        //Координата y мувиклипа.
        public int _y
        {
            set { ImportLib.SetField(webBrowser, nameMovie, "_y", value.ToString()); }
        }


        //Только для чтения; координата y указателя мыши в системе координат мувиклипа.
        public int _ymouse;

        //Вертикальный маштаб мувиклипа.
        public int _yscale;

        //Переводит воспроизводящую головку мувиклипа на указанный кадр и остонавливает воспроизведение.
        public void gotoAndStop(byte NumberFrame) {
            ImportLib.RunFunc(webBrowser, nameMovie, "gotoAndStop", NumberFrame.ToString());
        }

        //Начинает рисование заливки в указанном мувиклипе.
        public void beginFill() { }

        //Начинает рисование градиентной заливки в указанном мувиклипе.
        public void beginGradientFill() { }

        //Удаляет все программно нарисованные в данном мувиклипе элементы.
        public void clear() { }

        //Рисует кривую, используя текущие настройки стиля линии.
        public void curveTo() { }

        //Заканчивает заливку, начатую MovieClip.beginFill() или MovieClip.beginGradientFill().
        public void endFill() { }

        //Определяет вид линий, рисуемых при помощи MovieClip.lineTo() и MovieClip.curveTo(). 
        public void lineStyle() { }

        //Рисует линию, используя текущие настройки стиля линии. 
        public void lineTo() { }

        //Перемещает точку, из которой начинается рисование, в указанные координаты.
        public void moveTo() { }

    }
}

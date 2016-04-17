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
        public int _alpha
        {
            set { ImportLib.SetField(webBrowser, nameMovie, "_alpha", value.ToString()); }
            get
            {
                string Var = ImportLib.GetData(webBrowser, nameMovie, "_alpha");
                return Converter.StringTo<int>(Var);
            }
        }

        //Только для чтения; номер кадра, в котором в данный момент находится воспроизводящая головка.
        public int _currentframe
        {
            get
            {
                string Var = ImportLib.GetData(webBrowser, nameMovie, "_currentframe");
                return Converter.StringTo<int>(Var);
            }
        }

        //Только для чтения; абсолютный путь в слэш-нотации к мувиклипу, на который перетаскиваемый мувиклип был "брошен".
        public string _droptarget
        {
            get
            {
                return ImportLib.GetData(webBrowser, nameMovie, "_droptarget");
            }
        }

        //Булева величина, показывающая, доступен или нет(enabled) мувиклип.
        public bool enabled
        {
            set { ImportLib.SetField(webBrowser, nameMovie, "enabled", value.ToString()); }
            get
            {
                string Var = ImportLib.GetData(webBrowser, nameMovie, "enabled");
                return Converter.StringTo<bool>(Var);
            }
        }

        //Булева величина, показывающая, может ли мувиклип получать фокус.        
        public bool focusEnabled
        {
            set { ImportLib.SetField(webBrowser, nameMovie, "focusEnabled", value.ToString()); }
            get
            {
                string Var = ImportLib.GetData(webBrowser, nameMovie, "focusEnabled");
                return Converter.StringTo<bool>(Var);
            }
        }

        //Булева величина, показывающая, отображается ли желтый прямоугольник вокруг мувиклипа, когда он находится в фокусе.
        public bool _focusrect
        {
            set { ImportLib.SetField(webBrowser, nameMovie, "_focusrect", value.ToString()); }
            get
            {
                string Var = ImportLib.GetData(webBrowser, nameMovie, "_focusrect");
                return Converter.StringTo<bool>(Var);
            }
        }

        //Только для чтения; число уже загруженных кадров в загружаемом SWF файле.
        public int _framesloaded
        {
            get
            {
                string Var = ImportLib.GetData(webBrowser, nameMovie, "_framesloaded");
                return Converter.StringTo<int>(Var);
            }
        }

        //Высота мувиклипа в пикселах.
        public float _height
        {
            set { ImportLib.SetField(webBrowser, nameMovie, "_height", Converter.ToString(value)); }
            get
            {
                string Var = ImportLib.GetData(webBrowser, nameMovie, "_height");
                return Converter.StringTo<float>(Var);
            }
        }

        //Ссылка на мувиклип, служащая как "горячая зона" (hit area) для другого мувиклипа при проверке методом hitTest().
        public string hitArea
        {
            set { ImportLib.SetField(webBrowser, nameMovie, "hitArea", value.ToString()); }
            get
            {
                return ImportLib.GetData(webBrowser, nameMovie, "hitArea");
            }
        }

        //Определяет, на что ссылается ключевое слово _root(на главный Таймлайн ролика-родителя или загруженного ролика) при загрузке SWF файла в мувиклип.
        public string _lockroot
        {
            set { ImportLib.SetField(webBrowser, nameMovie, "_lockroot", value.ToString()); }
            get
            {
                return ImportLib.GetData(webBrowser, nameMovie, "_lockroot");
            }
        }



       // Имя экземпляра мувиклипа.
        public string _name
        {
            get
            {
                return ImportLib.GetData(webBrowser, nameMovie, "_name");
            }
        }

        //cсылка на мувиклип-родитель данного мувиклипа.
        public string _parent
        {
            get
            {
                return ImportLib.GetData(webBrowser, nameMovie, "_parent");
            }
        }

        //Строка, отображающая качество рендеринга мувиклипа.
        public string _quality
        {
            get
            {
                return ImportLib.GetData(webBrowser, nameMovie, "_quality");
            }
        }

        //Угол поворота мувиклипа в градусах.
        public float _rotation
        {
            set { ImportLib.SetField(webBrowser, nameMovie, "_rotation", value.ToString()); }
            get
            {
                string Var = ImportLib.GetData(webBrowser, nameMovie, "_rotation");
                return Converter.StringTo<float>(Var);
            }
        }


        //Булева величина, показывающая, включаются ли мувиклипы, вложенные в данный, в обход по клавише Tab.
        public bool tabChildren
        {
            set { ImportLib.SetField(webBrowser, nameMovie, "tabChildren", value.ToString()); }
            get
            {
                string Var = ImportLib.GetData(webBrowser, nameMovie, "tabChildren");
                return Converter.StringTo<bool>(Var);
            }
        }

        //Булева величина, показывающая, включается ли мувиклип в обход по клавише Tab.
        public bool tabEnabled
        {
            set { ImportLib.SetField(webBrowser, nameMovie, "tabEnabled", value.ToString()); }
            get
            {
                string Var = ImportLib.GetData(webBrowser, nameMovie, "tabEnabled");
                return Converter.StringTo<bool>(Var);
            }
        }

        //Порядковый номер мувиклипа в обходе по клавише Tab.
        public int tabIndex
        {
            set { ImportLib.SetField(webBrowser, nameMovie, "tabIndex", value.ToString()); }
            get
            {
                string Var = ImportLib.GetData(webBrowser, nameMovie, "tabIndex");
                return Converter.StringTo<int>(Var);
            }
        }

        //Только для чтения; путь к мувиклипу.
        public string _target
        {
            get
            {
                return ImportLib.GetData(webBrowser, nameMovie, "_target");
            }
        }

        //Только для чтения; общее количество кадров в мувиклипе.
        public int _totalframes
        {
            get
            {
                string Var = ImportLib.GetData(webBrowser, nameMovie, "_totalframes");
                return Converter.StringTo<int>(Var);
            }
        }

        //Булева величина, показывающая, получают ли все прочие мувиклипы, помимо данного, оповещение при отпускании левой кнопки мыши.
        public bool trackAsMenu
        {
            set { ImportLib.SetField(webBrowser, nameMovie, "trackAsMenu", value.ToString()); }
            get
            {
                string Var = ImportLib.GetData(webBrowser, nameMovie, "trackAsMenu");
                return Converter.StringTo<bool>(Var);
            }
        }

        //Только для чтения; URL, с которого SWF файл, содержащий данный мувиклип, был загружен.
        public string _url
        {
            get
            {
                return ImportLib.GetData(webBrowser, nameMovie, "_url");
            }
        }

        //Булева величина, определяющая, превращается ли курсор в изображение руки при наведении его на мувиклип.
        public bool useHandCursor
        {
            set { ImportLib.SetField(webBrowser, nameMovie, "useHandCursor", value.ToString()); }
            get
            {
                string Var = ImportLib.GetData(webBrowser, nameMovie, "useHandCursor");
                return Converter.StringTo<bool>(Var);
            }
        }

        //Булева величина, определяющая, скрыт или видим мувиклип.
        public  bool _visible
        {
            set { ImportLib.SetField(webBrowser, nameMovie, "_visible", value.ToString()); }
            get
            {
                string Var = ImportLib.GetData(webBrowser, nameMovie, "_visible");
                return Converter.StringTo<bool>(Var);
            }
        }

        //Ширина мувиклипа в пикселах.
        public float _width
        {
            set { ImportLib.SetField(webBrowser, nameMovie, "_width", Converter.ToString(value)); }
            get
            {
                string Var = ImportLib.GetData(webBrowser, nameMovie, "_width");
                return Converter.StringTo<float>(Var);
            }
        }

        //Координата x мувиклипа.
        public float _x 
        {
            set { ImportLib.SetField(webBrowser, nameMovie, "_x",Converter.ToString(value)); }
            get {
                string Var = ImportLib.GetData(webBrowser, nameMovie, "_x");
                return Converter.StringTo<float>(Var);
            }
        }

        //Только для чтения ; координата x указателя мыши в системе координат мувиклипа.
        public float _xmouse
        {
            get
            {
                string Var = ImportLib.GetData(webBrowser, nameMovie, "_xmouse");
                return Converter.StringTo<float>(Var);
            }
        }

        //Горизонтальный маштаб мувиклипа.
        public float _xscale
        {
            set { ImportLib.SetField(webBrowser, nameMovie, "_xscale", Converter.ToString(value)); }
            get
            {
                string Var = ImportLib.GetData(webBrowser, nameMovie, "_xscale");
                return Converter.StringTo<float>(Var);
            }
        }

        //Координата y мувиклипа.
        public float _y
        {
            set { ImportLib.SetField(webBrowser, nameMovie, "_y", Converter.ToString(value)); }
            get
            {
                string Var = ImportLib.GetData(webBrowser, nameMovie, "_y");
                return Converter.StringTo<float>(Var);
            }
        }


        //Только для чтения; координата y указателя мыши в системе координат мувиклипа.
        public float _ymouse
        {
            get
            {
                string Var = ImportLib.GetData(webBrowser, nameMovie, "_ymouse");
                return Converter.StringTo<float>(Var);
            }
        }

        //Вертикальный маштаб мувиклипа.
        public float _yscale
        {
            set { ImportLib.SetField(webBrowser, nameMovie, "_yscale", Converter.ToString(value)); }
            get
            {
                string Var = ImportLib.GetData(webBrowser, nameMovie, "_yscale");
                return Converter.StringTo<float>(Var);
            }
        }

        //Переводит воспроизводящую головку мувиклипа на указанный кадр и остонавливает воспроизведение.
        public void gotoAndStop(byte NumberFrame) {
            ImportLib.RunFunc(webBrowser, nameMovie, "gotoAndStop", NumberFrame.ToString());
        }

        //Начинает рисование заливки в указанном мувиклипе.
        public void beginFill(int rgb, int alpha=-1) {
            string Value = "";
            if (alpha == -1) Value = Converter.ToString(rgb);
            else Value = Converter.ToString(rgb, alpha);
            ImportLib.RunFunc(webBrowser, nameMovie, "beginFill", Value);
        }

        //Начинает рисование градиентной заливки в указанном мувиклипе.
        //public void beginGradientFill() { }

        //Удаляет все программно нарисованные в данном мувиклипе элементы.
        public void clear() {
            ImportLib.RunFunc(webBrowser, nameMovie, "clear", "0");
        }

        //Рисует кривую, используя текущие настройки стиля линии.
        public void curveTo(float controlX, float controlY, float anchorX, float anchorY) {
            ImportLib.RunFunc(webBrowser, nameMovie, "curveTo", Converter.ToString(controlX, controlY, anchorX, anchorY));
        }

        //Заканчивает заливку, начатую MovieClip.beginFill() или MovieClip.beginGradientFill().
        public void endFill() {
            ImportLib.RunFunc(webBrowser, nameMovie, "endFill", "0");
        }

        //Определяет вид линий, рисуемых при помощи MovieClip.lineTo() и MovieClip.curveTo(). 
        public void lineStyle(float thickness, int rgb=-1, int alpha=-1) {
            string Value = "";
            if (rgb == -1) Value = Converter.ToString(thickness);
            else
                if (alpha == -1) Value = Converter.ToString(thickness, rgb);
                else Value = Converter.ToString(thickness, rgb,alpha);
            ImportLib.RunFunc(webBrowser, nameMovie, "lineStyle", Value);
        }

        //Рисует линию, используя текущие настройки стиля линии. 
        public void lineTo(float x,float y) {
            ImportLib.RunFunc(webBrowser, nameMovie, "lineTo", Converter.ToString(x,y));
        }

        //Перемещает точку, из которой начинается рисование, в указанные координаты.
        public void moveTo(float x, float y) {
            ImportLib.RunFunc(webBrowser, nameMovie, "moveTo", Converter.ToString(x, y));
        }

    }
}

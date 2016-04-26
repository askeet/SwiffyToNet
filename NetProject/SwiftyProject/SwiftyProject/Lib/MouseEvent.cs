using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace SwiftyProject.Lib
{
    public class MouseEvent: IMessageFilter
    {
        public event MouseEventHandler onMouseMoved;
        public event MouseEventHandler onMouseClick;
        public event MouseEventHandler onMousePress;

        //static List<Control> listMouseHandler;
        Control sender = null;
        public MouseEvent()
        {
            Application.AddMessageFilter(this);
        }
        public MouseEvent(Control sender)
        {
            this.sender = sender;
            Application.AddMessageFilter(this);
        }

        //void AddMessageFilter()
        //{
        //    if (listMouseHandler.Find(item => item.Equals(this.sender)) == null)
        //    {
        //        listMouseHandler.Add(this.sender);
        //        Application.AddMessageFilter(this); 
        //    }
        //}

        private const int WM_MOUSEMOVE = 0x0200;
        private const int WM_LBBUTTONDOWN = 0x0201;
        private const int WM_LBUTTONUP = 0x0202;

        Point GetCursor()
        {
            Point currentPosition = System.Windows.Forms.Cursor.Position;
            currentPosition = (sender != null) ? sender.PointToClient(currentPosition) : currentPosition;
            if (currentPosition.X < 0) currentPosition.X = -1;
            if (currentPosition.Y < 0) currentPosition.Y = -1;
            return currentPosition;
        }

        #region IMessageFilter Members

        public bool PreFilterMessage(ref Message m)
        {
            if (m.Msg == WM_MOUSEMOVE && onMouseMoved != null)
            {
                Point currentPosition = GetCursor();
                if (currentPosition.X >= 0 && currentPosition.Y >= 0)
                {
                    MouseEventArgs arg = new MouseEventArgs(MouseButtons.None, 0, currentPosition.X, currentPosition.Y, 0);
                    onMouseMoved(sender, arg);
                }
            }

            if (m.Msg == WM_LBBUTTONDOWN && onMousePress != null)
            {
                Point currentPosition = GetCursor();
                if (currentPosition.X >= 0 && currentPosition.Y >= 0)
                {
                    MouseEventArgs arg = new MouseEventArgs(MouseButtons.Left, 0, currentPosition.X, currentPosition.Y, 0);
                    onMousePress(sender, arg);
                }
            }

            if (m.Msg == WM_LBUTTONUP && onMouseClick != null)
            {
                Point currentPosition = GetCursor();
                if (currentPosition.X >= 0 && currentPosition.Y >= 0)
                {
                    MouseEventArgs arg = new MouseEventArgs(MouseButtons.Left, 0, currentPosition.X, currentPosition.Y, 0);
                    onMouseClick(sender, arg);
                }
            }

            // Always allow message to continue to the next filter control 
            return false;
        }

        #endregion
    }
}
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Threading;

namespace SwiftyProject.Lib
{
    public class ImportLib
    {

        public static void OpenFile(WebBrowser webBrowser, string FileName)
        {                          
            webBrowser.Navigate(FileName);               
            webBrowser.ObjectForScripting = new ScriptInterface();
        }

        [System.Runtime.InteropServices.ComVisibleAttribute(true)]
        public class ScriptInterface
        {
            public static string Variable = "";
            public static bool WaitEvent = true;

            static object Sunc = new object();
            static ManualResetEvent oSignalEvent = new ManualResetEvent(false);
            public void EventForGetData(string variable)
            {             
                Variable = (variable==null )?"":variable;
                WaitEvent = false;
            }
          
            public static string ForWaitGetData(int MaxWait = 500)
            {
                System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
                sw.Start();
                WaitEvent = true;
                long Begin = DateTime.Now.Ticks;
                while (WaitEvent )
                {
                    Application.DoEvents();
                    if(new TimeSpan(DateTime.Now.Ticks - Begin).Milliseconds > MaxWait)
                    {
                        Variable = "";
                        break;
                    } 
                }
                sw.Stop();
                Console.WriteLine("Time="+  sw.ElapsedMilliseconds);
                return Variable;
            }

        }

        public static void SetVariable(WebBrowser webBrowser,string Variable, string Value)
        {
            webBrowser.Document.InvokeScript("SetVariable", new Object[] { String.Format("{0}={1}",Variable,Value)});
        }

        public static void SetField(WebBrowser webBrowser, string NameMovie,string NameField, string Value)
        {
            webBrowser.Document.InvokeScript("SetVariable", new Object[] { String.Format("CurMovie={0}&CurField={1}&SetVar={2}", NameMovie, NameField, Value) });   
        }

        public static string GetData(WebBrowser webBrowser, string NameMovie, string NameField)
        {
            webBrowser.Document.InvokeScript("SetVariable", new Object[] { String.Format("CurMovie={0}&CurField={1}&GetData=1", NameMovie, NameField) });
            return ScriptInterface.ForWaitGetData();
        }

        public static string GetData(WebBrowser webBrowser,  string NameVariable)
        {
            webBrowser.Document.InvokeScript("SetVariable", new Object[] { String.Format("CurField={0}&GetData=0", NameVariable) });
            return ScriptInterface.ForWaitGetData();
        }

        public static void RunFunc(WebBrowser webBrowser, string NameMovie, string NameFunc, string Value)
        {
            webBrowser.Document.InvokeScript("SetVariable", new Object[] { String.Format("CurMovie=" + NameMovie + "&CurField=" + NameFunc + "&RunFunc=" + Value) });
        }

        public object GetResultFunc(WebBrowser webBrowser)
        {
            return GetData(webBrowser, "GetResFunc");
        }
    }
}

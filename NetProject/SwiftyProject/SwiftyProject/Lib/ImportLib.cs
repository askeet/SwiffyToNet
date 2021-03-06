﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Threading;

namespace SwiftyProject.Lib
{
    public class ImportLib
    {
        public static MouseEvent ME;

        public static void OpenFile(WebBrowser webBrowser, string FileName)
        {                          
            webBrowser.Navigate(FileName);     
            webBrowser.DocumentCompleted += webBrowser_DocumentCompleted;
            ME = new MouseEvent(webBrowser);
        }

        private static void webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            WebBrowser webBrowser = sender as WebBrowser;
            var jsCode =
                "var SetVariable = function(Variable){ stage.setFlashVars(Variable);}; " +
                "function ReceiveDataFromAS(args) {" +
                   "window.external.EventForGetData(args);" +
                "};";
            // it works on IE
            webBrowser.Document.InvokeScript("execScript", new Object[] { jsCode, "JavaScript" });
            // register callback from JS
            webBrowser.ObjectForScripting = new ScriptInterface();
            // scale
            HtmlElement scale = webBrowser.Document.GetElementById("swiffycontainer");  //Size = new System.Drawing.Size(webBrowser.Width, webBrowser.Height);
            //scale.Style = String.Format("width: {0}px; height: {1}px;", webBrowser.Width, webBrowser.Height);

          
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
               // WaitEvent = true;
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
                if(sw.ElapsedMilliseconds > 0)
                    Console.WriteLine("Time="+  sw.ElapsedMilliseconds);
                return Variable;
            }

        }
        /// <summary>
        /// This function for set any variable doesn't work with Fields object.
        /// For it task you need to use SetField()
        /// </summary>
        public static void SetVariable(WebBrowser webBrowser,string Variable, string Value, bool ValueIsNumber = false)
        {
            webBrowser.Document.InvokeScript("SetVariable", new Object[] {
                String.Format(
                 (ValueIsNumber?"TypeVarIsNum=1&":"") + 
                "{0}={1}",Variable,Value)});
        }

        public static void SetField(WebBrowser webBrowser, string NameMovie,string NameField, string Value, bool ValueIsNumber = false)
        {
            webBrowser.Document.InvokeScript("SetVariable", new Object[] {
                String.Format("CurMovie={0}&CurField={1}"+
                (ValueIsNumber?"&TypeVarIsNum=1":"") +
                "&SetVar={2}", NameMovie, NameField, Value) });   
        }

        public static string GetData(WebBrowser webBrowser, string NameMovie, string NameField)
        {
            ScriptInterface.WaitEvent = true;
            webBrowser.Document.InvokeScript("SetVariable", new Object[] {
                String.Format("CurMovie={0}&CurField={1}&GetData=1", NameMovie, NameField) });
            return ScriptInterface.ForWaitGetData();
        }

        public static string GetData(WebBrowser webBrowser,  string NameVariable)
        {
            ScriptInterface.WaitEvent = true;
            webBrowser.Document.InvokeScript("SetVariable", new Object[] { String.Format("CurField={0}&GetData=0", NameVariable) });
            return ScriptInterface.ForWaitGetData();
        }

        public static void RunFunc(WebBrowser webBrowser, string NameMovie, string NameFunc, string Value, bool FirstValueIsObject = false)
        {
            webBrowser.Document.InvokeScript("SetVariable", 
                new Object[] { String.Format("CurMovie={0}&CurField={1}"+
                ((FirstValueIsObject)?"&KindRunFunc=1" :"") + "&RunFunc={2}",  
                NameMovie , NameFunc , Value) });
        }

        public static string GetResultFunc(WebBrowser webBrowser)
        {
            return GetData(webBrowser, "GetResFunc");
        }
    }
}

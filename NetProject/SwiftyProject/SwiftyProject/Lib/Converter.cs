﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Threading;
using System.Globalization;

namespace SwiftyProject.Lib
{
    public class Converter
    {
        public static string ToString(params object[] args)
        {
            string str = "";
            for(int i = 0; i < args.Length; i++)
            {
                str += Convert.ToString(args[i], new CultureInfo("en-US"));
                str += (i < args.Length - 1) ? ";;" : "";
            }

            return str;
        }

        public static T StringTo<T>(string Value)
        {
            if (Value == String.Empty) { Value = "0"; };
            return (T)Convert.ChangeType(Value, typeof(T));
        }


    }
}

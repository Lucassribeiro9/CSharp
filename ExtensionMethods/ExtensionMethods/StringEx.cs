using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionMethods
{
    static class StringEx
    {
        public static string Cut(this string thisObj, int count)
        {
            if (thisObj.Length <= count)
            {
                return thisObj;
            }
            else
            {
                return thisObj.Substring(0, count) + "...";
            }
        }
    }
}

﻿using System;
using System.Globalization;


namespace ExtensionMethods
{
    static class DateEx
    {
        public static string ElapsedTime(this DateTime thisObj)
        {
            TimeSpan duration = DateTime.Now.Subtract(thisObj);
            if (duration.TotalHours < 24)
            {
                return duration.TotalHours.ToString("F1", CultureInfo.InvariantCulture) + " hours";
            }
            else
            {
                return duration.TotalDays.ToString("F1", CultureInfo.InvariantCulture) + " days";

            }
        }
    }
}

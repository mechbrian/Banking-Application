﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountsGui
{
    public static class Utils
    {
        //Brian changes it from private to internal
        internal static readonly DateTime BaseTime = new DateTime(2023, 1, 1, 0, 0, 0);

        // Returns the current time in the custom system's DayTime format
        public static long Now => (long)(DateTime.UtcNow - BaseTime).TotalMinutes;

        // Converts DayTime minutes to a readable format
        public static string ToString(long minutes)
        {
            var time = BaseTime.AddMinutes(minutes);
            return time.ToString("yyyy-MM-dd HH:mm");
        }
    }
}

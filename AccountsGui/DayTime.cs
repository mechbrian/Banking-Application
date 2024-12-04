using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountsGui
{
    public struct DayTime
    {
        private long minutes;

        public DayTime(long minutes)
        {
            this.minutes = minutes;
        }

        public static DayTime operator +(DayTime lhs, int additionalMinutes)
        {
            return new DayTime(lhs.minutes + additionalMinutes);
        }

        public override string ToString()
        {
            long years = minutes / 518_400;
            long remainingMinutes = minutes % 518_400;

            long months = remainingMinutes / 43_200;
            remainingMinutes %= 43_200;

            long days = remainingMinutes / 1_440;
            remainingMinutes %= 1_440;

            long hours = remainingMinutes / 60;
            long mins = remainingMinutes % 60;

            return $"{2023 + years:D4}-{months + 1:D2}-{days + 1:D2} {hours:D2}:{mins:D2}";
        }
    }
}

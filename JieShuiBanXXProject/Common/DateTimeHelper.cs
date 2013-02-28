using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
    public class DateTimeHelper
    {
        public static bool ISDateTimeNULL(DateTime datetime)
        {
            if (datetime.Year == 1)
            {
                return true;
            }

            if (datetime.Equals(DateTime.MinValue))
            {
                return true;
            }

            return false;
        }

        public static DateTime GetFirstDayDatetime(DateTime dt)
        {
            return new DateTime(dt.Year, dt.Month, dt.Day, 0, 0, 1);
        }

        public static DateTime GetLastDayDatetime(DateTime dt)
        {
            return new DateTime(dt.Year, dt.Month, dt.Day, 23, 59, 59);
        }
    }
}

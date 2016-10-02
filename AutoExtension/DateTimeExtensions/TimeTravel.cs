using System;

namespace AutoExtension.DateTimeExtensions
{
    public static class TimeTravel
    {

        public static int NextMonth(this DateTime value)
        {
            return value.AddMonths(1).Month;
        }

        public static int PreviousMonth(this DateTime value)
        {
            return value.AddMonths(-1).Month;
        }

    }
}

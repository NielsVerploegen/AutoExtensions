using System;

namespace AutoExtension.DateTimeExtensions
{
    public static class DateTimeQuestion
    {
        public static bool IsWeekend(this DateTime value)
        {
            return value.DayOfWeek == DayOfWeek.Sunday || value.DayOfWeek == DayOfWeek.Saturday;
        }

        public static bool IsWeekDay(this DateTime value)
        {
            return !value.IsWeekend();
        }

        public static bool IsLeapYear(this DateTime value)
        {
            return DateTime.DaysInMonth(value.Year, 2) == 29;
        }

        public static bool IsBetweenDateAndTime(this DateTime value, DateTime startDate, DateTime endDate)
        {
            return value >= startDate && value <= endDate;
        }

        public static bool IsBetweenDates(this DateTime value, DateTime startDate, DateTime endDate)
        {
            return value.Date >= startDate.Date && value.Date <= endDate.Date;
        }
    }
}

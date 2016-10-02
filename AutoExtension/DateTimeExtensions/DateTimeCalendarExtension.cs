using System;

namespace AutoExtension.DateTimeExtensions
{
    /// <summary>
    /// DateTimeCalendar Extensions for the DateTime class.
    /// Makes it possible to make claims on dates. i.e. : 
    /// - Is this a leap year ?
    /// - Is a date inside a range?
    ///  etc.
    /// </summary>
    public static class DateTimeCalendarExtension
    {
        /// <summary>
        /// Determines whether a given date is a Saturday or Sunday.
        /// </summary>
        /// <param name="value">The DateTime value.</param>
        /// <returns>True if it is a Saturday or a Sunday.</returns>
        public static bool IsWeekend(this DateTime value)
        {
            return value.DayOfWeek == DayOfWeek.Sunday || value.DayOfWeek == DayOfWeek.Saturday;
        }

        /// <summary>
        /// Determines whether a given date is a normal weekday.
        /// Monday, Tuesday, Wednesday, Thursday, Friday.
        /// </summary>
        /// <param name="value">The Datetime value.</param>
        /// <returns>True if it is NOT a Saturday or a Sunday.</returns>
        public static bool IsWeekDay(this DateTime value)
        {
            return !value.IsWeekend();
        }

        /// <summary>
        /// Determines whether a given date is between  a start date
        /// and end date, taking into account the time part of the DateTime.
        /// </summary>
        /// <param name="value">The DateTime value.</param>
        /// <param name="startDate">The start date.</param>
        /// <param name="endDate">The end date.</param>
        /// <returns>True if the DateTime value lies between the start and end date.</returns>
        public static bool IsBetweenDateAndTime(this DateTime value, DateTime startDate, DateTime endDate)
        {
            return value >= startDate && value <= endDate;
        }

        /// <summary>
        /// Determines whether a given date is between a start daten
        /// and end date, not taking into account the time part of the DateTime.
        /// </summary>
        /// <param name="value">The DateTime value.</param>
        /// <param name="startDate">The start date.</param>
        /// <param name="endDate">The end date.</param>
        /// <returns>True if the DateTime value lies between the start and end date.</returns>
        public static bool IsBetweenDates(this DateTime value, DateTime startDate, DateTime endDate)
        {
            return value.Date >= startDate.Date && value.Date <= endDate.Date;
        }

        /// <summary>
        /// Determines the number of days in the current month.
        /// </summary>
        /// <param name="value">The DateTime value.</param>
        /// <returns>The number of days.</returns>
        public static int NumberOfDaysInThisMonth(this DateTime value)
        {
            return new DateTime(value.Year, value.Month + 1, 1).AddDays(-1).Day;
        }

        /// <summary>
        /// Determines the numner of days left in the current month.
        /// </summary>
        /// <param name="value">The DateTime value.</param>
        /// <returns>The number of days left.</returns>
        public static int NumberOfDaysLeftInThisMonth(this DateTime value)
        {
            int daysThisMonth = value.NumberOfDaysInThisMonth();
            return daysThisMonth - value.Day;
        }
    }
}

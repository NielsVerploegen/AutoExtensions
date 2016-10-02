using System;

namespace AutoExtension.DateTimeExtensions
{
    /// <summary>
    /// TimeTravel Extensions for the DateTime class.
    /// </summary>
    public static class TimeTravel
    {
        #region public methods
        /// <summary>
        /// Increase the DateTime value with one year.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>Next Year.</returns>
        public static DateTime NextYear(this DateTime value)
        {
            return value.AddYears(1);
        }

        /// <summary>
        /// Decrease the DateTime value with one year.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>Previous Year.</returns>
        public static DateTime PreviousYear(this DateTime value)
        {
            return value.AddYears(-1);
        }

        /// <summary>
        /// Increase the DateTime value with one month.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>Next Month.</returns>
        public static DateTime NextMonth(this DateTime value)
        {
            return value.AddMonths(1);
        }

        /// <summary>
        /// Decrease the DateTime value with one month.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>Previous Month.</returns>
        public static DateTime PreviousMonth(this DateTime value)
        {
            return value.AddMonths(-1);
        }

        /// <summary>
        /// Increase the DateTime value with one day.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>Tomorrow.</returns>
        public static DateTime Tomorrow(this DateTime value)
        {
            return value.AddDays(1);
        }

        /// <summary>
        /// Decrease the DateTime value with one day.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>Yesterday.</returns>
        public static DateTime YesterDay(this DateTime value)
        {
            return value.AddDays(-1);
        }
        #endregion
    }
}

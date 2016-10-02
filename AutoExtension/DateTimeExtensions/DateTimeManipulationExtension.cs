using System;
using AutoExtension.Common.Validators;

namespace AutoExtension.DateTimeExtensions
{
    /// <summary>
    /// DateTime Manipulation Extensions for the DateTime class enables to manipulate
    /// the date and time.
    /// </summary>
    public static class DateTimeManipulationExtension
    {
        #region public methods
        #region date
        /// <summary>
        /// Increase the DateTime value with one year.
        /// </summary>
        /// <param name="value">The DateTime value.</param>
        /// <returns>The next year.</returns>
        public static DateTime NextYear(this DateTime value)
        {
            return value.AddYears(1);
        }

        /// <summary>
        /// Decrease the DateTime value with one year.
        /// </summary>
        /// <param name="value">The DateTime value.</param>
        /// <returns>The previous year.</returns>
        public static DateTime PreviousYear(this DateTime value)
        {
            return value.AddYears(-1);
        }

        /// <summary>
        /// Increase the DateTime value with one month.
        /// </summary>
        /// <param name="value">The DateTime value.</param>
        /// <returns>The next month.</returns>
        public static DateTime NextMonth(this DateTime value)
        {
            return value.AddMonths(1);
        }

        /// <summary>
        /// Decrease the DateTime value with one month.
        /// </summary>
        /// <param name="value">The DateTime value.</param>
        /// <returns>The previous month.</returns>
        public static DateTime PreviousMonth(this DateTime value)
        {
            return value.AddMonths(-1);
        }

        /// <summary>
        /// Increase the DateTime value with one day.
        /// </summary>
        /// <param name="value">The DateTime value.</param>
        /// <returns>The date of Tomorrow.</returns>
        public static DateTime Tomorrow(this DateTime value)
        {
            return value.AddDays(1);
        }

        /// <summary>
        /// Decrease the DateTime value with one day.
        /// </summary>
        /// <param name="value">The DateTime value..</param>
        /// <returns>The date of Yesterday.</returns>
        public static DateTime YesterDay(this DateTime value)
        {
            return value.AddDays(-1);
        }

        /// <summary>
        /// Get the last day of the month.
        /// </summary>
        /// <param name="value">The DateTime value.</param>
        /// <returns>The last day of the month.</returns>
        public static DateTime GetLastDayOfMonth(this DateTime value)
        {
            return new DateTime(value.Year, value.Month, 1).AddMonths(1).AddDays(-1);
        }

        /// <summary>
        /// Get first day of the month.
        /// </summary>
        /// <param name="value">The DateTime value.</param>
        /// <returns>The first day of the month.</returns>
        public static DateTime GetFirstDayOfMonth(this DateTime value)
        {
            return new DateTime(value.Year, value.Month, 1);
        }
        #endregion

        #region time
        /// <summary>
        /// Set the time to the given the hour.
        /// </summary>
        /// <param name="value">The DateTime value.</param>
        /// <param name="hour">The hour.</param>
        /// <returns>The DateTime set to the desired hour component.</returns>
        public static DateTime SetTime(this DateTime value, int hour)
        {
            return value.SetTime(hour, 0, 0, 0);
        }

        /// <summary>
        /// Set the time to the given hour and minutes.
        /// </summary>
        /// <param name="value">The DateTime value.</param>
        /// <param name="hour">The hour.</param>
        /// <param name="minute">The minute</param>
        /// <returns>The DateTime set to the desired hour and minute components.</returns>
        public static DateTime SetTime(this DateTime value, int hour, int minute)
        {
            return value.SetTime(hour, minute, 0, 0);
        }

        /// <summary>
        /// Set the time to the given hour, minutes and seconds.
        /// </summary>
        /// <param name="value">The DateTime value.</param>
        /// <param name="hour">The hour.</param>
        /// <param name="minute">The minute.</param>
        /// <param name="second">The second.</param>
        /// <returns>The DateTime set to the desired hour, minute and second components.</returns>
        public static DateTime SetTime(this DateTime value, int hour, int minute, int second)
        {
            return value.SetTime(hour, minute, second, 0);
        }

        /// <summary>
        /// Set the time to the given hours, minutes, seconds and milliseconds.
        /// </summary>
        /// <param name="value">The DateTime value.</param>
        /// <param name="hour">The hour.</param>
        /// <param name="minute">The minute.</param>
        /// <param name="second">The second.</param>
        /// <param name="millisecond">The millisecond</param>
        /// <returns>The DateTime set to the desired hour, minute, second and milliseconds components.</returns>
        public static DateTime SetTime(this DateTime value, int hour, int minute, int second, int millisecond)
        {
            TimeValidator.ValidateHour(hour);
            TimeValidator.ValidateMinute(minute);
            TimeValidator.ValidateSecond(second);
            TimeValidator.ValidateMilliSecond(millisecond);
            return new DateTime(value.Year, value.Month, value.Day, hour, minute, second, millisecond);
        }
        #endregion
        #endregion
    }
}

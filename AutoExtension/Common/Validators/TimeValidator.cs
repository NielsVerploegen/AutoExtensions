using System;

namespace AutoExtension.Common.Validators
{
    public static class TimeValidator
    {
        #region public constants
        /// <summary>
        /// The number of hours in a day.
        /// </summary>
        public const int NumberOfHoursInADay = 24;

        /// <summary>
        /// The number of minutes in an hour.
        /// </summary>
        public const int NumberOfMinutesInAnHour = 60;

        /// <summary>
        /// The number of seconds in a minute.
        /// </summary>
        public const int NumberOfSecondsInAMinute = 60;

        /// <summary>
        /// The number of milliseconds in a second.
        /// </summary>
        public const int NumberOfMilliSecondsInASecond = 1000;
        #endregion

        #region public methods
        /// <summary>
        /// Validate the hour part.
        /// </summary>
        /// <param name="hour">The hour.</param>
        public static void ValidateHour(int hour)
        {
            if (hour >= NumberOfHoursInADay || hour < 0)
            {
                throw new ArgumentException($"hour {hour} is not within a valid hour range 0-23.");
            }
        }

        /// <summary>
        /// Validate the minute part.
        /// </summary>
        /// <param name="minute">The minute.</param>
        public static void ValidateMinute(int minute)
        {
            if (minute >= NumberOfMinutesInAnHour || minute < 0)
            {
                throw new ArgumentException($"minute {minute} is not within a valid minute range 0-59.");
            }
        }

        /// <summary>
        /// Validate the second part.
        /// </summary>
        /// <param name="second">The second.</param>
        public static void ValidateSecond(int second)
        {
            if (second >= NumberOfSecondsInAMinute || second < 0)
            {
                throw new ArgumentException($"second {second} is not within a valid second range 0-59.");
            }
        }

        /// <summary>
        /// Validate the millisecond part.
        /// </summary>
        /// <param name="millisecond">The millisecond.</param>
        public static void ValidateMilliSecond(int millisecond)
        {
            if (millisecond >= NumberOfMilliSecondsInASecond || millisecond < 0)
            {
                throw new ArgumentException($"millisecond {millisecond} is not within a valid millisecond range 0-999.");
            }
        }
        #endregion
    }
}

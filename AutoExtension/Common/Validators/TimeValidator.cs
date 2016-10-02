using System;

namespace AutoExtension.Common.Validators
{
    public static class TimeValidator
    {
        #region public constants
        public const int NumberOfHoursInADay = 24;

        public const int NumberOfMinutesInAnHour = 60;

        public const int NumberOfSecondsInAMinute = 60;

        public const int NumberOfMilliSecondsInASecond = 1000;
        #endregion

        #region public methods
        public static void ValidateHour(int hour)
        {
            if (hour >= NumberOfHoursInADay || hour < 0)
            {
                throw new ArgumentException($"hour {hour} is not within a valid hour range 0-23.");
            }
        }

        public static void ValidateMinute(int minute)
        {
            if (minute >= NumberOfMinutesInAnHour || minute < 0)
            {
                throw new ArgumentException($"minute {minute} is not within a valid minute range 0-59.");
            }
        }

        public static void ValidateSecond(int second)
        {
            if (second >= NumberOfSecondsInAMinute || second < 0)
            {
                throw new ArgumentException($"second {second} is not within a valid second range 0-59.");
            }
        }

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

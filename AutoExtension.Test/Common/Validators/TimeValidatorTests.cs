using System;
using AutoExtension.Common.Validators;
using NUnit.Framework;

namespace AutoExtension.Test.Common.Validators
{
    [TestFixture]
    public class TimeValidatorTests
    {
        [Test]
        public void InvalidNegativeHourThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => TimeValidator.ValidateHour(-1));
        }

        [Test]
        public void InvalidNegativeMinuteThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => TimeValidator.ValidateMinute(-1));
        }

        [Test]
        public void InvalidNegativeSecondThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => TimeValidator.ValidateSecond(-1));
        }

        [Test]
        public void InvalidNegativeMillisSecondThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => TimeValidator.ValidateMilliSecond(-1));
        }

        [Test]
        public void InvalidPositiveHourThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => TimeValidator.ValidateHour(24));
        }

        [Test]
        public void InvalidPositiveMinuteThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => TimeValidator.ValidateMinute(60));
        }

        [Test]
        public void InvalidPositiveSecondThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => TimeValidator.ValidateSecond(60));
        }

        [Test]
        public void InvalidPostiveMilliSecondThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => TimeValidator.ValidateMilliSecond(1000));
        }
    }
}

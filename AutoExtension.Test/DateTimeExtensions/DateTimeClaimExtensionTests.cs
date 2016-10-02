using System;
using AutoExtension.DateTimeExtensions;
using NUnit.Framework;

namespace AutoExtension.Test.DateTimeExtensions
{
    [TestFixture]
    public class DateTimeClaimExtensionTests
    {
        [Test]
        public void IsWeekendReturnsTrueAtSaturday()
        {
            Assert.IsTrue(new DateTime(2016, 10, 1).IsWeekend());
        }

        [Test]
        public void IsWeekendReturnsTrueAtSunday()
        {
            Assert.IsTrue(new DateTime(2016, 10, 2).IsWeekend());
        }

        [Test]
        public void IsWeekDayReturnsTrueAtMonday()
        {
            Assert.IsTrue(new DateTime(2016, 10, 3).IsWeekDay());
        }

        [Test]
        public void IsWeekDayReturnsTrueAtTuesday()
        {
            Assert.IsTrue(new DateTime(2016, 10, 4).IsWeekDay());
        }

        [Test]
        public void IsWeekDayReturnsTrueAtWednesday()
        {
            Assert.IsTrue(new DateTime(2016, 10, 5).IsWeekDay());
        }

        [Test]
        public void IsWeekDayReturnsTrueAtThursday()
        {
            Assert.IsTrue(new DateTime(2016, 10, 6).IsWeekDay());
        }

        [Test]
        public void IsWeekDayReturnsTrueAtFriday()
        {
            Assert.IsTrue(new DateTime(2016, 10, 7).IsWeekDay());
        }

        [Test]
        public void IsWeekDayReturnsTrueWhenTheYearIsLeap()
        {
            Assert.IsTrue(new DateTime(2008, 1, 1).IsLeapYear());
        }

        [Test]
        public void IsWeekDayReturnsFalseWhenTheYearIsNotLeap()
        {
            Assert.IsFalse(new DateTime(2009, 1, 1).IsLeapYear());
        }

        [Test]
        public void IsBeteenDateTimeReturnsTrue()
        {
            bool betweenDateAndTime = new DateTime(2010, 1, 1, 11, 0, 0)
                .IsBetweenDateAndTime(new DateTime(2009, 1, 1),
                new DateTime(2010, 1, 1, 11, 1, 0));

            Assert.IsTrue(betweenDateAndTime);
        }

        [Test]
        public void IsBeteenDateTimeReturnsFalse()
        {
            bool betweenDateAndTime = new DateTime(2010, 1, 1, 11, 0, 0)
                .IsBetweenDateAndTime(
                new DateTime(2010, 1, 1, 11, 1, 0),
                new DateTime(2010, 1, 1, 11, 1, 0));

            Assert.IsFalse(betweenDateAndTime);
        }

        [Test]
        public void IsBetweenDatesReturnsTrue()
        {
            bool isBetweenDates = new DateTime(2010, 1, 1)
                .IsBetweenDates(
                new DateTime(2009, 1, 1),
                new DateTime(2011, 1, 1));

            Assert.IsTrue(isBetweenDates);
        }

        [Test]
        public void IsBetweenDatesReturnsFalse()
        {
            bool isBetweenDates = new DateTime(2010, 1, 1)
                .IsBetweenDates(
                new DateTime(2011, 1, 1),
                new DateTime(2011, 1, 1));

            Assert.IsFalse(isBetweenDates);
        }
    }
}

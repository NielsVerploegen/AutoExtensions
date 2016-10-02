using AutoExtension.DateTimeExtensions;
using NUnit.Framework;
using System;

namespace AutoExtension.Test.DateTimeExtensions
{
    [TestFixture]
    public class DateTimeManipulationExtensionTests
    {
        [Test]
        public void NextYearReturnsTheCorrectYear()
        {
            Assert.AreEqual(new DateTime(2010, 1, 1), new DateTime(2009, 1, 1).NextYear());
        }

        [Test]
        public void PreviousYearReturnsTheCorrectYear()
        {
            Assert.AreEqual(new DateTime(2010, 1, 1), new DateTime(2011, 1, 1).PreviousYear());
        }

        [Test]
        public void NextMonthReturnsTheCorrectMonth()
        {
            Assert.AreEqual(new DateTime(2015, 2, 1), new DateTime(2015, 1, 1).NextMonth());
        }

        [Test]
        public void PreviousMonthReturnsTheCorrectMonth()
        {
            Assert.AreEqual(new DateTime(2014, 12, 1), new DateTime(2015, 1, 1).PreviousMonth());
        }

        [Test]
        public void TomorrowReturnsTheCorrectDay()
        {
            Assert.AreEqual(new DateTime(2010, 1, 1), new DateTime(2009, 12, 31).Tomorrow());
        }

        [Test]
        public void YesterdayReturnsTheCorrectDay()
        {
            Assert.AreEqual(new DateTime(2009, 12, 31), new DateTime(2010, 1, 1).YesterDay());
        }

        [Test]
        public void LastDayOfMonthReturnsTheCorrectDay()
        {
            Assert.AreEqual(new DateTime(2016, 1, 31), new DateTime(2016, 1, 1).GetLastDayOfMonth());
        }

        [Test]
        public void FirstDayOfMonthReturnsTheCorrectDay()
        {
            Assert.AreEqual(new DateTime(2016, 1, 1), new DateTime(2016, 1, 31).GetFirstDayOfMonth());
        }

        [Test]
        public void SetTimeToHourSetsCorrectTime()
        {
            Assert.AreEqual(new DateTime(2016, 1, 1, 12, 0, 0), new DateTime(2016, 1, 1).SetTime(12));
        }

        [Test]
        public void SetTimeToHourAndMinutesSetsCorrectTime()
        {
            Assert.AreEqual(new DateTime(2016, 1, 1, 12, 45, 0), new DateTime(2016, 1, 1).SetTime(12, 45));
        }

        [Test]
        public void SetTimeToHourMinutesAndSecondsSetsCorrectTime()
        {
            Assert.AreEqual(new DateTime(2016, 1, 1, 12, 45, 30), new DateTime(2016, 1, 1).SetTime(12, 45, 30));
        }

        [Test]
        public void SetTimeToHourMinutesSecondsAndMilliSecondsSetsCorrectTime()
        {
            var datetime = new DateTime(2016, 1, 1).SetTime(12, 45, 30, 500);
            Assert.AreEqual(500, datetime.Millisecond);
        }
    }
}

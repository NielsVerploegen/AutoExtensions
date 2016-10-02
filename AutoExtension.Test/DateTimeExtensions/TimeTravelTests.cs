using AutoExtension.DateTimeExtensions;
using NUnit.Framework;
using System;

namespace AutoExtension.Test.DateTimeExtensions
{
    [TestFixture]
    public class TimeTravelTests
    {
        [Test]
        public void NextMonthReturnsTheCorrectMonthNumber()
        {
           Assert.AreEqual(2, new DateTime(2015, 1, 1).NextMonth());
        } 
    }
}

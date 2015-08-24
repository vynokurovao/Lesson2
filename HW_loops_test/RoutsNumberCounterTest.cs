using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HW_loops;

namespace HW_loops_test
{
    [TestClass]
    public class RoutsNumberCounterTest
    {
        [TestMethod]
        public void CountRoudsNumber_With0Clients()
        {
            uint n = 0;
            uint actual = RoutesNumberCounter.CountRoutesNumber(n);
            uint expected = 1;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CountRoudsNumber_With8Clients()
        {
            uint n = 8;
            uint actual = RoutesNumberCounter.CountRoutesNumber(n);
            uint expected = 40320;

            Assert.AreEqual(expected, actual);
        }
    }
}

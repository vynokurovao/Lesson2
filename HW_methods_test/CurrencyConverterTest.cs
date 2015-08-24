using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HW_methods;

namespace HW_methods_test
{
    [TestClass]
    public class CurrencyConverterTest
    {
        CurrencyConverter converter = new CurrencyConverter();
        [TestMethod]
        public void Convert_With_USD_to_UAH()
        {
            double actual = converter.convert("USD", "UAH", 10);
            double expected = 240;

            Assert.AreEqual(expected, actual, 0.001);
        }

        [TestMethod]
        public void Convert_With_CrossConvertation()
        {
            double startSum = 87;
            double newSum = converter.convert("USD", "PLN", startSum);
            double actual = converter.convert("PLN", "USD", newSum);

            Assert.AreEqual(startSum, actual, 0.001);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "There is no such currency in this converter")]
        public void Convert_WithInvalidCurrency()
        {
            double actual = converter.convert("IOP", "EUR", 90);
        }
    }
}

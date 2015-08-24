using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HW_logic;

namespace HW_logic_test
{
    [TestClass]
    public class BonusCalculatorTest
    {
        //double salary = 22456.80;

        [TestMethod]
        public void calculatePremium_With_0_5_YearsExperience()
        {
            double salary = 22546.80;
            uint experience = 2;
            double actualPremium = BonusCalculator.CalculateBonus(salary, experience);
            double expectedPremium = 2254.68;

            Assert.AreEqual(expectedPremium, actualPremium, 0.001);
        }

        [TestMethod]
        public void calculatePremium_With_5_10_YearsExperience()
        {
            double salary = 22546.80;
            uint experience = 7;
            double actualPremium = BonusCalculator.CalculateBonus(salary, experience);
            double expectedPremium = 3382.02;

            Assert.AreEqual(expectedPremium, actualPremium, 0.001);
        }

        [TestMethod]
        public void calculatePremium_With_10_15_YearsExperience()
        {
            double salary = 22546.80;
            uint experience = 10;
            double actualPremium = BonusCalculator.CalculateBonus(salary, experience);
            double expectedPremium = 5636.7;

            Assert.AreEqual(expectedPremium, actualPremium, 0.001);
        }

        [TestMethod]
        public void calculatePremium_With_15_20_YearsExperience()
        {
            double salary = 22546.80;
            uint experience = 16;
            double actualPremium = BonusCalculator.CalculateBonus(salary, experience);
            double expectedPremium = 7891.38;

            Assert.AreEqual(expectedPremium, actualPremium, 0.001);
        }

        [TestMethod]
        public void calculatePremium_With_20_25_YearsExperience()
        {
            double salary = 22546.80;
            uint experience = 23;
            double actualPremium = BonusCalculator.CalculateBonus(salary, experience);
            double expectedPremium = 10146.06;

            Assert.AreEqual(expectedPremium, actualPremium, 0.001);
        }

        [TestMethod]
        public void calculatePremium_WithMoreThen_25_YearsExperience()
        {
            double salary = 22546.80;
            uint experience = 32;
            double actualPremium = BonusCalculator.CalculateBonus(salary, experience);
            double expectedPremium = 11273.4;

            Assert.AreEqual(expectedPremium, actualPremium, 0.001);
        }
    }
}

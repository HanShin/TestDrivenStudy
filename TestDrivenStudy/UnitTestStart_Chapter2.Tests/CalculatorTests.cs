using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestStart_Chapter2.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        Calculator calc = null;
        [TestInitialize]
        public void Setup()
        {
            calc = new Calculator();
        }

        [TestMethod]
        public void Sum_NoAddCalls_DefaultsToZero()
        {
            int lastSum = calc.Sum();
            Assert.AreEqual(0, lastSum);
        }

        [TestMethod]
        public void Add_CalledOnce_SavesNumberForSum()
        {
            calc.Add(1);
            int lastSum = calc.Sum();
            Assert.AreEqual(1, lastSum);
        }
    }
}

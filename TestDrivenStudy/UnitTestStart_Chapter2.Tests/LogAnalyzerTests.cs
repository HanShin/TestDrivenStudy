using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestStart_Chapter2;

namespace UnitTestStart_Chapter2.Tests
{
    [TestClass]
    public class LogAnalyzerTests
    {
        private LogAnalyzer m_analyers = null;

        [TestInitialize]
        public void Setup()
        {
            m_analyers = new LogAnalyzer();
        }

        [TestMethod]
        public void IsValidFileName_validFileLowerCased_ReturnsTrue()
        {

            // 작용을 가함
            bool result = m_analyers.IsValidLogFileName("whatever.slf");

            // assert
            Assert.IsTrue(result, "파일 이름이 적절하지 않음!");
        }

        [TestMethod]
        public void IsValidFileName_validFileUpperCased_ReturnsTrue()
        {

            // 작용을 가함
            bool result = m_analyers.IsValidLogFileName("whatever.SLF");

            // assert
            Assert.IsTrue(result, "파일 이름이 적절하지 않음!");
        }

        [TestCleanup]
        public void TearDown()
        {
            m_analyers = null;
        }
    }
}

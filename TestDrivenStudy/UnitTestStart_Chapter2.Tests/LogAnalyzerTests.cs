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

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "파일 이름이 없음!")]
        public void IsValidFileName_EmptyFileName_ThrowsException()
        {
            m_analyers.IsValidLogFileName(string.Empty);
        }
        [TestMethod]
        [Ignore] // 이 테스트에는 문제가 있소
        public void IsValidFileName_ValidFie_ReturnsTrue()
        {
            // ...
        }

        [TestCleanup]
        public void TearDown()
        {
            m_analyers = null;
        }
    }
}

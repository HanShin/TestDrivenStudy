using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestStart_Chapter2;

namespace UnitTestStart_Chapter2.Tests
{
    [TestClass]
    public class LogAnalyzerTests
    {
        [TestMethod]
        public void IsValidFileName_validFileLowerCased_ReturnsTrue()
        {
            // 준비
            LogAnalyzer analyzer = new LogAnalyzer();

            // 작용을 가함
            bool result = analyzer.IsValidLogFileName("whatever.slf");

            // assert
            Assert.IsTrue(result, "파일 이름이 적절하지 않음!");
        }
    }
}

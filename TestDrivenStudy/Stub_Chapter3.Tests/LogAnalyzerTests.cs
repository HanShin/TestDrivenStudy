using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Stub_Chapter3.Tests
{
    [TestClass]
    public class LogAnalyzerTests
    {
        [TestMethod]
        public void IsValdFileName_NameShorterThan6CharsButSupportedExtension_ReturnsFalse()
        {
            StubExtensionManager myFakeManager = new StubExtensionManager();
            myFakeManager.ShouldExtensionBeValid = true;

            ExtensionManagerFactory.SetManager(myFakeManager);

            // Analyzer 생성 및 스텁 주입
            LogAnalyzer log = new LogAnalyzer();
            log.ExtensionManager = myFakeManager;
            bool result = log.IsValidLogFileName("short.ext");
            Assert.IsFalse(result, "지원되는 확장자라 하더라도 파일명이 다섯 글자 미만이면 안됨");
        }
    }
}

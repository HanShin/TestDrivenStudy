using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MockObject_Chapter5;

namespace IsolationFramework_Chapter5.Tests
{
    [TestClass]
    public class LogAnalyzerTests
    {
        [TestMethod]
        public void Analyze_TooShortFileName_CallsWebService()
        {
            ManualMockService mockService = new ManualMockService();
            LogAnalyzer log = new LogAnalyzer(mockService);
            string tooShortFileName = "abc.ext";
            log.Analyze(tooShortFileName);
            Assert.AreEqual("Filename too short : abc.ext", mockService.LastError);
        }
    }
}

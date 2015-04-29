using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MockObject_Chapter4.Tests
{
    [TestClass]
    public class LogAnalyzerTests
    {
        [TestMethod]
        public void Analyze_TooShortFileName_CallsWebService()
        {
            MockService mockService = new MockService();
            LogAnalyzer log = new LogAnalyzer(mockService);
            string tooShortFileName = "abc.ext";
            log.Analyze(tooShortFileName);

            Assert.AreEqual("Filename too short : abc.ext", mockService.LastError);
        }
    }
}

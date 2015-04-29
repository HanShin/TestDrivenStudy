using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MockObject_Chapter4.Tests
{
    [TestClass]
    public class LogAnalyzer2Tests
    {
        [TestMethod]
        public void Analyze_WebServiceThrows_SendsEmail()
        {
            StubService stubService = new StubService();
            stubService.ToThrow = new Exception("fake exception");

            MockEmailService mockEmail = new MockEmailService();

            LogAnalyzer2 log = new LogAnalyzer2();

            log.Service = stubService;
            log.Email = mockEmail;

            string tooShortFileName = "abc.ext";
            log.Analyze(tooShortFileName);
            Assert.AreEqual("a",mockEmail.To);
            Assert.AreEqual("fake exception",mockEmail.Body);
            Assert.AreEqual("subject",mockEmail.Subject);
        }
    }
}
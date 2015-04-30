using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rhino.Mocks;
using Rhino.Mocks.Constraints;

namespace MockObject_Chapter5.Tests
{
    [TestClass]
    public class LogAnalyzer2Tests
    {
        [TestMethod]
        public void Analyze_WebServiceThrows_SendsEmail()
        {
            MockRepository mocks = new MockRepository();
            IWebService stubService = mocks.Stub<IWebService>();

            IEmailService mockEmail = mocks.StrictMock<IEmailService>();

            using (mocks.Record())
            {
                stubService.LogError("aaa");
                LastCall.Constraints(Is.Anything());
                LastCall.Throw(new Exception("가짜 예외"));

                mockEmail.SendEmail("a","subject","가짜 예외");
            }

            LogAnalyzer2 log = new LogAnalyzer2();
            log.Service = stubService;
            log.Email = mockEmail;

            string tooShortFileName = "abc.ext";
            log.Analyze(tooShortFileName);

            mocks.VerifyAll();
        }
    }
}
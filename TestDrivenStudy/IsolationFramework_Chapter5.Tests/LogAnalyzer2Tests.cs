using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rhino.Mocks;
using Rhino.Mocks.Constraints;
using IsolationFramework_Chapter5;

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
        [TestMethod]
        public void SimpleStringConstraints()
        {
            MockRepository mocks = new MockRepository();
            IWebService mockService = mocks.CreateMock<IWebService>();

            using (mocks.Record())
            {
                mockService.LogError("무시된 문자열");
                LastCall.Constraints(new Contains("abc"));
            }

            mockService.LogError(Guid.NewGuid() + "abc");
            mocks.VerifyAll();

        }

    }
}
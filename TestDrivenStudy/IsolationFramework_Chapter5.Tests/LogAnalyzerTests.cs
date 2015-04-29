using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MockObject_Chapter5;
using Rhino.Mocks;

namespace IsolationFramework_Chapter5.Tests
{
    [TestClass]
    public class LogAnalyzerTests
    {
        [TestMethod]
        public void Analyze_TooShortFileName_CallsWebService()
        {
            MockRepository mocks = new MockRepository();
            IWebService simulatedService = mocks.StrictMock<IWebService>();
            using(mocks.Record())
            {
                simulatedService.LogError("Filename too short : abc.ext");
            }
            LogAnalyzer log = new LogAnalyzer(simulatedService);
            string tooShortFileName = "abc.ext";
            log.Analyze(tooShortFileName);
            mocks.Verify(simulatedService);
        }
    }
}

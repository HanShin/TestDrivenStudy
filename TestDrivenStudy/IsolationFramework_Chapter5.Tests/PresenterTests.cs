using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rhino.Mocks;
using MockObject_Chapter5;
using Rhino.Mocks.Interfaces;
using Rhino.Mocks.Impl;

namespace IsolationFramework_Chapter5.Tests
{
    [TestClass]
    public class PresenterTests
    {
        [TestMethod]
        public void VerifyAttachesToViewEvents()
        {
            MockRepository mocks = new MockRepository();
            IView viewMock = (IView)mocks.CreateMock(typeof(IView));

            using (mocks.Record())
            {
                viewMock.Load += null;
                LastCall.IgnoreArguments();
            }
            new Presenter(viewMock);
            mocks.VerifyAll();

        }

        [TestMethod]
        public void TriggerAndVerifyRespondingToEvents()
        {
            MockRepository mocks = new MockRepository();
            IView viewStub = mocks.Stub<IView>();
            IWebService serviceMock = mocks.CreateMock<IWebService>();
            using(mocks.Record())
            {
                serviceMock.LogInfo("view loaded");
            }
            new Presenter(viewStub, serviceMock);

            IEventRaiser eventer = EventRaiser.Create(viewStub, "Load");
            eventer.Raise(null, EventArgs.Empty);

            mocks.Verify(serviceMock);
        }
        
        /// <summary>
        /// 기록 및 재생(Record-and-Replay) 방식
        /// </summary>
        [TestMethod]
        public void CreateMock_WithReplayAll()
        {
            MockRepository mockEngine = new MockRepository();

            IWebService simulatedService = mockEngine.DynamicMock<IWebService>();
            using(mockEngine.Record())
            {
                simulatedService.LogError("파일명이 너무 짧음:abc.ext");
            }
            LogAnalyzer log = new LogAnalyzer(simulatedService);
            string tooShortFileName = "abc.ext";
            log.Analyze(tooShortFileName);
            mockEngine.Verify(simulatedService);
        }

        /// <summary>
        /// 준비-작용-assert (AAA:Areange-Act-Assert) 문법으로 작성
        /// </summary>
        [TestMethod]
        public void CreateMock_WithReplayAll_AAA()
        {
            MockRepository mockEngine = new MockRepository();
            IWebService simualtedService = mockEngine.DynamicMock<IWebService>();
            LogAnalyzer log = new LogAnalyzer(simualtedService);

            mockEngine.ReplayAll();
            log.Analyze("abc.ext");

            simualtedService.AssertWasCalled(svc => svc.LogError("파일명이 너무 짧음:abc.ext"));
        }
    }
}

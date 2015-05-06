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
    }
}

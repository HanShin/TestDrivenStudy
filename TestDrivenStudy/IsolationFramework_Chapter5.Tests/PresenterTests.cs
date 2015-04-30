using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rhino.Mocks;

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
    }
}

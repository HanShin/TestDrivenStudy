using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsolationFramework_Chapter5.Tests
{
    public class StubService : IWebService
    {
        public Exception ToThrow;
        #region IWebService Members

        public void LogError(string message)
        {
            throw ToThrow;
        }

        #endregion

        #region IWebService Members


        public void LogInfo(string log)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}

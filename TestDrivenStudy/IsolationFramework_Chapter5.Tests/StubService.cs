using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockObject_Chapter5
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
    }
}

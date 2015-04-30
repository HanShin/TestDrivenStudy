using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockObject_Chapter5
{
    public class MockService : IWebService
    {
        public string LastError;

        #region IWebService Members

        public void LogError(string message)
        {
            LastError = message;
        }

        #endregion
    }
}

﻿using MockObject_Chapter5;

namespace IsolationFramework_Chapter5.Tests
{
    public class ManualMockService : IWebService
    {
        public string LastError;

        #region IWebService Members

        public void LogError(string message)
        {
            LastError = message;
        }

        #endregion

        #region IWebService Members


        public void LogInfo(string log)
        {
            throw new System.NotImplementedException();
        }

        #endregion
    }
}

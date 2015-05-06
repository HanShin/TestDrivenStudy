using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOrgranization_Chapter6.Tests
{
    public class BaseTestClass
    {
        [TestInitialize]
        public void SetUp()
        {
            Console.WriteLine("in setup");
            LoggingFacility.Logger = new StubLogger();
        }
    }
}

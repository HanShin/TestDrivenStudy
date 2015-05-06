using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestOrgranization_Chapter6.Tests
{
    [TestClass]
    public class ConfigurationManagerTests
    {
        [TestMethod]
        public void Analyze_Empty_ThrowsException()
        {
            ConfigurationManager cm = new ConfigurationManager();
            bool configured = cm.IsConfigured("aa");
        }
    }
}

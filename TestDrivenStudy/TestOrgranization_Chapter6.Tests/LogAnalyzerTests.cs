using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestOrgranization_Chapter6.Tests
{
    [TestClass]
    public class LogAnalyzerTests
    {
        [TestInitialize]
        public void SetUp()
        {
            LoggingFacility.Logger = new StubLogger();
        }

        [TestMethod]
        public void Anlyze_EmptyFile_ThrowsException()
        {
            LogAnalyzer la = new LogAnalyzer();
            la.Analyze("myemptyfile.txt");
        }
    }
}

﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestOrgranization_Chapter6.Tests
{
    [TestClass]
    public class LogAnalyzerTests : BaseTestClass
    {
        [TestMethod]
        public void Anlyze_EmptyFile_ThrowsException()
        {
            LogAnalyzer la = new LogAnalyzer();
            la.Analyze("myemptyfile.txt");
        }
    }
}

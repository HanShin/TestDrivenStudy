using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stub_Chapter3.Tests
{
    class TestableLogAnalyzer : LogAnalyzerUsingFactoryMethod
    {
        public IExtensionManager Manager;

        protected override IExtensionManager GetManager()
        {
            return Manager;
        }
    }
}

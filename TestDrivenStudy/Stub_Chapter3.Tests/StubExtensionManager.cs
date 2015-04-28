using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stub_Chapter3.Tests
{
    internal class StubExtensionManager : IExtensionManager
    {
        public bool ShouldExtensionBeValid;

        public bool IsValid(string fileName)
        {
            return ShouldExtensionBeValid;
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stub_Chapter3
{
    public class LogAnalyzer
    {
        private IExtensionManager manager;

        public LogAnalyzer()
        {
            manager = ExtensionManagerFactory.Create();
        }

        public IExtensionManager ExtensionManager 
        {
            get { return manager; }
            set { manager = value; }
        }

        public bool IsValidLogFileName(string fileName)
        {
            return manager.IsValid(fileName) && Path.GetFileNameWithoutExtension(fileName).Length > 5;
        }
    }
}

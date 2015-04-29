using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stub_Chapter3
{
    public class LogAnalyzerUsingFactoryMethod
    {
        public bool IsValidLogFileName(string fileName)
        {
            int len = fileName.Length;
            return this.IsValid(fileName) && len > 5;
        }
        protected virtual bool IsValid(string fileName)
        {
            FileExtensionManager mgr = new FileExtensionManager();
            return mgr.IsValid(fileName);
        }
        protected virtual IExtensionManager GetManager()
        {
            return new FileExtensionManager();
        }
    }
}

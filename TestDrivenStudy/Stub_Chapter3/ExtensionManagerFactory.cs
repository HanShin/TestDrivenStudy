using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stub_Chapter3
{
    public class ExtensionManagerFactory
    {
        private static IExtensionManager customManger = null;
        public static IExtensionManager Create()
        {
            if(customManger != null)
            {
                return customManger;
            }
            return new FileExtensionManager();
        }

        public static void SetManager(IExtensionManager mgr)
        {
            customManger = mgr;
        }
    }
}

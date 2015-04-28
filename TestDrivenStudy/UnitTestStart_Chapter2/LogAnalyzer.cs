using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestStart_Chapter2
{
    public class LogAnalyzer
    {
        public bool IsValidLogFileName(string fileName)
        {
            if (!fileName.ToLower().EndsWith(".slf"))
            {
                return false;
            }
            return true;
        }
    }
}

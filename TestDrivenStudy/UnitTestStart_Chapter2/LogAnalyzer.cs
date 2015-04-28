using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestStart_Chapter2
{
    public class LogAnalyzer
    {
        private bool wasLastFileNameValid;

        public bool WasLastFileNameVald
        {
            get { return wasLastFileNameValid; }
            set { wasLastFileNameValid = value; }
        }
        public bool IsValidLogFileName(string fileName)
        {
            if (!fileName.ToLower().EndsWith(".slf"))
            {
                wasLastFileNameValid = false;
                return false;
            }
            wasLastFileNameValid = true;
            return true;
        }
    }
}

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
            if(String.IsNullOrEmpty(fileName))
            {
                throw new ArgumentException("파일 이름이 없음!");
            }

            if (!fileName.EndsWith(".SLF"))
            {
                return false;
            }
            return true;
        }
    }
}

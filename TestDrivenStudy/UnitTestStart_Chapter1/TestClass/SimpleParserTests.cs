using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestStart_Chapter1.Code;

namespace UnitTestStart_Chapter1.TestClass
{
    class SimpleParserTests
    {
        public static void TestReturnsZeroWhenEmptyString()
        {
            try
            {
                SimpleParser p = new SimpleParser();
                int result = p.ParseAndSum(string.Empty);
                if (result != 0)
                {
                    Console.WriteLine(@"SimplePArserTests.TestReturnsZeroWhenEmptyString: ParseAndSum은 빈 문자열에 대해 0을 반환해야한다.");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestStart_Chapter1.TestClass;

namespace UnitTestStart_Chapter1
{
    class Program
    {
        static void Main(string[] args)
        {
            try 
            {
                SimpleParserTests.TestReturnsZeroWhenEmptyString();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}

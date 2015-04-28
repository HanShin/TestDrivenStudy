using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using UnitTestStart_Chapter1.Code;

namespace UnitTestStart_Chapter1.TestClass
{
    public class TestUtil
    {
        public static void ShowProblem(string test, string message)
        {
            string msg = string.Format(@"---{0}---{1}------------------------ ",test ,message);
            Console.WriteLine(msg);
        }

        public static void TestReturnsZeroWhenEmptyString()
        {
            // 현재 메서드의 이름을 얻기위해 리플렉션 API사용.
            string testName = MethodBase.GetCurrentMethod().Name;
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
                TestUtil.ShowProblem(testName, e.ToString());
            }
        }
    }
}

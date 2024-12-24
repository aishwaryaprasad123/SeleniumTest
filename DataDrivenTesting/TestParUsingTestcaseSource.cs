using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitTraning.DataDrivenTesting
{
    internal class TestParUsingTestcaseSource
    {
        [Test, TestCaseSource("GetTestData")]
        public void LoginTest(string username, string password)
        {
            Console.WriteLine(username+":"+ password);

        }
        public static IEnumerable<TestCaseData> GetTestData()
        {
            yield return new TestCaseData("abc.com", "gghh");
            yield return new TestCaseData("bcd.com", "eweer");
            yield return new TestCaseData("abcd.com", "eretr");
            yield return new TestCaseData("bca.com", "ererr");

        }
        

        }
    }


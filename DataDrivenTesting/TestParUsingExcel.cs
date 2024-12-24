using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NunitTraning.Utilites;

namespace NunitTraning.DataDrivenTesting
{
    internal class TestParUsingExcel: ExcelRead
    {
        [Test, TestCaseSource("GetTestData")]
        public void LoginTest(string username, string password)
        {
            Console.WriteLine(username + ":" + password);

        }


        public static IEnumerable<TestCaseData> GetTestData()
        {
            var columns = new List<string> {"username", "password"};
            return ExcelRead.GetTestDataFromExcel("C:\\Users\\apras\\source\\repos\\NunitTraning\\NunitTraning\\testdata.xlsx","LoginTest", columns);
           

        }

    }
}

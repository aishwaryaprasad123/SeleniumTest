using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitTraning.NunitTests
{
    internal class Test1
    {
        [Test, Description("First TestCase")]
        public void test1()
        {
            Console.WriteLine("First test case 1 is executed");
        }
    }
}

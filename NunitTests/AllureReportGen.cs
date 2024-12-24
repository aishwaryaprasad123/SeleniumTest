using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitTraning.NunitTests
{
    [Allure.NUnit.AllureNUnit]
    internal class AllureReportGen
    {
       
        [Test]
        public void login()
        {
            Console.WriteLine(" user logging in page");
        }

        [Test]
        public void product()
        {
            Console.WriteLine(" user product ");
        }


        [Test]

        public void addtocart()
        {
            Console.WriteLine(" product added to the cart");
        }

    }
}

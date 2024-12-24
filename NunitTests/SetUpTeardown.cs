using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitTraning.NunitTests
{
    internal class SetUpTeardown
    {
        [SetUp,Order(2)]
        public void launchbrowser()
        {
            Console.WriteLine("Launching the browser");

        }
      
        [TearDown]
        public void closebrowser()
        {
            Console.WriteLine("Closing the browser");

        }

        [Test, Order(1)]
        public void userreg()
        {
            Console.WriteLine("user registeration");
        }

        [Test, Order(2)]
        public void login()
        {
            Console.WriteLine("user logging in page");
        }

        [Test, Order(3)]
        public void product()
        {
            Console.WriteLine("user product ");
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitTraning.NunitTests
{
    internal class Categories
    {
        

        [Test, Order(1), Category("Sanity")]
        public void userreg()
        {
            Console.WriteLine("user registeration");
        }

        [Test, Order(2), Category("Registration")]
        public void login()
        {
            Console.WriteLine("user logging in page");
        }

        [Test, Order(3), Category("Registration")]
        public void product()
        {
            Console.WriteLine("user product ");
        }

    }
}

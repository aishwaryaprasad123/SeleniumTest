using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitTraning.NunitTests
{
    internal class Ignoretests
    {

        [Test, Order(1) ]
        [Ignore("defect ID 1234")]
        public void userreg()
        {
            Console.WriteLine(" user registeration page");
        }

        [Test, Order(2)]
        public void login()
        {
            Console.WriteLine(" user logging in page");
        }

        [Test, Order(3)]
        public void product()
        {
            Console.WriteLine(" user product ");
        }

        [Test, Order(4)]
        public void Buy()
        {
            Console.WriteLine(" user Buy");
        }
    }
}

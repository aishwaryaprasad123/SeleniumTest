using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitTraning.NunitTests
{
    [Parallelizable(ParallelScope.All)]
    internal class ParallelExecution
    {
        [Test]
        public void userreg()
        {
            Console.WriteLine(" user registeration page");
        }

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
    }
}

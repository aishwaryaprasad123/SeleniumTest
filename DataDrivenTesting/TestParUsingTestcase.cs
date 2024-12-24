using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitTraning.DataDrivenTesting
{
    [TestFixture(12, 3, 4)]
    [TestFixture(12, 2, 6)]
    [TestFixture(12, 4, 3)]
    internal class TestParUsingTestcase
    {
        
        public void DivideTest(int n, int d, int q)
        {
            Assert.That(n / d, Is.EqualTo(q));
        }
    }
}

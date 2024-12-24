using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitTraning.NunitTests
{
    [TestFixture(2,3)]
    [TestFixture(4,8)]
    [TestFixture(6,7)]
    internal class ParameterizedestFixturee
    {
        private readonly int _a;
        private readonly int _b;

        public ParameterizedestFixturee(int a , int b)
        {
            _a = a;
            _b = b;
        }
        [Test]
        public void TestSum()
        {
            Assert.AreEqual(_a + _b ,_a*1+_b*1);
        }

        [Test]
        public void TestSub()
        {
            Assert.AreEqual(_a * _b, _b * _a);
        }
    }
}

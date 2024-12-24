using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework.Constraints;

namespace NunitTraning.NunitTests
{
    internal class Assertion
    {
        [Test]
        public void AssertionEg()
        {
            String actual = "hey";
            String expected = "hello";

            if (actual == expected)
            {
                Console.WriteLine("matching");

            }
            else
            {
                Console.WriteLine("not matching");
            }
           // Assert.AreEqual(expected, actual);//fail
            Assert.AreNotEqual(expected, actual);//pass
           // Assert.AreSame(expected, actual);//fail
            Assert.AreNotSame(expected, actual);//pass

            //assert.that
            //Assert.That(actual, Is.EqualTo(expected));
           // Assert.That(actual, Is.Not.EqualTo(expected));
            //qassert for staribgs with ignore case
           // Assert.That(actual,Is.EqualTo(expected).IgnoreCase);


            //substring
            //Assert.That(actual, Does.Not.Contain("hey").IgnoreCase);

            //empty assertion

           // Assert.IsTrue(actual.Equals(expected));
            //Assert.IsEmpty(actual);
           // Assert.IsNull(actual);
            //Assert.IsNotNull(actual);


            //collection constraints
            int[] array = new int[] { 1, 2, 3, 4,5,6 };
            //Assert.NotNull(actual);
            Assert.That(array, Is.All.GreaterThan(0));
            //Assert.IsEmpty(array);
            //Assert.That(array, Is.Ordered.Ascending);
            //int age = 17;
            //if (age < 18)
            //{
            //    throw new AssertionException("User is not eligible for voting");
            //}

        }
    }
}

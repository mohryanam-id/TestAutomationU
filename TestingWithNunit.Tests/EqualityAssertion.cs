using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingWithNunit.Tests
{
    [TestFixture]
    public class EqualityAssertion
    {
        private const string Actual = "actual";
        private const int Actual1 = 2;
        private const int Actual2 = 23;

        [Test]
        public void AreEqual()
        {
            Assert.That(Actual, Is.EqualTo("expected"));
        }

        [Test]
        public void AreEqualWithDescription()
        {
            Assert.That(Actual, Is.EqualTo("Expected"), "What does this even mean");
        }

        [Test]
        public void AreEqualWithDynamicDescription()
        {
            Assert.That(Actual, Is.EqualTo("Expected"), "What does {0} mean to {1}","Testing", "you");
        }

        [Test]
        public void AreEqualNumber()
        {
            Assert.That(Actual1, Is.EqualTo(1));
        }


        [Test]
        public void AreEqualNumberWithTolerance()
        {
            Assert.That(Actual2, Is.EqualTo(2).Within(.5));
        }
    }
}

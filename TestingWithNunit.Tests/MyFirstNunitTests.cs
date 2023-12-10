using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestingWithNunit.Tests
{
    public class MyFirstNunitTests
    {
        private const bool Actual = true;

        [Test]
        public Task IAmDoingGreat()
        {
            Console.WriteLine("See you in the test output!");
            Assert.That(Actual, Is.True);
            return Task.CompletedTask;
        }
    }
}

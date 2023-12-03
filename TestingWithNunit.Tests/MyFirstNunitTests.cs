using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestingWithNunit.Tests
{
    internal class MyFirstNunitTests
    {
        [Test]
        public Task IAmDoingGreat()
        {
            Console.WriteLine("See you in the test output!");
            Assert.True(true);
            return Task.CompletedTask;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalcultorLib;
using NUnit.Framework;


namespace CalculatorLibTests
{
    [TestFixture]
    public class CalculatorTest
    {
        Calculator ob = new Calculator();
        [Test]
        [TestCase(-10,7)]
        [TestCase(0,0)]
        public void Add_for_Zero(int a, int b)
        {
            int res = ob.Add(a, b);
            Assert.That(res, Is.EqualTo(0));
        }

        [Test]
        [TestCase(5,4)]
        [TestCase(8,9)]
        public void Add_For_Sum(int a, int b)
        {
            int res = ob.Add(a, b);
            Assert.That(res, Is.EqualTo(a + b));
        }
    }
}

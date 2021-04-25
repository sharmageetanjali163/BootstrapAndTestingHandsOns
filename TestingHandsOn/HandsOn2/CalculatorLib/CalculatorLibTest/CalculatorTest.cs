using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorLib;
using NUnit.Framework;

namespace CalculatorLibTest
{
    [TestFixture]
    [Category("Math")]
    [Author("Geetanjalee", "Geetanjalee.Sharma@cognizant.com")]
    public class CalculatorTest
    {
        Calculator ob = new Calculator();
        [Test,Order(1)]
        [TestCaseSource(nameof(TestCases))]
        public void AddTest(int a, int b)
        {
            int res = ob.Add(a, b);
            Assert.That(res, Is.EqualTo(a + b));
        }


        [Test,Order(4)]
        [TestCaseSource(nameof(TestCases))]
        public void SubTest(int a, int b)
        {
            int res = ob.Sub(a, b);
            Assert.That(res, Is.EqualTo(a - b));
        }

        [Test,Order(3)]
        [TestCaseSource(nameof(TestCases))]
        public void MultiplyTest(int a, int b)
        {
            int res = ob.Multiply(a, b);
            Assert.That(res, Is.EqualTo(a * b));
        }

        [Test,Order(2)]
        [TestCaseSource(nameof(TestCases))]
        [Ignore("Ignore Division")]
        public void DivideTest(int a, int b)
        {
            int res = ob.Divide(a, b);
            if(b==0)
            {
                Assert.That(res, Is.EqualTo(0));
            }
            else
            {
                Assert.That(res, Is.EqualTo(a / b));
            }
            
        }

        static readonly object[] TestCases =
        {
            new object[] {1,1},
            new object[] {-2,9},
            new object[] {0,5},
            new object[] {22,98},
            new object[] {-9,0}
        };
    }
}

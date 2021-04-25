using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using MathLibrary;


namespace MathLibTest
{
    [TestFixture]
    public class MathTest
    {
        MathLib ob = new MathLib();

        [Test]
        [TestCaseSource(nameof(CompareTwoNumberTestData))]
        public void CompareTwoNumbers_Test(int a, int b, int c)
        {
            int res = ob.CompareTwoNumbers(a, b);
            Assert.That(res, Is.EqualTo(c));
        }

        private static IEnumerable <TestCaseData> CompareTwoNumberTestData
        {
            get
            {
                yield return new TestCaseData(-1, 0, 0);
                yield return new TestCaseData(1,2,-1);
                yield return new TestCaseData(2,1,1);
            }
        }
    }
}

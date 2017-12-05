using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeWars;

namespace CodeWarsUT
{
    [TestClass]
    public class PlayingWithDigits
    {
        public void Tester(int number, int factor, int expectedResult)
        {
            Assert.AreEqual(expectedResult, NumericHelper.PlayingWithDigits(number, factor));
        }
        [TestMethod]
        public void Should_resolve_the_mathematic_problem_its_to_complicated_to_explain()
        {
            Tester(89, 1, 1);
            Tester(92, 1, -1);
            Tester(695, 2, 2);
            Tester(46288, 3, 51);
        }

    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeWarsUT
{
    [TestClass]
    public class WeightSort
    {
        [TestMethod]
        public void Tester(string original, string expected)
        {
            Assert.AreEqual(expected, CodeWars.WeightSort.orderWeight(original));
        }


        [TestMethod]
        public void Should_return_weights_sorted_by_sum_of_its_digits()
        {
            //Tester("103 123 4444 99 2000", "2000 103 123 4444 99");
            Tester("2000 10003 1234000 44444444 9999 11 11 22 123", "11 11 2000 10003 22 123 1234000 44444444 9999");
        }
    }
}

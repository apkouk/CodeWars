using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeWars;

namespace CodeWarsUT
{
    [TestClass]
    public class TripleTrouble
    {
        private void Tester(long number1, long number2, int result)
        {
            Assert.IsTrue(NumericHelper.FindTripleAndDouble(number1, number2) == result);
        }

        [TestMethod]
        public void Find_same_number_x3_in_first_number_and_x2_in_second_number()
        {
            Tester(451999277, 41177722899, 1);
            Tester(1222345, 12345, 0);
            Tester(12345, 12345, 0);
            Tester(666789, 12345667, 1);
            Tester(10560002, 100, 1);
            Tester(843374555, 785154534, 0);
            Tester(843375055, 554247326, 0);
            Tester(843375055, 105653492, 0);
            Tester(44922420, 22513017, 0);
            Tester(44922420, 554247326, 0);

        }
    }
}

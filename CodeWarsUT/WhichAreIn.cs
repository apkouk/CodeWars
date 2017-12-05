using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeWarsUT
{
    [TestClass]
    public class WhichAreIn
    {
        private void Tester(string[] expected, string[] array1, string[] array2)
        {
            string[] result = StringHelper.WhichAreIn(array1, array2);
            CollectionAssert.AreEqual(expected, result);            
        }

        [TestMethod]
        public void Should_return_which_substrings_exist_on_the_second_array()
        {
            string[] a1 = new string[] { "arp", "live", "strong" };
            string[] a2 = new string[] { "lively", "alive", "harp", "sharp", "armstrong" };
            string[] r = new string[] { "arp", "live", "strong" };
            Tester(r, a1, a2);
        }
    }
}

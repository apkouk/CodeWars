using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using CodeWars;

namespace CodeWarsUT
{
    [TestClass]
    public class RemoveTheMinimum
    {    
        private void Tester(List<int> argument, List<int> expectedResult)
        {
            CollectionAssert.AreEqual(expectedResult, NumericHelper.RemoveSmallestIntegerFromCollection(argument));
        }
        [TestMethod]
        public void Should_return_a_collection_with_the_smallest_integer_deleted()
        {
            Tester(new List<int> { 1, 2, 3, 4, 5 }, new List<int> { 2, 3, 4, 5 });
            Tester(new List<int> { 5, 3, 2, 1, 4 }, new List<int> { 5, 3, 2, 4 });
            Tester(new List<int> { 1, 2, 3, 1, 1 }, new List<int> { 2, 3, 1, 1 });
        }
    }
}

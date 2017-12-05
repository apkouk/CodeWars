using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CodeWarsUT
{
    [TestClass]
    public class ShortestWord
    {
        private void Tester(int expectedResult, string phrase)
        {
            Assert.AreEqual(expectedResult, StringHelper.FindShortestWordIn(phrase));
        }
        [TestMethod]
        public void Should_return_the_smallest_word_in_a_string()
        {
            Tester(3, "bitcoin take over the world maybe who knows perhaps");
            Tester(2, "turns ut random test cases are easier than writing out basic ones");
        }
    }
}

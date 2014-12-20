using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzz;

namespace FizzBuzz.Test
{
    [TestClass]
    public class FizzBuzzTests
    {
        [TestMethod]
        public void ReturnCustomFizzBuzz()
        {
            Dictionary<int, string> parameters = new Dictionary<int, string>() {
                {3, "Fizz"},
                {5, "Buzz"},
                {10, "WooHoo"}
            };
            
            int inclusiveUpperBound = 100;

            List<string> results = FizzBuzz.ReturnCustomFizzBuzz(inclusiveUpperBound, parameters).ToList();

            // Make sure we returned enough results.
            Assert.AreEqual(inclusiveUpperBound, results.Count);

            // Make sure the number 3 was replaced with Fizz.
            Assert.AreEqual("Fizz", results[2]);

            // Make sure the number 90 was replaced with FizzBuzzWooHoo.
            Assert.AreEqual("FizzBuzzWooHoo", results[89]);
        }
    }
}

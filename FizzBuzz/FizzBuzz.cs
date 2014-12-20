using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public static class FizzBuzz
    {
        /// <summary>
        /// Performs the classic FizzBuzz number replacement calculation using a custom upper bound and dictionary of divisors and replacement words.
        /// </summary>
        /// <param name="upperBound">The inclusive upper bound of the numbers to replace.</param>
        /// <param name="parameters">The list of divisors and words to use as replacements.</param>
        /// <returns>An enumerable string of results.</returns>
        public static IEnumerable<string> ReturnCustomFizzBuzz(int upperBound, IDictionary<int, string> parameters)
        {
            for (var i = 1; i <= upperBound; i++)
            {
                string s = string.Empty;

                // Loop through each pair of divisors and add the corresponding replacement word if eligible.
                foreach (var pair in parameters)
                {
                    if (i % pair.Key == 0)
                        s += pair.Value;
                }                

                // If no divisors were eligible write out the current number.
                if (string.IsNullOrEmpty(s))
                    s += i.ToString();

                yield return s;         
            }
        }
    }
}

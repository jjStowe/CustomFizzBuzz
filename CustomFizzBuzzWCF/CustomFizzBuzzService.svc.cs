using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace CustomFizzBuzzWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class CustomFizzBuzzService : ICustomFizzBuzzService
    {
        /// <summary>
        /// Performs the classic FizzBuzz number replacement calculation using a custom upper bound and dictionary of divisors and replacement words.
        /// </summary>
        /// <param name="upperBound">The inclusive upper bound of the numbers to replace.</param>
        /// <param name="parameters">The list of divisors and words to use as replacements.</param>
        /// <returns>An enumerable string of results.</returns>
        public IEnumerable<string> CustomFizzBuzz(int inclusiveUpperBound, IDictionary<int, string> parameters)
        {
            return FizzBuzz.FizzBuzz.ReturnCustomFizzBuzz(inclusiveUpperBound, parameters);
        }        
    }
}

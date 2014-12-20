using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace CustomFizzBuzzWCF
{    
    [ServiceContract]
    public interface ICustomFizzBuzzService
    {
        /// <summary>
        /// Performs the classic FizzBuzz number replacement calculation using a custom upper bound and dictionary of divisors and replacement words.
        /// </summary>        
        [OperationContract]
        IEnumerable<string> CustomFizzBuzz(int inclusiveUpperBound, IDictionary<int, string> parameters);        
    }
}

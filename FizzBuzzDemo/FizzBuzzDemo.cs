using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzz;

namespace FizzBuzzDemo
{
    class FizzBuzzDemo
    {
        static void Main(string[] args)
        {
            // The list of parameters to pass into ReturnCustomFizzBuzz.
            Dictionary<int, string> parameters = new Dictionary<int, string>() {
                {3, "Fizz"},
                {5, "Buzz"},
                {10, "WooHoo"}
            };

            // How high we want ReturnCustomFizzBuzz to count.
            int inclusiveUpperBound = int.MaxValue;

            IEnumerable<string> results;

            // ************************ - DEMO using Azure WCF SOAP - **************************
            CustomFizzBuzzWCF.CustomFizzBuzzService customFizzBuzzWCF = new CustomFizzBuzzWCF.CustomFizzBuzzService();
            results = customFizzBuzzWCF.CustomFizzBuzz(inclusiveUpperBound, parameters);
            // ************************ - END - DEMO using Azure WCF SOAP - **************************

            // ************************ - DEMO using referenced DLL - **************************
            //results = FizzBuzz.FizzBuzz.ReturnCustomFizzBuzz(inclusiveUpperBound, parameters);
            // ************************ - END - DEMO using referenced DLL - **************************

            // Write each result string to the console. 
            foreach (var s in results)
            {
                Console.WriteLine(s);
            }            

            // Pause for input when done.
            Console.ReadKey();
        }
    }
}

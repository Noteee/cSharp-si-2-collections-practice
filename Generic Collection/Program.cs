using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> countryLookup = new Dictionary<int, string>();

            countryLookup[44] = "United Kingdom";
            countryLookup[33] = "France";
            countryLookup[31] = "Netherlands";
            countryLookup[55] = "Brazil";

            Console.WriteLine("The 33 Code is for: {0}", countryLookup[33]);

            foreach (var item in countryLookup)
            {
                int code = item.Key;
                string country = item.Value;
                Console.WriteLine("Code {0} = {1}", code, country);
                Console.ReadKey();
            }
        }
    }
}

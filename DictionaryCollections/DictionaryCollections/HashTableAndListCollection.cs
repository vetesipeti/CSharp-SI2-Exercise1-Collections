using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryCollections
{
    class HashTableAndListCollection
    {
        static void Main(string[] args)
        {
            Hashtable lookup = new Hashtable();
            lookup["0"] = "Zero";
            lookup["1"] = "One";
            lookup["2"] = "Two";
            lookup["3"] = "Three";
            lookup["4"] = "Four";
            lookup["5"] = "Five";
            lookup["6"] = "Six";
            lookup["7"] = "Seven";
            lookup["8"] = "Eight";
            lookup["9"] = "Nine";

            string ourNumber = "888-555-1212";

            foreach (char c in ourNumber)
            {
                string digit = c.ToString();
                if (lookup.ContainsKey(digit))
                {
                    Console.WriteLine(lookup[digit]);
                }
            }
            Console.WriteLine("\nPress any key to continue...\n");
            Console.ReadKey();
            
            // Make the dictionary case insensitive 
            ListDictionary list = new ListDictionary(new CaseInsensitiveComparer(CultureInfo.InvariantCulture));

            // Add some items
            list["Estados Unidos"] = "United States of America";
            list["Canadá"] = "Canada";
            list["España"] = "Spain";

            // Show the results 
            Console.WriteLine("España in english: " + list["españa"]);
            Console.WriteLine("Canadá in english: " + list["CANADÁ"]);
            Console.Read();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQedList
{
    class Program
    {
        static void Main(string[] args)
        {
            // Find the words in the collection that start with the letter 'L'
            List<string> fruits = new List<string>() 
                {
                    "Lemon", 
                    "Apple", 
                    "Orange", 
                    "Lime", 
                    "Watermelon", 
                    "Loganberry"
                };

            IEnumerable<string> LFruits = 
                from fruit in fruits
                where fruit.StartsWith("L")
                select fruit;
                
            foreach(string item in LFruits)
            {
                Console.WriteLine(item);
            }

            List<int> numbers = new List<int>()
            {
            15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };

            IEnumerable<int> fourSixMultiples = 
                from number in numbers
                where number % 4 == 0 || number % 6 == 0
                select number;
            
            foreach(int number in fourSixMultiples)
            {
                Console.WriteLine(number);
            }
        }
    }
}
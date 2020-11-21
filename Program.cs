using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQedList
{
    class Program
    {
        public class Customer
        {
            public string Name { get; set; }
            public double Balance { get; set; }
            public string Bank { get; set; }
        }

        
            
       


        static void Main(string[] args)
        {
                // Restriction/Filtering Operations
                    // Find the words in the collection that start with the letter 'L'
                    // List<string> fruits = new List<string>() 
                    //     {
                    //         "Lemon", 
                    //         "Apple", 
                    //         "Orange", 
                    //         "Lime", 
                    //         "Watermelon", 
                    //         "Loganberry"
                    //     };

                    // IEnumerable<string> LFruits = 
                    //     from fruit in fruits
                    //     where fruit.StartsWith("L")
                    //     select fruit;
                        
                    // foreach(string item in LFruits)
                    // {
                    //     Console.WriteLine(item);
                    // }

                    // List<int> numbers = new List<int>()
                    // {
                    // 15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
                    // };

                    // IEnumerable<int> fourSixMultiples = 
                    //     from number in numbers
                    //     where number % 4 == 0 || number % 6 == 0
                    //     select number;
                    
                    // foreach(int number in fourSixMultiples)
                    // {
                    //     Console.WriteLine(number);
                    // }


                // Ordering Operations
                    //Order these student names alphabetically, in descending order (Z to A)
                    // List<string> names = new List<string>()
                    // {
                    //  "Heather", "James", "Xavier", "Michelle", "Brian", "Nina",
                    //  "Kathleen", "Sophia", "Amir", "Douglas", "Zarley", "Beatrice",
                    //  "Theodora", "William", "Svetlana", "Charisse", "Yolanda",
                    //  "Gregorio", "Jean-Paul", "Evangelina", "Viktor", "Jacqueline",
                    //  "Francisco", "Tre"
                    // };

                    ////////////////////////////////THESE ARE TWO DIFFERENT WAYS OF DOING THE SAME THING/////////////////////////////////
                    //METHOD ONE
                    // IEnumerable<string> descend = 
                    //  from name in names
                    //  orderby name descending
                    //  select name;

                    //METHOD TWO
                    // List<string> descend = names.OrderByDescending(name => name).ToList();
                    ////////////////////////////////////////////////////////////////////////////////////////////////////////////

                    //  foreach(string name in descend)
                    //  {
                    //  Console.WriteLine(name);
                    //  }


                    // Build a collection of these numbers sorted in ascending order
                    //  List<int> numbers = new List<int>()
                    //  {
                    //  15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
                    //  };

                    //  IEnumerable<int> ascend =
                    //  from number in numbers
                    //  orderby number ascending
                    //  select number;

                    //  foreach(int number in ascend)
                    //  {
                    //  Console.WriteLine(number);
                    //  }


                //Aggregate Operations
                    // Output how many numbers are in this list
                    // List<int> numbers = new List<int>()
                    // {
                    //     15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
                    // };

                    // Console.WriteLine(numbers.Count());

                    // // How much money have we made?
                    // List<double> purchases = new List<double>()
                    // {
                    //     2340.29, 745.31, 21.76, 34.03, 4786.45, 879.45, 9442.85, 2454.63, 45.65
                    // };
                    
                    // double sum = purchases.Sum();

                    // Console.WriteLine(sum);

                    // What is our most expensive product?
                    // List<double> prices = new List<double>()
                    // {
                    //     879.45, 9442.85, 2454.63, 45.65, 2340.29, 34.03, 4786.45, 745.31, 21.76
                    // };

                    // double total = prices.Max();
                    // Console.WriteLine(total);
                    
                //Partitioning Operations
                    // List<int> wheresSquaredo = new List<int>()
                    // {
                    //     66, 12, 8, 27, 82, 34, 7, 50, 19, 46, 81, 23, 30, 4, 68, 14
                    // };

                    // /*
                    //     Store each number in the following List until a perfect square
                    //     is detected.

                    //     Expected output is { 66, 12, 8, 27, 82, 34, 7, 50, 19, 46 } 

                    //     Ref: https://msdn.microsoft.com/en-us/library/system.math.sqrt(v=vs.110).aspx
                    // */

                    // IEnumerable<int> notSquareRoots = wheresSquaredo.TakeWhile(num => 
                    // {
                    //     return Math.Sqrt(num) % 1 != 0;
                    // });

                    // foreach(int num in notSquareRoots)
                    // {
                    //     Console.WriteLine(num);
                    // };

            // Build a collection of customers who are millionaires
            List<Customer> customers = new List<Customer>() {
                new Customer(){ Name="Bob Lesman", Balance=80345.66, Bank="FTB"},
                new Customer(){ Name="Joe Landy", Balance=9284756.21, Bank="WF"},
                new Customer(){ Name="Meg Ford", Balance=487233.01, Bank="BOA"},
                new Customer(){ Name="Peg Vale", Balance=7001449.92, Bank="BOA"},
                new Customer(){ Name="Mike Johnson", Balance=790872.12, Bank="WF"},
                new Customer(){ Name="Les Paul", Balance=8374892.54, Bank="WF"},
                new Customer(){ Name="Sid Crosby", Balance=957436.39, Bank="FTB"},
                new Customer(){ Name="Sarah Ng", Balance=56562389.85, Bank="FTB"},
                new Customer(){ Name="Tina Fey", Balance=1000000.00, Bank="CITI"},
                new Customer(){ Name="Sid Brown", Balance=49582.68, Bank="CITI"}
            };

            List<Customer> millionaires = customers.Where(customer  => customer.Balance >= 1000000).ToList();

            millionaires.GroupBy(customer => customer.Bank)
                .ToList()
                .ForEach(group => 
                {
                    Console.WriteLine($"{group.Key} {group.Count()}");
                });

        }
    }
}
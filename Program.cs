using System;
using System.Collections.Generic;
using System.Linq;

namespace linq_practice
{
    public class Customer
    {
        public string Name { get; set; }
        public double Balance { get; set; }
        public string Bank { get; set; }
    }

        public class Bank
    {
        public string Symbol { get; set; }
        public string Name { get; set; }
    }

    public class Program
    {
        public static void Main()
        {

            //starts with 
            List<string> fruits = new List<string>() { "Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry" };
            List<string> LFruits = fruits.Where(x => x.StartsWith("L")).ToList();
            foreach (var item in LFruits)
            {
                Console.WriteLine(item);
            }

            //multiples of 4 or 6
            List<int> numbers = new List<int>()
            {
                15,
                8,
                21,
                24,
                32,
                13,
                30,
                12,
                7,
                54,
                48,
                4,
                49,
                96
            };

            var newNums = numbers.Where(num =>
                num % 4 == 0 || num % 6 == 0
            ).ToList();

            foreach (var num in newNums)
            {
                Console.WriteLine(num);
            }

            //sort by order (OrderBy)
            List<string> names = new List<string>()
            {
                "Heather",
                "James",
                "Xavier",
                "Michelle",
                "Brian",
                "Nina",
                "Kathleen",
                "Sophia",
                "Amir",
                "Douglas",
                "Zarley",
                "Beatrice",
                "Theodora",
                "William",
                "Svetlana",
                "Charisse",
                "Yolanda",
                "Gregorio",
                "Jean-Paul",
                "Evangelina",
                "Viktor",
                "Jacqueline",
                "Francisco",
                "Tre"
            };

            var orderedList = names.OrderByDescending(x => x);
            foreach (var x in orderedList)
            {
                Console.WriteLine(x);
            }

            List<int> listNums = new List<int>()
            {
                15,
                8,
                21,
                24,
                32,
                13,
                30,
                12,
                7,
                54,
                48,
                4,
                49,
                96
            };

            var newListNums = listNums.OrderBy(y => y);
            foreach (var y in newListNums)
            {
                Console.WriteLine(y);
            }

            //aggregate operators
            //Count in list
            List<int> xnumbers = new List<int>()
            {
                15,
                8,
                21,
                24,
                32,
                13,
                30,
                12,
                7,
                54,
                48,
                4,
                49,
                96
            };

            Console.WriteLine($"There are {xnumbers.Count} numbers.");

            //sum of list
            List<double> purchases = new List<double>()
            {
                2340.29,
                745.31,
                21.76,
                34.03,
                4786.45,
                879.45,
                9442.85,
                2454.63,
                45.65
            };

            Console.WriteLine($"The sum is {purchases.Sum():f2}");

            //highest num
            List<double> prices = new List<double>()
            {
                879.45,
                9442.85,
                2454.63,
                45.65,
                2340.29,
                34.03,
                4786.45,
                745.31,
                21.76
            };

            Console.WriteLine($"The highest num-num is {prices.Max()}");

            //takewhile not an even square root, then stop

            List<int> wheresSquaredo = new List<int>()
            {
                66,
                12,
                8,
                27,
                82,
                34,
                7,
                50,
                19,
                46,
                81,
                23,
                30,
                4,
                68,
                14
            };

            var newSquareDo = wheresSquaredo.TakeWhile(x =>
            {
                double y = Math.Sqrt(x);
                bool isSquare = y%1 != 0;
                return isSquare;

            });

            foreach (var x in newSquareDo)
            {
                Console.WriteLine(x);
            }

            //custom types
            List<Customer> customers = new List<Customer>()
            {
                new Customer() { Name = "Bob Lesman", Balance = 80345.66, Bank = "FTB" },
                new Customer() { Name = "Joe Landy", Balance = 9284756.21, Bank = "WF" },
                new Customer() { Name = "Meg Ford", Balance = 487233.01, Bank = "BOA" },
                new Customer() { Name = "Peg Vale", Balance = 7001449.92, Bank = "BOA" },
                new Customer() { Name = "Mike Johnson", Balance = 790872.12, Bank = "WF" },
                new Customer() { Name = "Les Paul", Balance = 8374892.54, Bank = "WF" },
                new Customer() { Name = "Sid Crosby", Balance = 957436.39, Bank = "FTB" },
                new Customer() { Name = "Sarah Ng", Balance = 56562389.85, Bank = "FTB" },
                new Customer() { Name = "Tina Fey", Balance = 1000000.00, Bank = "CITI" },
                new Customer() { Name = "Sid Brown", Balance = 49582.68, Bank = "CITI" }
            };

            var groups = customers.Where(customers => customers.Balance >= 1_000_000)
                .GroupBy(customers => customers.Bank);
            
            foreach (var group in groups)
            {
                Console.WriteLine($"{group.Key} has {group.Count()} millionaires");
                foreach (var customer in group)
                {
                    Console.WriteLine($"{customer.Name} has ${customer.Balance}");
                }
            };

            

            

        }

    }
}
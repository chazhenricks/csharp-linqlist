﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace linqlist
{
    public class Customer
{
    public string Name { get; set; }
    public double Balance { get; set; }
    public string Bank { get; set; }

}
    class Program
    {
        static void Main(string[] args)
        {
            // Find the words in the collection that start with the letter 'L'
            List<string> fruits = new List<string>() {"Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry"};

            IEnumerable<string> startsWithL = from f in fruits
            where f.StartsWith("L")
            select f;

            foreach(string f in startsWithL){
            Console.WriteLine($"{f}");
            }




            // Which of the following numbers are multiples of 4 or 6
            List<int> numbers = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };

             IEnumerable<int> fourSixMultiples = numbers.Where(number => number % 4 == 0 || number % 6 == 0);


             foreach(int number in fourSixMultiples){
                 Console.WriteLine($"{number}");
             }



             // Order these student names alphabetically, in descending order (Z to A)
            List<string> names = new List<string>()
            {
                "Heather", "James", "Xavier", "Michelle", "Brian", "Nina",
                "Kathleen", "Sophia", "Amir", "Douglas", "Zarley", "Beatrice",
                "Theodora", "William", "Svetlana", "Charisse", "Yolanda",
                "Gregorio", "Jean-Paul", "Evangelina", "Viktor", "Jacqueline",
                "Francisco", "Tre" 
            };

            IEnumerable<string> decend = from name in names
            orderby name descending
            select name;

            foreach(string name in decend){
                Console.WriteLine(name);
            }

        //List numbers in ascending order (Lowest to Highest)
        List<int> moreNumbers = new List<int>()
        {
            15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
        };

        IEnumerable<int> sortedNums = from nums in moreNumbers
        orderby nums ascending
        select nums;

        foreach(int nums in sortedNums){
            Console.WriteLine(nums);
        }


        // Output how many numbers are in this list
        List<int> numbers3 = new List<int>()
        {
            15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
        };
        int howMany = numbers3.Count();
        Console.WriteLine(howMany);
             


        // How much money have we made?
        List<double> purchases = new List<double>()
        {
            2340.29, 745.31, 21.76, 34.03, 4786.45, 879.45, 9442.85, 2454.63, 45.65
        };
        double totalPurchases = purchases.Sum();
        Console.WriteLine($"The sum of all the purchases is ${totalPurchases}");

        // What is our most expensive product?
        List<double> prices = new List<double>()
        {
            879.45, 9442.85, 2454.63, 45.65, 2340.29, 34.03, 4786.45, 745.31, 21.76
        };
        double mostExpensive = prices.Max();
        Console.WriteLine($"The most expensive product is ${mostExpensive}");

        


        /*
            Store each number in the following List until a perfect square
            is detected.

            Ref: https://msdn.microsoft.com/en-us/library/system.math.sqrt(v=vs.110).aspx
        */
        List<int> wheresSquaredo = new List<int>()
        {
            66, 12, 8, 27, 82, 34, 7, 50, 19, 46, 81, 23, 30, 4, 68, 14
        };

        IEnumerable<int> perfSquare = wheresSquaredo.TakeWhile(num => Math.Sqrt(num) % 1 != 0); 
        

        foreach(int num in perfSquare){
            Console.WriteLine($"{num} is not a perfect square");
        }

        List<Customer> customers = new List<Customer>() {
            new Customer(){ Name="Bob Lesman", Balance=80345.66, Bank="FTB"},
            new Customer(){ Name="Joe Landy", Balance=9284756.21, Bank="WF"},
            new Customer(){ Name="Meg Ford", Balance=487233.01, Bank="BOA"},
            new Customer(){ Name="Peg Vale", Balance=7001449.92, Bank="BOA"},
            new Customer(){ Name="Mike Johnson", Balance=790872.12, Bank="WF"},
            new Customer(){ Name="Les Paul", Balance=8374892.54, Bank="WF"},
            new Customer(){ Name="Big Ol Dick", Balance=957436.39, Bank="FTB"},
            new Customer(){ Name="Sarah Ng", Balance=56562389.85, Bank="FTB"},
            new Customer(){ Name="Tina Fey", Balance=1000000.00, Bank="CITI"},
            new Customer(){ Name="Sid Brown", Balance=49582.68, Bank="CITI"}
        };

        foreach(Customer cust in customers){
            Console.WriteLine($"{cust.Name} has ${cust.Balance} in thier {cust.Bank} account");
        }

        var  millionairs = from cust in customers
        group cust by cust.Balance > 1000000 into ballers
        select new {Bank = ballers.Key, numbers = ballers};

        foreach(var cust in millionairs){
            Console.WriteLine($"{cust.Bank} {cust.numbers}");
        }

        }
    }
}

using System;
using PierresBakery.Models;

namespace PierresBakery
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("Welcome to Pierre's Bakery");
            Console.WriteLine("Our prices are listed below: ");
            Console.WriteLine("Bread: $5/Loaf --Buy two and get your third one free \n every third loaf of bread is free!");
            Console.WriteLine("Pastries: $2/Pastry --Buy three and get your fourth one free \n every fourth pastry is free!");
        }
        static void UpdateOrder(Bread breadAmount, Pastries pastriesAmount){
            Console.WriteLine("How many loaves of bread would you like to buy?");
            string breadInput = Console.ReadLine();
            Console.WriteLine("How many pastries would you like to buy?");
            string pastriesInput = Console.ReadLine();
        }
        
    }
}


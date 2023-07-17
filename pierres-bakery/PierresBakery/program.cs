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

        static void ConfirmOrder(Bread breadAmount, Pastries pastriesAmount){
            Console.WriteLine($"Please confirm your order: you would like to purchase {breadAmount.BreadAmount} loaves of bread and {pastriesAmount.PastriesAmount} pastry/pastries?");
            Console.WriteLine("Is this order correct? please type in 'yes' to continue or 'no' to re-enter the correct amounts");
            string orderConfirmation = Console.ReadLine();
            if (orderConfirmation == "yes" || orderConfirmation == "YES" || orderConfirmation == "Yes"){
                Console.WriteLine("Thank you for confirming your order!");
                // CalculateTotalPrice(breadAmount, pastriesAmount);
            }
            else if(orderConfirmation == "no" || orderConfirmation == "NO" || orderConfirmation == "No"){
                UpdateOrder(breadAmount, pastriesAmount);
            }
            else{
                Console.WriteLine("please enter a valid response");
                ConfirmOrder(breadAmount, pastriesAmount);
            }
        }
        static void CalculateTotalPrice(Bread breadAmount, Pastries pastriesAmount){
            int totalPrice = breadAmount.CalculateBreadPrice() + pastriesAmount.CalculatePastryPrice();
            Console.WriteLine($"The total cost for your order is ${totalPrice}");
            Console.WriteLine("Thanks for visiting Pierre's Bakery!");
        }
        
    }
}


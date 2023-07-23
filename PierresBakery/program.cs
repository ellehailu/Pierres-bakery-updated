using System;
using PierresBakery.Models;

namespace PierresBakery
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
            Console.WriteLine("\nWelcome to Pierre's Bakery");
            Console.WriteLine("\n-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
            Console.WriteLine("\nOur prices are listed below: ");
            Console.WriteLine("\nBread: $5/Loaf --Buy two and get your third one free \n Every third loaf of bread is free!");
            Console.WriteLine("\nPastries: $2/Pastry --Buy three and get your fourth one free \n Every fourth pastry is free!");
            Console.WriteLine("\n-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
            UpdateOrder();
        }
        static void UpdateOrder()
        {
            int breadInput = 0;
            int pastriesInput = 0;
            try
            {
                Console.WriteLine("\nHow many loaves of bread would you like to buy?");
                breadInput = int.Parse(Console.ReadLine());

                Console.WriteLine("\nHow many pastries would you like to buy?");
                pastriesInput = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("\nplease enter a valid input");
                UpdateOrder();
            }
            Pastries pastriesOrder = new Pastries(pastriesInput);
            Bread breadOrder = new Bread(breadInput);
            ConfirmOrder(breadOrder, pastriesOrder);
        }

        static void ConfirmOrder(Bread breadAmount, Pastries pastriesAmount)
        {
            Console.WriteLine($"\nPlease confirm your order: you would like to purchase {breadAmount.BreadAmount} loaves of bread and {pastriesAmount.PastriesAmount} pastry/pastries?");
            Console.WriteLine("\nIs this order correct? please type in 'yes' to continue or 'no' to re-enter the correct amounts");
            string orderConfirmation = Console.ReadLine();
            if (orderConfirmation == "yes" || orderConfirmation == "YES" || orderConfirmation == "Yes")
            {
                CalculateTotalPrice(breadAmount, pastriesAmount);
            }
            else if (orderConfirmation == "no" || orderConfirmation == "NO" || orderConfirmation == "No")
            {
                UpdateOrder();
            }
            else
            {
                Console.WriteLine("\nplease enter a valid response");
                ConfirmOrder(breadAmount, pastriesAmount);
            }
        }
        static void CalculateTotalPrice(Bread breadAmount, Pastries pastriesAmount)
        {
            int totalPrice = breadAmount.CalculateBreadPrice() + pastriesAmount.CalculatePastryPrice();
            Console.WriteLine($"\nThe total cost for your order is ${totalPrice}");
            Console.WriteLine("\nThanks for visiting Pierre's Bakery!");
            Console.WriteLine("\n-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
        }
    }
}


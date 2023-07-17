using System.Collections.Generic;
using System;

namespace PierresBakery.Models
{

    public class Bread
    {
        // two loaves costs $10
        // three loaves cost $10
        // four loaves costs $15
        // five loaves cost $20
        // six loaves costs $20
        // seven loaves cost $25
        public int BreadAmount { get; set; }
        public Bread(int breadAmount)
        {
            BreadAmount = breadAmount;
        }

        public int CalculateBreadPrice()
        {
            int price = BreadAmount * 3;
            return price;
        }
    }
}

using System.Collections.Generic;
using System;

namespace PierresBakery.Models
{

    public class Bread
    {
        public int BreadAmount { get; set; }
        public Bread(int breadAmount)
        {
            BreadAmount = breadAmount;
        }

        public int CalculateBreadPrice()
        {
            int amountPaidFor = BreadAmount - (BreadAmount / 3);
            int totalBreadPrice = amountPaidFor * 5;
            return totalBreadPrice;
        }
    }
}

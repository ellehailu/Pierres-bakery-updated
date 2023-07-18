namespace PierresBakery.Models
{
    public class Pastries
    {
        public int PastriesAmount { get; set; }
        public Pastries(int pastriesAmount)
        {
            PastriesAmount = pastriesAmount;
        }

        public int CalculatePastryPrice()
        {
            int amountPaidFor = PastriesAmount - (PastriesAmount / 4);
            int totalPastriesPrice = amountPaidFor * 2;
            return totalPastriesPrice;
        }
    }
}
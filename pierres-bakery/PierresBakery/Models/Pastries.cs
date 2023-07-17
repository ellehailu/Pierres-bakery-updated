namespace PierresBakery.Models
{
    public class Pastries
    {
        // two pastries costs $4
        // three pastries costs $6
        // four pastries costs $6
        // five pastries costs $8
        // six pastries costs $10
        // seven pastries costs $12
        // eight pastries costs $12
        // Can you see a pattern? Every 4th pastry is free.
    
    public int PastriesAmount;
    public Pastries(int pastriesAmount) {
        PastriesAmount = pastriesAmount;
    }
    }
}
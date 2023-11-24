public class CustomerLoyaltyDiscount : SaleOff
{
    public CustomerLoyaltyDiscount ( string title, string description, string startDate, string endDate, int discountPercentage) : base(title, description, startDate, endDate, discountPercentage)
    {
        
    }
    public override double Persent()
    {
        return -(discountPercentage / 100);
    }
}
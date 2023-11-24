public class HolidayPromotion : SaleOff
{
    private string occasion;
    public string Occasion
    {
        get { return occasion; }
    }
    public HolidayPromotion(string occasion, string title, string description, string startDate, string endDate, int discountPercentage) : base(title, description, startDate, endDate, discountPercentage)
    {
        this.occasion = occasion;
    }
    public override double Persent()
    {
        return discountPercentage / 100;
    }

}
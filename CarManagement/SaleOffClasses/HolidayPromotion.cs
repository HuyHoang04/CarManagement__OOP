public class HolidayPromotion : SaleOff, ISaleOff
{
    private string occasion;
    public string Occasion
    {
        get { return occasion; }
        set { occasion = value; }
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
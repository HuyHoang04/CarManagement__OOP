public class SeasonalPriceIncrease : SaleOff, ISaleOff
{
    private string season;
    public string Season
    {
        get { return season; }
        set { season = value; }
    }
    public SeasonalPriceIncrease(string occasion, string title, string description, string startDate, string endDate, int discountPercentage, string season) : base(title, description, startDate, endDate, discountPercentage)
    {
        this.season = season;
    }
    public override double Persent()
    {
        return -(discountPercentage / 100);
    }

}
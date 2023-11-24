public class SeasonalPriceIncrease : SaleOff
{
    private string season;
    public string Season
    {
        get { return season; }
    }
    public SeasonalPriceIncrease( string title, string description, string startDate, string endDate, int discountPercentage, string season) : base(title, description, startDate, endDate, discountPercentage)
    {
        this.season = season;
    }
    public override double Persent()
    {
        return -(discountPercentage / 100);
    }

}
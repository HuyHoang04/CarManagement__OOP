public class SaleOff 
{
    protected string title;
    protected string description;
    protected DateTime startDate;
    protected DateTime endDate;
    protected int discountPercentage;
    public static List<SaleOff> Sale = new List<SaleOff>();
    public SaleOff (string title, string description, string startDate, string endDate, int discountPercentage)
    {
        this.title = title;
        this.description = description;
        this.startDate = ToDateTime.Convert(startDate);
        this.endDate = ToDateTime.Convert(endDate);
        this.discountPercentage = discountPercentage;
        Sale.Add(this);
    }
    public virtual void Display()
    {
        Console.WriteLine($"Title: {title}");
        Console.WriteLine($"Description: {description}");
        Console.WriteLine($"Start Date: {startDate}");
        Console.WriteLine($"End Date: {endDate}");
    }
    public virtual double Persent()
    {
        return 0;
    }

} 

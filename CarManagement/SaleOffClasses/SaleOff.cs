public class SaleOff 
{
    public string title;
    protected string description;
    protected DateTime startDate;
    protected DateTime endDate;
    protected int discountPercentage;


    public string Title
    {
        get { return title; } 
    }

    public string Description
    {
        get { return description; }
    }

    public string StartDate
    {
        get { return ToDateTime.ConvertToString(startDate); }
    }

    public string EndDate
    {
        get { return ToDateTime.ConvertToString(endDate); }
    }

    public int DiscountPercentage
    {
        get { return discountPercentage;}
    }

    public static List<SaleOff> Sale = new List<SaleOff>();
    public SaleOff (string title, string description, string startDate, string endDate, int discountPercentage)
    {
        this.title = title;
        this.description = description;
        this.startDate = ToDateTime.Convert(startDate);
        this.endDate = ToDateTime.Convert(endDate);
        this.discountPercentage = discountPercentage;
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

public class WeddingCar : Vehicle
{
    private double onedayrentprice = 1300000;
    private double priceperkm = 3800;
    private int decorationmoney = 100000;
    private int decoration;
    
    public int Decoration
    {
        get { return decoration; } 
    }
    public WeddingCar(int cartype, string namepurpose, string brand, int buyyear, int kmgo, int insurant, int decoration)
        : base(cartype, namepurpose, brand, buyyear, kmgo, insurant)
    {
        this.decoration = decoration;
    }
    public override double rentcostofcar(int timerentcar)
    {
        Console.WriteLine(timerentcar);
        return ((timerentcar * onedayrentprice) - (buyyear * 200000) - (kmgo * priceperkm) + insurant + cartypestandardmoney*(4-cartype)) + decoration*decorationmoney;
    }
} 
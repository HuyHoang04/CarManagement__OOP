public class WeddingCar : Vehicle
{
    private int decorationmoney = 100000;
    private int decoration;
    
    public int Decoration
    {
        get { return decoration; } 
    }
    public WeddingCar(Owner owner,int cartype, string namepurpose, string brand, int buyyear, int kmgo, int insurant, int decoration)
        : base(owner, cartype, namepurpose, brand, buyyear, kmgo, insurant)
    {
        this.decoration = decoration;
        this.onedayrentprice = 1300000;
        this.priceperkm = 3800;
    }
    public override double rentcostofcar(int timerentcar)
    {
        Console.WriteLine(timerentcar);
        return ((timerentcar * onedayrentprice) - (buyyear * 200000) - (kmgo * priceperkm) + insurant + cartypestandardmoney*(4-cartype)) + decoration*decorationmoney;
    }
} 
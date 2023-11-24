public class FourSeatsCar : Vehicle
{
    private double onedayrentprice = 1400000;
    private double priceperkm = 3800;
    private int sparetire;
    private int sparetiremoney = 200000;

    public int Sparetire
    {
        get { return sparetire; }
    }
    public FourSeatsCar (int cartype, string namepurpose, string brand, int buyyear, int kmgo, int insurant, int sparetire)
        : base(cartype, namepurpose, brand, buyyear, kmgo, insurant)
    {
        this.sparetire = sparetire;
    }
    public override double rentcostofcar(int timerentcar)
    {
        return ((timerentcar * onedayrentprice) - (buyyear * 200000) - (kmgo * priceperkm) + insurant + cartypestandardmoney * (4 - cartype)) + sparetire*sparetiremoney;
    }
}
    

    

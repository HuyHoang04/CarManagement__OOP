public class FourSeatsCar : Vehicle
{
    private int sparetire;
    private int sparetiremoney = 200000;

    public int Sparetire
    {
        get { return sparetire; }
    }
    public FourSeatsCar (Owner owner,int cartype, string namepurpose, string brand, int buyyear, int kmgo, int insurant, int sparetire)
        : base( owner,cartype, namepurpose, brand, buyyear, kmgo, insurant)
    {
        this.sparetire = sparetire;
        this.onedayrentprice = 1400000;
        this.priceperkm = 3800;
    }
    public override double rentcostofcar(int timerentcar)
    {
        return ((timerentcar * onedayrentprice) - (buyyear * 200000) - (kmgo * priceperkm) + insurant + cartypestandardmoney * (4 - cartype)) + sparetire*sparetiremoney;
    }
}
    

    

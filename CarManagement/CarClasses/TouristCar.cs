public class TouristCar: Vehicle
{
    private int minifridgemoney = 600000;
    private int minifridge;

    public int Minifridge
    {
        get { return minifridge; }
    }
    public TouristCar(Owner owner,int cartype, string namepurpose, string brand, int buyyear, int kmgo, int insurant, int minifridge)
        : base(owner, cartype, namepurpose, brand, buyyear, kmgo, insurant)
    {
        this.minifridge = minifridge;
        this.onedayrentprice = 3000000;
        this.priceperkm = 3800;
    }
    public override double rentcostofcar(int timerentcar)
    {
        return ((timerentcar * onedayrentprice) - (buyyear * 200000) - (kmgo * priceperkm) + insurant + cartypestandardmoney * (4 - cartype)) + minifridge*minifridgemoney;
    }
}

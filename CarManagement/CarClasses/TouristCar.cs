public class TouristCar: Vehicle
{
    private double onedayrentprice = 3000000;
    private double priceperkm = 3800;
    private int minifridgemoney = 600000;
    private int minifridge;

    public int Minifridge
    {
        get { return minifridge; }
    }
    public TouristCar(int cartype, string namepurpose, string brand, int buyyear, int kmgo, int insurant, int minifridge)
        : base(cartype, namepurpose, brand, buyyear, kmgo, insurant)
    {
        this.minifridge = minifridge;
    }
    public override double rentcostofcar(int timerentcar)
    {
        return ((timerentcar * onedayrentprice) - (buyyear * 200000) - (kmgo * priceperkm) + insurant + cartypestandardmoney * (4 - cartype)) + minifridge*minifridgemoney;
    }
}

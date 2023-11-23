public class WeddingCar : Vehicle, ICar
{
    private double onedayrentprice = 1300000;
    private double priceperkm = 3800;
    public WeddingCar(int cartype, string namepurpose, string brand, int buyyear, int kmgo, int timerentcar, int insurant)
        : base(cartype, namepurpose, brand, buyyear, kmgo, timerentcar, insurant)
    {

    }
    public override double rentcostofcar()
    {
        Console.WriteLine(timerentcar);
        return ((timerentcar * onedayrentprice) - (buyyear * 200000) - (kmgo * priceperkm) + insurant + cartypestandardmoney*(4-cartype));
    }
} 
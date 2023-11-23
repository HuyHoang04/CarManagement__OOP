public class TouristCar: Vehicle
{
    private double onedayrentprice = 3000000;
    private double priceperkm = 3800;
    public TouristCar(int cartype, string namepurpose, string brand, int buyyear, int kmgo, int insurant)
        : base(cartype, namepurpose, brand, buyyear, kmgo, insurant)
    {

    }
    public override double rentcostofcar(int timerentcar)
    {
        return ((timerentcar * onedayrentprice) - (buyyear * 200000) - (kmgo * priceperkm) + insurant + cartypestandardmoney * (4 - cartype));
    }
}

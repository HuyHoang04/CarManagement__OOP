public class Motobike : Vehicle, ICar
{
    private double onedayrentprice = 500000;
    private double priceperkm = 3000;
    public Motobike(int cartype, string namepurpose, string brand, int buyyear, int kmgo, int timerentcar, int insurant)
        : base(cartype, namepurpose, brand, buyyear, kmgo, timerentcar, insurant)
    { 

    }
    public override double rentcostofcar()
    {
        return ((timerentcar * onedayrentprice) - (buyyear * 2000000) - (kmgo * priceperkm) + insurant + cartypestandardmoney * (4 - cartype));
    }
}
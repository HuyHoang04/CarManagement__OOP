public class PracticeDrivingCar : Vehicle
{
    private double onedayrentprice = 1000000;
    private double priceperkm = 3800;
    private int backupbrakemoney = 150000;
    private int backupbrake;

    public int Backupbrake
    {
        get { return backupbrake; }
    }
    public PracticeDrivingCar(int cartype, string namepurpose, string brand, int buyyear, int kmgo, int insurant, int backupbrake)
        : base(cartype, namepurpose, brand, buyyear, kmgo, insurant)
    {
        this.backupbrake = backupbrake;
    }
    public override double rentcostofcar(int timerentcar)
    {
        return ((timerentcar * onedayrentprice) - (buyyear * 200000) - (kmgo * priceperkm) + insurant + cartypestandardmoney * (4 - cartype)) + backupbrake*backupbrakemoney;
    }
}
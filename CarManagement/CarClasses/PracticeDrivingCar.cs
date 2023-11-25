public class PracticeDrivingCar : Vehicle
{
    private int backupbrakemoney = 150000;
    private int backupbrake;

    public int Backupbrake
    {
        get { return backupbrake; }
    }
    public PracticeDrivingCar(Owner owner, int cartype, string namepurpose, string brand, int buyyear, int kmgo, int insurant, int backupbrake)
        : base(owner, cartype, namepurpose, brand, buyyear, kmgo, insurant)
    {
        this.backupbrake = backupbrake;
        this.onedayrentprice = 1000000;
        this.priceperkm = 3800;
    }
    public override double rentcostofcar(int timerentcar)
    {
        return ((timerentcar * onedayrentprice) - (buyyear * 200000) - (kmgo * priceperkm) + insurant + cartypestandardmoney * (4 - cartype)) + backupbrake*backupbrakemoney;
    }
}
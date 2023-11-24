public class Motobike : Vehicle
{
    private double onedayrentprice = 500000;
    private double priceperkm = 3000;
    private int toolboxmoney = 300000;
    private int toolbox;

    public int Toolbox
    {
        get { return toolbox; }
    }
    public Motobike(int cartype, string namepurpose, string brand, int buyyear, int kmgo, int insurant, int toolbox)
        : base(cartype, namepurpose, brand, buyyear, kmgo, insurant)
    { 
        this.toolbox = toolbox;
    }
    public override double rentcostofcar(int timerentcar)
    {
        return ((timerentcar * onedayrentprice) - (buyyear * 2000000) - (kmgo * priceperkm) + insurant + cartypestandardmoney * (4 - cartype)) + toolbox*toolboxmoney;
    }
}
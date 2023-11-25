public class Motobike : Vehicle
{
    private int toolboxmoney = 300000;
    private int toolbox;

    public int Toolbox
    {
        get { return toolbox; }
    }
    public Motobike(Owner owner, int cartype, string namepurpose, string brand, int buyyear, int kmgo, int insurant, int toolbox)
        : base(owner, cartype, namepurpose, brand, buyyear, kmgo, insurant)
    { 
        this.toolbox = toolbox;
        this.onedayrentprice = 500000;
        this.priceperkm = 3000;
    }
    public override double rentcostofcar(int timerentcar)
    {
        return ((timerentcar * onedayrentprice) - (buyyear * 2000000) - (kmgo * priceperkm) + insurant + cartypestandardmoney * (4 - cartype)) + toolbox*toolboxmoney;
    }
}
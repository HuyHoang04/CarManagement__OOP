public class Vehicle
{
    protected int cartype;
    protected string namepurpose;
    protected string brand;
    protected int buyyear;
    protected int kmgo;
    protected int insurant;
    public static List<Vehicle> All = new List<Vehicle>();
    protected int cartypestandardmoney = 5000000;

    public int Cartype
    {
        get { return cartype; }
    }
    public string Nampurpose
    {
        get { return namepurpose; }
    }
    public string Brand
    {
        get { return brand; }
    }
    public int Buyyear
    {
        get { return buyyear; }
    }
    public int Kmgo
    {
        get { return kmgo; }
    }
    public int Insurant
    {
        get { return insurant; }
    }
   
  


    public Vehicle(int cartype, string namepurpose, string brand, int buyyear, int kmgo, int insurant)
    {
        this.cartype = cartype;
        this.namepurpose = namepurpose;
        this.brand = brand;
        this.buyyear = (int)DateTime.Now.Year - buyyear;
        this.kmgo = kmgo;
        this.insurant = insurant;
        All.Add(this);

    }
    public virtual double rentcostofcar(int timerentcar)
    {
        return 0;
    }
    public string Display()
    {
        return $"Cartype: {cartype}, Namepurpose: {namepurpose} Brand: {brand} Buyyear: {buyyear} Kmgo: {kmgo} Insurant: {insurant} ";
    }
    public int VehicleInstock()
    {
        return All.Count() - Contract.counts;
    }
   
}


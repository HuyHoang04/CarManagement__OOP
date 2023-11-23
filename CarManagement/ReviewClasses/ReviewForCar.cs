public class ReviewForCar : Review
{
    public static List<ReviewForCar> All = new List<ReviewForCar>();
    private string vehicleModel;
    private string vehiclequality;
    private int price;
    public string VehicleModel
    {
        get { return vehicleModel; }
        set { vehicleModel = value; }
    }
    public string Vehiclequality
    {
        get { return vehiclequality; }
        set { vehiclequality = value; }
    }
    public int Price
    {
        get { return price; }
        set { price = value; }
    }
    public ReviewForCar (string vehicleModel,string vehiclequality, int price, string title, string content, int rating, string datePosted) : base (title, content, rating, datePosted)
    {
        this.vehicleModel = vehicleModel;
        this.vehiclequality = vehiclequality;
        this.price = price;
       All.Add (this);
    }
}
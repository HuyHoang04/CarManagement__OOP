public class Contract 
{
    private double deposit;
    private DateTime daterental;
    private bool hiredriver;
    private Vehicle vehicle;
    private List <CostsIncurred> costsIncurred ;
    private Owner owner;
    private RentalGuest rentalGuest;
    private SaleOff saleoff;
    private CustomerReview customerReview;
    private OwnerReview ownerReview;
    private ReviewForCar reviewForCar;
    public static int counts;

    public double Deposit
    {
        get { return deposit; }
        set { deposit = value; }
    }
    public DateTime Daterental
    {
        get { return daterental; }
        set { daterental = value; }
    }
    public bool Hiredriver
    {
        get { return hiredriver; }
        set { hiredriver = value; }
    }
    public RentalGuest RentalGuest
    {
        get { return rentalGuest; }
        set { rentalGuest = value; }
    }

    public Contract(double deposit, string daterental, bool hiredriver, Vehicle vehicle, List<CostsIncurred> costsIncurred, Owner owner, RentalGuest rentalGuest, SaleOff saleoff, CustomerReview customerReview, OwnerReview ownerReview, ReviewForCar reviewForCar)
    {
        this.deposit = deposit;
        this.daterental = ToDateTime.Convert(daterental);
        this.hiredriver = hiredriver;
        this.vehicle = vehicle;
        this.costsIncurred = costsIncurred;
        this.owner = owner;
        this.rentalGuest = rentalGuest;
        this.saleoff = saleoff;
        this.customerReview = customerReview;
        this.ownerReview = ownerReview;
        this.reviewForCar = reviewForCar;
        counts++;
    }
    public double Rentpriceinconstract()
    {
        double hiredrivercost = 0;

        if (hiredriver == true)
        {
            hiredrivercost = 5000000;
        }
        return vehicle.rentcostofcar() + (vehicle.rentcostofcar()* saleoff.Persent() ) + hiredrivercost;
    }
    public void InfoConstract()
    {
        vehicle.Display();
        owner.Display();
        rentalGuest.Display();
        Console.WriteLine($"Rentpriceinconstract: {Rentpriceinconstract()}");
    }
    public double ReturnConstract()
    {
        customerReview.Display();
        ownerReview.Display();
        reviewForCar.Display();
        double totalincludeprice = 0;
        if ( costsIncurred.Count()!= 0)
        {
            foreach (CostsIncurred p in costsIncurred)
            {
                totalincludeprice += p.Price();
            }
        }
        return Rentpriceinconstract() + totalincludeprice;
    }
    
    
}

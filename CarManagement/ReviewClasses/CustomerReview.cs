public class CustomerReview : Review
{
    public static List<CustomerReview> All = new List<CustomerReview>();
    private string renterName;
    public string RenterName
    {
        get { return RenterName; }
        set { RenterName = value; }
    }
    public CustomerReview (string renterName, string title, string content, int rating, string datePosted) : base(title, content, rating, datePosted)
    {
        this.renterName = renterName;
        All.Add(this);
    }

}
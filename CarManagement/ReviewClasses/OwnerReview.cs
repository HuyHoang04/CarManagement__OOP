public class OwnerReview : Review
{
    private string ownerName;
    private string attitude;
    public string OwnerName
    {
        get { return ownerName; }
        set { ownerName = value; }
    }
    public string Attitude
    {
        get { return attitude; }
        set { attitude = value; }
    }
    public OwnerReview(string ownerName, string attitude, string title, string content, int rating, string datePosted) : base(title, content, rating, datePosted)
    {
        this.ownerName = ownerName;
        this.attitude = attitude;
    }
}
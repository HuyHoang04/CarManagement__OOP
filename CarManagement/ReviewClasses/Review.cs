public class Review 
{
    private string title;
    private string content;
    private int rating;
    private DateTime datePosted;

    public string Title
    {
        get { return title;  }
        set { title = value; }
    }
    public string Content
    {
        get { return content; }
        set { content = value; }
    }
    public int Rating
    {
        get { return rating; }
        set { rating = value; }
    }
    public DateTime DatePosted
    {
        get { return datePosted; }
        set { datePosted = value; }
    }
    public Review (string title, string content, int rating , string datePosted)
    {
        this.title = title;
        this.content = content;
        this.rating = rating;
        this.datePosted = ToDateTime.Convert(datePosted);
    }
    public virtual void Display()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Content: {Content}");
        Console.WriteLine($"Rating: {Rating}");
        Console.WriteLine($"Date Posted: {ToDateTime.ConvertToString(datePosted)}");
    }
}

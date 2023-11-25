using System.Net;

public class RentalGuest : Person
{

    public static List<RentalGuest> All = new List<RentalGuest>();
    public RentalGuest (string customername, int id, string dob, string address, string phonenumber) : base (customername, id, dob, address, phonenumber)
    {

    }
    public string Customername
    {
        get { return customername; }
    }
    public int ID
    {
        get { return id; }
        set { id = value; }
    }
    public string Address
    {
        get { return address; }
    }
    public string Dob
    {
        get { return ToDateTime.ConvertToString(dob); }
    }
    public string Phonenumber
    {
        get { return phonenumber; }
    }
}
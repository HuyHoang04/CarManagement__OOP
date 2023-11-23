public class Person 
{
    protected string customername;
    protected int id;
    protected DateTime dob;
    protected string address;
    protected string phonenumber;


    public Person(string customername, int id, string dob, string address, string phonenumber)
    {
        this.customername =customername;
        this.id = id;
        this.dob = ToDateTime.Convert(dob);
        this.address = address;
        this.phonenumber = phonenumber;
    }
    public void Display()
    {
        Console.WriteLine($"Customername: {customername}");
        Console.WriteLine($"Id: {id}");
        Console.WriteLine($"Dob: {dob}");
        Console.WriteLine($"Address: {address}");
        Console.WriteLine($"Phonenumber: {phonenumber}");
    }
}

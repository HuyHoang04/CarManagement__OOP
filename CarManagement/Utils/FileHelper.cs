using System.IO;
public static class FileHelper
{
    public static void VehicleW(string path, List<Vehicle> records, bool continueW)
    {
        string filePath = path;

        using (StreamWriter writer = new StreamWriter(filePath, continueW))
        {
            if (writer.BaseStream.Position == 0)
            {
                writer.WriteLine("Purpose,Brand");
            }

            foreach (var a in records)
            {
                writer.WriteLine($"{a.Nampurpose},{a.Brand}");
            }

        }

    }
    public static void CustomerW(string path, List<RentalGuest> records, bool continueW)
    {
        string filePath = path;

        using (StreamWriter writer = new StreamWriter(filePath, continueW))
        {
            if (writer.BaseStream.Position == 0)
            {
                writer.WriteLine("ID,NAME,DOB,PHONENUMBER,ADDRESS");
            }
            foreach (var a in records)
            {
                writer.WriteLine($"{a.ID},{a.Customername},{a.Dob},{a.Phonenumber},{a.Address}");
            }
        }

    }

    public static void ReadCustomer(string filepath)
    {
        string filePath = filepath;

        if (File.Exists(filePath))
        {
            // Read all lines from the CSV file
            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                // Split the line into individual values
                string[] values = line.Split(',');

                // Assuming the order of columns is: CustomerName, ID, DOB, Address, PhoneNumber
                if (values.Length >= 5)
                {
                    // Extract values for each field
                    string customerName = values[0].Trim();
                    int id = int.Parse(values[1].Trim());
                    string dob = values[2].Trim();
                    string address = values[3].Trim();
                    string phoneNumber = values[4].Trim();
                    new RentalGuest(customerName, id, dob, address, phoneNumber);
                }
                else
                {
                    Console.WriteLine("Invalid format in the CSV file. Make sure it has at least 5 columns.");
                }
            }
        }
        else
        {
            Console.WriteLine("File not found: " + filePath);
        }


    }
    public static void ReadVehical(string filepath)
    {
        string filePath = filepath;

        if (File.Exists(filePath))
        {
            // Read all lines from the CSV file
            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                // Split the line into individual values
                string[] values = line.Split(',');

                // Assuming the order of columns is: CustomerName, ID, DOB, Address, PhoneNumber
                if (values.Length >= 5)
                {
                    // Extract values for each field
                    int cartype = int.Parse(values[0].Trim());
                    string namepurpose = values[1].Trim();
                    string brand = values[2].Trim();
                    int buyyear = int.Parse(values[3].Trim());
                    int kmgo = int.Parse(values[4].Trim());
                    int timerentcar = int.Parse(values[5].Trim());
                    int insurant = int.Parse(values[6].Trim());
                }
                else
                {
                    Console.WriteLine("Invalid format in the CSV file. Make sure it has at least 5 columns.");
                }
            }
        }
        else
        {
            Console.WriteLine("File not found: " + filePath);
        }


    }

}
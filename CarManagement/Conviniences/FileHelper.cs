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

        using (StreamWriter writer = new StreamWriter(filePath,continueW))
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

    //public static void CotractW(string path, List<Contract> records)
    //{
    //    string filePath = path;

    //    using (StreamWriter writer = new StreamWriter(filePath))
    //    {

    //        foreach (var a in records)
    //        {
    //            writer.WriteLine($"{a.},{a.Brand}");
    //        }
    //    }

    //}


}
using System;

class Program
{
    static void Main(string[] args)
    {
        List<CostsIncurred> costsIncurreds = new List<CostsIncurred>();

        FourSeatsCar MazdaCX5 = new FourSeatsCar(2, "Travel", "Mazda", 2014, 2200, 100000);
        Motobike Vision = new Motobike(2, "Travel", "Honda", 2019, 990, 160000);
        PracticeDrivingCar Toyota = new PracticeDrivingCar(3, "Practice", "Honda Civic", 2019, 1200, 160000);
        TouristCar Hyundai = new TouristCar(2, "Travel", "Ford Transit", 2020, 2000, 350000);
        WeddingCar Camry = new WeddingCar(1, "Wedding", "Toyota Camry", 2018, 3000, 150000);

        Owner Hoang = new Owner("La Huy Hoang", 0382004367, "10/01/1967", "DaLat", "0363892999");

        RentalGuest guest1 = new RentalGuest("Nguyen Huu Danh", 123123123, "20/04/1999", "DaLat", "0979897979");
        RentalGuest guest2 = new RentalGuest("Tran Thanh Vy", 0938475612, "15/08/1995", "Nha Trang", "0987654321");
        RentalGuest guest3 = new RentalGuest("Pham Thi Nga", 0789456123, "05/06/1985", "Hanoi", "0901234567");
        RentalGuest guest4 = new RentalGuest("Nguyen Minh Hieu", 0987654321, "22/02/1994", "Buon Ma Thuot", "0990123456");
        RentalGuest guest5 = new RentalGuest("Phan Minh Tu", 0587413690, "12/09/1997", "Can Tho", "0956789012");

        CustomerReview guest1review = new CustomerReview("Vinh", "Reviewforservice", "Good", 5, "20/06/2024");
        CustomerReview guest2review = new CustomerReview("Vy", "Reviewforservice", "Good", 5, "02/07/2024");
        CustomerReview guest3review = new CustomerReview("Nga", "Reviewforservice", "No Comment", 5, "28/06/2024");
        CustomerReview guest4review = new CustomerReview("Hieu", "Reviewforservice", "Good", 5, "13/08/2024");
        CustomerReview guest5review = new CustomerReview("Tu", "Reviewforservice", "No Comment", 5, "22/08/2024");

        OwnerReview HoangReview = new OwnerReview("Hoang", "Nice & Friendly", "Traveler", "Cheap car rental in Da Lat", 5, "02/03/2023");

        ReviewForCar reviewforWeddingCar = new ReviewForCar("Camry", "Good", 850000, "Rent Wedding Car", " New and clean", 5, "30/06/2024");
        ReviewForCar reviewforMotbike = new ReviewForCar("Vision", "Good", 850000, "Rent Motiobike ", " New and clean", 5, "30/06/2024");
        ReviewForCar reviewforTouristCar = new ReviewForCar("Mustang", "Good", 850000, "Rent Wedding Car", "New and clean", 5, "30/06/2024");
        ReviewForCar reviewforFourseatCar = new ReviewForCar("Ford Transit", "Good", 850000, "Rent Wedding Car", "New and clean", 5, "30/06/2024");
        ReviewForCar reviewforPracticeCar = new ReviewForCar("BMW", "Good", 850000, "Rent Wedding Car", "New and clean", 5, "30/06/2024");
        HolidayPromotion Summer = new HolidayPromotion("Summer Time", "Vacation Vibing", "Summer 50% sale", "07/07/2022", "08/08/2022", 50);

        


        //Console.WriteLine(CarRental.ReturnConstract());

        //FileHelper.VehicleW("Vehical.csv", Vehicle.All,false);
        //FileHelper.CustomerW("Customer.csv", RentalGuest.All,false);



    }
}



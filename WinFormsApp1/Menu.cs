using System.Windows.Forms;
using System.Linq;
using System.Runtime.InteropServices;
using ManagerForm;

namespace WinFormsApp1
{
    public partial class Menu : Form
    {
        List<CostsIncurred> costsIncurreds = new List<CostsIncurred>();

        FourSeatsCar MazdaCX5 = new FourSeatsCar(2, "Travel", "Mazda", 2014, 2200, 100000);
        Motobike Vision = new Motobike(2, "Travel", "Honda", 2019, 990, 160000);
        PracticeDrivingCar Toyota = new PracticeDrivingCar(3, "Practice", "Honda Civic", 2019, 1200, 160000);
        TouristCar Hyundai = new TouristCar(2, "Travel", "Ford Transit", 2020, 2000, 350000);
        WeddingCar Camry = new WeddingCar(1, "Wedding", "Toyota Camry", 2018, 3000, 150000);


        RentalGuest guest1 = new RentalGuest("Nguyen Huu Danh", 0682004862, "20/04/1999", "DaLat", "0979897979");
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


        private void Form1_Load(object sender, EventArgs e)
        {
            //Contract CarRental = new Contract(500000, "01/11/2023", true, MazdaCX5, costsIncurreds, Hoang, guest1, Summer, guest1review, HoangReview, reviewforWeddingCar);
            //Contract CarRental2 = new Contract(600000, "05/12/2023", true, Vision, costsIncurreds, Hoang, guest2, Summer, guest2review, HoangReview, reviewforMotbike);
            //Contract CarRental3 = new Contract(700000, "20/01/2024", true, Toyota, costsIncurreds, Hoang, guest3, Summer, guest3review, HoangReview, reviewforPracticeCar);
            //Contract CarRental4 = new Contract(800000, "15/03/2024", true, Hyundai, costsIncurreds, Hoang, guest4, Summer, guest4review, HoangReview, reviewforTouristCar);
            //Contract CarRental5 = new Contract(900000, "10/05/2024", true, Camry, costsIncurreds, Hoang, guest5, Summer, guest5review, HoangReview, reviewforFourseatCar);

        }


        public Menu()
        {

            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));


        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        private void button1_Click(object sender, EventArgs e)
        {


            

        }

        private void button2_Click(object sender, EventArgs e)
        {

           

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            ManagerForm form = new ManagerForm();
            form.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Customerform form = new Customerform();
            form.Show();
        }
    }
}
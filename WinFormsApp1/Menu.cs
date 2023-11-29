using System.Windows.Forms;
using System.Linq;
using System.Runtime.InteropServices;
using ManagerForm;

namespace WinFormsApp1
{
    public partial class Menu : Form
    {
        private Rectangle buttonOriginalRectangel;
        private Rectangle originalFormSize;
        Owner Hoang = new Owner("La Huy Hoang", 0382004367, "10/01/1967", "DaLat", "0363892999");

        private void Form1_Load(object sender, EventArgs e)
        {
            originalFormSize = new Rectangle(this.Location.X, this.Location.Y, this.Size.Width, this.Size.Height);
            buttonOriginalRectangel = new Rectangle(button2.Location.X, button2.Location.Y, button2.Width, button2.Height);
            Owner Hoang = new Owner("La Huy Hoang", 0382004367, "10/01/1967", "DaLat", "0363892999");

            Vehicle.All.Add(new FourSeatsCar(Hoang, 2, "Travel", "Mazda", 2014, 2200, 100000, 1));
            Vehicle.All.Add(new Motobike(Hoang, 2, "Travel", "Honda", 2019, 990, 160000, 1));
            Vehicle.All.Add(new PracticeDrivingCar(Hoang, 3, "Practice", "Honda Civic", 2019, 1200, 160000, 1));
            Vehicle.All.Add(new TouristCar(Hoang, 2, "Travel", "Ford Transit", 2020, 2000, 350000, 1));

            RentalGuest.All.Add(new RentalGuest("Nguyen Huu Danh", 123123123, "20/04/1999", "DaLat", "0979897979"));
            RentalGuest.All.Add(new RentalGuest("Tran Thanh Vy", 0938475612, "15/08/1995", "Nha Trang", "0987654321"));
            RentalGuest.All.Add(new RentalGuest("Pham Thi Nga", 0789456123, "05/06/1985", "Hanoi", "0901234567"));
            RentalGuest.All.Add(new RentalGuest("Nguyen Minh Hieu", 0987654321, "22/02/1994", "Buon Ma Thuot", "0990123456"));
            RentalGuest.All.Add(new RentalGuest("Phan Minh Tu", 0587413690, "12/09/1997", "Can Tho", "0956789012"));

            Review.All.Add(new Review("Vinh", "Reviewforservice", "Camry", "Good", 5, "20/06/2024"));
            Review.All.Add(new Review("Vy", "Reviewforservice", "Vision", "Good", 5, "02/07/2024"));
            Review.All.Add(new Review("Nga", "Reviewforservice", "Hyundai", "No Comment", 5, "28/06/2024"));
            Review.All.Add(new Review("Hieu", "Reviewforservice", "MazadaCX5", "Good", 5, "13/08/2024"));
            Review.All.Add(new Review("Tu", "Reviewforservice", "Toyota", "No Comment", 5, "22/08/2024"));

            SaleOff.Sale.Add(new HolidayPromotion("Summer Time", "Vacation Vibing", "Summer 50% sale", "07/07/2022", "08/08/2022", 50));
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

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

        }


        private void resizeControl(Rectangle r , Control c)
        {
            float xRatio = (float)(this.Width) / (float)(originalFormSize.Width);
            float yRatio = (float)(this.Height) / (float)(originalFormSize.Height);

            int newX = (int)(r.Width * xRatio);
            int newY = (int)(r.Height * yRatio);

            int newWidth = (int)(r.Width * xRatio);
            int newHeight = (int)(r.Height * yRatio);

            c.Location = new Point(newX, newY);
            c.Size = new Size(newWidth, newHeight);
        }

        private void Menu_Resize(object sender, EventArgs e)
        {
           
        }
    }
}
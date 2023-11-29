using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class ManagerForm : Form
    {
        public ManagerForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }

        private void clearbutton_Click(object sender, EventArgs e)
        {
            purposebox.Clear();
            brandbox.Clear();
            buybox.Clear();
            kmbox.Clear();
            insurantbox.Clear();
        }

        private void donebutton_Click(object sender, EventArgs e)
        {


            string a = comboBox1.Text;
            switch (a)
            {
                case "Four Seats Car ":
                    {

                        Vehicle.All.Add(new FourSeatsCar(MyData.Hoang, Int32.Parse(levelbox.Text), purposebox.Text, brandbox.Text, Int32.Parse(buybox.Text), Int32.Parse(kmbox.Text), Int32.Parse(insurantbox.Text), Int32.Parse(specialbox.Text)));
                        levelbox.Clear();
                        purposebox.Clear();
                        brandbox.Clear();
                        buybox.Clear();
                        kmbox.Clear();
                        insurantbox.Clear();
                        vehiclegridview.DataSource = Vehicle.All;
                        break;
                    }
                case "Motobike ":
                    {
                        Vehicle.All.Add(new Motobike(MyData.Hoang, Int32.Parse(levelbox.Text), purposebox.Text, brandbox.Text, Int32.Parse(buybox.Text), Int32.Parse(kmbox.Text), Int32.Parse(insurantbox.Text), Int32.Parse(specialbox.Text)));
                        levelbox.Clear();
                        purposebox.Clear();
                        brandbox.Clear();
                        buybox.Clear();
                        kmbox.Clear();
                        insurantbox.Clear();
                        vehiclegridview.DataSource = Vehicle.All;
                        break;
                    }
                case "Practice Driving Car ":
                    {
                        Vehicle.All.Add(new PracticeDrivingCar(MyData.Hoang, Int32.Parse(levelbox.Text), purposebox.Text, brandbox.Text, Int32.Parse(buybox.Text), Int32.Parse(kmbox.Text), Int32.Parse(insurantbox.Text), Int32.Parse(specialbox.Text)));
                        levelbox.Clear();
                        purposebox.Clear();
                        brandbox.Clear();
                        buybox.Clear();
                        kmbox.Clear();
                        insurantbox.Clear();
                        vehiclegridview.DataSource = Vehicle.All;
                        break;
                    }
                case "Tourist Car ":
                    {
                        Vehicle.All.Add(new TouristCar(MyData.Hoang, Int32.Parse(levelbox.Text), purposebox.Text, brandbox.Text, Int32.Parse(buybox.Text), Int32.Parse(kmbox.Text), Int32.Parse(insurantbox.Text), Int32.Parse(specialbox.Text)));
                        levelbox.Clear();
                        purposebox.Clear();
                        brandbox.Clear();
                        buybox.Clear();
                        kmbox.Clear();
                        insurantbox.Clear();
                        vehiclegridview.DataSource = Vehicle.All;
                        break;
                    }
                case "Wedding Car ":
                    {
                        Vehicle.All.Add(new WeddingCar(MyData.Hoang, Int32.Parse(levelbox.Text), purposebox.Text, brandbox.Text, Int32.Parse(buybox.Text), Int32.Parse(kmbox.Text), Int32.Parse(insurantbox.Text), Int32.Parse(specialbox.Text)));
                        levelbox.Clear();
                        purposebox.Clear();
                        brandbox.Clear();
                        buybox.Clear();
                        kmbox.Clear();
                        insurantbox.Clear();
                        vehiclegridview.DataSource = Vehicle.All;
                        break;
                    }
            }
            levelbox.Clear();
            purposebox.Clear();
            brandbox.Clear();
            buybox.Clear();
            kmbox.Clear();
            insurantbox.Clear();
            vehiclegridview.DataSource = Vehicle.All;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string a = comboBox1.Text;
            switch (a)
            {
                case "Four Seats Car ":
                    {
                        specialbox.Show();
                        sparelabel.Show();
                        toollabel.Hide();
                        backuplabel.Hide();
                        fridgelabel.Hide();
                        decoralabel.Hide();
                        break;
                    }
                case "Motobike ":
                    {
                        specialbox.Show();
                        sparelabel.Hide();
                        toollabel.Show();
                        backuplabel.Hide();
                        fridgelabel.Hide();
                        decoralabel.Hide();
                        break;
                    }
                case "Practice Driving Car ":
                    {
                        specialbox.Show();
                        sparelabel.Hide();
                        toollabel.Hide();
                        backuplabel.Show();
                        fridgelabel.Hide();
                        decoralabel.Hide();
                        break;
                    }
                case "Tourist Car ":
                    {
                        specialbox.Show();
                        sparelabel.Hide();
                        toollabel.Hide();
                        backuplabel.Hide();
                        fridgelabel.Show();
                        decoralabel.Hide();
                        break;
                    }
                case "Wedding Car ":
                    {
                        specialbox.Show();
                        sparelabel.Hide();
                        toollabel.Hide();
                        backuplabel.Hide();
                        fridgelabel.Hide();
                        decoralabel.Show();
                        break;
                    }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void Done_Click(object sender, EventArgs e)
        {
            string title = CodeTittleBox.Text;
            string description = Descriptionbox.Text;
            string startDate = StartDateBox.Text;
            string endDate = EndDateBox.Text;
            int discountPercentage = Int32.Parse(DiscountPersent.Text);
            string occation = OccationBox.Text;
            SaleGridView.DataSource = SaleOff.Sale;
            switch (Descriptionbox.Text)
            {
                case "Holiday":
                    {
                        SaleOff.Sale.Add(new HolidayPromotion(occation, title, description, startDate, endDate, discountPercentage));
                        SaleGridView.DataSource = SaleOff.Sale;
                        break;

                    }
                case "Seasonal_Increase":
                    {
                        SaleOff.Sale.Add(new SeasonalPriceIncrease(title, description, startDate, endDate, discountPercentage, occation));
                        SaleGridView.DataSource = SaleOff.Sale;
                        break;

                    }
                case "Seasonal_Decrease":
                    {
                        SaleOff.Sale.Add(new SeasonalPriceIncrease(title, description, startDate, endDate, discountPercentage, occation));
                        SaleGridView.DataSource = SaleOff.Sale;
                        break;

                    }
                case "Customer Loyalty":
                    {
                        SaleOff.Sale.Add(new CustomerLoyaltyDiscount(title, description, startDate, endDate, discountPercentage));
                        SaleGridView.DataSource = SaleOff.Sale;
                        break;

                    }


            }


        }

        private void Descriptionbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (Descriptionbox.Text)
            {
                case "Holiday":
                    {
                        OccationBox.Hide();
                        SeasonLabel.Hide();
                        OccationLabel.Hide();
                        break;

                    }
                case "Seasonal_Increase":
                    {
                        OccationBox.Show();
                        SeasonLabel.Show();
                        OccationLabel.Hide();
                        break;

                    }
                case "Seasonal_Decrease":
                    {
                        OccationBox.Show();
                        SeasonLabel.Show();
                        OccationLabel.Hide();
                        break;

                    }

            }

        }
        private void ManagerForm_Load(object sender, EventArgs e)
        {
            OccationBox.Hide();
            SeasonLabel.Hide();
            OccationLabel.Hide();

            specialbox.Hide();
            sparelabel.Hide();
            toollabel.Hide();
            backuplabel.Hide();
            fridgelabel.Hide();
            decoralabel.Hide();
            this.vehiclegridview.DefaultCellStyle.ForeColor = Color.Black;
            this.SaleGridView.DefaultCellStyle.ForeColor = Color.Black;
        }

        private void SaleGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            CodeTittleBox.Clear();
            StartDateBox.Clear();
            EndDateBox.Clear();
            DiscountPersent.Clear();
            OccationBox.Clear();
        }

        private void levelbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

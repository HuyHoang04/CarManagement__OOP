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
                        new FourSeatsCar(Int32.Parse(levelbox.Text), purposebox.Text, brandbox.Text, Int32.Parse(buybox.Text), Int32.Parse(kmbox.Text), Int32.Parse(insurantbox.Text));
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
                        new Motobike(Int32.Parse(levelbox.Text), purposebox.Text, brandbox.Text, Int32.Parse(buybox.Text), Int32.Parse(kmbox.Text), Int32.Parse(insurantbox.Text));
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
                        new PracticeDrivingCar(Int32.Parse(levelbox.Text), purposebox.Text, brandbox.Text, Int32.Parse(buybox.Text), Int32.Parse(kmbox.Text), Int32.Parse(insurantbox.Text));
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
                        new TouristCar(Int32.Parse(levelbox.Text), purposebox.Text, brandbox.Text, Int32.Parse(buybox.Text), Int32.Parse(kmbox.Text), Int32.Parse(insurantbox.Text));
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
                        new WeddingCar(Int32.Parse(levelbox.Text), purposebox.Text, brandbox.Text, Int32.Parse(buybox.Text), Int32.Parse(kmbox.Text), Int32.Parse(insurantbox.Text));
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

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

using ManagerForm.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerForm
{
    public partial class Customerform : Form
    {
        public Customerform()
        {
            InitializeComponent();
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void Customerform_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {

            var q = from u in RentalGuest.All
                    where u.ID.ToString() == SearchID.Text
                    select u;

            List<RentalGuest> list = q.ToList();
            if (list.Count == 0)
            {
                MessageBox.Show("Profile doesn't exist, go to create in new register !");
            }

            dataGridView1.DataSource = list;

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = RentalGuest.All;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void nameinput_TextChanged(object sender, EventArgs e)
        {

        }

        private void donebutton_Click(object sender, EventArgs e)
        {
            new RentalGuest(nameinput.Text, Int32.Parse(idinput.Text), dobinput.Text, addressinput.Text, phonenumberinput.Text);
            nameinput.Clear();
            idinput.Clear();
            dobinput.Clear();
            addressinput.Clear();
            phonenumberinput.Clear();
        }

        private void clearbutton_Click(object sender, EventArgs e)
        {
            nameinput.Clear();
            idinput.Clear();
            dobinput.Clear();
            addressinput.Clear();
            phonenumberinput.Clear();
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void idinput_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonrent_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void Reviewclear_Click(object sender, EventArgs e)
        {

        }

        private void Reviewdone_Click(object sender, EventArgs e)
        {


        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.Yellow_Star;
            pictureBox2.Image = Resources.Yellow_Star;
            pictureBox3.Image = Resources.Yellow_Star;
            pictureBox4.Image = Resources.Yellow_Star;
            pictureBox5.Image = Resources.Yellow_Star;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox5.Image = Resources.White_Star;
            pictureBox1.Image = Resources.Yellow_Star;
            pictureBox2.Image = Resources.Yellow_Star;
            pictureBox3.Image = Resources.Yellow_Star;
            pictureBox4.Image = Resources.Yellow_Star;

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox4.Image = Resources.White_Star;
            pictureBox5.Image = Resources.White_Star;
            pictureBox1.Image = Resources.Yellow_Star;
            pictureBox2.Image = Resources.Yellow_Star;
            pictureBox3.Image = Resources.Yellow_Star;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox3.Image = Resources.White_Star;
            pictureBox4.Image = Resources.White_Star;
            pictureBox5.Image = Resources.White_Star;
            pictureBox1.Image = Resources.Yellow_Star;
            pictureBox2.Image = Resources.Yellow_Star;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Resources.White_Star;
            pictureBox3.Image = Resources.White_Star;
            pictureBox4.Image = Resources.White_Star;
            pictureBox5.Image = Resources.White_Star;
            pictureBox1.Image = Resources.Yellow_Star;


        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }
    }
}

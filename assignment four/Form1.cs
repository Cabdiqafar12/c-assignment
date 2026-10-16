using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace assignment_four
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncalc_Click(object sender, EventArgs e)
        {
            string name = txtname.Text.Trim();

            int age, nights, guests;

            // check name
            if (name == "")
            {
                MessageBox.Show("Please enter guest name.");
                txtname.Focus();
                return;
            }

            // check that age, nights and guests are numbers
            if (!int.TryParse(txtage.Text, out age) ||
                !int.TryParse(txtnight.Text, out nights) ||
                !int.TryParse(txtguest.Text, out guests))
            {
                MessageBox.Show("Please enter valid numbers.");
                return;
            }

            // guest must be an adult
            if (age < 18)
            {
                MessageBox.Show("Guest must be 18 or older.");
                return;
            }

            if (nights < 1 || guests < 1)
            {
                MessageBox.Show("Nights and guests must be at least 1.");
                return;
            }

            // find room type and price per night
            double rate = 0;
            string room = "";

            if (rdostan.Checked)
            {
                rate = 50;
                room = "Standard";
            }
            else if (rdonormal.Checked)
            {
                rate = 80;
                room = "normal";
            }
            else if (rdohight.Checked)
            {
                rate = 130;
                room = "hight";
            }
            else
            {
                MessageBox.Show("Please select a room type.");
                return;
            }

            // calculate cost
            double roomCost = rate * nights;
            double breakfastCost = 0;

            // breakfast is $10 per guest per night
            if (checkbreak.Checked)
            {
                breakfastCost = 10 * guests * nights;
            }

            double totalCost = roomCost + breakfastCost;

            // show the result
            listbox1.Items.Add(
                "Booking Details\n\n" +
                "Guest Name: " + name + "\n" +
                "Guest Age: " + age + "\n" +
                "Room Type: " + room + "\n" +
                "Number of Nights: " + nights + "\n" +
                "Number of Guests: " + guests + "\n" +
                "Room Cost: $" + roomCost.ToString("0.00") + "\n" +
                "Breakfast Cost: $" + breakfastCost.ToString("0.00") + "\n" +
                "Total Cost: $" + totalCost.ToString("0.00"),
                "Booking Summary"
            );
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // clear everything
            txtname.Clear();
            txtage.Clear();
            txtnight.Clear();
            txtguest.Clear();

            rdostan.Checked = false;
            rdonormal.Checked = false;
            rdohight.Checked = false;
            checkbreak.Checked = false;

            txtname.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
        }

        private void btnclear_Click_1(object sender, EventArgs e)
        {
            txtname.Clear();
            txtage.Clear();
            txtnight.Clear();
            txtguest.Clear();

            rdostan.Checked ^= false;
            rdonormal.Checked ^= false;
            rdohight.Checked ^= false;
            checkbreak.Checked ^= false;
        }

        private void btnexit_Click_1(object sender, EventArgs e)
        {

        }
    }
}

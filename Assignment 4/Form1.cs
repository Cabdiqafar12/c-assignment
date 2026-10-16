using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btncalc.Click+= btncalc_Click;
        }

        private void btncalc_Click(object sender, EventArgs e)
        {
            
            // Get passenger information
            string name = txtpassname.Text.Trim();

            // Validate empty name
            if (name == "")
            {
                MessageBox.Show("Please enter passenger name.");
                txtpassname.Focus();
                return;
            }

            // Validate age, tickets and baggage using TryParse
            if (!int.TryParse(txtage.Text, out int age))
            {
                MessageBox.Show("Please enter a valid passenger age.");
                txtage.Focus();
                return;
            }

            if (!int.TryParse(txtticket.Text, out int tickets))
            {
                MessageBox.Show("Please enter a valid number of tickets.");
                txtticket.Focus();
                return;
            }

            if (!double.TryParse(txtweight.Text, out double baggage))
            {
                MessageBox.Show("Please enter a valid baggage weight.");
                txtweight.Focus();
                return;
            }

            // Validation rules
            if (age < 1 || age > 100)
            {
                MessageBox.Show("Passenger age must be between 1 and 100.");
                return;
            }

            if (tickets < 1 || tickets > 5)
            {
                MessageBox.Show("Number of tickets must be between 1 and 5.");
                return;
            }

            if (baggage < 0 || baggage > 50)
            {
                MessageBox.Show(
                    "Baggage weight must be between 0 and 50 kg per passenger.");
                return;
            }

            if (!rdofirst.Checked &&
                !rdonormal.Checked &&
                !rdobusiness.Checked)
            {
                MessageBox.Show("Please select a travel class.");
                return;
            }

            if (age < 12 && rdofirst.Checked)
            {
                MessageBox.Show(
                    "Booking rejected: Passengers below 12 years " +
                    "cannot book First Class.");
                return;
            }

            // Ticket prices (sample prices in dollars)
            double ticketPrice;
            string travelClass;

            if (rdofirst.Checked)
            {
                ticketPrice = 500;
                travelClass = "First Class";
            }
            else if (rdobusiness.Checked)
            {
                ticketPrice = 350;
                travelClass = "Business Class";
            }
            else
            {
                ticketPrice = 200;
                travelClass = "Normal Class";
            }

            // Basic ticket cost
            double basicCost = ticketPrice * tickets;
            double discountRate = 0;
            string discountDetails = "";

            // Ticket quantity discount
            if (tickets == 5)
            {
                discountRate += 0.10;
                discountDetails += "5 tickets: 10% discount\n";
            }
            else if (tickets >= 3)
            {
                discountRate += 0.05;
                discountDetails += "3-4 tickets: 5% discount\n";
            }

            // Child discount
            if (age < 12)
            {
                discountRate += 0.20;
                discountDetails += "Child discount: 20%\n";
            }
            // Senior discount
            else if (age >= 60)
            {
                discountRate += 0.10;
                discountDetails += "Senior discount: 10%\n";
            }

            // Calculate discount
            double discountAmount = basicCost * discountRate;
            double totalCost = basicCost - discountAmount;

            // Insurance cost
            double insuranceCost = 0;

            if (checkInsurance.Checked)
            {
                insuranceCost = 25 * tickets;
            }

            // Baggage information
            string baggageDetails;

            if (baggage <= 20)
            {
                baggageDetails = "Free";
            }
            else
            {
                baggageDetails = "Extra baggage: " +
                                 (baggage - 20) +
                                 " kg (within 50 kg limit)";
            }

            // Final total
            totalCost += insuranceCost;

            // Booking approved
            string result =
                "========== BOOKING APPROVED ==========\n\n" +
                "Passenger Name: " + name + "\n" +
                "Passenger Age: " + age + "\n" +
                "Number of Tickets: " + tickets + "\n" +
                "Travel Class: " + travelClass + "\n" +
                "Baggage Weight: " + baggage + " kg\n" +
                "Baggage Charge: " + baggageDetails + "\n\n" +
                "Ticket Price: $" + ticketPrice.ToString("F2") + "\n" +
                "Basic Ticket Cost: $" + basicCost.ToString("F2") + "\n" +
                "Discount: $" + discountAmount.ToString("F2") + "\n" +
                "Insurance Cost: $" + insuranceCost.ToString("F2") + "\n" +
                "--------------------------------------\n" +
                "TOTAL COST: $" + totalCost.ToString("F2") + "\n" +
                "======================================\n\n" +
                "Discount Details:\n" +
                (discountDetails == ""
                    ? "No discount applied."
                    : discountDetails);

            bookingdetail.Text = result;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtpassname.Clear();
            txtage.Clear();
            txtticket.Clear();
            txtweight.Clear();

            rdofirst.Checked = false;
            rdonormal.Checked = true;
            rdobusiness.Checked = false;

            checkInsurance.Checked = false;
            bookingdetail.Items.Clear();

            txtpassname.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show(
                "Are you sure you want to exit?",
                "Exit Application",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (answer == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
 

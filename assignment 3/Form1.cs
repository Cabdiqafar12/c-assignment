using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // Creating variables

                string customerName = txtCustomer.Text;
                double previousReading = double.Parse(txtPrevious.Text);
                double currentReading = double.Parse(txtCurrent.Text);
                double unitPrice = double.Parse(txtPrice.Text);

                // Calculate electric ,basic bill ,7% tax ,fixed 5$ and total bill
                double usage = currentReading - previousReading;
                double bill = usage * unitPrice;
                double tax = bill * 0.07;
                double fixedCharge = 5.00;
                double totalBill = bill + tax + fixedCharge;

                // Display electricity usage, Tax and Total amount
                txtUsage.Text = usage.ToString();
                txtTax.Text = "$" + tax.ToString("0.00");
                txtTotal.Text = "$" + totalBill.ToString("0.00");
            }
            catch
            {
                MessageBox.Show("Please enter valid numbers.",
                                "Error");
            }
        }
    }
}

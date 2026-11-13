using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            //create variable 
            int quantty;
            decimal price;

            //Valid input Only Accept valid number
            try
            {

                if (!int.TryParse(txtpackage.Text, out quantty) ||
                    !decimal.TryParse(txtprice.Text, out price) ||
                    quantty <= 0 || price < 0)
                {
                    MessageBox.Show("Soo gali valid saxan");
                    return;
                }

                decimal subtotal = quantty * price;
                decimal discountrate;

                if (quantty >= 100)
                    discountrate = 0.50m;
                else if (quantty >= 50)
                    discountrate = 0.40m;
                else if (quantty >= 20)
                    discountrate = 0.30m;
                else if (quantty >= 10)
                    discountrate = 0.20m;
                else
                    discountrate = 0m;

                decimal discountAmount = subtotal * discountrate;
                decimal total = subtotal - discountAmount;

                listBox1.Items.Add(Text = quantty.ToString());
                listBox1.Items.Add(Text = price.ToString());
                listBox1.Items.Add(Text = subtotal.ToString());
                listBox1.Items.Add(Text = discountrate.ToString());
                listBox1.Items.Add(Text = discountAmount.ToString());
                listBox1.Items.Add(Text = total.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error dhacaayo " + ex.Message);
            }
        }
        

        private void btnclear_Click_1(object sender, EventArgs e)
        {
            try
            {
                txtpackage.Clear();
                txtprice.Clear();
                listBox1.Items.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    }


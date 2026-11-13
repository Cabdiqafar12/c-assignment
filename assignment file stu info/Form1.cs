using System;
using System.IO;
using System.Globalization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment_file_stu_info
{
    public partial class Form1 : Form
    {
        string filePath = @"C:\Users\HP\Videos\isticmal path\Students.txt";
        public Form1()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "" ||
               txtname.Text == "" ||
               txdepart.Text == "" ||
               txtmark.Text == "")
            {
                MessageBox.Show("Please fill all fields!");
                return;
            }

            if (!decimal.TryParse(txtmark.Text,
                NumberStyles.Number,
                CultureInfo.CurrentCulture, out decimal mark)
                || mark < 0)
            {
                MessageBox.Show("Mark must be a non-negative number!");
                return;
            }

            string studentType = "";

            if (rdounder.Checked)
            {
                studentType = "Undergraduate";
            }
            else if (rdopost.Checked)
            {
                studentType = "Postgraduate";
            }
            else
            {
                MessageBox.Show("Please select Student Type!");
                return;
            }

            string studentInfo =
                "Student ID: " + txtid.Text +
                "\r\nStudent Name: " + txtname.Text +
                "\r\nDepartment: " + txdepart.Text +
                "\r\nMark: " + mark +
                "\r\nStudent Type: " + studentType +
                "\r\n-----------------------------\r\n";

            File.AppendAllText(@"C:\Users\HP\Videos\isticmal path\Students.txt", studentInfo);

            MessageBox.Show("Student information saved successfully!");

           
        }

        private void btnread_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            if (File.Exists(filePath))
            {
                string[] students = File.ReadAllLines(filePath);

                foreach (string student in students)
                {
                    listBox1.Items.Add(student);
                }
            }
            else
            {
                MessageBox.Show("File not found!");
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtid.Clear();
            txtname.Clear();
            txdepart.Clear();
            txtmark.Clear();
            listBox1.Items.Clear();

            rdounder.Checked = false;
            rdopost.Checked = false;

            txtid.Focus();
        }
    }
    }
    


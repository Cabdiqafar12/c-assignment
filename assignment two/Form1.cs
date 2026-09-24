using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment_two
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            String name = txtofstudent.Text;
            int studentID = int.Parse(txtofstuID.Text);
            string department = txtofdepat.Text;
            int semester = int.Parse(txtofsem.Text);
            lbloutputass.Text = "Name: " + name + "Student ID: " + studentID + "Department: " + department + "Semester: " + semester;
        }

        private void txtofstudent_TextChanged(object sender, EventArgs e)
        {


        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtofstudent.Clear();
            txtofstuID.Clear();
            txtofdepat.Clear();
            txtofsem.Clear();
            lbloutputass.Text="";


        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtofstuID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

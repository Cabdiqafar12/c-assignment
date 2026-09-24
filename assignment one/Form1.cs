using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment_one
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            String week, month, numeric, year,fulldate;
            week = txtdayofweek.Text;
            month = txtdayofmonth.Text;
            numeric = txtnumofmonth.Text;
            year = txttheyear.Text;
            fulldate = week + "," + month + "," + numeric + "," + year;
            lbloutput.Text = fulldate;


        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtdayofweek.Text="";
            txtdayofmonth.Text="";
            txtnumofmonth.Clear();
            txttheyear.Text=string.Empty;
            lbloutput.Text = string.Empty;
        }
    }
}

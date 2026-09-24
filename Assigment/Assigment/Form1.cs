using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assigment
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

        private void button1_Click(object sender, EventArgs e)
        {
            //Creating variables to store input data

            string DayoftheWeek, Month, Day, Year, FullDate;

            //Assign variable to user input

            DayoftheWeek = txtdayoftheWeek.Text;

            Month = txtdayofthemonth.Text;

            Day = dayofmonthtextbox.Text;

            Year = txtyear.Text;

            //process using concatination

            FullDate = DayoftheWeek  +Month + "" + Day + "," + Year;

            //Display The output

            lbldatoutput.Text = FullDate;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //clear textbox and label

            txtdayoftheWeek.Text = "";

txtdayofthemonth.Clear();

            dayofmonthtextbox.Text = string.Empty;

            txtyear.Text = string.Empty;

            lbldatoutput.Text = string.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

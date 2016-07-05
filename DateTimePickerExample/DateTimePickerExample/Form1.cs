using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateTimePickerExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            label2.Text = dateTimePicker1.Value.ToString();
            label3.Text = dateTimePicker1.Value.ToShortDateString();
            label4.Text = dateTimePicker1.Value.ToLongDateString();
            label5.Text = dateTimePicker1.Value.ToString("dd/MM/yyyy");
            label6.Text = dateTimePicker1.Value.Day.ToString();
            label7.Text = dateTimePicker1.Value.Month.ToString();
            label8.Text = dateTimePicker1.Value.Year.ToString();
            label9.Text = dateTimePicker1.Value.AddDays(5).ToString();



            label10.Text = dateTimePicker1.Value.ToShortTimeString();
            label11.Text = dateTimePicker1.Value.ToLongTimeString();
            label12.Text = dateTimePicker1.Value.Hour.ToString();
            label13.Text = dateTimePicker1.Value.Minute.ToString();
            label14.Text = dateTimePicker1.Value.Second.ToString();
            label15.Text = dateTimePicker1.Value.AddHours(2).ToString();
            label16.Text = dateTimePicker1.Value.AddHours(-2).ToString();


        }
    }
}

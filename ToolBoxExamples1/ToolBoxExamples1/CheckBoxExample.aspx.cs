using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ToolBoxExamples1
{
    public partial class CheckBoxExample : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(CheckBox1.Checked==true)
            {
                double billamount = double.Parse(TextBox1.Text);
                billamount = billamount + 2500;
                TextBox1.Text = billamount.ToString();
            }
            else
            {
                double billamount = double.Parse(TextBox1.Text);
                billamount = billamount - 2500;
                TextBox1.Text = billamount.ToString();
            }
        }

        protected void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox2.Checked == true)
            {
                double billamount = double.Parse(TextBox1.Text);
                billamount = billamount + 500;
                TextBox1.Text = billamount.ToString();
            }
            else
            {
                double billamount = double.Parse(TextBox1.Text);
                billamount = billamount - 500;
                TextBox1.Text = billamount.ToString();
            }
        }

        protected void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox3.Checked == true)
            {
                double billamount = double.Parse(TextBox1.Text);
                billamount = billamount + 500;
                TextBox1.Text = billamount.ToString();
            }
            else
            {
                double billamount = double.Parse(TextBox1.Text);
                billamount = billamount - 500;
                TextBox1.Text = billamount.ToString();
            }
        }

        protected void CheckBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox4.Checked == true)
            {
                double billamount = double.Parse(TextBox1.Text);
                billamount = billamount + 3000;
                TextBox1.Text = billamount.ToString();
            }
            else
            {
                double billamount = double.Parse(TextBox1.Text);
                billamount = billamount - 3000;
                TextBox1.Text = billamount.ToString();
            }
        }
    }
}
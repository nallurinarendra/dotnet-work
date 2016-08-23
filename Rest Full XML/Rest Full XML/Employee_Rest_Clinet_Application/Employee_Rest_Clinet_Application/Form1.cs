using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Employee_WCF_Rest_XML_Format;
using System.Net;
using System.IO;
using System.Runtime.Serialization;


namespace Employee_Rest_Clinet_Application
{
    public partial class Form1 : Form
    {

        string ServiceUrl = "http://localhost:2190/Service1.svc/";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
               
 
                // Insert Employee 
                
                EmployeeDataContract edc = new EmployeeDataContract();
                edc.EmpId = int.Parse(textBox1.Text);
                edc.EmpName = textBox2.Text;
                edc.EmpSalary = float.Parse(textBox3.Text);


                DataContractSerializer ser = new DataContractSerializer(typeof(EmployeeDataContract));
                MemoryStream mem = new MemoryStream();
                ser.WriteObject(mem, edc);
                string data = Encoding.UTF8.GetString(mem.ToArray(), 0, (int)mem.Length);


                WebClient proxy = new WebClient();
                proxy.Headers["Content-type"] = "application/xml";
                proxy.Encoding = Encoding.UTF8;
                proxy.UploadString(ServiceUrl + "AddEmployee", "POST", data);

                MessageBox.Show("Employee Added Successfully...");


                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox1.Focus();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            // Update Employees


            try
            {
                EmployeeDataContract edc = new EmployeeDataContract();
                edc.EmpId = int.Parse(textBox1.Text);
                edc.EmpName = textBox2.Text;
                edc.EmpSalary = float.Parse(textBox3.Text);


                DataContractSerializer ser = new DataContractSerializer(typeof(EmployeeDataContract));
                MemoryStream mem = new MemoryStream();
                ser.WriteObject(mem, edc);



                WebClient proxy = new WebClient();
                proxy.Headers["Content-type"] = "application/xml";
                proxy.Encoding = Encoding.UTF8;
                proxy.UploadData(ServiceUrl + "UpdateEmployee", "PUT", mem.ToArray());

                MessageBox.Show("Employee Updated Successfully...");


                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox1.Focus();
            }
            catch
            {
                MessageBox.Show("Uknow data");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox1.Focus();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Delete Employees

            try
            {
                EmployeeDataContract edc = new EmployeeDataContract();
                edc.EmpId = int.Parse(textBox1.Text);


                DataContractSerializer ser = new DataContractSerializer(typeof(EmployeeDataContract));
                MemoryStream mem = new MemoryStream();
                ser.WriteObject(mem, edc);


                WebClient proxy = new WebClient();
                proxy.Headers["Content-type"] = "application/xml";
                proxy.Encoding = Encoding.UTF8;
                byte[] data = proxy.UploadData(ServiceUrl + "DeleteEmployee", "DELETE", mem.ToArray());




                MessageBox.Show("Employee DELETE Successfully...");


                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox1.Focus();
            }
            catch
            {
                MessageBox.Show("Unknow Data");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox1.Focus();

            }



        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Get Employees
            try
            {
                WebClient proxy = new WebClient();
                byte[] data = proxy.DownloadData(ServiceUrl + "SearchEmployee/" + textBox1.Text);
                Stream stream = new MemoryStream(data);


                DataContractSerializer obj = new DataContractSerializer(typeof(EmployeeDataContract));
                EmployeeDataContract employee = obj.ReadObject(stream) as EmployeeDataContract;
                textBox2.Text = employee.EmpName.ToString();
                textBox3.Text = employee.EmpSalary.ToString();
            }
            catch
            {
                MessageBox.Show("Unknow Data ");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox1.Focus();
            }
           
            
                                

        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      
    }
}

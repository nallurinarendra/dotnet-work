using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinaryWriter_BrinaryReader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("D:/EmployeeData.dat", FileMode.Append, FileAccess.Write);

            BinaryWriter bw = new BinaryWriter(fs);

            int Eno = int.Parse(textBox1.Text);
            string Ename = textBox2.Text;
            double salary = double.Parse(textBox3.Text);
            string sp = " ";

            bw.Write(Eno);
            bw.Write(sp);
            bw.Write(Ename);
            bw.Write(sp);
            bw.Write(salary);

            bw.Close();
            fs.Close();

            MessageBox.Show(" New Employee Record Added Sucessfully...");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("D:/EmployeeData.dat", FileMode.Open, FileAccess.Read);

            BinaryReader br = new BinaryReader(fs);
            while (br.PeekChar() != -1)
                listBox1.Items.Add(br.ReadInt32() + "" + br.ReadString() + "" + br.ReadString() + "" + br.ReadString() + "" + br.ReadDouble());
            br.Close();
            fs.Close();


        }
    }
}

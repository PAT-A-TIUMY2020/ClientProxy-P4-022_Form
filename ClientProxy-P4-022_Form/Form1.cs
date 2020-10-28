using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientProxy_P4_022_Form
{
    public partial class Form1 : Form
    {
        ServiceReference1.MatematikaClient obj = new ServiceReference1.MatematikaClient();
        ServiceReference1.Koordinat a = new ServiceReference1.Koordinat();
        ServiceReference1.Koordinat b = new ServiceReference1.Koordinat();

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            try
            {
                int val1 = Int32.Parse(textBox1.Text);
                int val2 = Int32.Parse(textBox2.Text);
                string selectedItem = comboBox1.Items[comboBox1.SelectedIndex].ToString();
                Console.WriteLine(selectedItem);

                double result = 0;

                switch (selectedItem)
                {
                    case "+":
                        result = obj.Tambah(val1, val2);
                        break;
                    case "-":
                        result = obj.Kurang(val1, val2);
                        break;
                    case "*":
                        result = obj.Kali(val1, val2);
                        break;
                    case ":":
                        result = obj.Bagi(val1, val2);
                        break;
                }

                label4.Text = result.ToString();

            }
            catch {};

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                a.X = Int32.Parse(textBox3.Text);
                a.Y = Int32.Parse(textBox4.Text);
                b.X = Int32.Parse(textBox5.Text);
                b.Y = Int32.Parse(textBox6.Text);

                double selisihX = a.X - b.X;
                double selisihY = a.Y - b.Y;
                double jarak = Math.Sqrt(Math.Pow(selisihX, 2) +
                Math.Pow(selisihY, 2));

                label8.Text = jarak.ToString();

            } catch { }
        }
    }
}

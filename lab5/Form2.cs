using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab5
{
    public partial class Form2 : Form
    {
        int hours;
        double paymentHour;
        public Form2()
        {
            hours = 0;
            paymentHour = 0;
            InitializeComponent();
        }
        public int GetHours() { return hours; }
        public double GetpaymentHours() { return paymentHour; }

        public int GetTextbox1() { return Convert.ToInt32(textBox1.Text); }
        public double GetTextbox2() { return Convert.ToDouble(textBox2.Text); }

        private void button1_Click(object sender, EventArgs e)
        {
            if (GetTextbox1() < 0 && GetTextbox2() < 0)
                MessageBox.Show("Оба поля должны быть > 0");
            else if (GetTextbox1() < 0)
                MessageBox.Show("Кол-во часов должно быть > 0!");
            else if (GetTextbox2() < 0)
                MessageBox.Show("Стоимость одного часа работы должна быть > 0!");
            else
            {
                hours = GetTextbox1();
                paymentHour = GetTextbox2();
                Close();
            }


        }
    }
}

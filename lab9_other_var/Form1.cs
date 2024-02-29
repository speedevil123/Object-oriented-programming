using System.Numerics;
using static System.Math;
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Thread myThread;
        public Form1()
        {
            InitializeComponent();
        }

        private BigInteger factorial(int x)
        {
            var fact = new BigInteger(1);
            for (int i = 1; i <= x; i++)
            {
                fact *= i;
            }
            return fact;
        }

        public void chx()
        {
            double eps = 0.00001;
            string input = textBox2.Text;
            double res;
            double chx;
            if (double.TryParse(input, out res))
            {
                int m = 0;
                double sum = 0;
                chx = Math.Cosh(res);
                do
                {
                    sum += Math.Pow((res), m * 2) / (double)factorial(2 * m);
                    m++;
                } while (Math.Abs(chx - sum) > eps);
                textBox1.Text = sum.ToString();
                textBox4.Text = m.ToString();
                MessageBox.Show("                             !");
            }
            else
                MessageBox.Show("                      !");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            textBox1.Clear();
            textBox4.Clear();
            if (textBox2.Text != null)
            {
                myThread = new Thread(chx);
                myThread.Start();
            }
            else
                MessageBox.Show("                         !");
        }
    }
}
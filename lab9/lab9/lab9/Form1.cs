//21.Создать два потока: главный и вторичный. 
//Главный поток программы должен считывать вводимые пользователем 
//строки и помещать их в начало связанного списка.  
//При вводе пустой строки программа должна выдавать текущее состояние списка.
//Вторичный поток должен пробуждаться каждые 5 с и 
//сортировать список в алфавитном порядке.
using System.Threading;
namespace lab9
{
    public partial class Form1 : Form
    {
        Thread main;
        Thread myThread;
        public Form1()
        {
            InitializeComponent();
            main = Thread.CurrentThread;
            main.Name = "main";

            myThread = new Thread(background);
            myThread.Start();

        }
        private void UpdateListBox(string[] items)
        {
            if (listBox1.InvokeRequired)
            {
                listBox1.Invoke(new Action<string[]>(UpdateListBox), new object[] { items });
            }
            else
            {
                listBox1.Items.Clear();
                foreach (string s in items)
                {
                    listBox1.Items.Add(s);
                }
            }
        }

        private void background()
        {
            while (true)
            {
                strings.Sort();

                string[] itemsCopy;
                lock (strings) // Lock the list to prevent modification while copying
                {
                    itemsCopy = strings.ToArray();
                }

                UpdateListBox(itemsCopy);

                Thread.Sleep(5000);
            }
        }

        private void set_listbox()
        {

            strings.Add(textBox1.Text);
            listBox1.Items.Add(textBox1.Text);
        }
        private List<string> strings = new List<string>();
        private void button1_Click(object sender, EventArgs e)
        {
            set_listbox();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            strings.Clear();
            listBox1.Items.Clear();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (myThread != null && myThread.IsAlive)
            {
                System.Diagnostics.Process.GetCurrentProcess().Kill();
            }
        }
    }
}
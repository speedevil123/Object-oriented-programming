namespace lab5
{
    public partial class Form1 : Form
    {
        private Form2 form2;

        public Form1()
        {
            InitializeComponent();
            form2 = new Form2();
            inputToolStripMenuItem.Click += inputToolStripMenuItem_Click;
            resultToolStripMenuItem.Click += resultToolStripMenuItem_Click;
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            aboutUsToolStripMenuItem.Click += aboutUsToolStripMenuItem_Click;
        }

        private void inputToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            form2.Show();
        }

        private void resultToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            int number = form2.GetHours();
            double number2 = form2.GetpaymentHours();
            if (!(number * number2 == 0))
            {
                MessageBox.Show("Общая з/п: " + (number * number2));
            }
            else
                MessageBox.Show("Стоимость работы и кол-во часов не задано");
        }

        private void exitToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            Close();
        }

        private void aboutUsToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Приложение, позволяющее подсчитать общую з/п:\n\n" +
                "- Для использования нажмите кнопку << Input >> и введите данные\n" +
                "- Далее нажмите кнопку << Результат >> для вывода результата\n" +
                "- После окончания работы в приложении нажмите << Exit >>");
        }
    }
}
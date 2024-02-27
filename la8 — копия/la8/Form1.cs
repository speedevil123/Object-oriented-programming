using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Xml;

namespace la8
{
    public partial class Form1 : Form
    {
        string file_name = "houses.xml";
        XmlTextReader xml_read;
        DataSet DataXML;
        DataTable MyDatatable = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataXML = new DataSet();
            FileStream fs = new FileStream(file_name, FileMode.Open);
            xml_read = new XmlTextReader(fs);
            DataXML.ReadXml(xml_read, XmlReadMode.InferSchema);

            MyDatatable = DataXML.Tables[0];
            bindingSource1.DataMember = DataXML.Tables[0].ToString();
            bindingSource1.DataSource = DataXML.Tables[0];

            dataGridView1.DataSource = bindingSource1;
            dataGridView1.EditMode = DataGridViewEditMode.EditOnEnter;

            dataGridView1.Columns[0].Width = 70;
            dataGridView1.Columns[0].HeaderText = "Улица";

            dataGridView1.Columns[1].Width = 60;
            dataGridView1.Columns[1].HeaderText = "Номер дома";

            dataGridView1.Columns[2].Width = 60;
            dataGridView1.Columns[2].HeaderText = "Номер кв.";

            dataGridView1.Columns[3].Width = 60;
            dataGridView1.Columns[3].HeaderText = "Кол-во комнат";

            dataGridView1.Columns[4].Width = 60;
            dataGridView1.Columns[4].HeaderText = "Этаж";

            dataGridView1.Columns[5].Width = 100;
            dataGridView1.Columns[5].HeaderText = "Кол-во квартир на этаже";

            dataGridView1.Columns[6].Width = 100;
            dataGridView1.Columns[6].HeaderText = "Кол-во подъездов";

            dataGridView1.Columns[7].Width = 110;
            dataGridView1.Columns[7].HeaderText = "Общее кол-во квартир";

            ;
            fs.Close();
            dataGridView1.ClearSelection();

        }

        private class RowComparer : System.Collections.IComparer
        {
            private static int sortOrderModifier = 1;

            public RowComparer(SortOrder sortOrder)
            {
                if (sortOrder == SortOrder.Descending)
                {
                    sortOrderModifier = -1;
                }
                else if (sortOrder == SortOrder.Ascending)
                {
                    sortOrderModifier = 1;
                }
            }

            public int Compare(object x, object y)
            {
                DataGridViewRow DataGridViewRow1 = (DataGridViewRow)x;
                DataGridViewRow DataGridViewRow2 = (DataGridViewRow)y;

                // Try to sort based on the Last Name column.
                int CompareResult = System.String.Compare(
                    DataGridViewRow1.Cells[1].Value.ToString(),
                    DataGridViewRow2.Cells[1].Value.ToString());

                // If the Last Names are equal, sort based on the First Name.
                if (CompareResult == 0)
                {
                    CompareResult = System.String.Compare(
                        DataGridViewRow1.Cells[0].Value.ToString(),
                        DataGridViewRow2.Cells[0].Value.ToString());
                }
                return CompareResult * sortOrderModifier;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                textBox1.Text = DataXML.Tables[0].Rows[e.RowIndex][0].ToString();
                textBox2.Text = DataXML.Tables[0].Rows[e.RowIndex][1].ToString();
                textBox3.Text = DataXML.Tables[0].Rows[e.RowIndex][2].ToString();
                textBox4.Text = DataXML.Tables[0].Rows[e.RowIndex][3].ToString();
                textBox7.Text = DataXML.Tables[0].Rows[e.RowIndex][4].ToString();
                textBox8.Text = DataXML.Tables[0].Rows[e.RowIndex][5].ToString();
                textBox9.Text = DataXML.Tables[0].Rows[e.RowIndex][6].ToString();
                textBox10.Text = DataXML.Tables[0].Rows[e.RowIndex][7].ToString();
            }
            else
                return;
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                textBox1.Text = DataXML.Tables[0].Rows[e.RowIndex][0].ToString();
                textBox2.Text = DataXML.Tables[0].Rows[e.RowIndex][1].ToString();
                textBox3.Text = DataXML.Tables[0].Rows[e.RowIndex][2].ToString();
                textBox4.Text = DataXML.Tables[0].Rows[e.RowIndex][3].ToString();
                textBox7.Text = DataXML.Tables[0].Rows[e.RowIndex][4].ToString();
                textBox8.Text = DataXML.Tables[0].Rows[e.RowIndex][5].ToString();
                textBox9.Text = DataXML.Tables[0].Rows[e.RowIndex][6].ToString();
                textBox10.Text = DataXML.Tables[0].Rows[e.RowIndex][7].ToString();
            }
            else
                return;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //textBox5 Ул.
            //textbox14 Дом
            //textbox13 Кв.
            //textbox6 Кол-во комнат
            listBox1.Items.Clear();
            if (textBox5.Text == string.Empty && textBox14.Text == string.Empty && textBox13.Text == string.Empty && textBox6.Text == string.Empty)
            {
                MessageBox.Show("Поля для поиска не могут быть пустыми!");
                return;
            }

            if (textBox5.Text != string.Empty && textBox14.Text != string.Empty && textBox13.Text != string.Empty && textBox6.Text == string.Empty)
            {
                for (int i = 0; i < DataXML.Tables[0].Rows.Count; i++)
                {
                    if (DataXML.Tables[0].Rows[i][0].ToString() == textBox5.Text &&
                        DataXML.Tables[0].Rows[i][1].ToString() == textBox14.Text &&
                        DataXML.Tables[0].Rows[i][2].ToString() == textBox13.Text)
                    {
                        textBox11.Text = "Улица: " + textBox5.Text + " Дом: " + textBox14.Text + " Квартира: " + textBox13.Text;
                        string line = "Улица: " +
                            DataXML.Tables[0].Rows[i][0].ToString() + ", Дом: " + " " +
                            DataXML.Tables[0].Rows[i][1].ToString() + ", Квартира: " + " " +
                            DataXML.Tables[0].Rows[i][2].ToString() + ", Кол-во квартир: " + " " +
                            DataXML.Tables[0].Rows[i][3].ToString() + ", Этаж: " + " " +
                            DataXML.Tables[0].Rows[i][4].ToString() + ", Кол-во квартир на этаже:" + " " +
                            DataXML.Tables[0].Rows[i][5].ToString() + ", Кол-во подъездов: " + " " +
                            DataXML.Tables[0].Rows[i][6].ToString() + ", Общее кол-во квартир: " + " " +
                            DataXML.Tables[0].Rows[i][7].ToString();
                        listBox1.Items.Add(line);
                    }
                }
            }
            else if (textBox6.Text != string.Empty && textBox5.Text == string.Empty && textBox14.Text == string.Empty && textBox13.Text == string.Empty)
            {
                for (int i = 0; i < DataXML.Tables[0].Rows.Count; i++)
                {
                    if (DataXML.Tables[0].Rows[i][3].ToString() == textBox6.Text)
                    {
                        string line = "Улица: " +
                            DataXML.Tables[0].Rows[i][0].ToString() + ", Дом: " + " " +
                            DataXML.Tables[0].Rows[i][1].ToString() + ", Квартира: " + " " +
                            DataXML.Tables[0].Rows[i][2].ToString() + ", Кол-во квартир: " + " " +
                            DataXML.Tables[0].Rows[i][3].ToString() + ", Этаж: " + " " +
                            DataXML.Tables[0].Rows[i][4].ToString() + ", Кол-во квартир на этаже:" + " " +
                            DataXML.Tables[0].Rows[i][5].ToString() + ", Кол-во подъездов: " + " " +
                            DataXML.Tables[0].Rows[i][6].ToString() + ", Общее кол-во квартир: " + " " +
                            DataXML.Tables[0].Rows[i][7].ToString();
                        listBox1.Items.Add(line);
                    }
                }
            }
            else
            {
                MessageBox.Show("Для поиска по адресу:\n" +
                    "- Заполните поля дом, кв., кол-во комнат.\n" +
                    "\n Для поиска по кол-ву комнат:\n" +
                    "- Заполните кол-во комнат.\n" +
                    "После выполнения одного из двух действий нажмите кнопку << Поиск >>");
            }

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                dataGridView1.Sort(dataGridView1.Columns[3], ListSortDirection.Ascending);
            }
        }
    }
}
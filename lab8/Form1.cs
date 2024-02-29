using System.Data;
using System.Xml;

namespace la8
{
    public partial class Form1 : Form
    {
        string file_name = "raspisanie.xml";
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

            dataGridView1.Columns[0].Width = 110;
            dataGridView1.Columns[0].HeaderText = "           ";

            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[1].HeaderText = "       ";

            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[2].HeaderText = "         ";

            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[3].HeaderText = "             ";

            ;
            fs.Close();
            dataGridView1.ClearSelection();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                textBox1.Text = DataXML.Tables[0].Rows[e.RowIndex][0].ToString();
                textBox2.Text = DataXML.Tables[0].Rows[e.RowIndex][1].ToString();
                textBox3.Text = DataXML.Tables[0].Rows[e.RowIndex][2].ToString();
                textBox4.Text = DataXML.Tables[0].Rows[e.RowIndex][3].ToString();
            }
            else
                return;
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox1.Text = DataXML.Tables[0].Rows[e.RowIndex][0].ToString();
            textBox2.Text = DataXML.Tables[0].Rows[e.RowIndex][1].ToString();
            textBox3.Text = DataXML.Tables[0].Rows[e.RowIndex][2].ToString();
            textBox4.Text = DataXML.Tables[0].Rows[e.RowIndex][3].ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null)
            {
                MessageBox.Show("                !");
                return;
            }

            for (int i = 0; i < DataXML.Tables[0].Rows.Count; i++)
            {
                if (DataXML.Tables[0].Rows[i][0].ToString() == textBox5.Text)
                {
                    textBox6.Text = textBox5.Text;
                    string line = "       : " + DataXML.Tables[0].Rows[i][1].ToString() + ",          : " +
                        DataXML.Tables[0].Rows[i][2].ToString() + ",      : " + DataXML.Tables[0].Rows[i][3].ToString();
                    listBox1.Items.Add(line);
                }
            }

        }
    }
}
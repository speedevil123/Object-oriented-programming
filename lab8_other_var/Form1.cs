using System.Collections;
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
        DataTable MyDatatable = new DataTable();
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
            DataXML.ReadXml(xml_read, XmlReadMode.Auto);

            MyDatatable.Columns.Add("Street", typeof(string));
            MyDatatable.Columns.Add("House Number", typeof(Int32));
            MyDatatable.Columns.Add("FlatNumber", typeof(Int32));
            MyDatatable.Columns.Add("RoomsAmount", typeof(Int32));
            MyDatatable.Columns.Add("Etaj", typeof(Int32));
            MyDatatable.Columns.Add("FlatsPerFloor", typeof(Int32));
            MyDatatable.Columns.Add("EntrancesAmount", typeof(Int32));
            MyDatatable.Columns.Add("AllFlatsAmount", typeof(Int32));


            for (int i = 0; i < DataXML.Tables[0].Rows.Count; i++)
            {
                MyDatatable.Rows.Add();
                if (MyDatatable.Columns[0].ColumnName == "Street")
                {
                    MyDatatable.Rows[i][0] = DataXML.Tables[0].Rows[i][0];
                }
                MyDatatable.Rows[i][1] = Convert.ToInt16(DataXML.Tables[0].Rows[i][1]);
                MyDatatable.Rows[i][2] = Convert.ToInt16(DataXML.Tables[0].Rows[i][2]);
                MyDatatable.Rows[i][3] = Convert.ToInt16(DataXML.Tables[0].Rows[i][3]);
                MyDatatable.Rows[i][4] = Convert.ToInt16(DataXML.Tables[0].Rows[i][4]);
                MyDatatable.Rows[i][5] = Convert.ToInt16(DataXML.Tables[0].Rows[i][5]);
                MyDatatable.Rows[i][6] = Convert.ToInt16(DataXML.Tables[0].Rows[i][6]);
                MyDatatable.Rows[i][7] = Convert.ToInt16(DataXML.Tables[0].Rows[i][7]);
            }

            bindingSource1.DataMember = MyDatatable.TableName;
            bindingSource1.DataSource = MyDatatable;

            dataGridView1.DataSource = bindingSource1;
            dataGridView1.EditMode = DataGridViewEditMode.EditOnEnter;

            dataGridView1.Columns[0].Width = 70;
            dataGridView1.Columns[0].HeaderText = "     ";

            dataGridView1.Columns[1].Width = 60;
            dataGridView1.Columns[1].HeaderText = "          ";

            dataGridView1.Columns[2].Width = 60;
            dataGridView1.Columns[2].HeaderText = "        .";

            dataGridView1.Columns[3].Width = 60;
            dataGridView1.Columns[3].HeaderText = "   -         ";

            dataGridView1.Columns[4].Width = 60;
            dataGridView1.Columns[4].HeaderText = "    ";

            dataGridView1.Columns[5].Width = 100;
            dataGridView1.Columns[5].HeaderText = "   -                   ";

            dataGridView1.Columns[6].Width = 100;
            dataGridView1.Columns[6].HeaderText = "   -            ";

            dataGridView1.Columns[7].Width = 110;
            dataGridView1.Columns[7].HeaderText = "         -          ";

            fs.Close();
            dataGridView1.ClearSelection();

        }


        private void button1_Click(object sender, EventArgs e)
        {
            //textBox5   .
            //textbox14    
            //textbox13   .
            //textbox6    -         
            listBox1.Items.Clear();
            if (textBox5.Text == string.Empty && textBox14.Text == string.Empty && textBox13.Text == string.Empty && textBox6.Text == string.Empty)
            {
                MessageBox.Show("                                     !");
                return;
            }

            if (textBox5.Text != string.Empty && textBox14.Text != string.Empty && textBox13.Text != string.Empty && textBox6.Text == string.Empty)
            {
                for (int i = 0; i < DataXML.Tables[0].Rows.Count; i++)
                {
                    if (MyDatatable.Rows[i][0].ToString() == textBox5.Text &&
                        MyDatatable.Rows[i][1].ToString() == textBox14.Text &&
                        MyDatatable.Rows[i][2].ToString() == textBox13.Text)
                    {
                        textBox11.Text = "     : " + textBox5.Text + "    : " + textBox14.Text + "         : " + textBox13.Text;
                        string line = "     : " +
                            MyDatatable.Rows[i][0].ToString() + ",    : " + " " +
                            MyDatatable.Rows[i][1].ToString() + ",         : " + " " +
                            MyDatatable.Rows[i][2].ToString() + ",    -         : " + " " +
                            MyDatatable.Rows[i][3].ToString() + ",     : " + " " +
                            MyDatatable.Rows[i][4].ToString() + ",    -                   :" + " " +
                            MyDatatable.Rows[i][5].ToString() + ",    -            : " + " " +
                            MyDatatable.Rows[i][6].ToString() + ",          -          : " + " " +
                            MyDatatable.Rows[i][7].ToString();
                        listBox1.Items.Add(line);
                    }
                }
                textBox5.Clear();
                textBox14.Clear();
                textBox13.Clear();
            }
            else if (textBox6.Text != string.Empty && textBox5.Text == string.Empty && textBox14.Text == string.Empty && textBox13.Text == string.Empty)
            {
                for (int i = 0; i < DataXML.Tables[0].Rows.Count; i++)
                {
                    if (MyDatatable.Rows[i][3].ToString() == textBox6.Text)
                    {
                        string line = "     : " +
                            MyDatatable.Rows[i][0].ToString() + ",    : " + " " +
                            MyDatatable.Rows[i][1].ToString() + ",         : " + " " +
                            MyDatatable.Rows[i][2].ToString() + ",    -         : " + " " +
                            MyDatatable.Rows[i][3].ToString() + ",     : " + " " +
                            MyDatatable.Rows[i][4].ToString() + ",    -                   :" + " " +
                            MyDatatable.Rows[i][5].ToString() + ",    -            : " + " " +
                            MyDatatable.Rows[i][6].ToString() + ",          -          : " + " " +
                            MyDatatable.Rows[i][7].ToString();
                        listBox1.Items.Add(line);
                    }
                }
                textBox6.Clear();
            }
            else
            {
                MessageBox.Show("                    :\n" +
                    "-                   ,   .,    -         .\n" +
                    "\n                  -         :\n" +
                    "-              -         .\n" +
                    "                                                        <<       >>");
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

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                textBox7.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                textBox8.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                textBox9.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                textBox10.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            }
            else
                return;
        }

    }
}
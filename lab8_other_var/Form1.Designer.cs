namespace la8
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            bindingSource1 = new BindingSource(components);
            textBox5 = new TextBox();
            button1 = new Button();
            listBox1 = new ListBox();
            label7 = new Label();
            label8 = new Label();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            textBox10 = new TextBox();
            label9 = new Label();
            label10 = new Label();
            textBox11 = new TextBox();
            textBox12 = new TextBox();
            textBox6 = new TextBox();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            textBox13 = new TextBox();
            textBox14 = new TextBox();
            label6 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(1009, 25);
            label1.Name = "label1";
            label1.Size = new Size(87, 18);
            label1.TabIndex = 1;
            label1.Text = "По адресу";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ButtonHighlight;
            textBox1.Location = new Point(40, 46);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(140, 27);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.ButtonHighlight;
            textBox2.Location = new Point(40, 114);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(140, 27);
            textBox2.TabIndex = 3;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.ButtonHighlight;
            textBox3.Location = new Point(40, 182);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(140, 27);
            textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.ButtonHighlight;
            textBox4.Location = new Point(40, 250);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(140, 27);
            textBox4.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(40, 25);
            label2.Name = "label2";
            label2.Size = new Size(56, 18);
            label2.TabIndex = 6;
            label2.Text = "Улица";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(40, 93);
            label3.Name = "label3";
            label3.Size = new Size(101, 18);
            label3.TabIndex = 7;
            label3.Text = "Номер дома";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(40, 161);
            label4.Name = "label4";
            label4.Size = new Size(84, 18);
            label4.TabIndex = 8;
            label4.Text = "Номер кв.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(40, 229);
            label5.Name = "label5";
            label5.Size = new Size(122, 18);
            label5.TabIndex = 9;
            label5.Text = "Кол-во комнат";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(1009, 46);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(161, 27);
            textBox5.TabIndex = 10;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientInactiveCaption;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(1009, 250);
            button1.Name = "button1";
            button1.Size = new Size(94, 27);
            button1.TabIndex = 12;
            button1.Text = "Поиск";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(40, 337);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(1119, 204);
            listBox1.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(252, 25);
            label7.Name = "label7";
            label7.Size = new Size(49, 18);
            label7.TabIndex = 16;
            label7.Text = "Этаж";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(252, 93);
            label8.Name = "label8";
            label8.Size = new Size(203, 18);
            label8.TabIndex = 17;
            label8.Text = "Кол-во квартир на этаже";
            // 
            // textBox7
            // 
            textBox7.BackColor = SystemColors.ButtonHighlight;
            textBox7.Location = new Point(252, 46);
            textBox7.Name = "textBox7";
            textBox7.ReadOnly = true;
            textBox7.Size = new Size(140, 27);
            textBox7.TabIndex = 18;
            // 
            // textBox8
            // 
            textBox8.BackColor = SystemColors.ButtonHighlight;
            textBox8.Location = new Point(252, 114);
            textBox8.Name = "textBox8";
            textBox8.ReadOnly = true;
            textBox8.Size = new Size(140, 27);
            textBox8.TabIndex = 19;
            // 
            // textBox9
            // 
            textBox9.BackColor = SystemColors.ButtonHighlight;
            textBox9.Location = new Point(252, 182);
            textBox9.Name = "textBox9";
            textBox9.ReadOnly = true;
            textBox9.Size = new Size(140, 27);
            textBox9.TabIndex = 20;
            // 
            // textBox10
            // 
            textBox10.BackColor = SystemColors.ButtonHighlight;
            textBox10.Location = new Point(252, 250);
            textBox10.Name = "textBox10";
            textBox10.ReadOnly = true;
            textBox10.Size = new Size(140, 27);
            textBox10.TabIndex = 21;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(252, 161);
            label9.Name = "label9";
            label9.Size = new Size(151, 18);
            label9.TabIndex = 22;
            label9.Text = "Кол-во подъездов";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(252, 229);
            label10.Name = "label10";
            label10.Size = new Size(184, 18);
            label10.TabIndex = 23;
            label10.Text = "Общее кол-во квартир";
            // 
            // textBox11
            // 
            textBox11.BackColor = SystemColors.ButtonHighlight;
            textBox11.Location = new Point(589, 307);
            textBox11.Name = "textBox11";
            textBox11.ReadOnly = true;
            textBox11.Size = new Size(335, 27);
            textBox11.TabIndex = 24;
            textBox11.TextChanged += textBox11_TextChanged;
            // 
            // textBox12
            // 
            textBox12.BackColor = SystemColors.ButtonHighlight;
            textBox12.Location = new Point(956, 307);
            textBox12.Name = "textBox12";
            textBox12.ReadOnly = true;
            textBox12.Size = new Size(122, 27);
            textBox12.TabIndex = 25;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(1009, 217);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(144, 27);
            textBox6.TabIndex = 26;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(1009, 196);
            label11.Name = "label11";
            label11.Size = new Size(144, 18);
            label11.TabIndex = 27;
            label11.Text = "По кол-ву комнат";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(589, 286);
            label12.Name = "label12";
            label12.Size = new Size(55, 18);
            label12.TabIndex = 28;
            label12.Text = "Адрес";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(956, 286);
            label13.Name = "label13";
            label13.Size = new Size(122, 18);
            label13.TabIndex = 29;
            label13.Text = "Кол-во комнат";
            // 
            // textBox13
            // 
            textBox13.Location = new Point(1009, 136);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(161, 27);
            textBox13.TabIndex = 30;
            // 
            // textBox14
            // 
            textBox14.Location = new Point(1009, 89);
            textBox14.Name = "textBox14";
            textBox14.Size = new Size(161, 27);
            textBox14.TabIndex = 31;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(956, 50);
            label6.Name = "label6";
            label6.Size = new Size(33, 18);
            label6.TabIndex = 32;
            label6.Text = "Ул.";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(956, 93);
            label14.Name = "label14";
            label14.Size = new Size(40, 18);
            label14.TabIndex = 33;
            label14.Text = "Дом";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(959, 140);
            label15.Name = "label15";
            label15.Size = new Size(33, 18);
            label15.TabIndex = 34;
            label15.Text = "Кв.";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label16.Location = new Point(477, 17);
            label16.Name = "label16";
            label16.Size = new Size(226, 21);
            label16.TabIndex = 35;
            label16.Text = "Объекты недвижимости";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(461, 50);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(489, 227);
            dataGridView1.TabIndex = 36;
            dataGridView1.CellClick += dataGridView1_CellContentClick_1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1182, 553);
            Controls.Add(dataGridView1);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label6);
            Controls.Add(textBox14);
            Controls.Add(textBox13);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(textBox6);
            Controls.Add(textBox12);
            Controls.Add(textBox11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(textBox10);
            Controls.Add(textBox9);
            Controls.Add(textBox8);
            Controls.Add(textBox7);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "XML-обработчик";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private BindingSource bindingSource1;
        private TextBox textBox5;
        private Button button1;
        private ListBox listBox1;
        private Label label7;
        private Label label8;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox9;
        private TextBox textBox10;
        private Label label9;
        private Label label10;
        private TextBox textBox11;
        private TextBox textBox12;
        private TextBox textBox6;
        private Label label11;
        private Label label12;
        private Label label13;
        private TextBox textBox13;
        private TextBox textBox14;
        private Label label6;
        private Label label14;
        private Label label15;
        private Label label16;
        private DataGridView dataGridView1;
    }
}
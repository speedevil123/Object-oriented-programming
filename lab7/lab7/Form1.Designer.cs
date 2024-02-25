namespace lab7
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
            textBoxInput = new TextBox();
            label1 = new Label();
            buttonDisplay = new Button();
            customPanel1 = new CustomPanel1();
            label11 = new Label();
            customPanel12 = new CustomPanel1();
            label12 = new Label();
            textBoxNewPath = new TextBox();
            buttonDelete = new Button();
            buttonCopyTo = new Button();
            buttonMoveTo = new Button();
            label5 = new Label();
            customPanel11 = new CustomPanel1();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            textBoxLastWriteTime = new TextBox();
            textBoxLastAccessTime = new TextBox();
            textBoxCreationTime = new TextBox();
            textBoxFileSize = new TextBox();
            label6 = new Label();
            textBoxFileName = new TextBox();
            label4 = new Label();
            label3 = new Label();
            ListBoxFolders = new ListBox();
            ListBoxFiles = new ListBox();
            buttonUp = new Button();
            textBoxFolder = new TextBox();
            label2 = new Label();
            customPanel1.SuspendLayout();
            customPanel12.SuspendLayout();
            customPanel11.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxInput
            // 
            textBoxInput.BorderStyle = BorderStyle.FixedSingle;
            textBoxInput.Location = new Point(13, 33);
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new Size(496, 27);
            textBoxInput.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(13, 9);
            label1.Name = "label1";
            label1.Size = new Size(496, 18);
            label1.TabIndex = 1;
            label1.Text = "Введите имя файла или папки и нажмите кнопку \"Отобразить\"";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonDisplay
            // 
            buttonDisplay.BackColor = SystemColors.InactiveBorder;
            buttonDisplay.FlatAppearance.BorderColor = Color.Black;
            buttonDisplay.FlatStyle = FlatStyle.Flat;
            buttonDisplay.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDisplay.Location = new Point(530, 32);
            buttonDisplay.Name = "buttonDisplay";
            buttonDisplay.Size = new Size(120, 27);
            buttonDisplay.TabIndex = 2;
            buttonDisplay.Text = "Отобразить";
            buttonDisplay.UseVisualStyleBackColor = false;
            buttonDisplay.Click += button1_Click;
            // 
            // customPanel1
            // 
            customPanel1.BorderColor = Color.LightGray;
            customPanel1.Controls.Add(label11);
            customPanel1.Controls.Add(customPanel12);
            customPanel1.Controls.Add(label5);
            customPanel1.Controls.Add(customPanel11);
            customPanel1.Controls.Add(label4);
            customPanel1.Controls.Add(label3);
            customPanel1.Controls.Add(ListBoxFolders);
            customPanel1.Controls.Add(ListBoxFiles);
            customPanel1.Controls.Add(buttonUp);
            customPanel1.Controls.Add(textBoxFolder);
            customPanel1.Controls.Add(label2);
            customPanel1.Location = new Point(6, 79);
            customPanel1.Name = "customPanel1";
            customPanel1.Size = new Size(644, 662);
            customPanel1.TabIndex = 3;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(7, 492);
            label11.Name = "label11";
            label11.Size = new Size(180, 18);
            label11.TabIndex = 12;
            label11.Text = "Действия над файлом";
            // 
            // customPanel12
            // 
            customPanel12.BorderColor = Color.LightGray;
            customPanel12.Controls.Add(label12);
            customPanel12.Controls.Add(textBoxNewPath);
            customPanel12.Controls.Add(buttonDelete);
            customPanel12.Controls.Add(buttonCopyTo);
            customPanel12.Controls.Add(buttonMoveTo);
            customPanel12.Location = new Point(7, 513);
            customPanel12.Name = "customPanel12";
            customPanel12.Size = new Size(630, 146);
            customPanel12.TabIndex = 11;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(14, 97);
            label12.Name = "label12";
            label12.Size = new Size(166, 18);
            label12.TabIndex = 13;
            label12.Text = "Новый путь к файлу";
            // 
            // textBoxNewPath
            // 
            textBoxNewPath.BorderStyle = BorderStyle.FixedSingle;
            textBoxNewPath.Location = new Point(194, 94);
            textBoxNewPath.Name = "textBoxNewPath";
            textBoxNewPath.Size = new Size(410, 27);
            textBoxNewPath.TabIndex = 4;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = SystemColors.InactiveBorder;
            buttonDelete.FlatAppearance.BorderColor = Color.Black;
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDelete.Location = new Point(464, 23);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(140, 40);
            buttonDelete.TabIndex = 15;
            buttonDelete.Text = "Удаление";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonCopyTo
            // 
            buttonCopyTo.BackColor = SystemColors.InactiveBorder;
            buttonCopyTo.FlatAppearance.BorderColor = Color.Black;
            buttonCopyTo.FlatStyle = FlatStyle.Flat;
            buttonCopyTo.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCopyTo.Location = new Point(247, 23);
            buttonCopyTo.Name = "buttonCopyTo";
            buttonCopyTo.Size = new Size(140, 40);
            buttonCopyTo.TabIndex = 14;
            buttonCopyTo.Text = "Копирование";
            buttonCopyTo.UseVisualStyleBackColor = false;
            buttonCopyTo.Click += buttonCopyTo_Click;
            // 
            // buttonMoveTo
            // 
            buttonMoveTo.BackColor = SystemColors.InactiveBorder;
            buttonMoveTo.FlatAppearance.BorderColor = Color.Black;
            buttonMoveTo.FlatStyle = FlatStyle.Flat;
            buttonMoveTo.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonMoveTo.Location = new Point(30, 23);
            buttonMoveTo.Name = "buttonMoveTo";
            buttonMoveTo.Size = new Size(140, 40);
            buttonMoveTo.TabIndex = 13;
            buttonMoveTo.Text = "Перемещение";
            buttonMoveTo.UseVisualStyleBackColor = false;
            buttonMoveTo.Click += buttonMoveTo_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(7, 274);
            label5.Name = "label5";
            label5.Size = new Size(364, 18);
            label5.TabIndex = 10;
            label5.Text = "Детальная информация о выделенном файле";
            // 
            // customPanel11
            // 
            customPanel11.BorderColor = Color.LightGray;
            customPanel11.Controls.Add(label10);
            customPanel11.Controls.Add(label9);
            customPanel11.Controls.Add(label8);
            customPanel11.Controls.Add(label7);
            customPanel11.Controls.Add(textBoxLastWriteTime);
            customPanel11.Controls.Add(textBoxLastAccessTime);
            customPanel11.Controls.Add(textBoxCreationTime);
            customPanel11.Controls.Add(textBoxFileSize);
            customPanel11.Controls.Add(label6);
            customPanel11.Controls.Add(textBoxFileName);
            customPanel11.Location = new Point(7, 295);
            customPanel11.Name = "customPanel11";
            customPanel11.Size = new Size(630, 184);
            customPanel11.TabIndex = 9;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(313, 119);
            label10.Name = "label10";
            label10.Size = new Size(218, 18);
            label10.TabIndex = 19;
            label10.Text = "Время последнего доступа";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(37, 119);
            label9.Name = "label9";
            label9.Size = new Size(255, 18);
            label9.TabIndex = 18;
            label9.Text = "Время последней модификации";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(313, 56);
            label8.Name = "label8";
            label8.Size = new Size(132, 18);
            label8.TabIndex = 17;
            label8.Text = "Время создания";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(37, 56);
            label7.Name = "label7";
            label7.Size = new Size(64, 18);
            label7.TabIndex = 16;
            label7.Text = "Размер";
            // 
            // textBoxLastWriteTime
            // 
            textBoxLastWriteTime.BackColor = SystemColors.MenuBar;
            textBoxLastWriteTime.BorderStyle = BorderStyle.FixedSingle;
            textBoxLastWriteTime.Location = new Point(37, 140);
            textBoxLastWriteTime.Name = "textBoxLastWriteTime";
            textBoxLastWriteTime.ReadOnly = true;
            textBoxLastWriteTime.Size = new Size(255, 27);
            textBoxLastWriteTime.TabIndex = 15;
            // 
            // textBoxLastAccessTime
            // 
            textBoxLastAccessTime.BackColor = SystemColors.MenuBar;
            textBoxLastAccessTime.BorderStyle = BorderStyle.FixedSingle;
            textBoxLastAccessTime.Location = new Point(313, 140);
            textBoxLastAccessTime.Name = "textBoxLastAccessTime";
            textBoxLastAccessTime.ReadOnly = true;
            textBoxLastAccessTime.Size = new Size(255, 27);
            textBoxLastAccessTime.TabIndex = 14;
            // 
            // textBoxCreationTime
            // 
            textBoxCreationTime.BackColor = SystemColors.MenuBar;
            textBoxCreationTime.BorderStyle = BorderStyle.FixedSingle;
            textBoxCreationTime.Location = new Point(313, 77);
            textBoxCreationTime.Name = "textBoxCreationTime";
            textBoxCreationTime.ReadOnly = true;
            textBoxCreationTime.Size = new Size(255, 27);
            textBoxCreationTime.TabIndex = 13;
            // 
            // textBoxFileSize
            // 
            textBoxFileSize.BackColor = SystemColors.MenuBar;
            textBoxFileSize.BorderStyle = BorderStyle.FixedSingle;
            textBoxFileSize.Location = new Point(37, 77);
            textBoxFileSize.Name = "textBoxFileSize";
            textBoxFileSize.ReadOnly = true;
            textBoxFileSize.Size = new Size(255, 27);
            textBoxFileSize.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(22, 22);
            label6.Name = "label6";
            label6.Size = new Size(40, 18);
            label6.TabIndex = 11;
            label6.Text = "Имя";
            label6.Click += label6_Click;
            // 
            // textBoxFileName
            // 
            textBoxFileName.BackColor = SystemColors.MenuBar;
            textBoxFileName.BorderStyle = BorderStyle.FixedSingle;
            textBoxFileName.Location = new Point(107, 19);
            textBoxFileName.Name = "textBoxFileName";
            textBoxFileName.ReadOnly = true;
            textBoxFileName.Size = new Size(496, 27);
            textBoxFileName.TabIndex = 11;
            textBoxFileName.TextChanged += textBoxFileName_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(334, 77);
            label4.Name = "label4";
            label4.Size = new Size(55, 18);
            label4.TabIndex = 8;
            label4.Text = "Папки";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(7, 77);
            label3.Name = "label3";
            label3.Size = new Size(62, 18);
            label3.TabIndex = 7;
            label3.Text = "Файлы";
            // 
            // ListBoxFolders
            // 
            ListBoxFolders.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ListBoxFolders.FormattingEnabled = true;
            ListBoxFolders.ItemHeight = 18;
            ListBoxFolders.Location = new Point(333, 98);
            ListBoxFolders.Name = "ListBoxFolders";
            ListBoxFolders.Size = new Size(304, 166);
            ListBoxFolders.TabIndex = 6;
            ListBoxFolders.SelectedIndexChanged += ListBoxFolders_SelectedIndexChanged;
            // 
            // ListBoxFiles
            // 
            ListBoxFiles.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ListBoxFiles.FormattingEnabled = true;
            ListBoxFiles.ItemHeight = 18;
            ListBoxFiles.Location = new Point(7, 98);
            ListBoxFiles.Name = "ListBoxFiles";
            ListBoxFiles.Size = new Size(304, 166);
            ListBoxFiles.TabIndex = 5;
            ListBoxFiles.SelectedIndexChanged += ListBoxFiles_SelectedIndexChanged;
            // 
            // buttonUp
            // 
            buttonUp.BackColor = SystemColors.InactiveBorder;
            buttonUp.FlatAppearance.BorderColor = Color.Black;
            buttonUp.FlatStyle = FlatStyle.Flat;
            buttonUp.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonUp.Location = new Point(524, 31);
            buttonUp.Name = "buttonUp";
            buttonUp.Size = new Size(86, 27);
            buttonUp.TabIndex = 4;
            buttonUp.Text = "Вверх";
            buttonUp.UseVisualStyleBackColor = false;
            buttonUp.Click += buttonUp_Click;
            // 
            // textBoxFolder
            // 
            textBoxFolder.BackColor = SystemColors.MenuBar;
            textBoxFolder.BorderStyle = BorderStyle.FixedSingle;
            textBoxFolder.Location = new Point(7, 31);
            textBoxFolder.Name = "textBoxFolder";
            textBoxFolder.ReadOnly = true;
            textBoxFolder.Size = new Size(496, 27);
            textBoxFolder.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(7, 10);
            label2.Name = "label2";
            label2.Size = new Size(95, 18);
            label2.TabIndex = 0;
            label2.Text = "Путь папки";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(662, 753);
            Controls.Add(buttonDisplay);
            Controls.Add(label1);
            Controls.Add(textBoxInput);
            Controls.Add(customPanel1);
            Name = "Form1";
            Text = "Файловый браузер";
            customPanel1.ResumeLayout(false);
            customPanel1.PerformLayout();
            customPanel12.ResumeLayout(false);
            customPanel12.PerformLayout();
            customPanel11.ResumeLayout(false);
            customPanel11.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxInput;
        private Label label1;
        private Button buttonDisplay;
        private CustomPanel1 customPanel1;
        private TextBox textBoxFolder;
        private Label label2;
        private Button buttonUp;
        private ListBox ListBoxFolders;
        private ListBox ListBoxFiles;
        private Label label4;
        private Label label3;
        private Label label5;
        private CustomPanel1 customPanel11;
        private Label label6;
        private TextBox textBoxFileName;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private TextBox textBoxLastWriteTime;
        private TextBox textBoxLastAccessTime;
        private TextBox textBoxCreationTime;
        private TextBox textBoxFileSize;
        private CustomPanel1 customPanel12;
        private Label label11;
        private Button buttonMoveTo;
        private Label label12;
        private TextBox textBoxNewPath;
        private Button buttonDelete;
        private Button buttonCopyTo;
    }
    public class CustomPanel1 : Panel
    {
        private Color borderColor = Color.LightGray;

        public Color BorderColor
        {
            get { return borderColor; }
            set { borderColor = value; Invalidate(); }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle, borderColor, ButtonBorderStyle.Solid);
        }
    }
}
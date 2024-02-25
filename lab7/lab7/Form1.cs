using System.Web;

namespace lab7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private string currentFolderPath;

        //Display button
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string folderPath = textBoxInput.Text;
                DirectoryInfo directoryInfo = new DirectoryInfo(folderPath);
                if (directoryInfo.Exists)
                {
                    DisplayFolderList(directoryInfo.FullName);
                    return;

                }
                FileInfo fileInfo = new FileInfo(folderPath);
                if (fileInfo.Exists)
                {
                    DisplayFolderList(fileInfo.Directory.FullName);
                    int index = ListBoxFiles.Items.IndexOf(fileInfo.Name);
                    ListBoxFiles.SetSelected(index, true);
                    return;
                }
                throw new FileNotFoundException("Файла с заданным именем или путём с этим именем: " + textBoxInput.Text + " не существует");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void ClearAllFields()
        {
            ListBoxFolders.Items.Clear();
            ListBoxFiles.Items.Clear();
            textBoxFolder.Text = string.Empty;
            textBoxFileName.Text = string.Empty;
            textBoxCreationTime.Text = string.Empty;
            textBoxLastAccessTime.Text = string.Empty;
            textBoxLastWriteTime.Text = string.Empty;
            textBoxFileSize.Text = string.Empty;
        }

        private void DisableMoveFeatures()
        {
            textBoxNewPath.Text = string.Empty;
            textBoxNewPath.Enabled = false;
            buttonCopyTo.Enabled = false;
            buttonDelete.Enabled = false;
            buttonMoveTo.Enabled = false;
        }

        private void DisplayFileInfo(string fileFullName)
        {
            FileInfo fileInfo = new FileInfo(fileFullName);
            if (!fileInfo.Exists)
            {
                throw new FileNotFoundException("Файл не найден: " + fileFullName);
            }
            textBoxFileName.Text = fileInfo.Name;

            textBoxCreationTime.Text = fileInfo.CreationTime.ToLongTimeString();
            textBoxLastAccessTime.Text = fileInfo.LastAccessTime.ToLongDateString();
            textBoxLastWriteTime.Text = fileInfo.LastWriteTime.ToLongDateString();
            textBoxFileSize.Text = fileInfo.Length.ToString() + " bytes";

            textBoxNewPath.Text = fileInfo.FullName;
            textBoxNewPath.Enabled = true;
            buttonCopyTo.Enabled = true;
            buttonDelete.Enabled = true;
            buttonMoveTo.Enabled = true;
        }

        private void DisplayFolderList(string folderFullName)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(folderFullName);
            if (!directoryInfo.Exists)
            {
                throw new DirectoryNotFoundException("Папка не найдена: " + folderFullName);
            }
            ClearAllFields();
            DisableMoveFeatures();

            textBoxFolder.Text = directoryInfo.FullName;
            currentFolderPath = directoryInfo.FullName;

            foreach (DirectoryInfo nextFolder in directoryInfo.GetDirectories())
            {
                ListBoxFolders.Items.Add(nextFolder.Name);
            }

            foreach (FileInfo nextFile in directoryInfo.GetFiles())
            {
                ListBoxFiles.Items.Add(nextFile.Name);
            }
        }



        private void textBoxFileName_TextChanged(object sender, EventArgs e)
        {

        }

        private void ListBoxFolders_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string selectedString = ListBoxFolders.SelectedItem.ToString();
                string fullPathName = Path.Combine(currentFolderPath, selectedString);
                DisplayFolderList(fullPathName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            try
            {
                string folderPath = new FileInfo(currentFolderPath).DirectoryName;
                DisplayFolderList(folderPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = Path.Combine(currentFolderPath, textBoxFileName.Text);
                string query = "Вы действительно хотите удалить файл\n" + filePath + "?";
                if (MessageBox.Show(query, "Удалить файл?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    File.Delete(filePath);
                    DisplayFolderList(currentFolderPath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Невозможно удалить файл - Ошибка: " + ex.Message);
            }
        }

        private void buttonMoveTo_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = Path.Combine(currentFolderPath, textBoxFileName.Text);
                string query = "Вы действительно хотите переместить файл\n" + filePath + " в" + textBoxNewPath + "?";
                if (MessageBox.Show(query, "Переместить файл?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    File.Move(filePath, textBoxNewPath.Text);
                    DisplayFolderList(currentFolderPath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Невозможно переместить файл - Ошибка: " + ex.Message);
            }
        }

        private void buttonCopyTo_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = Path.Combine(currentFolderPath, textBoxFileName.Text);
                string query = "Вы действительно хотите скопировать файл\n" + filePath + " в" + textBoxNewPath + "?";
                if (MessageBox.Show(query, "Копировать файл?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    File.Copy(filePath, textBoxNewPath.Text);
                    DisplayFolderList(currentFolderPath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Невозможно скопировать файл - Ошибка: " + ex.Message);
            }
        }

        private void ListBoxFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string selectedString = ListBoxFiles.SelectedItem.ToString();
                string fullFileName = Path.Combine(currentFolderPath, selectedString);
                DisplayFileInfo(fullFileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
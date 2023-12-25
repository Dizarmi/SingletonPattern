using System;
using System.Windows.Forms;

namespace SingletonPattern
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void DatabaseAccessButton_Click(object sender, EventArgs e)
        {
            DbManager dbManager = DbManager.GetInstance();
            // Використання dbManager для взаємодії з базою даних
            // Наприклад, dbManager.PerformDatabaseOperation();
            MessageBox.Show("Accessed database using Singleton: " + dbManager.ToString());
        }

        private void DocumentSaveButton_Click(object sender, EventArgs e)
        {
            DocumentSaver documentSaver = DocumentSaver.GetInstance();
            // Використання documentSaver для збереження документів
            // Наприклад, documentSaver.SaveDocument();
            MessageBox.Show("Saved document using Singleton: " + documentSaver.ToString());
        }

        private void LogButton_Click(object sender, EventArgs e)
        {
            Logger logger = Logger.GetInstance();
            logger.Log("User performed an action.");
            MessageBox.Show("Logged using Singleton: " + logger.ToString());
        }

        private void ShowLogButton_Click(object sender, EventArgs e)
        {
            LogForm logForm = new LogForm();
            logForm.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

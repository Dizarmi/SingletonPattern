using System;
using System.IO; // Додайте цей рядок
using System.Windows.Forms;

namespace SingletonPattern
{
    public partial class LogForm : Form
    {
        public LogForm()
        {
            InitializeComponent();
            DisplayLogs();

            // Додавання обробника події dataGridView1_CellContentClick
            dataGridView1.CellContentClick += DataGridView1_CellContentClick;
        }

        // Обробник події для dataGridView1_CellContentClick
        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Обробка події
            // Наприклад, ви можете отримати значення клітинки, на яку клікнули:
            string cellValue = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString();
            MessageBox.Show("Clicked cell value: " + cellValue);
        }

        private void DisplayLogs()
        {
            string logFileName = "log.txt";
            if (File.Exists(logFileName))
            {
                string[] logs = File.ReadAllLines(logFileName);
                foreach (string log in logs)
                {
                    dataGridView1.Rows.Add(log);
                }
            }
        }
    }
}

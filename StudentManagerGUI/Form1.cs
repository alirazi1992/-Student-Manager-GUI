using System;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;

namespace StudentManagerGUI
{
    public partial class Form1 : Form
    {
        private string _dbPath;
        private string _connectionString;

        public Form1()
        {
            InitializeComponent();

            _dbPath = Path.Combine(AppContext.BaseDirectory, "students.db");
            _connectionString = "Data Source=" + _dbPath;

            EnsureDatabase();

            LoadData();
        }

        private void EnsureDatabase()
        {
            if (!File.Exists(_dbPath))
            {
                SQLiteConnection.CreateFile(_dbPath);
            }

            using (var conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                string sql = @"CREATE TABLE IF NOT EXISTS Students (
                                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                                Name TEXT NOT NULL,
                                Age INTEGER NOT NULL,
                                Major TEXT NOT NULL
                              );";
                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void LoadData()
        {
            using (var conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                string sql = "SELECT * FROM Students";
                using (var da = new SQLiteDataAdapter(sql, conn))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvStudents.DataSource = dt;
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                string sql = "INSERT INTO Students (Name, Age, Major) VALUES (@Name, @Age, @Major)";
                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", txtName.Text);
                    cmd.Parameters.AddWithValue("@Age", int.Parse(txtAge.Text));
                    cmd.Parameters.AddWithValue("@Major", txtMajor.Text);
                    cmd.ExecuteNonQuery();
                }
            }
            LoadData();
            ClearInputs();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvStudents.CurrentRow == null) return;
            int id = Convert.ToInt32(dgvStudents.CurrentRow.Cells["Id"].Value);

            using (var conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                string sql = "UPDATE Students SET Name=@Name, Age=@Age, Major=@Major WHERE Id=@Id";
                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", txtName.Text);
                    cmd.Parameters.AddWithValue("@Age", int.Parse(txtAge.Text));
                    cmd.Parameters.AddWithValue("@Major", txtMajor.Text);
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();
                }
            }
            LoadData();
            ClearInputs();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvStudents.CurrentRow == null) return;
            int id = Convert.ToInt32(dgvStudents.CurrentRow.Cells["Id"].Value);

            using (var conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                string sql = "DELETE FROM Students WHERE Id=@Id";
                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();
                }
            }
            LoadData();
        }

        private void dgvStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvStudents.CurrentRow != null)
            {
                txtName.Text = dgvStudents.CurrentRow.Cells["Name"].Value.ToString();
                txtAge.Text = dgvStudents.CurrentRow.Cells["Age"].Value.ToString();
                txtMajor.Text = dgvStudents.CurrentRow.Cells["Major"].Value.ToString();
            }
        }

        private void ClearInputs()
        {
            txtName.Clear();
            txtAge.Clear();
            txtMajor.Clear();
        }
    }
}

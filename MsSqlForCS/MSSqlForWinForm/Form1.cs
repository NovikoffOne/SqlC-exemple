using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace MSSqlForWinForm
{
    public partial class Form1 : Form
    {
        private SqlConnection _sqlConnection;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["TestDB"].ConnectionString);

            _sqlConnection.Open();

            if(_sqlConnection.State == ConnectionState.Open)
                MessageBox.Show("Подключено");
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand(
                $"INSERT INTO [Students] (Name, Surname, Birthday, Phone, Email) VALUES (@Name, @Surname, @Birthday, @Phone, @Email)",
                _sqlConnection
                );

            command.Parameters.AddWithValue("Name", NameField.Text);
            command.Parameters.AddWithValue("Surname", SurnameField.Text);
            command.Parameters.AddWithValue("Birthday", DateField.Text);
            command.Parameters.AddWithValue("Phone", PhoneField.Text);
            command.Parameters.AddWithValue("Email", EmailField.Text);

            MessageBox.Show($"{command.ExecuteNonQuery() > 0}");
        }
    }
}

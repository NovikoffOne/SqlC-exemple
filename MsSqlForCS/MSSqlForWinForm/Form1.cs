using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;
using System.Net.Http.Headers;

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

        private void SelectButton_Click(object sender, EventArgs e)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter(
                TextBoxRow.Text,
                _sqlConnection
                );

            DataSet dataSet = new DataSet();
            
            dataAdapter.Fill(dataSet);

            dataGridView1.DataSource = dataSet.Tables[0];
        }

        private void SelectButtonToSQLDRider_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            SqlDataReader sqlDataReader = null;

            try
            {
                SqlCommand command = new SqlCommand(
                    "SELECT ProductName, QuantityPerUnit, UnitPrice FROM Products",
                    _sqlConnection
                );

                sqlDataReader = command.ExecuteReader();

                ListViewItem item = null;

                while (sqlDataReader.Read())
                {
                    item = new ListViewItem(new string[]
                    {
                        Convert.ToString(sqlDataReader["ProductName"]),
                        Convert.ToString(sqlDataReader["QuantityPerUnit"]),
                        Convert.ToString(sqlDataReader["UnitPrice"]),
                    });

                    listView1.Items.Add(item);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                if(sqlDataReader != null && !sqlDataReader.IsClosed)
                {
                    sqlDataReader.Close();
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"ProductName LIKE '%{textBox1.Text}%'";
        }
    }
}

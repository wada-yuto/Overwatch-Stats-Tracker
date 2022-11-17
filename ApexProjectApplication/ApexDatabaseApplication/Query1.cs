using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApexDatabaseApplication
{
    public partial class Query1 : Form
    {
        public Query1()
        {
            InitializeComponent();
        }

        private void Execute_Click(object sender, EventArgs e)
        {
            const string connectionString = @"Server=BLD\SQLEXPRESS;Database=ApexDatabase;Integrated Security=True;";
            try
            {
                SqlConnectionStringBuilder build = new SqlConnectionStringBuilder(connectionString);

                using (SqlConnection connection = new SqlConnection(build.ConnectionString))
                {
                    string sql = $"SELECT ItemID, Barcode FROM dbo.TEST_Barcode WHERE Barcode = 9323503022494";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {

                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                textBox1.Text = reader.GetValue(0).ToString();
                            }
                        }
                    }
                }
            }
            catch (SystemException)
            {
            }
        }
    }
}

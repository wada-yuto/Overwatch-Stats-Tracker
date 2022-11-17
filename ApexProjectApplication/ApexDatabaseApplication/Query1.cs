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
            var tourneyID = uxTIDInput.Text;

            const string connectionString = @"Server=BLD\SQLEXPRESS;Database=ApexDatabase;Integrated Security=True;";
            try
            {
                SqlConnectionStringBuilder build = new SqlConnectionStringBuilder(connectionString);

                using (SqlConnection connection = new SqlConnection(build.ConnectionString))
                {
                    string sql = $"CharacterWinPercentage";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        //Need to change this part to supply parameters
                        command.Parameters.Add(new SqlParameter("@CharacterName", uxCharacerComboBox.Text));

                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            DataTable dt = new DataTable();
                            dt.Load(reader);
                            uxDataView.DataSource = dt;
                            MessageBox.Show("Query successful");
                                connection.Close();
                        }
                    }
                }
            }
            catch (SystemException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            //string ConnectionString = @"Data Source = (localdb) / MSSQLLocalDB; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
            //using (SqlConnection MyConnection = new SqlConnection(ConnectionString))
            //{
            //    MyConnection.Open();
            //    // some code here 
            //}
            //SqlConnection con = new SqlConnection("Server= localhost, Authentication=Windows Authentication, Database= ApexDatabase");
            //con.Open();
            //SqlConnection con = new SqlConnection();
            //con.Open();
            //SqlCommand cmd = new SqlCommand("SELECT * FROM ApexDatabase.Team", MyConnection);


            //var reader = cmd.ExecuteReader();
            //if (reader == null)
            //{

            //    MessageBox.Show("Error");
            //}
            //else
            //
            //DataTable dt = new DataTable();
            //dt.Load(reader);
            //uxDataView.DataSource = dt;
            //    con.Close();
            //}
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

    }
}


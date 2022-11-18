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
    public partial class TournamentWinnerFrm : Form
    {
        public TournamentWinnerFrm()
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
                    string sql = $"FindTournamentWinner";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        string [] tournamentID = uxTournamentComboBox.Text.Split(' ');
                        //Need to change this part to supply parameters
                        command.Parameters.Add(new SqlParameter("@TournamentID", tournamentID[1] ));
                        

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
        }
    }
}

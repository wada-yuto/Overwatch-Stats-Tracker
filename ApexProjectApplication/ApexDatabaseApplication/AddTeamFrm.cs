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
    public partial class AddTeamFrm : Form
    {
        public AddTeamFrm()
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
                    string sql = $"AddNewTeam";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        //Need to change this part to supply parameters
                        command.Parameters.Add(new SqlParameter("@Coach", uxCoachTextBox.Text));
                        command.Parameters.Add(new SqlParameter("@Record", uxRecord.Text));
                        command.Parameters.Add(new SqlParameter("@TeamName", uxTeamName.Text));
                        command.Parameters.Add(new SqlParameter("@Player1", uxTextBoxPlayer1.Text));
                        command.Parameters.Add(new SqlParameter("@Player2", uxTextBoxPlayer2.Text));
                        command.Parameters.Add(new SqlParameter("@Player3", uxTextBoxPlayer3.Text));
                        command.Parameters.Add(new SqlParameter("@Player4", uxTextBoxPlayer4.Text));
                        command.Parameters.Add(new SqlParameter("@Player5", uxTextBoxPlayer5.Text));



                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            MessageBox.Show("Team Added");
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

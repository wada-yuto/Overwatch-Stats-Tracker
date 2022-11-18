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
    public partial class AddNewPlayerFrm : Form
    {
        public AddNewPlayerFrm()
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
                    string sql = $"AddNewPlayer";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        //Need to change this part to supply parameters
                        command.Parameters.Add(new SqlParameter("@PlayerName", uxEnteredName.Text));
                        command.Parameters.Add(new SqlParameter("@TotalKills", uxKills.Text));
                        command.Parameters.Add(new SqlParameter("@Main", uxMain.Text));
                        command.Parameters.Add(new SqlParameter("@Role", uxCharacerComboBox.Text));
                        command.Parameters.Add(new SqlParameter("@Email", uxEnteredEmail.Text));

                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            MessageBox.Show("Player Added");
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

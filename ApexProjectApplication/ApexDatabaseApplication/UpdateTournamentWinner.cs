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
    public partial class UpdateTournamentWinner : Form
    {
        public UpdateTournamentWinner()
        {
            InitializeComponent();
        }
        //EditWinnerTournamentGame
        private void Execute_Click(object sender, EventArgs e)
        {
            const string connectionString = @"Server=BLD\SQLEXPRESS;Database=OverwatchDatabase;Integrated Security=True;";
            try
            {
                SqlConnectionStringBuilder build = new SqlConnectionStringBuilder(connectionString);

                using (SqlConnection connection = new SqlConnection(build.ConnectionString))
                {
                    string sql = $"EditWinnerTournamentGame";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        string[] tournamentID = uxTournamentComboBox.Text.Split(' ');
                        Console.WriteLine(uxT1CB.SelectedIndex + 1);
                        Console.WriteLine(uxT2CB.SelectedIndex + 1);
                        //Need to change this part to supply parameters
                        command.Parameters.Add(new SqlParameter("@TournamentID", tournamentID[1]));
                        command.Parameters.Add(new SqlParameter("@Team1ID", uxT1CB.SelectedIndex + 1));
                        command.Parameters.Add(new SqlParameter("@Team2ID", uxT2CB.SelectedIndex + 1));
                        command.Parameters.Add(new SqlParameter("@Winner", uxWinner.SelectedIndex + 1));

                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            MessageBox.Show("Tournament Winner Updated");
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

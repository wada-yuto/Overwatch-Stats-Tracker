﻿using System;
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
                //try
                //{
                //    SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

                //    builder.DataSource = "<your_server.database.windows.net>";
                //    builder.UserID = "<your_username>";
                //    builder.Password = "<your_password>";
                //    builder.InitialCatalog = "<your_database>";

                //    using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                //    {
                //        Console.WriteLine("\nQuery data example:");
                //        Console.WriteLine("=========================================\n");

                //        connection.Open();

                //        String sql = "SELECT name, collation_name FROM sys.databases";

                //        using (SqlCommand command = new SqlCommand(sql, connection))
                //        {
                //            using (SqlDataReader reader = command.ExecuteReader())
                //            {
                //                while (reader.Read())
                //                {
                //                    Console.WriteLine("{0} {1}", reader.GetString(0), reader.GetString(1));
                //                }
                //            }
                //        }
                //    }
                //}
                //catch (SqlException ex)
                //{
                //    Console.WriteLine(ex.ToString());
                //}
                //Console.WriteLine("\nDone. Press enter.");
                //Console.ReadLine();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}


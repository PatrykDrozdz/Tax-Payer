using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;//konieczne do połączenia z db

namespace CSS_database_connection_tries
{
    public partial class addAdmin : Form
    {
        public addAdmin()
        {
            InitializeComponent();
            passTxt.PasswordChar = '*';
        }

        private void addAdministrator_Click(object sender, EventArgs e)
        {
            string connDetail = "datasource=localhost;port=3306;username=root;password=root;";
            string selectQuery = "SELECT * FROM taxpayer.admins;";

            MySqlConnection conn = new MySqlConnection(connDetail);
            MySqlCommand command = new MySqlCommand(selectQuery, conn);

            MySqlDataReader queryReader;

            try
            {
                conn.Open();

                queryReader = command.ExecuteReader();


                while (queryReader.Read())
                {

                    string login = queryReader.GetString("login");

                    if (login == logTxt.Text)
                    {
                        MessageBox.Show("Administrator o tym loginie już istnieje!");
                    }
                    else {
                        MessageBox.Show("OK!");
                    }


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

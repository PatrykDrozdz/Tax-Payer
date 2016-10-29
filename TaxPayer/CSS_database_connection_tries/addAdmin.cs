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

        private int checkLogin = 0;

        private void addAdministrator_Click(object sender, EventArgs e)
        {
            string connDetail = "datasource=localhost;port=3306;username=root;password=root;";
            string selectQuery = "SELECT * FROM taxpayer.admins;";
            string insertQuery = "INSERT INTO taxpayer.admins(idadmins, login, password) VALUES(NULL, '"+this.logTxt.Text+"', '"+this.passTxt.Text+"');";

            MySqlConnection conn = new MySqlConnection(connDetail);
            MySqlCommand command = new MySqlCommand(selectQuery, conn);
            MySqlCommand command2 = new MySqlCommand(insertQuery, conn);

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
                        checkLogin++;
                    }
                    

                }

                conn.Close();

                if (checkLogin > 0)
                {
                    MessageBox.Show("Administrator o tym loginie już istnieje!");
                }
                else
                {

                    conn.Open();
                    command2.ExecuteReader();
                    MessageBox.Show("Administrator dodany!");
                    this.Close();
                }

                checkLogin = 0;

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

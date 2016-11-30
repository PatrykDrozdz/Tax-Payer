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
    public partial class UpdateAccount : Form
    {
        Connection connect = new Connection();
        AdminPanel ap;
        MySqlConnection conn;
        MySqlCommand command;
        MySqlDataReader queryReader;

        private string updateQuery;
        private string selectQuery;
        private int idadmin;

        public UpdateAccount(AdminPanel ap)
        {
            InitializeComponent();
            newPass.PasswordChar = '*';
            this.ap = ap;
            this.loginToShow.Text = ap.Login.ToString();
            setIdAdmin();
        }

        void setIdAdmin()
        {

            this.selectQuery = "SELECT * FROM taxpayer.admins WHERE login = '"+this.loginToShow.Text+"';";

            conn = new MySqlConnection(connect.connDetail);
            command = new MySqlCommand(selectQuery, conn);

            try
            {
                conn.Open();

                queryReader = command.ExecuteReader();


                while (queryReader.Read())
                {
                    this.idadmin = queryReader.GetInt32("idadmins");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void changeLog_Click(object sender, EventArgs e)
        {

            updateQuery = "UPDATE taxpayer.admins SET login='"+this.newLog.Text+"' WHERE idadmins = '"+this.idadmin+"';";

            conn = new MySqlConnection(connect.connDetail);
            command = new MySqlCommand(updateQuery, conn);

            try
            {
                conn.Open();

                queryReader = command.ExecuteReader();

                MessageBox.Show("Edytowano login administratora!");

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void changePass_Click(object sender, EventArgs e)
        {

            updateQuery = "UPDATE taxpayer.admins SET password='" + this.newPass.Text + "' WHERE idadmins = '" + this.idadmin + "';";

            conn = new MySqlConnection(connect.connDetail);
            command = new MySqlCommand(updateQuery, conn);

            try
            {
                conn.Open();

                queryReader = command.ExecuteReader();

                MessageBox.Show("Edytowano hasło administratora!");

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}

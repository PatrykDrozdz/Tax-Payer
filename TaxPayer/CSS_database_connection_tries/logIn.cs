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
    public partial class logIn : Form
    {
        public logIn()
        {
            InitializeComponent();
            pass_text.PasswordChar = '*';
            

        }

        private void connect_db_Click(object sender, EventArgs e)
        {
            try {

                string connDetail = "datasource=localhost;port=3306;username=root;password=root;";
                MySqlConnection conn = new MySqlConnection(connDetail);

                MySqlCommand SelectComm = new MySqlCommand("SELECT * FROM taxpayer.admins WHERE login = '" + this.log_text.Text + "' AND password = '" + this.pass_text.Text + "';", conn);

                MySqlDataReader dataReader;
                conn.Open();

                dataReader = SelectComm.ExecuteReader();

                int userCount = 0;

                while (dataReader.Read())
                {
                    userCount = userCount + 1;

                }


                if (userCount == 1)
                {
                    MessageBox.Show("admin zalogowany!");
                    this.Hide();
                    AdminPanel formAdmin = new AdminPanel();

                    formAdmin.Show();


                }
                else if (userCount > 1)
                {
                    MessageBox.Show("duplikacja!");
                }
                else
                    MessageBox.Show("zły login lub hasło!");
                

                conn.Close();

            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void closeForms_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aplikacja zamknięta");
            Add f2 = new Add();
            this.Close();
            f2.Close();
            
        }

        private void liczenieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            addingDatasToCount adtc = new addingDatasToCount();
            adtc.Show();
        }

        private void zamknijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pomocToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

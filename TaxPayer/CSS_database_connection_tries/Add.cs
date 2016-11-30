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
    public partial class Add : Form
    {

        Connection connect = new Connection();
        private int idFreePay;

        public Add()
        {
            InitializeComponent();
            fillComboFreeTaxValue();
        }

        


        void fillComboFreeTaxValue()
        {


            string selectQuery = "SELECT * FROM taxpayer.freetaxvalue;";


            MySqlConnection conn = new MySqlConnection(connect.connDetail);
            MySqlCommand command = new MySqlCommand(selectQuery, conn);
            MySqlDataReader queryReader;

            try
            {
                conn.Open();

                queryReader = command.ExecuteReader();

                while (queryReader.Read())
                {
                    string value = queryReader.GetString("freePay");
                    taxFreeValue.Items.Add(value);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void logOut_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wylogowany!");
            this.Hide();
            LogIn f1 = new LogIn();
            f1.Show();
        }


        private void taxFreeValue_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectQuery = "SELECT * FROM taxpayer.freetaxvalue WHERE freePay='" + taxFreeValue.Text + "';";

            MySqlConnection conn = new MySqlConnection(connect.connDetail);
            MySqlCommand command = new MySqlCommand(selectQuery, conn);

            MySqlDataReader queryReader;

            try
            {
                conn.Open();

                queryReader = command.ExecuteReader();

                while (queryReader.Read())
                {

                    idFreePay = queryReader.GetInt32("idfreetaxvalue");

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void insertToDB_Click(object sender, EventArgs e)
        {
			
            string insertQuery = "INSERT INTO taxpayer.taxes (idtaxes, value, guaranteedAmount, downPayment, maxPayment, flagT, freetaxvalue_idfreetaxvalue) VALUES (NULL, '" + this.valueUpDown.Value + "','" + this.guaranteedAmountUpDown.Value + "', '" + this.downPaymentUpDown.Value + "', '" + this.maxPaymentUpDown.Value + "', '1', '"+ idFreePay + "');";

            MySqlConnection conn = new MySqlConnection(connect.connDetail);
            MySqlCommand command = new MySqlCommand(insertQuery, conn);

            MySqlDataReader queryReader;


            try {
                conn.Open();

                queryReader = command.ExecuteReader();
                MessageBox.Show("Dane zapisane do bazy!");
                this.Close();


               }
           catch (Exception ex)
           {
                MessageBox.Show(ex.Message);
           }
            

        }

     
    }
}

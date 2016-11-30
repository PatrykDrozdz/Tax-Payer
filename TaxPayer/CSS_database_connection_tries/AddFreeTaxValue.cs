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
    public partial class AddFreeTaxValue : Form
    {
        public AddFreeTaxValue()
        {
            InitializeComponent();
        }

        private int checkValue = 0;
        Connection connect = new Connection();

        private void addFreePaymentTax_Click(object sender, EventArgs e)
        {

            string selectQuery = "SELECT * FROM taxpayer.freetaxvalue;";
            string insertQuery = "INSERT INTO taxpayer.freetaxvalue(idfreetaxvalue, freePay) VALUES(NULL, '" + taxFreePaymentUpDown .Value+ "');";

            MySqlConnection conn = new MySqlConnection(connect.connDetail);
            MySqlCommand command = new MySqlCommand(selectQuery, conn);
            MySqlCommand command2 = new MySqlCommand(insertQuery, conn);

            MySqlDataReader queryReader;

            try
            {
                conn.Open();

                queryReader = command.ExecuteReader();


                while (queryReader.Read())
                {

                    double value = queryReader.GetDouble("freePay");

                    if ((double)taxFreePaymentUpDown.Value == value)
                    {
                        checkValue++;
                    }


                }

                conn.Close();

                if (checkValue > 0)
                {
                    MessageBox.Show("Podana kwota wolna od podatku jest już w bazie!");
                }
                else
                {

                    conn.Open();
                    command2.ExecuteReader();
                    MessageBox.Show("Kwota wolna od podatku została dodana!");
                    this.Close();
                }

                checkValue = 0;

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}

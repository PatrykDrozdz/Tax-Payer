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
    public partial class TaxFreePayEdit : Form
    {
        public TaxFreePayEdit()
        {
            InitializeComponent();
            getFreeTaxPayment();
        }

        void getFreeTaxPayment() {

            string connDetail = "datasource=localhost;port=3306;username=root;password=root;";
            string selsectQuery = "SELECT * FROM taxpayer.freetaxvalue;";

            MySqlConnection conn = new MySqlConnection(connDetail);
            MySqlCommand command = new MySqlCommand(selsectQuery, conn);

            MySqlDataReader queryReader;

            try
            {
                conn.Open();

                queryReader = command.ExecuteReader();
              

                while (queryReader.Read())
                {

                    string freePayTax = queryReader.GetString("freePay");

                    taxFreePaymentToShow.Text = freePayTax;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void updateFreePaymentTax_Click(object sender, EventArgs e)
        {

            string connDetail = "datasource=localhost;port=3306;username=root;password=root;";
            string updateQuery = "UPDATE taxpayer.freetaxvalue SET freePay='"+taxFreePaymentUpDown.Value+"' WHERE idfreeTaxValue='1';";

            MySqlConnection conn = new MySqlConnection(connDetail);
            MySqlCommand command = new MySqlCommand(updateQuery, conn);

            MySqlDataReader queryReader;

            try
            {
                conn.Open();

                queryReader = command.ExecuteReader();


                MessageBox.Show("Edytowano kwotę wolną od podatku!");

                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}

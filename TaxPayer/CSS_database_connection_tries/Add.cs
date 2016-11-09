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
        public Add()
        {
            InitializeComponent();
        }

        private int flagFreePayment = 1;

        private void logOut_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wylogowany!");
            this.Hide();
            logIn f1 = new logIn();
            f1.Show();
        }



        private void insertToDB_Click(object sender, EventArgs e)
        {

            if (this.freePaymentUnused.Checked)
            {
                flagFreePayment = 0;
            }

			string connDetail = "datasource=localhost;port=3306;username=root;password=root;";
            string insertQuery = "INSERT INTO taxpayer.taxes (idtaxes, value, guaranteedAmount, downPayment, maxPayment, flagFreePayment, contents, flagT) VALUES (NULL, '" + this.valueUpDown.Value + "','" + this.guaranteedAmountUpDown.Value + "', '" + this.downPaymentUpDown.Value + "', '" + this.maxPaymentUpDown.Value + "', '" + this.flagFreePayment + "','" + this.contentsText.Text + "', '1');";

            MySqlConnection conn = new MySqlConnection(connDetail);
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

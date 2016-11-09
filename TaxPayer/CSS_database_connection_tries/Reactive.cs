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
    public partial class Reactive : Form
    {
        public Reactive()
        {
            InitializeComponent();
            fillComboId();
        }


        void fillComboId()
        { 
            string connDetail = "datasource=localhost;port=3306;username=root;password=root;";
            string selectQuery = "SELECT * FROM taxpayer.taxes WHERE flagT=0;";
 
             MySqlConnection conn = new MySqlConnection(connDetail);
             MySqlCommand command = new MySqlCommand(selectQuery, conn);
			 MySqlDataReader queryReader;	
			 
			 
            try
            {
                conn.Open();

                queryReader = command.ExecuteReader();

                while (queryReader.Read())
                {
                    string ids = queryReader.GetString("idtaxes");
                    idCombo.Items.Add(ids);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void idCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string connDetail = "datasource=localhost;port=3306;username=root;password=root;";
             string insertQuery = "SELECT * FROM taxpayer.taxes WHERE flagT=0 AND idtaxes='" + idCombo.Text + "';";

            MySqlConnection conn = new MySqlConnection(connDetail);
            MySqlCommand command = new MySqlCommand(insertQuery, conn);

           MySqlDataReader queryReader;

            try
            {
                conn.Open();

                queryReader = command.ExecuteReader();

                while (queryReader.Read())
                {
                   string value = queryReader.GetString("value");
                   string guaranteedAmount = queryReader.GetString("guaranteedAmount");
                   string downPayment = queryReader.GetString("downPayment");
                   string maxPayment = queryReader.GetString("maxPayment");
                   string contents = queryReader.GetString("contents");
                   int flagFreePayment = queryReader.GetInt32("flagFreePayment");

                    labelForValue.Text = value;
                    labelForGuaranteedAmount.Text = guaranteedAmount;
                    labelForDownPayment.Text = downPayment;
                    labelForMaxPayment.Text = maxPayment;
                    contentsTextLabel.Text = contents;

                    if (flagFreePayment == 0)
                    {
                        this.labelForTaxFreePaymentInfo.Text = "nieobowiązuje";
                    }
                    else if (flagFreePayment == 1)
                    {
                        this.labelForTaxFreePaymentInfo.Text = "obowiązuje";
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void reactiveButton_Click(object sender, EventArgs e)
        {

            string connDetail = "datasource=localhost;port=3306;username=root;password=root;";
            string updateQuery = "UPDATE taxpayer.taxes SET flagT='1' WHERE idtaxes='" + idCombo.Text + "' ;";
            MySqlConnection conn = new MySqlConnection(connDetail);
            MySqlCommand command = new MySqlCommand(updateQuery, conn);

            MySqlDataReader queryReader;

            try
            {
                conn.Open();

                queryReader = command.ExecuteReader();

                MessageBox.Show("Próg znów obowiązuje!");

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}

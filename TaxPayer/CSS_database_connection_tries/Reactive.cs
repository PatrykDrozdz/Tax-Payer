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

        private string connDetail = "datasource=localhost;port=3306;username=root;password=root;";
        private string selectQuery;
        private string insertQuery;
        private string updateQuery;
        private string value;
        private string guaranteedAmount;
        private string downPayment;
        private string maxPayment;
        private string contents;
        private string ids;
        private int flagFreePayment;
        MySqlConnection conn;
        MySqlCommand command;
        MySqlDataReader queryReader;

        void fillComboId()
        { 
            selectQuery = "SELECT * FROM taxpayer.taxes WHERE flagT=0;";

            conn = new MySqlConnection(connDetail);
            command = new MySqlCommand(selectQuery, conn);

            try
            {
                conn.Open();

                queryReader = command.ExecuteReader();

                while (queryReader.Read())
                {
                    ids = queryReader.GetString("idtaxes");
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
            
            insertQuery = "SELECT * FROM taxpayer.taxes WHERE flagT=0 AND idtaxes='" + idCombo.Text + "';";

            conn = new MySqlConnection(connDetail);
            command = new MySqlCommand(insertQuery, conn);

            try
            {
                conn.Open();

                queryReader = command.ExecuteReader();

                while (queryReader.Read())
                {
                    value = queryReader.GetString("value");
                    guaranteedAmount = queryReader.GetString("guaranteedAmount");
                    downPayment = queryReader.GetString("downPayment");
                    maxPayment = queryReader.GetString("maxPayment");
                    contents = queryReader.GetString("contents");
                    flagFreePayment = queryReader.GetInt32("flagFreePayment");

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

            updateQuery = "UPDATE taxpayer.taxes SET flagT='1' WHERE idtaxes='" + idCombo.Text + "' ;";

            conn = new MySqlConnection(connDetail);
            command = new MySqlCommand(updateQuery, conn);

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

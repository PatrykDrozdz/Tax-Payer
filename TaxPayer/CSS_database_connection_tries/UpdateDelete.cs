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
    public partial class UpdateDelete : Form
    {
        public UpdateDelete()
        {
            InitializeComponent();
            fillComboId();
        }

        private string connDetail = "datasource=localhost;port=3306;username=root;password=root;";
        private string value;
        private string guaranteedAmount;
        private string downPayment;
        private string maxPaymentValue;
        private string contents;
        private string selectQuery;
        private string deleteQuery;
        private string updateQuery;
        private string insertQuery;
        private int getFlagFreePayment;
        private int flagFreePayment = 1;
        MySqlConnection conn;
        MySqlCommand command;
        MySqlDataReader queryReader;


        void fillComboId()
        {
            
            selectQuery = "SELECT * FROM taxpayer.taxes WHERE flagT=1;";

            conn = new MySqlConnection(connDetail);
            command = new MySqlCommand(selectQuery, conn);

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


        private void deleteButton_Click(object sender, EventArgs e)
        {

            deleteQuery = "UPDATE taxpayer.taxes SET flagT='0' WHERE idtaxes='"+idCombo.Text+"' ;";

            conn = new MySqlConnection(connDetail);
            command = new MySqlCommand(deleteQuery, conn);

            try
            {
                conn.Open();

                queryReader = command.ExecuteReader();

                MessageBox.Show("Usunięto kwotę podatku!");
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void editButton_Click(object sender, EventArgs e)
        {

            if (this.unusedFreePayment.Checked)
            {
                this.flagFreePayment = 0;
            }

            updateQuery = "UPDATE taxpayer.taxes SET value='"+valueUpDown.Value+"', guaranteedAmount='"+this.guaranteedAmountUpDown.Value+"', downPayment='"+this.downPaymentUpDown.Value+"', maxPayment='"+maxPaymentUpDown.Value+"', flagFreePayment='"+this.flagFreePayment+"', contents='"+contentsText.Text+"' WHERE idtaxes='" + idCombo.Text + "' ;";

            conn = new MySqlConnection(connDetail);
            command = new MySqlCommand(updateQuery, conn);

            try
            {
                conn.Open();

                queryReader = command.ExecuteReader();

                MessageBox.Show("Edytowano kwotę podatku!");

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void idCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

            insertQuery = "SELECT * FROM taxpayer.taxes WHERE flagT=1 AND idtaxes='"+idCombo.Text+"';";

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
                    maxPaymentValue = queryReader.GetString("maxPayment");
                    contents = queryReader.GetString("contents");
                    getFlagFreePayment = queryReader.GetInt32("flagFreePayment");

                    labelForValue.Text = value;
                    labelForGuaranteedAmount.Text = guaranteedAmount;
                    labelForDownPayment.Text = downPayment;
                    labelForMaxPayment.Text = maxPaymentValue;
                    contentsTextLabel.Text = contents;

                    if (getFlagFreePayment == 0) {
                        this.labelForTaxFreePaymentInfo.Text = "nieobowiązuje";
                    } else if (getFlagFreePayment == 1)
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

        private void UpdateDelete_Load(object sender, EventArgs e)
        {

        }
    }
}

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

        void fillComboId() {

            string connDetail = "datasource=localhost;port=3306;username=root;password=root;";
            string selectQuery = "SELECT * FROM taxpayer.taxes WHERE flagT=1;";

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


        private void deleteButton_Click(object sender, EventArgs e)
        {
            string connDetail = "datasource=localhost;port=3306;username=root;password=root;";
            string deleteQuery = "UPDATE taxpayer.taxes SET flagT='0' WHERE idtaxes='"+idCombo.Text+"' ;";

            MySqlConnection conn = new MySqlConnection(connDetail);
            MySqlCommand command = new MySqlCommand(deleteQuery, conn);

            MySqlDataReader queryReader;

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

            string connDetail = "datasource=localhost;port=3306;username=root;password=root;";
            string updateQuery = "UPDATE taxpayer.taxes SET value='"+valueUpDown.Value+"', maxPayment='"+maxPaymentUpDown.Value+"', contents='"+contentsText.Text+"' WHERE idtaxes='" + idCombo.Text + "' ;";

            MySqlConnection conn = new MySqlConnection(connDetail);
            MySqlCommand command = new MySqlCommand(updateQuery, conn);

            MySqlDataReader queryReader;

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

            string connDetail = "datasource=localhost;port=3306;username=root;password=root;";
            string insertQuery = "SELECT * FROM taxpayer.taxes WHERE flagT=1 AND idtaxes='"+idCombo.Text+"';";

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

                    labelForValue.Text = value;
                    labelForGuaranteedAmount.Text = guaranteedAmount;
                    labelForDownPayment.Text = downPayment;
                    labelForMaxPayment.Text = maxPayment;
                    contentsTextLabel.Text = contents;

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

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
    public partial class Result : Form 
    {

        addingDatasToCount add;
        int countValues = 0;

        public Result(addingDatasToCount add)
        {
            InitializeComponent();
            this.add = add;
            counting();
        }

        void getTaxFreePayment()
        {

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

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        void counting()
        {

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
                    countValues++;
                }

                //this.ResultValueTab = new double[this.countValues];

               /* this.Values[0] = countValues;
                this.Values[1] = add.getIncomme();

                 taxValueCount.Text = this.Values[0].ToString();
                 taxValue.Text = this.Values[1].ToString();
                 */

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Result_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}

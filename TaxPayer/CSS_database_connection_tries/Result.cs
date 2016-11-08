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

        private string connDetail = "datasource=localhost;port=3306;username=root;password=root;";
        private string selectQuery;
        private int countValues = 0;
        private double[] ResultValueTab;
        addingDatasToCount add;
        MySqlConnection conn;
        MySqlCommand command;

        MySqlDataReader queryReader;

        public Result(addingDatasToCount add)
        {
            InitializeComponent();
            this.add = add;
            counting();
        }

        void getTaxFreePayment()
        {

            selectQuery = "SELECT * FROM taxpayer.freetaxvalue;";

            conn = new MySqlConnection(connDetail);
            command = new MySqlCommand(selectQuery, conn);

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

            selectQuery = "SELECT * FROM taxpayer.taxes WHERE flagT=1;";

            conn = new MySqlConnection(connDetail);
            command = new MySqlCommand(selectQuery, conn);

            try
            {
                conn.Open();

                queryReader = command.ExecuteReader();

                while (queryReader.Read())
                {    
                    countValues++;
                }

                this.ResultValueTab = new double[this.countValues];

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

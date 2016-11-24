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

        AddingDatasToCount add;
        Connection connect = new Connection();
        int countValues = 0;
        double freePay = 0.0;

        public Result(AddingDatasToCount add)
        {
            InitializeComponent();
            this.add = add;
            counting();
        }

        

        void getTaxFreePayment()
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
                    this.freePay = queryReader.GetDouble("freePay");
                }

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        void counting()
        {
            getTaxFreePayment();

            string selectQuery = "SELECT * FROM taxpayer.taxes WHERE flagT=1;";
			
			MySqlConnection conn = new MySqlConnection(connect.connDetail);
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

               //sprawdzanie
               //////////////////////////////////
                taxValue.Text = add.Incomme.ToString();
                taxValueCount.Text = add.OutcommeHealth.ToString();
                taxValueLabel.Text = add.OutcommeSocial.ToString();
                taxLabel.Text = this.freePay.ToString();
                ///////////////////////////////////////////////

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

       
    }
}

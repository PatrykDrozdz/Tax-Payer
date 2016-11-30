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

        private double[] resultTab;
        private double[] valueTab;
        private double[] guaranteedAmountTab;
        private double[] downPaymentTab;
        private double[] maxPaymentTab;
        private double[] flagFreePaymentTab;
        private double payment;
        private int i = 0;

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

                resultTab = new double[this.countValues];
                valueTab = new double[this.countValues];
                guaranteedAmountTab = new double[this.countValues];
                downPaymentTab = new double[this.countValues];
                maxPaymentTab = new double[this.countValues];
                flagFreePaymentTab = new double[this.countValues];

                this.payment = add.Incomme - add.OutcommeSocial - add.IncommeCosts;

                 
              
                while(queryReader.Read())
                {
                    this.valueTab[i] = queryReader.GetDouble("value");
                    this.guaranteedAmountTab[i] = queryReader.GetDouble("guaranteedAmount");
                    this.downPaymentTab[i] = queryReader.GetDouble("downPayment");
                    this.maxPaymentTab[i] = queryReader.GetDouble("maxPayment");
                    i = i + 1;
 
                }

                //sprawdzanie
                //////////////////////////////////

                //taxValue.Text = this.payment.ToString();
                //taxValue.Text = add.Incomme.ToString(); ///kwota podatkowa
                //taxValueCount.Text = add.OutcommeHealth.ToString(); ///ile do zapłacenia
                //taxValueLabel.Text = add.OutcommeSocial.ToString();
                //taxLabel.Text = this.freePay.ToString();
                ///////////////////////////////////////////////

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

       
    }
}

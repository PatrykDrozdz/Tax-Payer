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
        double[] results;
        List<double> values = new List<double>();
        List<double> guaranteedAmounts = new List<double>();
        List<double> downPayments = new List<double>();
        List<double> maxPayments = new List<double>();
        List<double> freeTaxValues = new List<double>();
        List<int> freeTaxFlags = new List<int>();
        double payment;

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
                    this.freeTaxValues.Add(queryReader.GetDouble("freePay"));
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

                    this.values.Add(queryReader.GetDouble("value"));
                    this.guaranteedAmounts.Add(queryReader.GetDouble("guaranteedAmount"));
                    this.downPayments.Add(queryReader.GetDouble("downPayment"));
                    this.maxPayments.Add(queryReader.GetDouble("maxPayment"));
                    this.freeTaxFlags.Add(queryReader.GetInt32("freetaxvalue_idfreetaxvalue"));

                }

                this.payment = add.Incomme - add.OutcommeSocial - add.IncommeCosts;

                this.results = new double[this.values.Count];

                for(int i=0; i<this.values.Count; i++)
                {

                    //this.freeTaxFlags[i];
                    this.results[i] = (this.guaranteedAmounts[i] + (this.payment - this.downPayments[i] - 3091
                        ) * this.values[i]) - add.OutcommeHealth;
                }

                this.taxValue.Text = results[0].ToString();
                //this.taxValueCount.Text = this.values[0].ToString();
                this.taxValueCount.Text = 3091.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

       
    }
}

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
        List<int> freeTaxFlags = new List<int>();
        double payment;
        double result;

        public Result(AddingDatasToCount add)
        {
            InitializeComponent();
            this.add = add;
            counting();
        }

        double getTaxFreePayment(int idfreetaxpay)
        {

			string selectQuery = "SELECT * FROM taxpayer.freetaxvalue WHERE idfreetaxvalue = '"+idfreetaxpay+"';";
            
			
			MySqlConnection conn = new MySqlConnection(connect.connDetail);
            MySqlCommand command = new MySqlCommand(selectQuery, conn);
			MySqlDataReader queryReader;

            try
            {
                conn.Open();

                queryReader = command.ExecuteReader();

                

                while (queryReader.Read())
                {
                    result = queryReader.GetDouble("freePay");
                }

                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return result;

        }


        void counting()
        {
            //getTaxFreePayment();

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

                int i = 0;
                while (i<this.values.Count)
                {
                    this.results[i] = (this.guaranteedAmounts[i] + (this.payment - this.downPayments[i] -
                        getTaxFreePayment(this.freeTaxFlags[i])) * this.values[i]) - add.OutcommeHealth;

                    if (/*maxPayments[i] != 0 &&*/ maxPayments[i] >= this.payment)
                    {
                        this.taxValueCount.Text = results[i].ToString();
                        this.taxValue.Text = this.values[i].ToString();
                    }
                    if (maxPayments[i] < this.payment /*&& maxPayments[i]!=0*/)
                    {
                        i++;
                    }

                    if(i== (this.values.Count - 1))
                    {
                        i = 0;
                    }
                    i++;
                }

                //this.taxValue.Text = results[1].ToString();
                //this.taxValueCount.Text = this.values[0].ToString();
                //this.taxValueCount.Text = getTaxFreePayment(3).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

       
    }
}

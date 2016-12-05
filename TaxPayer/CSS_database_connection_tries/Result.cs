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
        List<double> values = new List<double>();
        List<double> guaranteedAmounts = new List<double>();
        List<double> downPayments = new List<double>();
        List<double> maxPayments = new List<double>();
        List<int> freeTaxFlags = new List<int>();
        private double payment;
        private double result;
        private double prog;
        private double line;
        private double taxProg;
        private double taxLine;

        public Result(AddingDatasToCount add)
        {
            InitializeComponent();
            this.add = add;
            counting();
        }
		
		double changeToProcents(double taxValue){
			
			return (taxValue * 100);
			
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

                for(int i=0; i<this.values.Count; i++)
                {

                    if (maxPayments[i] >= this.payment && downPayments[i] < this.payment)
                    {//progresja - pośrednie podatki
                        prog = (this.guaranteedAmounts[i] + (this.payment - this.downPayments[i] -
                        getTaxFreePayment(this.freeTaxFlags[i])) * this.values[i]) - add.OutcommeHealth;
                        taxProg = changeToProcents(values[i]);

                    }
                    else if (maxPayments[i] == 0 && downPayments[i] == 0)
                    {//liniowy podatek
                        line = (this.guaranteedAmounts[i] + (this.payment - this.downPayments[i] -
                        getTaxFreePayment(this.freeTaxFlags[i])) * this.values[i]) - add.OutcommeHealth;
                        taxLine = changeToProcents(values[i]);
                    }
                    else if(maxPayments[i]==0 && downPayments[i] != 0 && payment>this.downPayments[i])
                    {//progresja - najwyższa stawka
                        prog = (this.guaranteedAmounts[i] + (this.payment - this.downPayments[i] -
                        getTaxFreePayment(this.freeTaxFlags[i])) * this.values[i]) - add.OutcommeHealth;
                        taxProg = changeToProcents(values[i]);
                    }

                    if (prog < 0)
                    {
                        prog = 0;
                    }

                    if (line < 0)
                    {
                        line = 0;
                    }

                }

                prog = Math.Round(prog);
                line = Math.Round(line);

                this.taxValueCount.Text = prog.ToString();
                this.taxValue.Text = (taxProg + "%").ToString();

                this.taxValueCountLine.Text = line.ToString();
                this.taxValueLine.Text = (taxLine + "%").ToString();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

       
    }
}

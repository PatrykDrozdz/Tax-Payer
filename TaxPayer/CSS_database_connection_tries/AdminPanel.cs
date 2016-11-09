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
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
            getFreeTaxPayment();
            getDatas();
        }


        
        void getFreeTaxPayment()
        {

            string connDetail = "datasource=localhost;port=3306;username=root;password=root;";
             string selectQuery = "SELECT * FROM taxpayer.freetaxvalue;";
        

  
            MySqlConnection conn = new MySqlConnection(connDetail);
            MySqlCommand command = new MySqlCommand(selectQuery, conn);
            MySqlDataReader queryReader;

            try
            {
                conn.Open();

                queryReader = command.ExecuteReader();


                while (queryReader.Read())
                {

                    string freePayTax = queryReader.GetString("freePay");

                    freePayShow.Text = freePayTax;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        void getDatas()
        {

			string connDetail = "datasource=localhost;port=3306;username=root;password=root;";
			string selectQuery = "SELECT * FROM taxpayer.taxes;";

  
             MySqlConnection conn = new MySqlConnection(connDetail);
             MySqlCommand command = new MySqlCommand(selectQuery, conn);

            try
            {
                MySqlDataAdapter adaptData = new MySqlDataAdapter();
                DataTable dbDatas = new DataTable();
                BindingSource bSource = new BindingSource();

                adaptData.SelectCommand = command;
                adaptData.Fill(dbDatas);

                bSource.DataSource = dbDatas;
                showAllDatas.DataSource = bSource;
                adaptData.Update(dbDatas);

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }

        }

        private void addOpen_Click(object sender, EventArgs e)
        {
			Add adDel = new Add();
            adDel.ShowDialog();
        }

        private void logOut_Click(object sender, EventArgs e)
        {
             MessageBox.Show("wylogowany!");
             this.Hide();
             logIn main = new logIn();
 
             main.Show();
        }

        private void addDeleteOpen_Click(object sender, EventArgs e)
        {
			UpdateDelete updel = new UpdateDelete();
            updel.ShowDialog();
        }

        private void taxFreeOpen_Click(object sender, EventArgs e)
        {
			 TaxFreePayEdit tfpe = new TaxFreePayEdit();
            tfpe.ShowDialog();
        }

        private void wylogujSięToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("wylogowany!");
			logIn main = new logIn();
            this.Hide();
            main.Show();
        }

        private void zamknijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dodajStawkęToolStripMenuItem_Click(object sender, EventArgs e)
        {
			Add adDel = new Add();
            adDel.ShowDialog();
        }

        private void kwoteWolnaToolStripMenuItem_Click(object sender, EventArgs e)
        {
			TaxFreePayEdit tfpe = new TaxFreePayEdit();
            tfpe.ShowDialog();
        }

        private void stawkęPodatkuToolStripMenuItem_Click(object sender, EventArgs e)
        {
			UpdateDelete updel = new UpdateDelete();
            updel.ShowDialog();
        }

        private void odświeżToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.getDatas();
            this.getFreeTaxPayment();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            this.getDatas();
            this.getFreeTaxPayment();
        }

        private void Reactive_Click(object sender, EventArgs e)
        {
			Reactive reac = new Reactive();
            reac.ShowDialog();
        }

        private void akktywujPrógToolStripMenuItem_Click(object sender, EventArgs e)
        {
			Reactive reac = new Reactive();
            reac.ShowDialog();
        }

        private void AdminPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void addAdmin_button_Click(object sender, EventArgs e)
        {
			addAdmin addAdmin = new addAdmin();
            addAdmin.ShowDialog();
        }

        private void dodajAdministratoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
			addAdmin addAdmin = new addAdmin();
            addAdmin.ShowDialog();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

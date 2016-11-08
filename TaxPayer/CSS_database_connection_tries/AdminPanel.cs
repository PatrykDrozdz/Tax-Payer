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

        private string connDetail = "datasource=localhost;port=3306;username=root;password=root;";
        private string selectQuery;
        private string freePayTax;

        addAdmin addAdmin = new addAdmin();
        Reactive reac = new Reactive();
        UpdateDelete updel = new UpdateDelete();
        TaxFreePayEdit tfpe = new TaxFreePayEdit();
        Add adDel = new Add();
        logIn main = new logIn();
        MySqlConnection conn;
        MySqlCommand command;
        MySqlDataReader queryReader;
        BindingSource bSource = new BindingSource();
        MySqlDataAdapter adaptData = new MySqlDataAdapter();
        DataTable dbDatas = new DataTable();
        
        void getFreeTaxPayment()
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

                    freePayTax = queryReader.GetString("freePay");

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

            selectQuery = "SELECT * FROM taxpayer.taxes;";

            conn = new MySqlConnection(connDetail);
            command = new MySqlCommand(selectQuery, conn);

            try
            {

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
            adDel.ShowDialog();
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            MessageBox.Show("wylogowany!");
            this.Hide();
            main.Show();
        }

        private void addDeleteOpen_Click(object sender, EventArgs e)
        {
            updel.ShowDialog();
        }

        private void taxFreeOpen_Click(object sender, EventArgs e)
        {
            tfpe.ShowDialog();
        }

        private void wylogujSięToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("wylogowany!");
            this.Hide();
            main.Show();
        }

        private void zamknijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dodajStawkęToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adDel.ShowDialog();
        }

        private void kwoteWolnaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tfpe.ShowDialog();
        }

        private void stawkęPodatkuToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
            reac.ShowDialog();
        }

        private void akktywujPrógToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reac.ShowDialog();
        }

        private void AdminPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void addAdmin_button_Click(object sender, EventArgs e)
        {
            addAdmin.ShowDialog();
        }

        private void dodajAdministratoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addAdmin.ShowDialog();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

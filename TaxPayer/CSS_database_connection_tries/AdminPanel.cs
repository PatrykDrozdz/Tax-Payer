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
        LogIn li;
        Connection connect = new Connection();
        private string login;

        public AdminPanel(LogIn li)
        {
            InitializeComponent();
            this.li = li;
            getFreeTaxPayment();
            getDatas();
            this.Login = li.Login;
        }
        
        public string Login
        {
            set
            {
                this.login = value;
            }

            get
            {
                return this.login;
            }

        }



        void getFreeTaxPayment()
        {

            
            string selectQuery = "SELECT * FROM taxpayer.freetaxvalue;";

           // this.info_label.Text = li.Login.ToString();

            MySqlConnection conn = new MySqlConnection(connect.connDetail);
            MySqlCommand command = new MySqlCommand(selectQuery, conn);

            try
            {

                MySqlDataAdapter adaptData = new MySqlDataAdapter();
                DataTable dbDatas = new DataTable();
                BindingSource bSource = new BindingSource();

                adaptData.SelectCommand = command;
                adaptData.Fill(dbDatas);

                bSource.DataSource = dbDatas;
                freePaysShow.DataSource = bSource;
                adaptData.Update(dbDatas);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        void getDatas()
        {

	
			string selectQuery = "SELECT * FROM taxpayer.taxes;";

  
             MySqlConnection conn = new MySqlConnection(connect.connDetail);
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
             LogIn main = new LogIn();
 
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

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("wylogowany!");
			LogIn main = new LogIn();
            this.Hide();
            main.Show();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void freeValueToolStripMenuItem_Click(object sender, EventArgs e)
        {
			TaxFreePayEdit tfpe = new TaxFreePayEdit();
            tfpe.ShowDialog();
        }

        private void taxValueToolStripMenuItem_Click(object sender, EventArgs e)
        {
			UpdateDelete updel = new UpdateDelete();
            updel.ShowDialog();
        }

        private void refreashToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void reactiveToolStripMenuItem_Click(object sender, EventArgs e)
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
			AddAdmin addAdmin = new AddAdmin();
            addAdmin.ShowDialog();
        }

        private void addAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
			AddAdmin addAdmin = new AddAdmin();
            addAdmin.ShowDialog();
        }

        private void addTaxValueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add adDel = new Add();
            adDel.ShowDialog();
        }

        private void freePatValueAddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddFreeTaxValue addFree = new AddFreeTaxValue();
            addFree.ShowDialog();
        }

        private void editAdminAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateAccount ua = new UpdateAccount(this);
            ua.Owner = this;
            ua.ShowDialog();
        }
    }
}

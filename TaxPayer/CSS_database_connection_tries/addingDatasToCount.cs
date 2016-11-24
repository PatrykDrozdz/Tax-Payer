using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSS_database_connection_tries
{
    public partial class AddingDatasToCount : Form
    {

        public AddingDatasToCount()
        {
            InitializeComponent();
            
        }

        private double incomme;
        private double outcommeHealth;
        private double outcommeSocial;

        public double Incomme {

            get
            {
                return this.incomme;
            }

            set
            {
                this.incomme = value;
            }

        }

        public double OutcommeHealth {

            get
            {
                return this.outcommeHealth;
            }

            set
            {
                this.outcommeHealth = value;
            }
        }

        public double OutcommeSocial
        {

            get
            {
                return this.outcommeSocial;
            }

            set
            {
                this.outcommeSocial = value;
            }

        }
        

        private void LogInToolStripMenuItem_Click(object sender, EventArgs e)
        {
			LogIn logIn = new LogIn();
            this.Hide();
            logIn.Show();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openChecking_Click(object sender, EventArgs e)
        {
            //this.Incomme((double)this.incommeUpDown.Value);

            this.Incomme = (double)this.incommeUpDown.Value;

            this.OutcommeSocial = (double)this.outcommeSocialUpDown.Value;

            this.OutcommeHealth = (double)this.outcommeHealthUpDown.Value;

            Result r = new Result(this);
            r.Owner = this;

            r.ShowDialog();
        }

        private void addingDatasToCount_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

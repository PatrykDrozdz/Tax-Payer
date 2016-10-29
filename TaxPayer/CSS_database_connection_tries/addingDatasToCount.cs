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
    public partial class addingDatasToCount : Form
    {

        public addingDatasToCount()
        {
            InitializeComponent();
            

        }

        private double incomme;
        private double outcommeHealth;
        private double outcommeSocial;

        private void setIncomme(double value)
        {
            this.incomme = value;
        }

        private void setOutcommeHealth(double value)
        {
            this.outcommeHealth = value;
        }

        private void setOutcommeSocial(double value)
        {
            this.outcommeSocial = value;
        }

        public double getIncomme()
        {
            return this.incomme;
        }

        public double getOutcommeHealth()
        {
            return this.outcommeHealth;
        }

        public double getOutcommeSocial()
        {
            return this.outcommeSocial;
        }

        private void zalogujSięToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            logIn logIn = new logIn();
            logIn.Show();
        }

        private void zamknijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pomocToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openChecking_Click(object sender, EventArgs e)
        {
            this.setIncomme((double)this.incommeUpDown.Value);

            this.setOutcommeSocial((double)this.outcommeSocialUpDown.Value);

            this.setOutcommeHealth((double)this.outcommeHealthUpDown.Value);

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

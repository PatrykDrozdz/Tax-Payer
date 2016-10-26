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
        private double outcomme;

        private void setIncomme(double value)
        {
            this.incomme = value;
        }

        private void setOutcomme(double value)
        {
            this.outcomme = value;
        }

        public double getIncomme()
        {
            return this.incomme;
        }

        public double getOutcomme()
        {
            return this.outcomme;
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

            this.setOutcomme((double)this.outcommeSocialUpDown.Value);


            Result r = new Result(this);
            r.Owner = this;

            r.ShowDialog();
        }
    }
}

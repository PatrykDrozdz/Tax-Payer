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
        addingDatasToCount add;
        int count = 0;

        public Result(addingDatasToCount add)
        {
            InitializeComponent();
            this.add = add;
            counting();
        }

        void counting()
        {

            //label1.Text = add.getIncomme().ToString();
            //label2.Text = add.getOutcomme().ToString();

            string connDetail = "datasource=localhost;port=3306;username=root;password=root;";
            string selectQuery = "SELECT * FROM taxpayer.taxes WHERE flagT=1;";

            MySqlConnection conn = new MySqlConnection(connDetail);
            MySqlCommand command = new MySqlCommand(selectQuery, conn);

            MySqlDataReader queryReader;

            try
            {
                conn.Open();

                queryReader = command.ExecuteReader();

                while (queryReader.Read())
                {
                    string ids = queryReader.GetString("idtaxes");
                    //idCombo.Items.Add(ids);
                    label1.Text = ids;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
    }
}

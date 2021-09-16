using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using PervasiveImporter__32_bit_;
using Npgsql;

namespace CWA_Assessment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*https://www.youtube.com/watch?v=OoIk4ahkDmo */
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This will close down the whole application. Confirm?", "Close Application", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("The application has been closed successfully.", "Application Closed!", MessageBoxButtons.OK);
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                this.Activate();
            }
        }

        private void trailBTN_Click(object sender, EventArgs e)
        {
            //32 bit is used to create access to the  PervasiveImporter__32_bit_

            PSQLImport32 PSQL32 = new PSQLImport32();

            //string dataLoc = "C:\\Development\\Accounting\\Pastel 8\\Accounting\\Source\\_Demo\\Documents\\Labels\\CustomerSupplier";
            string dataLoc = "C:\\Development\\Accounting\\Pastel 8\\Accounting\\Source\\_Demo";
            string server = "Server = \"\"";
            string query1 = "SELECT * FROM";
            string query2 = "SELECT * FROM C:\\Development\\Accounting\\Pastel 8\\Accounting\\Source\\_Demo\\Documents\\Labels\\CustomerSupplier\\Fields.pmd";

            try
            {
                object result = PSQL32.sync_ImportSQL(dataLoc, server, query2);
                
                if (result.ToString().Length > 0)
                {
                    /*TextWriter writer = new StreamWriter(@"C:\folder\Text.txt");

                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {
                        for (int j = 0; j < dataGridView1.Columns.Count; j++)
                        {
                            writer.Write("\t" + dataGridView1.Rows[i].Cells[j].Value.ToString() + "\t" + "|");
                        }
                        writer.WriteLine("");
                    }
                    writer.Close();
                    MessageBox.Show("Data Exported");*/
                }
            }
            catch (Exception ex)
            {
                string error = ex.Message;
            }


            /**
             * Within this variable you can access Patel data in to forms
             * Quering a table or running a SQL qury against multiple tables
             * example of doing the connection :
             * PSQL32.sync_ImportSQL(Path to the Pastel data , Server this must stay as : 'Server = ""', Table name or SQL query)
             */

        }

        private void TransactionsBTN_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void TransactionsBTN_MouseHover(object sender, EventArgs e)
        {
            TransactionsBTN.BorderStyle = BorderStyle.Fixed3D;
        }

        private void TransactionsBTN_MouseLeave(object sender, EventArgs e)
        {
            TransactionsBTN.BorderStyle = BorderStyle.None;
        }

        private void trailBTN_MouseHover(object sender, EventArgs e)
        {
            trailBTN.BorderStyle = BorderStyle.Fixed3D;
        }

        private void trailBTN_MouseLeave(object sender, EventArgs e)
        {
            trailBTN.BorderStyle = BorderStyle.None;
        }

        private void closeBTN_MouseHover(object sender, EventArgs e)
        {
            closeBTN.BorderStyle = BorderStyle.FixedSingle;
            closeBTN.BackColor = Color.Aqua;
        }

        private void closeBTN_MouseLeave(object sender, EventArgs e)
        {
            closeBTN.BorderStyle = BorderStyle.None;
            closeBTN.BackColor = Color.White;
        }

        private void logo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This will open AdaptIT site down. Confirm?", "Close Application", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("https://www.adaptit.com/");
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                this.Activate();
            }
        }
    }
}

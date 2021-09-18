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

        static private string connectionString = "Data Source=DESKTOP-HERS5E5\\SQLEXPRESS; Initial Catalog = BigData; Integrated Security=True";

        DataTable dataTable = new DataTable();

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
            StringBuilder txt = new StringBuilder("");

            //32 bit is used to create access to the  PervasiveImporter__32_bit_
            PSQLImport32 PSQL32 = new PSQLImport32();

            string dataLoc = @"C:\Development\Accounting\Pastel 8\Accounting\Source\_Demo";
            string server = @"Server = """;
            string selectQuery = @"SELECT * FROM C:\Development\Accounting\Pastel 8\Accounting\Source\_Demo\Documents\Labels\CustomerSupplier\Fields.pmd";
            string pastelDataPath = @"C:\Users\mdladla\source\repos\CWA-Data-Assessment\PastelData\mike2009";
            string trialBalanceQuery = " WHERE YEAR() BETWEEN YEAR(GETDATE()) - 1 AND GETDATE()";

            try
            {      
                DataTable connection = PSQL32.sync_ImportSQL(pastelDataPath, server, selectQuery + trialBalanceQuery);

                dataGridView.DataSource = connection;

                dataTable = connection;

                if (connection.ToString().Length > 0)
                {
                    //Adding Table ColumnName to text file delimited by |
                    foreach (DataColumn column in dataTable.Columns)
                    {
                        txt.Append(column.ColumnName + "|");
                    }

                    if (txt.Length > 0)
                    {
                        txt.Remove(txt.Length - 1, 1);
                        txt.Append("\n");

                        //Adding Row values to text file delimited by |
                        for (int i = 0; i < dataGridView.Rows.Count - 1; i++)
                        {
                            for (int j = 0; j < dataGridView.Columns.Count; j++)
                            {
                                txt.Append(dataGridView.Rows[i].Cells[j].Value.ToString() + "|");
                            }
                            txt.Remove(txt.Length - 1, 1);
                            txt.Append("\n");
                        }

                        try
                        {
                            string fileName = @"..\..\Trial Balance.txt";
                            if (File.Exists(fileName))
                            {
                                File.Delete(fileName);
                            }

                            using (FileStream fs = File.Create(fileName))
                            {
                                // Add some text to file    
                                Byte[] title = new UTF8Encoding(true).GetBytes(txt.ToString());
                                fs.Write(title, 0, title.Length);
                                MessageBox.Show("Data Exported");
                            }
                        }
                        catch (Exception Ex)
                        {
                            Console.WriteLine(Ex.ToString());
                            Console.ReadLine();
                        }
                    }
                    else
                    {
                        MessageBox.Show(@"Press 'Trial Balance' to generate DATA", "NO DATA",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void TransactionsBTN_Click(object sender, EventArgs e)
        {
            StringBuilder txt = new StringBuilder("");
            //Adding Table ColumnName to text file delimited by |
            foreach (DataColumn column in dataTable.Columns)
            {
                txt.Append(column.ColumnName + "|");
            }

            if (txt.Length > 0)
            {
                txt.Remove(txt.Length - 1, 1);
                txt.Append("\n");

                //Adding Row values to text file delimited by |
                for (int i = 0; i < dataGridView.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dataGridView.Columns.Count; j++)
                    {
                        txt.Append(dataGridView.Rows[i].Cells[j].Value.ToString() + "|");
                    }
                    txt.Remove(txt.Length - 1, 1);
                    txt.Append("\n");
                }

                try
                {
                    string fileName = @"..\..\Transactions.txt";
                    //string fileName = @"..\..\Transactions.txt";
                    if (File.Exists(fileName))
                    {
                        File.Delete(fileName);
                    }

                    using (FileStream fs = File.Create(fileName))
                    {
                        // Add some text to file    
                        Byte[] title = new UTF8Encoding(true).GetBytes(txt.ToString());
                        fs.Write(title, 0, title.Length);
                        MessageBox.Show("Data Exported");
                    }
                }
                catch (Exception Ex)
                {
                    Console.WriteLine(Ex.ToString());
                    Console.ReadLine();
                }
            }
            else
            {
                MessageBox.Show(@"Press 'Trial Balance' to generate DATA", "NO DATA",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

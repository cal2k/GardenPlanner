using System;
using System.Windows.Forms;
using System.Data.SQLite;

namespace GardenPlanner.Edit
{
    public partial class EditVeg : Form
    {
        SqL SQL = new SqL();
        string query, temp;
        string[] split = new string[2];

        public EditVeg()
        {
            InitializeComponent();
        }

        public void populateReadonly(string t)
        {
            this.Text = t;
            temp = t;
            split = t.Split('(', ')');
            try
            {
                using (SQL.conn)
                {
                    SQL.conn.Open();
                    query = "Select Name, Species, Sowing, Growing, Harvest, CommonProblems from Vegs where Species = '" + split[1] + "'";
                    SQL.cmd = new SQLiteCommand(query, SQL.conn);

                    using (SQL.cmd)
                    {
                        using (SQL.reader = SQL.cmd.ExecuteReader())
                        {
                            while (SQL.reader.Read())
                            {
                                tbName.Text = SQL.reader.GetString(0);
                                tbSpecies.Text = SQL.reader.GetString(1);
                                tbSowingNote.Text = SQL.reader.GetString(2);
                                tbGrowingNote.Text = SQL.reader.GetString(3);
                                tbHarvestNote.Text = SQL.reader.GetString(4);
                                tbCommonProblems.Text = SQL.reader.GetString(5);
                            }
                        }
                    }

                    query = "Select SowStart, SowEnd, HarvestStart, HarvestEnd from Vegs Where Species = '" + split[1] + "'";
                    SQL.cmd = new SQLiteCommand(query, SQL.conn);


                    using (SQL.cmd)
                    {
                        using (SQL.reader = SQL.cmd.ExecuteReader())
                        {
                            while (SQL.reader.Read())
                            {
                                tbSowStart.Text = SQL.reader.GetInt32(0).ToString();
                                tbSowEnd.Text = SQL.reader.GetInt32(1).ToString();
                                tbHarvestStart.Text = SQL.reader.GetInt32(2).ToString();
                                tbHarvestEnd.Text = SQL.reader.GetInt32(3).ToString();
                            }
                        }
                    }
                    SQL.conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            btnSave.Hide();
            tbName.ReadOnly = true;
            tbSpecies.ReadOnly = true;
            tbSowStart.ReadOnly = true;
            tbSowEnd.ReadOnly = true;
            tbSowingNote.ReadOnly = true;
            tbHarvestStart.ReadOnly = true;
            tbHarvestEnd.ReadOnly = true;
            tbHarvestNote.ReadOnly = true;
            tbGrowingNote.ReadOnly = true;
            tbCommonProblems.ReadOnly = true;


            tbSowingNote.BackColor = System.Drawing.Color.Empty;
            tbHarvestNote.BackColor = System.Drawing.Color.Empty;
            tbGrowingNote.BackColor = System.Drawing.Color.Empty;
            tbCommonProblems.BackColor = System.Drawing.Color.Empty;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            query = "update Vegs set Name = '" + tbName.Text + "', Species = '" + tbSpecies.Text + "', SowStart = '" + tbSowStart.Text +
                "', SowEnd = '" + tbSowEnd.Text + "', Sowing = '" + tbSowingNote.Text + "', Growing = '" + tbGrowingNote.Text +
                "', HarvestStart = '" + tbHarvestStart.Text + "', HarvestEnd = '" + tbHarvestEnd.Text + "', Harvest = '" + tbHarvestNote.Text + 
                "', CommonProblems = '" + tbCommonProblems.Text + "'  Where Species = '" + split[1] + "'";
            SQL.cmd = new SQLiteCommand(query, SQL.conn);

            try
            {
                using (SQL.conn)
                {
                    SQL.conn.Open();
                    using (SQL.cmd)
                    {
                        SQL.cmd.ExecuteNonQuery();
                    }
                        SQL.conn.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            tbName.Text = "";
            tbSpecies.Text = "";
            tbSowStart.Text = "";
            tbSowEnd.Text = "";
            tbSowingNote.Text = "";
            tbHarvestStart.Text = "";
            tbHarvestEnd.Text = "";
            tbHarvestNote.Text = "";
            tbGrowingNote.Text = "";
            tbCommonProblems.Text = "";
            btnEdit.Show();

            populateReadonly(temp);

        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnSave.Show();
            btnEdit.Hide();

            tbName.ReadOnly = false;
            tbSpecies.ReadOnly = false;
            tbSowStart.ReadOnly = false;
            tbSowEnd.ReadOnly = false;
            tbSowingNote.ReadOnly = false;
            tbSowingNote.BackColor = System.Drawing.Color.White;
            tbHarvestStart.ReadOnly = false;
            tbHarvestEnd.ReadOnly = false;
            tbHarvestNote.ReadOnly = false;
            tbHarvestNote.BackColor = System.Drawing.Color.White;
            tbGrowingNote.ReadOnly = false;
            tbGrowingNote.BackColor = System.Drawing.Color.White;
            tbCommonProblems.ReadOnly = false;
            tbCommonProblems.BackColor = System.Drawing.Color.White;
        }
    }
}

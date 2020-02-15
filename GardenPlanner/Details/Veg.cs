using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace GardenPlanner.Details
{
    public partial class Veg : Form
    {
        SqL SQL = new SqL();
        string temp, query, currentVeg, name, species;
        string[] split = new string[2];
        int count, userid, currentVegID ;

        public Veg()
        {
            InitializeComponent();
        }

        public void New(int i)
        {
            userid = i;
        }
        private void replaceIN()
        {
            if (temp.Contains("'"))
            {
                temp = temp.Replace("'", "*A*");
            }
        }
        private void replaceOUT()
        {
            if (temp.Contains("*A*"))
            {
                temp = temp.Replace("*A*", "'");
            }
        }
        public void View(int i,string t)
        {
            cbVegName.Hide();
            cbVegSpecies.Hide();
            btnAddSelectedVeg.Hide();
            userid = i;
            currentVeg = t;
            
            try
            {
                using (SQL.conn)
                {
                    SQL.conn.Open();
                    query = "Select Name, Species, Sowing, Growing, Harvest, CommonProblems from Vegs where Species = '" + currentVeg + "'";
                    SQL.cmd = new SQLiteCommand(query, SQL.conn);

                    using (SQL.cmd)
                    {
                        using (SQL.reader = SQL.cmd.ExecuteReader())
                        {
                            while (SQL.reader.Read())
                            {
                                temp = SQL.reader.GetString(0);
                                replaceOUT();
                                tbName.Text = temp;

                                temp = SQL.reader.GetString(1);
                                replaceOUT();
                                tbSpecies.Text = temp;

                                temp = SQL.reader.GetString(2);
                                replaceOUT();
                                tbSowingNote.Text = temp;

                                temp = SQL.reader.GetString(3);
                                replaceOUT();
                                tbGrowingNote.Text = temp;

                                temp = SQL.reader.GetString(4);
                                replaceOUT();
                                tbHarvestNote.Text = temp;
                                
                                temp = SQL.reader.GetString(5);
                                replaceOUT();
                                tbCommonProblems.Text = temp;

                            }
                        }
                    }

                    query = "Select SowStart, SowEnd, HarvestStart, HarvestEnd from Vegs Where Species = '" + currentVeg + "'";
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

        public void select(int i)
        {
            userid = i;
            tbName.Hide();
            lblname.Hide();
            tbSpecies.Hide();
            lblSpecies.Hide();
            tbSowStart.Hide();
            lblSowingStart.Hide();
            tbSowEnd.Hide();
            lblSowingEnd.Hide();
            tbSowingNote.Hide();
            lblSowingNote.Hide();
            tbHarvestStart.Hide();
            lblHarvestStart.Hide();
            tbHarvestEnd.Hide();
            lblHarvestEnd.Hide();
            tbHarvestNote.Hide();
            lblHarvestNote.Hide();
            tbGrowingNote.Hide();
            lblGrowingNote.Hide();
            tbCommonProblems.Hide();
            lblCommonProblems.Hide();

            query = "Select distinct  (Name) FROM Vegs order by name asc";
            SQL.cmd = new SQLiteCommand(query, SQL.conn);
            try
            {
                using (SQL.conn)
                {
                    SQL.conn.Open();
                    using (SQL.cmd)
                    {
                        using (SQL.reader = SQL.cmd.ExecuteReader())
                        {
                            while (SQL.reader.Read())
                            {
                                temp = SQL.reader.GetString(0);
                                replaceOUT();
                                cbVegName.Items.Add(temp);
                            }

                        }
                        SQL.conn.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cbVegName_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbVegSpecies.Items.Clear();
            temp = cbVegName.SelectedItem.ToString();
            replaceIN();
            name = temp;
            query = "Select Species FROM Vegs Where Name = '" + name + "'";
            SQL.cmd = new SQLiteCommand(query, SQL.conn);
            try
            {
                using (SQL.conn)
                {
                    SQL.conn.Open();
                    using (SQL.cmd)
                    {
                        using (SQL.reader = SQL.cmd.ExecuteReader())
                        {
                            while (SQL.reader.Read())
                            {
                                temp = SQL.reader.GetString(0);
                                replaceOUT();
                                cbVegSpecies.Items.Add(temp);
                                cbVegSpecies.Enabled = true;
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
        }

        private void cbVegSpecies_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAddSelectedVeg.Enabled = true;
        }

        private void btnAddSelectedVeg_Click(object sender, EventArgs e)
        {
            temp = cbVegSpecies.SelectedItem.ToString();
            replaceIN();
            query = "select id from Vegs where Species = '" + species + "'";
            SQL.cmd = new SQLiteCommand(query, SQL.conn);
            try
            {
                using (SQL.conn)
                {
                    SQL.conn.Open();
                    using (SQL.cmd)
                    {
                        using (SQL.reader = SQL.cmd.ExecuteReader())
                        {
                            while (SQL.reader.Read())
                            {
                                currentVegID = SQL.reader.GetInt32(0);
                            }
                        }
                    }

                    query = "SELECT COUNT (vegid) from SelectedVeg WHERE vegid = '" + currentVegID.ToString() + "'";
                    SQL.cmd = new SQLiteCommand(query, SQL.conn);

                    using (SQL.cmd)
                    {
                        using (SQL.reader = SQL.cmd.ExecuteReader())
                        {
                            while (SQL.reader.Read())
                            {
                                count = SQL.reader.GetInt32(0);
                            }
                        }

                    }
                    if (count == 0)
                    {
                        query = "INSERT INTO SelectedVeg (userid, vegid) VALUES ('" + userid + "', '" + currentVegID + "')";
                        SQL.cmd = new SQLiteCommand(query, SQL.conn);

                        using (SQL.cmd)
                        {
                            SQL.cmd.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        MessageBox.Show(temp + " has already been added to your list. Please select somthing differnt.");
                    }

                    SQL.conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            cbVegName.Items.Clear();
            cbVegName.Text = "Choose vegetables";
            cbVegSpecies.Items.Clear();
            cbVegSpecies.SelectedIndex = -1;
            cbVegSpecies.Enabled = false;

            select(userid);

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

        

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = tbName.Text, species = tbSpecies.Text, sowing = tbSowingNote.Text, growing = tbGrowingNote.Text, harvest = tbHarvestNote.Text, common = tbCommonProblems.Text;

            temp = name;
            replaceIN();
            name = temp;

            temp = species;
            replaceIN();
            species = temp;

            temp = sowing;
            replaceIN();
            sowing = temp;

            temp = growing;
            replaceIN();
            growing = temp;

            temp = harvest;
            replaceIN();
            harvest = temp;

            temp = common;
            replaceIN();
            common = temp;


            query = "update Vegs set Name = '" + name + "', Species = '" + species + "', SowStart = '" + tbSowStart.Text +
                "', SowEnd = '" + tbSowEnd.Text + "', Sowing = '" + sowing + "', Growing = '" + growing +
                "', HarvestStart = '" + tbHarvestStart.Text + "', HarvestEnd = '" + tbHarvestEnd.Text + "', Harvest = '" + harvest +
                "', CommonProblems = '" + common + "'  Where Species = '" + temp + "'";
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
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }

            this.Close();
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

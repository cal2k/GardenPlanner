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

namespace GardenPlanner.New_Entirys
{
    public partial class NewSelectedVeg : Form
    {
        string query, temp;
        int userid, count, currentVegID;

        static string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            pathComplete = path + @"\CGP\GardenDB.db";

        SQLiteConnection conn = new SQLiteConnection("Data Source =" + pathComplete + "; version =3;");
        SQLiteCommand cmd;
        SQLiteDataReader reader;
        DateTime date;

        private void cbVegSpecies_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAddSelectedVeg.Enabled = true;
        }

        public NewSelectedVeg()
        {
            InitializeComponent();
        }
        
        public void setUserID(int i)
        {
            userid = i;

            query = "Select distinct  (Name) FROM Vegs order by name asc";
            cmd = new SQLiteCommand(query, conn);
            try
            {
                using (conn)
                {
                    conn.Open();
                    using (cmd)
                    {
                        using (reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                temp = reader.GetString(0);
                                cbVegName.Items.Add(temp);
                            }
                        }
                    }
                    conn.Close();
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
            cbVegSpecies.Text = "Select Species";

            query = "Select Species FROM Vegs Where Name = '" + cbVegName.SelectedItem.ToString() + "'";
            cmd = new SQLiteCommand(query, conn);
            try
            {
                using (conn)
                {
                    conn.Open();
                    using (cmd)
                    {
                        using (reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                temp = reader.GetString(0);
                                cbVegSpecies.Items.Add(temp);
                                cbVegSpecies.Enabled = true;
                            }
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void btnAddSelectedVeg_Click(object sender, EventArgs e)
        {
            date = DateTime.Now;

            query = "select id from Vegs where Species = '" + cbVegSpecies.SelectedItem.ToString() + "'";
            cmd = new SQLiteCommand(query, conn);
            try
            {
                using (conn)
                {
                    conn.Open();
                    using (cmd)
                    {
                        using (reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                currentVegID = reader.GetInt32(0);
                            }
                        }
                    }

                    query = "SELECT COUNT (vegid) from SelectedVeg WHERE vegid = '" + currentVegID.ToString() + "'";
                    cmd = new SQLiteCommand(query, conn);

                    using (cmd)
                    {
                        using (reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                count = reader.GetInt32(0);
                            }
                        }

                    }
                    if (count == 0)
                    {
                        query = "INSERT INTO SelectedVeg (userid, vegid) VALUES ('" + userid + "', '" + currentVegID + "')";
                        cmd = new SQLiteCommand(query, conn);

                        using (cmd)
                        {
                            cmd.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        MessageBox.Show(temp + " has already been added to your list. Please select somthing differnt.");
                    }

                    conn.Close();
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

            setUserID(userid);

        }


    }
}

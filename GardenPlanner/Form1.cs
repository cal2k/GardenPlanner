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

namespace GardenPlanner
{
    public partial class Form1 : Form
    {
        private string UserNameCollection, userName, query, temp, journalTitle,
            journalDetails, journalEntiry, noteTitle, noteDetails, noteEntiry, jobTitle, jobDetails, jobEntiry, SelectedVegName, SelectedVegSpecies;
        string[] UserNameSplit = new string[2];
        int count = 0;
        DateTime date;

        SQLiteConnection conn = new SQLiteConnection("Data Source = GardenDB.db; version =3;");
        SQLiteCommand cmd;
        SQLiteDataReader reader;

        

        public Form1()
        {
            InitializeComponent();
            GatherUserName();
        }

        private void GatherUserName()
        {
            UserNameCollection = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            UserNameSplit = UserNameCollection.Split('\\');
            userName = UserNameSplit[1].ToLower();
            CheckUserTable();
        }

        private void CheckUserTable()
        {
            query = "CREATE TABLE IF NOT EXISTS '" + userName + "' (ID INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE, Journal TEXT, Jobs TEXT, Selected TEXT, Notes TEXT, Date TEXT, Tag TEXT)";
            using (conn)
            {
                conn.Open();
                cmd = new SQLiteCommand(query, conn);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

            LoadUserData();
        }

        private void LoadUserData()
        {
            lblUserName.Text = "Welcome, " + userName;

            query = "Select Journal FROM '" + userName + "' WHERE Journal IS NOT NULL ORDER BY ID DESC";

            cmd = new SQLiteCommand(query, conn);


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
                            listBoxJournal.Items.Add(temp);
                        }
                    }
                }
                conn.Close();
            }

            //Notes
            query = "Select Notes FROM '" + userName + "' WHERE Notes IS NOT NULL ORDER BY ID DESC";

            cmd = new SQLiteCommand(query, conn);


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
                            listBoxNotes.Items.Add(temp);
                        }
                    }
                }
                conn.Close();
            }


            query = "Select Jobs FROM '" + userName + "' WHERE Jobs IS NOT NULL ORDER BY ID DESC";

            cmd = new SQLiteCommand(query, conn);


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
                            listBoxJobs.Items.Add(temp);
                        }
                    }
                }
                conn.Close();
            }



            query = "Select Selected FROM '" + userName + "' WHERE Selected IS NOT NULL ORDER BY Selected ASC";

            cmd = new SQLiteCommand(query, conn);


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
                            listBoxSelectedVeg.Items.Add(temp);
                        }
                    }
                }
                conn.Close();
            }
        }

        public void ClearLists()
        {
            listBoxJournal.Items.Clear();
            listBoxNotes.Items.Clear();
            listBoxJobs.Items.Clear();
            listBoxSelectedVeg.Items.Clear();

            LoadUserData();
        }

        private void insertQuery()
        {
            using (conn)
            {
                conn.Open();

                cmd = new SQLiteCommand(query, conn);

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

                conn.Close();
            }
        }
        
        //Journal
        private void listBoxJournal_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnRemoveJournalPost.Enabled = true;
        }
        private void tbJournalTitle_Click(object sender, EventArgs e)
        {
            if (tbJournalTitle.Text == "Journal Entiry Title")
            {
                tbJournalTitle.Text = "";
            }
        }
        private void tbJournalEntiry_Click(object sender, EventArgs e)
        {
            if (tbJournalEntiry.Text == "Journal Entiry Details")
            {
                tbJournalEntiry.Text = "";
            }
        }
        private void btnSaveJournalEntiry_Click(object sender, EventArgs e)
        {
            journalTitle = tbJournalTitle.Text;
            journalDetails = tbJournalEntiry.Text;
            journalEntiry = journalTitle + "," + journalDetails;
            date = DateTime.Now;

            query = "INSERT INTO " + userName + "(Journal, Date) VALUES ('" + journalEntiry + "', '" + date + "')";

            insertQuery();

            resetJournal();
        }
        private void btnDiscardJournalEntiry_Click(object sender, EventArgs e)
        {
            DialogResult confirmation = MessageBox.Show("Are you sure you want to discard " + tbJournalTitle.Text, "Confirmation", MessageBoxButtons.YesNo);
            if (confirmation == DialogResult.Yes)
            {
                resetJournal();
            }
        }
        private void btnRemoveJournalPost_Click(object sender, EventArgs e)
        {
            temp = listBoxJournal.SelectedItem.ToString();
            query = " Delete from '" + userName + "' where Journal = '" + temp + "'";
            cmd = new SQLiteCommand(query, conn);
            using (conn)
            {
                conn.Open();
                using (cmd)
                {
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }

                conn.Close();
            }

            btnRemoveJournalPost.Enabled = false;

            ClearLists();
        }
        private void resetJournal()
        {
            tbJournalTitle.Text = "Journal Entiry Title";
            tbJournalEntiry.Text = "Journal Entiry Details";
            ClearLists();
        }
        
        //Notes
        private void listBoxNotes_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnRemoveNote.Enabled = true;
        }
        private void tbNoteTitle_Click(object sender, EventArgs e)
        {
            if (tbJournalTitle.Text == "Note Title")
            {
                tbJournalTitle.Text = "";
            }
        }
        private void tbNoteEntiry_Click(object sender, EventArgs e)
        {
            if (tbJournalTitle.Text == "Note Details")
            {
                tbJournalTitle.Text = "";
            }
        }
        private void btnSaveNote_Click(object sender, EventArgs e)
        {
            noteTitle = tbNoteTitle.Text;
            noteDetails = tbNoteEntiry.Text;
            noteEntiry = noteTitle + "," + noteDetails;

            date = DateTime.Now;

            query = "INSERT INTO " + userName + "(Notes, Date) VALUES ('" + noteEntiry + "', '" + date + "')";

            insertQuery();

            resetNotes();
        }
        private void btnDiscardNote_Click(object sender, EventArgs e)
        {
            DialogResult confirmation = MessageBox.Show("Are you sure you want to discard " + tbNoteTitle.Text, "Confirmation", MessageBoxButtons.YesNo);
            if (confirmation == DialogResult.Yes)
            {
                resetNotes();
            }
        }
        private void btnRemoveNote_Click(object sender, EventArgs e)
        {
            temp = listBoxNotes.SelectedItem.ToString();
            query = " Delete from '" + userName + "' where Notes = '" + temp + "'";
            cmd = new SQLiteCommand(query, conn);
            using (conn)
            {
                conn.Open();
                using (cmd)
                {
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }

                conn.Close();
            }

            btnRemoveNote.Enabled = false;

            ClearLists();
        }
        private void resetNotes()
        {
            tbNoteTitle.Text = "Note Title";
            tbNoteEntiry.Text = "Note Details";
            ClearLists();
        }
        
        //Jobs
        private void listBoxJobs_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnRemoveJob.Enabled = true;
        }

        private void btnAddPlant_Click(object sender, EventArgs e)
        {
            AddPlant addPlant = new AddPlant();
            addPlant.Show();
        }

        private void tbJobTitle_Click(object sender, EventArgs e)
        {
            if (tbJobTitle.Text == "Job Title")
            {
                tbJobTitle.Text = "";
            }
        }
        private void tbJobDetails_Click(object sender, EventArgs e)
        {
            if (tbJobDetails.Text == "Job Details")
            {
                tbJobDetails.Text = "";
            }
        }
        private void btnSaveJob_Click(object sender, EventArgs e)
        {
            jobTitle = tbJobTitle.Text;
            jobDetails = tbJobDetails.Text;
            jobEntiry = jobTitle + "," + jobDetails;

            date = DateTime.Now;

            query = "INSERT INTO " + userName + "(Jobs, Date) VALUES ('" + jobEntiry + "', '" + date + "')";

            insertQuery();

            resetJobs();
        }
        private void btnDiscardJob_Click(object sender, EventArgs e)
        {
            DialogResult confirmation = MessageBox.Show("Are you sure you want to discard " + tbJobTitle.Text, "Confirmation", MessageBoxButtons.YesNo);
            if (confirmation == DialogResult.Yes)
            {
                resetJobs();
            }
        }
        private void resetJobs()
        {
            tbJobTitle.Text = "Job Title";
            tbJobDetails.Text = "Job Details";
            ClearLists();
        }
        private void btnRemoveJob_Click(object sender, EventArgs e)
        {
            temp = listBoxJobs.SelectedItem.ToString();
            query = " Delete from '" + userName + "' where Jobs = '" + temp + "'";
            cmd = new SQLiteCommand(query, conn);
            using (conn)
            {
                conn.Open();
                using (cmd)
                {
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }

                conn.Close();
            }

            btnRemoveJob.Enabled = false;

            ClearLists();
        }
        

        //Select Veg
        private void listBoxSelectedVeg_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxSelecVegName.Items.Clear();
            listBoxSelectVegSpecies.Items.Clear();
            btnRemoveVeg.Enabled = true;
        }
        private void btnSelectVeg_Click(object sender, EventArgs e)
        {
            listBoxSelecVegName.Items.Clear();
            listBoxSelectVegSpecies.Items.Clear();
            loadVegNames();
        }
        private void loadVegNames()
        {
            query = "Select Distinct Name FROM Vegs WHERE Name IS NOT NULL ORDER BY Name ASC";
            cmd = new SQLiteCommand(query, conn);
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
                            listBoxSelecVegName.Items.Add(temp);
                        }
                    }
                }
                conn.Close();
            }
        }
        private void listBoxSelecVegName_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedVegName = listBoxSelecVegName.SelectedItem.ToString();
            btnAddSelectedVeg.Enabled = false;
            listBoxSelectVegSpecies.Items.Clear();

            count = temp.Length;
            if(count > 0)
            {
                query = "Select Species FROM Vegs WHERE Name  = '" + SelectedVegName + "' ORDER BY Species ASC";
                cmd = new SQLiteCommand(query, conn);
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
                                listBoxSelectVegSpecies.Items.Add(temp);
                            }
                        }
                    }
                    conn.Close();
                }
            }
        }
        private void listBoxSelectVegSpecies_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedVegSpecies = listBoxSelectVegSpecies.SelectedItem.ToString();
            count = temp.Length;
            if (count > 0)
            {
                btnAddSelectedVeg.Enabled = true;
            }
        }
        private void btnAddSelectedVeg_Click(object sender, EventArgs e)
        {
            addVeg();
        }
        //Write chosen veg into database after checking if the selected veg is present
        public void addVeg()
        {
            btnAddSelectedVeg.Enabled = false;
            listBoxSelecVegName.Items.Clear();
            listBoxSelectVegSpecies.Items.Clear();
            date = DateTime.Now;
            temp = SelectedVegName + " (" + SelectedVegSpecies + ")";
            query = "SELECT COUNT (Selected) from '" + userName + "' WHERE Selected = '" + temp + "'";
            cmd = new SQLiteCommand(query, conn);
            using (conn)
            {
                conn.Open();
                using (cmd)
                {
                    using (reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            try
                            {
                                count = reader.GetInt32(0);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.ToString());
                            }
                        }
                    }
                }

                conn.Close();
            }

            if (count == 0)
            {
                query = "INSERT INTO " + userName + "(Selected, Date) VALUES ('" + temp + "', '" + date +"')";
                cmd = new SQLiteCommand(query, conn);

                using (conn)
                {
                    conn.Open();
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show(temp + " has already been added to your list. Please select somthing differnt.");
            }

            ClearLists();
        }
        private void btnRemoveVeg_Click(object sender, EventArgs e)
        {
            temp = listBoxSelectedVeg.SelectedItem.ToString();
            query = " Delete from '" + userName + "' where Selected = '" + temp + "'";
            cmd = new SQLiteCommand(query, conn);
            using (conn)
            {
                conn.Open();
                using (cmd)
                {
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }

                conn.Close();
            }

            btnRemoveVeg.Enabled = false;

            ClearLists();
        }
    }
}


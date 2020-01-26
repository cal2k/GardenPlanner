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
using System.IO;

namespace GardenPlanner
{
    public partial class Form1 : Form
    {

        private string userName, query, temp,preview, journalTitle, journalDetails, journalEntiry, noteTitle, noteDetails, noteEntiry, jobEntiry, SelectedVegName, SelectedVegSpecies;
        List<string> list = new List<string>();
        int count = 0, userID = 0, remaingTitle = 50, remaingContent = 500, usedTitle = 0, usedContent = 0, countJournalTitle, countJournalContent;
        DateTime date;

        static string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            pathComplete = path + @"\CGP\GardenDB.db";
        SQLiteConnection conn = new SQLiteConnection("Data Source =" + pathComplete + "; version =3;");
        SQLiteCommand cmd;
        SQLiteDataReader reader;
        
        //Tools
        private void btnAddPlant_Click(object sender, EventArgs e)
        {
            AddPlant addPlant = new AddPlant();
            addPlant.Show();
        }
                
        public Form1()
        {
            InitializeComponent();
            Startup();
        }
        
        private void Startup()
        {
            string[] UserNameSplit = new string[2];
            string fileToCopy = "GardenDB.db";

            //gather username
            temp = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            UserNameSplit = temp.Split('\\');
            userName = UserNameSplit[1].ToLower();
            lblUserName.Text = "Welcome, " + userName;

            //check if database exists 
            if (File.Exists(pathComplete) == false)
            {
                System.IO.Directory.CreateDirectory(path + @"\CGP");
                File.Copy(fileToCopy, pathComplete);
            }
            
            //checks for username
            using (conn)
            {
                conn.Open();
                query = "SELECT COUNT (username) from users WHERE username = '" + userName + "'";
                cmd = new SQLiteCommand(query, conn);

                using (cmd)
                {
                    using (reader = cmd.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            try
                            {
                                count = reader.GetInt16(0) ;
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.ToString());
                            }
                        }
                    }
                }

                //adding username if not present
                if (count == 0)
                {
                    query = "INSERT INTO  users (username) VALUES ('" + userName + "')";
                    cmd = new SQLiteCommand(query, conn);
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
                }

                //gather users id
                query = "select ID from users where username = '" + userName + "'";
                cmd = new SQLiteCommand(query, conn);
                using (cmd)
                {
                    using (reader = cmd.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            try
                            {
                                userID = reader.GetInt32(0);
                            }
                            catch(Exception ex)
                            {
                                MessageBox.Show(ex.ToString());
                            }
                        }
                    }
                }
                conn.Close();
            }

             

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
                conn.Close();
            }
            count = 0;
            while (count <= 3)
            {
                LoadUserData(count);
                count++;
            }

        }

        private void LoadUserData(int i)
        {
            string[] array = new string[2];
            switch(i)
            {
                case 0:
                    query = "Select Title FROM Journal WHERE userid = '" + userID +"'ORDER BY date DESC";
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
                    /*count = list.Count();
                    for(int ii = 0; ii < count; ii++)
                    {
                        temp = list[ii].ToString();
                        array = temp.Split(',');
                        journalTitle = array[0];
                        journalDetails = array[1];
                        if (journalDetails.Length > 20)
                        {
                            journalEntiry = journalDetails.Substring(0, 20);
                            preview = journalTitle + " - " + journalEntiry;
                        }
                        else
                        {
                            preview = journalTitle + " - " + journalEntiry;
                        }
                        listBoxJournal.Items.Add(preview);
                    }*/
                    break;
                case 1:
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
                                    cbVegName.Items.Add(temp);
                                }
                            }
                        }
                        conn.Close();
                    }
                    break;
                case 2:
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
                    break;
                case 3:
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
                    break;
            }
        }

        private void Reset(int i)
        {
            switch (i)
            {
                case 0:

                    listBoxJournal.Items.Clear();
                    btnDeleteJournalPost.Enabled = false;
                    btnDeleteJournalPost.Text = "";
                    tbJournalTitle.Text = "Title";
                    lblJournalTitleRemaining.Text = "(50)";
                    tbJournalEntiry.Text = "Details";
                    lblJournalContentRemaing.Text = "(500)";
                    tbJournalEntiry.Enabled = false;
                    btnSaveJournalEntiry.Enabled = false;
                    btnSaveJournalEntiry.Text = "";
                    btnDiscardJournalEntiry.Enabled = false;
                    btnDiscardJournalEntiry.Text = "";
                    LoadUserData(i);
                    break;
                case 1:
                    btnRemoveVeg.Enabled = false;
                    btnRemoveVeg.Text = "";
                    tbVegDetails.Text = "";
                    cbVegName.Items.Clear();
                    cbVegName.Text = "Choose vegetables";
                    cbVegSpecies.Items.Clear();
                    cbVegSpecies.Text = "";
                    cbVegSpecies.Enabled = false;
                    listBoxSelectedVeg.Items.Clear();
                    LoadUserData(i);
                    break;
                case 2:
                    btnRemoveNote.Enabled = false;
                    btnRemoveNote.Text = "";
                    tbNoteTitle.Text = "Title";
                    tbNoteEntiry.Text = "Details";
                    tbNoteEntiry.Enabled = false;
                    btnSaveNote.Enabled = false;
                    btnSaveNote.Text = "";
                    btnDiscardNote.Enabled = false;
                    btnDiscardNote.Text = "";
                    listBoxNotes.Items.Clear();
                    LoadUserData(i);
                    break;
                case 3:
                    btnRemoveJob.Enabled = false;
                    btnRemoveJob.Text = "";
                    tbJobTitle.Text = "Title";
                    tbJobDetails.Text = "Details";
                    tbJobDetails.Enabled = false;
                    btnSaveJob.Enabled = false;
                    btnSaveJob.Text = "";
                    btnDiscardJob.Enabled = false;
                    btnDiscardJob.Text = "";
                    listBoxJobs.Items.Clear();
                    LoadUserData(i);
                    break;

            }

        }

        private void Query()
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
        
        //Save Buttons
        private void btnSaveJournalEntiry_Click(object sender, EventArgs e)
        {
            date = DateTime.Now;

            query = "INSERT INTO Journal (userid, title, content, date) VALUES ('" + userID + "', '" + tbJournalTitle.Text + "', '" + tbJournalEntiry.Text + "', '" + date + "')";

            Query();

            count = 0;
            Reset(count);
        }
        private void btnAddSelectedVeg_Click(object sender, EventArgs e)
        {
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
                query = "INSERT INTO " + userName + "(Selected, Date) VALUES ('" + temp + "', '" + date + "')";
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
            count = 1;
            Reset(count);
        }
        private void btnSaveNote_Click(object sender, EventArgs e)
        {
            noteTitle = tbNoteTitle.Text;
            noteDetails = tbNoteEntiry.Text;
            noteEntiry = noteTitle + "," + noteDetails;

            date = DateTime.Now;

            query = "INSERT INTO " + userName + "(Notes, Date) VALUES ('" + noteEntiry + "', '" + date + "')";

            Query();
            count = 2;
            Reset(count);
        }
        private void btnSaveJob_Click(object sender, EventArgs e)
        {
            jobEntiry = tbJobTitle.Text +","+ tbJobDetails.Text;

            date = DateTime.Now;

            query = "INSERT INTO " + userName + "(Jobs, Date) VALUES ('" + jobEntiry + "', '" + date + "')";

            Query();
            count = 3;
            Reset(count);
        }

        //Discard Buttons
        private void btnDiscardJournalEntiry_Click(object sender, EventArgs e)
        {
            DialogResult confirmation = MessageBox.Show("Are you sure you want to discard " + tbJournalTitle.Text, "Confirmation", MessageBoxButtons.YesNo);
            if (confirmation == DialogResult.Yes)
            {
                count = 0;
                Reset(count);
            }
        }
        private void btnDiscardNote_Click(object sender, EventArgs e)
        {
            DialogResult confirmation = MessageBox.Show("Are you sure you want to discard " + tbNoteTitle.Text, "Confirmation", MessageBoxButtons.YesNo);
            if (confirmation == DialogResult.Yes)
            {
                count = 2;
                Reset(count);
            }
        }
        private void btnDiscardJob_Click(object sender, EventArgs e)
        {
            DialogResult confirmation = MessageBox.Show("Are you sure you want to discard " + tbJobTitle.Text, "Confirmation", MessageBoxButtons.YesNo);
            if (confirmation == DialogResult.Yes)
            {
                count = 3;
                Reset(count);
            }
        }

        //List Events
        private void listBoxJournal_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDeleteJournalPost.Enabled = true;
            btnDeleteJournalPost.Text = "Remove " + listBoxJournal.SelectedItem.ToString();
        }
        private void listBoxSelectedVeg_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnRemoveVeg.Enabled = true;
            btnRemoveVeg.Text = "Remove " + listBoxSelectedVeg.SelectedItem.ToString();

            temp = listBoxSelectedVeg.SelectedItem.ToString();
            string[] tempArray = new string[2];

            tempArray = temp.Split('(', ')');
            List<string> vegDetails = new List<string>();
            StringBuilder sb = new StringBuilder();

            query = "Select * FROM TEST WHERE test1 = 'test'";
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
                                vegDetails.Add(temp);
                                sb.Append(temp + " ");
                            }
                        }
                    }
                    conn.Close();
                }
                count = vegDetails.Count();
                for(int i = 0; i < count; i++)
                {
                    listboxVegDetails.Items.Add(vegDetails[i]);
                }

                tbVegDetails.Text = sb.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void listBoxNotes_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnRemoveNote.Enabled = true;
            btnRemoveNote.Text = "Remove " + listBoxNotes.SelectedItem.ToString();
        }
        private void listBoxJobs_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnRemoveJob.Enabled = true;
            btnRemoveJob.Text = "Remove " + listBoxJobs.SelectedItem.ToString();
        }

        //Remove Buttons
        private void btnRemoveJournalPost_Click(object sender, EventArgs e)
        {
            temp = listBoxJournal.SelectedItem.ToString();
            DialogResult confirmation = MessageBox.Show("Are you sure you want to Delete " + temp, "Confirmation", MessageBoxButtons.YesNo);
            if (confirmation == DialogResult.Yes)
            {
                query = " Delete from '" + userName + "' where Journal = '" + temp + "'";
                Query();

                btnDeleteJournalPost.Enabled = false;
                count = 0;
                Reset(count);
            }
            
            
        }
        private void btnRemoveVeg_Click(object sender, EventArgs e)
        {
            temp = listBoxSelectedVeg.SelectedItem.ToString();
            DialogResult confirmation = MessageBox.Show("Are you sure you want to Delete " + temp, "Confirmation", MessageBoxButtons.YesNo);
            if (confirmation == DialogResult.Yes)
            {
                query = " Delete from '" + userName + "' where Selected = '" + temp + "'";
                Query();

                btnRemoveVeg.Enabled = false;
                count = 1;
                Reset(count);
            }
        }
        private void btnRemoveNote_Click(object sender, EventArgs e)
        {
            temp = listBoxNotes.SelectedItem.ToString();
            DialogResult confirmation = MessageBox.Show("Are you sure you want to Delete " + temp, "Confirmation", MessageBoxButtons.YesNo);
            if (confirmation == DialogResult.Yes)
            {
                query = " Delete from '" + userName + "' where Notes = '" + temp + "'";
                Query();

                btnRemoveNote.Enabled = false;
                count = 2;
                Reset(count);
            }
        }
        private void btnRemoveJob_Click(object sender, EventArgs e)
        {
            temp = listBoxJobs.SelectedItem.ToString();
            DialogResult confirmation = MessageBox.Show("Are you sure you want to Delete " + temp, "Confirmation", MessageBoxButtons.YesNo);
            if (confirmation == DialogResult.Yes)
            {
                query = " Delete from '" + userName + "' where Jobs = '" + temp + "'";

                Query();

                btnRemoveJob.Enabled = false;
                count = 3;
                Reset(count);
            }
        }
        

        //NEW ENTIRYS

        //Journal
        private void tbJournalTitle_Click(object sender, EventArgs e)
        {
            if (tbJournalTitle.Text == "Title")
            {
                tbJournalTitle.Text = "";
            }
        }
        private void tbJournalTitle_TextChanged(object sender, EventArgs e)
        {
            usedTitle = tbJournalTitle.Text.Length;
            count = remaingTitle - usedTitle;
            lblJournalTitleRemaining.Text = "(" + count.ToString() + ")";

            if (tbJournalTitle.Text.Length > 3)
            {
                tbJournalEntiry.Enabled = true;
            }
        }
        private void tbJournalEntiry_Click(object sender, EventArgs e)
        {
            if (tbJournalEntiry.Text == "Details")
            {
                tbJournalEntiry.Text = "";
                btnDiscardJournalEntiry.Text = "Discard " + tbJournalTitle.Text;
                btnDiscardJournalEntiry.Enabled = true;
            }
        }
        private void tbJournalEntiry_TextChanged(object sender, EventArgs e)
        {
            usedContent = tbJournalEntiry.Text.Length;
            countJournalContent = remaingContent - usedContent;
            lblJournalContentRemaing.Text = ("(" + countJournalContent + ")");

            if(tbJournalEntiry.Text.Length > 3)
            {
                btnSaveJournalEntiry.Enabled = true;
                btnSaveJournalEntiry.Text = "Save " + tbJournalTitle.Text;
            }
        }

        //Veg
        private void cbVegName_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedVegName = cbVegName.SelectedItem.ToString();
            cbVegSpecies.Items.Clear();

            query = "Select Species FROM Vegs WHERE Name = '" + SelectedVegName + "' ORDER BY Species ASC";
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
                            cbVegSpecies.Items.Add(temp);
                        }
                    }
                }
                conn.Close();
            }
            //select species
            cbVegSpecies.Enabled = true;
            cbVegSpecies.Text = "Select " + SelectedVegName + " species";
        }
        private void cbVegSpecies_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedVegSpecies = cbVegSpecies.SelectedItem.ToString();
            btnAddSelectedVeg.Enabled = true;
            btnAddSelectedVeg.Text = "Add " + SelectedVegName + " (" + SelectedVegSpecies + ") to your selected vegetable list";
        }

        //Note
        private void tbNoteTitle_Click(object sender, EventArgs e)
            {
                if (tbNoteTitle.Text == "Title")
                {
                tbNoteTitle.Text = "";
                }
            }
        private void tbNoteTitle_TextChanged(object sender, EventArgs e)
        {
            if(tbNoteTitle.Text.Length > 3)
            {
                tbNoteEntiry.Enabled = true;
            }
        }
        private void tbNoteEntiry_Click(object sender, EventArgs e)
        {
            if (tbNoteEntiry.Text == "Details")
            {
                tbNoteEntiry.Text = "";
                btnDiscardNote.Text = "Discard " + tbNoteTitle.Text;
                btnDiscardNote.Enabled = true;
            }
        }
        private void tbNoteEntiry_TextChanged(object sender, EventArgs e)
            {
                if(tbNoteEntiry.Text.Length > 3)
                {
                    btnSaveNote.Enabled = true;
                    btnSaveNote.Text = "Save " + tbNoteTitle.Text;
                }
            }

        //Job
        private void tbJobTitle_Click(object sender, EventArgs e)
        {
            if (tbJobTitle.Text == "Title")
            {
                tbJobTitle.Text = "";
            }
        }
        private void tbJobTitle_TextChanged(object sender, EventArgs e)
        {
            if(tbJobTitle.Text.Length > 3)
            {
                tbJobDetails.Enabled = true;
            }
        }
        private void tbJobDetails_Click(object sender, EventArgs e)
        {
            if (tbJobDetails.Text == "Details")
            {
                tbJobDetails.Text = "";
                btnDiscardJob.Text = "Discard " + tbJobTitle.Text;
                btnDiscardJob.Enabled = true;
            }
        }
        private void tbJobDetails_TextChanged(object sender, EventArgs e)
            {
                if(tbJobDetails.Text.Length > 3)
                {
                    btnSaveJob.Enabled = true;
                    btnSaveJob.Text = "Save " + tbJobTitle.Text;
                }
            }
    }           
}


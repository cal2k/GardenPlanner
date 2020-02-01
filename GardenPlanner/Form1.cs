﻿using System;
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

        private string userName, query, temp, SelectedVegName, SelectedVegSpecies, currentTag;
        List<string> list = new List<string>(), listTags = new List<string>();
        int count = 0, userID = 0;

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
        private void btnCreateTag_Click(object sender, EventArgs e)
        {
            CreateTag tag = new CreateTag();
            tag.setID(userID);
            tag.FormClosed += new FormClosedEventHandler(CreateTag_FormClosed);
            tag.Show();

        }
        private void CreateTag_FormClosed(object sender, FormClosedEventArgs e)
        {
            count = 4;
            Reset(count);
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
                        while (reader.Read())
                        {
                            try
                            {
                                count = reader.GetInt16(0);
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
                        while (reader.Read())
                        {
                            try
                            {
                                userID = reader.GetInt32(0);
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
            while (count <= 4)
            {
                LoadUserData(count);
                count++;
            }

        }

        private void LoadUserData(int i)
        {
            string[] array = new string[2];
            switch (i)
            {
                case 0:
                    query = "Select Title FROM Journal WHERE userid = '" + userID + "'ORDER BY date DESC";
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
                                    temp = reader.GetString(0).Replace(".a", "'");
                                    listBoxJournal.Items.Add(temp);
                                }
                            }
                        }
                        conn.Close();
                    }
                    break;
                case 1:
                    query = "Select * From Vegs WHERE id IN(SELECT vegid FROM SelectedVeg WHERE userid = '" + userID + "')";

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
                                    SelectedVegName = reader.GetString(1);
                                    SelectedVegSpecies = reader.GetString(2);
                                    temp = SelectedVegName + " (" + SelectedVegSpecies + ")";
                                    listBoxSelectedVeg.Items.Add(temp);
                                }
                            }
                        }
                        conn.Close();
                    }
                    break;
                case 2:
                    query = "Select title FROM Note where userid = '"+userID+"' ORDER BY date DESC";

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
                                    temp = reader.GetString(0).Replace(".a", "'");
                                    listBoxNotes.Items.Add(temp);
                                }
                            }
                        }
                        conn.Close();
                    }
                    break;
                case 3:
                    query = "Select title FROM Job where userid = '" + userID +"' ORDER BY date DESC";

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
                                    temp = reader.GetString(0).Replace(".a", "'");
                                    listBoxJobs.Items.Add(temp);
                                }
                            }
                        }
                        conn.Close();
                    }
                    break;
                case 4:
                    query = "Select tag FROM Tags where userid = '" + userID + "'";
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
                                        cbJournalTags.Items.Add(temp);
                                        cbJobTags.Items.Add(temp);
                                        cbVegTags.Items.Add(temp);
                                        cbNoteTags.Items.Add(temp);

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
                    break;
                case 5:
                    query = "Select title from Journal where tag = '" + currentTag + "';";
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
                    break;
                case 6:
                    query = "Select title from Job where tag = '" + currentTag + "';";
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
                case 8:
                    query = "Select title from Note where tag = '" + currentTag + "';";
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
            }
        }

        public void Reset(int i)
        {
            switch (i)
            {
                case 0:

                    listBoxJournal.Items.Clear();
                    btnEditJournal.Enabled = false;
                    btnDeleteJournalPost.Enabled = false;
                    tbJournalContent.Text = "";
                    LoadUserData(i);
                    break;
                case 1:
                    btnEditVegDetails.Enabled = false;
                    btnRemoveVeg.Enabled = false;
                    tbVegDetails.Text = "";
                    listBoxSelectedVeg.Items.Clear();
                    LoadUserData(i);
                    break;
                case 2:
                    btnEditNote.Enabled = false;
                    btnRemoveNote.Enabled = false;
                    listBoxNotes.Items.Clear();
                    LoadUserData(i);
                    break;
                case 3:
                    btnEditJob.Enabled = false;
                    btnRemoveJob.Enabled = false;
                    listBoxJobs.Items.Clear();
                    LoadUserData(i);
                    break;
                case 4:
                    listTags.Clear();
                    cbJournalTags.Items.Clear();
                    LoadUserData(i);
                    break;
                case 5:
                    listBoxJournal.Items.Clear();
                    LoadUserData(i);
                    break;
                case 6:
                    listBoxJobs.Items.Clear();
                    LoadUserData(i);
                    break;
                case 7:
                    listBoxSelectedVeg.Items.Clear();
                    LoadUserData(i);
                    break;
                case 8:
                    listBoxNotes.Items.Clear();
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

        //List Events
        private void listBoxJournal_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbJournalContent.Text = "";
            if (listBoxJournal.SelectedIndex > -1)
            {
                btnEditJournal.Enabled = true;
                btnDeleteJournalPost.Enabled = true;

                temp = listBoxJournal.SelectedItem.ToString().Replace("'", ".a");

                query = "select content from Journal where title ='" + temp + "'";
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
                                    tbJournalContent.Text = reader.GetString(0).Replace(".a", "'");
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
        }
        private void listBoxSelectedVeg_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> vegDetails = new List<string>();
            List<string> titles = new List<string>();
            StringBuilder sb = new StringBuilder();

            tbVegDetails.Text = "";
            vegDetails.Clear();
            sb.Clear();



            if (listBoxSelectedVeg.SelectedIndex > -1)
            {
                btnEditVegDetails.Enabled = true;
                btnRemoveVeg.Enabled = true;

                temp = listBoxSelectedVeg.SelectedItem.ToString();
                string[] tempArray = new string[2];
                tempArray = temp.Split('(', ')');

                titles.Add("Sowing:\n");
                titles.Add("\nGrowing:\n");
                titles.Add("\nHarvest:\n");
                titles.Add("\nCommon Problems:\n");

                query = "Select Sowing, Growing, Harvest, CommonProblems, Companion FROM Vegs WHERE Species = '" + tempArray[1].ToString() + "'";
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
                                    temp = reader.GetString(1);
                                    vegDetails.Add(temp);
                                    temp = reader.GetString(2);
                                    vegDetails.Add(temp);
                                    temp = reader.GetString(3);
                                    vegDetails.Add(temp);
                                }
                            }
                        }
                        conn.Close();
                    }
                    count = vegDetails.Count();
                    for (int i = 0; i < count; i++)
                    {
                        sb.Append(titles[i] + vegDetails[i] + "\n");
                    }
                    tbVegDetails.Text = sb.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
        private void listBoxNotes_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbNoteContent.Text = "";

            if (listBoxNotes.SelectedIndex > -1)
            {
                btnEditNote.Enabled = true;
                btnRemoveNote.Enabled = true;

                temp = listBoxNotes.SelectedItem.ToString().Replace("'", ".a"); 

                query = "select content from Note where title ='" + temp + "'";
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
                                while(reader.Read())
                                {
                                    tbNoteContent.Text = reader.GetString(0).Replace(".a", "'");
                                }
                            }
                        }
                            conn.Close();
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
        private void listBoxJobs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxJobs.SelectedIndex > -1)
            {
                btnEditJob.Enabled = true;
                btnRemoveJob.Enabled = true;

                temp = listBoxJobs.SelectedItem.ToString().Replace("'", ".a");

                query = "select content from Job where title ='" + temp + "'";
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
                                    tbJobContent.Text = reader.GetString(0).Replace(".a", "'");
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
        }

        //List Filters
        private void cbJournalFilterTags_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentTag = cbJournalTags.SelectedItem.ToString();
            count = 5;
            Reset(count);
        }
        private void btnJournalFilterRemove_Click(object sender, EventArgs e)
        {
            cbJournalTags.Text = "Tags";
            count = 0;
            Reset(count);
        }
        private void bnJobTags_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentTag = cbJobTags.SelectedItem.ToString();
            count = 6;
            Reset(count);
        }
        private void btnRemoveJobTag_Click(object sender, EventArgs e)
        {
            cbJobTags.Text = "Tags";
            count = 3;
            Reset(count);
        }
        private void cbVegTags_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentTag = cbVegTags.SelectedItem.ToString();
            count = 7;
            Reset(count);
        }
        private void btnRemoveVegTag_Click(object sender, EventArgs e)
        {
            cbVegTags.Text = "Tags";
            count = 1;
            Reset(count);
        }
        private void cbNoteTags_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentTag = cbNoteTags.SelectedItem.ToString();
            count = 8;
            Reset(count);
        }
        private void btnRemoveNoteTags_Click(object sender, EventArgs e)
        {
            cbNoteTags.Text = "Tags";
            count = 2;
            Reset(count);
        }

        //new entirys
        private void btnNewJournal_Click(object sender, EventArgs e)
        {
            New_Entirys.NewJournal Journal = new New_Entirys.NewJournal();
            Journal.FormClosed += new FormClosedEventHandler(Journal_FormClosed);
            Journal.setUserID(userID);
            Journal.Show();
        }
        private void btnEditJournal_Click(object sender, EventArgs e)
        {
            Edit.EditJournal EditJournal = new Edit.EditJournal();
            EditJournal.FormClosed += new FormClosedEventHandler(Journal_FormClosed);
            EditJournal.populate(listBoxJournal.SelectedItem.ToString());
            EditJournal.Show();
        }
        private void Journal_FormClosed(object sender, FormClosedEventArgs e)
        {
            tbJournalContent.Text = "";
            count = 0;
            Reset(count);
        }
        private void btnNewNote_Click(object sender, EventArgs e)
        {
            New_Entirys.NewNote Note = new New_Entirys.NewNote();
            Note.FormClosed += new FormClosedEventHandler(Note_FormClosed);
            Note.setUserID(userID);
            Note.Show();
        }
        private void Note_FormClosed(object sender, FormClosedEventArgs e)
        {
            count = 2;
            Reset(count);
        }
        private void btnEditNote_Click(object sender, EventArgs e)
        {
            Edit.EditNote EditNote = new Edit.EditNote();
            EditNote.FormClosed += new FormClosedEventHandler(Note_FormClosed);
            EditNote.populate(listBoxNotes.SelectedItem.ToString());
            EditNote.Show();
        }
        private void btnNewJob_Click(object sender, EventArgs e)
        {
            New_Entirys.NewJob Note = new New_Entirys.NewJob();
            Note.FormClosed += new FormClosedEventHandler(Job_FormClosed);
            Note.setUserID(userID);
            Note.Show();
        }
        private void Job_FormClosed(object sender, FormClosedEventArgs e)
        {
            count = 3;
            Reset(count);
        }
        private void btnEditJob_Click(object sender, EventArgs e)
        {
            Edit.EditJob EditJob = new Edit.EditJob();
            EditJob.FormClosed += new FormClosedEventHandler(Job_FormClosed);
            EditJob.populate(listBoxJobs.SelectedItem.ToString());
            EditJob.Show();

        }
        private void btnSelectVeg_Click(object sender, EventArgs e)
        {
            New_Entirys.NewSelectedVeg NewSelectedVeg = new New_Entirys.NewSelectedVeg();
            NewSelectedVeg.FormClosed += new FormClosedEventHandler(SelectedVeg_FormClosed);
            NewSelectedVeg.setUserID(userID);
            NewSelectedVeg.Show();
        }
        private void SelectedVeg_FormClosed(object sender, FormClosedEventArgs e)
        {
            count = 1;
            Reset(count);
        }
        private void btnEditVegDetails_Click(object sender, EventArgs e)
        {
            Edit.EditVeg EditVeg = new Edit.EditVeg();
            EditVeg.FormClosed += new FormClosedEventHandler(SelectedVeg_FormClosed);
            EditVeg.populate(listBoxSelectedVeg.SelectedItem.ToString());
            EditVeg.Show();
        }

        //Remove Buttons
        private void btnRemoveJournalPost_Click(object sender, EventArgs e)
        {
            temp = listBoxJournal.SelectedItem.ToString();
            DialogResult confirmation = MessageBox.Show("Are you sure you want to Delete " + temp, "Confirmation", MessageBoxButtons.YesNo);
            if (confirmation == DialogResult.Yes)
            {
                temp = temp.Replace("'", ".a");
                query = "Delete from Journal where title = '" + temp + "'";
                Query();
                tbJournalContent.Text = "";
                btnDeleteJournalPost.Enabled = false;
                count = 0;
                Reset(count);
            }


        }
        private void btnRemoveVeg_Click(object sender, EventArgs e)
        {
            temp = listBoxSelectedVeg.SelectedItem.ToString();
            string[] split = new string[2];
            split = temp.Split('(', ')');

            DialogResult confirmation = MessageBox.Show("Are you sure you want to Delete " + temp, "Confirmation", MessageBoxButtons.YesNo);
            if (confirmation == DialogResult.Yes)
            {
                
                try
                {
                    using (conn)
                    {
                        conn.Open();
                        query = "SELECT id from Vegs where Species = '" + split[1] + "'";
                        cmd = new SQLiteCommand(query, conn);

                        using (cmd)
                        {
                            using (reader = cmd.ExecuteReader())
                            {
                                while(reader.Read())
                                {
                                    count = reader.GetInt32(0);
                                }
                            }
                        }
                        conn.Close(); 
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                query = "Delete from SelectedVeg where vegid = '" + count + "'";
                Query();
                conn.Close();
                tbVegDetails.Text = "";
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
                temp = temp.Replace("'", ".a");
                query = "Delete from Note where title = '" + temp + "'";
                Query();

                tbNoteContent.Text = "";
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
                temp = temp.Replace("'", ".a");
                query = "Delete from Job where title = '" + temp + "'";

                Query();

                tbJobContent.Text = "";
                btnRemoveJob.Enabled = false;
                count = 3;
                Reset(count);
            }
        }

    }
}


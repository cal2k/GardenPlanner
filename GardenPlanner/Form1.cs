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

        private string userName, query, temp, noteTitle, noteDetails, noteEntiry, jobEntiry, SelectedVegName, SelectedVegSpecies, currentTag;
        List<string> list = new List<string>(), listTags = new List<string>();
        int count = 0, userID = 0, remaingTitle = 50, remaingContent = 500, usedTitle = 0, usedContent = 0, countJournalTitle, countJournalContent;

        int currentVegID;
        DateTime date;

        static string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            pathComplete = path + @"\CGP\GardenDB.db";
        SQLiteConnection conn = new SQLiteConnection("Data Source =" + pathComplete + "; version =3;");
        SQLiteCommand cmd;
        SQLiteDataReader reader;

        DisplayJournal ds = new DisplayJournal();
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
            while (count <= 4)
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
                                    while(reader.Read())
                                    {
                                        temp = reader.GetString(0);
                                        cbJournalFilterTags.Items.Add(temp);
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
            }
        }

        public void Reset(int i)
        {
            switch (i)
            {
                case 0:

                    listBoxJournal.Items.Clear();
                    btnDeleteJournalPost.Enabled = false;
                    btnDeleteJournalPost.Text = "";
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
                    listBoxNotes.Items.Clear();
                    LoadUserData(i);
                    break;
                case 3:
                    btnRemoveJob.Enabled = false;
                    btnRemoveJob.Text = "";
                    listBoxJobs.Items.Clear();
                    LoadUserData(i);
                    break;
                case 4:
                    listTags.Clear();
                    cbJournalFilterTags.Items.Clear();
                    LoadUserData(i);
                    break;
                case 5:
                    listBoxJournal.Items.Clear();
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
                        query = "INSERT INTO SelectedVeg (userid, vegid) VALUES ('" + userID + "', '" + currentVegID + "')";
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

                    count = 1;
                    Reset(count);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        

        //List Events
        private void listBoxJournal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxJournal.SelectedItem.ToString().Length > 0)
            {
                btnDeleteJournalPost.Enabled = true;
                btnDeleteJournalPost.Text = "Remove " + listBoxJournal.SelectedItem.ToString();
            }
        }
        private void listBoxJournal_DoubleClick(object sender, EventArgs e)
        {
            temp = listBoxJournal.SelectedItem.ToString();
            ds.load(temp);
            ds.FormClosed += new FormClosedEventHandler(DisplayJournnal_FormClosed);
            ds.Show();
            
        }
        private void DisplayJournnal_FormClosed(object sender, FormClosedEventArgs e)
        {
            count = 0;
            Reset(count);
        }

        private void listBoxSelectedVeg_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> vegDetails = new List<string>();
            List<string> titles = new List<string>();
            StringBuilder sb = new StringBuilder();

            tbVegDetails.Text = "";
            vegDetails.Clear();
            sb.Clear();



            if (listBoxSelectedVeg.SelectedItem.ToString().Length > 0)
            {
                btnRemoveVeg.Enabled = true;
                btnRemoveVeg.Text = "Remove " + listBoxSelectedVeg.SelectedItem.ToString();

                temp = listBoxSelectedVeg.SelectedItem.ToString();
                string[] tempArray = new string[2];
                tempArray = temp.Split('(', ')');

                titles.Add("Sowing:\n");
                titles.Add("\nGrowing:\n");
                titles.Add("\nHarvest:\n");
                titles.Add("\nCommon Problems:\n");

                query = "Select Sowing, Growing, Harvest, CommonProblems, Companion FROM Vegs WHERE Species = '" + tempArray[1].ToString() +"'";
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
            if (listBoxNotes.SelectedItem.ToString().Length > 0)
            {
                btnRemoveNote.Enabled = true;
                btnRemoveNote.Text = "Remove " + listBoxNotes.SelectedItem.ToString();
            }
        }
        private void listBoxJobs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxJobs.SelectedItem.ToString().Length > 0)
            {
                btnRemoveJob.Enabled = true;
                btnRemoveJob.Text = "Remove " + listBoxJobs.SelectedItem.ToString();
            }
        }

        //List Filters
        private void cbJournalFilterTags_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentTag = cbJournalFilterTags.SelectedItem.ToString();
            count = 5;
            Reset(count);
        }

        private void btnJournalFilterRemove_Click(object sender, EventArgs e)
        {
            cbJournalFilterTags.Text = "Tags";
            count = 0;
            Reset(count);
        }

        //new entirys
        private void btnNewJournal_Click(object sender, EventArgs e)
        {
            New_Entirys.NewJournal Journal = new New_Entirys.NewJournal();
            Journal.FormClosed += new FormClosedEventHandler(NewJournal_FormClosed);
            Journal.setUserID(userID);
            Journal.Show();

        }
        private void NewJournal_FormClosed(object sender, FormClosedEventArgs e)
        {
            //reset journal list
        }

        private void btnNewNote_Click(object sender, EventArgs e)
        {
            New_Entirys.NewNote Note = new New_Entirys.NewNote();
            Note.FormClosed += new FormClosedEventHandler(NewNote_FormClosed);
            Note.setUserID(userID);
            Note.Show();
        }
        private void NewNote_FormClosed(object sender, FormClosedEventArgs e)
        {
            //reset note list
        }

        private void btnNewJob_Click(object sender, EventArgs e)
        {
            New_Entirys.NewJob Note = new New_Entirys.NewJob();
            Note.FormClosed += new FormClosedEventHandler(NewJob_FormClosed);
            Note.setUserID(userID);
            Note.Show();
        }
        private void NewJob_FormClosed(object sender, FormClosedEventArgs e)
        {
            //reset job list
        }


        //Remove Buttons
        private void btnRemoveJournalPost_Click(object sender, EventArgs e)
        {
            temp = listBoxJournal.SelectedItem.ToString();
            DialogResult confirmation = MessageBox.Show("Are you sure you want to Delete " + temp, "Confirmation", MessageBoxButtons.YesNo);
            if (confirmation == DialogResult.Yes)
            {
                query = " Delete from Journal where title = '" + temp + "'";
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
    }           
}


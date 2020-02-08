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
        SqL SQL = new SqL();
        New_Entirys.NewJournal NewJournal = new New_Entirys.NewJournal();

        private string userName, query, temp, SelectedVegName, SelectedVegSpecies, currentTag, currentList, currentItem;
        private bool tutorialRun = true;

        
        List<string> list = new List<string>(), listTags = new List<string>();

        private int count, userID;
        
        public Form1()
        {
            InitializeComponent();
            Startup();
        }

        private void Startup()
        {
            SQL.checkfordb();
            SQL.gatherusername();
            setUserDetails();
            loadJournal();
            loadSelected();
            loadJobs();
            loadTags();
            tutorialRun = SQL.tutorial;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            if (tutorialRun == false)
            {
                HOWTO();
            }
        }
        
        //Tools
        private void toolstripbtnAddPlant_Click(object sender, EventArgs e)
        {
            AddPlant addPlant = new AddPlant();
            addPlant.Show();
        }
        private void toolStripbtnCreateTag_Click(object sender, EventArgs e)
        {
            CreateTag tag = new CreateTag();
            tag.setID(userID);
            tag.FormClosed += new FormClosedEventHandler(CreateTag_FormClosed);
            tag.Show();
        }
        private void CreateTag_FormClosed(object sender, FormClosedEventArgs e)
        {
            loadTags();
        }
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            HOWTO();
        }
        //Tools END

        private void HOWTO()
        {
            MessageBox.Show("HELP");
        }
        public void setUserDetails()
        {
            userName = SQL.USERNAME;
            userID = SQL.USERID;
            lblUserName.Text = "Welcome " + userName;
        }
        private void loadJournal()
        {
            listBoxJournal.Items.Clear();
            query = "Select Title FROM Journal WHERE userid = '" + userID + "' and Title is not null ORDER BY date DESC";
            SQL.cmd = new SQLiteCommand(query, SQL.conn);
            using (SQL.conn)
            {
                SQL.conn.Open();
                using (SQL.cmd)
                {
                    using (SQL.reader = SQL.cmd.ExecuteReader())
                    {
                        while (SQL.reader.Read())
                        {
                            temp = SQL.reader.GetString(0).Replace("*A*", "'");
                            listBoxJournal.Items.Add(temp);
                        }
                    }
                }
                SQL.conn.Close();
            }
        }
        private void loadJournalFilter()
        {
            query = "Select title from Journal where tag = '" + currentTag + "';";
            SQL.cmd = new SQLiteCommand(query, SQL.conn);
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
                            listBoxJournal.Items.Add(temp);
                        }
                    }
                }
                SQL.conn.Close();
            }
        }
        private void loadSelected()
        {
            listBoxSelectedVeg.Items.Clear();
            query = "Select * From Vegs WHERE id IN(SELECT vegid FROM SelectedVeg WHERE userid = '" + userID + "' and vegid is not null)";

            SQL.cmd = new SQLiteCommand(query, SQL.conn);


            using (SQL.conn)
            {
                SQL.conn.Open();
                using (SQL.cmd)
                {
                    using (SQL.reader = SQL.cmd.ExecuteReader())
                    {
                        while (SQL.reader.Read())
                        {
                            SelectedVegName = SQL.reader.GetString(1);
                            SelectedVegSpecies = SQL.reader.GetString(2);
                            temp = SelectedVegName + " (" + SelectedVegSpecies + ")";
                            listBoxSelectedVeg.Items.Add(temp);
                        }
                    }
                }
                SQL.conn.Close();
            }
        }
        private void loadJobs()
        {
            listBoxJobs.Items.Clear();
            query = "Select job FROM Job where userid = '" + userID + "' and job is not null ORDER BY date DESC";
            SQL.cmd = new SQLiteCommand(query, SQL.conn);
            using (SQL.conn)
            {
                SQL.conn.Open();
                using (SQL.cmd)
                {
                    using (SQL.reader = SQL.cmd.ExecuteReader())
                    {
                        while (SQL.reader.Read())
                        {
                            temp = SQL.reader.GetString(0).Replace("*A*", "'");
                            listBoxJobs.Items.Add(temp);
                        }
                    }
                }
                SQL.conn.Close();
            }
        }
        private void loadNotes()
        {
            listBoxNotes.Items.Clear();
            query = "select note from '" + currentList + "' where noteid = '" + currentItem + "' and userid = '" + userID + "'";
            SQL.cmd = new SQLiteCommand(query, SQL.conn);
            try
            {
                using (SQL.conn)
                {
                    SQL.conn.Open();
                    using (SQL.reader = SQL.cmd.ExecuteReader())
                    {
                        while(SQL.reader.Read())
                        {
                            temp = SQL.reader.GetString(0);
                            if(temp.Contains("*A*"))
                            {
                                temp = temp.Replace("*A*", "'");
                            }
                            listBoxNotes.Items.Add(temp);
                        }
                    }
                        SQL.conn.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void loadTags()
        {
            listTags.Clear();
            query = "Select tag FROM Tags where userid = '" + userID + "'";
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
                                cbJournalTags.Items.Add(temp);
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

        private void disablebtn()
        {
            btnEditJournal.Enabled = false;
            btnDeleteJournalPost.Enabled = false;
            btnRemoveJournalTag.Enabled = false;
            btnRemoveVeg.Enabled = false;
            btnEditJob.Enabled = false;
            btnRemoveJob.Enabled = false;
            btnNewNote.Enabled = false;
            btnEditNote.Enabled = false;
            btnRemoveNote.Enabled = false;

        }

        //Journal
        private void listBoxJournal_SelectedIndexChanged(object sender, EventArgs e)
        {
            disablebtn();
            if (listBoxJournal.SelectedIndex > -1)
            {
                listBoxJobs.SelectedIndex = -1;
                listBoxSelectedVeg.SelectedIndex = -1;

                btnEditJournal.Enabled = true;
                btnDeleteJournalPost.Enabled = true;
                btnNewNote.Enabled = true;
                currentList = "Journal";
                currentItem = listBoxJournal.SelectedItem.ToString();

                if (currentItem.Contains("'"))
                {
                    currentItem = currentItem.Replace("'", "*A*");
                }
                loadNotes();

            }
        }
        private void btnNewJournal_Click(object sender, EventArgs e)
        {
            New_Entirys.NewJournal Journal = new New_Entirys.NewJournal();
            Journal.FormClosed += new FormClosedEventHandler(Journal_FormClosed);
            Journal.setUserID(userID);
            Journal.Show();
        }
        private void Journal_FormClosed(object sender, FormClosedEventArgs e)
        {
            loadJournal();
        }
        private void btnEditJournal_Click(object sender, EventArgs e)
        {
            Edit.EditJournal EditJournal = new Edit.EditJournal();
            EditJournal.FormClosed += new FormClosedEventHandler(Journal_FormClosed);
            EditJournal.populate(listBoxJournal.SelectedItem.ToString());
            EditJournal.Show();
        }
        private void btnRemoveJournalPost_Click(object sender, EventArgs e)
        {
            temp = listBoxJournal.SelectedItem.ToString();

            DialogResult confirmation = MessageBox.Show("Are you sure you want to Delete " + temp, "Confirmation", MessageBoxButtons.YesNo);
            if (confirmation == DialogResult.Yes)
            {
                if (temp.Contains("'"))
                {
                    temp = temp.Replace("'", "*A*");
                }

                SQL.QUERY = "Delete from Journal where title = '" + temp + "'";
                SQL.queryExecute();
                loadJournal();
            }


        }
        private void cbJournalFilterTags_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnRemoveJournalTag.Enabled = true;
            currentTag = cbJournalTags.SelectedItem.ToString();
            loadJournalFilter();
        }
        private void btnJournalFilterRemove_Click(object sender, EventArgs e)
        {
            cbJournalTags.Text = "Tags";
            loadJournal();
            loadTags();
        }

        //Notes
        private void listBoxNotes_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listBoxNotes.SelectedIndex > -1)
            {
                btnEditNote.Enabled = true;
                btnRemoveNote.Enabled = true;
            }
        }
        private void btnNewNote_Click(object sender, EventArgs e)
        {
            New_Entirys.NewNote Note = new New_Entirys.NewNote();
            Note.FormClosed += new FormClosedEventHandler(Note_FormClosed);
            Note.setUserID(userID, currentList, currentItem);
            Note.Show();
        }
        private void Note_FormClosed(object sender, FormClosedEventArgs e)
        {
            loadNotes();
        }
        private void btnEditNote_Click(object sender, EventArgs e)
        {
            Edit.EditNote EditNote = new Edit.EditNote();
            EditNote.FormClosed += new FormClosedEventHandler(Note_FormClosed);
            EditNote.populate(userID, currentList, currentItem);
            EditNote.Show();
        }
        private void btnRemoveNote_Click(object sender, EventArgs e)
        {
            temp = listBoxNotes.SelectedItem.ToString();
            DialogResult confirmation = MessageBox.Show("Are you sure you want to Delete " + temp, "Confirmation", MessageBoxButtons.YesNo);
            if (confirmation == DialogResult.Yes)
            {
                temp = temp.Replace("'", "*A*");
                SQL.QUERY = "Delete from '" + currentList + "' where note = '" + temp + "'";
                SQL.queryExecute();

                loadNotes();
            }
        }

        //Jobs
        private void listBoxJobs_SelectedIndexChanged(object sender, EventArgs e)
        {
            disablebtn();
            if (listBoxJobs.SelectedIndex > -1)
            {
                listBoxJournal.SelectedIndex = -1;
                listBoxSelectedVeg.SelectedIndex = -1;
                btnEditJob.Enabled = true;
                btnRemoveJob.Enabled = true;
                btnNewNote.Enabled = true;
                currentList = "Job";
                currentItem = listBoxJobs.SelectedItem.ToString();

                if (currentItem.Contains("'"))
                {
                    currentItem = currentItem.Replace("'", "*A*");
                }
                loadNotes();
            }
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
            loadJobs();
        }
        private void btnEditJob_Click(object sender, EventArgs e)
        {
            Edit.EditJob EditJob = new Edit.EditJob();
            EditJob.FormClosed += new FormClosedEventHandler(Job_FormClosed);
            EditJob.populate(listBoxJobs.SelectedItem.ToString());
            EditJob.Show();

        }
        private void btnRemoveJob_Click(object sender, EventArgs e)
        {

            temp = listBoxJobs.SelectedItem.ToString();

            DialogResult confirmation = MessageBox.Show("Are you sure you want to Delete " + temp, "Confirmation", MessageBoxButtons.YesNo);
            if (confirmation == DialogResult.Yes)
            {
                if (temp.Contains("'"))
                {
                    temp = temp.Replace("'", "*A*");
                }

                SQL.QUERY = "Delete from Job where job = '" + temp + "'";
                SQL.queryExecute();

                btnRemoveJob.Enabled = false;
                loadJobs();
            }
        }

        //Selected
        private void listBoxSelectedVeg_SelectedIndexChanged(object sender, EventArgs e)
        {
            disablebtn();
            if (listBoxSelectedVeg.SelectedIndex > -1)
            {
                listBoxJournal.SelectedIndex = -1;
                listBoxJobs.SelectedIndex = -1;
                btnRemoveVeg.Enabled = true;
                btnNewNote.Enabled = true;
                currentList = "SelectedVeg";
                string[] array = listBoxSelectedVeg.SelectedItem.ToString().Split('(', ')');

                currentItem = array[1];

                query = "select ID from Vegs where Species = '" + currentItem + "'";
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
                                    count = SQL.reader.GetInt32(0);
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

                currentItem = count.ToString();

                if (currentItem.Contains("'"))
                {
                    currentItem = currentItem.Replace("'", "*A*");
                }
                loadNotes();
            }
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
            loadSelected();
        }
        private void btnEditVegDetails_Click(object sender, EventArgs e)
        {
            Edit.EditVeg EditVeg = new Edit.EditVeg();
            EditVeg.FormClosed += new FormClosedEventHandler(SelectedVeg_FormClosed);
            EditVeg.populate(listBoxSelectedVeg.SelectedItem.ToString());
            EditVeg.Show();
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
                    using (SQL.conn)
                    {
                        SQL.conn.Open();
                        query = "SELECT id from Vegs where Species = '" + split[1] + "'";
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
                        SQL.conn.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                SQL.QUERY = "Delete from SelectedVeg where vegid = '" + count + "'";
                SQL.queryExecute();
                SQL.conn.Close();
                btnRemoveVeg.Enabled = false;
                loadSelected();
            }
        }
    }
}


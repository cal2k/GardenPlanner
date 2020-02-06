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

        private string userName, query, temp, SelectedVegName, SelectedVegSpecies, currentTag;

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
        }

        public void setUserDetails()
        {
            userName = SQL.USERNAME;
            userID = SQL.USERID;
            lblUserName.Text = "Welcome " + userName;
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
            count = 4;
            Reset(count);
        }
        //Tools END

        private void loadJournal()
        {
            query = "Select Title FROM Journal WHERE userid = '" + userID + "'ORDER BY date DESC";
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
            query = "Select * From Vegs WHERE id IN(SELECT vegid FROM SelectedVeg WHERE userid = '" + userID + "')";

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
            query = "Select job FROM Job where userid = '" + userID + "' ORDER BY date DESC";
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

        }
        private void loadTags()
        {
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

        public void Reset(int i)
        {
            switch (i)
            {
                case 0:

                    listBoxJournal.Items.Clear();
                    btnEditJournal.Enabled = false;
                    btnDeleteJournalPost.Enabled = false;
                    loadJournal();
                    break;
                case 1:
                    btnEditVegDetails.Enabled = false;
                    btnRemoveVeg.Enabled = false;
                    listBoxSelectedVeg.Items.Clear();
                    loadSelected();
                    break;
                case 2:
                    btnEditNote.Enabled = false;
                    btnRemoveNote.Enabled = false;
                    listBoxNotes.Items.Clear();
                    loadNotes();
                    break;
                case 3:
                    btnEditJob.Enabled = false;
                    btnRemoveJob.Enabled = false;
                    listBoxJobs.Items.Clear();
                    loadJobs();
                    break;
                case 4:
                    listTags.Clear();
                    cbJournalTags.Items.Clear();
                    loadTags();
                    break;

            }

        }

        //List Events
        private void listBoxJournal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxJournal.SelectedIndex > -1)
            {
                btnEditJournal.Enabled = true;
                btnDeleteJournalPost.Enabled = true;
            }
        }
        private void listBoxNotes_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listBoxNotes.SelectedIndex > -1)
            {
                btnEditNote.Enabled = true;
                btnRemoveNote.Enabled = true;
            }
        }
        private void listBoxJobs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxJobs.SelectedIndex > -1)
            {
                btnEditJob.Enabled = true;
                btnRemoveJob.Enabled = true;
            }
        }
        private void listBoxSelectedVeg_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBoxSelectedVeg.SelectedIndex > -1)
            {
                btnEditVegDetails.Enabled = true;
                btnRemoveVeg.Enabled = true;
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
            count = 4;
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
                if (temp.Contains("'"))
                {
                    temp = temp.Replace("'", "*A*");
                }

                SQL.QUERY = "Delete from Journal where title = '" + temp + "'";
                SQL.queryExecute();
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
                    using (SQL.conn)
                    {
                        SQL.conn.Open();
                        query = "SELECT id from Vegs where Species = '" + split[1] + "'";
                        SQL.cmd = new SQLiteCommand(query, SQL.conn);

                        using (SQL.cmd)
                        {
                            using (SQL.reader = SQL.cmd.ExecuteReader())
                            {
                                while(SQL.reader.Read())
                                {
                                    count = SQL.reader.GetInt32(0);
                                }
                            }
                        }
                        SQL.conn.Close(); 
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                SQL.QUERY = "Delete from SelectedVeg where vegid = '" + count + "'";
                SQL.queryExecute();
                SQL.conn.Close();
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
                temp = temp.Replace("'", "*A*");
                SQL.QUERY = "Delete from Note where title = '" + temp + "'";
                SQL.queryExecute();

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
                if (temp.Contains("'"))
                {
                    temp = temp.Replace("'", "*A*");
                }

                SQL.QUERY = "Delete from Job where job = '" + temp + "'";
                SQL.queryExecute();

                btnRemoveJob.Enabled = false;
                count = 3;
                Reset(count);
            }
        }

    }
}


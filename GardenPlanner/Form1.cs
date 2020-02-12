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

        private int vegid;
        private string userName, query, temp, SelectedVegName, SelectedVegSpecies, currentTag, currentList, currentItem;
        private bool tutorialRun = true;

        
        List<string> list = new List<string>(), listTags = new List<string>();

        private int count, userID;
        
        public int COUNT { set { count = value; } }

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
                //Tour
            }
        }


        //Menu
        private void btnNewJournalEntiry_Click(object sender, EventArgs e)
        {
            New_Entirys.NewJournal Journal = new New_Entirys.NewJournal();
            Journal.FormClosed += new FormClosedEventHandler(Journal_FormClosed);
            Journal.setUserID(userID);
            Journal.Show();
        }
        private void btnNewJob_Click(object sender, EventArgs e)
        {
            New_Entirys.NewJob Note = new New_Entirys.NewJob();
            Note.FormClosed += new FormClosedEventHandler(Job_FormClosed);
            Note.setUserID(userID);
            Note.Show();
        }
        private void btnNewNote_Click(object sender, EventArgs e)
        {
            New_Entirys.NewNote Note = new New_Entirys.NewNote();
            Note.FormClosed += new FormClosedEventHandler(Note_FormClosed);
            Note.setUserID(userID, currentList, currentItem);
            Note.Show();
        }
        private void btnSelectVegs_Click(object sender, EventArgs e)
        {
            New_Entirys.NewSelectedVeg NewSelectedVeg = new New_Entirys.NewSelectedVeg();
            NewSelectedVeg.FormClosed += new FormClosedEventHandler(SelectedVeg_FormClosed);
            NewSelectedVeg.setUserID(userID);
            NewSelectedVeg.Show();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult confirmation = MessageBox.Show("Are you sure you want to Delete " + temp + " This is also delete any notes attached to it", "Confirmation", MessageBoxButtons.YesNo);
            if (confirmation == DialogResult.Yes)
            {
                replaceIN();
                switch (count)
                {
                    case 0:
                        SQL.QUERY = "Delete from Journal where title = '" + temp + "'";
                        SQL.queryExecute();
                        SQL.QUERY = "Delete from Journal where noteid = '" + temp + "'";
                        SQL.queryExecute();
                        loadJournal();
                        loadNotes();
                        break;
                    case 1:
                        SQL.QUERY = "Delete from SelectedVeg where vegid = '" + vegid + "'";
                        SQL.queryExecute();
                        SQL.QUERY = "Delete from Journal where noteid = '" + vegid + "'";
                        SQL.queryExecute();
                        loadSelected();
                        loadNotes();
                        break;
                    case 2:
                        SQL.QUERY = "Delete from Job where job = '" + temp + "'";
                        SQL.queryExecute();
                        SQL.QUERY = "Delete from Job where noteid = '" + temp + "'";
                        SQL.queryExecute();
                        loadJobs();
                        loadNotes();
                        break;
                    case 3:
                        SQL.QUERY = "Delete from '" + currentList + "' where note = '" + temp + "'";
                        SQL.queryExecute();
                        loadNotes();
                        break;
                    default:
                        break;
                }
            }
        }

        //Tools
        private void btnNewVegetable_Click(object sender, EventArgs e)
        {
            AddPlant addPlant = new AddPlant();
            addPlant.Show();
        }
        private void btnNewCategory_Click(object sender, EventArgs e)
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
        private void btnHelp_Click(object sender, EventArgs e)
        {
            Tools.Help help = new Tools.Help();
            help.Show();
        }
        
        public void setUserDetails()
        {
            userName = SQL.USERNAME;
            userID = SQL.USERID;
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
                            temp = SQL.reader.GetString(0);

                            replaceOUT();
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
                            replaceOUT();
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
                            temp = SQL.reader.GetString(0);
                            replaceOUT();
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
                            replaceOUT();
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
                                replaceOUT();
                                listTags.Add(temp);
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

            count = listTags.Count;
            for(int i = 0; i < count; i++)
            {
                cbJournalTags.Items.Add(listTags[i]);
            }
        }

        private void disablebtn()
        {
            btnNewNote1.Enabled = false;
            btnEditNote.Enabled = false;
            btnRemoveNote.Enabled = false;

        }

        private void replaceIN()
        {
            if(temp.Contains("'"))
            {
                temp = temp.Replace("'", "*A*");
            }
        }
        private void replaceOUT()
        {
            if(temp.Contains("*A*"))
            {
                temp = temp.Replace("*A*", "'");
            }
        }

        //Journal
        private void listBoxJournal_SelectedIndexChanged(object sender, EventArgs e)
        {
            count = 0;
            disablebtn();
            btnNewNote1.Enabled = true;
            if (listBoxJournal.SelectedIndex > -1)
            {
                listBoxJobs.SelectedIndex = -1;
                listBoxSelectedVeg.SelectedIndex = -1;
                btnNewNote1.Enabled = true;
                currentList = "Journal";
                temp = listBoxJournal.SelectedItem.ToString();
                replaceIN();
                currentItem = temp;
                loadNotes();

            }
        }
        private void listBoxJournal_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxJournal.SelectedIndex > -1)
            {
                Edit.EditJournal EditJournal = new Edit.EditJournal();
                EditJournal.FormClosed += new FormClosedEventHandler(Journal_FormClosed);
                EditJournal.populateReadOnly(listBoxJournal.SelectedItem.ToString(), listTags);
                EditJournal.Show();
            }
        }
        private void Journal_FormClosed(object sender, FormClosedEventArgs e)
        {
            loadJournal();
        }
        private void cbJournalFilterTags_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxJournal.Items.Clear();
            btnRemoveJournalTag.Enabled = true;
            currentTag = cbJournalTags.SelectedItem.ToString();
            loadJournalFilter();
        }
        private void btnJournalFilterRemove_Click(object sender, EventArgs e)
        {
            cbJournalTags.Text = "Tags";
            btnRemoveJournalTag.Enabled = false;
            loadJournal();
        }

        //Notes
        private void listBoxNotes_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listBoxNotes.SelectedIndex > -1)
            {
                count = 3;
                temp = listBoxNotes.SelectedItem.ToString();
                btnEditNote.Enabled = true;
                btnDelete.Enabled = true;
            }
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
        
        //Jobs
        private void listBoxJobs_SelectedIndexChanged(object sender, EventArgs e)
        {
            disablebtn();
            btnNewNote1.Enabled = true;
            if (listBoxJobs.SelectedIndex > -1)
            {
                temp = listBoxJobs.SelectedItem.ToString();
                count = 2;
                listBoxJournal.SelectedIndex = -1;
                listBoxSelectedVeg.SelectedIndex = -1;
                btnNewNote1.Enabled = true;
                currentList = "Job";
                temp = listBoxJobs.SelectedItem.ToString();
                replaceIN();
                currentItem = temp;
                loadNotes();
            }
        }
        private void Job_FormClosed(object sender, FormClosedEventArgs e)
        {
            loadJobs();
        }

        //Selected
        private void listBoxSelectedVeg_SelectedIndexChanged(object sender, EventArgs e)
        {
            count = 1;
            disablebtn();
            btnNewNote1.Enabled = true;
            if (listBoxSelectedVeg.SelectedIndex > -1)
            {
                temp = listBoxSelectedVeg.SelectedItem.ToString();
                string[] split = new string[2];
                split = temp.Split('(', ')');
                temp = split[1];

                listBoxJournal.SelectedIndex = -1;
                listBoxJobs.SelectedIndex = -1;
                btnNewNote1.Enabled = true;

                currentList = "SelectedVeg";

                query = "select ID from Vegs where Species = '" + temp + "'";
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
                                    vegid = SQL.reader.GetInt32(0);
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
                loadNotes();
            }
        }
        private void listBoxSelectedVeg_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxSelectedVeg.SelectedIndex > -1)
            {
                Edit.EditVeg EditVeg = new Edit.EditVeg();
                EditVeg.FormClosed += new FormClosedEventHandler(SelectedVeg_FormClosed);
                EditVeg.populateReadonly(listBoxSelectedVeg.SelectedItem.ToString());
                EditVeg.Show();
            }
        }
        private void SelectedVeg_FormClosed(object sender, FormClosedEventArgs e)
        {
            loadSelected();
        }
        
    }
}


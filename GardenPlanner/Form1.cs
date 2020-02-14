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
        Details.Note Note = new Details.Note();
        Details.VegSelected VegSelected = new Details.VegSelected();
        

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
            count = 0;
            Details.Journal Journal = new Details.Journal();
            Journal.FormClosed += new FormClosedEventHandler(formClosed);
            Journal.New(listTags, userID);
            Journal.Show();
        }
        private void btnNewJob_Click(object sender, EventArgs e)
        {
            count = 2;
            int i = 0;
            Details.Job Job = new Details.Job();
            Job.FormClosed += new FormClosedEventHandler(formClosed);
            Job.setup(userID, i, listTags, currentItem);
            Job.Show();
        }
        private void btnNewNote_Click(object sender, EventArgs e)
        {
            New_Entirys.NewNote Note = new New_Entirys.NewNote();
            Note.FormClosed += new FormClosedEventHandler(formClosed);
            Note.setUserID(userID, currentList, currentItem);
            Note.Show();
        }
        private void btnSelectVegs_Click(object sender, EventArgs e)
        {
            Details.Veg Veg = new Details.Veg();

            count = 1;
            Veg.FormClosed += new FormClosedEventHandler(formClosed);
            Veg.select(userID);
            Veg.Size = new System.Drawing.Size(352, 142);
            Veg.Show();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {

            DialogResult confirmation = MessageBox.Show("Are you sure you want to Delete " + temp + " This is also delete any notes attached to it", "Confirmation", MessageBoxButtons.YesNo);
            if (confirmation == DialogResult.Yes)
            {
                btnDelete.Enabled = false;
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
            btnRemoveJournalTag.Enabled = false;
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
            btnRemoveJobTag.Enabled = false;
            listBoxJobs.Items.Clear();

            query = "Select job FROM Job where userid = '" + userID + "' and job is not null ORDER BY job ASC";
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
        private void loadJobFilter()
        {
            query = "Select job from Job where tag = '" + currentTag + "';";
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
            cbJobTag.Items.Clear();
            cbJournalTags.Items.Clear();

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
                cbJobTag.Items.Add(listTags[i]);
            }
        }

        private void cleanup()
        {
            switch(count)
            {
                case 0:
                    listBoxJobs.SelectedIndex = -1;
                    listBoxSelectedVeg.SelectedIndex = -1;
                    listBoxNotes.SelectedIndex = -1;
                    break;
                case 1:
                    listBoxJobs.SelectedIndex = -1;
                    listBoxJournal.SelectedIndex = -1;
                    listBoxNotes.SelectedIndex = -1;
                    break;
                case 2:
                    listBoxJournal.SelectedIndex = -1;
                    listBoxSelectedVeg.SelectedIndex = -1;
                    listBoxNotes.SelectedIndex = -1;
                    break;
                default:
                    break;
            }
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

        private void formClosed(object sender, FormClosedEventArgs e)
        {
            switch(count)
            {
                case 0:
                    loadJournal();
                    break;
                case 1:
                    loadSelected();
                    break;
                case 2:
                    loadJobs();
                    break;
                case 3:
                    loadNotes();
                    break;
                default:
                    break;
            }
        }

        

        //Journal
        private void listBoxJournal_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (listBoxJournal.SelectedIndex > -1)
            {
                count = 0;
                btnDelete.Enabled = true;
                cleanup();
                currentList = "Journal";
                temp = listBoxJournal.SelectedItem.ToString();
                replaceIN();
                loadNotes();

            }
        }
        private void listBoxJournal_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxJournal.SelectedIndex > -1)
            {
                Details.Journal Journal = new Details.Journal();
                Journal.FormClosed += new FormClosedEventHandler(formClosed);
                Journal.View(temp, listTags, userID);
                Journal.Show();
            }
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
                btnDelete.Enabled = true;
            }
        }
        private void listBoxNotes_DoubleClick(object sender, EventArgs e)
        {
            Edit.EditNote EditNote = new Edit.EditNote();
            EditNote.FormClosed += new FormClosedEventHandler(formClosed);
            EditNote.populate(userID, currentList, currentItem, temp);
            EditNote.Show();
        }
        
        //Jobs
        private void listBoxJobs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxJobs.SelectedIndex > -1)
            {
                count = 2;
                btnDelete.Enabled = true;
                cleanup();
                currentList = "Job";
                temp = listBoxJobs.SelectedItem.ToString();
                replaceIN();
                currentItem = temp;
                loadNotes();
            }
        }
        private void listBoxJobs_DoubleClick(object sender, EventArgs e)
        {
            count = 2;
            int i = 1;
            Details.Job Job = new Details.Job();
            Job.FormClosed += new FormClosedEventHandler(formClosed);
            Job.setup(userID, i, listTags, currentItem);
            Job.Show();
        }
        private void cbJobTag_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxJobs.Items.Clear();
            btnRemoveJobTag.Enabled = true;
            currentTag = cbJobTag.SelectedItem.ToString();
            loadJobFilter();
        }
        private void btnRemoveJobTag_Click(object sender, EventArgs e)
        {
            cbJournalTags.Text = "Tags";
            btnRemoveJobTag.Enabled = false;
            loadJobs();
        }

        //Selected
        private void listBoxSelectedVeg_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (listBoxSelectedVeg.SelectedIndex > -1)
            {
                count = 1;
                btnDelete.Enabled = true;
                cleanup();
                temp = listBoxSelectedVeg.SelectedItem.ToString();
                string[] split = new string[2];
                split = temp.Split('(', ')');
                temp = split[1];

                listBoxJournal.SelectedIndex = -1;
                listBoxJobs.SelectedIndex = -1;

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
                                    currentItem = vegid.ToString();
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
                Details.Veg Veg = new Details.Veg();
                Veg.FormClosed += new FormClosedEventHandler(formClosed);
                Veg.View(userID, temp);
                Veg.Show();
            }
        }
    }
}


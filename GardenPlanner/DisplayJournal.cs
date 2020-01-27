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
    public partial class DisplayJournal : Form
    {
        string title, content, query;
        int id;
        static string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            pathComplete = path + @"\CGP\GardenDB.db";
        SQLiteConnection conn = new SQLiteConnection("Data Source =" + pathComplete + "; version =3;");
        SQLiteCommand cmd;
        SQLiteDataReader reader;

        public DisplayJournal()
        {
            InitializeComponent();
        }

        public void load(string current)
        {

            title = current;

            try
            {
                using (conn)
                {
                    conn.Open();
                    query = "select id from Journal where title = '" + title + "'";
                    cmd = new SQLiteCommand(query, conn);
                    using (cmd)
                    {
                        using (reader = cmd.ExecuteReader())
                        {
                            while(reader.Read())
                            {
                                id = reader.GetInt32(0);
                            }
                        }
                    }
                    query = "Select content from Journal where title = '" + title + "'";
                    cmd = new SQLiteCommand(query, conn);
           
                    using (cmd)
                    {
                        using (reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                content = reader.GetString(0);
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

            tbTitle.Text = title;
            tbDetails.Text = content;
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            tbTitle.ReadOnly = false;
            tbDetails.ReadOnly = false;
            //set colour to white as it dosnt change the colour back when 
            tbDetails.BackColor = Color.White;
            btnDiscard.Enabled = true;
            btnSave.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DateTime date = new DateTime();
            date = DateTime.Now;
            query = "Update Journal Set title = '" + tbTitle.Text.ToString() + "', content = '" + 
                tbDetails.Text.ToString() + "', date = '" + date + "' where id = '" + id + "'";
            cmd = new SQLiteCommand(query, conn);

            try
            {
                using (conn)
                {
                    conn.Open();
                    using (cmd)
                    {
                        cmd.ExecuteNonQuery();
                    }
                    conn.Close();
                }
                tbTitle.ReadOnly = true;
                tbDetails.ReadOnly = true;
                btnSave.Enabled = false;
                btnDiscard.Enabled = false;

                //change back from white when read only
                tbDetails.BackColor = Color.Empty;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        
        private void btnDiscard_Click(object sender, EventArgs e)
        {
            tbTitle.Text = title;
            tbDetails.Text = content;
            tbTitle.ReadOnly = true;
            tbDetails.ReadOnly = true;
            btnDiscard.Enabled = false;
            btnSave.Enabled = false;
            tbDetails.BackColor = Color.Empty;
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

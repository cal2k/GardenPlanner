using System;
using System.Windows.Forms;
using System.Data.SQLite;

namespace GardenPlanner.Edit
{
    public partial class EditJournal : Form
    {
        SqL SQL = new SqL();
        string query, title, oldTitle, content;
        public EditJournal()
        {
            InitializeComponent();
        }

        
        public void populateReadOnly(string t)
        {
            this.Text = "Viewing: " + t;
            oldTitle = t.Replace("'", "*A*");
            try
            {
                using (SQL.conn)
                {
                    SQL.conn.Open();
                    query = "Select title, content from Journal Where title = '" + oldTitle + "'";
                    SQL.cmd = new SQLiteCommand(query, SQL.conn);


                    using (SQL.cmd)
                    {
                        using (SQL.reader = SQL.cmd.ExecuteReader())
                        {
                            while (SQL.reader.Read())
                            {
                                title = SQL.reader.GetString(0).Replace("*A*", "'");
                                content = SQL.reader.GetString(1).Replace("*A*", "'");
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
            tbTitle.Text = title;
            tbContent.Text = content;
            tbTitle.ReadOnly = true;
            tbContent.ReadOnly = true;
            btnSave.Hide();
        }
        public void populate(string t)
        {
            this.Text = "EDIT: " + t;
            oldTitle = t.Replace("'", "*A*");
            try
            {
                using (SQL.conn)
                {
                    SQL.conn.Open();
                    query = "Select title, content from Journal Where title = '" + oldTitle + "'";
                    SQL.cmd = new SQLiteCommand(query, SQL.conn);

            
                    using (SQL.cmd)
                    {
                        using (SQL.reader = SQL.cmd.ExecuteReader())
                        {
                            while(SQL.reader.Read())
                            {
                                title = SQL.reader.GetString(0).Replace("*A*", "'");
                                content = SQL.reader.GetString(1).Replace("*A*", "'");
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
            tbTitle.Text = title;
            tbContent.Text = content;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            title = tbTitle.Text.Replace("'", "*A*");
            content = tbContent.Text.Replace("'", "*A*");
            query = "update Journal set title = '" + title + "', content = '" + content + "' Where title = '" + oldTitle + "'";
            SQL.cmd = new SQLiteCommand(query, SQL.conn);

            using (SQL.conn)
            {
                SQL.conn.Open();
                using (SQL.cmd)
                {
                    SQL.cmd.ExecuteNonQuery();
                }
                    SQL.conn.Close();
            }
            this.Close();
        }
        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

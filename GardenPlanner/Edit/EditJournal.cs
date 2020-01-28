using System;
using System.Windows.Forms;
using System.Data.SQLite;

namespace GardenPlanner.Edit
{
    public partial class EditJournal : Form
    {
        SqL SQL = new SqL();
        string query;
        int id;
        
        public EditJournal()
        {
            InitializeComponent();
        }

        

        public void populate(string t)
        {
            try
            {
                using (SQL.conn)
                {
                    SQL.conn.Open();
                    this.Text = "EDIT: " + t;
                    query = "Select id from Journal where title = '" + t + "'";
                    SQL.cmd = new SQLiteCommand(query, SQL.conn);

                    using (SQL.cmd)
                    {
                        using (SQL.reader = SQL.cmd.ExecuteReader())
                        {
                            while (SQL.reader.Read())
                            {
                                id = SQL.reader.GetInt32(0);
                            }
                        }
                    }

                    query = "Select title, content from Journal Where title = '" + t + "'";
                    SQL.cmd = new SQLiteCommand(query, SQL.conn);

            
                    using (SQL.cmd)
                    {
                        using (SQL.reader = SQL.cmd.ExecuteReader())
                        {
                            while(SQL.reader.Read())
                            {
                                tbTitle.Text = SQL.reader.GetString(0);
                                tbContent.Text = SQL.reader.GetString(1);
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
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            query = "update Journal set title = '" + tbTitle.Text +"', content = '"+ tbContent.Text + "' Where id = " + id;
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
        }
        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using System;
using System.Windows.Forms;
using System.Data.SQLite;

namespace GardenPlanner.Edit
{
    public partial class EditJob : Form
    {
        SqL SQL = new SqL();
        string query, oldTitle, content;

        public EditJob()
        {
            InitializeComponent();
        }

        public void populate(string t)
        {
            
            this.Text = "EDIT: " + t;
            if(t.Contains("'"))
            {
                t = t.Replace("'", "*A*");
            }
            oldTitle = t;
            try
            {
                using (SQL.conn)
                {
                    SQL.conn.Open();
                    query = "Select job from Job Where job = '" + oldTitle + "'";
                    SQL.cmd = new SQLiteCommand(query, SQL.conn);
                    using (SQL.cmd)
                    {
                        using (SQL.reader = SQL.cmd.ExecuteReader())
                        {
                            while (SQL.reader.Read())
                            {
                                content = SQL.reader.GetString(0).Replace("*A*", "'");
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
            tbContent.Text = content;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            content = tbContent.Text.Replace("'", "*A*");
            SQL.QUERY = "update Job set job = '" + content + "' Where job = '" + oldTitle + "'";
            SQL.queryExecute();
            this.Close();
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}

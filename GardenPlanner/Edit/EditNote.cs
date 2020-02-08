using System;
using System.Windows.Forms;
using System.Data.SQLite;

namespace GardenPlanner.Edit
{
    public partial class EditNote : Form
    {
        SqL SQL = new SqL();
        string query, title, oldTitle, content, list, item;
        int userid;

        public EditNote()
        {
            InitializeComponent();
        }
        public void populate(int i, string t, string tt)
        {
            userid = i;
            list = t;
            item = tt;
            if(item.Contains("'"))
            {
                item = item.Replace("'", "*A*");
            }
            try
            {
                using (SQL.conn)
                {
                    SQL.conn.Open();

                    query = "Select note from '" + list + "' Where noteid = '" + item + "' and userid = '" + userid + "'";
                    SQL.cmd = new SQLiteCommand(query, SQL.conn);


                    using (SQL.cmd)
                    {
                        using (SQL.reader = SQL.cmd.ExecuteReader())
                        {
                            while (SQL.reader.Read())
                            {
                                content = SQL.reader.GetString(0);
                                if(content.Contains("*A*"))
                                {
                                    content = content.Replace("*A*", "'");
                                }
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
            query = "update '" + list + "' set note = '" + content + "' Where noteid = '" + item + "'";
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

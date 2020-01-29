using System;
using System.Windows.Forms;
using System.Data.SQLite;

namespace GardenPlanner.Edit
{
    public partial class EditNote : Form
    {
        SqL SQL = new SqL();
        string query, temp;
        int id;

        public EditNote()
        {
            InitializeComponent();
        }
        public void populate(string t)
        {
            this.Text = "EDIT: " + t;
            try
            {
                using (SQL.conn)
                {
                    SQL.conn.Open();
                    query = "Select id from Vegs where Species = '" + t + "'";
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

                    query = "Select title, content from Note Where title = '" + t + "'";
                    SQL.cmd = new SQLiteCommand(query, SQL.conn);


                    using (SQL.cmd)
                    {
                        using (SQL.reader = SQL.cmd.ExecuteReader())
                        {
                            while (SQL.reader.Read())
                            {
                                tbTitle.Text = SQL.reader.GetString(0);
                                tbContent.Text = SQL.reader.GetString(1);
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            query = "update Note set title = '" + tbTitle.Text + "', content = '" + tbContent.Text + "' Where id = " + id;
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

using System;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Collections.Generic;

namespace GardenPlanner.Edit
{
    public partial class EditJournal : Form
    {
        SqL SQL = new SqL();
        string query, title, oldTitle, content, tag;
        List<string> tags = new List<string>();
        int count;
        public EditJournal()
        {
            InitializeComponent();
        }

        private void btnRemoveTag_Click(object sender, EventArgs e)
        {
            cbTags.SelectedIndex = -1;
        }

        public void populateReadOnly(string t, List<string>tt)
        {
            count = tt.Count;
            for(int i = 0; i < count; i++)
            {
                tags.Add(tt[i]);
            }
            
            this.Text = "Viewing: " + t;
            oldTitle = t.Replace("'", "*A*");
            try
            {
                using (SQL.conn)
                {
                    SQL.conn.Open();
                    query = "Select title, content, tag from Journal Where title = '" + oldTitle + "'";
                    SQL.cmd = new SQLiteCommand(query, SQL.conn);


                    using (SQL.cmd)
                    {
                        using (SQL.reader = SQL.cmd.ExecuteReader())
                        {
                            while (SQL.reader.Read())
                            {
                                title = SQL.reader.GetString(0).Replace("*A*", "'");
                                content = SQL.reader.GetString(1).Replace("*A*", "'");
                                tag = SQL.reader.GetString(2).Replace("*A*", "'");
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
            cbTags.Hide();
            btnRemoveTag.Hide();
            lblTag.Text = tag;
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnSave.Show();
            btnSave.Enabled = true;
            tbTitle.ReadOnly = false;
            tbContent.ReadOnly = false;
            tbContent.BackColor = System.Drawing.Color.White;
            btnEdit.Hide();
            cbTags.Show();
            btnRemoveTag.Show();
            count = tags.Count;
            for(int i = 0; i < count; i++)
            {
                cbTags.Items.Add(tags[i]);
            }
            cbTags.SelectedItem = tag;

            lblTag.Hide();
        }

        
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(cbTags.SelectedIndex == -1)
            {
                tag = "";
            }
            else
            {
                tag = cbTags.SelectedItem.ToString();
            }

            title = tbTitle.Text.Replace("'", "*A*");
            content = tbContent.Text.Replace("'", "*A*");
            query = "update Journal set title = '" + title + "', content = '" + content + "', tag = '" + tag + "' Where title = '" + oldTitle + "'";
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

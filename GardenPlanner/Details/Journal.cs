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

namespace GardenPlanner.Details
{
    public partial class Journal : Form
    {
        SqL SQL = new SqL();
        string query, currentTitle, title, content, tag;
        int userid, count, working;
        List<string> Tags = new List<string>();
        DateTime date;
        public Journal()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            date = DateTime.Now;

            if (cbTags.SelectedIndex == -1)
            {
                tag = "";
            }
            else
            {
                tag = cbTags.SelectedItem.ToString();
            }

            switch(working)
            {
                case 0:
                    string title = tbTitle.Text, content = tbContent.Text;

                    if (title.Contains("'"))
                    {
                        title = title.Replace("'", "*A*");
                    }
                    if (content.Contains("'"))
                    {
                        content = content.Replace("'", "*A*");
                    }

                    query = "update Journal set title = '" + title + "', content = '" + content + "', tag = '" + tag + "' Where title = '" + currentTitle + "' and userid = '" + userid + "'";
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
                    break;


                case 1:
                    
                    string Title = tbTitle.Text, Content = tbContent.Text;

                    if (Title.Contains("'"))
                    {
                        title = Title.Replace("'", "*A*");
                    }
                    if (Content.Contains("'"))
                    {
                        Content = Content.Replace("'", "*A*");
                    }

                    SQL.QUERY = "INSERT INTO Journal (userid, title, content, date, tag) VALUES ('" + userid + "', '" +
                        Title + "', '" + Content + "', '" + date + "', '" + tag + "')";

                    SQL.queryExecute();
                    break;
                default:
                    break;
            }
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            tbTitle.ReadOnly = false;
            tbContent.ReadOnly = false;
            btnSave.Show();
            btnEdit.Hide();
            btnRemoveTag.Show();
            cbTags.Show();
            lblTag.Hide();

            count = Tags.Count();
            for(int i = 0; i < count; i++)
            {
                cbTags.Items.Add(Tags[i]);
            }
            if(lblTag.Text.Length > 1)
            {
                cbTags.SelectedItem = tag;
            }
            else
            {
                cbTags.Text = "Tags";
            }
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRemoveTag_Click(object sender, EventArgs e)
        {
            cbTags.SelectedIndex = -1;

        }

        public void New(List<string> tags, int x)
        {
            working = 1;
            userid = x;
            setTags(tags);

            btnEdit.Hide();
            lblTag.Hide();
        }
        
        public void View(string t, List<string>tags, int x)
        {
            working = 0;
            userid = x;
            setTags(tags);
            currentTitle = t;
            try
            {
                using (SQL.conn)
                {
                    SQL.conn.Open();
                    query = "Select title, content, tag from Journal Where title = '" + currentTitle + "' and userid ='" + userid +"'";
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
            lblTag.Text = tag;
            tbTitle.ReadOnly = true;
            tbContent.ReadOnly = true;
            btnSave.Hide();
            cbTags.Hide();
            btnRemoveTag.Hide();
        }

        private void setTags(List<string> tags)
        {
            count = tags.Count;
            for (int i = 0; i < count; i++)
            {
                cbTags.Items.Add(tags[i]);
            }
        }
    }
}

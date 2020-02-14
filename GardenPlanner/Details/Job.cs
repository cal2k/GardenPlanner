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
    public partial class Job : Form
    {
        SqL SQL = new SqL();

        string content, currentTag, oldcontent, tag, query;
        int username, count, working;

        public Job()
        {
            InitializeComponent();
        }

        public void setup(int i, int ii, List<string> t, string tt)
        {
            username = i;
            count = ii;
            oldcontent = tt;

            for (int x = 0; x < t.Count(); x++)
            {
                cbTag.Items.Add(t[x]);
            }


            switch (count)
            {
                case 0:
                    New();
                    break;
                case 1:
                    View();
                    break;
            }
        }
        private void New()
        {
            btnEdit.Hide();
            lbltag.Hide();
        }

        private void View()
        {
            try
            {
                using (SQL.conn)
                {
                    SQL.conn.Open();
                    query = "Select job, tag from Job Where job = '" + oldcontent + "' and userid ='" + username + "'";
                    SQL.cmd = new SQLiteCommand(query, SQL.conn);


                    using (SQL.cmd)
                    {
                        using (SQL.reader = SQL.cmd.ExecuteReader())
                        {
                            while (SQL.reader.Read())
                            {
                                oldcontent = SQL.reader.GetString(0);
                                tag = SQL.reader.GetString(1);
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

            replaceout();
            tbContent.Text = oldcontent;
            lbltag.Text = tag;

            tbContent.ReadOnly = true;
            btnAdd.Hide();
            cbTag.Hide();
            btnRemoveTag.Hide();
            
        }

        private void btnRemoveTag_Click(object sender, EventArgs e)
        {
            cbTag.SelectedIndex = -1;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnEdit.Hide();
            btnAdd.Show();
            tbContent.BackColor = System.Drawing.Color.White;

            lbltag.Hide();
            cbTag.Show();
            btnRemoveTag.Show();
            cbTag.SelectedItem = tag;
            tbContent.ReadOnly = false;
        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            switch (count)
            {
                case 0:
                    checktag();
                    content = tbContent.Text;
                    replacein();
                    SQL.QUERY = "INSERT INTO Job (userid, job, tag) VALUES ('" + username + "', '" + content + "', '" + currentTag + "')";
                    SQL.queryExecute();

                    this.Close();
                    break;
                case 1:
                    checktag();
                    content = tbContent.Text;
                    replacein();
                    SQL.QUERY = "update Job set job = '" + content + "', tag = '" + currentTag + "' Where job = '" + oldcontent + "' and userid = '" + username +"'";
                    SQL.queryExecute();
                    break;
            }
            this.Close();
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checktag()
        {
            if (cbTag.SelectedIndex == -1)
            {
                currentTag = "";
            }
            else
            {
                currentTag = cbTag.SelectedItem.ToString();
            }
        }

        private void replacein()
        {

            if (content.Contains("'"))
            {
                content = content.Replace("'", "*A*");
            }
        }

        private void replaceout()
        {

            if (oldcontent.Contains("*A*"))
            {
                oldcontent = content.Replace("*A*", "'");
            }
        }
    }
}

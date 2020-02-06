using System;
using System.Linq;
using System.Windows.Forms;
using System.Data.SQLite;

namespace GardenPlanner.New_Entirys
{
    public partial class NewJob : Form
    {
        SqL SQL = new SqL();
        string query, currentTag, temp;
        int userid, contentLimit = 500, contentCurrent = 0, contentRemaining;
        DateTime date;

        public NewJob()
        {
            InitializeComponent();
        }

        public void setUserID(int i)
        {
            userid = i;

            query = "Select tag FROM Tags where userid = '" + userid + "'";
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
                                cbTag.Items.Add(temp);
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
        private void tbContent_TextChanged(object sender, EventArgs e)
        {
            contentCurrent = tbContent.Text.Count();
            contentRemaining = contentLimit - contentCurrent;
            lblContentRemaing.Text = "(" + contentRemaining.ToString() + ")";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbTag.SelectedIndex == -1)
            {
                currentTag = "";
            }
            else
            {
                currentTag = cbTag.SelectedItem.ToString();
            }

            date = DateTime.Now;
            {

            }
            string content = tbContent.Text;
            if(content.Contains("'"))
            {
                content = content.Replace("'", "*A*");
            }

            SQL.QUERY = "INSERT INTO Job (userid, job, date, tag) VALUES ('" + userid + "', '" + content + "', '" + date + "', '" + currentTag + "')";
            SQL.queryExecute();

            this.Close();
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

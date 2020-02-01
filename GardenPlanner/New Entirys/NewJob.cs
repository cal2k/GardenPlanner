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

namespace GardenPlanner.New_Entirys
{
    public partial class NewJob : Form
    {
        string query, currentTag, temp;
        int userid, titleLimit = 50, titleCurrent = 0, titleRemaining, contentLimit = 1000, contentCurrent = 0, contentRemaining;

        static string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            pathComplete = path + @"\CGP\GardenDB.db";
        
        SQLiteConnection conn = new SQLiteConnection("Data Source =" + pathComplete + "; version =3;");
        SQLiteCommand cmd;
        SQLiteDataReader reader;
        DateTime date;

        public NewJob()
        {
            InitializeComponent();
        }

        public void setUserID(int i)
        {
            userid = i;

            query = "Select tag FROM Tags where userid = '" + userid + "'";
            cmd = new SQLiteCommand(query, conn);
            try
            {
                using (conn)
                {
                    conn.Open();
                    using (cmd)
                    {
                        using (reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                temp = reader.GetString(0);
                                cbTag.Items.Add(temp);
                            }
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tbTitle_Click(object sender, EventArgs e)
        {
            if (tbTitle.Text == "Title")
            {
                tbTitle.Text = "";
            }
        }
        private void tbTitle_TextChanged(object sender, EventArgs e)
        {
            titleCurrent = tbTitle.Text.Count();
            titleRemaining = titleLimit - titleCurrent;
            lblTitleRemaining.Text = "(" + titleRemaining.ToString() + ")";

            if (titleCurrent > 3)
            {
                tbContent.Enabled = true;
            }
        }
        private void tbContent_Click(object sender, EventArgs e)
        {
            if (tbContent.Text == "Details")
            {
                tbContent.Text = "";
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
            string title = tbTitle.Text.Replace("'", ".a"), content = tbContent.Text.Replace("'", ".a");
            query = "INSERT INTO Job (userid, title, content, date, tag) VALUES ('" + userid + "', '" +
               title + "', '" + content + "', '" + date + "', '" + currentTag + "')";

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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            this.Close();
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

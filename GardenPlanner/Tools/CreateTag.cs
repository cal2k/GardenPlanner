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

namespace GardenPlanner
{
    public partial class CreateTag : Form
    {
        string tag, query;
        int limit = 30, current, remaining, userid, count;

        static string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            pathComplete = path + @"\CGP\GardenDB.db";
        SQLiteConnection conn = new SQLiteConnection("Data Source =" + pathComplete + "; version =3;");
        SQLiteCommand cmd;
        SQLiteDataReader reader;

        public CreateTag()
        {
            InitializeComponent();
        }
        public void setID(int i)
        {
            userid = i;;
        }
        private void tbTag_Click(object sender, EventArgs e)
        {
            if(tbTag.Text == "Tag name")
            {
                tbTag.Text = "";
            }
        }

        private void tbTag_TextChanged(object sender, EventArgs e)
        {
            current = tbTag.Text.Length;
            remaining = limit - current;
            lblRemaning.Text = "(" + remaining + ")";

            if(tbTag.Text.Length > 3)
            {
                btnAddTag.Enabled = true;
            }
        }

        private void btnAddTag_Click(object sender, EventArgs e)
        {
            try
            {
                using (conn)
                {
                    conn.Open();
                    tag = tbTag.Text.ToString();
                    query = "Select count (tag) from Tags where tag = '" + tag + "'";
                    cmd = new SQLiteCommand(query, conn);

                    using (cmd)
                    {
                        using (reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                count = reader.GetInt32(0);
                            }
                        }
                    }

                    if (count == 0)
                    {
                        query = "INSERT INTO Tags (userid, tag) VALUES ('" + userid + "', '" + tag + "')";
                        cmd = new SQLiteCommand(query, conn);
                        using (cmd)
                        {
                            cmd.ExecuteNonQuery();
                            tbTag.Text = "Tag name";
                            btnAddTag.Enabled = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("The tag " + tag + " already exsitis");
                        tbTag.Text = "Tag name";
                        btnAddTag.Enabled = false;
                    }
                    conn.Close();
                }
                btnAddTag.Enabled = false;
            }
            catch(Exception ex)
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

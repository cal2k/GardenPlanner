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
    public partial class Note : Form
    {
        public Note()
        {
            InitializeComponent();
        }

        SqL SQL = new SqL();

        int userid, count = 0;
        string query,currentlist, currentitem, noteid, content, list, item;

        private void btnEdit_Click(object sender, EventArgs e)
        {
            tbContent.ReadOnly = false;
            btnSave.Show();
            btnEdit.Hide();
        }

        public void setUserID(int i, string List, string Item)
        {
            userid = i;
            currentlist = List;
            currentitem = Item;
        }
        

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            switch(count)
            {
                case 0:
                    string content = tbContent.Text;
                    if (content.Contains("'"))
                    {
                        content = content.Replace("'", "*A*");
                    }
                    query = "INSERT INTO '" + currentlist + "' (userid, note, noteid) VALUES ('" + userid + "', '" + content + "','" + currentitem + "')";
                    SQL.cmd = new SQLiteCommand(query, SQL.conn);
                    try
                    {
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
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    break;
                case 1:
                    content = tbContent.Text.Replace("'", "*A*");
                    query = "update '" + list + "' set note = '" + content + "' Where noteid = '" + item + "' and note ='" + noteid + "'";
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
                default:
                    break;
            }
           

            this.Close();
        }

        public void populate(int i, string t, string tt, string ttt)
        {
            count = 1;
            userid = i;
            list = t;
            item = tt;
            noteid = ttt;

            tbContent.ReadOnly = true;
            btnSave.Hide();

            if (item.Contains("'"))
            {
                item = item.Replace("'", "*A*");
            }
            try
            {
                using (SQL.conn)
                {
                    SQL.conn.Open();

                    query = "Select note from '" + list + "' Where noteid = '" + item + "' and userid = '" + userid + "' and note = '" + noteid + "'";
                    SQL.cmd = new SQLiteCommand(query, SQL.conn);


                    using (SQL.cmd)
                    {
                        using (SQL.reader = SQL.cmd.ExecuteReader())
                        {
                            while (SQL.reader.Read())
                            {
                                content = SQL.reader.GetString(0);
                                if (content.Contains("*A*"))
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



    }
}

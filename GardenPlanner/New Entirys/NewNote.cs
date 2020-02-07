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
    public partial class NewNote : Form
    {
        SqL SQL = new SqL();
        string currentTag, temp, query, currentlist, currentitem;
        int userid, contentLimit = 1000, contentCurrent = 0, contentRemaining;
        
        DateTime date;

        public NewNote()
        {
            InitializeComponent();
        }

        public void setUserID(int i, string List, string Item)
        {
            userid = i;
            currentlist = List;
            currentitem = Item;
        }
        private void tbContent_TextChanged(object sender, EventArgs e)
        {
            contentCurrent = tbContent.Text.Count();
            contentRemaining = contentLimit - contentCurrent;
            lblContentRemaing.Text = "(" + contentRemaining.ToString() + ")";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            date = DateTime.Now;
            string content = tbContent.Text;
            if(content.Contains("'"))
            {
                content = content.Replace("'", "*A*");
            }
            query = "INSERT INTO '"+ currentlist + "' (userid, note, noteid) VALUES ('"+ userid +"', '" + content + "','" + currentitem +"')";
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

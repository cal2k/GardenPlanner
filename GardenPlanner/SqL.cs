using System;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

using System.Collections.Generic;

namespace GardenPlanner
{
    class SqL
    {
        public static string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), pathComplete = path + @"\CGP\GardenDB.db";

        public SQLiteConnection conn = new SQLiteConnection("Data Source =" + pathComplete + "; version =3;");
        public SQLiteCommand cmd;
        public SQLiteDataReader reader;

        private string query, temp, userName;
        private int count, userID;

        public string QUERY
        {
            set { query = value; }
        }
        public string USERNAME
        {
            get { return userName; }
        }
        public int USERID
        {
            get { return userID; }
        }
            

        //Querys
        public void queryExecute()
        {
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        public void queryCount()
        {
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
                                count = reader.GetInt32(0);
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
        public void queryInsert()
        {
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
        }
        //Querys END

        //Startup
        public void checkfordb()
        {
            string fileToCopy = "GardenDB.db";

            //check if database exists 
            if (File.Exists(pathComplete) == false)
            {
                System.IO.Directory.CreateDirectory(path + @"\CGP");
                File.Copy(fileToCopy, pathComplete);
            }
        }
        public void gatherusername()
        {
            string[] UserNameSplit = new string[2];
            temp = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            UserNameSplit = temp.Split('\\');
            userName = UserNameSplit[1].ToLower();
            checkusernamedetails();
        }
        public void checkusernamedetails()
        {
            query = "SELECT COUNT (username) from users WHERE username = '" + userName + "'";
            queryCount();
            if (count == 0)
            {
                query = "INSERT INTO  users (username) VALUES ('" + userName + "')";
                queryInsert();
            }
            query = "select ID from users where username = '" + userName + "'";
            queryCount();
            userID = count;
        }
        //Startup END
    }
}

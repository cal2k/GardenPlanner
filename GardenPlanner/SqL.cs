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
        public bool tutorial = true;

        private string query, temp, userName;
        private int count, userID, currentVersion, nextVersion;
        public static int dbV = 2;



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
            else
            {
                checkVersion();
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
                queryExecute();
                tutorial = false;
            }
            query = "select ID from users where username = '" + userName + "'";
            queryCount();
            userID = count;
        }

        public void checkVersion()
        {
            query = "SELECT number FROM dbVersion";
            queryCount();
            currentVersion = count;
            
            while (currentVersion < dbV)
            {
                try
                {
                    applyUpdate();
                }
                catch (Exception exception)
                {
                    Console.WriteLine("The updates didn't apply: " + exception.ToString());
                    break;
                }
            }

        }

        private void applyUpdate()
        {
            nextVersion = currentVersion + 1;
            string upgradeFile = "update_" + currentVersion + "_to_" + nextVersion + ".sql";

            if (!System.IO.File.Exists(upgradeFile))
            {
                MessageBox.Show("Update file " + upgradeFile + " does not exist");
            }
            string upgradeSQL = System.IO.File.ReadAllText(upgradeFile);
            query = upgradeSQL;
            queryExecute();

            query = "SELECT number FROM dbVersion";
            queryCount();
            currentVersion = count;
        }
        //Startup END
    }
}

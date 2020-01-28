using System;
using System.Data.SQLite;

namespace GardenPlanner
{
    class SqL
    {
        static string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            pathComplete = path + @"\CGP\GardenDB.db";
        public SQLiteConnection conn = new SQLiteConnection("Data Source =" + pathComplete + "; version =3;");
        public SQLiteCommand cmd;
        public SQLiteDataReader reader;
    }
}

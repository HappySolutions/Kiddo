using System;
using System.IO;

using Kiddo1.Persistance;
using SQLite;

namespace Kiddo1.Droid.Persistance
{
    public class SQLiteDb : ISQLiteDb
    {
        private SQLiteConnection Connection { get; set; }

        public SQLiteConnection GetConnection()
        {
            if (this.Connection != null) { return this.Connection; }

            var path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            path = Path.Combine(path, "Kiddo.db3");
            return this.Connection = new SQLiteConnection(path);
        }
    }
}
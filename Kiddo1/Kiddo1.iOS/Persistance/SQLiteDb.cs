using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Foundation;
using Kiddo1.Persistance;
using SQLite;
using UIKit;

namespace Kiddo1.iOS.Persistance
{
    public class SQLiteDb : ISQLiteDb
    {
        private SQLiteConnection Connection { get; set; }

        public SQLiteConnection GetConnection()
        {
            if (this.Connection != null) { return this.Connection; }

            var path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            path = Path.Combine(path, "..", "Library", "Kiddo.db3");
            return this.Connection = new SQLiteConnection(path);
        }
    }
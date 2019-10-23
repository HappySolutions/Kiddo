using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kiddo1.Persistance
{
    public interface ISQLiteDb
    {
        SQLiteConnection GetConnection();
    }
}

using System;
using SQLite;

namespace FloodPing
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}
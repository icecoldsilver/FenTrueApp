using SQLite;

namespace FenTrue
{
    public interface ISQLiteDb
    {
        SQLiteAsyncConnection GetConnection();
    }
}


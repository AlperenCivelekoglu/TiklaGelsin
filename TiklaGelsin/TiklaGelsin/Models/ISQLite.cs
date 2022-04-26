using System;
using System.Collections.Generic;
using System.Text;
using SQLite;


namespace TiklaGelsin.Models
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}

using SampleAppBatch3.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xamarin.Essentials;

namespace SampleAppBatch3.DAL
{
    public class DataAccess
    {
        private SQLiteConnection _conn;
        public SQLiteConnection GetConn()
        {
            SQLiteConnection conn;
            var dbName = "MyDb.db3";
            var dbPath = Path.Combine(FileSystem.AppDataDirectory, dbName);
            conn = new SQLiteConnection(dbPath);
            return conn;
        }

        public DataAccess()
        {
            _conn = GetConn();
            _conn.CreateTable<Employee>();
        }
    }
}

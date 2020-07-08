using SampleAppBatch3.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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

        public IEnumerable<Employee> GetAllEmployee()
        {
            //return _conn.Query<Employee>("select * from Employee order by EmpName asc");
            //var results = _conn.Table<Employee>().OrderBy(e => e.EmpName);
            var result = from e in _conn.Table<Employee>()
                         orderby e.EmpName
                         select e;

            return result;
        }

        public int InsertEmployee(Employee employee)
        {
            var result = 
        }
    }
}

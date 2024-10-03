using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class DBSingleton
    {
        private static DBSingleton instance { get; set; }

        public string ConnectionString { get; set; }

        private DBSingleton(string connection)
        {
            ConnectionString = connection;
        }

        public DBSingleton getInstance(string connection)
        {
            if (instance == null)
            {
                instance = new DBSingleton(connection);
            }

            return instance;
        }
    }
}

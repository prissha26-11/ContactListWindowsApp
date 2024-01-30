using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLite_Database_Project
{
    public class AppSetting
    {
        public static string ConnectionString()
        {
            return "Data Source=test.db;Version=3";
        }
    }
}

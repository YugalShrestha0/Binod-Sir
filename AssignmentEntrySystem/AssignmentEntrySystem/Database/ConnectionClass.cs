using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace AssignmentEntrySystem.Database
{
    class ConnectionClass
    {
        public static String ConnectionString
        {
            get
            {
                return @"Data Source=YUGAL\MSSQLSERVER01;Initial Catalog=AssignmentEntrySystem;Integrated Security=True";
            }
        }
    }
}

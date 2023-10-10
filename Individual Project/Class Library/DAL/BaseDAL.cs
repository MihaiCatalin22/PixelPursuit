using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Class_Library.DAL
{
    public class BaseDAL
    {
        protected const string CONNECTION_STRING = "Server = mssqlstud.fhict.local; Database = dbi500157_dbind2; User Id = dbi500157_dbind2; Password = individual2023;";

        protected BaseDAL()
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace TransactionForm4
{
     class NamesDataAccess
    {
        public List<Names> GetNames(string id)
        {
            List<Names> Reader = new List<Names>();
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings["IM"].ConnectionString))
            {
                Reader = connection.Query<Names>($"SELECT FirstName, LastName FROM Customers WHERE ID = '{id}'").ToList();
                return Reader;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;
using System.Configuration;
using Dapper;

namespace TransactionForm4
{
    class CityDataAccess
    {
        public List<Cities> GetCity(string id)
        {
            List<Cities> Reader = new List<Cities>();
            using (DbConnection connection = new System.Data.SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings["IM"].ConnectionString))
            {
                Reader = connection.Query<Cities>($"SELECT * FROM Customers1 WHERE CustomerID = '{id}'").ToList();
                return Reader;
            }

        }
    }
}

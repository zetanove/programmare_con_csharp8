using System;
using System.Data;
using System.Data.SqlClient;

namespace DisconnectedADO_NetCore
{
    class Program
    {
        static void Main(string[] args)
        {
            string connString = "Server=.;Integrated Security=true;database=WideWorldImporters";

            DataSet ds = new DataSet();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Sales.Orders", conn);
                adapter.Fill(ds, "Products");
            }

        }
    }
}

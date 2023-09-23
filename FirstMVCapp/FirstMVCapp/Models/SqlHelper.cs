using System.Data.SqlClient;

namespace FirstMVCapp.Models
{
    public class SqlHelper
    {
        public static SqlConnection CreateConnection()
        {            var connString = @"server =200411LTP2823\SQLEXPRESS; database = testDB ; integrated security=true; Encrypt=false";

            SqlConnection sqlcn = new SqlConnection(connString);
            return sqlcn;
        }
    }
}

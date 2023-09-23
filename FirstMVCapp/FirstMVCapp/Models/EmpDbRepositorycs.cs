using System.Data.SqlClient;
using System.Data;
namespace FirstMVCapp.Models
{
    public class EmpDbRepositorycs
    {
        public static List<EmpTable> GetEmpList()
        {
            // These are null methods. We use this if we dont want to override all the methods only want to read particular number of methods.
            List<EmpTable> empList = new List<EmpTable>();
            using (SqlConnection cn = SqlHelper.CreateConnection())
            {
                if (cn.State != ConnectionState.Open)
                {
                    cn.Open();
                }
                SqlCommand selectempcmd = cn.CreateCommand();
                String selectAllEmps = "Select * from emptbl";
                selectempcmd.CommandText = selectAllEmps;
                SqlDataReader empdr = selectempcmd.ExecuteReader();
                while (empdr.Read())
                {
                    EmpTable emp = new EmpTable
                    {
                        Id = empdr.GetInt32(0),
                        name = empdr.GetString(1),
                        salary = empdr.GetDecimal(2),
                        city = empdr.GetString(3)
                    };
                    empList.Add(emp);
                }
                return empList;

            }
                return null;
        }
        //public static EmpDbRepositorycs GetEmpById(int id)
        //{
        //    EmpTable empFound = null;
        //    using (SqlConnection cn = SqlHelper.CreateConnection())
        //    {
        //        if (cn.State != ConnectionState.Open) { cn.Open(); }

        //        SqlCommand selectempcmd = cn.CreateCommand();
        //        String selectEmps = "Select * from emptbl where eno=@id";
        //        selectempcmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
        //        selectempcmd.CommandText = selectEmps;
        //        SqlDataReader empdr = selectempcmd.ExecuteReader();
        //        while (empdr.Read())
        //        {
        //             empFound = new EmpTable
        //            {
        //                Id = empdr.GetInt32(0),
        //                name = empdr.GetString(1),
        //                salary = empdr.GetDecimal(2),
        //                city = empdr.GetString(3)
        //            };
        //        }
        //    }
        //    return empFound;

        //}

        public static EmpTable  GetEmpById(int id)
        {
            EmpTable empFound = null;
            using (SqlConnection cn = SqlHelper.CreateConnection())
            {
                if (cn.State != System.Data.ConnectionState.Open)
                    cn.Open();
                SqlCommand selectempcmd = cn.CreateCommand();
                String selectEmp = "Select * from emptbl where eno=@id";
                selectempcmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                selectempcmd.CommandText = selectEmp;
                SqlDataReader empdr = selectempcmd.ExecuteReader();
                while (empdr.Read())
                {
                    empFound = new EmpTable
                    {
                        Id = empdr.GetInt32(0),
                        name = empdr.GetString(1),
                        salary = empdr.GetDecimal(2),
                        city = empdr.GetString(3)
                    };
                }
            }
            return empFound;
        }
        public static  int AddNewEmp(EmpTable newEmp)
        {
            int query_result = 0;
            using (SqlConnection cn = SqlHelper.CreateConnection())
            {
                if (cn.State != ConnectionState.Open)
                {
                    cn.Open();
                }
                SqlCommand insertEmpcmd = cn.CreateCommand();
                String insertNewEmpQuery = "insert into emptbl values( @id,@name,@salary,@city)";
                insertEmpcmd.Parameters.Add("@id", SqlDbType.Int).Value = newEmp.Id;
                insertEmpcmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = newEmp.name;
         
              
                insertEmpcmd.Parameters.Add("@city", SqlDbType.NVarChar).Value = newEmp.city;
                insertEmpcmd.Parameters.Add("@salary", SqlDbType.Decimal).Value = newEmp.salary;
                insertEmpcmd.CommandText = insertNewEmpQuery;
                query_result = insertEmpcmd.ExecuteNonQuery();
            }
            return query_result;
        }
        public static int UpdateEmp(EmpTable modifiesEmp)
        {
            int query_result = 0;
            using (SqlConnection cn = SqlHelper.CreateConnection())
            {
                if (cn.State != ConnectionState.Open)
                {
                    cn.Open();
                }
                SqlCommand updateEmpcmd = cn.CreateCommand();
                String updateEmpQuery = "Update emptbl set name=@name, salary=@salary, city=@city where eno=@id";
                updateEmpcmd.Parameters.Add("@id", SqlDbType.Int).Value = modifiesEmp.Id;
                updateEmpcmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = modifiesEmp.name;
                updateEmpcmd.Parameters.Add("@salary", SqlDbType.Decimal).Value = modifiesEmp.salary;
                updateEmpcmd.Parameters.Add("@city", SqlDbType.NVarChar).Value = modifiesEmp.city;
                
                updateEmpcmd.CommandText = updateEmpQuery;
                query_result = updateEmpcmd.ExecuteNonQuery();
            }
            return query_result;
        }
        public static int DeletEmp(int id)
        {
            int query_result = 0;
            using (SqlConnection cn = SqlHelper.CreateConnection())
            {
                if (cn.State != ConnectionState.Open)
                {
                    cn.Open();
                }
                SqlCommand deleteEmpcmd = cn.CreateCommand();
                String deleteEmpQuery = "Delete from emptbl where eno=@id";
                deleteEmpcmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                deleteEmpcmd.CommandText = deleteEmpQuery;
                query_result = deleteEmpcmd.ExecuteNonQuery();
            }
            return query_result;
        }
    }
}

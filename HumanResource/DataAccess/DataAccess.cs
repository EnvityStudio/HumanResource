using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResource.DataAccess
{
    class DataAccess
    {
        public static string stringConnection = @"";
        public static SqlConnection con = new SqlConnection(stringConnection);
        public static void NonQuery(string query, params SqlParameter[] param)
        {
            con.Open();
            SqlCommand sc = new SqlCommand(query, con);
            if (!query.Contains(' '))
            {
                sc.CommandType = CommandType.StoredProcedure;
                param.ToList().ForEach(x => sc.Parameters.Add(x));
            }
            else
                sc.CommandType = CommandType.Text;
            sc.ExecuteNonQuery();
            con.Close();
        }
        public static DataTable Query(string query, params SqlParameter[] param)
        {
            DataTable dt = null;
            SqlDataAdapter da = null;
            con.Open();
            if (query.Contains(" "))
            {
                da = new SqlDataAdapter(query, con);
            }
            else
            {
                SqlCommand sc = new SqlCommand(query, con);
                sc.CommandType = CommandType.StoredProcedure;
                param.ToList().ForEach(x => sc.Parameters.Add(x));
                da = new SqlDataAdapter(sc);
            }
            da.Fill(dt);
            con.Close();
            return dt;
        }
    }
}

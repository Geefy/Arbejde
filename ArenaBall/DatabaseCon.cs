using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows;

namespace ArenaBall
{
    class DatabaseCon
    {
        
            SqlConnection sqlCon = new SqlConnection(@"DATA SOURCE= ZBC-EMA-1617; Initial Catalog = Characters; Integrated Security=True;");
      

        public void OpenCon()
        {
            sqlCon.Open(); 
        }
        public void CloseCon()
        {
            sqlCon.Close();
        }

        public DataTable GetData(string query)
        {
            DataTable dt = new DataTable();

            SqlCommand cmd = new SqlCommand(query, sqlCon);

            try
            {
                this.OpenCon();
                dt.Load(cmd.ExecuteReader());
            }
            catch(SqlException s)
            {
                throw s;
            }
            finally
            {
                this.CloseCon();
            }

            return dt;
        }


    }

}


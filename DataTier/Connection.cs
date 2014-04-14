using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace BusinessTier
{
    class Connection
    {
        public static SqlConnection GetConnection()
        {
            string SConnectionString = "Data Source=Q6600IN-PC;Initial Catalog=University;Persist Security Info=True;User ID=sa;Password=nimda@123";            
            SqlConnection Con = new SqlConnection(SConnectionString); 
            return Con;
        }
    }
}

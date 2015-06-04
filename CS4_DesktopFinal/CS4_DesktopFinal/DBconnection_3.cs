using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace CS4_DesktopFinal
{
    class DBconnection
    {

        public SqlConnection con;
        public string constr;
        public void connection()
        {
            //DataBase Connection Details  
            constr = "Data Source=VITHAL;Initial Catalog=C#corner;User Id=sa;Password=swift";
            con = new SqlConnection(constr);
            con.Open();

        } 
    }
}

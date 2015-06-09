using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace CS4_DesktopFinal
{
    public class DBconnection
    {

        public SqlConnection con;
        public string constr;
        public void connection()
        {
            //DataBase Connection Details  
            constr = "Data Source=Database;Initial Catalog=CS4_DesktopFinal;username=admin;password=23424";
            con = new SqlConnection(constr);
            con.Open();

        }   

    }
}

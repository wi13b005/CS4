using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace CS4_DesktopFinal.Views
{
    
    public class DBconnection
    {

        public SqlConnection con;
        public string constr;
        public void connection()
        {
            //DataBase Connection Details  
            constr = "Data Source=Database;Initial Catalog=CS4_DesktopFinal;username=tcmexpert;password=23432";
            con = new SqlConnection(constr);
            con.Open();

        } 

    }
}

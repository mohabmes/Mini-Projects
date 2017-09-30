using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Sales_Management.BL
{
    using Sales_Management.DAL;

    class LoginCheck
    {
        DataAccessLayer Con = new DataAccessLayer();  
        public DataTable Login(string ID , string PWD)
        {
            SqlParameter[] Param = new SqlParameter[2];
            Param[0] = new SqlParameter("ID", SqlDbType.VarChar, 50);
            Param[0].Value = ID;
            Param[1] = new SqlParameter("PWD", SqlDbType.VarChar, 50);
            Param[1].Value = PWD;
            Con.Open();
            DataTable DT = new DataTable();
            DT = Con.SelectData("Login", Param);
            Con.Close();
            return DT;
        }
        public void AddUser(string ID, string Username, string PWD, string UserType)
        {
            SqlParameter[] Param = new SqlParameter[4];
            Param[0] = new SqlParameter("@ID", SqlDbType.VarChar);
            Param[0].Value = ID;
            Param[1] = new SqlParameter("@PWD", SqlDbType.VarChar);
            Param[1].Value = PWD;
            Param[2] = new SqlParameter("@UserType", SqlDbType.VarChar);
            Param[2].Value = UserType;
            Param[3] = new SqlParameter("@Username", SqlDbType.VarChar);
            Param[3].Value = Username;

            Con.ExecuteCommand("AddUser", Param);
        }
    }
}

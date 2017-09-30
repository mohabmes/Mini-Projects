using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Sales_Management.BL
{
    class Clients
    {
        DAL.DataAccessLayer Conn = new DAL.DataAccessLayer();

        public void AddClient(  int ID_Customer, string First_Name, string Second_Name, int Telephone,
                                string Email, byte[] Pic)
        {
            SqlParameter[] Param = new SqlParameter[6];
            Param[0] = new SqlParameter("@ID_Customer", SqlDbType.Int);
            Param[0].Value = ID_Customer;
            Param[1] = new SqlParameter("@First_Name", SqlDbType.VarChar);
            Param[1].Value = First_Name;
            Param[2] = new SqlParameter("@Second_Name", SqlDbType.VarChar);
            Param[2].Value = Second_Name;
            Param[3] = new SqlParameter("@Telephone", SqlDbType.NChar);
            Param[3].Value = Telephone;
            Param[4] = new SqlParameter("@Email", SqlDbType.VarChar);
            Param[4].Value = Email;
            Param[5] = new SqlParameter("@Image_Customer", SqlDbType.Image);
            Param[5].Value = Pic;

            Conn.ExecuteCommand("AddClient", Param);
        }
        public void UpdateClient(int ID, string First_Name, string Second_Name, int Telephone,
                               string Email, byte[] Pic)
        {
            SqlParameter[] Param = new SqlParameter[6];
            Param[0] = new SqlParameter("@ID", SqlDbType.Int);
            Param[0].Value = ID;
            Param[1] = new SqlParameter("@First_Name", SqlDbType.VarChar);
            Param[1].Value = First_Name;
            Param[2] = new SqlParameter("@Second_Name", SqlDbType.VarChar);
            Param[2].Value = Second_Name;
            Param[3] = new SqlParameter("@Telephone", SqlDbType.NChar);
            Param[3].Value = Telephone;
            Param[4] = new SqlParameter("@Email", SqlDbType.VarChar);
            Param[4].Value = Email;
            Param[5] = new SqlParameter("@Image_Customer", SqlDbType.Image);
            Param[5].Value = Pic;

            Conn.ExecuteCommand("UpdateClient", Param);
        }
        public void DeleteClient(int ID)
        {
            SqlParameter[] Param = new SqlParameter[1];
            Param[0] = new SqlParameter("@ID", SqlDbType.Int);
            Param[0].Value = ID;
            Conn.ExecuteCommand("DeleteClient", Param);
        }
        public DataTable GetAllClients()
        {
            DataTable DT = new DataTable();
            DT = Conn.SelectData("GetAllClients", null);
            return DT;
        }

        public DataTable SearchClients(string Search)
        {
            SqlParameter[] Param = new SqlParameter[1];
            Param[0] = new SqlParameter("@Search", SqlDbType.VarChar);
            Param[0].Value = Search;
            DataTable DT = new DataTable();
            DT = Conn.SelectData("SearchClientDetails", Param);
            return DT;
        }

    }
}

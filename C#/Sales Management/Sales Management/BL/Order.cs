using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Sales_Management.BL
{        

    class Order
    {
        DAL.DataAccessLayer Conn = new DAL.DataAccessLayer();

        public DataTable GetTheLastOrderID()
        {
            DAL.DataAccessLayer Con = new DAL.DataAccessLayer();
            DataTable DT = new DataTable();
            DT = Conn.SelectData("GetTheLastOrderID", null);
            return DT;
        }
        public DataTable GetAllOrders()
        {
            DAL.DataAccessLayer Con = new DAL.DataAccessLayer();
            DataTable DT = new DataTable();
            DT = Con.SelectData("GetAllOrders", null);
            return DT;
        }
        public DataTable GetOrder(string ID_Order)
        {
            DataTable DT = new DataTable();
            SqlParameter[] Param = new SqlParameter[1];
            Param[0] = new SqlParameter("@ID_order", SqlDbType.Int);
            Param[0].Value = ID_Order;
            DT = Conn.SelectData("GetOrder", Param);
            Conn.Close();
            return DT;
        }
        public DataTable GetOrderDetails(string ID_Order)
        {
            DataTable DT = new DataTable();
            SqlParameter[] Param = new SqlParameter[1];
            Param[0] = new SqlParameter("@ID_order", SqlDbType.Int);
            Param[0].Value = ID_Order;
            DT = Conn.SelectData("GetOrderDetails", Param);
            Conn.Close();
            return DT;
        }
        public DataTable GetAllClients()
        {
            DataTable DT = new DataTable();
            DT = Conn.SelectData("GetAllClients", null);
            return DT;
        }
        
        public DataTable GetAllProducts()
        {
            DAL.DataAccessLayer Con = new DAL.DataAccessLayer();
            DataTable DT = new DataTable();
            DT = Con.SelectData("GetAllProducts", null);
            return DT;
        }

        public void AddOrder(int ID_Order, DateTime Date_Order, int ID_Customer, string Description, string Username)
        {
            SqlParameter[] Param = new SqlParameter[5];
            Param[0] = new SqlParameter("@ID_Order", SqlDbType.Int);
            Param[0].Value = ID_Order;
            Param[1] = new SqlParameter("@Date_Order", SqlDbType.DateTime);
            Param[1].Value = Date_Order;
            Param[2] = new SqlParameter("@ID_Customer", SqlDbType.Int);
            Param[2].Value = ID_Customer;
            Param[3] = new SqlParameter("@Description", SqlDbType.NChar);
            Param[3].Value = Description;
            Param[4] = new SqlParameter("@Username", SqlDbType.VarChar);
            Param[4].Value = Username;

            Conn.ExecuteCommand("AddOrder", Param);
        }
        public void AddOrderDetails(string ID_Product, int ID_Order, int Quantity, string Price, Double Discount, string Amount, string Total_Amount)
        {
            SqlParameter[] Param = new SqlParameter[7];
            Param[0] = new SqlParameter("@ID_Product", SqlDbType.VarChar);
            Param[0].Value = ID_Product;
            Param[1] = new SqlParameter("@ID_Order", SqlDbType.Int);
            Param[1].Value = ID_Order;
            Param[2] = new SqlParameter("@Quantity", SqlDbType.Int);
            Param[2].Value = Quantity;
            Param[3] = new SqlParameter("@Price", SqlDbType.VarChar);
            Param[3].Value = Price;
            Param[4] = new SqlParameter("@Discount", SqlDbType.Float);
            Param[4].Value = Discount;
            Param[5] = new SqlParameter("@Amount", SqlDbType.VarChar);
            Param[5].Value = Amount;
            Param[6] = new SqlParameter("@Total_Amount", SqlDbType.VarChar);
            Param[6].Value = Total_Amount;
            Conn.ExecuteCommand("AddOrderDetails", Param);
        }
        public DataTable VerifyQuantity(string ID , int Quan)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable DT = new DataTable();
            SqlParameter[] Param = new SqlParameter[2];
            Param[0] = new SqlParameter("@ID", SqlDbType.VarChar);
            Param[0].Value = ID;
            Param[1] = new SqlParameter("@Quan", SqlDbType.Int);
            Param[1].Value = Quan;

            DT = Conn.SelectData("VerifyQuantity", Param);
            DAL.Close();
            return DT;
        }
        public DataTable ReportOrder(string ID_order)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable DT = new DataTable();
            SqlParameter[] Param = new SqlParameter[1];
            Param[0] = new SqlParameter("@ID_order", SqlDbType.Int);
            Param[0].Value = ID_order;

            DT = Conn.SelectData("ReportOrder", Param);
            DAL.Close();
            return DT;
        }
        public DataTable SearchOrder(string Search)
        {
            DataTable Dt = new DataTable();
            SqlParameter[] Param = new SqlParameter[1];
            Param[0] = new SqlParameter("@Search", SqlDbType.VarChar);
            Param[0].Value = Search;
            Dt = Conn.SelectData("SearchOrder", Param);
            Conn.Close();
            return Dt;
        }
    }
}
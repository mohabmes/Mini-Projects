using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Sales_Management.BL
{
    class Product
    {
        //This Method Get All Categories Name to fill the cmbb_CategoryID
        public DataTable GetAllCategories()
        {
            DAL.DataAccessLayer Con = new DAL.DataAccessLayer();
            DataTable DT = new DataTable();
            DT = Con.SelectData("GetAllCategories", null);
            return DT;
        }
        //Method To add new product
        public void AddProduct(string ID_Product, string Label_Product, int Quantity, string Price, byte[] Image, int ID_Category)
        {
            DAL.DataAccessLayer Con = new DAL.DataAccessLayer();
            Con.Open();
            SqlParameter[] Param = new SqlParameter[6];
            Param[0] = new SqlParameter("@ID_Product", SqlDbType.VarChar);
            Param[0].Value = ID_Product;
            Param[1] = new SqlParameter("@Label_Product", SqlDbType.VarChar);
            Param[1].Value = Label_Product;
            Param[2] = new SqlParameter("@Quantity", SqlDbType.Int);
            Param[2].Value = Quantity;
            Param[3] = new SqlParameter("@Price", SqlDbType.VarChar);
            Param[3].Value = Price;
            Param[4] = new SqlParameter("@Image", SqlDbType.Image);
            Param[4].Value = Image;
            Param[5] = new SqlParameter("@ID_Category", SqlDbType.Int);
            Param[5].Value = ID_Category;
            Con.ExecuteCommand("AddProduct", Param); Con.Close();
        }
        //Verify Product ID (warn For any replication)
        public DataTable VerifyProductID(string ID)
        {
            DAL.DataAccessLayer Con = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] Param = new SqlParameter[1];
            Param[0] = new SqlParameter("@ID", SqlDbType.VarChar);
            Param[0].Value = ID;
            Dt = Con.SelectData("VerifyProductID", Param);
            return Dt;
        }
        //This Method GetAllProducts Names to fill the dataGridView
        public DataTable GetAllProducts()
        {
            DAL.DataAccessLayer Con = new DAL.DataAccessLayer();
            DataTable DT = new DataTable();
            DT = Con.SelectData("GetAllProducts", null);
            return DT;
        }
        //Search in Product Table
        public DataTable SearchProduct(string Search)
        {
            DAL.DataAccessLayer Con = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] Param = new SqlParameter[1];
            Param[0] = new SqlParameter("@Search", SqlDbType.VarChar);
            Param[0].Value = Search;
            Dt = Con.SelectData("SearchProduct", Param);
            return Dt;
        }
        //Method To Delete new product
        public void DeleteProduct(string ID)
        {
            DAL.DataAccessLayer Con = new DAL.DataAccessLayer();
            Con.Open();
            SqlParameter[] Param = new SqlParameter[1];
            Param[0] = new SqlParameter("@ID", SqlDbType.VarChar);
            Param[0].Value = ID;
            Con.ExecuteCommand("DeleteProduct", Param); 
            Con.Close();
        }
        //Get Picture of product
        public DataTable GetPicture(string ID)
        {
            DAL.DataAccessLayer Con = new DAL.DataAccessLayer();
            DataTable DT = new DataTable();
            Con.Open();
            SqlParameter[] Param = new SqlParameter[1];
            Param[0] = new SqlParameter("@ID", SqlDbType.VarChar);
            Param[0].Value = ID;
            DT = Con.SelectData("GetPicture", Param);
            return DT;
        }
        //Method To Update product
        public void UpdateProduct(string ID_Product, string Label_Product, int Quantity, string Price, byte[] Image, int ID_Category)
        {
            DAL.DataAccessLayer Con = new DAL.DataAccessLayer();
            Con.Open();
            SqlParameter[] Param = new SqlParameter[6];
            Param[0] = new SqlParameter("@ID_Product", SqlDbType.VarChar);
            Param[0].Value = ID_Product;
            Param[1] = new SqlParameter("@Label_Product", SqlDbType.VarChar);
            Param[1].Value = Label_Product;
            Param[2] = new SqlParameter("@Quantity", SqlDbType.Int);
            Param[2].Value = Quantity;
            Param[3] = new SqlParameter("@Price", SqlDbType.VarChar);
            Param[3].Value = Price;
            Param[4] = new SqlParameter("@Image", SqlDbType.Image);
            Param[4].Value = Image;
            Param[5] = new SqlParameter("@ID_Category", SqlDbType.Int);
            Param[5].Value = ID_Category;
            Con.ExecuteCommand("UpdateProduct", Param); Con.Close();
        }
    }
}

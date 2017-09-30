using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Sales_Management.DAL
{
    class DataAccessLayer
    {
        //Fields
        SqlConnection sqlConnection;
        //Constructor
        public DataAccessLayer()
        {
            //initialize SQL Server & Database To the Project 
            sqlConnection = new SqlConnection("Server=.\\SQLEXPRESS ; Database=Product_DB ; integrated Security=True");
        }

        //Methods
        #region "SQL Connection State Method Controller"
        //Method to Open SQL Server Connection 
        public void Open()
        {
            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }
        //Method to Close SQL Server Connection 
        public void Close()
        {
            if (sqlConnection.State == ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }
        #endregion

        //Method to Read -Select- from SQL Server Database
        public DataTable SelectData(string stored_Procedure, SqlParameter[] Param)
        {
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.CommandText = stored_Procedure;
            sqlCmd.Connection = sqlConnection;

            if (Param !=null)
            {
                sqlCmd.Parameters.AddRange(Param);
            }
            SqlDataAdapter DA = new SqlDataAdapter(sqlCmd);
            DataTable DT = new DataTable();
            DA.Fill(DT);
            return DT;
        }
        //Method to Read -Insert, Update, Delete - Data from SQL Server Database
        public void ExecuteCommand(string stored_Procedure, SqlParameter[] Param)
        {
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.CommandText = stored_Procedure;
            sqlCmd.Connection = sqlConnection;
            sqlConnection.Open();
            if (Param != null)
            {
                sqlCmd.Parameters.AddRange(Param);
            }
            try
            {
                sqlCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error " + ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
              
        }
    }
}

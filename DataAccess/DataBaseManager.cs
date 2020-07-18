using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
   public class DataBaseManager
    {
       String ConnectionString = "server=.;initial catalog=Library;integrated security=true";
        public bool ExecuteCommand(string command, List<SqlParameter> parameters)
        {
            SqlConnection myConnection = new SqlConnection();
            myConnection.ConnectionString = ConnectionString;
            SqlCommand myCommand = new SqlCommand();
            myCommand.Connection = myConnection;
            myCommand.CommandText = command;
            foreach (SqlParameter param in parameters)
            {
                myCommand.Parameters.Add(param);
            }
            try
            {
                myConnection.Open();
                int result = myCommand.ExecuteNonQuery();//تعداد سطر ها در دیتا بیس 
                myConnection.Close();
                if (result > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public DataTable GetData(string command)
        {
            SqlConnection myConnection = new SqlConnection();
            myConnection.ConnectionString = ConnectionString;
            SqlCommand myCommand = new SqlCommand();
            myCommand.Connection = myConnection;
            myCommand.CommandText = command;
            DataTable result = new DataTable();
            SqlDataAdapter myDataAdapter = new SqlDataAdapter();
            myDataAdapter.SelectCommand = myCommand;

            try
            {
                myDataAdapter.Fill(result);
                return result;
            }
            catch
            {
                return null;
            }
        }

        public int ExecuteScalar(string command, List<SqlParameter> parameters)
        {
            SqlConnection myConnection = new SqlConnection();
            myConnection.ConnectionString = ConnectionString;
            SqlCommand myCommand = new SqlCommand();
            myCommand.Connection = myConnection;
            myCommand.CommandText = command;
            foreach (SqlParameter param in parameters)
            {
                myCommand.Parameters.Add(param);
            }
            try
            {
                myConnection.Open();
                int result = Convert.ToInt32(myCommand.ExecuteScalar());
                myConnection.Close();
                return result;
            }
            catch
            {
                return -1;
            }
        }

    }
}


    


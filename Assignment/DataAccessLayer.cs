using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Assignment.ModelClass;
using System.Configuration;
using System.Data.SqlClient;

namespace Assignment 
{
    class DataAccessLayer
    {
      public List<WholeDetails>  GetAllRequireDetails()
        {
            List<WholeDetails> Listwholedetails = new List<WholeDetails>();
            string connectingString = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectingString))
            {
                SqlCommand command = new SqlCommand("Sp_SelectAll", connection);

                command.CommandType = System.Data.CommandType.StoredProcedure;

                connection.Open();

                SqlDataReader dataReader = command.ExecuteReader();

                while(dataReader.Read())
                {
                    WholeDetails wholedetails = new WholeDetails();
                    wholedetails.StudentName =  dataReader["StudentName"].ToString();
                    wholedetails.CourseName = dataReader["CourseName"].ToString();
                    wholedetails.Professor = dataReader["Professor"].ToString();
                    Listwholedetails.Add(wholedetails);

                }


            }


            return Listwholedetails;
        } 
        
        public  List<ChangeData> GetAllChangeDetails()
        {
            List<ChangeData> ListChangeData = new List<ChangeData>();
            string connectionString = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("Sp_Get_Change_Data", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                connection.Open();
                SqlDataReader datareader = command.ExecuteReader();
                 
                while(datareader.Read())
                {
                    ChangeData changedata = new ChangeData();
                    changedata.StudentName = datareader["StudentName"].ToString();
                    changedata.ActionType = datareader["ActionType"].ToString();
                    changedata.ActionTable = datareader["ActionTable"].ToString();
                    changedata.Professor = datareader["Professor"].ToString();

                    ListChangeData.Add(changedata);
                }
            }
            return ListChangeData;
        }
    }
}

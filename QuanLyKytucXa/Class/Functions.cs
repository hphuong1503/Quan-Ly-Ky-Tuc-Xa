using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyKytucXa.Class
{
    class Functions
    {
        public static SqlConnection sqlConnection = null;
        private static string strConnection = @"Data Source=.\SQLEXPRESS;Initial Catalog = QuanLyKyTucXa; User ID = sa;pwd=123456";
         private SqlCommand command = new SqlCommand();
        // this funtion to establish command 
        public static SqlCommand setCommand(string commmandText)
        {
            SqlCommand command = new SqlCommand();
            command.Parameters.Clear();
            
            command.CommandType = CommandType.Text;
            command.CommandText = commmandText;
            command.Connection = Functions.sqlConnection;
            return command;
        }
        // kiem tra tai khoan va mat khau
        public static bool checkLogin(string userName, string passWord)
        {
            checkOpen();
            SqlCommand sqlCommand = new SqlCommand();
            string com = "select * from ACCOUNT where UserName=@userName";
            sqlCommand = setCommand(com);
            SqlParameter paramUser = new SqlParameter("@userName", SqlDbType.VarChar);
            paramUser.Value = userName;
            sqlCommand.Parameters.Add(paramUser);

            SqlDataReader sqlReader = sqlCommand.ExecuteReader();
            if (sqlReader.Read())
            {
                string user = sqlReader.GetString(0) + "";
                string pass = sqlReader.GetString(1) + "";

                if (passWord.Equals(pass))
                {
                    sqlReader.Close();
                    return true;
                }
                    
                MessageBox.Show("Sai mật khẩu");
            }
            else
                MessageBox.Show("Tài khoản không tồn tại");
            sqlReader.Close();
            return false;


        }
        public static void checkOpen()
        {
            try
            {
                if (sqlConnection == null)
                    sqlConnection = new SqlConnection(strConnection);
                if (sqlConnection.State == ConnectionState.Closed)
                    sqlConnection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connect Database is failed !\n"+ex.Message);
            }
        }

        public static string SafeGetString( SqlDataReader reader, int colIndex)
        {
           
            if (reader.GetValue(colIndex) != DBNull.Value)
                return reader.GetString(colIndex);
                    return "";
        }

        public static string SafeGetINT(SqlDataReader reader, int colIndex)
        {
            if (reader.GetValue(colIndex) != DBNull.Value)
                return  Convert.ToString( reader.GetInt32(colIndex));
                return "";
        }

        public static string SafeGetDate(SqlDataReader reader, int colIndex)
        {
            if (!reader.IsDBNull(5))
               return  reader.GetDateTime(5).ToString("dd/MM/yyyy");
            return "";
        }
        public static string convertSex(bool sex)
        {
            return (sex) ? "Nam" : "Nữ";

        }


        // this funtion to update customer for room update
        public static void deleteRoom(string roomID)
        {
            checkOpen();
            SqlCommand command = new SqlCommand();
            string sql = "update CUSTOMER set RoomId=@NewroomID where RoomID=@OldroomID";
            command = setCommand(sql);
            command.Parameters.Add("@OldroomID", SqlDbType.VarChar).Value = roomID;
            command.Parameters.Add("@NewroomID", SqlDbType.VarChar).Value = "";
            int ret = command.ExecuteNonQuery();
            
        }
        // delete Customer
        public static void deleteCustomerRoom(string roomID)
        {
            Functions.checkOpen();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "delete from CUSTOMER where RoomID=@roomID ";
            command.Connection = Functions.sqlConnection;
            command.Parameters.Add("@roomID", SqlDbType.VarChar).Value = roomID;

            int ret = command.ExecuteNonQuery();
            
        }

        // delete Reservation

        public static void deleteReservationCus(string CustomerID)
        {
            Functions.checkOpen();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "delete from Reservation where CustomerID=@ID";
            command.Connection = Functions.sqlConnection;
            command.Parameters.Add("@ID", SqlDbType.VarChar).Value = CustomerID;
            int ret = command.ExecuteNonQuery();
            
        }

        public static void deleteReservationRoom(string RoomID)
        {
            Functions.checkOpen();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "delete from Reservation where RoomID=@ID";
            command.Connection = Functions.sqlConnection;
            command.Parameters.Add("@ID", SqlDbType.VarChar).Value = RoomID;
            int ret = command.ExecuteNonQuery();
        }

    }
}

using QuanLyKytucXa.Class;
using System;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyKytucXa.Controller
{
    class CtrServiceFee : Controller
    {
        // this function to add a room to DataBase
        public void showServiceFee(Bunifu.Framework.UI.BunifuCustomDataGrid dgv) 
        {
            setCommand( "select * from SERVICE_FEE");
            command.Connection = Functions.sqlConnection;
            SqlDataReader reader = command.ExecuteReader();
            dgv.Rows.Clear();
            while (reader.Read())
            {
                dgv.Rows.Add(reader.GetString(0), reader.GetString(1), Functions.SafeGetINT(reader, 2), Functions.SafeGetString(reader, 3));
            }
            reader.Close();
        }

        //this funtion to update  service fee
        public bool updateServiceFee(string serID, int price)
        {
            try
            {
                string com = "update SERVICE_FEE set Price=@price where  ServiceID=@id";
                setCommand(com);
                command.Parameters.Add("@id", SqlDbType.VarChar).Value = serID;
                command.Parameters.Add("@price", SqlDbType.Int).Value = price;
                int ret = command.ExecuteNonQuery();
                if (ret > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }catch(Exception) { return false; }
        }

    }
}

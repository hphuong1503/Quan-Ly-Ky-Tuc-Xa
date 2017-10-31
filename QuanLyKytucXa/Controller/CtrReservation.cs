using QuanLyKytucXa.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyKytucXa.Controller
{
    class CtrReservation :Controller
    {
        
        //this funtion to show all reservation to dgv
        public void showRes(Bunifu.Framework.UI.BunifuCustomDataGrid dgv)
        {
            string com = "select * from Reservation";
            setCommand(com);
            SqlDataReader reader = command.ExecuteReader();
            dgv.Rows.Clear();
            while (reader.Read())
            {
                dgv.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2),
                     Functions.SafeGetString(reader, 3), reader.GetDateTime(4).ToString("dd/MM/yyyy"), Functions.SafeGetDate(reader, 5));
            }
            reader.Close();
        }

        // this function to add new reservation
        public bool addReservation(List<string> res, DateTime start, bool isEnd, DateTime end)
        {
            try
            {
                string com = "Insert into RESERVATION(ReservationID,CustomerID,RoomID,RentType,StartDate,EndDate) " +
                         " values(@resID,@cusID,@roomID,@rent,@startdate,@enddate)";
                setCommand(com);
                command.Parameters.Add("@resID", SqlDbType.VarChar).Value = res[0];
                command.Parameters.Add("@cusID", SqlDbType.VarChar).Value = res[1];
                command.Parameters.Add("@roomID", SqlDbType.VarChar).Value = res[2];
                command.Parameters.Add("@rent", SqlDbType.NVarChar).Value = res[3];
                command.Parameters.Add("@startdate", SqlDbType.Date).Value = start;
                if (isEnd)
                    command.Parameters.Add("@enddate", SqlDbType.Date).Value = end;
                else command.Parameters.Add("@enddate", SqlDbType.Date).Value = DBNull.Value;
                int ret = command.ExecuteNonQuery();
                if (ret > 0)
                {
                    if (res[3] == "Bao phòng")
                    {
                        CtrRoom ctrRoom = new CtrRoom();
                        ctrRoom.markStatus(res[2], "Đủ Người");
                    }
                    command.CommandText = "update CUSTOMER set RoomId=@roomId where customerID=@cusID";
                    command.ExecuteNonQuery();
                    return true;
                }
                else
                    return false;



            }
            catch (Exception)
            {
                return false;

            }
        }

        //this funtion to delete reservation
        public bool deleteRes(string ResID)
        {
            string com = "delete from Reservation where ReservationID=@ID";
            setCommand(com);
            command.Connection = Functions.sqlConnection;
            command.Parameters.Add("@ID", SqlDbType.VarChar).Value = ResID;
            int ret = command.ExecuteNonQuery();
            if (ret > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //this funtuin to update reservation
        public bool updateReservation(List<string> res, DateTime start, bool isEnd, DateTime end)
        {
            try
            {
                string com = "update RESERVATION set CustomerID=@cusID,RoomID=@roomId,RentType=@rent,StartDate=@startDate,EndDate=@enddate where ReservationID=@resID";
                setCommand(com);
                command.Parameters.Add("@resID", SqlDbType.VarChar).Value = res[0];
                command.Parameters.Add("@cusID", SqlDbType.VarChar).Value = res[1];
                command.Parameters.Add("@roomID", SqlDbType.VarChar).Value = res[2];
                command.Parameters.Add("@rent", SqlDbType.NVarChar).Value = res[3];
                command.Parameters.Add("@startdate", SqlDbType.Date).Value = start;
                if (isEnd)
                    command.Parameters.Add("@enddate", SqlDbType.Date).Value = end;
                else command.Parameters.Add("@enddate", SqlDbType.Date).Value = DBNull.Value;

                int ret = command.ExecuteNonQuery();
                if (ret > 0)
                {
                    if (res[3] == "Bao phòng")
                    {
                        CtrRoom ctrRoom = new CtrRoom();
                        ctrRoom.markStatus(res[2], "Đủ Người");
                    }
                    command.CommandText = "update CUSTOMER set RoomId=@roomId where customerID=@cusID";
                    command.ExecuteNonQuery();
                    return true;
                }
                else
                    return false;
            }
            catch (Exception )
            {
                
                return false;

            }
        }
    }
}

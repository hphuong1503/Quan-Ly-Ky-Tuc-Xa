using QuanLyKytucXa.Class;
using System;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyKytucXa.Controller
{
    class CtrRoom : Controller
    {
        

        // this function to add a room to DataBase
        public  bool  addRoom(string roomID, string price , string status)
        {
            try
            {
                string com = "Insert into Room(RoomID,StatusRoom,Price) " +
                      " values(@roomID,@status,@price)";
                setCommand(com);
                command.Connection = Functions.sqlConnection;
                command.Parameters.Add("@roomID", SqlDbType.VarChar).Value = roomID;
                command.Parameters.Add("@status", SqlDbType.NVarChar).Value = status;
                command.Parameters.Add("@price", SqlDbType.Int).Value = Convert.ToInt32(price);

                int ret = command.ExecuteNonQuery();
                if (ret > 0)
                {
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

        //this funtion to show room to combobox
        public void loadRoomID(System.Windows.Forms.ComboBox cb)
        {
            try
            {
                setCommand( "select RoomID from Room");
                SqlDataReader reader = command.ExecuteReader();
                cb.Items.Clear();
            
                while (reader.Read())
                {
                    cb.Items.Add(reader.GetString(0));
                }
                reader.Close();
            }
            catch (Exception)
            {

            }
        }

        // this funtion to show all the room from DB with condition
        public void showRoom(Bunifu.Framework.UI.BunifuCustomDataGrid dgv,string com="",string status="")
        {
            setCommand("select * from Room "+com );
            if (!"".Equals(status))
                command.Parameters.Add("@status", SqlDbType.NVarChar).Value = status;
            SqlDataReader reader = command.ExecuteReader();
            dgv.Rows.Clear();
           
            while (reader.Read())
            {
                dgv.Rows.Add(reader.GetString(0), Functions.SafeGetString(reader, 1), reader.GetInt32(2));
            }
            reader.Close();
        }

        // this funtion to show all customer in a room
        public void showRoomCustomer(Bunifu.Framework.UI.BunifuCustomDataGrid dgvCus, Bunifu.Framework.UI.BunifuCustomDataGrid dgvRoom)
        {
            string com = "select CustomerId,Name,Addres,Phone from Customer where RoomId=@roomID";
            setCommand(com);
            command.Parameters.Add("@roomID", SqlDbType.VarChar).Value = (string)dgvRoom.CurrentRow.Cells[0].Value;

            SqlDataReader reader = command.ExecuteReader();
            dgvCus.Rows.Clear();
            while (reader.Read())
            {
                dgvCus.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3));
            }
            reader.Close();
        }

        //this funtion to delete room
        public bool deleteRoom(string roomID)
        {
            //do something
            Functions.deleteReservationRoom(roomID);
            Functions.deleteRoom(roomID);
            string com = "delete from Room where RoomID=@roomID ";
            setCommand(com);
            command.Parameters.Add("@roomID", SqlDbType.VarChar).Value = roomID;

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

        // this funtion to update price or status for roomID
        public bool updateRoom(string roomId, int price, string status)
        {
            string com = "update Room set StatusRoom=@status,Price=@price where RoomID=@roomID";
            setCommand(com);
            command.Connection = Functions.sqlConnection;
            command.Parameters.Add("@roomID", SqlDbType.VarChar).Value = roomId;
            command.Parameters.Add("@status", SqlDbType.NVarChar).Value = status;
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
        }

        // check room is full or not
        public bool RoomisFull(string roomID)
        {
            string com = "select * from Room where RoomID=@roomID";
            setCommand(com);
            command.Parameters.Add("@roomID", SqlDbType.VarChar).Value = roomID;
            SqlDataReader reader = command.ExecuteReader();
            string status = "";
            if (reader.Read())
            {
                status = reader.GetString(1);
            }
            reader.Close();
            if ("Đủ Người".Equals(status))
                return true;
            return false;

        }

        // this funtion to update room status
        public void markStatus(string roomId, string status)
        {
            string com = "update Room set StatusRoom=@status where RoomID=@roomID";
            setCommand(com);
            command.Connection = Functions.sqlConnection;
            command.Parameters.Add("@roomID", SqlDbType.VarChar).Value = roomId;
            command.Parameters.Add("@status", SqlDbType.NVarChar).Value = status;
            int ret = command.ExecuteNonQuery();
            
            
        }
    }
}

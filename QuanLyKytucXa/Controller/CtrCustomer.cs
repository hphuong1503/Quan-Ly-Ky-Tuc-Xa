using QuanLyKytucXa.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyKytucXa.Controller
{
    class CtrCustomer : Controller
    {
        

        //this funtion to show customer
        public void showCustomer(Bunifu.Framework.UI.BunifuCustomDataGrid dgv,string con="", string name="",string room="")
        {
            try
            {
                setCommand("select * from CUSTOMER "+con);
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = "%" + name + "%";
                command.Parameters.Add("@roomID", SqlDbType.VarChar).Value = room;
                SqlDataReader reader = command.ExecuteReader();
                dgv.Rows.Clear();
                while (reader.Read())
                {
                    dgv.Rows.Add(reader.GetString(0), reader.GetString(1), Functions.convertSex(reader.GetBoolean(2)), Functions.SafeGetString(reader, 3),
                        Functions.SafeGetString(reader, 4), Functions.SafeGetString(reader, 5), reader.GetString(6));
                }
                reader.Close();
            }
            catch (Exception) { }
        }

        //this funtion to add Customer
        public bool addCustomer(List<string> cus, bool sex)
        {
            try
            {
               
                string com = "Insert into CUSTOMER(CustomerID,Name,Sex,Addres,Phone,RoomID,Vehicle) " +
                      " values(@customerID,@name,@sex,@addres,@phone,@roomID,@vehicle)";
                setCommand(com);

                command.Parameters.Add("@customerID", SqlDbType.VarChar).Value = cus[0];
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = cus[1];
                command.Parameters.Add("@sex", SqlDbType.Bit).Value = sex;
                command.Parameters.Add("@addres", SqlDbType.NVarChar).Value = cus[2];
                command.Parameters.Add("@phone", SqlDbType.VarChar).Value =  cus[3];
                command.Parameters.Add("@roomID", SqlDbType.VarChar).Value = cus[4];
                command.Parameters.Add("@vehicle", SqlDbType.NVarChar).Value = cus[5];

                int ret = command.ExecuteNonQuery();
                if (ret > 0)

                    return true;

                else
                    return false;
            }
            catch (Exception )
            {
                return false;

            }
        }

        // this funtion to delete Customer
        public bool deleteCustomer(string CustomerID)
        {
            Functions.deleteReservationCus(CustomerID);
            string com = "delete from CUSTOMER where CustomerId=@customerId ";
            setCommand(com);   
            command.Parameters.Add("@customerID", SqlDbType.VarChar).Value = CustomerID;

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

        //this funtion to update customer
        public bool updateCustomer(List<string> cus, bool sex)
        {
            try
            {
                string com = "update CUSTOMER set customerID=@oldcustomerID,Name=@name,Sex=@sex,Phone=@phone,addres=@addres,RoomId=@roomId,Vehicle=@vehicle where customerID=@newcustomerID";
                setCommand(com);
                command.Parameters.Add("@oldcustomerID", SqlDbType.VarChar).Value = cus[0];
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = cus[1];
                command.Parameters.Add("@sex", SqlDbType.Bit).Value = sex;
                command.Parameters.Add("@addres", SqlDbType.NVarChar).Value = cus[2];
                command.Parameters.Add("@phone", SqlDbType.VarChar).Value = cus[3];
                command.Parameters.Add("@roomID", SqlDbType.VarChar).Value = cus[4];
                command.Parameters.Add("@vehicle", SqlDbType.NVarChar).Value = cus[5];
                command.Parameters.Add("@newcustomerID", SqlDbType.VarChar).Value = cus[6];

                int ret = command.ExecuteNonQuery();
                if (ret > 0)

                    return true;

                else
                    return false;
            }
            catch (Exception)
            {
                return false;

            }
        }


    }
}

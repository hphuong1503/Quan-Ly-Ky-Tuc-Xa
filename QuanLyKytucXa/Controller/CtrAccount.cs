using QuanLyKytucXa.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKytucXa.Controller
{
    class CtrAccount : Controller
    {
        //this function to add new account
        public bool addAcc(string user, string pass)
        {
            try
            {
                string com = "Insert into ACCOUNT(UserName,Password) " +
                      " values(@user,@pass)";
                setCommand(com);

                command.Parameters.Add("@user", SqlDbType.VarChar).Value = user;
                command.Parameters.Add("@pass", SqlDbType.VarChar).Value = pass;
                int ret = command.ExecuteNonQuery();
                if (ret > 0)
                {
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

        // this function to update
        public bool updateAcc(string user, string pass)
        {
            try
            {
                string com = "update ACCOUNT set UserName=@user,Password=@pass where  UserName=@user";
                setCommand(com);
                command.Parameters.Add("@user", SqlDbType.VarChar).Value = user;
                command.Parameters.Add("@pass", SqlDbType.VarChar).Value = pass;
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


        // this funtion to delete
        public bool deleteAcc(string User)
        {
            setCommand("delete from Account where UserName=@user");
            command.Parameters.Add("@user", SqlDbType.VarChar).Value = User;
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
        // this function to show to dgv
        public void showAcc(Bunifu.Framework.UI.BunifuCustomDataGrid dgv)
        {
            setCommand("select * from ACCOUNT");
            SqlDataReader reader = command.ExecuteReader();
            dgv.Rows.Clear();
            while (reader.Read())
            {
                dgv.Rows.Add(reader.GetString(0), reader.GetString(1));
            }
            reader.Close();
        }
    }
}

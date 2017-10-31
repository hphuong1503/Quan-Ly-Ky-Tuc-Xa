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
    class Controller
    {
        protected SqlCommand command = new SqlCommand();
        // this funtion to establish command 
        public void setCommand(string commmandText)
        {
            command.Parameters.Clear();
            Functions.checkOpen();
            command.CommandType = CommandType.Text;
            command.CommandText = commmandText;
            command.Connection = Functions.sqlConnection;
        }
    }
}

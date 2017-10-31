using QuanLyKytucXa.Class;
using System;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyKytucXa.Controller
{
    class CtrInvoiceDetail : Controller
    {
       
        // add some invoice detail to database
        public void addInvoiceDetail(string invoiceID, string ServiceID, int Fee)
        {
            try
            {
                string com = "Insert into INVOICE_DETAIL(InvoiceID,ServiceID,Fee) " +
                      " values(@invoiceID,@serID,@Fee)";
                setCommand(com);
                command.Parameters.Add("@invoiceID", SqlDbType.VarChar).Value = invoiceID;
                command.Parameters.Add("@serID", SqlDbType.VarChar).Value = ServiceID;
                command.Parameters.Add("@Fee", SqlDbType.Int).Value = Fee;
                int ret = command.ExecuteNonQuery();
            }
            catch (Exception) { }
        }

        //this funtion to show all invoice to dgv
        public void showInvoiceDetail(Bunifu.Framework.UI.BunifuCustomDataGrid dgv,string invoiceID)
        {
            try
            {
                Functions.checkOpen();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "select * from INVOICE_DETAIL where InvoiceID=@id";
                command.Connection = Functions.sqlConnection;
                command.Parameters.Add("@id", SqlDbType.VarChar).Value = invoiceID;

                SqlDataReader reader = command.ExecuteReader();
                dgv.Rows.Clear();
                while (reader.Read())
                {
                    dgv.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetInt32(2));
                }
                reader.Close();
            }
            catch (Exception) { }
        }
    }
}

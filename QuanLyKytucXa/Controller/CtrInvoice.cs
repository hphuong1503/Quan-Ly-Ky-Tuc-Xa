using QuanLyKytucXa.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyKytucXa.Controller
{
    class CtrInvoice : Controller
    {
        public void showInvoice(Bunifu.Framework.UI.BunifuCustomDataGrid dgv,string con= "", string CustomerID = "")
        {
            try
            {
                string com = "select * from INVOICE"+con;
                setCommand(com);
                command.Parameters.Add("@cusID", SqlDbType.VarChar).Value = CustomerID;
                SqlDataReader reader = command.ExecuteReader();
                dgv.Rows.Clear();
                while (reader.Read())
                {
                    dgv.Rows.Add(reader.GetString(0), reader.GetString(1), Functions.SafeGetINT(reader, 2),
                        Functions.SafeGetINT(reader, 3), Functions.SafeGetINT(reader, 4), Functions.SafeGetString(reader, 5));
                }
                reader.Close();
            } catch (Exception) { }
        }

        // this funtion to add new Invoice
        public bool addInvoice(List<string> text, List<int> num)
        {
            try
            {
                string com = "Insert into INVOICE(InvoiceID,CustomerID,Month,Year,Payment,Description) " +
                      " values(@invoiceID,@customerID,@month,@year,@pay,@Des)";
                setCommand(com);
                command.Parameters.Add("@invoiceID", SqlDbType.VarChar).Value = text[0];
                command.Parameters.Add("@customerID", SqlDbType.VarChar).Value = text[1];
                command.Parameters.Add("@month", SqlDbType.Int).Value = num[0];
                command.Parameters.Add("@year", SqlDbType.Int).Value = num[1];
                command.Parameters.Add("@pay", SqlDbType.Int).Value = num[2];
                command.Parameters.Add("@des", SqlDbType.NVarChar).Value = text[2];

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

        //this funtion to delete invoice
        public bool deleteInvoice(string invoiceID)
        {

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "delete from INVOICE_DETAIL where InvoiceID=@invoiceID ";
            command.Connection = Functions.sqlConnection;
            command.Parameters.Add("@invoiceID", SqlDbType.VarChar).Value = invoiceID;
            int ret = command.ExecuteNonQuery();
            command.CommandText = "delete from INVOICE where InvoiceID=@invoiceID ";
            ret+= command.ExecuteNonQuery();
            if (ret > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // this function update invoice
        public bool updateInvoice(List<string> text, List<int> num)
        {
            try
            {
                string com = "update INVOICE set customerID=@customerID,Month=@month,year=@year,Payment=@pay,Description=@des where InvoiceID=@invoiceID";
                setCommand(com);
                command.Parameters.Add("@invoiceID", SqlDbType.VarChar).Value = text[0];
                command.Parameters.Add("@customerID", SqlDbType.VarChar).Value = text[1];
                command.Parameters.Add("@month", SqlDbType.Int).Value = num[0];
                command.Parameters.Add("@year", SqlDbType.Int).Value = num[1];
                command.Parameters.Add("@pay", SqlDbType.Int).Value = num[2];
                command.Parameters.Add("@des", SqlDbType.NVarChar).Value = text[2];
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
            catch (Exception) { return false; }
        }


    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace QLNS2
{
    public class ConnectDB
    {
        public class KetNoi
        {
            string ConnectionStr = @"Data Source=Ngoc_Lan\SQLEXPRESS;Initial Catalog=QLNS;Persist Security Info=True;User ID=lan;Password=1;Encrypt=True;TrustServerCertificate=True";

            public SqlConnection OpenConnection()
            {
                SqlConnection connection = new SqlConnection(ConnectionStr);

                try
                {
                    // Mở kết nối
                    connection.Open();
                    Console.WriteLine("Kết nối thành công!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Lỗi kết nối: " + ex.Message);
                }

                return connection;
            }
            // Hàm đóng kết nối
            public void CloseConnection(SqlConnection connection)
            {
                try
                {
                    // Đóng kết nối
                    connection.Close();
                    Console.WriteLine("Đóng kết nối thành công!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Lỗi khi đóng kết nối: " + ex.Message);
                }
            }
        }
    }
}
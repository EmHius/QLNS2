using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static QLNS2.ConnectDB;

public partial class FormChamCong : System.Web.UI.Page
{
    KetNoi ketNoi = new KetNoi();
    int idKhenThuong, idNhanVien, idKiLuat;

    protected void Page_Load(object sender, EventArgs e)
    {
        using (SqlConnection connection = ketNoi.OpenConnection())
        {

           
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT LuongThang.MaNhanVien, Users.HoTen, LuongThang.TongLuong, LuongThang.Thang, LuongThang.Nam FROM LuongThang INNER JOIN NhanVien ON LuongThang.MaNhanVien = NhanVien.MaNhanVien INNER JOIN Users ON NhanVien.IdUser = Users.Id", connection))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
        }
    }
}
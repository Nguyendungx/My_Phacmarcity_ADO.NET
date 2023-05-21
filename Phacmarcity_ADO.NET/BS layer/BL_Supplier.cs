using Phacmarcity_ADO.NET.DB_layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phacmarcity_ADO.NET.BS_layer
{
    class BL_Supplier
    {
        DBMain db = null;
        public BL_Supplier()
        {
            db = new DBMain();
        }
        public DataSet LayNCC()
        {
            return db.ExecuteQueryDataSet("SELECT * FROM NhaCungCap", CommandType.Text);
        }
        public bool ThemNCC(string MaNhaCungCap,
            string TenNhaCungCap,
            string DiaChi,
            string ThongTinDaiDien,
            ref string err)
        {
            string sqlString = "INSERT INTO NhaCungCap (MaNhaCungCap, TenNhaCungCap,DiaChi,ThongTinDaiDien) VALUES ('" + MaNhaCungCap + "', '" + TenNhaCungCap + "', '" + DiaChi + "', '" + ThongTinDaiDien + "');";
       
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool XoaNCC(ref string err, string MaNhaCungCap)
        {
            string sqlString = "DELETE FROM NhaCungCap WHERE MaNhaCungCap = '" + MaNhaCungCap + "';";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public bool CapNhatNCC(string MaNhaCungCap,
            string TenNhaCungCap,
            string DiaChi,
            string ThongTinDaiDien, ref string err)
        {
            string sqlString = "UPDATE NhaCungCap SET MaNhaCungCap = N'" + MaNhaCungCap +
                "', TenNhaCungCap = N'" + TenNhaCungCap +
                "', DiaChi = N'" +DiaChi +
                "', ThongTinDaiDien = N'" +ThongTinDaiDien+
                "' WHERE MaPX = '" + MaNhaCungCap + "';";
                               
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
    }
}

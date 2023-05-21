using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

using Phacmarcity_ADO.NET.DB_layer;

namespace Phacmarcity_ADO.NET.BS_layer
{
    class BLProduce_Product
    {
        DBMain db = null;
        public BLProduce_Product()
        {
            db = new DBMain();
        }
        public DataSet LayPhieuXuat()
        {
            return db.ExecuteQueryDataSet("SELECT * FROM PhieuXuat JOIN CTPhieuXuat ON PhieuXuat.MaPX = CTPhieuXuat.MaPX", CommandType.Text);
        }
        public bool ThemPhieuXuat(string MaPX, 
            string MaNhanVien,
            string MaKhachHang, 
            string MaThuoc,
            string SoLuong,
            string DonGia,DateTime NgayXuat,
            ref string err)
        {
            string sqlString = "INSERT INTO PhieuXuat (MaPX, MaNhanVien,MaKhachHang,NgayXuat) VALUES ('" + MaPX + "', '" + MaNhanVien + "', '"+MaKhachHang+ "', '"+ NgayXuat.ToString("yyyy-MM-dd") + "');" +
                   "INSERT INTO CTPhieuXuat (MaPX, MaThuoc, SoLuong,DonGia) VALUES ('" + MaPX + "', '" + MaThuoc + "', '" + SoLuong + "', '"+DonGia+ "');";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool XoaPhieuXuat(ref string err, string MaPX)
        {
            string sqlString = "DELETE FROM CTPhieuXuat WHERE MaPX = '" + MaPX + "';" +
                               "DELETE FROM PhieuXuat WHERE MaPX = '" + MaPX + "';";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public bool CapNhatPhieuXuat(string MaPX, string MaNhanVien, string MaKhachHang, string MaThuoc, string SoLuong, string DonGia, DateTime NgayXuat, ref string err)
        {
            string sqlString = "UPDATE PhieuXuat SET MaNhanVien = N'" + MaNhanVien + "', MaKhachHang = '" + MaKhachHang + "', NgayXuat = '" + NgayXuat.ToString("yyyy-MM-dd") + "' WHERE MaPX = '" + MaPX + "';" +
                               "UPDATE CTPhieuXuat SET MaThuoc = N'" + MaThuoc + "', SoLuong = " + SoLuong + ", DonGia = " + DonGia + " WHERE MaPX = '" + MaPX + "';";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }


    }
}

using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace Phacmarcity_ADO.NET.Class
{
    public static class StringConvert
    {
        public static string ConvertToEnumPhieuNhap(string input)
        {
            switch (input)
            {
                case "Ngày sản xuất":
                    return "NgaySanXuat";
                case "Hạn sử dụng":
                    return "HanSuDung";
                case "Ngày nhập":
                    return "NgayNhap";
                default:
                    return "";
            }
        }
        public static string ConvertToEnumPhieuXuat(string input)
        {
/*            Mã phiếu xuất
            Mã nhân viên
            Mã khách hàng
            Mã thuốc
            Số lượng
            Ngày xuất*/
            switch (input)
            {
                case "Mã phiếu xuất":
                    return "MaPX";
                case "Mã nhân viên":
                    return "MaNhanVien";
                case "Mã khách hàng":
                    return "MaKhachHang";
                case "Mã thuốc":
                    return "MaThuoc";
                case "Số lượng":
                    return "SoLuong";
                case "Ngày xuất":
                    return "NgayXuat";

                default:
                    return "";
            }
        }
        public static string ConvertToEnumEmployee(string input)
        {
            switch (input)
            {
                case "Ngày sinh":
                    return "NgaySinh";
                case "Ngày vào làm":
                    return "NgayVaoLam";
                
                default:
                    return "";
            }
        }

    }
}

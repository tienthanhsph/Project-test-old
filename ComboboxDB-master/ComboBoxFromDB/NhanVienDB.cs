using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ComboBoxFromDB
{
    public class NhanVienDB
    {
        // chuỗi kết nối
        private static string connectionString1 = "Data Source=Root-PC;Initial Catalog=NhanVienDB;Integrated Security=True";
        private static string connectionString2 = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\NhanVien.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
        public static string connectionString;
        public NhanVienDB()
        {

            SetConnectionStringSqlExpress();
        }       

        // thiết lập connect string là hệ quản trị sql
        public void SetConnectionStringSqlServer()
        {
            connectionString = connectionString1;
        }

        // thiết lập sql connection từ file database
        public void SetConnectionStringSqlExpress()
        {
            connectionString = connectionString2;
        }
        /// <summary>
        /// Lấy danh sách tất cả các nhân viên
        /// </summary>
        /// <returns></returns>
        public List<NhanVien> LayDanhSachNhanVien()
        {
            // tạo kết nối sql
            SqlConnection connection = new SqlConnection(connectionString);

            // mở kết nối sql
            connection.Open();

            // câu sql query lấy danh sách nhân viên
            string sqlQuery = "SELECT * FROM NHANVIEN";

            // sql command dùng để thực thi sql query
            SqlCommand command = new SqlCommand(sqlQuery, connection);

            // lấy đối tượng reader để đọc dữ liệu trả về từ SQL
            SqlDataReader reader =  command.ExecuteReader();

            // tao danh sách chứa các nhân viên
            List<NhanVien> dsNhanVien = new List<NhanVien>();

            //đọc dữ liệu nếu reader còn có thể đọc được
            while (reader.Read() == true)
            {
                // lấy mã nhân viên ở cột thứ 0 trong bảng nhân viên
                string maNhanVien = reader.GetString(0);

                // lấy tên nhân viên ở cột thứ 1 trong bảng nhân viên
                string tenNhanVien = reader.GetString(1);

                // lấy thông tin chi tiết nhân viên cột thứ 2 của bảng nhân viên
                string thongTinChiTiet = reader.GetString(2);
                                
                NhanVien nv = new NhanVien(maNhanVien, tenNhanVien, thongTinChiTiet);

                // thêm nhân viên vừa tạo vào danh sách
                dsNhanVien.Add(nv);
            }

            // đóng kết nối
            connection.Close();
            return dsNhanVien;
        }

        public NhanVien LayNhanVienTheoMa(string maNhanVien)
        {
            // tạo kết nối sql
            SqlConnection connection = new SqlConnection(connectionString);

            // mở kết nối sql
            connection.Open();

            // câu sql query lấy danh sách nhân viên
            string sqlQuery = "SELECT * FROM NHANVIEN WHERE MaNhanVien=@MaNhanVien";

            // sql command dùng để thực thi sql query
            SqlCommand command = new SqlCommand(sqlQuery, connection);
            SqlParameter paraMaNhanVien = new SqlParameter("@MaNhanVien", SqlDbType.VarChar);
            paraMaNhanVien.Value = maNhanVien;
            command.Parameters.Add(paraMaNhanVien);

            // lấy đối tượng reader để đọc dữ liệu trả về từ SQL
            SqlDataReader reader = command.ExecuteReader();

            NhanVien nhanVien = null;

            //đọc dữ liệu nếu reader còn có thể đọc được
            while (reader.Read() == true)
            {
                // lấy mã nhân viên ở cột thứ 0 trong bảng nhân viên
                string maNV = reader.GetString(0);

                // lấy tên nhân viên ở cột thứ 1 trong bảng nhân viên
                string tenNV = reader.GetString(1);

                // lấy thông tin chi tiết nhân viên cột thứ 2 của bảng nhân viên
                string thongTinChiTiet = reader.GetString(2);

                nhanVien = new NhanVien(maNV, tenNV, thongTinChiTiet);
                break;
            }

            // đóng kết nối
            connection.Close();
            return nhanVien;
        }
    }
}

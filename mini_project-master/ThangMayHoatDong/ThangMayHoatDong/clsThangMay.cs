using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThangMayHoatDong
{
    class clsThangMay
    {
        public  float GiaToc { get; set; }
        public  float TocDoMax { get; set; }
        public string TenThangMay { get; set; }//  có nhiều thang máy
        public int Tang { get; set; }
        public bool DangHoatDong { get; set; }
        public int DichDen { get; set; }
        public float TocDo { get; set; }
        public clsTang[] BangDieuKhien { get; set; }
        public bool TangToc { get; set; }
        public bool MoCua { get; set; }
        public bool Up { get;set;}
        public int X { get; set; }
        public int Y { get; set; }

        /// bắt đầu giảm tốc độ thang máy nếu kiểm tra tốc độ hiện tại và đích đến phù hợp với việc dừng lại.
        /// 
        /// làm sao để thang máy đủ thông minh trong khi nhiều thang máy cùng làm việc?????
        /// 
        /// làm sao có thể cấu hình yêu cầu đối với thang máy bằng form thay vì bằng code????  AI, HỆ CHUYÊN GIA????
        /// 
        /// LÀM NHỮNG YÊU CẦU CƠ BẢN TRƯỚC.



        public clsThangMay()
        { 
        
        
        }        
        public float TinhToanTocDo(bool tangToc)
        {
            float tocDo = 0;


            return tocDo;
        }
        public void Move()
        { 
        
        }

    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThucTap
{
    
        public class ThucTapSinh
        {
            public string ma_tts { get; set; }
            public string ho_ten { get; set; }
            public string email { get; set; }
            public DateTime DOB { get; set; }
            public DateTime bat_dau_thuc_tap { get; set; }
            public DateTime ket_thuc_thuc_tap { get; set; }
        //public DateTime DOB { get; set; }
        //    public DateTime bat_dau_thuc_tap { get; set; }
        //    public DateTime ket_thuc_thuc_tap { get; set; }
            public string ma_phong_thuc_tap { get; set; }
            public string gioi_tinh { get; set; }
        }
        public class PHONG
    {
        public string ma_phong { get; set; }
        public string ten_phong { get; set; }
        public string sdt { get; set; }
        public string nguoi_quan_ly { get; set; }

        public PHONG() { }

        public PHONG(DataRow row)
        {
            this.ma_phong = row["ma_phong"].ToString();
            this.ten_phong = row["ten_phong"].ToString();
            this.sdt = row["sdt"].ToString();
            this.nguoi_quan_ly = row["nguoi_quan_ly"].ToString();
        }
    }
    
}

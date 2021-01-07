using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThucTap
{
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

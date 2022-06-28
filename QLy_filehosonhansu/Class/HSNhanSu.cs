using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLy_filehosonhansu.Class
{
    public class HSNhanSu
    {
        public int ID { get; set; }
        public string MaNS { get; set; }
        public string HovaTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string SoCMND { get; set; }
        public string DiaChi { get; set; }
        public string SoDienThoai { get; set; }
        public string Email { get; set; }
        public List<FileDinhKem> fileDinhKem { get; set; }


    }
    public class FileDinhKem
    {
        public int IDFile { get; set; }
        public int STT { get; set; }
        public int IDHOSONHANSU { get; set; }
        public string TenFile { get; set; }
        public string DuongDan { get; set; }
        public string DungLuong { get; set; }
        public string KieuFile { get; set; }
    }
}

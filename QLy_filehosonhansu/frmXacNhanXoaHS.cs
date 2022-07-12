using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLy_filehosonhansu.Class;

namespace QLy_filehosonhansu
{
    public partial class frmXacNhanXoaHS : Form
    {
     
        private QLy_filehosonhansuDataContext db = new QLy_filehosonhansuDataContext();
        public HSNhanSu xoaHS { get; set; }
        public frmXacNhanXoaHS()
        {
            InitializeComponent();
        }
        private void frmHoSoNhanSu_Load(object sender, EventArgs e)
        {

        }

        private void bt_XacNhan_Click(object sender, EventArgs e)
        {
            NS_HOSONHANSU hsNS = (from ds in db.NS_HOSONHANSUs where ds.ID == xoaHS.ID select ds).FirstOrDefault();

            hsNS.HovaTen = txt_HovaTen.Text;
            hsNS.SoCMND = txt_SoCMND.Text;
            hsNS.NgaySinh = date_NgaySinh.DateTime;
            hsNS.DiaChi = txt_DiaChi.Text;
            hsNS.SoDienThoai = txt_SDT.Text;
            hsNS.Email = txt_Email.Text;

            foreach (var item in from ds in db.NS_FILE_HOSOs where ds.IDHOSONHANSU == hsNS.ID select ds)
            {
                db.NS_FILE_HOSOs.DeleteOnSubmit(item);
            }
            db.NS_HOSONHANSUs.DeleteOnSubmit(hsNS);
            db.SubmitChanges();
            frmHoSoNhanSu_Load(sender, e);
            this.DialogResult = DialogResult.OK;
        }

        private void bt_Huy_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void frmXacNhanXoaHS_Load(object sender, EventArgs e)
        {
            db = new QLy_filehosonhansuDataContext();
            txt_MaNS.Text = xoaHS.MaNS;
            txt_HovaTen.Text = xoaHS.HovaTen;
            txt_SoCMND.Text = xoaHS.SoCMND;
            txt_DiaChi.Text = xoaHS.DiaChi;
            txt_Email.Text = xoaHS.Email;
            date_NgaySinh.DateTime = (DateTime)xoaHS.NgaySinh;
            txt_SDT.Text = xoaHS.SoDienThoai;
        }
    }
}

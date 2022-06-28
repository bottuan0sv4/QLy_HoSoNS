using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLy_filehosonhansu
{
    public partial class frmCapNhatHS : Form
    {
        QLy_filehosonhansuDataContext db = new QLy_filehosonhansuDataContext();
        NS_HOSONHANSU hsns = new NS_HOSONHANSU();

        public bool them { get; set; }
        public bool xoa { get; set; }
        public NS_HOSONHANSU hsNhanSu { get; set; }

        public frmCapNhatHS()
        {
            InitializeComponent();
        }

        private void txt_SoCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txt_SDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == '+' || e.KeyChar == '(' || e.KeyChar == ')' || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void bt_Huy_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void bt_XacNhan_Click(object sender, EventArgs e)
        {
            if (them)
            {
                hsns.MaNS = txt_MaNS.Text;
                hsns.HovaTen = txt_HovaTen.Text;
                hsns.SoCMND = txt_SoCMND.Text;
                hsns.NgaySinh = date_NgaySinh.DateTime;
                hsns.DiaChi = txt_DiaChi.Text;
                hsns.SoDienThoai = txt_SDT.Text;
                hsns.Email = txt_Email.Text;
                if (string.IsNullOrEmpty(hsns.MaNS))
                {
                    MessageBox.Show("Xin hãy nhập dữ liệu!", "Error");
                }
                else
                {
                    db.NS_HOSONHANSUs.InsertOnSubmit(hsns);
                    db.SubmitChanges();
                    frmHoSoNhanSu_Load(sender, e);
                    this.DialogResult = DialogResult.OK;
                }


            }
            else
            {
                if (xoa)
                {
                    hsns = db.NS_HOSONHANSUs.Where(s => s.MaNS == txt_MaNS.Text).FirstOrDefault();
                    hsns.HovaTen = txt_HovaTen.Text;
                    hsns.SoCMND = txt_SoCMND.Text;
                    hsns.NgaySinh = date_NgaySinh.DateTime;
                    hsns.DiaChi = txt_DiaChi.Text;
                    hsns.SoDienThoai = txt_SDT.Text;
                    hsns.Email = txt_Email.Text;
                    db.NS_HOSONHANSUs.DeleteOnSubmit(hsns);
                    db.SubmitChanges();
                    frmHoSoNhanSu_Load(sender, e);
                    this.DialogResult = DialogResult.Cancel;
                }
                else
                {
                    hsns = db.NS_HOSONHANSUs.Where(s => s.MaNS == txt_MaNS.Text).FirstOrDefault();
                    hsns.HovaTen = txt_HovaTen.Text;
                    hsns.SoCMND = txt_SoCMND.Text;
                    hsns.NgaySinh = date_NgaySinh.DateTime;
                    hsns.DiaChi = txt_DiaChi.Text;
                    hsns.SoDienThoai = txt_SDT.Text;
                    hsns.Email = txt_Email.Text;
                    db.SubmitChanges();
                    frmHoSoNhanSu_Load(sender, e);
                    this.DialogResult = DialogResult.Cancel;
                }
            }
        }

        private void frmHoSoNhanSu_Load(object sender, EventArgs e)
        {
        }

        private void frmCapNhatHSNS_Load(object sender, EventArgs e)
        {

            if (them)
            {

            }
            else
            {
                txt_MaNS.Text = hsNhanSu.MaNS;
                txt_HovaTen.Text = hsNhanSu.HovaTen;
                txt_SoCMND.Text = hsNhanSu.SoCMND;
                txt_DiaChi.Text = hsNhanSu.DiaChi;
                txt_Email.Text = hsNhanSu.Email;
                date_NgaySinh.DateTime = (DateTime)hsNhanSu.NgaySinh;
                txt_SDT.Text = hsNhanSu.SoDienThoai;
            }
            
        }
    }
}

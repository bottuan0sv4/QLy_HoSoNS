using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using QLy_filehosonhansu.Class;

namespace QLy_filehosonhansu
{
    public partial class frmHoSo : Form
    {
        private QLy_filehosonhansuDataContext db = new QLy_filehosonhansuDataContext();

        public frmHoSo()
        {
            InitializeComponent();
        }
        private void dataload()
        {
            db = new QLy_filehosonhansuDataContext();
            var list = (from p in db.NS_HOSONHANSUs
                       select new HSNhanSu
                       {
                           ID = p.ID,
                           MaNS = p.MaNS,
                           HovaTen = p.HovaTen,
                           NgaySinh = p.NgaySinh,
                           SoCMND = p.SoCMND,
                           SoDienThoai = p.SoDienThoai,
                           DiaChi = p.DiaChi,
                           Email = p.Email
                       }).OrderBy(x => x.ID);
            gc_HSNhanSu.DataSource = list;
            gc_HSNhanSu.RefreshDataSource();
        }
        private void frmHoSoNhanSu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Escape))
                this.Close();
        }

        private void bt_Them_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmCapNhatHS th = new frmCapNhatHS();
            th.them = true;
            th.ShowDialog();
            dataload();
        }

        private void bt_ChinhSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmCapNhatHS th = new frmCapNhatHS();
            th.them = false;
            th.xoa = false;
            th.hsNhanSu = (NS_HOSONHANSU)gv_HSNhanSu.GetFocusedRow();
            th.ShowDialog();
            dataload();
        }

        private void bt_Xoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmCapNhatHS th = new frmCapNhatHS();
            th.them = false;
            th.xoa = true;
            th.hsNhanSu = (NS_HOSONHANSU)gv_HSNhanSu.GetFocusedRow();
            th.ShowDialog();
            dataload();
        }

        private void frmHoSoNhanSu_Load(object sender, EventArgs e)
        {
            dataload();
        }

        private void gv_HSNhanSu_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            HSNhanSu obj = (HSNhanSu)gv_HSNhanSu.GetFocusedRow();
            db = new QLy_filehosonhansuDataContext();
            var list = (from p in db.NS_HOSONHANSUs
                        join c in db.NS_FILE_HOSOs on p.ID equals c.IDHOSONHANSU
                        where p.ID == obj.ID
                        select new FileDinhKem
                        {
                            IDFile = c.ID,
                            STT = c.STT,
                            IDHOSONHANSU = p.ID,
                            TenFile = c.TenFile,
                            DuongDan = c.DuongDan,
                            DungLuong = c.DungLuong,
                            KieuFile = c.KieuFile,
                        }).OrderBy(x => x.IDHOSONHANSU);
            gc_FileDinhKem.DataSource = list;
            gc_FileDinhKem.RefreshDataSource();
        }
    }
}

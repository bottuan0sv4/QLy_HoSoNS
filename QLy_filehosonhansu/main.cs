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
    public partial class main : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public main()
        {
            InitializeComponent();
        }

        private void TrangChu_Load(object sender, EventArgs e)
        {

        }

        private void bt_HoSoNS_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmHoSo NS = new frmHoSo();
            NS.MdiParent = this;
            NS.Show();
        }

        private void bt_HSDinhKem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
        }
    }
}

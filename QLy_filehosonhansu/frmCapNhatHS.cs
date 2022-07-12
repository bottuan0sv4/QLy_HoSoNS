using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using QLy_filehosonhansu.Class;

namespace QLy_filehosonhansu
{
    public partial class frmCapNhatHS : Form
    {
        QLy_filehosonhansuDataContext db = new QLy_filehosonhansuDataContext();
        NS_HOSONHANSU hsns = new NS_HOSONHANSU();
        NS_FILE_HOSO fileHoSo = new NS_FILE_HOSO();
        public bool them { get; set; }
        public HSNhanSu hsNhanSu { get; set; }
        public FileDinhKem fileHS { get; set; }

        List<FileDinhKem> lstFile = new List<FileDinhKem>();
        List<FileDinhKem> lstHS = new List<FileDinhKem>();


        public frmCapNhatHS()
        {
            InitializeComponent();
        }

        private void dataload()
        {
            db = new QLy_filehosonhansuDataContext();
            var list = (from p in db.NS_FILE_HOSOs

                        select new FileDinhKem
                        {
                            IDFile = p.ID,
                            IDHOSONHANSU = p.IDHOSONHANSU,
                            TenFile = p.TenFile,
                            DungLuong = p.DungLuong,
                            DuongDan = p.DuongDan,
                            KieuFile = p.KieuFile,
                        }
                        ).OrderBy(x => x.IDFile);
            gc_File.DataSource = list;
            gc_File.RefreshDataSource();
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

        private void frmHoSoNhanSu_Load(object sender, EventArgs e)
        {
        }

        private void frmCapNhatHSNS_Load(object sender, EventArgs e)
        {
            btnXoa.Click += BtnXoa_Click;
            btnSua.Click += BtnSua_Click;
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

                db = new QLy_filehosonhansuDataContext();
                lstHS = (from p in db.NS_FILE_HOSOs
                           where p.IDHOSONHANSU == hsNhanSu.ID
                           select new FileDinhKem
                           {
                               IDFile = p.ID,
                               TenFile = p.TenFile,
                               DuongDan = p.DuongDan,
                               DungLuong = p.DungLuong,
                               KieuFile = p.KieuFile,

                           }
                            ).OrderBy(x => x.IDFile)
                            .ToList();
                gc_File.DataSource = lstHS;
                gc_File.RefreshDataSource();
            }
            
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            var x = gv_File.GetFocusedRowCellValue("IDFile").ToString();
            frmSuaFileHS f = new frmSuaFileHS();
            f.dk = gv_File.GetFocusedRow() as FileDinhKem;
            f.ShowDialog();
            dataload();
            
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            var x = gv_File.GetFocusedRowCellValue("IDFile").ToString();
            NS_HOSONHANSU hoso = (from ds in db.NS_HOSONHANSUs where ds.ID == hsNhanSu.ID select ds).FirstOrDefault();

            fileHoSo = db.NS_FILE_HOSOs.Where(s => s.ID == Convert.ToInt32(x)).FirstOrDefault();
            db.NS_FILE_HOSOs.DeleteOnSubmit(fileHoSo);

            db.SubmitChanges();
            frmCapNhatHSNS_Load(sender, e);
            this.DialogResult = DialogResult.OK;

        }

        private void btn_FileDK_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDK = new OpenFileDialog();

            fileDK.InitialDirectory = "f:\\";
            fileDK.Filter = "Word|*.doc;*.docx|Excel|*.xls;*.xlsx|Power Point|*.pdf;*.pptx|Image|*.jpg;*.png";

            if (fileDK.ShowDialog() == DialogResult.OK)
            {
                FileInfo f_info = new FileInfo(fileDK.FileName);
                txt_DungLuong.Text = (f_info.Length / 1000).ToString() + " KB";
                txt_DuongDan.Text = fileDK.FileName;
                txt_TenFile.Text = f_info.Name;
                if(f_info.Extension == ".doc" || f_info.Extension == ".docx")
                {
                    txt_KieuFile.Text = "Word";
                }
                if (f_info.Extension == ".xls" || f_info.Extension == ".xlsx")
                {
                    txt_KieuFile.Text = "Excel";
                }
                if (f_info.Extension == ".pdf" || f_info.Extension == ".pptx")
                {
                    txt_KieuFile.Text = "Power Point";
                }
                if (f_info.Extension == ".jpg" || f_info.Extension == ".png")
                {
                    txt_KieuFile.Text = "Image";
                }
            }
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if (them)
            {
                try
                {
                    lstFile.Add(new FileDinhKem()
                    {
                        IDHOSONHANSU = (from p in db.NS_HOSONHANSUs
                                        where p.MaNS == txt_MaNS.Text
                                        select p.ID).FirstOrDefault(),
                        TenFile = txt_TenFile.Text,
                        DuongDan = txt_DuongDan.Text,
                        DungLuong = txt_DungLuong.Text,
                        KieuFile = txt_KieuFile.Text,
                    });

                    txt_TenFile.ResetText();
                    txt_DuongDan.ResetText();
                    txt_DungLuong.ResetText();
                    txt_KieuFile.ResetText();

                }
                catch (Exception)
                {
                    MessageBox.Show("Xin hãy nhập dữ liệu", "Error");
                }


            }
            else
            {

                lstFile.Add(new FileDinhKem()
                {
                    IDHOSONHANSU = (from p in db.NS_HOSONHANSUs
                                    where p.MaNS == txt_MaNS.Text
                                    select p.ID).FirstOrDefault(),
                    TenFile = txt_TenFile.Text,
                    DuongDan = txt_DuongDan.Text,
                    DungLuong = txt_DungLuong.Text,
                    KieuFile = txt_KieuFile.Text,
                });

                txt_TenFile.ResetText();
                txt_DuongDan.ResetText();
                txt_DungLuong.ResetText();
                txt_KieuFile.ResetText();

                lstFile.AddRange(lstHS);
            }
            frmCapNhatHSNS_Load(sender, e);
            gc_File.DataSource = lstFile;
            gc_File.RefreshDataSource();
        }

        private void bt_Luu_HS_Click(object sender, EventArgs e)
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
                    MessageBox.Show("Hãy nhập dữ liệu!", "Error");
                }
                else
                {

                    foreach (var item in lstFile)
                    {
                        NS_FILE_HOSO fileHS = new NS_FILE_HOSO();
                        fileHS.IDHOSONHANSU = item.IDHOSONHANSU;
                        fileHS.TenFile = item.TenFile;
                        fileHS.DuongDan = item.DuongDan;
                        fileHS.DungLuong = item.DungLuong;
                        fileHS.KieuFile = item.KieuFile;
                        fileHS.ID = item.IDFile;


                        hsns.NS_FILE_HOSOs.Add(fileHS);
                    }
                    db.NS_HOSONHANSUs.InsertOnSubmit(hsns);
                    db.SubmitChanges();
                    frmHoSoNhanSu_Load(sender, e);
                    this.DialogResult = DialogResult.OK;
                }

            }
            else
            {
                NS_HOSONHANSU hsNS = (from ds in db.NS_HOSONHANSUs where ds.ID == hsNhanSu.ID select ds).FirstOrDefault();

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
                foreach (var item in lstFile)
                {
                    NS_FILE_HOSO fileHS = new NS_FILE_HOSO();
                    fileHS.IDHOSONHANSU = item.IDHOSONHANSU;
                    fileHS.TenFile = item.TenFile;
                    fileHS.DuongDan = item.DuongDan;
                    fileHS.DungLuong = item.DungLuong;
                    fileHS.KieuFile = item.KieuFile;
                    fileHS.ID = item.IDFile;

                    hsNS.NS_FILE_HOSOs.Add(fileHS);
                }
                db.SubmitChanges();
                frmHoSoNhanSu_Load(sender, e);
                this.DialogResult = DialogResult.OK;


            }
            
        }

        private void gv_File_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column == stt_file)
            {
                e.DisplayText = Convert.ToString(e.RowHandle + 1);
            }
        }

        private void bt_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

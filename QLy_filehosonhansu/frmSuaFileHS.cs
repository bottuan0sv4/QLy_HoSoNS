using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using QLy_filehosonhansu.Class;

namespace QLy_filehosonhansu
{
    public partial class frmSuaFileHS : Form
    {
        QLy_filehosonhansuDataContext db = new QLy_filehosonhansuDataContext();

        public FileDinhKem dk { get; set; }
        NS_FILE_HOSO fhs = new NS_FILE_HOSO();
        List<FileDinhKem> lstDK = new List<FileDinhKem>();
        public frmSuaFileHS()
        {
            InitializeComponent();
        }

        private void frmSuaFileHS_Load(object sender, EventArgs e)
        {
            txt_DungLuong.Text = dk.DungLuong;
            txt_DuongDan.Text = dk.DuongDan;
            txt_KieuFile.Text = dk.KieuFile;
            txt_TenFile.Text = dk.TenFile;
            txt_ID.EditValue = dk.IDFile;
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
                if (f_info.Extension == ".doc" || f_info.Extension == ".docx")
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

            fhs = db.NS_FILE_HOSOs.Where(s => s.ID == Convert.ToInt32(txt_ID.EditValue)).FirstOrDefault();

            fhs.DuongDan = txt_DuongDan.Text;
            fhs.DungLuong = txt_DungLuong.Text;
            fhs.TenFile = txt_TenFile.Text;
            fhs.KieuFile = txt_KieuFile.Text;

            db.SubmitChanges();
            frmSuaFileHS_Load(sender, e);
            this.DialogResult = DialogResult.OK;
            
        }
    }
}

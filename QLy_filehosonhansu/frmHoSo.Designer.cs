
namespace QLy_filehosonhansu
{
    partial class frmHoSo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bt_Them = new DevExpress.XtraBars.BarButtonItem();
            this.bt_ChinhSua = new DevExpress.XtraBars.BarButtonItem();
            this.bt_Xoa = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.sidePanel2 = new DevExpress.XtraEditors.SidePanel();
            this.gc_HSNhanSu = new DevExpress.XtraGrid.GridControl();
            this.gv_HSNhanSu = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_FileDinhKem = new DevExpress.XtraGrid.GridControl();
            this.gv_FileDinhKem = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn15 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.sidePanel1.SuspendLayout();
            this.sidePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_HSNhanSu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_HSNhanSu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_FileDinhKem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_FileDinhKem)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bt_Them,
            this.bt_ChinhSua,
            this.bt_Xoa});
            this.barManager1.MaxItemId = 3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bt_Them, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bt_ChinhSua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bt_Xoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // bt_Them
            // 
            this.bt_Them.Caption = "Thêm Mới";
            this.bt_Them.Id = 0;
            this.bt_Them.ImageOptions.Image = global::QLy_filehosonhansu.Properties.Resources.addgroupheader_16x16;
            this.bt_Them.ImageOptions.LargeImage = global::QLy_filehosonhansu.Properties.Resources.addgroupheader_32x32;
            this.bt_Them.Name = "bt_Them";
            this.bt_Them.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bt_Them_ItemClick);
            // 
            // bt_ChinhSua
            // 
            this.bt_ChinhSua.Caption = "Chỉnh Sửa";
            this.bt_ChinhSua.Id = 1;
            this.bt_ChinhSua.ImageOptions.Image = global::QLy_filehosonhansu.Properties.Resources.edit_16x16;
            this.bt_ChinhSua.ImageOptions.LargeImage = global::QLy_filehosonhansu.Properties.Resources.edit_32x32;
            this.bt_ChinhSua.Name = "bt_ChinhSua";
            this.bt_ChinhSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bt_ChinhSua_ItemClick);
            // 
            // bt_Xoa
            // 
            this.bt_Xoa.Caption = "Xóa";
            this.bt_Xoa.Id = 2;
            this.bt_Xoa.ImageOptions.Image = global::QLy_filehosonhansu.Properties.Resources.deletegroupfooter_16x16;
            this.bt_Xoa.ImageOptions.LargeImage = global::QLy_filehosonhansu.Properties.Resources.deletegroupfooter_32x32;
            this.bt_Xoa.Name = "bt_Xoa";
            this.bt_Xoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bt_Xoa_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(800, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 620);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(800, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 590);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(800, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 590);
            // 
            // sidePanel1
            // 
            this.sidePanel1.Controls.Add(this.gc_HSNhanSu);
            this.sidePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.sidePanel1.Location = new System.Drawing.Point(0, 30);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(800, 229);
            this.sidePanel1.TabIndex = 9;
            this.sidePanel1.Text = "sidePanel1";
            // 
            // sidePanel2
            // 
            this.sidePanel2.Controls.Add(this.gc_FileDinhKem);
            this.sidePanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sidePanel2.Location = new System.Drawing.Point(0, 259);
            this.sidePanel2.Name = "sidePanel2";
            this.sidePanel2.Size = new System.Drawing.Size(800, 361);
            this.sidePanel2.TabIndex = 10;
            this.sidePanel2.Text = "sidePanel2";
            // 
            // gc_HSNhanSu
            // 
            this.gc_HSNhanSu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_HSNhanSu.Location = new System.Drawing.Point(0, 0);
            this.gc_HSNhanSu.MainView = this.gv_HSNhanSu;
            this.gc_HSNhanSu.MenuManager = this.barManager1;
            this.gc_HSNhanSu.Name = "gc_HSNhanSu";
            this.gc_HSNhanSu.Size = new System.Drawing.Size(800, 228);
            this.gc_HSNhanSu.TabIndex = 6;
            this.gc_HSNhanSu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_HSNhanSu});
            // 
            // gv_HSNhanSu
            // 
            this.gv_HSNhanSu.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn6,
            this.gridColumn8,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn7});
            this.gv_HSNhanSu.GridControl = this.gc_HSNhanSu;
            this.gv_HSNhanSu.Name = "gv_HSNhanSu";
            this.gv_HSNhanSu.OptionsBehavior.Editable = false;
            this.gv_HSNhanSu.OptionsView.ShowAutoFilterRow = true;
            this.gv_HSNhanSu.OptionsView.ShowDetailButtons = false;
            this.gv_HSNhanSu.OptionsView.ShowGroupPanel = false;
            this.gv_HSNhanSu.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gv_HSNhanSu_FocusedRowChanged);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "ID";
            this.gridColumn1.FieldName = "ID";
            this.gridColumn1.MinWidth = 25;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Width = 94;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Mã Nhân Sự";
            this.gridColumn2.FieldName = "MaNS";
            this.gridColumn2.MinWidth = 25;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 94;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Họ và Tên";
            this.gridColumn6.FieldName = "HovaTen";
            this.gridColumn6.MinWidth = 25;
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 1;
            this.gridColumn6.Width = 94;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Số CMND";
            this.gridColumn8.FieldName = "SoCMND";
            this.gridColumn8.MinWidth = 25;
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 2;
            this.gridColumn8.Width = 94;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Ngày Sinh";
            this.gridColumn3.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.gridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumn3.FieldName = "NgaySinh";
            this.gridColumn3.GroupFormat.FormatString = "dd/MM/yyyy";
            this.gridColumn3.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumn3.MinWidth = 25;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 3;
            this.gridColumn3.Width = 94;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Địa Chỉ";
            this.gridColumn4.FieldName = "DiaChi";
            this.gridColumn4.MinWidth = 25;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 4;
            this.gridColumn4.Width = 94;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Số Điện Thoại";
            this.gridColumn5.FieldName = "SoDienThoai";
            this.gridColumn5.MinWidth = 25;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 5;
            this.gridColumn5.Width = 94;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Email";
            this.gridColumn7.FieldName = "Email";
            this.gridColumn7.MinWidth = 25;
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 6;
            this.gridColumn7.Width = 94;
            // 
            // gc_FileDinhKem
            // 
            this.gc_FileDinhKem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_FileDinhKem.Location = new System.Drawing.Point(0, 0);
            this.gc_FileDinhKem.MainView = this.gv_FileDinhKem;
            this.gc_FileDinhKem.MenuManager = this.barManager1;
            this.gc_FileDinhKem.Name = "gc_FileDinhKem";
            this.gc_FileDinhKem.Size = new System.Drawing.Size(800, 361);
            this.gc_FileDinhKem.TabIndex = 0;
            this.gc_FileDinhKem.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_FileDinhKem});
            // 
            // gv_FileDinhKem
            // 
            this.gv_FileDinhKem.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn12,
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn11,
            this.gridColumn13,
            this.gridColumn14,
            this.gridColumn15});
            this.gv_FileDinhKem.GridControl = this.gc_FileDinhKem;
            this.gv_FileDinhKem.Name = "gv_FileDinhKem";
            this.gv_FileDinhKem.OptionsBehavior.Editable = false;
            this.gv_FileDinhKem.OptionsView.ShowAutoFilterRow = true;
            this.gv_FileDinhKem.OptionsView.ShowDetailButtons = false;
            this.gv_FileDinhKem.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "STT";
            this.gridColumn9.FieldName = "STT";
            this.gridColumn9.MinWidth = 25;
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 0;
            this.gridColumn9.Width = 62;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Tên File";
            this.gridColumn10.FieldName = "TenFile";
            this.gridColumn10.MinWidth = 25;
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 1;
            this.gridColumn10.Width = 200;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "Đường Link";
            this.gridColumn11.FieldName = "DuongDan";
            this.gridColumn11.MinWidth = 25;
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 2;
            this.gridColumn11.Width = 535;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "ID";
            this.gridColumn12.FieldName = "ID";
            this.gridColumn12.MinWidth = 25;
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.Width = 94;
            // 
            // gridColumn13
            // 
            this.gridColumn13.Caption = "IDHOSONHANSU";
            this.gridColumn13.FieldName = "IDHOSONHANSU";
            this.gridColumn13.MinWidth = 25;
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.Width = 94;
            // 
            // gridColumn14
            // 
            this.gridColumn14.Caption = "DungLuong";
            this.gridColumn14.FieldName = "DungLuong";
            this.gridColumn14.MinWidth = 25;
            this.gridColumn14.Name = "gridColumn14";
            this.gridColumn14.Width = 94;
            // 
            // gridColumn15
            // 
            this.gridColumn15.Caption = "KieuFile";
            this.gridColumn15.FieldName = "KieuFile";
            this.gridColumn15.MinWidth = 25;
            this.gridColumn15.Name = "gridColumn15";
            this.gridColumn15.Width = 94;
            // 
            // frmHoSo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 620);
            this.Controls.Add(this.sidePanel2);
            this.Controls.Add(this.sidePanel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.KeyPreview = true;
            this.Name = "frmHoSo";
            this.Text = "Hồ Sơ Nhân Sự";
            this.Load += new System.EventHandler(this.frmHoSoNhanSu_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmHoSoNhanSu_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.sidePanel1.ResumeLayout(false);
            this.sidePanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_HSNhanSu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_HSNhanSu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_FileDinhKem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_FileDinhKem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem bt_Them;
        private DevExpress.XtraBars.BarButtonItem bt_ChinhSua;
        private DevExpress.XtraBars.BarButtonItem bt_Xoa;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.SidePanel sidePanel2;
        private DevExpress.XtraGrid.GridControl gc_FileDinhKem;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_FileDinhKem;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraEditors.SidePanel sidePanel1;
        private DevExpress.XtraGrid.GridControl gc_HSNhanSu;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_HSNhanSu;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn15;
    }
}
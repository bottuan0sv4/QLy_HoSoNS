﻿
namespace QLy_filehosonhansu
{
    partial class frmCapNhatHS
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
            this.bt_Huy = new DevExpress.XtraEditors.SimpleButton();
            this.date_NgaySinh = new DevExpress.XtraEditors.DateEdit();
            this.txt_HovaTen = new DevExpress.XtraEditors.TextEdit();
            this.HovaTen = new DevExpress.XtraEditors.LabelControl();
            this.txt_DiaChi = new DevExpress.XtraEditors.TextEdit();
            this.txt_SDT = new DevExpress.XtraEditors.TextEdit();
            this.SDT = new DevExpress.XtraEditors.LabelControl();
            this.txt_Email = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txt_SoCMND = new DevExpress.XtraEditors.TextEdit();
            this.SoCMND = new DevExpress.XtraEditors.LabelControl();
            this.dat = new DevExpress.XtraEditors.LabelControl();
            this.txt_MaNS = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.Email = new DevExpress.XtraEditors.LabelControl();
            this.bt_XacNhan = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.date_NgaySinh.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_NgaySinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_HovaTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SDT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Email.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SoCMND.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaNS.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_Huy
            // 
            this.bt_Huy.ImageOptions.SvgImage = global::QLy_filehosonhansu.Properties.Resources.actions_forbid;
            this.bt_Huy.Location = new System.Drawing.Point(680, 103);
            this.bt_Huy.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Huy.Name = "bt_Huy";
            this.bt_Huy.Size = new System.Drawing.Size(125, 46);
            this.bt_Huy.TabIndex = 36;
            this.bt_Huy.Text = "Hủy";
            this.bt_Huy.Click += new System.EventHandler(this.bt_Huy_Click);
            // 
            // date_NgaySinh
            // 
            this.date_NgaySinh.EditValue = null;
            this.date_NgaySinh.Location = new System.Drawing.Point(508, 74);
            this.date_NgaySinh.Margin = new System.Windows.Forms.Padding(4);
            this.date_NgaySinh.Name = "date_NgaySinh";
            this.date_NgaySinh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_NgaySinh.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_NgaySinh.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.date_NgaySinh.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.date_NgaySinh.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.date_NgaySinh.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.date_NgaySinh.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.date_NgaySinh.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.date_NgaySinh.Size = new System.Drawing.Size(125, 22);
            this.date_NgaySinh.TabIndex = 35;
            // 
            // txt_HovaTen
            // 
            this.txt_HovaTen.Location = new System.Drawing.Point(109, 42);
            this.txt_HovaTen.Margin = new System.Windows.Forms.Padding(4);
            this.txt_HovaTen.Name = "txt_HovaTen";
            this.txt_HovaTen.Size = new System.Drawing.Size(229, 22);
            this.txt_HovaTen.TabIndex = 34;
            // 
            // HovaTen
            // 
            this.HovaTen.Location = new System.Drawing.Point(13, 45);
            this.HovaTen.Margin = new System.Windows.Forms.Padding(4);
            this.HovaTen.Name = "HovaTen";
            this.HovaTen.Size = new System.Drawing.Size(63, 17);
            this.HovaTen.TabIndex = 33;
            this.HovaTen.Text = "Họ và Tên";
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Location = new System.Drawing.Point(730, 74);
            this.txt_DiaChi.Margin = new System.Windows.Forms.Padding(4);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(75, 22);
            this.txt_DiaChi.TabIndex = 32;
            // 
            // txt_SDT
            // 
            this.txt_SDT.Location = new System.Drawing.Point(508, 42);
            this.txt_SDT.Margin = new System.Windows.Forms.Padding(4);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(297, 22);
            this.txt_SDT.TabIndex = 29;
            this.txt_SDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SDT_KeyPress);
            // 
            // SDT
            // 
            this.SDT.Location = new System.Drawing.Point(387, 45);
            this.SDT.Margin = new System.Windows.Forms.Padding(4);
            this.SDT.Name = "SDT";
            this.SDT.Size = new System.Drawing.Size(84, 17);
            this.SDT.TabIndex = 28;
            this.SDT.Text = "Số Điện Thoại";
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(508, 10);
            this.txt_Email.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(297, 22);
            this.txt_Email.TabIndex = 27;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(680, 77);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(42, 17);
            this.labelControl4.TabIndex = 26;
            this.labelControl4.Text = "Địa Chỉ";
            // 
            // txt_SoCMND
            // 
            this.txt_SoCMND.Location = new System.Drawing.Point(109, 74);
            this.txt_SoCMND.Margin = new System.Windows.Forms.Padding(4);
            this.txt_SoCMND.Name = "txt_SoCMND";
            this.txt_SoCMND.Size = new System.Drawing.Size(229, 22);
            this.txt_SoCMND.TabIndex = 25;
            this.txt_SoCMND.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SoCMND_KeyPress);
            // 
            // SoCMND
            // 
            this.SoCMND.Location = new System.Drawing.Point(13, 77);
            this.SoCMND.Margin = new System.Windows.Forms.Padding(4);
            this.SoCMND.Name = "SoCMND";
            this.SoCMND.Size = new System.Drawing.Size(58, 17);
            this.SoCMND.TabIndex = 24;
            this.SoCMND.Text = "Số CMND";
            // 
            // dat
            // 
            this.dat.Location = new System.Drawing.Point(387, 77);
            this.dat.Margin = new System.Windows.Forms.Padding(4);
            this.dat.Name = "dat";
            this.dat.Size = new System.Drawing.Size(57, 16);
            this.dat.TabIndex = 23;
            this.dat.Text = "Ngày Sinh";
            // 
            // txt_MaNS
            // 
            this.txt_MaNS.Location = new System.Drawing.Point(109, 10);
            this.txt_MaNS.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MaNS.Name = "txt_MaNS";
            this.txt_MaNS.Size = new System.Drawing.Size(229, 22);
            this.txt_MaNS.TabIndex = 22;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(13, 13);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(74, 17);
            this.labelControl1.TabIndex = 21;
            this.labelControl1.Text = "Mã Nhân Sự";
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(387, 13);
            this.Email.Margin = new System.Windows.Forms.Padding(4);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(31, 16);
            this.Email.TabIndex = 37;
            this.Email.Text = "Email";
            // 
            // bt_XacNhan
            // 
            this.bt_XacNhan.ImageOptions.Image = global::QLy_filehosonhansu.Properties.Resources.apply_32x32;
            this.bt_XacNhan.Location = new System.Drawing.Point(508, 103);
            this.bt_XacNhan.Margin = new System.Windows.Forms.Padding(4);
            this.bt_XacNhan.Name = "bt_XacNhan";
            this.bt_XacNhan.Size = new System.Drawing.Size(125, 46);
            this.bt_XacNhan.TabIndex = 31;
            this.bt_XacNhan.Text = "Xác Nhận";
            this.bt_XacNhan.Click += new System.EventHandler(this.bt_XacNhan_Click);
            // 
            // frmCapNhatHS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 163);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.bt_Huy);
            this.Controls.Add(this.date_NgaySinh);
            this.Controls.Add(this.txt_HovaTen);
            this.Controls.Add(this.HovaTen);
            this.Controls.Add(this.txt_DiaChi);
            this.Controls.Add(this.bt_XacNhan);
            this.Controls.Add(this.txt_SDT);
            this.Controls.Add(this.SDT);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txt_SoCMND);
            this.Controls.Add(this.SoCMND);
            this.Controls.Add(this.dat);
            this.Controls.Add(this.txt_MaNS);
            this.Controls.Add(this.labelControl1);
            this.MaximizeBox = false;
            this.Name = "frmCapNhatHS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cập nhật hồ sơ";
            this.Load += new System.EventHandler(this.frmCapNhatHSNS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.date_NgaySinh.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_NgaySinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_HovaTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SDT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Email.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SoCMND.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaNS.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton bt_Huy;
        private DevExpress.XtraEditors.DateEdit date_NgaySinh;
        private DevExpress.XtraEditors.TextEdit txt_HovaTen;
        private DevExpress.XtraEditors.LabelControl HovaTen;
        private DevExpress.XtraEditors.TextEdit txt_DiaChi;
        private DevExpress.XtraEditors.SimpleButton bt_XacNhan;
        private DevExpress.XtraEditors.TextEdit txt_SDT;
        private DevExpress.XtraEditors.LabelControl SDT;
        private DevExpress.XtraEditors.TextEdit txt_Email;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txt_SoCMND;
        private DevExpress.XtraEditors.LabelControl SoCMND;
        private DevExpress.XtraEditors.LabelControl dat;
        private DevExpress.XtraEditors.TextEdit txt_MaNS;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl Email;
    }
}
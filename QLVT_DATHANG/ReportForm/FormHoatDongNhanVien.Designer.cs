using DevExpress.XtraEditors;
using System.Windows.Forms;

namespace QLVT_DATHANG.ReportForm
{
    partial class FormHoatDongNhanVien
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
            this.label1 = new System.Windows.Forms.Label();
            this.DiaChiTb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.NgaySinhTb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ChonNVBtn = new System.Windows.Forms.Button();
            this.HoTenTb = new System.Windows.Forms.TextBox();
            this.MaNVTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.XuatBanBtb = new System.Windows.Forms.Button();
            this.XemTruocBtn = new System.Windows.Forms.Button();
            this.FromDateDE = new DevExpress.XtraEditors.DateEdit();
            this.ToDateDE = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.FromDateDE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FromDateDE.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToDateDE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToDateDE.Properties.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(123, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "HOẠT ĐỘNG NHÂN VIÊN";
            // 
            // DiaChiTb
            // 
            this.DiaChiTb.Enabled = false;
            this.DiaChiTb.Location = new System.Drawing.Point(196, 160);
            this.DiaChiTb.Margin = new System.Windows.Forms.Padding(2);
            this.DiaChiTb.Name = "DiaChiTb";
            this.DiaChiTb.Size = new System.Drawing.Size(128, 21);
            this.DiaChiTb.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(68, 161);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 17);
            this.label8.TabIndex = 27;
            this.label8.Text = "Địa Chỉ";
            // 
            // NgaySinhTb
            // 
            this.NgaySinhTb.Enabled = false;
            this.NgaySinhTb.Location = new System.Drawing.Point(196, 202);
            this.NgaySinhTb.Margin = new System.Windows.Forms.Padding(2);
            this.NgaySinhTb.Name = "NgaySinhTb";
            this.NgaySinhTb.Size = new System.Drawing.Size(128, 21);
            this.NgaySinhTb.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(68, 206);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 17);
            this.label7.TabIndex = 25;
            this.label7.Text = "Ngày Sinh";
            // 
            // ChonNVBtn
            // 
            this.ChonNVBtn.BackColor = System.Drawing.Color.MistyRose;
            this.ChonNVBtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ChonNVBtn.Location = new System.Drawing.Point(379, 164);
            this.ChonNVBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ChonNVBtn.Name = "ChonNVBtn";
            this.ChonNVBtn.Size = new System.Drawing.Size(128, 63);
            this.ChonNVBtn.TabIndex = 24;
            this.ChonNVBtn.Text = "Chọn Nhân Viên";
            this.ChonNVBtn.UseVisualStyleBackColor = false;
            this.ChonNVBtn.Click += new System.EventHandler(this.ChonNVBtn_Click);
            // 
            // HoTenTb
            // 
            this.HoTenTb.Enabled = false;
            this.HoTenTb.Location = new System.Drawing.Point(196, 120);
            this.HoTenTb.Margin = new System.Windows.Forms.Padding(2);
            this.HoTenTb.Name = "HoTenTb";
            this.HoTenTb.Size = new System.Drawing.Size(128, 21);
            this.HoTenTb.TabIndex = 23;
            // 
            // MaNVTb
            // 
            this.MaNVTb.Enabled = false;
            this.MaNVTb.Location = new System.Drawing.Point(196, 79);
            this.MaNVTb.Margin = new System.Windows.Forms.Padding(2);
            this.MaNVTb.Name = "MaNVTb";
            this.MaNVTb.Size = new System.Drawing.Size(128, 21);
            this.MaNVTb.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(68, 290);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Tới Ngày";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(68, 244);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Từ Ngày";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(68, 121);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Họ Và Tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Mã Nhân Viên";
            // 
            // XuatBanBtb
            // 
            this.XuatBanBtb.BackColor = System.Drawing.Color.OrangeRed;
            this.XuatBanBtb.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XuatBanBtb.ForeColor = System.Drawing.Color.White;
            this.XuatBanBtb.Location = new System.Drawing.Point(340, 353);
            this.XuatBanBtb.Margin = new System.Windows.Forms.Padding(2);
            this.XuatBanBtb.Name = "XuatBanBtb";
            this.XuatBanBtb.Size = new System.Drawing.Size(136, 44);
            this.XuatBanBtb.TabIndex = 30;
            this.XuatBanBtb.Text = "XUẤT BẢN";
            this.XuatBanBtb.UseVisualStyleBackColor = false;
            this.XuatBanBtb.Click += new System.EventHandler(this.XuatBanBtb_Click);
            // 
            // XemTruocBtn
            // 
            this.XemTruocBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.XemTruocBtn.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XemTruocBtn.ForeColor = System.Drawing.Color.White;
            this.XemTruocBtn.Location = new System.Drawing.Point(86, 353);
            this.XemTruocBtn.Margin = new System.Windows.Forms.Padding(2);
            this.XemTruocBtn.Name = "XemTruocBtn";
            this.XemTruocBtn.Size = new System.Drawing.Size(136, 44);
            this.XemTruocBtn.TabIndex = 29;
            this.XemTruocBtn.Text = "XEM TRƯỚC";
            this.XemTruocBtn.UseVisualStyleBackColor = false;
            this.XemTruocBtn.Click += new System.EventHandler(this.XemTruocBtn_Click);
            // 
            // FromDateDE
            // 
            this.FromDateDE.EditValue = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            this.FromDateDE.Location = new System.Drawing.Point(196, 244);
            this.FromDateDE.Name = "FromDateDE";
            this.FromDateDE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.FromDateDE.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.FromDateDE.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.FromDateDE.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.FromDateDE.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.FromDateDE.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.FromDateDE.Size = new System.Drawing.Size(128, 20);
            this.FromDateDE.TabIndex = 31;
            // 
            // ToDateDE
            // 
            this.ToDateDE.EditValue = new System.DateTime(2024, 12, 31, 0, 0, 0, 0);
            this.ToDateDE.Location = new System.Drawing.Point(196, 290);
            this.ToDateDE.Name = "ToDateDE";
            this.ToDateDE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ToDateDE.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ToDateDE.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.ToDateDE.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.ToDateDE.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.ToDateDE.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.ToDateDE.Size = new System.Drawing.Size(128, 20);
            this.ToDateDE.TabIndex = 32;
            // 
            // FormHoatDongNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 421);
            this.Controls.Add(this.ToDateDE);
            this.Controls.Add(this.FromDateDE);
            this.Controls.Add(this.XuatBanBtb);
            this.Controls.Add(this.XemTruocBtn);
            this.Controls.Add(this.DiaChiTb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.NgaySinhTb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ChonNVBtn);
            this.Controls.Add(this.HoTenTb);
            this.Controls.Add(this.MaNVTb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormHoatDongNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormHoatDongNhanVien";
            ((System.ComponentModel.ISupportInitialize)(this.FromDateDE.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FromDateDE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToDateDE.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToDateDE.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DiaChiTb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox NgaySinhTb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button ChonNVBtn;
        private System.Windows.Forms.TextBox HoTenTb;
        private System.Windows.Forms.TextBox MaNVTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button XuatBanBtb;
        private System.Windows.Forms.Button XemTruocBtn;
        private DevExpress.XtraEditors.DateEdit FromDateDE;
        private DevExpress.XtraEditors.DateEdit ToDateDE;
    }
}
using System.Windows.Forms;

namespace QLVT_DATHANG.ReportForm
{
    partial class FormChiTietNhapXuat
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
            this.LoaiPhieuCb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.XuatBanBtn = new System.Windows.Forms.Button();
            this.XemTruocBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DateFromDE = new DevExpress.XtraEditors.DateEdit();
            this.DateToDE = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.DateFromDE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateFromDE.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateToDE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateToDE.Properties.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(630, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "CHI TIẾT SỐ LƯỢNG HÀNG HÓA NHẬP XUẤT";
            // 
            // LoaiPhieuCb
            // 
            this.LoaiPhieuCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LoaiPhieuCb.FormattingEnabled = true;
            this.LoaiPhieuCb.Items.AddRange(new object[] {
            "NHAP",
            "XUAT"});
            this.LoaiPhieuCb.Location = new System.Drawing.Point(162, 92);
            this.LoaiPhieuCb.Name = "LoaiPhieuCb";
            this.LoaiPhieuCb.Size = new System.Drawing.Size(125, 21);
            this.LoaiPhieuCb.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Loại Phiếu";
            // 
            // XuatBanBtn
            // 
            this.XuatBanBtn.BackColor = System.Drawing.Color.OrangeRed;
            this.XuatBanBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XuatBanBtn.ForeColor = System.Drawing.Color.White;
            this.XuatBanBtn.Location = new System.Drawing.Point(406, 221);
            this.XuatBanBtn.Name = "XuatBanBtn";
            this.XuatBanBtn.Size = new System.Drawing.Size(184, 46);
            this.XuatBanBtn.TabIndex = 10;
            this.XuatBanBtn.Text = "XUẤT BẢN";
            this.XuatBanBtn.UseVisualStyleBackColor = false;
            this.XuatBanBtn.Click += new System.EventHandler(this.XuatBanBtn_Click);
            // 
            // XemTruocBtn
            // 
            this.XemTruocBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.XemTruocBtn.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XemTruocBtn.ForeColor = System.Drawing.Color.White;
            this.XemTruocBtn.Location = new System.Drawing.Point(82, 221);
            this.XemTruocBtn.Name = "XemTruocBtn";
            this.XemTruocBtn.Size = new System.Drawing.Size(184, 46);
            this.XemTruocBtn.TabIndex = 9;
            this.XemTruocBtn.Text = "XEM TRƯỚC";
            this.XemTruocBtn.UseVisualStyleBackColor = false;
            this.XemTruocBtn.Click += new System.EventHandler(this.XemTruocBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(351, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Tới Ngày";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Từ Ngày";
            // 
            // DateFromDE
            // 
            this.DateFromDE.EditValue = null;
            this.DateFromDE.Location = new System.Drawing.Point(160, 158);
            this.DateFromDE.Name = "DateFromDE";
            this.DateFromDE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DateFromDE.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DateFromDE.Size = new System.Drawing.Size(145, 20);
            this.DateFromDE.TabIndex = 13;
            // 
            // DateToDE
            // 
            this.DateToDE.EditValue = null;
            this.DateToDE.Location = new System.Drawing.Point(445, 158);
            this.DateToDE.Name = "DateToDE";
            this.DateToDE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DateToDE.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DateToDE.Size = new System.Drawing.Size(145, 20);
            this.DateToDE.TabIndex = 15;
            // 
            // FormChiTietNhapXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 294);
            this.Controls.Add(this.DateToDE);
            this.Controls.Add(this.DateFromDE);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.XuatBanBtn);
            this.Controls.Add(this.XemTruocBtn);
            this.Controls.Add(this.LoaiPhieuCb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormChiTietNhapXuat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormChiTietNhapXuat";
            this.Load += new System.EventHandler(this.FormChiTietNhapXuat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DateFromDE.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateFromDE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateToDE.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateToDE.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox LoaiPhieuCb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button XuatBanBtn;
        private System.Windows.Forms.Button XemTruocBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.DateEdit DateFromDE;
        private DevExpress.XtraEditors.DateEdit DateToDE;
    }
}
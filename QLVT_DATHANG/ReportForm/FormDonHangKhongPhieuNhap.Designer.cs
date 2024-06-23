namespace QLVT_DATHANG.ReportForm
{
    partial class FormDonHangKhongPhieuNhap
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
            this.ChiNhanhCb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.XuatBanBtn = new System.Windows.Forms.Button();
            this.XemTruocBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(407, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Đơn Hàng Không Phiếu Nhập";
            // 
            // ChiNhanhCb
            // 
            this.ChiNhanhCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChiNhanhCb.Enabled = false;
            this.ChiNhanhCb.FormattingEnabled = true;
            this.ChiNhanhCb.Location = new System.Drawing.Point(178, 104);
            this.ChiNhanhCb.Margin = new System.Windows.Forms.Padding(2);
            this.ChiNhanhCb.Name = "ChiNhanhCb";
            this.ChiNhanhCb.Size = new System.Drawing.Size(238, 21);
            this.ChiNhanhCb.TabIndex = 5;
            this.ChiNhanhCb.SelectedIndexChanged += new System.EventHandler(this.ChiNhanhCb_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Chi Nhánh";
            // 
            // XuatBanBtn
            // 
            this.XuatBanBtn.BackColor = System.Drawing.Color.OrangeRed;
            this.XuatBanBtn.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XuatBanBtn.ForeColor = System.Drawing.Color.White;
            this.XuatBanBtn.Location = new System.Drawing.Point(262, 162);
            this.XuatBanBtn.Margin = new System.Windows.Forms.Padding(2);
            this.XuatBanBtn.Name = "XuatBanBtn";
            this.XuatBanBtn.Size = new System.Drawing.Size(130, 28);
            this.XuatBanBtn.TabIndex = 7;
            this.XuatBanBtn.Text = "XUẤT BẢN";
            this.XuatBanBtn.UseVisualStyleBackColor = false;
            this.XuatBanBtn.Click += new System.EventHandler(this.XuatBanBtn_Click);
            // 
            // XemTruocBtn
            // 
            this.XemTruocBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.XemTruocBtn.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XemTruocBtn.ForeColor = System.Drawing.Color.White;
            this.XemTruocBtn.Location = new System.Drawing.Point(84, 162);
            this.XemTruocBtn.Margin = new System.Windows.Forms.Padding(2);
            this.XemTruocBtn.Name = "XemTruocBtn";
            this.XemTruocBtn.Size = new System.Drawing.Size(130, 28);
            this.XemTruocBtn.TabIndex = 6;
            this.XemTruocBtn.Text = "XEM TRƯỚC";
            this.XemTruocBtn.UseVisualStyleBackColor = false;
            this.XemTruocBtn.Click += new System.EventHandler(this.XemTruocBtn_Click);
            // 
            // FormDonHangKhongPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 228);
            this.Controls.Add(this.XuatBanBtn);
            this.Controls.Add(this.XemTruocBtn);
            this.Controls.Add(this.ChiNhanhCb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormDonHangKhongPhieuNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDonHangKhongPhieuNhap";
            this.Load += new System.EventHandler(this.FormDonHangKhongPhieuNhap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ChiNhanhCb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button XuatBanBtn;
        private System.Windows.Forms.Button XemTruocBtn;
    }
}
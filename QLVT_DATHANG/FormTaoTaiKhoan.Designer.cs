
namespace QLTVT
{
    partial class FormTaoTaiKhoan
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
            this.label3 = new System.Windows.Forms.Label();
            this.MaNVTb = new DevExpress.XtraEditors.TextEdit();
            this.ChonNVBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.XacNhanMKTb = new DevExpress.XtraEditors.TextEdit();
            this.MatKhauTb = new DevExpress.XtraEditors.TextEdit();
            this.XacNhanBtn = new System.Windows.Forms.Button();
            this.ThoatBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ChiNhanhRb = new System.Windows.Forms.RadioButton();
            this.UserRb = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.MaNVTb.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XacNhanMKTb.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MatKhauTb.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(174, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "TẠO TÀI KHOẢN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(72, 95);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Mã Nhân Viên";
            // 
            // MaNVTb
            // 
            this.MaNVTb.Enabled = false;
            this.MaNVTb.Location = new System.Drawing.Point(232, 92);
            this.MaNVTb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaNVTb.Name = "MaNVTb";
            this.MaNVTb.Size = new System.Drawing.Size(107, 20);
            this.MaNVTb.TabIndex = 18;
            // 
            // ChonNVBtn
            // 
            this.ChonNVBtn.Location = new System.Drawing.Point(360, 91);
            this.ChonNVBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ChonNVBtn.Name = "ChonNVBtn";
            this.ChonNVBtn.Size = new System.Drawing.Size(118, 27);
            this.ChonNVBtn.TabIndex = 19;
            this.ChonNVBtn.Text = "Chọn Nhân Viên";
            this.ChonNVBtn.UseVisualStyleBackColor = true;
            this.ChonNVBtn.Click += new System.EventHandler(this.btnChonNhanVien_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(72, 143);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Mật Khẩu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(72, 187);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Xác Nhận Mật Khẩu";
            // 
            // XacNhanMKTb
            // 
            this.XacNhanMKTb.EditValue = "123456";
            this.XacNhanMKTb.Location = new System.Drawing.Point(232, 188);
            this.XacNhanMKTb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.XacNhanMKTb.Name = "XacNhanMKTb";
            this.XacNhanMKTb.Properties.PasswordChar = '*';
            this.XacNhanMKTb.Size = new System.Drawing.Size(107, 20);
            this.XacNhanMKTb.TabIndex = 22;
            // 
            // MatKhauTb
            // 
            this.MatKhauTb.EditValue = "123456";
            this.MatKhauTb.Location = new System.Drawing.Point(232, 140);
            this.MatKhauTb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MatKhauTb.Name = "MatKhauTb";
            this.MatKhauTb.Properties.PasswordChar = '*';
            this.MatKhauTb.Size = new System.Drawing.Size(107, 20);
            this.MatKhauTb.TabIndex = 23;
            // 
            // XacNhanBtn
            // 
            this.XacNhanBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.XacNhanBtn.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XacNhanBtn.ForeColor = System.Drawing.Color.White;
            this.XacNhanBtn.Location = new System.Drawing.Point(75, 306);
            this.XacNhanBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.XacNhanBtn.Name = "XacNhanBtn";
            this.XacNhanBtn.Size = new System.Drawing.Size(131, 36);
            this.XacNhanBtn.TabIndex = 24;
            this.XacNhanBtn.Text = "XÁC NHẬN";
            this.XacNhanBtn.UseVisualStyleBackColor = false;
            this.XacNhanBtn.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // ThoatBtn
            // 
            this.ThoatBtn.BackColor = System.Drawing.Color.OrangeRed;
            this.ThoatBtn.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThoatBtn.ForeColor = System.Drawing.Color.White;
            this.ThoatBtn.Location = new System.Drawing.Point(347, 306);
            this.ThoatBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ThoatBtn.Name = "ThoatBtn";
            this.ThoatBtn.Size = new System.Drawing.Size(131, 36);
            this.ThoatBtn.TabIndex = 25;
            this.ThoatBtn.Text = "THOÁT";
            this.ThoatBtn.UseVisualStyleBackColor = false;
            this.ThoatBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "Vai Trò";
            // 
            // ChiNhanhRb
            // 
            this.ChiNhanhRb.AutoSize = true;
            this.ChiNhanhRb.Checked = true;
            this.ChiNhanhRb.Location = new System.Drawing.Point(232, 234);
            this.ChiNhanhRb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ChiNhanhRb.Name = "ChiNhanhRb";
            this.ChiNhanhRb.Size = new System.Drawing.Size(74, 17);
            this.ChiNhanhRb.TabIndex = 27;
            this.ChiNhanhRb.TabStop = true;
            this.ChiNhanhRb.Text = "Chi Nhánh";
            this.ChiNhanhRb.UseVisualStyleBackColor = true;
            // 
            // UserRb
            // 
            this.UserRb.AutoSize = true;
            this.UserRb.Location = new System.Drawing.Point(360, 234);
            this.UserRb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UserRb.Name = "UserRb";
            this.UserRb.Size = new System.Drawing.Size(47, 17);
            this.UserRb.TabIndex = 28;
            this.UserRb.Text = "User";
            this.UserRb.UseVisualStyleBackColor = true;
            // 
            // FormTaoTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 393);
            this.Controls.Add(this.UserRb);
            this.Controls.Add(this.ChiNhanhRb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ThoatBtn);
            this.Controls.Add(this.XacNhanBtn);
            this.Controls.Add(this.MatKhauTb);
            this.Controls.Add(this.XacNhanMKTb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ChonNVBtn);
            this.Controls.Add(this.MaNVTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormTaoTaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tạo Tài Khoản";
            this.Load += new System.EventHandler(this.FormTaoTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MaNVTb.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XacNhanMKTb.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MatKhauTb.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit MaNVTb;
        private System.Windows.Forms.Button ChonNVBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.TextEdit XacNhanMKTb;
        private DevExpress.XtraEditors.TextEdit MatKhauTb;
        private System.Windows.Forms.Button XacNhanBtn;
        private System.Windows.Forms.Button ThoatBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton ChiNhanhRb;
        private System.Windows.Forms.RadioButton UserRb;
    }
}
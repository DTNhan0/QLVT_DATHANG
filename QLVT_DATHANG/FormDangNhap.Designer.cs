namespace QLVT_DATHANG
{
    partial class FormDangNhap
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ThoatBtn = new System.Windows.Forms.Button();
            this.DangNhapBtn = new System.Windows.Forms.Button();
            this.MatKhauTf = new System.Windows.Forms.TextBox();
            this.TaiKhoanTf = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chi nhánh:";
            // 
            // ChiNhanhCb
            // 
            this.ChiNhanhCb.FormattingEnabled = true;
            this.ChiNhanhCb.Location = new System.Drawing.Point(92, 25);
            this.ChiNhanhCb.Name = "ChiNhanhCb";
            this.ChiNhanhCb.Size = new System.Drawing.Size(273, 27);
            this.ChiNhanhCb.TabIndex = 1;
            this.ChiNhanhCb.SelectedIndexChanged += new System.EventHandler(this.ChiNhanhCb_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ThoatBtn);
            this.panel1.Controls.Add(this.DangNhapBtn);
            this.panel1.Controls.Add(this.MatKhauTf);
            this.panel1.Controls.Add(this.TaiKhoanTf);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.ChiNhanhCb);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(12, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 236);
            this.panel1.TabIndex = 2;
            // 
            // ThoatBtn
            // 
            this.ThoatBtn.Location = new System.Drawing.Point(234, 177);
            this.ThoatBtn.Name = "ThoatBtn";
            this.ThoatBtn.Size = new System.Drawing.Size(90, 30);
            this.ThoatBtn.TabIndex = 7;
            this.ThoatBtn.Text = "Thoát";
            this.ThoatBtn.UseVisualStyleBackColor = true;
            this.ThoatBtn.Click += new System.EventHandler(this.ThoatBtn_Click);
            // 
            // DangNhapBtn
            // 
            this.DangNhapBtn.Location = new System.Drawing.Point(114, 177);
            this.DangNhapBtn.Name = "DangNhapBtn";
            this.DangNhapBtn.Size = new System.Drawing.Size(94, 30);
            this.DangNhapBtn.TabIndex = 6;
            this.DangNhapBtn.Text = "Đăng nhập";
            this.DangNhapBtn.UseVisualStyleBackColor = true;
            this.DangNhapBtn.Click += new System.EventHandler(this.DangNhapBtn_Click);
            // 
            // MatKhauTf
            // 
            this.MatKhauTf.Location = new System.Drawing.Point(92, 129);
            this.MatKhauTf.Name = "MatKhauTf";
            this.MatKhauTf.PasswordChar = '*';
            this.MatKhauTf.Size = new System.Drawing.Size(273, 27);
            this.MatKhauTf.TabIndex = 5;
            // 
            // TaiKhoanTf
            // 
            this.TaiKhoanTf.Location = new System.Drawing.Point(92, 77);
            this.TaiKhoanTf.Name = "TaiKhoanTf";
            this.TaiKhoanTf.Size = new System.Drawing.Size(273, 27);
            this.TaiKhoanTf.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mật khẩu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tài khoản:";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 287);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(122, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 26);
            this.label4.TabIndex = 9;
            this.label4.Text = "QUẢN LÝ VẬT TƯ";
            // 
            // FormDangNhap
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(423, 287);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "FormDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.FormDangNhap_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ChiNhanhCb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox MatKhauTf;
        private System.Windows.Forms.TextBox TaiKhoanTf;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ThoatBtn;
        private System.Windows.Forms.Button DangNhapBtn;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label label4;
    }
}


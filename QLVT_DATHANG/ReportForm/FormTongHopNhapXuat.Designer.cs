namespace QLVT_DATHANG.ReportForm
{
    partial class FormTongHopNhapXuat
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
            this.ToDateDE = new DevExpress.XtraEditors.DateEdit();
            this.FromDateDE = new DevExpress.XtraEditors.DateEdit();
            this.XuatBanBtb = new System.Windows.Forms.Button();
            this.XemTruocBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ChiNhanhCb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ToDateDE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToDateDE.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FromDateDE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FromDateDE.Properties.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // ToDateDE
            // 
            this.ToDateDE.EditValue = new System.DateTime(2024, 12, 31, 0, 0, 0, 0);
            this.ToDateDE.Location = new System.Drawing.Point(192, 175);
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
            this.ToDateDE.TabIndex = 38;
            // 
            // FromDateDE
            // 
            this.FromDateDE.EditValue = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            this.FromDateDE.Location = new System.Drawing.Point(192, 129);
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
            this.FromDateDE.TabIndex = 37;
            // 
            // XuatBanBtb
            // 
            this.XuatBanBtb.BackColor = System.Drawing.Color.OrangeRed;
            this.XuatBanBtb.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XuatBanBtb.ForeColor = System.Drawing.Color.White;
            this.XuatBanBtb.Location = new System.Drawing.Point(293, 240);
            this.XuatBanBtb.Margin = new System.Windows.Forms.Padding(2);
            this.XuatBanBtb.Name = "XuatBanBtb";
            this.XuatBanBtb.Size = new System.Drawing.Size(136, 44);
            this.XuatBanBtb.TabIndex = 36;
            this.XuatBanBtb.Text = "XUẤT BẢN";
            this.XuatBanBtb.UseVisualStyleBackColor = false;
            this.XuatBanBtb.Click += new System.EventHandler(this.XuatBanBtb_Click);
            // 
            // XemTruocBtn
            // 
            this.XemTruocBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.XemTruocBtn.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XemTruocBtn.ForeColor = System.Drawing.Color.White;
            this.XemTruocBtn.Location = new System.Drawing.Point(73, 240);
            this.XemTruocBtn.Margin = new System.Windows.Forms.Padding(2);
            this.XemTruocBtn.Name = "XemTruocBtn";
            this.XemTruocBtn.Size = new System.Drawing.Size(136, 44);
            this.XemTruocBtn.TabIndex = 35;
            this.XemTruocBtn.Text = "XEM TRƯỚC";
            this.XemTruocBtn.UseVisualStyleBackColor = false;
            this.XemTruocBtn.Click += new System.EventHandler(this.XemTruocBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(70, 175);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 34;
            this.label5.Text = "Tới Ngày";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(70, 129);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 33;
            this.label4.Text = "Từ Ngày";
            // 
            // ChiNhanhCb
            // 
            this.ChiNhanhCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChiNhanhCb.Enabled = false;
            this.ChiNhanhCb.Location = new System.Drawing.Point(192, 84);
            this.ChiNhanhCb.Margin = new System.Windows.Forms.Padding(2);
            this.ChiNhanhCb.Name = "ChiNhanhCb";
            this.ChiNhanhCb.Size = new System.Drawing.Size(237, 21);
            this.ChiNhanhCb.TabIndex = 39;
            this.ChiNhanhCb.SelectedIndexChanged += new System.EventHandler(this.ChiNhanhCb_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 19);
            this.label2.TabIndex = 40;
            this.label2.Text = "Chi Nhánh";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 29);
            this.label1.TabIndex = 41;
            this.label1.Text = "Tổng Hợp Nhập Xuất";
            // 
            // FormTongHopNhapXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 321);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChiNhanhCb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ToDateDE);
            this.Controls.Add(this.FromDateDE);
            this.Controls.Add(this.XuatBanBtb);
            this.Controls.Add(this.XemTruocBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Name = "FormTongHopNhapXuat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTongHopNhapXuat";
            this.Load += new System.EventHandler(this.FormTongHopNhapXuat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ToDateDE.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToDateDE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FromDateDE.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FromDateDE.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.DateEdit ToDateDE;
        private DevExpress.XtraEditors.DateEdit FromDateDE;
        private System.Windows.Forms.Button XuatBanBtb;
        private System.Windows.Forms.Button XemTruocBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ChiNhanhCb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
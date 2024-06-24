using DevExpress.XtraEditors;
using QLVT_DATHANG;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTVT.SubForm
{
    public partial class FormChuyenChiNhanh : DevExpress.XtraEditors.XtraForm
    {

        public FormChuyenChiNhanh()
        {
            InitializeComponent();
        }


        private void FormChuyenChiNhanh_Load(object sender, EventArgs e)
        {
            /*Lấy dữ liệu từ form đăng nhập đổ vào nhưng chỉ lấn đúng danh sách
             phân mảnh mà thôi*/
            cmbCHINHANH.DataSource = Program.bds_dspm.DataSource;
            /*sao chep bingding source tu form dang nhap*/
            cmbCHINHANH.DisplayMember = "tencn";
            cmbCHINHANH.ValueMember = "tenserver";
            cmbCHINHANH.SelectedIndex = Program.mChiNhanh;

        }
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }
        private void cmbCHINHANH_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private Button btnTHOAT;
        private Button btnXACNHAN;
        private System.Windows.Forms.ComboBox cmbCHINHANH;



        /************************************************************
         * tạo delegate - một cái biến mà khi được gọi, nó sẽ thực hiện 1 hàm(function) khác
         * Ví dụ: ở class formNhanVien, ta có hàm chuyển chi nhánh, hàm này cần 1 tham số, chính
         * là tên server được chọn ở formChuyenChiNhanh này. Để gọi được hàm chuyển chi nhánh ở formNHANVIEN
         * Chúng ta khai báo 1 delete là branchTransfer để gọi hàm chuyển chi nhánh về form này
         *************************************************************/
        public delegate void MyDelegate(string chiNhanh);
        public MyDelegate branchTransfer;
        private void btnXACNHAN_Click(object sender, EventArgs e)
        {
            if (cmbCHINHANH.Text.Trim().Equals(""))
            {
                MessageBox.Show("Vui lòng chọn chi nhánh", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            /*Step 2*/
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn chuyển nhân viên này đi ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.OK)
            {
                branchTransfer(cmbCHINHANH.SelectedValue.ToString());
            }

            this.Dispose();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cCHINHANH_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.btnTHOAT = new System.Windows.Forms.Button();
            this.btnXACNHAN = new System.Windows.Forms.Button();
            this.cmbCHINHANH = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTHOAT
            // 
            this.btnTHOAT.BackColor = System.Drawing.Color.OrangeRed;
            this.btnTHOAT.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnTHOAT.ForeColor = System.Drawing.Color.White;
            this.btnTHOAT.Location = new System.Drawing.Point(160, 181);
            this.btnTHOAT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTHOAT.Name = "btnTHOAT";
            this.btnTHOAT.Size = new System.Drawing.Size(117, 28);
            this.btnTHOAT.TabIndex = 10;
            this.btnTHOAT.Text = "THOÁT";
            this.btnTHOAT.UseVisualStyleBackColor = false;
            this.btnTHOAT.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnXACNHAN
            // 
            this.btnXACNHAN.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnXACNHAN.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnXACNHAN.ForeColor = System.Drawing.Color.White;
            this.btnXACNHAN.Location = new System.Drawing.Point(25, 181);
            this.btnXACNHAN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXACNHAN.Name = "btnXACNHAN";
            this.btnXACNHAN.Size = new System.Drawing.Size(117, 28);
            this.btnXACNHAN.TabIndex = 9;
            this.btnXACNHAN.Text = "XÁC NHẬN";
            this.btnXACNHAN.UseVisualStyleBackColor = false;
            this.btnXACNHAN.Click += new System.EventHandler(this.btnXACNHAN_Click);
            // 
            // cmbCHINHANH
            // 
            this.cmbCHINHANH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCHINHANH.FormattingEnabled = true;
            this.cmbCHINHANH.Location = new System.Drawing.Point(25, 116);
            this.cmbCHINHANH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbCHINHANH.Name = "cmbCHINHANH";
            this.cmbCHINHANH.Size = new System.Drawing.Size(253, 21);
            this.cmbCHINHANH.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(20, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 27);
            this.label1.TabIndex = 7;
            this.label1.Text = "CHUYỂN CHI NHÁNH";
            // 
            // FormChuyenChiNhanh
            // 
            this.ClientSize = new System.Drawing.Size(298, 268);
            this.Controls.Add(this.btnTHOAT);
            this.Controls.Add(this.btnXACNHAN);
            this.Controls.Add(this.cmbCHINHANH);
            this.Controls.Add(this.label1);
            this.Name = "FormChuyenChiNhanh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormChuyenChiNhanh_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Label label1;
    }
}
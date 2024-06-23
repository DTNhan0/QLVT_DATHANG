using DevExpress.XtraEditors;
using QLVT_DATHANG.ReportForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLVT_DATHANG.SubForm
{
    public partial class FormChonNhanVien : DevExpress.XtraEditors.XtraForm
    {
        private FormHoatDongNhanVien formHoatDongNhanVien = new FormHoatDongNhanVien();

        public FormChonNhanVien(FormHoatDongNhanVien f)
        {
            this.formHoatDongNhanVien = f;
            InitializeComponent();
        }

        private void FormChonNhanVien_Load(object sender, EventArgs e)
        {
            DataSet.EnforceConstraints = false;
            this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nhanVienTableAdapter.Fill(this.DataSet.NhanVien);

            ChiNhanhCb.DataSource = Program.bds_dspm;/*sao chep bingding source tu form dang nhap*/
            ChiNhanhCb.DisplayMember = "TENCN";
            ChiNhanhCb.ValueMember = "TENSERVER";
            ChiNhanhCb.SelectedIndex = Program.mChiNhanh;

            if (Program.mGroup == "CONGTY")
            {
                ChiNhanhCb.Enabled = true;
            }
        }

        private void ChiNhanhCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ChiNhanhCb.SelectedValue.ToString() == "System.Data.DataRowView")
                return;

            Program.servername = ChiNhanhCb.SelectedValue.ToString();

            if (ChiNhanhCb.SelectedIndex != Program.mChiNhanh)
            {
                Program.mlogin = Program.remotelogin;
                Program.password = Program.remotepassword;
            }
            else
            {
                Program.mlogin = Program.mloginDN;
                Program.password = Program.passwordDN;
            }

            if (Program.KetNoi() == 0)
            {
                MessageBox.Show("Xảy ra lỗi kết nối với chi nhánh hiện tại", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                this.nhanVienTableAdapter.Fill(this.DataSet.NhanVien);
            }
        }

        private void ChonBtn_Click(object sender, EventArgs e)
        {
            DataRowView drv = ((DataRowView)(bdsNV.Current));
            string maNhanVien = drv["MANV"].ToString().Trim();

            string ho = drv["HO"].ToString().Trim();
            string ten = drv["TEN"].ToString().Trim();
            string hoTen = ho + " " + ten;

            string ngaySinh = ((DateTime)drv["NGAYSINH"]).ToString("dd-MM-yyyy");
            string diaChi = drv["DIACHI"].ToString().Trim();

            this.formHoatDongNhanVien.MaNVTb1.Text = maNhanVien;
            this.formHoatDongNhanVien.HoTenTb1.Text = hoTen;
            this.formHoatDongNhanVien.NgaySinhTb1.Text = ngaySinh;
            this.formHoatDongNhanVien.DiaChiTb1.Text = diaChi;

            this.Close();
        }

        private void ThoatBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
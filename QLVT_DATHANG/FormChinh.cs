using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraTabbedMdi;
using QLVT_DATHANG.ReportForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLVT_DATHANG
{
    public partial class FormChinh : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FormChinh()
        {
            InitializeComponent();
            DangNhapBtn.PerformClick();
            setEnableOptions(false);
        }

        private void logout()
        {
            foreach (Form f in this.MdiChildren)
                f.Dispose();
        }

        private void DangNhapBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = this.CheckExists(typeof(FormDangNhap));
            if (form != null)
            {
                form.Activate();
            }
            else
            {
                FormDangNhap formDangNhap = new FormDangNhap(this);
                formDangNhap.MdiParent = this;
                formDangNhap.Show();
            }
        }

        private void DangXuatBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            logout();
            this.setEnableOptions(false);
            Form f = this.CheckExists(typeof(FormDangNhap));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                FormDangNhap form = new FormDangNhap(this);
                form.MdiParent = this;
                form.Show();
            }

            maNVSsl.Text = "MNV: ";
            hoTenSsl.Text = "HOTEN: ";
            nhomSsl.Text = "NHOM: ";

        }

        public void setEnableOptions(bool check)
        {
            if (check)
            {
                DangNhapBtn.Enabled = false;
                pageNhapXuat.Visible = true;
                pageBaoCao.Visible = true;
                DangXuatBtn.Enabled = true;
            }
            else
            {
                DangNhapBtn.Enabled = true;
                pageNhapXuat.Visible = false;
                pageBaoCao.Visible = false;
                DangXuatBtn.Enabled = false;
            }
        }

        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        private void NhanVienBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = this.CheckExists(typeof(FormNhanVien));
            if (form != null)
            {
                form.Activate();
            }
            else
            {
                FormNhanVien formNhanVien = new FormNhanVien();
                formNhanVien.MdiParent = this;
                formNhanVien.Show();
            }
        }

        private void ThoatBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        private void VatTuBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = this.CheckExists(typeof(FormVatTu));
            if (form != null)
            {
                form.Activate();
            }
            else
            {
                FormVatTu formVatTu = new FormVatTu();
                formVatTu.MdiParent = this;
                formVatTu.Show();
            }
        }

        private void KhoHangBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = this.CheckExists(typeof(FormKho));
            if (form != null)
            {
                form.Activate();
            }
            else
            {
                FormKho formKho = new FormKho();
                formKho.MdiParent = this;
                formKho.Show();
            }
        }

        private void DanhSachNhanVienBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(FormDanhSachNhanVien));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                FormDanhSachNhanVien form = new FormDanhSachNhanVien();
                //form.MdiParent = this;
                form.Show();
            }
        }

        private void DanhSachVatTuBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(FormDanhSachVatTu));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                FormDanhSachVatTu form = new FormDanhSachVatTu();
                //form.MdiParent = this;
                form.Show();
            }
        }

        private void ChiTietNhapXuatBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(FormChiTietNhapXuat));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                FormChiTietNhapXuat form = new FormChiTietNhapXuat();
                //form.MdiParent = this;
                form.Show();
            }
        }

        private void DHKoPNBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(FormDonHangKhongPhieuNhap));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                FormDonHangKhongPhieuNhap form = new FormDonHangKhongPhieuNhap();
                //form.MdiParent = this;
                form.Show();
            }
        }

        private void HoatDongNhanVienBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(FormHoatDongNhanVien));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                FormHoatDongNhanVien form = new FormHoatDongNhanVien();
                //form.MdiParent = this;
                form.Show();
            }
        }

        private void TongHopNXBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(FormTongHopNhapXuat));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                FormTongHopNhapXuat form = new FormTongHopNhapXuat();
                //form.MdiParent = this;
                form.Show();
            }
        }

        private void DonDatBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = this.CheckExists(typeof(FormDonDatHang));
            if (form != null)
            {
                form.Activate();
            }
            else
            {
                FormDonDatHang formDonDatHang = new FormDonDatHang();
                formDonDatHang.MdiParent = this;
                formDonDatHang.Show();
            }
        }

        private void PhieuNhapBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = this.CheckExists(typeof(FormPhieuNhap));
            if (form != null)
            {
                form.Activate();
            }
            else
            {
                FormPhieuNhap formPhieuNhap = new FormPhieuNhap();
                formPhieuNhap.MdiParent = this;
                formPhieuNhap.Show();
            }
        }
    }
}
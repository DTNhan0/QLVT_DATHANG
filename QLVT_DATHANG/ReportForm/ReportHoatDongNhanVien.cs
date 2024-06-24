using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLVT_DATHANG.ReportForm
{
    public partial class ReportHoatDongNhanVien : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportHoatDongNhanVien(FormHoatDongNhanVien formHoatDongNhanVien, String maNhanVien, DateTime fromDate, DateTime toDate)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = maNhanVien;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = fromDate;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = toDate;

            MaNVLbl.Text = formHoatDongNhanVien.MaNVTb1.Text;
            HoTenLbl.Text = formHoatDongNhanVien.HoTenTb1.Text;
            DiaChiLbl.Text = formHoatDongNhanVien.DiaChiTb1.Text;
            NgaySinhLbl.Text = formHoatDongNhanVien.NgaySinhTb1.Text;
            TuNgayLbl.Text = formHoatDongNhanVien.FromDateDE1.Text;
            DenNgayLbl.Text = formHoatDongNhanVien.ToDateDE1.Text;

            this.sqlDataSource1.Fill();
            TenNV.Text = Program.mHoten;
            NgayXuatLbl.Text = DateTime.Now.ToString();
        }

    }
}

﻿using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLVT_DATHANG.ReportForm
{
    public partial class ReportDonHangKhongPhieuNhap : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportDonHangKhongPhieuNhap(FormDonHangKhongPhieuNhap formDonHangKhongPhieuNhap)
        {
            InitializeComponent();

            ChiNhanhLbl.Text = formDonHangKhongPhieuNhap.ChiNhanh;
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Fill();
            TenNV.Text = Program.mHoten;
            NgayXuatLbl.Text = DateTime.Now.ToString();
        }

    }
}

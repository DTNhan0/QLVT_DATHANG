﻿using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLVT_DATHANG.ReportForm
{
    public partial class ReportDanhSachNhanVien : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportDanhSachNhanVien(FormDanhSachNhanVien formDanhSachNhanVien)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Fill();
            ChiNhanhLbl.Text = formDanhSachNhanVien.ChiNhanh.ToUpper();
            TenNV.Text = Program.mHoten;
            NgayXuatLbl.Text = DateTime.Now.ToString();
        }

    }
}

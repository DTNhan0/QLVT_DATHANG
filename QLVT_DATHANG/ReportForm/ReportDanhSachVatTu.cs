using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLVT_DATHANG.ReportForm
{
    public partial class ReportDanhSachVatTu : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportDanhSachVatTu()
        {
            InitializeComponent();
            TenNV.Text = Program.mHoten;
            NgayXuatLbl.Text = DateTime.Now.ToString();
        }

    }
}

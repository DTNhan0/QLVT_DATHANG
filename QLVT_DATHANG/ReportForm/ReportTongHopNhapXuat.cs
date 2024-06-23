using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLVT_DATHANG.ReportForm
{
    public partial class ReportTongHopNhapXuat : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportTongHopNhapXuat(FormTongHopNhapXuat formTongHopNhapXuat, DateTime fromDate, DateTime toDate)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = fromDate;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = toDate;

            String FromDate = fromDate.ToString("dd/MM/yyyy");
            String ToDate = toDate.ToString("dd/MM/yyyy");

            this.ChiNhanhLbl.Text = formTongHopNhapXuat.ChiNhanh;
            this.TuNgayLbl.Text = FromDate;
            this.DenNgayLbl.Text = ToDate;

            this.sqlDataSource1.Fill();
        }

    }
}

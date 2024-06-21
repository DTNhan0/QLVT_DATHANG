using DevExpress.XtraReports;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace QLVT_DATHANG.ReportForm
{
    public partial class ReportChiTietNhapXuat : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportChiTietNhapXuat(FormChiTietNhapXuat formChiTietNhapXuat, String vaiTro, String loaiPhieu, DateTime fromDate, DateTime toDate)
        {
            InitializeComponent();

            if (Program.mChiNhanh == 0)
            {
                ChiNhanhLbl.Text = "1";
            }
            else if(Program.mChiNhanh == 1)
            {
                ChiNhanhLbl.Text = "2";
            }
            else
            {
                ChiNhanhLbl.Text = "1 và 2";
            }
            
            this.LoaiPhieuLbl.Text = formChiTietNhapXuat.LoaiPhieuCb1.SelectedItem.ToString().ToUpper();
            this.FromDateLbl.Text = fromDate.ToString("dd-MM-yyyy");
            this.ToDateLbl.Text = toDate.ToString("dd-MM-yyyy");

            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = vaiTro;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = loaiPhieu;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = fromDate;
            this.sqlDataSource1.Queries[0].Parameters[3].Value = toDate;

            try
            {
                this.sqlDataSource1.Fill();
            }
            catch (AggregateException ex)
            {
                MessageBox.Show("Không có dữ liệu trả về. Chi tiết phiếu nhập hoặc phiếu xuất chưa có dữ liệu!!!");
                //Console.WriteLine(ex.Message);
            }

        }

    }
}

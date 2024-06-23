using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using QLVT_DATHANG.SubForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLVT_DATHANG.ReportForm
{
    public partial class FormHoatDongNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public TextBox MaNVTb1 { get => MaNVTb; set => MaNVTb = value; }
        public TextBox HoTenTb1 { get => HoTenTb; set => HoTenTb = value; }
        public TextBox NgaySinhTb1 { get => NgaySinhTb; set => NgaySinhTb = value; }
        public TextBox DiaChiTb1 { get => DiaChiTb; set => DiaChiTb = value; }
        public DateEdit FromDateDE1 { get => FromDateDE; set => FromDateDE = value; }
        public DateEdit ToDateDE1 { get => ToDateDE; set => ToDateDE = value; }

        public FormHoatDongNhanVien()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            this.MaximizeBox = false;
        }

        private void ChonNVBtn_Click(object sender, EventArgs e)
        {
            FormChonNhanVien form = new FormChonNhanVien(this);
            form.ShowDialog();

            Console.WriteLine(MaNVTb1);
        }

        private void XemTruocBtn_Click(object sender, EventArgs e)
        {
            string maNhanVien = MaNVTb.Text;
            DateTime fromDate = FromDateDE.DateTime;
            DateTime toDate = ToDateDE.DateTime;

            ReportHoatDongNhanVien report = new ReportHoatDongNhanVien(this, maNhanVien, fromDate, toDate);

            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.ShowPreviewDialog();
        }

        private void XuatBanBtb_Click(object sender, EventArgs e)
        {
            try
            {
                string maNhanVien = MaNVTb.Text;
                DateTime fromDate = FromDateDE.DateTime;
                DateTime toDate = ToDateDE.DateTime;

                ReportHoatDongNhanVien report = new ReportHoatDongNhanVien(this, maNhanVien, fromDate, toDate);

                if (File.Exists(@"C:\CSDLPTpdf\ReportHoatDongNhanVien.pdf"))
                {
                    DialogResult dr = MessageBox.Show("File ReportHoatDongNhanVien.pdf tại ổ C đã có!\nBạn có muốn tạo lại?",
                        "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                        report.ExportToPdf(@"C:\CSDLPTpdf\ReportHoatDongNhanVien.pdf");
                        MessageBox.Show("File ReportHoatDongNhanVien.pdf đã được ghi thành công tại ổ C",
                "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else
                {
                    report.ExportToPdf(@"C:\CSDLPTpdf\ReportHoatDongNhanVien.pdf");
                    MessageBox.Show("File ReportHoatDongNhanVien.pdf đã được ghi thành công tại ổ C",
                "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show("Vui lòng đóng file ReportHoatDongNhanVien.pdf",
                    "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
        }
    }
}
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
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
    public partial class FormChiTietNhapXuat : DevExpress.XtraEditors.XtraForm
    {

        public System.Windows.Forms.ComboBox LoaiPhieuCb1 { get => LoaiPhieuCb; set => LoaiPhieuCb = value; }

        public FormChiTietNhapXuat()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            this.MaximizeBox = false;
        }

        private void XemTruocBtn_Click(object sender, EventArgs e)
        {
            string vaiTro = Program.mGroup;
            string loaiPhieu = (LoaiPhieuCb.SelectedItem.ToString() == "NHAP") ? "NHAP" : "XUAT";

            DateTime fromDate = DateFromDE.DateTime;
            DateTime toDate = DateToDE.DateTime;
            ReportChiTietNhapXuat report = new ReportChiTietNhapXuat(this, vaiTro, loaiPhieu, fromDate, toDate);

            ReportPrintTool printTool = new ReportPrintTool(report);

            printTool.ShowPreviewDialog();
        }

        private void XuatBanBtn_Click(object sender, EventArgs e)
        {
            string vaiTro = Program.mGroup;
            string loaiPhieu = (LoaiPhieuCb.SelectedItem.ToString() == "NHAP") ? "NHAP" : "XUAT";

            try
            {

                DateTime fromDate = DateFromDE.DateTime;
                DateTime toDate = DateToDE.DateTime;

                ReportChiTietNhapXuat report = new ReportChiTietNhapXuat(this, vaiTro, loaiPhieu, fromDate, toDate);

                if (File.Exists(@"C:\CSDLPTpdf\ReportChiTietSoLuongTriGiaHangHoaNhapXuat.pdf"))
                {
                    DialogResult dr = MessageBox.Show("File ReportChiTietSoLuongTriGiaHangHoaNhapXuat.pdf tại ổ C đã có!\nBạn có muốn tạo lại?",
                        "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                        report.ExportToPdf(@"D:\ReportChiTietSoLuongTriGiaHangHoaNhapXuat.pdf");
                        MessageBox.Show("File ReportChiTietSoLuongTriGiaHangHoaNhapXuat.pdf đã được ghi thành công tại ổ C",
                "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else
                {
                    report.ExportToPdf(@"C:\CSDLPTpdf\ReportChiTietSoLuongTriGiaHangHoaNhapXuat.pdf");
                    MessageBox.Show("File ReportChiTietSoLuongTriGiaHangHoaNhapXuat.pdf đã được ghi thành công tại ổ C",
                "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show("Vui lòng đóng file ReportChiTietSoLuongTriGiaHangHoaNhapXuat.pdf",
                    "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
        }

        private void FormChiTietNhapXuat_Load(object sender, EventArgs e)
        {
            this.LoaiPhieuCb.SelectedIndex = 1;
            this.DateFromDE.EditValue = "01-01-2015";
            this.DateToDE.EditValue = "31-12-2024";
        }
    }
}
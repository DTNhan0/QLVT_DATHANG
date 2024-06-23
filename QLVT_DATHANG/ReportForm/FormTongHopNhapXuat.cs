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
    public partial class FormTongHopNhapXuat : DevExpress.XtraEditors.XtraForm
    {
        public String chiNhanh = "";

        public string ChiNhanh { get => chiNhanh; set => chiNhanh = value; }

        public FormTongHopNhapXuat()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            this.MaximizeBox = false;
        }

        private void FormTongHopNhapXuat_Load(object sender, EventArgs e)
        {
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
        }

        private void XemTruocBtn_Click(object sender, EventArgs e)
        {
            DateTime fromDate = (DateTime)FromDateDE.DateTime;
            DateTime toDate = (DateTime)ToDateDE.DateTime;

            chiNhanh = ChiNhanhCb.SelectedValue.ToString().Contains("1") ? "CHI NHÁNH 1" : "CHI NHÁNH 2";

            ReportTongHopNhapXuat report = new ReportTongHopNhapXuat(this, fromDate, toDate);

            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.ShowPreviewDialog();
        }

        private void XuatBanBtb_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fromDate = (DateTime)FromDateDE.DateTime;
                DateTime toDate = (DateTime)ToDateDE.DateTime;

                chiNhanh = ChiNhanhCb.SelectedValue.ToString().Contains("1") ? "CHI NHÁNH 1" : "CHI NHÁNH 2";

                ReportTongHopNhapXuat report = new ReportTongHopNhapXuat(this, fromDate, toDate);

                if (File.Exists(@"C:\CSDLPTpdf\ReportTongHopNhapXuat.pdf"))
                {
                    DialogResult dr = MessageBox.Show("File ReportTongHopNhapXuat.pdf tại ổ C đã có!\nBạn có muốn tạo lại?",
                        "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                        report.ExportToPdf(@"C:\CSDLPTpdf\ReportTongHopNhapXuat.pdf");
                        MessageBox.Show("File ReportTongHopNhapXuat.pdf đã được ghi thành công tại ổ C",
                "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else
                {
                    report.ExportToPdf(@"C:\CSDLPTpdf\ReportTongHopNhapXuat.pdf");
                    MessageBox.Show("File ReportTongHopNhapXuat.pdf đã được ghi thành công tại ổ C",
                "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show("Vui lòng đóng file ReportTongHopNhapXuat.pdf",
                    "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
        }
    }
}
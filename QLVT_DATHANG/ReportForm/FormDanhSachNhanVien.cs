using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using QLVT_DATHANG.ReportForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLVT_DATHANG
{
    public partial class FormDanhSachNhanVien : DevExpress.XtraEditors.XtraForm
    {
        private SqlConnection connPublisher = new SqlConnection();
        private string chiNhanh = "";

        public string ChiNhanh { get => chiNhanh; set => chiNhanh = value; }

        private void layDanhSachPhanManh(String cmd)
        {
            if (connPublisher.State == ConnectionState.Closed)
            {
                connPublisher.Open();
            }
            DataTable dt = new DataTable();
            // adapter dùng để đưa dữ liệu từ view sang database
            SqlDataAdapter da = new SqlDataAdapter(cmd, connPublisher);
            // dùng adapter thì mới đổ vào data table được
            da.Fill(dt);


            connPublisher.Close();
            Program.bds_dspm.DataSource = dt;


            ChiNhanhCb.DataSource = Program.bds_dspm;
            ChiNhanhCb.DisplayMember = "TENCN";
            ChiNhanhCb.ValueMember = "TENSERVER";

        }

        public FormDanhSachNhanVien()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            this.MaximizeBox = false;
        }

        private int KetNoiDatabaseGoc()
        {
            if (connPublisher != null && connPublisher.State == ConnectionState.Open)
                connPublisher.Close();
            try
            {
                connPublisher.ConnectionString = Program.connstrPublisher;
                connPublisher.Open();
                return 1;
            }

            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\nBạn xem lại user name và password.\n " + e.Message, "", MessageBoxButtons.OK);
                return 0;
            }
        }

        private void FormDanhSachNhanVien_Load(object sender, EventArgs e)
        {
            

            if (Program.mGroup == "CONGTY")
            {
                this.ChiNhanhCb.Enabled = true;
            }
            // TODO: This line of code loads data into the 'dataSet.NhanVien' table. You can move, or remove it, as needed.
            dataSet.EnforceConstraints = false;

            if (KetNoiDatabaseGoc() == 0)
                return;

            layDanhSachPhanManh("SELECT TOP 2 * FROM view_DanhSachPhanManh");
            ChiNhanhCb.SelectedIndex = 0;
            ChiNhanhCb.SelectedIndex = 1;

            if(Program.mChiNhanh == 0)
            {
                ChiNhanhCb.SelectedIndex = 0;
            }
            else
            {
                ChiNhanhCb.SelectedIndex = 1;
            }

        }

        private void XemTruocBtn_Click(object sender, EventArgs e)
        {
            ReportDanhSachNhanVien report = new ReportDanhSachNhanVien(this);
            /*GAN TEN CHI NHANH CHO BAO CAO*/
            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.ShowPreviewDialog();
        }

        private void XuatBanBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ReportDanhSachNhanVien report = new ReportDanhSachNhanVien(this);
                if (File.Exists(@"C:\CSDLPTpdf\ReportDanhSachNhanVien.pdf"))
                {
                    DialogResult dr = MessageBox.Show("File ReportDSNhanVien.pdf tại ổ C đã có!\nBạn có muốn tạo lại?",
                        "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                        report.ExportToPdf(@"D:\ReportDSNhanVien.pdf");
                        MessageBox.Show("File ReportDSNhanVien.pdf đã được ghi thành công tại ổ D",
                "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else
                {
                    report.ExportToPdf(@"C:\CSDLPTpdf\ReportDanhSachNhanVien.pdf");
                    MessageBox.Show("File ReportDSNhanVien.pdf đã được ghi thành công tại ổ C",
                "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show("Vui lòng đóng file ReportDSNhanVien.pdf",
                    "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
        }

        private void ChiNhanhCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            /*Neu combobox khong co so lieu thi ket thuc luon*/
            if (ChiNhanhCb.SelectedValue.ToString() == "System.Data.DataRowView")
                return;

            Program.servername = ChiNhanhCb.SelectedValue.ToString();

            /*Neu chon sang chi nhanh khac voi chi nhanh hien tai*/
            if (ChiNhanhCb.SelectedIndex != Program.mChiNhanh)
            {
                Program.mlogin = Program.remotelogin;
                Program.password = Program.remotepassword;
            }
            /*Neu chon trung voi chi nhanh dang dang nhap o formDangNhap*/
            else
            {
                Program.mlogin = Program.mloginDN;
                Program.password = Program.passwordDN;
            }

            if (Program.KetNoi() == 0)
            {
                MessageBox.Show("Xảy ra lỗi kết nối với chi nhánh hiện tại", "Thông báo", MessageBoxButtons.OK);
            }

            chiNhanh = ChiNhanhCb.SelectedValue.ToString().Contains("1") ? "CHI NHÁNH 1" : "CHI NHÁNH 2";

            this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nhanVienTableAdapter.Fill(this.dataSet.NhanVien);
        }
    }
}
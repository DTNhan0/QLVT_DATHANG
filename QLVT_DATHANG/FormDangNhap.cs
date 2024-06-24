using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLVT_DATHANG
{
    public partial class FormDangNhap : DevExpress.XtraEditors.XtraForm
    {
        private SqlConnection connPublisher = new SqlConnection();

        private void LayDSPhanManh(String cmd)
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

        private FormChinh formChinh;
        public FormDangNhap(FormChinh formC)
        {
            this.formChinh = formC;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();
        }

        private void DangNhapBtn_Click(object sender, EventArgs e)
        {
            if (TaiKhoanTf.Text.Trim() == "" || MatKhauTf.Text.Trim() == "")
            {
                MessageBox.Show("Tài khoản & mật khẩu không thể bỏ trống", "Thông Báo", MessageBoxButtons.OK);
                return;
            }

            Program.mlogin = TaiKhoanTf.Text.Trim();
            Program.password = MatKhauTf.Text.Trim();
            if (Program.KetNoi() == 0)
                return;

            Program.mChiNhanh = ChiNhanhCb.SelectedIndex;
            Program.mloginDN = Program.mlogin;
            Program.passwordDN = Program.password;

            String statement = "EXEC sp_LayThongTinNV '" + Program.mlogin + "'";
            Program.myReader = Program.ExecSqlDataReader(statement);
            if (Program.myReader == null)
                return;

            Program.myReader.Read();

            Program.username = Program.myReader.GetString(0);// lấy MaNV dang nhap
            if (Convert.IsDBNull(Program.username))
            {
                MessageBox.Show("Tài khoản này không có quyền truy cập \n Hãy thử tài khoản khác", "Thông Báo", MessageBoxButtons.OK);
            }

            Program.mHoten = Program.myReader.GetString(1);
            Program.mGroup = Program.myReader.GetString(2);

            Program.myReader.Close();
            Program.conn.Close();

            formChinh.maNVSsl.Text = "MNV: " + Program.username;
            formChinh.hoTenSsl.Text = "HOTEN: " + Program.mHoten;
            formChinh.nhomSsl.Text = "NHOM: " + Program.mGroup;

            this.Visible = false;
            formChinh.setEnableOptions(true);
            formChinh.TaoTKBtn1.Enabled = true;
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

        private void ChiNhanhCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Program.servername = ChiNhanhCb.SelectedValue.ToString();
            }
            catch (Exception)
            {
            }
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {
            TaiKhoanTf.Text = "TT";
            MatKhauTf.Text = "12345";
            if (KetNoiDatabaseGoc() == 0)
                return;

            LayDSPhanManh("SELECT TOP 2 * FROM view_DanhSachPhanManh");
            ChiNhanhCb.SelectedIndex = 0;
            ChiNhanhCb.SelectedIndex = 1;
        }

        private void ThoatBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            formChinh.Dispose();
        }
    }
}

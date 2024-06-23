using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Windows.Forms;
namespace QLVT_DATHANG
{
    internal static class Program
    {
        public static SqlConnection conn = new SqlConnection();
        public static String connstr = "";
        public static String connstrPublisher = "Data Source=LAPTOP-R5G6HICH;Initial Catalog=QLVT_DATHANG;Integrated Security=true";
        public static SqlDataReader myReader;

        public static String servername = "";
        public static String serverNameLeft = "";
        public static String username = "";

        public static String mlogin = "";
        public static String password = "";

        public static String database = "QLVT";

        public static String remotelogin = "HTKN";
        public static String remotepassword = "12345";

        public static String mloginDN = "";
        public static String passwordDN = "";

        public static String mGroup = "";
        public static String mHoten = "";
        public static int mChiNhanh = 0;

        //Vật tư đang chọn
        public static string maVatTuDuocChon = "";
        public static int soLuongVatTu = 0;

        //Mã kho đang chọn
        public static string maKhoDuocChon = "";

        public static string maDonDatHangDuocChon = "";
        public static string maDonDatHangDuocChonChiTiet = "";
        public static int donGia = 0;

        public static string maNhanVienDuocChon = "";
        public static string hoTen = "";
        public static string diaChi = "";
        public static string ngaySinh = "";

        /*bidSou: BindingSource -> liên kết dữ liệu từ bảng dữ liệu vào chương trình*/
        public static BindingSource bds_dspm = new BindingSource();

        public static int KetNoi()
        {
            if (Program.conn != null && Program.conn.State == ConnectionState.Open)
                Program.conn.Close();
            try
            {
                Program.connstr = "Data Source=" + Program.servername + ";Initial Catalog=" +
                       Program.database + ";User ID=" +
                       Program.mlogin + ";password=" + Program.password;

                Program.conn.ConnectionString = Program.connstr;

                Program.conn.Open();

                return 1;
            }

            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\nXem lại tài khoản và mật khẩu.\n " + e.Message, "", MessageBoxButtons.OK);
                return 0;
            }
        }

        public static SqlDataReader ExecSqlDataReader(String strLenh)
        {
            SqlDataReader myreader;
            SqlCommand sqlcmd = new SqlCommand(strLenh, Program.conn);
            sqlcmd.CommandType = CommandType.Text;
            if (Program.conn.State == ConnectionState.Closed)
                Program.conn.Open();
            try
            {
                myreader = sqlcmd.ExecuteReader(); return myreader;

            }
            catch (SqlException ex)
            {
                Program.conn.Close();
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public static int ExecSqlScalar(String strLenh)
        {
            SqlCommand sqlcmd = new SqlCommand(strLenh, Program.conn);
            sqlcmd.CommandType = CommandType.Text;
            if (Program.conn.State == ConnectionState.Closed)
                Program.conn.Open();
            try
            {
                object result = sqlcmd.ExecuteScalar();
                return Convert.ToInt32(result);
            }
            catch (SqlException ex)
            {
                Program.conn.Close();
                MessageBox.Show(ex.Message);
                return -1;
            }
        }


        public static DataTable ExecSqlDataTable(String cmd)
        {
            DataTable dt = new DataTable();
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn);
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        public static int ExecSqlNonQuery(String strlenh)
        {
            SqlCommand Sqlcmd = new SqlCommand(strlenh, conn);
            Sqlcmd.CommandType = CommandType.Text;
            Sqlcmd.CommandTimeout = 600;// 10 phut
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                Sqlcmd.ExecuteNonQuery(); conn.Close();
                return 0;
            }
            catch (SqlException ex)
            {
                if (ex.Message.Contains("Error converting data type varchar to int"))
                    MessageBox.Show("Bạn format Cell lại cột \"Ngày Thi\" qua kiểu Number hoặc mở File Excel.");
                else MessageBox.Show(ex.Message);
                conn.Close();
                return ex.State;

            }
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormChinh());
        }
    }
}

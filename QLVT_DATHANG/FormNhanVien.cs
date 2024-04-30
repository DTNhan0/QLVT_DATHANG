using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using static DevExpress.Data.Helpers.FindSearchRichParser;
using System.Collections.Specialized;
using System.Collections;
using DevExpress.Data.Helpers;
using DevExpress.Utils;
using DevExpress.Xpo.DB.Helpers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Threading;
using DevExpress.Utils.Extensions;
using DevExpress.Utils.Helpers;

namespace QLVT_DATHANG
{
    public partial class FormNhanVien : Form
    {
        bool IsThem = false;
        bool IsHoanTac = false;
        int Index = 0;
        String MaCN = "";

        StackUndoRedo UndoRedo;
        DataRowView TempData = null;

        public FormNhanVien()
        {
            InitializeComponent();
        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            DataSet.EnforceConstraints = false;

            this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nhanVienTableAdapter.Fill(this.DataSet.NhanVien);

            this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.datHangTableAdapter.Fill(this.DataSet.DatHang);

            this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuNhapTableAdapter.Fill(this.DataSet.PhieuNhap);

            this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuXuatTableAdapter.Fill(this.DataSet.PhieuXuat);

            MaCN = ((DataRowView)bdsNV[0])["MACN"].ToString();

            ChiNhanhCb.DataSource = Program.bds_dspm;
            ChiNhanhCb.DisplayMember = "TENCN";
            ChiNhanhCb.ValueMember = "TENSERVER";
            ChiNhanhCb.SelectedIndex = Program.mChiNhanh;

            CheckLoginPermission();
            BoGhiBtn.Enabled = false;

            UndoRedo = new StackUndoRedo(bdsNV);

            NhanVienGc_Click(sender, e);

            HoanTacBtn.Enabled = false;
        }

        public void CheckLoginPermission()
        {
            switch (Program.mGroup)
            {
                case "CONGTY":
                    setEnableOptions(false);
                    break;
                case "CHINHANH":
                case "USER":
                    setEnableOptions(true);
                    break;
                default:
                    break;
            }
        }

        public void setEnableOptions(bool check)
        {
            if (check)
            {
                ThemBtn.Enabled = true;
                XoaBtn.Enabled = true;
                GhiBtn.Enabled = true;
                ChuyenCNBtn.Enabled = true;
                HoanTacBtn.Enabled = true;
                panelNhapXuat.Enabled = true;
            }
            else
            {
                ThemBtn.Enabled = false;
                XoaBtn.Enabled = false;
                GhiBtn.Enabled = false;
                ChuyenCNBtn.Enabled = false;
                HoanTacBtn.Enabled = false;
                panelNhapXuat.Enabled = false;
            }
        }

        private void ThoatBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (IsHoanTac)
            {
                if (MessageBox.Show("Bạn đang có dữ liệu cần hoàn tác, bạn có chắc chắn muốn thoát không?", "Thông báo",
                                MessageBoxButtons.OKCancel) == DialogResult.OK)
                    this.Close();
            }
            else
            {
                this.Close();
            }

        }

        private void LamMoiBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                CheckLoginPermission();
                IsThem = false;
                MaNVTb.Enabled = false;

                this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                this.nhanVienTableAdapter.Fill(this.DataSet.NhanVien);

                this.NhanVienGc.Enabled = true;
                this.NhanVienGc.Focus();

                BoGhiBtn.Enabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Làm mới" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                return;
            }
        }

        private void ThemBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.panelNhapXuat.Enabled = true;

            IsThem = true;
            bdsNV.AddNew();
            Index = bdsNV.Position;
            MaCNTb.Text = MaCN;
            NgaySinhDte.EditValue = "01/01/2000";
            LuongTxtE.EditValue = 5000000;

            setEnableOptions(false);
            MaNVTb.Enabled = true;
            panelNhapXuat.Enabled = true;
            GhiBtn.Enabled = true;
            NhanVienGc.Enabled = false;
            TrangThaiXoaCb.Checked = false;
        }

        private void XoaBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            String MaNV = ((DataRowView)bdsNV[bdsNV.Position])["MANV"].ToString();

            if (MaNV == Program.username)
            {
                MessageBox.Show("Không thể xóa chính tài khoản đang đăng nhập", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if (bdsNV.Count == 0)
            {
                XoaBtn.Enabled = false;
            }

            if (bdsDH.Count > 0)
            {
                MessageBox.Show("Không thể xóa nhân viên này vì đã lập đơn đặt hàng", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if (bdsPN.Count > 0)
            {
                MessageBox.Show("Không thể xóa nhân viên này vì đã lập phiếu nhập", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if (bdsPX.Count > 0)
            {
                MessageBox.Show("Không thể xóa nhân viên này vì đã lập phiếu xuất", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên có mã: " + MaNV + " không?", "Thông báo",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (bdsNV.Current != null)
                {
                    try
                    {
                        DataRowView currentRow = (DataRowView)bdsNV.Current;

                        UndoRedo.InsertStack(CopyDataRowView(currentRow), "Delete", bdsNV.Position);

                        bdsNV.RemoveCurrent();
                        bdsNV.EndEdit();

                        Index = bdsNV.Position;

                        this.HoanTacBtn.Enabled = true;
                        this.HoanTacBtn.Enabled = true;
                        this.nhanVienTableAdapter.Update(this.DataSet.NhanVien);

                        MessageBox.Show("Xóa dữ liệu thành công!");
                        HoanTacBtn.Enabled = true;

                        LamMoiBtn.PerformClick();
                        while (true)
                        {
                            using (SqlDataReader reader = Program.ExecSqlDataReader("EXEC [dbo].[sp_TimMaNV] '" + MaNV + "'"))
                            {
                                if (reader != null && reader.HasRows)
                                        Thread.Sleep(100);
                                else
                                {
                                    MessageBox.Show("Cơ sở dữ liệu đã cập nhật lại thông tin!", "Thông báo", MessageBoxButtons.OK);
                                    break;
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi xóa dữ liệu: " + ex.Message);
                        bdsNV.Position = Index;
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu để xóa.");
                }
            }

        }

        private void GhiBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!CheckDataInput())
                return;

            if (IsThem)
            {
                try
                {
                    if (CheckDataExistence("EXEC [dbo].[sp_TimMaNV] '" + MaNVTb.Text + "'", "Mã nhân viên có số: ", MaNVTb))
                        return;

                    if (CheckDataExistence("EXEC [dbo].[sp_TimCMND] '" + SoCmndTb.Text + "'", "CMND có số: ", SoCmndTb))
                        return;

                    DataRowView currentRow = (DataRowView)bdsNV.Current;
                    bdsNV.EndEdit();
                    String MaNV = ((DataRowView)bdsNV[bdsNV.Position])["MANV"].ToString();

                    this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.nhanVienTableAdapter.Update(this.DataSet.NhanVien);

                    MessageBox.Show("Thêm dữ liệu thành công!");

                    LamMoiBtn.PerformClick();

                    for (int i = 0; i < bdsNV.Count; i++)
                    {
                        DataRowView rowView = (DataRowView)bdsNV[i];
                        if (rowView["MANV"].ToString() == MaNV)
                        {
                            Index = i; 
                            break; 
                        }
                    }

                    bdsNV.Position = Index;

                    UndoRedo.InsertStack((DataRowView)bdsNV.Current, "Add", bdsNV.Position);
                    HoanTacBtn.Enabled = true;

                    while (true)
                    {
                        using (SqlDataReader reader = Program.ExecSqlDataReader("EXEC [dbo].[sp_TimMaNV] '" + MaNV + "'"))
                        {
                            if (reader == null || !reader.HasRows)
                                Thread.Sleep(100);
                            else
                            {
                                MessageBox.Show("Cơ sở dữ liệu đã cập nhật lại thông tin!", "Thông báo", MessageBoxButtons.OK);
                                break;
                            }
                        }
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi thêm dữ liệu: " + ex.Message);
                    bdsNV.Position = Index;
                    return;
                }
            }
            else
            {
                DataRowView OldData = TempData;

                if (MessageBox.Show("Bạn có chắc chắn muốn cập nhật nhân viên có mã: " + MaNVTb.Text + " không?", "Thông báo",
                    MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    try
                    {
                        Index = bdsNV.Position;

                        String MaNV = ((DataRowView)bdsNV[bdsNV.Position])["MANV"].ToString();
                        using (SqlDataReader readerSoCMND = Program.ExecSqlDataReader("EXEC [dbo].[sp_TimCMND] '" + SoCmndTb.Text + "'"))
                        {
                            int maNVIndex = -1;
                            int maNVTb = -1;
                            if (readerSoCMND != null && readerSoCMND.HasRows)
                            {
                                while (readerSoCMND.Read())
                                    maNVTb = readerSoCMND.GetInt32(0);
                                readerSoCMND.Close();

                                using (SqlDataReader readerMaNV = Program.ExecSqlDataReader("EXEC [dbo].[sp_TimMaNV] '" + MaNV + "'"))
                                {
                                    if (readerMaNV != null && readerMaNV.HasRows)
                                    {
                                        while (readerMaNV.Read())
                                            maNVIndex = readerMaNV.GetInt32(0);

                                    }
                                }

                                if (maNVIndex != maNVTb)
                                {
                                    MessageBox.Show("Số CMND đã tồn tại", "Thông báo", MessageBoxButtons.OK);
                                    SoCmndTb.Focus();
                                    return;
                                }
                            }
                        }

                        UndoRedo.InsertStack(OldData, "Update", Index);

                        DataRowView currentRow = (DataRowView)bdsNV.Current;
                        this.Validate();
                        bdsNV.EndEdit();
                        this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.nhanVienTableAdapter.Update(this.DataSet.NhanVien);

                        MessageBox.Show("Cập nhật dữ liệu thành công!");

                        LamMoiBtn.PerformClick();
                        bdsNV.Position = Index;
                        HoanTacBtn.Enabled = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi cập nhật dữ liệu: " + ex.Message);
                        bdsNV.Position = Index;
                        return;
                    }
                }
            }
        }

        private void ChuyenCNBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

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
            else
            {
                this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                this.nhanVienTableAdapter.Fill(this.DataSet.NhanVien);

                this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
                this.datHangTableAdapter.Fill(this.DataSet.DatHang);

                this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
                this.phieuNhapTableAdapter.Fill(this.DataSet.PhieuNhap);

                this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
                this.phieuXuatTableAdapter.Fill(this.DataSet.PhieuXuat);

            }
        }

        private bool CheckDataInput()
        {

            if (MaNVTb.Text == "")
            {
                MessageBox.Show("Không bỏ trống mã nhân viên", "Thông báo", MessageBoxButtons.OK);
                MaNVTb.Focus();
                return false;
            }

            if (Regex.IsMatch(MaNVTb.Text, @"^[a-zA-Z0-9]+$") == false)
            {
                MessageBox.Show("Mã nhân viên chỉ chấp nhận số", "Thông báo", MessageBoxButtons.OK);
                MaNVTb.Focus();
                return false;
            }

            if (HoTb.Text == "")
            {
                MessageBox.Show("Không bỏ trống họ và tên", "Thông báo", MessageBoxButtons.OK);
                HoTb.Focus();
                return false;
            }

            if (Regex.IsMatch(HoTb.Text, @"^[\p{L} ]+$") == false)
            {
                MessageBox.Show("Họ của người chỉ có chữ cái và khoảng trắng", "Thông báo", MessageBoxButtons.OK);
                HoTb.Focus();
                return false;
            }

            if (HoTb.Text.Length > 40)
            {
                MessageBox.Show("Họ không thể lớn hơn 40 kí tự", "Thông báo", MessageBoxButtons.OK);
                HoTb.Focus();
                return false;
            }

            if (TenTb.Text == "")
            {
                MessageBox.Show("Không bỏ trống họ và tên", "Thông báo", MessageBoxButtons.OK);
                TenTb.Focus();
                return false;
            }

            if (Regex.IsMatch(TenTb.Text, @"^[\p{L} ]+$") == false)
            {
                MessageBox.Show("Tên người chỉ có chữ cái và khoảng trắng", "Thông báo", MessageBoxButtons.OK);
                TenTb.Focus();
                return false;
            }

            if (TenTb.Text.Length > 10)
            {
                MessageBox.Show("Tên không thể lớn hơn 10 kí tự", "Thông báo", MessageBoxButtons.OK);
                TenTb.Focus();
                return false;
            }

            if (DiaChiTb.Text == "")
            {
                MessageBox.Show("Không bỏ trống địa chỉ", "Thông báo", MessageBoxButtons.OK);
                DiaChiTb.Focus();
                return false;
            }

            if (Regex.IsMatch(DiaChiTb.Text, @"^[\p{L}0-9\s]+$") == false)
            {
                MessageBox.Show("Phải ghi rõ địa chỉ hợp lệ", "Thông báo", MessageBoxButtons.OK);
                DiaChiTb.Focus();
                return false;
            }

            if (DiaChiTb.Text.Length > 100)
            {
                MessageBox.Show("Không bỏ trống địa chỉ", "Thông báo", MessageBoxButtons.OK);
                DiaChiTb.Focus();
                return false;
            }

            if (CheckAge(NgaySinhDte.DateTime) < 18)
            {
                MessageBox.Show("Nhân viên chưa đủ 18 tuổi", "Thông báo", MessageBoxButtons.OK);
                NgaySinhDte.Focus();
                return false;
            }

            if(Regex.IsMatch(SoCmndTb.Text, "^[0-9]+$"))
            {
                if(SoCmndTb.Text.Length != 10 || SoCmndTb.Text == "")
                {
                    MessageBox.Show("Số CMND phải đủ 10 chữ số và không được bỏ trống", "Thông báo", MessageBoxButtons.OK);
                    SoCmndTb.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Số CMND phải là kiểu dữ liệu hợp lệ", "Thông báo", MessageBoxButtons.OK);
                SoCmndTb.Focus();
                return false;
            }

            long Luong;
            string chuoiLuong = LuongTxtE.Text;
            chuoiLuong = chuoiLuong.Replace(" ", "").Replace(",", "");

            if (Regex.IsMatch(chuoiLuong, "^[0-9]+$"))
            {
                long.TryParse(new string(chuoiLuong.Where(char.IsDigit).ToArray()), out Luong);
                if (Luong < 5000000 || chuoiLuong == "")
                {
                    MessageBox.Show("Mức lương phải lớn hơn 4.000.000 đồng và không được bỏ trống", "Thông báo", MessageBoxButtons.OK);
                    LuongTxtE.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Lương phải là kiểu dữ liệu hợp lệ", "Thông báo", MessageBoxButtons.OK);
                LuongTxtE.Focus();
                return false;
            }


            return true;
        }

        private static int CheckAge(DateTime dateOfBirth)
        {
            int age = 0;
            age = DateTime.Now.Year - dateOfBirth.Year;
            if (DateTime.Now.DayOfYear < dateOfBirth.DayOfYear)
                age = age - 1;

            return age;
        }

        public static bool CheckDataExistence(string query, string errorMessage, System.Windows.Forms.TextBox textBox)
        {
            using (SqlDataReader reader = Program.ExecSqlDataReader(query))
            {
                if (reader != null && reader.HasRows)
                {
                    MessageBox.Show(errorMessage + textBox.Text + " đã tồn tại", "Thông báo", MessageBoxButtons.OK);
                    textBox.Focus();
                    return true;
                }
            }
            return false;
        }

        private void HoanTacBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int index = UndoRedo.DoUndo();
            if(index != -1)
            {
                this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                this.nhanVienTableAdapter.Update(this.DataSet.NhanVien);
                LamMoiBtn.PerformClick();
                bdsNV.Position = index;
            }
            else
            {
                MessageBox.Show("Không còn dữ liệu để hoàn tác!", "Thông báo");
            }

        }

        private void TextBoxClicked(object sender, EventArgs e)
        {
            BoGhiBtn.Enabled = true;
            Index = bdsNV.Position;
            NhanVienGc.Enabled = false;
        }

        private void BoGhiBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BoGhiBtn.Enabled = false;
            this.nhanVienTableAdapter.Fill(this.DataSet.NhanVien);
            this.NhanVienGc.Enabled = true;
            bdsNV.Position = Index;
            ThemBtn.Enabled = true;
            XoaBtn.Enabled = true;
            ChuyenCNBtn.Enabled = true;
            this.NhanVienGc.Focus();
        }

        public DataRowView CopyDataRowView(DataRowView original)
        {
            // Tạo một DataTable mới để chứa dữ liệu của original
            DataTable tempTable = original.DataView.Table.Clone();

            // Tạo một dòng mới trong DataTable
            DataRow tempRow = tempTable.NewRow();

            // Sao chép dữ liệu từ original sang tempRow
            foreach (DataColumn column in tempTable.Columns)
            {
                tempRow[column.ColumnName] = original.Row[column.ColumnName];
            }

            // Thêm dòng mới vào DataTable
            tempTable.Rows.Add(tempRow);

            // Tạo một DataRowView từ dòng mới trong DataTable
            DataView tempDataView = new DataView(tempTable);
            DataRowView clonedRow = tempDataView[0];
            return clonedRow;
        }

        private void NhanVienGc_Click(object sender, EventArgs e)
        {
            if ((DataRowView)bdsNV.Current != null)
                TempData = CopyDataRowView((DataRowView)bdsNV.Current);
        }
    }
}

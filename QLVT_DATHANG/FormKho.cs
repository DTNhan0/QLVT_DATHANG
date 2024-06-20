using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLVT_DATHANG
{
    public partial class FormKho : DevExpress.XtraEditors.XtraForm
    {
        bool IsThem = false;
        bool IsHoanTac = false;
        int Index = 0;
        String MaCN = "";

        StackUndoRedo UndoRedo;
        DataRowView TempData = null;

        public FormKho()
        {
            InitializeComponent();
        }

        private void FormKho_Load(object sender, EventArgs e)
        {
            DataSet.EnforceConstraints = false;

            this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
            this.khoTableAdapter.Fill(this.DataSet.Kho);

            this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.datHangTableAdapter.Fill(this.DataSet.DatHang);

            this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuNhapTableAdapter.Fill(this.DataSet.PhieuNhap);

            this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuXuatTableAdapter.Fill(this.DataSet.PhieuXuat);

            MaCN = ((DataRowView)bdsKho[0])["MACN"].ToString();

            ChiNhanhCb.DataSource = Program.bds_dspm;
            ChiNhanhCb.DisplayMember = "TENCN";
            ChiNhanhCb.ValueMember = "TENSERVER";
            ChiNhanhCb.SelectedIndex = Program.mChiNhanh;

            CheckLoginPermission();
            BoGhiBtn.Enabled = false;

            UndoRedo = new StackUndoRedo(bdsKho);

            KhoGc_Click(sender, e);

        }

        public void CheckLoginPermission()
        {
            switch (Program.mGroup)
            {
                case "CONGTY":
                    setEnableOptions(false);
                    ChiNhanhCb.Enabled = true;
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

        private void TextBoxClicked(object sender, EventArgs e)
        {
            BoGhiBtn.Enabled = true;
            Index = bdsKho.Position;
            KhoGc.Enabled = false;
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

        private void KhoGc_Click(object sender, EventArgs e)
        {
            if ((DataRowView)bdsKho.Current != null)
            {
                TempData = CopyDataRowView((DataRowView)bdsKho.Current);
            }
        }

        private bool CheckDataInput()
        {
            /*kiem tra txtMAKHO*/
            if (MaKhoTb.Text == "")
            {
                MessageBox.Show("Không bỏ trống mã kho hàng", "Thông báo", MessageBoxButtons.OK);
                MaKhoTb.Focus();
                return false;
            }

            if (Regex.IsMatch(MaKhoTb.Text, @"^[a-zA-Z0-9]+$") == false)
            {
                MessageBox.Show("Mã kho chỉ chấp nhận chữ và số", "Thông báo", MessageBoxButtons.OK);
                MaKhoTb.Focus();
                return false;
            }

            if (MaKhoTb.Text.Length > 4)
            {
                MessageBox.Show("Mã kho không thể lớn hơn 4 kí tự", "Thông báo", MessageBoxButtons.OK);
                MaKhoTb.Focus();
                return false;
            }
            /*kiem tra txtTenKho*/
            if (TenKhoTb.Text == "")
            {
                MessageBox.Show("Không bỏ trống tên kho hàng", "Thông báo", MessageBoxButtons.OK);
                TenKhoTb.Focus();
                return false;
            }

            if (Regex.IsMatch(TenKhoTb.Text, @"^[a-zA-Z0-9 ]+$") == false)
            {
                MessageBox.Show("Mã kho chỉ chấp nhận chữ cái, số và khoảng trắng", "Thông báo", MessageBoxButtons.OK);
                TenKhoTb.Focus();
                return false;
            }

            if (TenKhoTb.Text.Length > 30)
            {
                MessageBox.Show("Tên kho không thể quá 30 kí tự", "Thông báo", MessageBoxButtons.OK);
                TenKhoTb.Focus();
                return false;
            }
            /*kiem tra txtDiaChi*/
            if (DiaChiTb.Text == "")
            {
                MessageBox.Show("Không bỏ trống địa chỉ kho hàng", "Thông báo", MessageBoxButtons.OK);
                DiaChiTb.Focus();
                return false;
            }

            if (Regex.IsMatch(DiaChiTb.Text, @"^[a-zA-Z0-9, ]+$") == false)
            {
                MessageBox.Show("Địa chỉ chỉ gồm chữ cái, số và khoảng trắng", "Thông báo", MessageBoxButtons.OK);
                DiaChiTb.Focus();
                return false;
            }

            if (DiaChiTb.Text.Length > 100)
            {
                MessageBox.Show("Địa chỉ không quá 100 kí tự", "Thông báo", MessageBoxButtons.OK);
                DiaChiTb.Focus();
                return false;
            }

            return true;
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

        private void LamMoiBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                CheckLoginPermission();
                IsThem = false;
                MaKhoTb.Enabled = false;

                this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
                this.khoTableAdapter.Fill(this.DataSet.Kho);

                this.KhoGc.Enabled = true;
                this.KhoGc.Focus();

                BoGhiBtn.Enabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Làm mới" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                return;
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

        private void BoGhiBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BoGhiBtn.Enabled = false;
            this.khoTableAdapter.Fill(this.DataSet.Kho);
            this.KhoGc.Enabled = true;
            bdsKho.Position = Index;
            ThemBtn.Enabled = true;
            XoaBtn.Enabled = true;
            ChuyenCNBtn.Enabled = true;
            this.KhoGc.Focus();
            HoanTacBtn.Enabled = true;
        }

        private void ThemBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.panelNhapXuat.Enabled = true;

            IsThem = true;
            bdsKho.AddNew();
            Index = bdsKho.Position;
            MaCNTb.Text = MaCN;
            setEnableOptions(false);

            MaKhoTb.Enabled = true;
            panelNhapXuat.Enabled = true;
            GhiBtn.Enabled = true;
            KhoGc.Enabled = false;
        }

        private void XoaBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String MaKho = ((DataRowView)bdsKho[bdsKho.Position])["MAKHO"].ToString();

            if (bdsKho.Count == 0)
            {
                XoaBtn.Enabled = false;
            }

            if (bdsPX.Count > 0)
            {
                MessageBox.Show("Không thể xóa kho này vì đã lập phiếu xuất", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if (bdsPN.Count > 0)
            {
                MessageBox.Show("Không thể xóa kho này vì đã lập phiếu nhập", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if (bdsDH.Count > 0)
            {
                MessageBox.Show("Không thể xóa kho này vì đã lập đơn đặt hàng", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa kho có mã: " + MaKho + " không?", "Thông báo",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (bdsKho.Current != null)
                {
                    try
                    {
                        DataRowView currentRow = (DataRowView)bdsKho.Current;

                        UndoRedo.InsertStack(CopyDataRowView(currentRow), "Delete", bdsKho.Position);

                        bdsKho.RemoveCurrent();
                        bdsKho.EndEdit();

                        Index = bdsKho.Position;

                        this.HoanTacBtn.Enabled = true;
                        this.HoanTacBtn.Enabled = true;
                        this.khoTableAdapter.Update(this.DataSet.Kho);

                        MessageBox.Show("Xóa dữ liệu thành công!");
                        HoanTacBtn.Enabled = true;

                        LamMoiBtn.PerformClick();
                        String sql = "declare @result int\r\nexec @result = sp_TraCuu_KiemTraMaKho '" + MaKho + "'\r\nselect @result";
                        while (true)
                        {
                            int reader = Program.ExecSqlScalar(sql);
                            if (reader == -1 || reader == 1)
                            {
                                Thread.Sleep(100);
                            }
                            else
                            {
                                MessageBox.Show("Cơ sở dữ liệu đã cập nhật lại thông tin!", "Thông báo", MessageBoxButtons.OK);
                                break;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi xóa dữ liệu: " + ex.Message);
                        bdsKho.Position = Index;
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
                    if (CheckDataExistence("EXEC [dbo].[sp_TraCuu_KiemTraMaKho] '" + MaKhoTb.Text + "'", "Mã kho: ", MaKhoTb))
                        return;

                    DataRowView currentRow = (DataRowView)bdsKho.Current;
                    bdsKho.EndEdit();
                    String MaKho = ((DataRowView)bdsKho[bdsKho.Position])["MAKHO"].ToString();

                    this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.khoTableAdapter.Update(this.DataSet.Kho);

                    MessageBox.Show("Thêm dữ liệu thành công!");

                    LamMoiBtn.PerformClick();

                    for (int i = 0; i < bdsKho.Count; i++)
                    {
                        DataRowView rowView = (DataRowView)bdsKho[i];
                        if (rowView["MAKHO"].ToString() == MaKho)
                        {
                            Index = i;
                            break;
                        }
                    }

                    bdsKho.Position = Index;

                    UndoRedo.InsertStack((DataRowView)bdsKho.Current, "Add", bdsKho.Position);
                    HoanTacBtn.Enabled = true;

                    String sql = "declare @result int\r\nexec @result = sp_TraCuu_KiemTraMaKho '" + MaKho + "'\r\nselect @result";
                    while (true)
                    {
                        int reader = Program.ExecSqlScalar(sql);
                        if (reader == -1 || reader == 0)
                        {
                            Thread.Sleep(100);
                        }
                        else
                        {
                            MessageBox.Show("Cơ sở dữ liệu đã cập nhật lại thông tin!", "Thông báo", MessageBoxButtons.OK);
                            break;
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi thêm dữ liệu: " + ex.Message);
                    bdsKho.Position = Index;
                    return;
                }
            }
            else
            {
                DataRowView OldData = TempData;

                if (MessageBox.Show("Bạn có chắc chắn muốn cập nhật vật tư có mã: " + MaKhoTb.Text + " không?", "Thông báo",
                    MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    try
                    {
                        Index = bdsKho.Position;

                        UndoRedo.InsertStack(OldData, "Update", Index);

                        DataRowView currentRow = (DataRowView)bdsKho.Current;

                        this.Validate();
                        bdsKho.EndEdit();
                        this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.khoTableAdapter.Update(this.DataSet.Kho);

                        MessageBox.Show("Cập nhật dữ liệu thành công!");

                        LamMoiBtn.PerformClick();
                        bdsKho.Position = Index;
                        HoanTacBtn.Enabled = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi cập nhật dữ liệu: " + ex.Message);
                        bdsKho.Position = Index;
                        return;
                    }
                }
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
                Program.mlogin = Program.remotelogin;
                Program.password = Program.remotepassword;
            }

            if (Program.KetNoi() == 0)
            {
                MessageBox.Show("Xảy ra lỗi kết nối với chi nhánh hiện tại", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                /*Do du lieu tu dataSet vao grid Control*/
                this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
                this.khoTableAdapter.Fill(this.DataSet.Kho);

                this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
                this.phieuNhapTableAdapter.Fill(this.DataSet.PhieuNhap);

                this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
                this.phieuXuatTableAdapter.Fill(this.DataSet.PhieuXuat);

                this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
                this.datHangTableAdapter.Fill(this.DataSet.DatHang);
                /*Tu dong lay maChiNhanh hien tai - phuc vu cho phan btnTHEM*/
                /*Cho dong nay chay thi bi loi*/
                //maChiNhanh = ((DataRowView)bdsNhanVien[0])["MACN"].ToString().Trim();
            }
        }

        private void HoanTacBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int index = UndoRedo.DoUndo();
            if (index != -1)
            {
                this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
                this.khoTableAdapter.Update(this.DataSet.Kho);
                LamMoiBtn.PerformClick();
                bdsKho.Position = index;
            }
            else
            {
                MessageBox.Show("Không còn dữ liệu để hoàn tác!", "Thông báo");
            }
        }
    }
}
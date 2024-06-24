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
    public partial class FormVatTu : DevExpress.XtraEditors.XtraForm
    {
        bool IsThem = false;
        bool IsHoanTac = false;
        int Index = 0;

        StackUndoRedo UndoRedo;
        DataRowView TempData = null;

        public FormVatTu()
        {
            InitializeComponent();
        }

        private void FormVatTu_Load(object sender, EventArgs e)
        {
            DataSet.EnforceConstraints = false;

            this.vattuTableAdapter.Connection.ConnectionString = Program.connstr;
            this.vattuTableAdapter.Fill(this.DataSet.Vattu);

            this.cTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTDDHTableAdapter.Fill(this.DataSet.CTDDH);

            this.cTPNTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTPNTableAdapter.Fill(this.DataSet.CTPN);

            this.cTPXTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTPXTableAdapter.Fill(this.DataSet.CTPX);


            ChiNhanhCb.DataSource = Program.bds_dspm;
            ChiNhanhCb.DisplayMember = "TENCN";
            ChiNhanhCb.ValueMember = "TENSERVER";
            ChiNhanhCb.SelectedIndex = Program.mChiNhanh;

            CheckLoginPermission();
            BoGhiBtn.Enabled = false;

            UndoRedo = new StackUndoRedo(bdsVT);

            VatTuGc_Click(sender, e);
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
                    setEnableOptions(true);
                    break;
                case "USER":
                    setEnableOptions(true);
                    ThemBtn.Enabled = false;
                    XoaBtn.Enabled = false;
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
            Index = bdsVT.Position;
            VatTuGc.Enabled = false;
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

        private void VatTuGc_Click(object sender, EventArgs e)
        {
            if ((DataRowView)bdsVT.Current != null)
            {
                TempData = CopyDataRowView((DataRowView)bdsVT.Current);
            }
        }

        private bool CheckDataInput()
        {
            /*Kiem tra txtMAVT*/
            if (MaVTTb.Text == "")
            {
                MessageBox.Show("Không bỏ trống mã vật tư", "Thông báo", MessageBoxButtons.OK);
                MaVTTb.Focus();
                return false;
            }

            if (Regex.IsMatch(MaVTTb.Text, @"^[a-zA-Z0-9]+$") == false)
            {
                MessageBox.Show("Mã vật tư chỉ có chữ cái và số", "Thông báo", MessageBoxButtons.OK);
                MaVTTb.Focus();
                return false;
            }

            if (MaVTTb.Text.Length > 4)
            {
                MessageBox.Show("Mã vật tư không quá 4 kí tự", "Thông báo", MessageBoxButtons.OK);
                MaVTTb.Focus();
                return false;
            }
            /*Kiem tra txtTENVT*/
            if (TenVTTb.Text == "")
            {
                MessageBox.Show("Không bỏ trống tên vật tư", "Thông báo", MessageBoxButtons.OK);
                TenVTTb.Focus();
                return false;
            }

            //if (Regex.IsMatch(TenVTTb.Text, @"^[a-zA-Z0-9 ]+$") == false)
            //{
            //    MessageBox.Show("Tên vật tư chỉ chấp nhận chữ, số và khoảng trắng", "Thông báo", MessageBoxButtons.OK);
            //    TenVTTb.Focus();
            //    return false;
            //}

            if (TenVTTb.Text.Length > 30)
            {
                MessageBox.Show("Tên vật tư không quá 30 kí tự", "Thông báo", MessageBoxButtons.OK);
                TenVTTb.Focus();
                return false;
            }
            /*Kiem tra txtDONVIVATTU*/
            if (DvtTb.Text == "")
            {
                MessageBox.Show("Không bỏ trống đơn vị tính", "Thông báo", MessageBoxButtons.OK);
                DvtTb.Focus();
                return false;
            }

            //if (Regex.IsMatch(DvtTb.Text, @"^[a-zA-Z ]+$") == false)
            //{
            //    MessageBox.Show("Đơn vị vật tư chỉ có chữ cái", "Thông báo", MessageBoxButtons.OK);
            //    DvtTb.Focus();
            //    return false;
            //}

            if (DvtTb.Text.Length > 15)
            {
                MessageBox.Show("Đơn vị vật tự không quá 15 kí tự", "Thông báo", MessageBoxButtons.OK);
                DvtTb.Focus();
                return false;
            }
            /*Kiem tra txtSOLUONGTON*/
            if (SoLgTonTb.Text == "")
            {
                MessageBox.Show("Sô lượng tồn không được bỏ trống", "Thông báo", MessageBoxButtons.OK);
                SoLgTonTb.Focus();
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

        private int kiemTraVatTuCoSuDungTaiChiNhanhKhac(String maVatTu)
        {
            String cauTruyVan =
                    "DECLARE	@result int " +
                    "EXEC @result = sp_KiemTraMaVatTuChiNhanhConLai '" +
                    maVatTu + "' " +
                    "SELECT 'Value' = @result";
            SqlCommand sqlCommand = new SqlCommand(cauTruyVan, Program.conn);
            try
            {
                Program.myReader = Program.ExecSqlDataReader(cauTruyVan);
                /*khong co ket qua tra ve thi ket thuc luon*/
                if (Program.myReader == null)
                {
                    return 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thực thi database thất bại!\n\n" + ex.Message, "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
                return 1;
            }
            Program.myReader.Read();
            int result = int.Parse(Program.myReader.GetValue(0).ToString());
            //Console.WriteLine("line 535");
            //Console.WriteLine(result);
            Program.myReader.Close();

            /*result = 1 nghia la vat tu nay dang duoc su dung o chi nhanh con lai*/
            int ketQua = (result == 1) ? 1 : 0;

            return ketQua;
        }

        private void LamMoiBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                CheckLoginPermission();
                IsThem = false;
                MaVTTb.Enabled = false;

                this.vattuTableAdapter.Connection.ConnectionString = Program.connstr;
                this.vattuTableAdapter.Fill(this.DataSet.Vattu);

                this.VatTuGc.Enabled = true;
                this.VatTuGc.Focus();

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
            this.vattuTableAdapter.Fill(this.DataSet.Vattu);
            this.VatTuGc.Enabled = true;
            bdsVT.Position = Index;
            ThemBtn.Enabled = true;
            XoaBtn.Enabled = true;
            ChuyenCNBtn.Enabled = true;
            this.VatTuGc.Focus();
            HoanTacBtn.Enabled = true;
        }

        private void ThemBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.panelNhapXuat.Enabled = true;

            IsThem = true;
            bdsVT.AddNew();
            Index = bdsVT.Position;
            SoLgTonTb.Text = "0";

            setEnableOptions(false);
            MaVTTb.Enabled = true;
            panelNhapXuat.Enabled = true;
            GhiBtn.Enabled = true;
            VatTuGc.Enabled = false;
        }

        private void XoaBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String MaVT = ((DataRowView)bdsVT[bdsVT.Position])["MAVT"].ToString();

            if (bdsVT.Count == 0)
            {
                XoaBtn.Enabled = false;
            }

            if (bdsCTPX.Count > 0)
            {
                MessageBox.Show("Không thể xóa vật tư này vì đã lập chi tiết phiếu xuất", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if (bdsCTPN.Count > 0)
            {
                MessageBox.Show("Không thể xóa vật tư này vì đã lập chi tiết phiếu xuất", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if (bdsCTDDH.Count > 0)
            {
                MessageBox.Show("Không thể xóa vật tư này vì đã lập chi tiết đơn đặt hàng", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            int ketQua = kiemTraVatTuCoSuDungTaiChiNhanhKhac(MaVT);

            if (ketQua == 1)
            {
                MessageBox.Show("Không thể xóa vật tư này vì đang được sử dụng ở chi nhánh khác", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa vật tư có mã: " + MaVT + " không?", "Thông báo",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (bdsVT.Current != null)
                {
                    try
                    {
                        DataRowView currentRow = (DataRowView)bdsVT.Current;

                        UndoRedo.InsertStack(CopyDataRowView(currentRow), "Delete", bdsVT.Position);

                        bdsVT.RemoveCurrent();
                        bdsVT.EndEdit();

                        Index = bdsVT.Position;

                        this.HoanTacBtn.Enabled = true;
                        this.HoanTacBtn.Enabled = true;
                        this.vattuTableAdapter.Update(this.DataSet.Vattu);

                        MessageBox.Show("Xóa dữ liệu thành công!");
                        HoanTacBtn.Enabled = true;

                        LamMoiBtn.PerformClick();
                        String sql = "declare @returnedResult int\r\nexec @returnedResult = sp_KiemTraMaVatTu '" + MaVT + "'\r\nselect @returnedResult";
                        while (true)
                        {
                            int reader = Program.ExecSqlScalar(sql);
                            if(reader == -1 || reader == 1)
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
                        bdsVT.Position = Index;
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
                    if (CheckDataExistence("EXEC [dbo].[sp_KiemTraMaVatTu] '" + MaVTTb.Text + "'", "Mã vật tư: ", MaVTTb))
                        return;

                    DataRowView currentRow = (DataRowView)bdsVT.Current;
                    int soLuongTon = int.Parse(SoLgTonTb.Text);
                    currentRow["SOLUONGTON"] = soLuongTon;
                    bdsVT.EndEdit();
                    String MaVT = ((DataRowView)bdsVT[bdsVT.Position])["MAVT"].ToString();

                    this.vattuTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.vattuTableAdapter.Update(this.DataSet.Vattu);

                    MessageBox.Show("Thêm dữ liệu thành công!");

                    LamMoiBtn.PerformClick();

                    for (int i = 0; i < bdsVT.Count; i++)
                    {
                        DataRowView rowView = (DataRowView)bdsVT[i];
                        if (rowView["MAVT"].ToString() == MaVT)
                        {
                            Index = i;
                            break;
                        }
                    }

                    bdsVT.Position = Index;

                    UndoRedo.InsertStack((DataRowView)bdsVT.Current, "Add", bdsVT.Position);
                    HoanTacBtn.Enabled = true;

                    String sql = "declare @returnedResult int\r\nexec @returnedResult = sp_KiemTraMaVatTu '" + MaVT + "'\r\nselect @returnedResult";
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
                    bdsVT.Position = Index;
                    return;
                }
            }
            else
            {
                DataRowView OldData = TempData;

                if (MessageBox.Show("Bạn có chắc chắn muốn cập nhật vật tư có mã: " + MaVTTb.Text + " không?", "Thông báo",
                    MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    try
                    {
                        Index = bdsVT.Position;

                        UndoRedo.InsertStack(OldData, "Update", Index);

                        DataRowView currentRow = (DataRowView)bdsVT.Current;

                        this.Validate();
                        bdsVT.EndEdit();
                        this.vattuTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.vattuTableAdapter.Update(this.DataSet.Vattu);

                        MessageBox.Show("Cập nhật dữ liệu thành công!");

                        LamMoiBtn.PerformClick();
                        bdsVT.Position = Index;
                        HoanTacBtn.Enabled = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi cập nhật dữ liệu: " + ex.Message);
                        bdsVT.Position = Index;
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
                this.vattuTableAdapter.Connection.ConnectionString = Program.connstr;
                this.vattuTableAdapter.Fill(this.DataSet.Vattu);

                this.cTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
                this.cTDDHTableAdapter.Fill(this.DataSet.CTDDH);

                this.cTPNTableAdapter.Connection.ConnectionString = Program.connstr;
                this.cTPNTableAdapter.Fill(this.DataSet.CTPN);

                this.cTPXTableAdapter.Connection.ConnectionString = Program.connstr;
                this.cTPXTableAdapter.Fill(this.DataSet.CTPX);
                /*Tu dong lay maChiNhanh hien tai - phuc vu cho phan btnTHEM*/
                /*Cho dong nay chay thi bi loi*/
                //maChiNhanh = ((DataRowView)bdsNhanVien[0])["MACN"].ToString().Trim();
            }
        }

        private void SoLgTonTb_TextChanged(object sender, EventArgs e)
        {
            int soLuongTon;
            if (int.TryParse(SoLgTonTb.Text, out soLuongTon))
            {
                if (soLuongTon < 0)
                {
                    MessageBox.Show("Số lượng tồn kho không được nhỏ hơn 0!", "Thông báo", MessageBoxButtons.OK);
                    SoLgTonTb.Text = "0";
                }
            }
        }

        private void HoanTacBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int index = UndoRedo.DoUndo();
            if (index != -1)
            {
                this.vattuTableAdapter.Connection.ConnectionString = Program.connstr;
                this.vattuTableAdapter.Update(this.DataSet.Vattu);
                LamMoiBtn.PerformClick();
                bdsVT.Position = index;
            }
            else
            {
                MessageBox.Show("Không còn dữ liệu để hoàn tác!", "Thông báo");
            }
        }
    }
}
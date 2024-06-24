using DevExpress.XtraEditors;
using QLVT_DATHANG.SubForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLVT_DATHANG
{
    public partial class FormPhieuXuat : DevExpress.XtraEditors.XtraForm
    {
        int ViTriPX = -1;
        int ViTriCTPX = -1;
        bool CheDo;
        BindingSource bds = null;
        bool dangThemMoi = false;

        public FormPhieuXuat()
        {
            InitializeComponent();
        }

        private void FormPhieuXuat_Load(object sender, EventArgs e)
        {
            DataSet.EnforceConstraints = false;
            this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
            this.khoTableAdapter.Fill(this.DataSet.Kho);

            this.vattuTableAdapter.Connection.ConnectionString = Program.connstr;
            this.vattuTableAdapter.Fill(this.DataSet.Vattu);

            this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuXuatTableAdapter.Fill(this.DataSet.PhieuXuat);

            this.cTPXTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTPXTableAdapter.Fill(this.DataSet.CTPX);

            /*van con ton tai loi chua sua duoc*/
            //maChiNhanh = ((DataRowView)bdsVatTu[0])["MACN"].ToString();

            ChiNhanhCb.DataSource = Program.bds_dspm;/*sao chep bingding source tu form dang nhap*/
            ChiNhanhCb.DisplayMember = "TENCN";
            ChiNhanhCb.ValueMember = "TENSERVER";
            ChiNhanhCb.SelectedIndex = Program.mChiNhanh;
            BoGhiBtn.Enabled = false;
            setEnableOptions(false);
            CheckLoginPermission();

        }

        public void CheckLoginPermission()
        {
            switch (Program.mGroup)
            {
                case "CONGTY":
                    ChiNhanhCb.Enabled = true;
                    PhieuXuatGc.Enabled = true;
                    CTPXGc.Enabled = true;
                    ApDungChoBsi.Enabled = false;
                    HoanTacBtn.Enabled = false;
                    setEnableOptions(false);
                    setEnableDetails(false);
                    ChonKHBtn.Enabled = false;
                    ChonVatTuBtn.Enabled = false;
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

        private void ChonKHBtn_Click(object sender, EventArgs e)
        {
            FormChonKhoHang form = new FormChonKhoHang();
            form.ShowDialog();
            this.MaKhoTb.Text = Program.maKhoDuocChon;
        }

        private void ChonVatTuBtn_Click(object sender, EventArgs e)
        {
            FormChonVatTu form = new FormChonVatTu();
            form.ShowDialog();

            Thread.Sleep(100);
            this.MaVTTb.Text = Program.maVatTuDuocChon;
            ((DataRowView)(bdsCTPX.Current))["MAVT"] = MaCTVTTb.Text;
        }

        private void setEnableOptions(bool check)
        {
            if (check)
            {
                ThemBtn.Enabled = true;
                XoaBtn.Enabled = true;
                GhiBtn.Enabled = true;
            }
            else if (check == false)
            {
                ThemBtn.Enabled = false;
                XoaBtn.Enabled = false;
                GhiBtn.Enabled = false;
            }
        }

        private void setEnableDetails(bool check)
        {
            if (check)
            {
                this.HoTenKHTb.Enabled = true;
                this.NgayDE.Enabled = true;

                DonGiaTb.Enabled = true;
                SoLuongTb.Enabled = true;
            }
            else if (check == false)
            {
                this.HoTenKHTb.Enabled = false;
                this.NgayDE.Enabled = false;

                DonGiaTb.Enabled = false;
                SoLuongTb.Enabled = false;
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
            else
            {
                this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
                this.khoTableAdapter.Fill(this.DataSet.Kho);

                this.vattuTableAdapter.Connection.ConnectionString = Program.connstr;
                this.vattuTableAdapter.Fill(this.DataSet.Vattu);

                this.cTPXTableAdapter.Connection.ConnectionString = Program.connstr;
                this.cTPXTableAdapter.Fill(this.DataSet.CTPX);

                this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
                this.phieuXuatTableAdapter.Fill(this.DataSet.PhieuXuat);

                this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
                this.khoTableAdapter.Fill(this.DataSet.Kho);
            }
        }

        private void PhieuXuatBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PhieuXuatGc.Enabled = true;
            PXGrpC.Enabled = true;
            CTPXGc.Enabled = false;
            CTPXGrpC.Enabled = false;
            CheDo = true;
            bds = bdsPX;
            ApDungChoBsi.Caption = "Phiếu xuất";
            setEnableOptions(true);
            setEnableDetails(true);
            CheckLoginPermission();
        }

        private void ChiTietPXBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PhieuXuatGc.Enabled = false;
            PXGrpC.Enabled = false;
            CTPXGc.Enabled = true;
            CTPXGrpC.Enabled = true;
            CheDo = false;
            bds = bdsCTPX;
            ApDungChoBsi.Caption = "Chi tiết phiếu xuất";
            setEnableOptions(true);
            setEnableDetails(true);
            CheckLoginPermission();
        }

        private bool CheckDataInput()
        {
            if (CheDo)
            {
                DataRowView drv = ((DataRowView)bdsPX[bdsPX.Position]);
                String maNhanVien = drv["MANV"].ToString();
                if (Program.username != maNhanVien)
                {
                    MessageBox.Show("Không thể sửa phiếu xuất do người khác tạo", "Thông báo", MessageBoxButtons.OK);
                    return false;
                }

                if (MaPXTb.Text == "")
                {
                    MessageBox.Show("Không bỏ trống mã phiếu xuất !", "Thông báo", MessageBoxButtons.OK);
                    MaPXTb.Focus();
                    return false;
                }

                if (MaPXTb.Text.Length > 8)
                {
                    MessageBox.Show("Mã phiếu xuất không thể quá 8 kí tự !", "Thông báo", MessageBoxButtons.OK);
                    MaPXTb.Focus();
                    return false;
                }

                if (HoTenKHTb.Text == "")
                {
                    MessageBox.Show("Không bỏ trống tên khách hàng !", "Thông báo", MessageBoxButtons.OK);
                    HoTenKHTb.Focus();
                    return false;
                }

                if (HoTenKHTb.Text.Length > 100)
                {
                    MessageBox.Show("Tên khách hàng không quá 100 kí tự !", "Thông báo", MessageBoxButtons.OK);
                    HoTenKHTb.Focus();
                    return false;
                }

                if (MaKhoTb.Text == "")
                {
                    MessageBox.Show("Không bỏ trống mã kho !", "Thông báo", MessageBoxButtons.OK);
                    return false;
                }
            }

            if (CheDo == false)
            {
                DataRowView drv = ((DataRowView)bdsPX[bdsPX.Position]);
                String maNhanVien = drv["MANV"].ToString();
                if (Program.username != maNhanVien)
                {
                    MessageBox.Show("Không thể thêm chi tiết phiếu xuất với phiếu xuất do người khác tạo !", "Thông báo", MessageBoxButtons.OK);
                    bdsCTPX.RemoveCurrent();
                    return false;
                }

                if (MaPXTb.Text == "")
                {
                    MessageBox.Show("Không bỏ trống mã phiếu nhập !", "Thông báo", MessageBoxButtons.OK);
                    MaPXTb.Focus();
                    return false;
                }

                if (MaPXTb.Text.Length > 8)
                {
                    MessageBox.Show("Mã phiếu xuất không thể quá 8 kí tự !", "Thông báo", MessageBoxButtons.OK);
                    MaPXTb.Focus();
                    return false;
                }

                if (MaCTVTTb.Text == "")
                {
                    MessageBox.Show("Thiếu mã vật tư !", "Thông báo", MessageBoxButtons.OK);
                    MaCTVTTb.Focus();
                    return false;
                }

                if (MaVTTb.Text == "")
                {
                    MessageBox.Show("Thiếu mã vật tư chi tiết, vui lòng chọn vật tư!", "Thông báo", MessageBoxButtons.OK);
                    MaCTVTTb.Focus();
                    return false;
                }

                if (MaCTVTTb.Text.Length > 4)
                {
                    MessageBox.Show("Mã vật tư không quá 4 kí tự !", "Thông báo", MessageBoxButtons.OK);
                    MaCTVTTb.Focus();
                    return false;
                }

                int soLuongVatTu;
                float donGia;

                bool isSoLuongValid = int.TryParse(SoLuongTb.Text, out soLuongVatTu);
                bool isDonGiaValid = float.TryParse(DonGiaTb.Text, out donGia);

                if (!isSoLuongValid || !isDonGiaValid || soLuongVatTu <= 0 || donGia <= 0)
                {
                    MessageBox.Show("Số lượng vật tư hoặc đơn giá không được nhỏ hơn 0 và phải là số hợp lệ", "Thông báo", MessageBoxButtons.OK);
                    return false;
                }
            }
            return true;
        }

        private void LamMoiBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                setEnableDetails(true);
                setEnableOptions(true);
                CheckLoginPermission();
                MaPXTb.Enabled = false;

                this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
                this.khoTableAdapter.Update(this.DataSet.Kho);
                this.khoTableAdapter.Fill(this.DataSet.Kho);

                this.vattuTableAdapter.Connection.ConnectionString = Program.connstr;
                this.vattuTableAdapter.Update(this.DataSet.Vattu);
                this.vattuTableAdapter.Fill(this.DataSet.Vattu);

                this.cTPXTableAdapter.Connection.ConnectionString = Program.connstr;
                this.cTPXTableAdapter.Update(this.DataSet.CTPX);
                this.cTPXTableAdapter.Fill(this.DataSet.CTPX);

                this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
                this.phieuXuatTableAdapter.Update(this.DataSet.PhieuXuat);
                this.phieuXuatTableAdapter.Fill(this.DataSet.PhieuXuat);

                if (CheDo)
                {
                    PhieuXuatGc.Enabled = true;
                    CTPXGc.Enabled = false;
                }
                else
                {
                    PhieuXuatGc.Enabled = false;
                    CTPXGc.Enabled = true;
                }

                bdsPX.Position = ViTriPX;
                bdsCTPX.Position = ViTriCTPX;

                ChonKHBtn.Enabled = false;
                ChonVatTuBtn.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Làm mới" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                return;
            }
        }

        private void ThemBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ChonKHBtn.Enabled = true;
            ChonVatTuBtn.Enabled = true;

            dangThemMoi = true;

            bds.AddNew();
            if (CheDo)
            {
                setEnableDetails(true);

                this.NgayDE.EditValue = DateTime.Now;
                this.MaNVTb.Text = Program.username;
                HoTenKHTb.Text = "";
                MaPXTb.Text = "";
                MaKhoTb.Text = "";
                MaPXTb.Enabled = true;

                ((DataRowView)(bdsPX.Current))["MANV"] = Program.username;
                ((DataRowView)(bdsPX.Current))["NGAY"] = DateTime.Now;
                ((DataRowView)(bdsPX.Current))["MAKHO"] = Program.maKhoDuocChon;
            }
            else
            {
                DataRowView drv = ((DataRowView)bdsPX[bdsPX.Position]);
                String maNhanVien = drv["MANV"].ToString();
                if (Program.username != maNhanVien)
                {
                    MessageBox.Show("Không thể thêm chi tiết phiếu xuất trên phiếu  không phải do mình tạo", "Thông báo", MessageBoxButtons.OK);
                    return;
                }

               /*Gan tu dong may truong du lieu nay*/
               ((DataRowView)(bdsCTPX.Current))["MAPX"] = MaPXTb.Text;
                MaCTPXTb.Text = MaPXTb.Text;
               ((DataRowView)(bdsCTPX.Current))["MAVT"] = Program.maVatTuDuocChon;

                MaVTTb.Text = "";
                SoLuongTonTb.Text = "0";

                MaCTVTTb.Text = "";
                DonGiaTb.Text = "0";
                SoLuongTb.Text = "0";


                setEnableDetails(true);
            }

            setEnableOptions(false);
            GhiBtn.Enabled = true;
        }

        private void XoaBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (CheDo)
                {
                    DataRowView drv = ((DataRowView)bdsPX[bdsPX.Position]);
                    String maNhanVien = drv["MANV"].ToString();
                    if (Program.username != maNhanVien)
                    {
                        MessageBox.Show("Không xóa chi tiết phiếu xuất không phải do mình tạo", "Thông báo", MessageBoxButtons.OK);
                        return;
                    }

                    if (bdsCTPX.Count > 0)
                    {
                        MessageBox.Show("Không thể xóa vì có chi tiết phiếu xuất", "Thông báo", MessageBoxButtons.OK);
                        return;
                    }

                    if (MessageBox.Show("Bạn có chắc chắn muốn xóa phiếu xuất có mã: " + MaPXTb.Text + " không?", "Thông báo",
                        MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        String Mapx = MaPXTb.Text;
                        bdsPX.RemoveCurrent();
                        this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.phieuXuatTableAdapter.Update(this.DataSet.PhieuXuat);

                        MessageBox.Show("Xóa dữ liệu thành công!");

                        String sql = "declare @result int\r\nexec @result = sp_KiemTraMaPhieuXuat '" + Mapx + "'\r\nselect @result";
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
                }
                else
                {
                    DataRowView drv = ((DataRowView)bdsCTPX[bdsCTPX.Position]);
                    String maNhanVien = drv["MANV"].ToString();
                    if (Program.username != maNhanVien)
                    {
                        MessageBox.Show("Bạn không xóa chi tiết đơn hàng trên phiếu không phải do mình tạo", "Thông báo", MessageBoxButtons.OK);
                        return;
                    }

                    if (MessageBox.Show("Bạn có chắc chắn muốn xóa chi tiết đơn hàng có mã: " + MaCTPXTb.Text + " không?", "Thông báo",
                            MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        String Mactpx = MaCTPXTb.Text;
                        String Mavt = MaCTVTTb.Text;
                        bdsCTPX.RemoveCurrent();
                        MessageBox.Show("Xóa dữ liệu thành công!");

                        String sql = "declare @result int\r\nexec @result = sp_KiemTraChiTietPhieuXuat '" + Mactpx + "', " + "'" + Mavt + "' " + "\r\nselect @result";
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
                }

                LamMoiBtn.PerformClick();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xóa nhân viên. Hãy thử lại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                LamMoiBtn.PerformClick();
                return;
            }
        }

        private void ThoatBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }

        private void GhiBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (dangThemMoi)
            {
                try
                {
                    if (CheDo)
                    {
                        if (CheckDataInput() == false)
                        {
                            return;
                        }

                        String sql = "declare @result int\r\nexec @result = sp_KiemTraMaPhieuXuat '" + MaPXTb.Text + "'\r\nselect @result";
                        int reader = Program.ExecSqlScalar(sql);

                        if (reader == 1)
                        {
                            MessageBox.Show("Mã phiếu nhập đã tồn tại, vui lòng nhập mã khác", "Thông báo", MessageBoxButtons.OK);
                            return;
                        }

                        String MaPX = "";

                        DataRowView currentRow = (DataRowView)bdsPX.Current;
                        bdsPX.EndEdit();

                        MaPX = currentRow["MAPX"].ToString();
                        this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.phieuXuatTableAdapter.Update(this.DataSet.PhieuXuat);

                        MessageBox.Show("Thêm dữ liệu thành công!");

                        LamMoiBtn.PerformClick();

                        while (true)
                        {
                            reader = Program.ExecSqlScalar(sql);
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

                        ViTriPX = bdsPX.Find("MAPX", MaPX);
                        bdsPX.Position = ViTriPX;
                        dangThemMoi = false;
                        MaPXTb.Enabled = false;
                    }
                    else
                    {
                        if (CheckDataInput() == false)
                        {
                            return;
                        }

                        String sql = "declare @result int\r\nexec @result = sp_KiemTraChiTietPhieuXuat '" + MaCTPXTb.Text + "', " + "'" + MaVTTb.Text + "' " + "\r\nselect @result";
                        int reader = Program.ExecSqlScalar(sql);

                        if (reader == 1)
                        {
                            MessageBox.Show("Chi tiết phiếu nhập có mã vật tư đã tồn tại, vui lòng chọn vật tư khác", "Thông báo", MessageBoxButtons.OK);
                            return;
                        }

                        if (int.Parse(SoLuongTb.Text) > int.Parse(SoLuongTonTb.Text))
                        {
                            MessageBox.Show("Không nhập quá số lượng đã đặt trên các vật tư trong đơn đặt", "Thông báo", MessageBoxButtons.OK);
                            return;
                        }

                        String MaVT = "";
                        DataRowView currentRow = (DataRowView)bdsCTPX.Current;
                        ((DataRowView)(bdsCTPX.Current))["MAPX"] = ((DataRowView)(bdsCTPX.Current))["MAPX"];
                        bdsCTPX.EndEdit();
                        bdsPX.EndEdit();

                        MaVT = currentRow["MAVT"].ToString();
                        this.cTPXTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.cTPXTableAdapter.Update(this.DataSet.CTPX);
                        this.phieuXuatTableAdapter.Update(this.DataSet.PhieuXuat);

                        MessageBox.Show("Thêm dữ liệu thành công!");
                        string maVatTu = MaCTVTTb.Text.Trim();
                        int soLuong = int.Parse(SoLuongTb.Text);

                        capNhatSoLuongVatTu(maVatTu, soLuong);

                        LamMoiBtn.PerformClick();

                        while (true)
                        {
                            reader = Program.ExecSqlScalar(sql);
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
                        //ViTriCTDH = bdsCTDDH.Find("MAVT", MaVT);
                        //bdsCTDDH.Position = ViTriCTDH;
                        bool found = false;
                        for (int i = 0; i < bdsCTPX.Count; i++)
                        {
                            DataRowView row = (DataRowView)bdsCTPX[i];
                            if (row["MAVT"].ToString() == MaVT)
                            {
                                ViTriCTPX = i;
                                found = true;
                                break;
                            }
                        }

                        if (found)
                        {
                            bdsCTPX.Position = ViTriCTPX;
                        }
                        dangThemMoi = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi thêm dữ liệu: " + ex.Message);

                    return;
                }
            }
            else
            {
                DataRowView drv = ((DataRowView)bdsPX[bdsPX.Position]);
                String maNhanVien = drv["MANV"].ToString();

                if (Program.username != maNhanVien)
                {
                    MessageBox.Show("Bạn không thể sửa phiếu do người khác lập", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                try
                {
                    if (CheDo)
                    {
                        String MaPX = "";
                        DataRowView currentRow = (DataRowView)bdsPX.Current;
                        this.Validate();
                        MaPX = (string)currentRow["MAPX"];
                        bdsPX.EndEdit();
                        this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.phieuXuatTableAdapter.Update(this.DataSet.PhieuXuat);

                        MessageBox.Show("Cập nhật dữ liệu thành công!");

                        LamMoiBtn.PerformClick();

                        ViTriPX = bdsPX.Find("MAPX", MaPX);
                        bdsPX.Position = ViTriPX;
                    }
                    else
                    {
                        if (int.Parse(SoLuongTb.Text) > int.Parse(SoLuongTonTb.Text))
                        {
                            MessageBox.Show("Không nhập quá số lượng đã đặt trên các vật tư trong đơn đặt", "Thông báo", MessageBoxButtons.OK);
                            return;
                        }

                        String MaVT = "";
                        DataRowView currentRow = (DataRowView)bdsCTPX.Current;
                        this.Validate();
                        MaVT = currentRow["MAVT"].ToString();
                        bdsCTPX.EndEdit();
                        this.cTPXTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.cTPXTableAdapter.Update(this.DataSet.CTPX);

                        MessageBox.Show("Cập nhật dữ liệu thành công!");

                        LamMoiBtn.PerformClick();

                        //ViTriCTDH = bdsCTDDH.Find("MAVT", MaVT);
                        //bdsCTDDH.Position = ViTriCTDH;
                        bool found = false;
                        for (int i = 0; i < bdsCTPX.Count; i++)
                        {
                            DataRowView row = (DataRowView)bdsCTPX[i];
                            if (row["MAVT"].ToString() == MaVT)
                            {
                                ViTriCTPX = i;
                                found = true;
                                break;
                            }
                        }

                        if (found)
                        {
                            bdsCTPX.Position = ViTriCTPX;
                        }
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi cập nhật dữ liệu: " + ex.Message);

                    return;
                }
            }
        }

        private void capNhatSoLuongVatTu(string maVatTu, int soLuong)
        {
            string cauTruyVan = "EXEC sp_CapNhatSoLuongVatTu 'IMPORT','" + maVatTu + "', " + soLuong;

            int n = Program.ExecSqlNonQuery(cauTruyVan);
        }

        private void TextBoxClicked(object sender, EventArgs e)
        {
            if (CheDo)
            {
                ThemBtn.Enabled = false;
                XoaBtn.Enabled = false;
                PhieuXuatGc.Enabled = false;
            }
            else
            {
                ThemBtn.Enabled = false;
                XoaBtn.Enabled = false;
                CTPXGc.Enabled = false;
            }
        }

        private void MaVTTb_TextChanged(object sender, EventArgs e)
        {
            if (MaVTTb != null)
            {
                int ViTriMaCTVT = bdsVT.Find("MAVT", MaVTTb.Text);
                if (ViTriMaCTVT != -1)
                {
                    DataRowView currentRow = (DataRowView)bdsVT[ViTriMaCTVT];
                    MaCTVTTb.Text = (string)currentRow["MAVT"];
                    TenVTTb.Text = (string)currentRow["TENVT"];
                    DvtTb.Text = (string)currentRow["DVT"];
                    SoLuongTonTb.Text = currentRow["SOLUONGTON"].ToString();
                }
            }
        }

        private void MaPXTb_TextChanged(object sender, EventArgs e)
        {
            //if (MaPXTb != null)
            //{
            //    MaCTPXTb.Text = MaPXTb.Text;
            //}
        }

        private void PhieuXuatGc_Click(object sender, EventArgs e)
        {
            if ((DataRowView)bdsPX.Current != null)
                ViTriPX = bdsPX.Position;
        }

        private void CTPXGc_Click(object sender, EventArgs e)
        {
            if ((DataRowView)bdsCTPX.Current != null)
                ViTriCTPX = bdsCTPX.Position;
        }
    }
}
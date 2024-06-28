using DevExpress.XtraEditors;
using QLVT_DATHANG.SubForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLVT_DATHANG
{
    public partial class FormDonDatHang : DevExpress.XtraEditors.XtraForm
    {
        int ViTriDH = -1;
        int ViTriCTDH = -1;
        bool CheDo;
        BindingSource bds = null;
        bool dangThemMoi = false;

        public FormDonDatHang()
        {
            InitializeComponent();
        }

        private void FormDonDatHang_Load(object sender, EventArgs e)
        {
            DataSet.EnforceConstraints = false;

            this.vattuTableAdapter.Connection.ConnectionString = Program.connstr;
            this.vattuTableAdapter.Fill(this.DataSet.Vattu);

            this.cTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTDDHTableAdapter.Fill(this.DataSet.CTDDH);

            this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.datHangTableAdapter.Fill(this.DataSet.DatHang);

            this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuNhapTableAdapter.Fill(this.DataSet.PhieuNhap);
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
                    DatHangGc.Enabled = true;
                    CTDDHGc.Enabled = true;
                    ApDungChoBsi.Enabled = false;
                    HoanTacBtn.Enabled = false;
                    setEnableOptions(false);
                    setEnableDetails(false);
                    ChonKhoBtn.Enabled = false;
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

        private void ChonKhoBtn_Click(object sender, EventArgs e)
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
        }

        private void setEnableOptions(bool check)
        {
            if(check)
            {
                ThemBtn.Enabled = true;
                XoaBtn.Enabled = true;
                GhiBtn.Enabled = true;
                BoGhiBtn.Enabled = true;
            }
            else if(check == false)
            {
                ThemBtn.Enabled = false;
                XoaBtn.Enabled = false;
                GhiBtn.Enabled = false;
                BoGhiBtn.Enabled = false;
            }
        }

        private void setEnableDetails(bool check)
        {
            if (check)
            {
                this.NhaCCTb.Enabled = true;
                this.MaDDHTb.Enabled = true;

                DonGiaTb.Enabled = true;
                SoLuongVTTb.Enabled = true;
            }
            else if (check == false)
            {
                this.NhaCCTb.Enabled = false;
                this.MaDDHTb.Enabled = false;

                DonGiaTb.Enabled = false;
                SoLuongVTTb.Enabled = false;
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
                this.cTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
                this.cTDDHTableAdapter.Fill(this.DataSet.CTDDH);

                this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
                this.datHangTableAdapter.Fill(this.DataSet.DatHang);

                this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
                this.phieuNhapTableAdapter.Fill(this.DataSet.PhieuNhap);
            }
        }

        private void DonHangBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DatHangGc.Enabled = true;
            DHGrpC.Enabled = true;
            CTDDHGc.Enabled = false;
            CTDHGrpC.Enabled = false;
            CheDo = true;
            bds = bdsDH;
            ApDungChoBsi.Caption = "Đơn hàng";
            setEnableOptions(true);
            setEnableDetails(true);
            CheckLoginPermission();
        }

        private void ChiTietDonHangBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DatHangGc.Enabled = false;
            DHGrpC.Enabled = false;
            CTDDHGc.Enabled = true;
            CTDHGrpC.Enabled = true;
            CheDo = false;
            bds = bdsCTDDH;
            ApDungChoBsi.Caption = "Chi tiết đơn hàng";
            setEnableOptions(true);
            setEnableDetails(true);
            CheckLoginPermission();
        }

        private bool CheckDataInput()
        {
            if (CheDo)
            {
                if (MaDDHTb.Text == "")
                {
                    MessageBox.Show("Không thể bỏ trống mã đơn hàng", "Thông báo", MessageBoxButtons.OK);
                    return false;
                }
                if (MaDDHTb.Text.Length > 8)
                {
                    MessageBox.Show("Mã đơn đặt hàng không quá 8 kí tự", "Thông báo", MessageBoxButtons.OK);
                    return false;
                }
                if (MaNVTb.Text == "")
                {
                    MessageBox.Show("Không thể bỏ trống mã nhân viên", "Thông báo", MessageBoxButtons.OK);
                    return false;
                }
                if (NhaCCTb.Text == "")
                {
                    MessageBox.Show("Không thể bỏ trống nhà cung cấp", "Thông báo", MessageBoxButtons.OK);
                    return false;
                }
                if (NhaCCTb.Text.Length > 100)
                {
                    MessageBox.Show("Tên nhà cung cấp không quá 100 kí tự", "Thông báo", MessageBoxButtons.OK);
                    return false;
                }
                if (MaKhoTb.Text == "")
                {
                    MessageBox.Show("Không thể bỏ trống mã kho", "Thông báo", MessageBoxButtons.OK);
                    return false;
                }
            }

            if (CheDo == false)
            {
                if (MaVTTb.Text == "")
                {
                    MessageBox.Show("Không thể bỏ trống mã vật tư", "Thông báo", MessageBoxButtons.OK);
                    return false;
                }
                if (DonGiaTb.Text == "")
                {
                    MessageBox.Show("Không thể bỏ trống đơn giá", "Thông báo", MessageBoxButtons.OK);
                    return false;
                }
                if (MaDDHCTTb.Text == "")
                {
                    MessageBox.Show("Không thể bỏ trống mã đơn đặt hàng bên chi tiết", "Thông báo", MessageBoxButtons.OK);
                    return false;
                }
                if (SoLuongVTTb.Text == "")
                {
                    MessageBox.Show("Không thể bỏ trống số lượng vật tư", "Thông báo", MessageBoxButtons.OK);
                    return false;
                }
                int soLuongVatTu;
                float donGia;

                bool isSoLuongValid = int.TryParse(SoLuongVTTb.Text, out soLuongVatTu);
                bool isDonGiaValid = float.TryParse(DonGiaTb.Text, out donGia);

                if (!isSoLuongValid || !isDonGiaValid || soLuongVatTu <= 0 || donGia <= 0)
                {
                    MessageBox.Show("Số lượng vật tư hoặc đơn giá không được nhỏ hơn 0 và phải là số hợp lệ", "Thông báo", MessageBoxButtons.OK);
                    return false;
                }
                /*
                if( txtSoLuong.Value > Program.soLuongVatTu)
                {
                    MessageBox.Show("Sô lượng đặt mua lớn hơn số lượng vật tư hiện có", "Thông báo", MessageBoxButtons.OK);
                    return false;
                }*/
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
                this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
                this.datHangTableAdapter.Update(this.DataSet.DatHang);

                this.cTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
                this.cTDDHTableAdapter.Update(this.DataSet.CTDDH);
                this.datHangTableAdapter.Fill(this.DataSet.DatHang);
                this.cTDDHTableAdapter.Fill(this.DataSet.CTDDH);

                BoGhiBtn.Enabled = false;

                if (CheDo)
                {
                    DatHangGc.Enabled = true;
                    CTDDHGc.Enabled = false;
                }
                else
                {
                    DatHangGc.Enabled = false;
                    CTDDHGc.Enabled = true;
                }

                bdsDH.Position = ViTriDH;
                bdsCTDDH.Position = ViTriCTDH;

                ChonKhoBtn.Enabled = false;
                ChonVatTuBtn.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Làm mới" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                return;
            }
        }

        private void ThoatBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }

        private void ThemBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ChonKhoBtn.Enabled = true;
            ChonVatTuBtn.Enabled = true;

            BoGhiBtn.Enabled = true;

            dangThemMoi = true;

            bds.AddNew();
            if (CheDo)
            {
                setEnableDetails(true);

                this.NgayDE.EditValue = DateTime.Now;
                this.MaNVTb.Text = Program.username;
                MaDDHTb.Text = "";
                NhaCCTb.Text = "";
                MaKhoTb.Text = "";

                ((DataRowView)(bdsDH.Current))["MANV"] = Program.username;
                ((DataRowView)(bdsDH.Current))["NGAY"] = DateTime.Now;
            }
            else
            {
                DataRowView drv = ((DataRowView)bdsDH[bdsDH.Position]);
                String maNhanVien = drv["MANV"].ToString();

                TenVTTb.Text = "";
                DvtTb.Text = "";
                SoLuongTonTb.Text = "";

                MaVTTb.Text = "";
                DonGiaTb.Text = "0";
                SoLuongVTTb.Text = "0";

                if (Program.username != maNhanVien)
                {
                    MessageBox.Show("Bạn không thêm chi tiết đơn hàng trên phiếu không phải do mình tạo", "Thông báo", MessageBoxButtons.OK);
                    bdsCTDDH.RemoveCurrent();
                    return;
                }
                ((DataRowView)(bdsCTDDH.Current))["MasoDDH"] = Program.maDonDatHangDuocChon;

                setEnableDetails(true);
            }

            setEnableOptions(false);
            BoGhiBtn.Enabled = true;
            GhiBtn.Enabled = true;
        }

        private void XoaBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
            if (CheDo)
            {
                DataRowView drv = ((DataRowView)bdsDH[bdsDH.Position]);
                String maNhanVien = drv["MANV"].ToString();
                if (Program.username != maNhanVien)
                {
                    MessageBox.Show("Bạn không xóa đơn hàng trên phiếu không phải do mình tạo", "Thông báo", MessageBoxButtons.OK);
                    return;
                }

                    if (bdsCTDDH.Count > 0)
                {
                    MessageBox.Show("Không thể xóa đơn đặt hàng này vì có chi tiết đơn đặt hàng", "Thông báo", MessageBoxButtons.OK);
                    return;
                }

                if (bdsPN.Count > 0)
                {
                    MessageBox.Show("Không thể xóa đơn đặt hàng này vì có phiếu nhập", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa đơn hàng có mã: " + MaDDHTb.Text + " không?", "Thông báo",
                    MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        bdsDH.RemoveCurrent();

                        MessageBox.Show("Xóa dữ liệu thành công!");

                        String sql = "declare @result int\r\nexec @result = sp_KiemTraMaDonDatHang '" + MaDDHTb.Text + "'\r\nselect @result";
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
                DataRowView drv = ((DataRowView)bdsDH[bdsDH.Position]);
                String maNhanVien = drv["MANV"].ToString();
                if (Program.username != maNhanVien)
                {
                    MessageBox.Show("Bạn không xóa chi tiết đơn hàng trên phiếu không phải do mình tạo", "Thông báo", MessageBoxButtons.OK);
                    return;
                }

                if (MessageBox.Show("Bạn có chắc chắn muốn xóa chi tiết đơn hàng có mã: " + MaDDHCTTb.Text + " không?", "Thông báo",
                        MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        bdsCTDDH.RemoveCurrent();
                        MessageBox.Show("Xóa dữ liệu thành công!");

                        String sql = "declare @result int\r\nexec @result = sp_KiemTraChiTietDonDatHang '" + MaDDHTb.Text + "', " + "'" + MaVTTb.Text + "' " + "\r\nselect @result";
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

                        String sql = "declare @result int\r\nexec @result = sp_KiemTraMaDonDatHang '" + MaDDHTb.Text + "'\r\nselect @result";
                        int reader = Program.ExecSqlScalar(sql);

                        if (reader == 1)
                        {
                            MessageBox.Show("Mã đơn đặt hàng đã tồn tại, vui lòng nhập mã khác", "Thông báo", MessageBoxButtons.OK);
                            return;
                        }

                        String MaDDH = "";

                        DataRowView currentRow = (DataRowView)bdsDH.Current;
                        bdsDH.EndEdit();

                        MaDDH = currentRow["MasoDDH"].ToString();
                        this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.datHangTableAdapter.Update(this.DataSet.DatHang);

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

                        ViTriDH = bdsDH.Find("MasoDDH", MaDDH);
                        bdsDH.Position = ViTriDH;
                        dangThemMoi = false;
                    }
                    else
                    {
                        if (CheckDataInput() == false)
                        {
                            return;
                        }

                        String sql = "declare @result int\r\nexec @result = sp_KiemTraChiTietDonDatHang '" + MaDDHTb.Text + "', " + "'" + MaVTTb.Text + "' " + "\r\nselect @result";
                        int reader = Program.ExecSqlScalar(sql);

                        if (reader == 1)
                        {
                            MessageBox.Show("Chi tiết đơn đặt hàng có mã vật tư đã tồn tại, vui lòng chọn vật tư khác", "Thông báo", MessageBoxButtons.OK);
                            return;
                        }

                        String MaVT = "";
                        DataRowView currentRow = (DataRowView)bdsCTDDH.Current;
                        ((DataRowView)(bdsCTDDH.Current))["MasoDDH"] = ((DataRowView)(bdsDH.Current))["MasoDDH"];
                        bdsCTDDH.EndEdit();
                        bdsDH.EndEdit();
                        this.bdsCTDDH.EndEdit();

                        MaVT = currentRow["MAVT"].ToString();
                        this.cTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.cTDDHTableAdapter.Update(this.DataSet.CTDDH);
                        this.datHangTableAdapter.Update(this.DataSet.DatHang);

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
                        //ViTriCTDH = bdsCTDDH.Find("MAVT", MaVT);
                        //bdsCTDDH.Position = ViTriCTDH;
                        bool found = false;
                        for (int i = 0; i < bdsCTDDH.Count; i++)
                        {
                            DataRowView row = (DataRowView)bdsCTDDH[i];
                            if (row["MAVT"].ToString() == MaVT)
                            {
                                ViTriCTDH = i;
                                found = true;
                                break;
                            }
                        }

                        if (found)
                        {
                            bdsCTDDH.Position = ViTriCTDH;
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
                DataRowView drv = ((DataRowView)bdsDH[bdsDH.Position]);
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
                        String MaDDH = "";
                        DataRowView currentRow = (DataRowView)bdsDH.Current;
                        this.Validate();
                        MaDDH = (string)currentRow["MasoDDH"];
                        bdsDH.EndEdit();
                        this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.datHangTableAdapter.Update(this.DataSet.DatHang);

                        MessageBox.Show("Cập nhật dữ liệu thành công!");

                        LamMoiBtn.PerformClick();

                        ViTriDH = bdsCTDDH.Find("MasoDDH", MaDDH);
                        bdsDH.Position = ViTriDH;
                    }
                    else
                    {
                        String MaVT = "";
                        DataRowView currentRow = (DataRowView)bdsCTDDH.Current;
                        this.Validate();
                        MaVT = currentRow["MAVT"].ToString();
                        bdsCTDDH.EndEdit();
                        this.cTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.cTDDHTableAdapter.Update(this.DataSet.CTDDH);

                        MessageBox.Show("Cập nhật dữ liệu thành công!");

                        LamMoiBtn.PerformClick();

                        //ViTriCTDH = bdsCTDDH.Find("MAVT", MaVT);
                        //bdsCTDDH.Position = ViTriCTDH;
                        bool found = false;
                        for (int i = 0; i < bdsCTDDH.Count; i++)
                        {
                            DataRowView row = (DataRowView)bdsCTDDH[i];
                            if (row["MAVT"].ToString() == MaVT)
                            {
                                ViTriCTDH = i;
                                found = true;
                                break;
                            }
                        }

                        if (found)
                        {
                            bdsCTDDH.Position = ViTriCTDH;
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

        private void BoGhiBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BoGhiBtn.Enabled = false;
            this.cTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTDDHTableAdapter.Fill(this.DataSet.CTDDH);

            this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.datHangTableAdapter.Fill(this.DataSet.DatHang);

            this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuNhapTableAdapter.Fill(this.DataSet.PhieuNhap);

            if (CheDo)
            {
                this.DatHangGc.Enabled = true;
                this.DatHangGc.Focus();
            }
            else
            {
                this.CTDDHGc.Enabled = false;
                this.CTDDHGc.Focus();
            }

            ThemBtn.Enabled = true;
            XoaBtn.Enabled = true;
        }

        private void MaDDHCTTb_TextChanged(object sender, EventArgs e)
        {
            if(MaDDHTb.Text != null)
            {
                MaDDHCTTb.Text = MaDDHTb.Text;
            }
        }

        private void MaVTTb_TextChanged(object sender, EventArgs e)
        {
            if (MaVTTb != null)
            {
                int VitriMaVT = bdsVT.Find("MAVT", MaVTTb.Text);
                if (VitriMaVT != -1)
                {
                    DataRowView currentRow = (DataRowView)bdsVT[VitriMaVT];
                    TenVTTb.Text = (string)currentRow["TENVT"];
                    DvtTb.Text = (string)currentRow["DVT"];
                    SoLuongTonTb.Text = currentRow["SOLUONGTON"].ToString();
                }
            }
        }

        private void TextBoxClicked(object sender, EventArgs e)
        {
            BoGhiBtn.Enabled = true;
            if (CheDo)
            {
                ThemBtn.Enabled = false;
                XoaBtn.Enabled = false;
            }
            else
            {
                ThemBtn.Enabled = false;
                XoaBtn.Enabled = false;
            }
        }

        private void DatHangGc_Click(object sender, EventArgs e)
        {
            if ((DataRowView)bdsDH.Current != null)
                ViTriDH = bdsDH.Position;
        }

        private void CTDDHGc_Click(object sender, EventArgs e)
        {
            if ((DataRowView)bdsCTDDH.Current != null)
                ViTriCTDH = bdsCTDDH.Position;
        }
    }
}
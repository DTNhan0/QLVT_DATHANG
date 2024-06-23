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
    public partial class FormPhieuNhap : DevExpress.XtraEditors.XtraForm
    {
        int ViTriPN = -1;
        int ViTriCTPN = -1;
        bool CheDo;
        BindingSource bds = null;
        bool dangThemMoi = false;

        public FormPhieuNhap()
        {
            InitializeComponent();
        }

        private void FormPhieuNhap_Load(object sender, EventArgs e)
        {

            DataSet.EnforceConstraints = false;

            this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuNhapTableAdapter.Fill(this.DataSet.PhieuNhap);

            this.cTPNTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTPNTableAdapter.Fill(this.DataSet.CTPN);

            this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.datHangTableAdapter.Fill(this.DataSet.DatHang);

            this.cTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTDDHTableAdapter.Fill(this.DataSet.CTDDH);

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
                    PhieuNhapGc.Enabled = true;
                    CTPNGc.Enabled = true;
                    ApDungChoBsi.Enabled = false;
                    HoanTacBtn.Enabled = false;
                    setEnableOptions(false);
                    setEnableDetails(false);
                    ChonDHBtn.Enabled = false;
                    ChonCTDHBtn.Enabled = false;
                    break;
                //case "CHINHANH":
                //case "USER":
                //    setEnableOptions(true);
                //    break;
                default:
                    break;
            }
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
                this.NgayDE.Enabled = true;

                DonGiaTb.Enabled = true;
                SoLuongTb.Enabled = true;
            }
            else if (check == false)
            {
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
                this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
                this.phieuNhapTableAdapter.Fill(this.DataSet.PhieuNhap);

                this.cTPNTableAdapter.Connection.ConnectionString = Program.connstr;
                this.cTPNTableAdapter.Fill(this.DataSet.CTPN);

                this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
                this.datHangTableAdapter.Fill(this.DataSet.DatHang);

                this.cTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
                this.cTDDHTableAdapter.Fill(this.DataSet.CTDDH);
            }
        }

        private void PhieuNhapBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PhieuNhapGc.Enabled = true;
            PNGrpC.Enabled = true;
            CTPNGc.Enabled = false;
            CTPNGrpC.Enabled = false;
            CheDo = true;
            bds = bdsPN;
            ApDungChoBsi.Caption = "Phiếu nhập";
            setEnableOptions(true);
            setEnableDetails(true);
            CheckLoginPermission();
        }

        private void ChiTietPNBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PhieuNhapGc.Enabled = false;
            PNGrpC.Enabled = false;
            CTPNGc.Enabled = true;
            CTPNGrpC.Enabled = true;
            CheDo = false;
            bds = bdsCTPN;
            ApDungChoBsi.Caption = "Chi tiết phiếu nhập";
            setEnableOptions(true);
            setEnableDetails(true);
            CheckLoginPermission();
        }

        private bool CheckDataInput()
        {
            if (CheDo)
            {
                if (MaPNTb.Text == "")
                {
                    MessageBox.Show("Không bỏ trống mã phiếu nhập !", "Thông báo", MessageBoxButtons.OK);
                    MaPNTb.Focus();
                    return false;
                }

                if (MaNVTb.Text == "")
                {
                    MessageBox.Show("Không bỏ trống mã nhân viên !", "Thông báo", MessageBoxButtons.OK);
                    return false;
                }

                if (MaKhoTb.Text == "")
                {
                    MessageBox.Show("Không bỏ trống mã kho !", "Thông báo", MessageBoxButtons.OK);
                    return false;
                }

                if (MaSoDDHTb.Text == "")
                {
                    MessageBox.Show("Không bỏ trống mã đơn đặt hàng !", "Thông báo", MessageBoxButtons.OK);
                    return false;
                }
            }

            if (CheDo == false)
            {
                if (MaPNCTTb.Text == "")
                {
                    MessageBox.Show("Không bỏ trống mã phiếu nhập !", "Thông báo", MessageBoxButtons.OK);
                    MaPNCTTb.Focus();
                    return false;
                }

                if (MaVTTb.Text == "")
                {
                    MessageBox.Show("Không bỏ trống mã vật tư !", "Thông báo", MessageBoxButtons.OK);
                    return false;
                }
                if (DonGiaTb.Text == "")
                {
                    MessageBox.Show("Không thể bỏ trống đơn giá", "Thông báo", MessageBoxButtons.OK);
                    return false;
                }
                if (SoLuongTb.Text == "")
                {
                    MessageBox.Show("Không thể bỏ trống số lượng vật tư", "Thông báo", MessageBoxButtons.OK);
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

        private void ChonDHBtn_Click(object sender, EventArgs e)
        {
            FormChonDonHang form = new FormChonDonHang();
            form.ShowDialog();

            this.MaSoDDHTb.Text = Program.maDonDatHangDuocChon;
            this.MaKhoTb.Text = Program.maKhoDuocChon;
        }

        private void ChonCTDHBtn_Click(object sender, EventArgs e)
        {
            /*Lay MasoDDH hien tai cua gcPhieuNhap de so sanh voi MasoDDH se duoc chon*/
            Program.maDonDatHangDuocChon = ((DataRowView)(bdsPN.Current))["MasoDDH"].ToString().Trim();

            //Console.WriteLine(Program.maDonDatHangDuocChon);
            FormChonChiTietDonHang form = new FormChonChiTietDonHang();
            form.ShowDialog();

            this.MaVTTb.Text = Program.maVatTuDuocChon;
            this.SoLuongTb.Text = Program.soLuongVatTu.ToString();
            this.DonGiaTb.Text = Program.donGia.ToString();
        }

        private void LamMoiBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                MaPNTb.Enabled = false;
                setEnableDetails(true);
                setEnableOptions(true);
                CheckLoginPermission();
                this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
                this.phieuNhapTableAdapter.Update(this.DataSet.PhieuNhap);

                this.cTPNTableAdapter.Connection.ConnectionString = Program.connstr;
                this.cTPNTableAdapter.Update(this.DataSet.CTPN);


                this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
                this.datHangTableAdapter.Fill(this.DataSet.DatHang);

                this.cTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
                this.cTDDHTableAdapter.Fill(this.DataSet.CTDDH);

                this.phieuNhapTableAdapter.Fill(this.DataSet.PhieuNhap);
                this.cTPNTableAdapter.Fill(this.DataSet.CTPN);


                BoGhiBtn.Enabled = false;

                if (CheDo)
                {
                    PhieuNhapGc.Enabled = true;
                    CTPNGc.Enabled = false;
                }
                else
                {
                    PhieuNhapGc.Enabled = false;
                    CTPNGc.Enabled = true;
                }

                bdsPN.Position = ViTriPN;
                bdsCTPN.Position = ViTriCTPN;

                ChonDHBtn.Enabled = false;
                ChonCTDHBtn.Enabled = false;
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
            ChonDHBtn.Enabled = true;
            ChonCTDHBtn.Enabled = true;

            dangThemMoi = true;

            bds.AddNew();
            if (CheDo)
            {
                setEnableDetails(true);

                this.NgayDE.EditValue = DateTime.Now;
                this.MaNVTb.Text = Program.username;
                MaPNTb.Text = "";
                NgayDE.Text = "";
                MaKhoTb.Text = "";
                MaSoDDHTb.Text = "";
                MaPNTb.Enabled = true;

                ((DataRowView)(bdsPN.Current))["MANV"] = Program.username;
                ((DataRowView)(bdsPN.Current))["NGAY"] = DateTime.Now;
            }
            else
            {
                DataRowView drv = ((DataRowView)bdsPN[bdsPN.Position]);
                String maNhanVien = drv["MANV"].ToString();

                SoLuongTb.Text = "0";
                DonGiaTb.Text = "0";

                MaVTTb.Text = "";

                if (Program.username != maNhanVien)
                {
                    MessageBox.Show("Bạn không thêm chi tiết phiếu nhập không phải do mình tạo", "Thông báo", MessageBoxButtons.OK);
                    bdsCTPN.RemoveCurrent();
                    LamMoiBtn.PerformClick();
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
            DataRowView drv = ((DataRowView)bdsPN[bdsPN.Position]);
            String maNhanVien = drv["MANV"].ToString();
            if (Program.username != maNhanVien)
            {
                MessageBox.Show("Bạn không được xóa phiếu nhập không phải do mình tạo", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            try
            {
                if (CheDo)
                {
                    if (bdsCTPN.Count > 0)
                    {
                        MessageBox.Show("Không thể xóa phiếu nhập vì có chi tiết phiếu nhập", "Thông báo", MessageBoxButtons.OK);
                        return;
                    }
                    if (MessageBox.Show("Bạn có chắc chắn muốn xóa phiếu nhập có mã: " + MaPNTb.Text + " không?", "Thông báo",
                        MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        String Mapn = MaPNTb.Text;
                        bdsPN.RemoveCurrent();

                        this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.phieuNhapTableAdapter.Update(this.DataSet.PhieuNhap);

                        MessageBox.Show("Xóa dữ liệu thành công!");

                        String sql = "declare @result int\r\nexec @result = sp_KiemTraMaPhieuNhap '" + Mapn + "'\r\nselect @result";
                        while (true)
                        {
                            int reader = Program.ExecSqlScalar(sql);
                            Console.WriteLine(reader);
                            Console.WriteLine(MaPNTb.Text);
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
                    drv = ((DataRowView)bdsPN[bdsPN.Position]);
                    maNhanVien = drv["MANV"].ToString();
                    if (Program.username != maNhanVien)
                    {
                        MessageBox.Show("Bạn không xóa chi tiết phiếu nhập không phải do mình tạo", "Thông báo", MessageBoxButtons.OK);
                        return;
                    }

                    if (MessageBox.Show("Bạn có chắc chắn muốn xóa chi tiết phiếu nhập có mã: " + MaPNCTTb.Text + " không?", "Thông báo",
                            MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        bdsCTPN.RemoveCurrent();
                        MessageBox.Show("Xóa dữ liệu thành công!");

                        String sql = "declare @result int\r\nexec @result = sp_KiemTraChiTietPhieuNhap '" + MaPNCTTb.Text + "', " + "'" + MaVTTb.Text + "' " + "\r\nselect @result";
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

                        String sql = "declare @result int\r\nexec @result = sp_KiemTraMaPhieuNhap '" + MaPNTb.Text + "'\r\nselect @result";
                        int reader = Program.ExecSqlScalar(sql);

                        if (reader == 1)
                        {
                            MessageBox.Show("Mã phiếu nhập đã tồn tại, vui lòng nhập mã khác", "Thông báo", MessageBoxButtons.OK);
                            return;
                        }

                        String MaPN = "";

                        DataRowView currentRow = (DataRowView)bdsPN.Current;
                        bdsPN.EndEdit();

                        MaPN = currentRow["MAPN"].ToString();
                        this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.phieuNhapTableAdapter.Update(this.DataSet.PhieuNhap);

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

                        ViTriPN = bdsPN.Find("MAPN", MaPN);
                        bdsPN.Position = ViTriPN;
                        dangThemMoi = false;
                    }
                    else
                    {
                        if (CheckDataInput() == false)
                        {
                            return;
                        }

                        String sql = "declare @result int\r\nexec @result = sp_KiemTraChiTietPhieuNhap '" + MaPNCTTb.Text + "', " + "'" + MaVTTb.Text + "' " + "\r\nselect @result";
                        int reader = Program.ExecSqlScalar(sql);

                        if (reader == 1)
                        {
                            MessageBox.Show("Chi tiết phiếu nhập có mã vật tư đã tồn tại, vui lòng chọn vật tư khác", "Thông báo", MessageBoxButtons.OK);
                            return;
                        }

                        if (int.Parse(SoLuongTb.Text) > int.Parse(SoLuongDDHTb.Text))
                        {
                            MessageBox.Show("Không nhập quá số lượng đã đặt trên các vật tư trong đơn đặt", "Thông báo", MessageBoxButtons.OK);
                            return;
                        }

                        String MaVT = "";
                        DataRowView currentRow = (DataRowView)bdsCTPN.Current;
                        ((DataRowView)(bdsCTPN.Current))["MAPN"] = ((DataRowView)(bdsCTPN.Current))["MAPN"];
                        bdsCTPN.EndEdit();
                        bdsPN.EndEdit();

                        MaVT = currentRow["MAVT"].ToString();
                        this.cTPNTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.cTPNTableAdapter.Update(this.DataSet.CTPN);
                        this.phieuNhapTableAdapter.Update(this.DataSet.PhieuNhap);

                        MessageBox.Show("Thêm dữ liệu thành công!");
                        string maVatTu = MaVTTb.Text.Trim();
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
                        for (int i = 0; i < bdsCTPN.Count; i++)
                        {
                            DataRowView row = (DataRowView)bdsCTPN[i];
                            if (row["MAVT"].ToString() == MaVT)
                            {
                                ViTriCTPN = i;
                                found = true;
                                break;
                            }
                        }

                        if (found)
                        {
                            bdsCTPN.Position = ViTriCTPN;
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
                DataRowView drv = ((DataRowView)bdsPN[bdsPN.Position]);
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
                        String MaPN = "";
                        DataRowView currentRow = (DataRowView)bdsPN.Current;
                        this.Validate();
                        MaPN = (string)currentRow["MAPN"];
                        bdsPN.EndEdit();
                        this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.phieuNhapTableAdapter.Update(this.DataSet.PhieuNhap);

                        MessageBox.Show("Cập nhật dữ liệu thành công!");

                        LamMoiBtn.PerformClick();

                        ViTriPN = bdsCTPN.Find("MAPN", MaPN);
                        bdsPN.Position = ViTriPN;
                    }
                    else
                    {
                        if (int.Parse(SoLuongTb.Text) > int.Parse(SoLuongDDHTb.Text))
                        {
                            MessageBox.Show("Không nhập quá số lượng đã đặt trên các vật tư trong đơn đặt", "Thông báo", MessageBoxButtons.OK);
                            return;
                        }

                        String MaVT = "";
                        DataRowView currentRow = (DataRowView)bdsCTPN.Current;
                        this.Validate();
                        MaVT = currentRow["MAVT"].ToString();
                        bdsCTPN.EndEdit();
                        this.cTPNTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.cTPNTableAdapter.Update(this.DataSet.CTPN);

                        MessageBox.Show("Cập nhật dữ liệu thành công!");

                        LamMoiBtn.PerformClick();

                        //ViTriCTDH = bdsCTDDH.Find("MAVT", MaVT);
                        //bdsCTDDH.Position = ViTriCTDH;
                        bool found = false;
                        for (int i = 0; i < bdsCTPN.Count; i++)
                        {
                            DataRowView row = (DataRowView)bdsCTPN[i];
                            if (row["MAVT"].ToString() == MaVT)
                            {
                                ViTriCTPN = i;
                                found = true;
                                break;
                            }
                        }

                        if (found)
                        {
                            bdsCTPN.Position = ViTriCTPN;
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

        private void MaPNCTTb_TextChanged(object sender, EventArgs e)
        {
            if (MaPNTb != null)
            {
                MaPNCTTb.Text = MaPNTb.Text;
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
                PhieuNhapGc.Enabled = false;
            }
            else
            {
                ThemBtn.Enabled = false;
                XoaBtn.Enabled = false;
                CTPNGc.Enabled = false;
            }
        }

        private void PhieuNhapGc_Click(object sender, EventArgs e)
        {
            if ((DataRowView)bdsPN.Current != null)
                ViTriPN = bdsPN.Position;
        }

        private void CTPNGc_Click(object sender, EventArgs e)
        {
            if ((DataRowView)bdsCTPN.Current != null)
                ViTriCTPN = bdsCTPN.Position;
        }

        private void MaSoDDHTb_TextChanged(object sender, EventArgs e)
        {
            if (MaSoDDHTb != null)
            {
                int VitriMaCTDDH = bdsCTDDH.Find("MasoDDH", MaSoDDHTb.Text);
                if (VitriMaCTDDH != -1)
                {
                    DataRowView currentRow = (DataRowView)bdsCTDDH[VitriMaCTDDH];
                    MaSoDDHCTTb.Text = (string)currentRow["MasoDDH"];
                    MaVTDDHTb.Text = (string)currentRow["MAVT"];
                    SoLuongDDHTb.Text = currentRow["SOLUONG"].ToString();
                    DonGiaTb.Text = currentRow["DONGIA"].ToString();
                }
            }
        }
    }
}
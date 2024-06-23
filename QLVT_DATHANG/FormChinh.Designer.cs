using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraTabbedMdi;
using System.Windows.Forms;

namespace QLVT_DATHANG
{
    partial class FormChinh
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChinh));
            this.repositoryItemHypertextLabel2 = new DevExpress.XtraEditors.Repository.RepositoryItemHypertextLabel();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.DangNhapBtn = new DevExpress.XtraBars.BarButtonItem();
            this.TaoTKBtn = new DevExpress.XtraBars.BarButtonItem();
            this.DangXuatBtn = new DevExpress.XtraBars.BarButtonItem();
            this.NhanVienBtn = new DevExpress.XtraBars.BarButtonItem();
            this.VatTuBtn = new DevExpress.XtraBars.BarButtonItem();
            this.KhoHangBtn = new DevExpress.XtraBars.BarButtonItem();
            this.LapPhieuBsi = new DevExpress.XtraBars.BarSubItem();
            this.DonDatBtn = new DevExpress.XtraBars.BarButtonItem();
            this.PhieuNhapBtn = new DevExpress.XtraBars.BarButtonItem();
            this.PhieuXuatBtn = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.ThoatBtn = new DevExpress.XtraBars.BarButtonItem();
            this.DanhSachNhanVienBtn = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.DanhSachVatTuBtn = new DevExpress.XtraBars.BarButtonItem();
            this.ChiTietNhapXuatBtn = new DevExpress.XtraBars.BarButtonItem();
            this.DHKoPNBtn = new DevExpress.XtraBars.BarButtonItem();
            this.HoatDongNhanVienBtn = new DevExpress.XtraBars.BarButtonItem();
            this.TongHopNXBtn = new DevExpress.XtraBars.BarButtonItem();
            this.PageHeThong = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.DangNhapRbGrp = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.TaoTKRbGrp = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.DangXuatRbGrp = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ThoatRbGrp = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.PageNhapXuat = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.NhanVienRbGrp = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.VatTuRbGrp = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.KhoHangRbGrp = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.LapPhieuRbGrp = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.PageBaoCao = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.BaoCaoGrp = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.MaNVSsl = new System.Windows.Forms.ToolStripStatusLabel();
            this.HoTenSsl = new System.Windows.Forms.ToolStripStatusLabel();
            this.NhomSsl = new System.Windows.Forms.ToolStripStatusLabel();
            this.xtraTabbedMdiManager = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHypertextLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            this.SuspendLayout();
            // 
            // repositoryItemHypertextLabel2
            // 
            this.repositoryItemHypertextLabel2.Name = "repositoryItemHypertextLabel2";
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.DangNhapBtn,
            this.TaoTKBtn,
            this.DangXuatBtn,
            this.NhanVienBtn,
            this.VatTuBtn,
            this.KhoHangBtn,
            this.LapPhieuBsi,
            this.DonDatBtn,
            this.PhieuNhapBtn,
            this.PhieuXuatBtn,
            this.barButtonItem1,
            this.ThoatBtn,
            this.DanhSachNhanVienBtn,
            this.barButtonItem3,
            this.DanhSachVatTuBtn,
            this.ChiTietNhapXuatBtn,
            this.DHKoPNBtn,
            this.HoatDongNhanVienBtn,
            this.TongHopNXBtn});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 24;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.PageHeThong,
            this.PageNhapXuat,
            this.PageBaoCao});
            this.ribbon.Size = new System.Drawing.Size(1181, 158);
            // 
            // DangNhapBtn
            // 
            this.DangNhapBtn.Caption = "ĐĂNG NHẬP";
            this.DangNhapBtn.Id = 1;
            this.DangNhapBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("DangNhapBtn.ImageOptions.Image")));
            this.DangNhapBtn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("DangNhapBtn.ImageOptions.LargeImage")));
            this.DangNhapBtn.Name = "DangNhapBtn";
            this.DangNhapBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.DangNhapBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.DangNhapBtn_ItemClick);
            // 
            // TaoTKBtn
            // 
            this.TaoTKBtn.Caption = "TẠO TÀI KHOẢN";
            this.TaoTKBtn.Id = 2;
            this.TaoTKBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("TaoTKBtn.ImageOptions.Image")));
            this.TaoTKBtn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("TaoTKBtn.ImageOptions.LargeImage")));
            this.TaoTKBtn.Name = "TaoTKBtn";
            this.TaoTKBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // DangXuatBtn
            // 
            this.DangXuatBtn.Caption = "ĐĂNG XUẤT";
            this.DangXuatBtn.Id = 3;
            this.DangXuatBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("DangXuatBtn.ImageOptions.Image")));
            this.DangXuatBtn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("DangXuatBtn.ImageOptions.LargeImage")));
            this.DangXuatBtn.Name = "DangXuatBtn";
            this.DangXuatBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.DangXuatBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.DangXuatBtn_ItemClick);
            // 
            // NhanVienBtn
            // 
            this.NhanVienBtn.Caption = "NHÂN VIÊN";
            this.NhanVienBtn.Id = 5;
            this.NhanVienBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("NhanVienBtn.ImageOptions.Image")));
            this.NhanVienBtn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("NhanVienBtn.ImageOptions.LargeImage")));
            this.NhanVienBtn.Name = "NhanVienBtn";
            this.NhanVienBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.NhanVienBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.NhanVienBtn_ItemClick);
            // 
            // VatTuBtn
            // 
            this.VatTuBtn.Caption = "VẬT TƯ";
            this.VatTuBtn.Id = 6;
            this.VatTuBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("VatTuBtn.ImageOptions.Image")));
            this.VatTuBtn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("VatTuBtn.ImageOptions.LargeImage")));
            this.VatTuBtn.Name = "VatTuBtn";
            this.VatTuBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.VatTuBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.VatTuBtn_ItemClick);
            // 
            // KhoHangBtn
            // 
            this.KhoHangBtn.Caption = "KHO HÀNG";
            this.KhoHangBtn.Id = 7;
            this.KhoHangBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("KhoHangBtn.ImageOptions.Image")));
            this.KhoHangBtn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("KhoHangBtn.ImageOptions.LargeImage")));
            this.KhoHangBtn.Name = "KhoHangBtn";
            this.KhoHangBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.KhoHangBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.KhoHangBtn_ItemClick);
            // 
            // LapPhieuBsi
            // 
            this.LapPhieuBsi.Caption = "LẬP PHIẾU";
            this.LapPhieuBsi.Id = 10;
            this.LapPhieuBsi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("LapPhieuBsi.ImageOptions.Image")));
            this.LapPhieuBsi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("LapPhieuBsi.ImageOptions.LargeImage")));
            this.LapPhieuBsi.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.DonDatBtn, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.PhieuNhapBtn, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.PhieuXuatBtn, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.LapPhieuBsi.Name = "LapPhieuBsi";
            this.LapPhieuBsi.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // DonDatBtn
            // 
            this.DonDatBtn.Caption = "Đơn đặt";
            this.DonDatBtn.Id = 11;
            this.DonDatBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("DonDatBtn.ImageOptions.Image")));
            this.DonDatBtn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("DonDatBtn.ImageOptions.LargeImage")));
            this.DonDatBtn.Name = "DonDatBtn";
            this.DonDatBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.DonDatBtn_ItemClick);
            // 
            // PhieuNhapBtn
            // 
            this.PhieuNhapBtn.Caption = "Phiếu nhập";
            this.PhieuNhapBtn.Id = 12;
            this.PhieuNhapBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("PhieuNhapBtn.ImageOptions.Image")));
            this.PhieuNhapBtn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("PhieuNhapBtn.ImageOptions.LargeImage")));
            this.PhieuNhapBtn.Name = "PhieuNhapBtn";
            this.PhieuNhapBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.PhieuNhapBtn_ItemClick);
            // 
            // PhieuXuatBtn
            // 
            this.PhieuXuatBtn.Caption = "Phiếu xuất";
            this.PhieuXuatBtn.Id = 13;
            this.PhieuXuatBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("PhieuXuatBtn.ImageOptions.Image")));
            this.PhieuXuatBtn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("PhieuXuatBtn.ImageOptions.LargeImage")));
            this.PhieuXuatBtn.Name = "PhieuXuatBtn";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 14;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // ThoatBtn
            // 
            this.ThoatBtn.Caption = "THOÁT";
            this.ThoatBtn.Id = 15;
            this.ThoatBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ThoatBtn.ImageOptions.Image")));
            this.ThoatBtn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("ThoatBtn.ImageOptions.LargeImage")));
            this.ThoatBtn.Name = "ThoatBtn";
            this.ThoatBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.ThoatBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ThoatBtn_ItemClick);
            // 
            // DanhSachNhanVienBtn
            // 
            this.DanhSachNhanVienBtn.Caption = "Danh sách nhân viên";
            this.DanhSachNhanVienBtn.Id = 16;
            this.DanhSachNhanVienBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("DanhSachNhanVienBtn.ImageOptions.Image")));
            this.DanhSachNhanVienBtn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("DanhSachNhanVienBtn.ImageOptions.LargeImage")));
            this.DanhSachNhanVienBtn.LargeWidth = 150;
            this.DanhSachNhanVienBtn.Name = "DanhSachNhanVienBtn";
            this.DanhSachNhanVienBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.DanhSachNhanVienBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.DanhSachNhanVienBtn_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "barButtonItem3";
            this.barButtonItem3.Id = 17;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // DanhSachVatTuBtn
            // 
            this.DanhSachVatTuBtn.Caption = "Danh sách vật tư";
            this.DanhSachVatTuBtn.Id = 19;
            this.DanhSachVatTuBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("DanhSachVatTuBtn.ImageOptions.Image")));
            this.DanhSachVatTuBtn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("DanhSachVatTuBtn.ImageOptions.LargeImage")));
            this.DanhSachVatTuBtn.LargeWidth = 150;
            this.DanhSachVatTuBtn.Name = "DanhSachVatTuBtn";
            this.DanhSachVatTuBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.DanhSachVatTuBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.DanhSachVatTuBtn_ItemClick);
            // 
            // ChiTietNhapXuatBtn
            // 
            this.ChiTietNhapXuatBtn.Caption = "Chi tiết nhập xuất";
            this.ChiTietNhapXuatBtn.Id = 20;
            this.ChiTietNhapXuatBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ChiTietNhapXuatBtn.ImageOptions.Image")));
            this.ChiTietNhapXuatBtn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("ChiTietNhapXuatBtn.ImageOptions.LargeImage")));
            this.ChiTietNhapXuatBtn.LargeWidth = 150;
            this.ChiTietNhapXuatBtn.Name = "ChiTietNhapXuatBtn";
            this.ChiTietNhapXuatBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.ChiTietNhapXuatBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ChiTietNhapXuatBtn_ItemClick);
            // 
            // DHKoPNBtn
            // 
            this.DHKoPNBtn.Caption = "Đơn hàng không phiếu nhập";
            this.DHKoPNBtn.Id = 21;
            this.DHKoPNBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("DHKoPNBtn.ImageOptions.Image")));
            this.DHKoPNBtn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("DHKoPNBtn.ImageOptions.LargeImage")));
            this.DHKoPNBtn.LargeWidth = 150;
            this.DHKoPNBtn.Name = "DHKoPNBtn";
            this.DHKoPNBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.DHKoPNBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.DHKoPNBtn_ItemClick);
            // 
            // HoatDongNhanVienBtn
            // 
            this.HoatDongNhanVienBtn.Caption = "Hoạt động nhân viên";
            this.HoatDongNhanVienBtn.Id = 22;
            this.HoatDongNhanVienBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("HoatDongNhanVienBtn.ImageOptions.Image")));
            this.HoatDongNhanVienBtn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("HoatDongNhanVienBtn.ImageOptions.LargeImage")));
            this.HoatDongNhanVienBtn.LargeWidth = 150;
            this.HoatDongNhanVienBtn.Name = "HoatDongNhanVienBtn";
            this.HoatDongNhanVienBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.HoatDongNhanVienBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.HoatDongNhanVienBtn_ItemClick);
            // 
            // TongHopNXBtn
            // 
            this.TongHopNXBtn.Caption = "Tổng hợp nhập xuất";
            this.TongHopNXBtn.Id = 23;
            this.TongHopNXBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("TongHopNXBtn.ImageOptions.Image")));
            this.TongHopNXBtn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("TongHopNXBtn.ImageOptions.LargeImage")));
            this.TongHopNXBtn.LargeWidth = 150;
            this.TongHopNXBtn.Name = "TongHopNXBtn";
            this.TongHopNXBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.TongHopNXBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.TongHopNXBtn_ItemClick);
            // 
            // PageHeThong
            // 
            this.PageHeThong.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.DangNhapRbGrp,
            this.TaoTKRbGrp,
            this.DangXuatRbGrp,
            this.ThoatRbGrp});
            this.PageHeThong.Name = "PageHeThong";
            this.PageHeThong.Text = "HỆ THỐNG";
            // 
            // DangNhapRbGrp
            // 
            this.DangNhapRbGrp.AllowTextClipping = false;
            this.DangNhapRbGrp.ItemLinks.Add(this.DangNhapBtn);
            this.DangNhapRbGrp.Name = "DangNhapRbGrp";
            this.DangNhapRbGrp.Text = "---Đăng nhập---";
            // 
            // TaoTKRbGrp
            // 
            this.TaoTKRbGrp.AllowTextClipping = false;
            this.TaoTKRbGrp.ItemLinks.Add(this.TaoTKBtn);
            this.TaoTKRbGrp.Name = "TaoTKRbGrp";
            this.TaoTKRbGrp.Text = "---Tạo tài khoản---";
            // 
            // DangXuatRbGrp
            // 
            this.DangXuatRbGrp.AllowTextClipping = false;
            this.DangXuatRbGrp.ItemLinks.Add(this.DangXuatBtn);
            this.DangXuatRbGrp.Name = "DangXuatRbGrp";
            this.DangXuatRbGrp.Text = "---Đăng xuất---";
            // 
            // ThoatRbGrp
            // 
            this.ThoatRbGrp.AllowTextClipping = false;
            this.ThoatRbGrp.ItemLinks.Add(this.ThoatBtn);
            this.ThoatRbGrp.Name = "ThoatRbGrp";
            this.ThoatRbGrp.Text = "---Thoát---";
            // 
            // PageNhapXuat
            // 
            this.PageNhapXuat.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.NhanVienRbGrp,
            this.VatTuRbGrp,
            this.KhoHangRbGrp,
            this.LapPhieuRbGrp});
            this.PageNhapXuat.Name = "PageNhapXuat";
            this.PageNhapXuat.Text = "NHẬP XUẤT";
            // 
            // NhanVienRbGrp
            // 
            this.NhanVienRbGrp.AllowTextClipping = false;
            this.NhanVienRbGrp.ItemLinks.Add(this.NhanVienBtn);
            this.NhanVienRbGrp.Name = "NhanVienRbGrp";
            this.NhanVienRbGrp.Text = "---Nhân viên---";
            // 
            // VatTuRbGrp
            // 
            this.VatTuRbGrp.AllowTextClipping = false;
            this.VatTuRbGrp.ItemLinks.Add(this.VatTuBtn);
            this.VatTuRbGrp.Name = "VatTuRbGrp";
            this.VatTuRbGrp.Text = "---Vật tư---";
            // 
            // KhoHangRbGrp
            // 
            this.KhoHangRbGrp.AllowTextClipping = false;
            this.KhoHangRbGrp.ItemLinks.Add(this.KhoHangBtn);
            this.KhoHangRbGrp.Name = "KhoHangRbGrp";
            this.KhoHangRbGrp.Text = "---Kho hàng---";
            // 
            // LapPhieuRbGrp
            // 
            this.LapPhieuRbGrp.AllowTextClipping = false;
            this.LapPhieuRbGrp.ItemLinks.Add(this.LapPhieuBsi);
            this.LapPhieuRbGrp.Name = "LapPhieuRbGrp";
            this.LapPhieuRbGrp.Text = "---Lập phiếu---";
            // 
            // PageBaoCao
            // 
            this.PageBaoCao.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.BaoCaoGrp});
            this.PageBaoCao.Name = "PageBaoCao";
            this.PageBaoCao.Text = "BÁO CÁO";
            // 
            // BaoCaoGrp
            // 
            this.BaoCaoGrp.ItemLinks.Add(this.DanhSachNhanVienBtn);
            this.BaoCaoGrp.ItemLinks.Add(this.DanhSachVatTuBtn);
            this.BaoCaoGrp.ItemLinks.Add(this.ChiTietNhapXuatBtn);
            this.BaoCaoGrp.ItemLinks.Add(this.DHKoPNBtn);
            this.BaoCaoGrp.ItemLinks.Add(this.HoatDongNhanVienBtn);
            this.BaoCaoGrp.ItemLinks.Add(this.TongHopNXBtn);
            this.BaoCaoGrp.Name = "BaoCaoGrp";
            this.BaoCaoGrp.Text = "---Báo cáo---";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MaNVSsl,
            this.HoTenSsl,
            this.NhomSsl});
            this.statusStrip1.Location = new System.Drawing.Point(0, 489);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1181, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // MaNVSsl
            // 
            this.MaNVSsl.Name = "MaNVSsl";
            this.MaNVSsl.Size = new System.Drawing.Size(45, 17);
            this.MaNVSsl.Text = "MANV:";
            // 
            // HoTenSsl
            // 
            this.HoTenSsl.Name = "HoTenSsl";
            this.HoTenSsl.Size = new System.Drawing.Size(48, 17);
            this.HoTenSsl.Text = "HOTEN:";
            // 
            // NhomSsl
            // 
            this.NhomSsl.Name = "NhomSsl";
            this.NhomSsl.Size = new System.Drawing.Size(48, 17);
            this.NhomSsl.Text = "NHOM:";
            // 
            // xtraTabbedMdiManager
            // 
            this.xtraTabbedMdiManager.MdiParent = this;
            // 
            // barEditItem1
            // 
            this.barEditItem1.Caption = "barEditItem1";
            this.barEditItem1.Edit = this.repositoryItemHypertextLabel2;
            this.barEditItem1.Id = 4;
            this.barEditItem1.Name = "barEditItem1";
            // 
            // popupMenu1
            // 
            this.popupMenu1.Name = "popupMenu1";
            this.popupMenu1.Ribbon = this.ribbon;
            // 
            // FormChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 511);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Name = "FormChinh";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ VẬT TƯ - ĐẶT HÀNG";
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHypertextLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage PageHeThong;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup DangNhapRbGrp;
        private DevExpress.XtraBars.Ribbon.RibbonPage PageBaoCao;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup BaoCaoGrp;
        private DevExpress.XtraBars.Ribbon.RibbonPage PageNhapXuat;
        private DevExpress.XtraBars.BarButtonItem DangNhapBtn;
        private DevExpress.XtraBars.BarButtonItem TaoTKBtn;
        private DevExpress.XtraBars.BarButtonItem DangXuatBtn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel MaNVSsl;
        private System.Windows.Forms.ToolStripStatusLabel HoTenSsl;
        private System.Windows.Forms.ToolStripStatusLabel NhomSsl;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager;
        private DevExpress.XtraEditors.Repository.RepositoryItemHypertextLabel repositoryItemHypertextLabel2;
        private DevExpress.XtraBars.BarEditItem barEditItem1;
        private BarButtonItem NhanVienBtn;
        private BarButtonItem VatTuBtn;
        private BarButtonItem KhoHangBtn;
        private RibbonPageGroup NhanVienRbGrp;
        private RibbonPageGroup TaoTKRbGrp;
        private RibbonPageGroup DangXuatRbGrp;
        private RibbonPageGroup VatTuRbGrp;
        private RibbonPageGroup KhoHangRbGrp;
        private RibbonPageGroup LapPhieuRbGrp;
        private PopupMenu popupMenu1;
        private BarSubItem LapPhieuBsi;
        private BarButtonItem DonDatBtn;
        private BarButtonItem PhieuNhapBtn;
        private BarButtonItem PhieuXuatBtn;
        private BarButtonItem barButtonItem1;
        private RibbonPageGroup ThoatRbGrp;
        private BarButtonItem ThoatBtn;
        private BarButtonItem DanhSachNhanVienBtn;
        private BarButtonItem barButtonItem3;
        private BarButtonItem DanhSachVatTuBtn;
        private BarButtonItem ChiTietNhapXuatBtn;
        private BarButtonItem DHKoPNBtn;
        private BarButtonItem HoatDongNhanVienBtn;
        private BarButtonItem TongHopNXBtn;

        public RibbonPage pageHeThong { get => PageHeThong; set => PageHeThong = value; }
        public RibbonPage pageBaoCao { get => PageBaoCao; set => PageBaoCao = value; }
        public RibbonPage pageNhapXuat { get => PageNhapXuat; set => PageNhapXuat = value; }
        public BarButtonItem dangNhapBtn { get => DangNhapBtn; set => DangNhapBtn = value; }
        public BarButtonItem dangXuatBtn { get => DangXuatBtn; set => DangXuatBtn = value; }
        public ToolStripStatusLabel maNVSsl { get => MaNVSsl; set => MaNVSsl = value; }
        public ToolStripStatusLabel hoTenSsl { get => HoTenSsl; set => HoTenSsl = value; }
        public ToolStripStatusLabel nhomSsl { get => NhomSsl; set => NhomSsl = value; }
    }
}
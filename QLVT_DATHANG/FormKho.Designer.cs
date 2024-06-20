namespace QLVT_DATHANG
{
    partial class FormKho
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
            System.Windows.Forms.Label mAKHOLabel;
            System.Windows.Forms.Label tENKHOLabel;
            System.Windows.Forms.Label dIACHILabel;
            System.Windows.Forms.Label mACNLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKho));
            this.BarManager = new DevExpress.XtraBars.BarManager(this.components);
            this.Bar = new DevExpress.XtraBars.Bar();
            this.ThemBtn = new DevExpress.XtraBars.BarButtonItem();
            this.XoaBtn = new DevExpress.XtraBars.BarButtonItem();
            this.GhiBtn = new DevExpress.XtraBars.BarButtonItem();
            this.BoGhiBtn = new DevExpress.XtraBars.BarButtonItem();
            this.HoanTacBtn = new DevExpress.XtraBars.BarButtonItem();
            this.LamMoiBtn = new DevExpress.XtraBars.BarButtonItem();
            this.ThoatBtn = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.ChuyenCNBtn = new DevExpress.XtraBars.BarButtonItem();
            this.barHeaderItem1 = new DevExpress.XtraBars.BarHeaderItem();
            this.barMdiChildrenListItem1 = new DevExpress.XtraBars.BarMdiChildrenListItem();
            this.skinBarSubItem1 = new DevExpress.XtraBars.SkinBarSubItem();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.panelChiNhanh = new DevExpress.XtraEditors.PanelControl();
            this.ChiNhanhCb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DataSet = new QLVT_DATHANG.DataSet();
            this.bdsKho = new System.Windows.Forms.BindingSource(this.components);
            this.khoTableAdapter = new QLVT_DATHANG.DataSetTableAdapters.KhoTableAdapter();
            this.tableAdapterManager = new QLVT_DATHANG.DataSetTableAdapters.TableAdapterManager();
            this.datHangTableAdapter = new QLVT_DATHANG.DataSetTableAdapters.DatHangTableAdapter();
            this.phieuNhapTableAdapter = new QLVT_DATHANG.DataSetTableAdapters.PhieuNhapTableAdapter();
            this.phieuXuatTableAdapter = new QLVT_DATHANG.DataSetTableAdapters.PhieuXuatTableAdapter();
            this.KhoGc = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAKHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENKHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bdsPX = new System.Windows.Forms.BindingSource(this.components);
            this.bdsPN = new System.Windows.Forms.BindingSource(this.components);
            this.bdsDH = new System.Windows.Forms.BindingSource(this.components);
            this.panelNhapXuat = new DevExpress.XtraEditors.PanelControl();
            this.MaCNTb = new System.Windows.Forms.TextBox();
            this.DiaChiTb = new System.Windows.Forms.TextBox();
            this.TenKhoTb = new System.Windows.Forms.TextBox();
            this.MaKhoTb = new System.Windows.Forms.TextBox();
            mAKHOLabel = new System.Windows.Forms.Label();
            tENKHOLabel = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            mACNLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelChiNhanh)).BeginInit();
            this.panelChiNhanh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KhoGc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelNhapXuat)).BeginInit();
            this.panelNhapXuat.SuspendLayout();
            this.SuspendLayout();
            // 
            // mAKHOLabel
            // 
            mAKHOLabel.AutoSize = true;
            mAKHOLabel.Location = new System.Drawing.Point(75, 31);
            mAKHOLabel.Name = "mAKHOLabel";
            mAKHOLabel.Size = new System.Drawing.Size(47, 13);
            mAKHOLabel.TabIndex = 0;
            mAKHOLabel.Text = "MAKHO:";
            // 
            // tENKHOLabel
            // 
            tENKHOLabel.AutoSize = true;
            tENKHOLabel.Location = new System.Drawing.Point(71, 91);
            tENKHOLabel.Name = "tENKHOLabel";
            tENKHOLabel.Size = new System.Drawing.Size(51, 13);
            tENKHOLabel.TabIndex = 2;
            tENKHOLabel.Text = "TENKHO:";
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Location = new System.Drawing.Point(340, 31);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(47, 13);
            dIACHILabel.TabIndex = 4;
            dIACHILabel.Text = "DIACHI:";
            // 
            // mACNLabel
            // 
            mACNLabel.AutoSize = true;
            mACNLabel.Location = new System.Drawing.Point(347, 91);
            mACNLabel.Name = "mACNLabel";
            mACNLabel.Size = new System.Drawing.Size(40, 13);
            mACNLabel.TabIndex = 6;
            mACNLabel.Text = "MACN:";
            // 
            // BarManager
            // 
            this.BarManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.Bar,
            this.bar3});
            this.BarManager.DockControls.Add(this.barDockControlTop);
            this.BarManager.DockControls.Add(this.barDockControlBottom);
            this.BarManager.DockControls.Add(this.barDockControlLeft);
            this.BarManager.DockControls.Add(this.barDockControlRight);
            this.BarManager.Form = this;
            this.BarManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ThemBtn,
            this.XoaBtn,
            this.GhiBtn,
            this.HoanTacBtn,
            this.LamMoiBtn,
            this.ChuyenCNBtn,
            this.ThoatBtn,
            this.barHeaderItem1,
            this.barMdiChildrenListItem1,
            this.skinBarSubItem1,
            this.barSubItem1,
            this.barButtonItem1,
            this.BoGhiBtn,
            this.barButtonItem2});
            this.BarManager.MaxItemId = 14;
            this.BarManager.StatusBar = this.bar3;
            // 
            // Bar
            // 
            this.Bar.BarName = "Tools";
            this.Bar.DockCol = 0;
            this.Bar.DockRow = 0;
            this.Bar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.Bar.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.ThemBtn, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.XoaBtn, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.GhiBtn, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.BoGhiBtn, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.HoanTacBtn, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.LamMoiBtn, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.ThoatBtn, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.Bar.OptionsBar.AllowQuickCustomization = false;
            this.Bar.Text = "Tools";
            // 
            // ThemBtn
            // 
            this.ThemBtn.Caption = "Thêm";
            this.ThemBtn.Id = 0;
            this.ThemBtn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ThemBtn.ImageOptions.SvgImage")));
            this.ThemBtn.Name = "ThemBtn";
            this.ThemBtn.Size = new System.Drawing.Size(90, 0);
            this.ThemBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ThemBtn_ItemClick);
            // 
            // XoaBtn
            // 
            this.XoaBtn.Caption = "Xóa";
            this.XoaBtn.Id = 1;
            this.XoaBtn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("XoaBtn.ImageOptions.SvgImage")));
            this.XoaBtn.Name = "XoaBtn";
            this.XoaBtn.Size = new System.Drawing.Size(90, 0);
            this.XoaBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.XoaBtn_ItemClick);
            // 
            // GhiBtn
            // 
            this.GhiBtn.Caption = "Ghi";
            this.GhiBtn.Id = 2;
            this.GhiBtn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("GhiBtn.ImageOptions.SvgImage")));
            this.GhiBtn.Name = "GhiBtn";
            this.GhiBtn.Size = new System.Drawing.Size(90, 0);
            this.GhiBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.GhiBtn_ItemClick);
            // 
            // BoGhiBtn
            // 
            this.BoGhiBtn.Caption = "Bỏ ghi";
            this.BoGhiBtn.Id = 12;
            this.BoGhiBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BoGhiBtn.ImageOptions.Image")));
            this.BoGhiBtn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BoGhiBtn.ImageOptions.LargeImage")));
            this.BoGhiBtn.Name = "BoGhiBtn";
            this.BoGhiBtn.Size = new System.Drawing.Size(95, 0);
            this.BoGhiBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BoGhiBtn_ItemClick);
            // 
            // HoanTacBtn
            // 
            this.HoanTacBtn.Caption = "Hoàn tác";
            this.HoanTacBtn.Id = 3;
            this.HoanTacBtn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("HoanTacBtn.ImageOptions.SvgImage")));
            this.HoanTacBtn.Name = "HoanTacBtn";
            this.HoanTacBtn.Size = new System.Drawing.Size(105, 0);
            this.HoanTacBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.HoanTacBtn_ItemClick);
            // 
            // LamMoiBtn
            // 
            this.LamMoiBtn.Caption = "Làm mới";
            this.LamMoiBtn.Id = 4;
            this.LamMoiBtn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("LamMoiBtn.ImageOptions.SvgImage")));
            this.LamMoiBtn.Name = "LamMoiBtn";
            this.LamMoiBtn.Size = new System.Drawing.Size(105, 0);
            this.LamMoiBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.LamMoiBtn_ItemClick);
            // 
            // ThoatBtn
            // 
            this.ThoatBtn.Caption = "Thoát";
            this.ThoatBtn.Id = 6;
            this.ThoatBtn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ThoatBtn.ImageOptions.SvgImage")));
            this.ThoatBtn.Name = "ThoatBtn";
            this.ThoatBtn.Size = new System.Drawing.Size(90, 0);
            this.ThoatBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ThoatBtn_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.Appearance.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.barDockControlTop.Appearance.Options.UseFont = true;
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.BarManager;
            this.barDockControlTop.Size = new System.Drawing.Size(1256, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 520);
            this.barDockControlBottom.Manager = this.BarManager;
            this.barDockControlBottom.Size = new System.Drawing.Size(1256, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.BarManager;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 496);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1256, 24);
            this.barDockControlRight.Manager = this.BarManager;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 496);
            // 
            // ChuyenCNBtn
            // 
            this.ChuyenCNBtn.Caption = "Chuyển chi nhánh";
            this.ChuyenCNBtn.Id = 5;
            this.ChuyenCNBtn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ChuyenCNBtn.ImageOptions.SvgImage")));
            this.ChuyenCNBtn.Name = "ChuyenCNBtn";
            this.ChuyenCNBtn.Size = new System.Drawing.Size(150, 0);
            // 
            // barHeaderItem1
            // 
            this.barHeaderItem1.Caption = "barHeaderItem1";
            this.barHeaderItem1.Id = 7;
            this.barHeaderItem1.Name = "barHeaderItem1";
            // 
            // barMdiChildrenListItem1
            // 
            this.barMdiChildrenListItem1.Caption = "barMdiChildrenListItem1";
            this.barMdiChildrenListItem1.Id = 8;
            this.barMdiChildrenListItem1.Name = "barMdiChildrenListItem1";
            // 
            // skinBarSubItem1
            // 
            this.skinBarSubItem1.Caption = "skinBarSubItem1";
            this.skinBarSubItem1.Id = 9;
            this.skinBarSubItem1.Name = "skinBarSubItem1";
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "barSubItem1";
            this.barSubItem1.Id = 10;
            this.barSubItem1.Name = "barSubItem1";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Test";
            this.barButtonItem1.Id = 11;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "CheckDataStack";
            this.barButtonItem2.Id = 13;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // panelChiNhanh
            // 
            this.panelChiNhanh.Controls.Add(this.ChiNhanhCb);
            this.panelChiNhanh.Controls.Add(this.label1);
            this.panelChiNhanh.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelChiNhanh.Location = new System.Drawing.Point(0, 24);
            this.panelChiNhanh.Name = "panelChiNhanh";
            this.panelChiNhanh.Size = new System.Drawing.Size(1256, 58);
            this.panelChiNhanh.TabIndex = 6;
            // 
            // ChiNhanhCb
            // 
            this.ChiNhanhCb.Enabled = false;
            this.ChiNhanhCb.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ChiNhanhCb.FormattingEnabled = true;
            this.ChiNhanhCb.Location = new System.Drawing.Point(128, 16);
            this.ChiNhanhCb.Name = "ChiNhanhCb";
            this.ChiNhanhCb.Size = new System.Drawing.Size(351, 27);
            this.ChiNhanhCb.TabIndex = 1;
            this.ChiNhanhCb.SelectedIndexChanged += new System.EventHandler(this.ChiNhanhCb_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(16, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHI NHÁNH:";
            // 
            // DataSet
            // 
            this.DataSet.DataSetName = "DataSet";
            this.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsKho
            // 
            this.bdsKho.DataMember = "Kho";
            this.bdsKho.DataSource = this.DataSet;
            // 
            // khoTableAdapter
            // 
            this.khoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.CTDDHTableAdapter = null;
            this.tableAdapterManager.CTPNTableAdapter = null;
            this.tableAdapterManager.CTPXTableAdapter = null;
            this.tableAdapterManager.DatHangTableAdapter = this.datHangTableAdapter;
            this.tableAdapterManager.KhoTableAdapter = this.khoTableAdapter;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = this.phieuNhapTableAdapter;
            this.tableAdapterManager.PhieuXuatTableAdapter = this.phieuXuatTableAdapter;
            this.tableAdapterManager.UpdateOrder = QLVT_DATHANG.DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = null;
            // 
            // datHangTableAdapter
            // 
            this.datHangTableAdapter.ClearBeforeFill = true;
            // 
            // phieuNhapTableAdapter
            // 
            this.phieuNhapTableAdapter.ClearBeforeFill = true;
            // 
            // phieuXuatTableAdapter
            // 
            this.phieuXuatTableAdapter.ClearBeforeFill = true;
            // 
            // KhoGc
            // 
            this.KhoGc.DataSource = this.bdsKho;
            this.KhoGc.Dock = System.Windows.Forms.DockStyle.Top;
            this.KhoGc.Location = new System.Drawing.Point(0, 82);
            this.KhoGc.MainView = this.gridView1;
            this.KhoGc.MenuManager = this.BarManager;
            this.KhoGc.Name = "KhoGc";
            this.KhoGc.Size = new System.Drawing.Size(1256, 220);
            this.KhoGc.TabIndex = 6;
            this.KhoGc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.KhoGc.Click += new System.EventHandler(this.KhoGc_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAKHO,
            this.colTENKHO,
            this.colDIACHI,
            this.colMACN});
            this.gridView1.GridControl = this.KhoGc;
            this.gridView1.Name = "gridView1";
            // 
            // colMAKHO
            // 
            this.colMAKHO.FieldName = "MAKHO";
            this.colMAKHO.Name = "colMAKHO";
            this.colMAKHO.OptionsColumn.AllowEdit = false;
            this.colMAKHO.Visible = true;
            this.colMAKHO.VisibleIndex = 0;
            // 
            // colTENKHO
            // 
            this.colTENKHO.FieldName = "TENKHO";
            this.colTENKHO.Name = "colTENKHO";
            this.colTENKHO.OptionsColumn.AllowEdit = false;
            this.colTENKHO.Visible = true;
            this.colTENKHO.VisibleIndex = 1;
            // 
            // colDIACHI
            // 
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.OptionsColumn.AllowEdit = false;
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 2;
            // 
            // colMACN
            // 
            this.colMACN.FieldName = "MACN";
            this.colMACN.Name = "colMACN";
            this.colMACN.OptionsColumn.AllowEdit = false;
            this.colMACN.Visible = true;
            this.colMACN.VisibleIndex = 3;
            // 
            // bdsPX
            // 
            this.bdsPX.DataMember = "FK_PhieuXuat_Kho";
            this.bdsPX.DataSource = this.bdsKho;
            // 
            // bdsPN
            // 
            this.bdsPN.DataMember = "FK_PhieuNhap_Kho";
            this.bdsPN.DataSource = this.bdsKho;
            // 
            // bdsDH
            // 
            this.bdsDH.DataMember = "FK_DatHang_Kho";
            this.bdsDH.DataSource = this.bdsKho;
            // 
            // panelNhapXuat
            // 
            this.panelNhapXuat.Controls.Add(mACNLabel);
            this.panelNhapXuat.Controls.Add(this.MaCNTb);
            this.panelNhapXuat.Controls.Add(dIACHILabel);
            this.panelNhapXuat.Controls.Add(this.DiaChiTb);
            this.panelNhapXuat.Controls.Add(tENKHOLabel);
            this.panelNhapXuat.Controls.Add(this.TenKhoTb);
            this.panelNhapXuat.Controls.Add(mAKHOLabel);
            this.panelNhapXuat.Controls.Add(this.MaKhoTb);
            this.panelNhapXuat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNhapXuat.Location = new System.Drawing.Point(0, 302);
            this.panelNhapXuat.Name = "panelNhapXuat";
            this.panelNhapXuat.Size = new System.Drawing.Size(1256, 218);
            this.panelNhapXuat.TabIndex = 7;
            // 
            // MaCNTb
            // 
            this.MaCNTb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsKho, "MACN", true));
            this.MaCNTb.Enabled = false;
            this.MaCNTb.Location = new System.Drawing.Point(393, 88);
            this.MaCNTb.Name = "MaCNTb";
            this.MaCNTb.Size = new System.Drawing.Size(100, 21);
            this.MaCNTb.TabIndex = 7;
            this.MaCNTb.Enter += new System.EventHandler(this.TextBoxClicked);
            // 
            // DiaChiTb
            // 
            this.DiaChiTb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsKho, "DIACHI", true));
            this.DiaChiTb.Location = new System.Drawing.Point(393, 28);
            this.DiaChiTb.Name = "DiaChiTb";
            this.DiaChiTb.Size = new System.Drawing.Size(228, 21);
            this.DiaChiTb.TabIndex = 5;
            this.DiaChiTb.Enter += new System.EventHandler(this.TextBoxClicked);
            // 
            // TenKhoTb
            // 
            this.TenKhoTb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsKho, "TENKHO", true));
            this.TenKhoTb.Location = new System.Drawing.Point(128, 88);
            this.TenKhoTb.Name = "TenKhoTb";
            this.TenKhoTb.Size = new System.Drawing.Size(166, 21);
            this.TenKhoTb.TabIndex = 3;
            this.TenKhoTb.Enter += new System.EventHandler(this.TextBoxClicked);
            // 
            // MaKhoTb
            // 
            this.MaKhoTb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsKho, "MAKHO", true));
            this.MaKhoTb.Enabled = false;
            this.MaKhoTb.Location = new System.Drawing.Point(128, 28);
            this.MaKhoTb.Name = "MaKhoTb";
            this.MaKhoTb.Size = new System.Drawing.Size(74, 21);
            this.MaKhoTb.TabIndex = 1;
            this.MaKhoTb.Enter += new System.EventHandler(this.TextBoxClicked);
            // 
            // FormKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 540);
            this.Controls.Add(this.panelNhapXuat);
            this.Controls.Add(this.KhoGc);
            this.Controls.Add(this.panelChiNhanh);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FormKho";
            this.Text = "FormKho";
            this.Load += new System.EventHandler(this.FormKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelChiNhanh)).EndInit();
            this.panelChiNhanh.ResumeLayout(false);
            this.panelChiNhanh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KhoGc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelNhapXuat)).EndInit();
            this.panelNhapXuat.ResumeLayout(false);
            this.panelNhapXuat.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager BarManager;
        private DevExpress.XtraBars.Bar Bar;
        private DevExpress.XtraBars.BarButtonItem ThemBtn;
        private DevExpress.XtraBars.BarButtonItem XoaBtn;
        private DevExpress.XtraBars.BarButtonItem GhiBtn;
        private DevExpress.XtraBars.BarButtonItem BoGhiBtn;
        private DevExpress.XtraBars.BarButtonItem HoanTacBtn;
        private DevExpress.XtraBars.BarButtonItem LamMoiBtn;
        private DevExpress.XtraBars.BarButtonItem ThoatBtn;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem ChuyenCNBtn;
        private DevExpress.XtraBars.BarHeaderItem barHeaderItem1;
        private DevExpress.XtraBars.BarMdiChildrenListItem barMdiChildrenListItem1;
        private DevExpress.XtraBars.SkinBarSubItem skinBarSubItem1;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraEditors.PanelControl panelChiNhanh;
        private System.Windows.Forms.ComboBox ChiNhanhCb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bdsKho;
        private DataSet DataSet;
        private DataSetTableAdapters.KhoTableAdapter khoTableAdapter;
        private DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl KhoGc;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTENKHO;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colMACN;
        private DataSetTableAdapters.PhieuXuatTableAdapter phieuXuatTableAdapter;
        private System.Windows.Forms.BindingSource bdsPX;
        private DataSetTableAdapters.PhieuNhapTableAdapter phieuNhapTableAdapter;
        private System.Windows.Forms.BindingSource bdsPN;
        private DataSetTableAdapters.DatHangTableAdapter datHangTableAdapter;
        private System.Windows.Forms.BindingSource bdsDH;
        private DevExpress.XtraEditors.PanelControl panelNhapXuat;
        private System.Windows.Forms.TextBox TenKhoTb;
        private System.Windows.Forms.TextBox MaKhoTb;
        private System.Windows.Forms.TextBox MaCNTb;
        private System.Windows.Forms.TextBox DiaChiTb;
    }
}
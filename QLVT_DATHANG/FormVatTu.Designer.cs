namespace QLVT_DATHANG
{
    partial class FormVatTu
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
            System.Windows.Forms.Label mAVTLabel;
            System.Windows.Forms.Label tENVTLabel;
            System.Windows.Forms.Label dVTLabel;
            System.Windows.Forms.Label sOLUONGTONLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVatTu));
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
            this.bdsVT = new System.Windows.Forms.BindingSource(this.components);
            this.vattuTableAdapter = new QLVT_DATHANG.DataSetTableAdapters.VattuTableAdapter();
            this.tableAdapterManager = new QLVT_DATHANG.DataSetTableAdapters.TableAdapterManager();
            this.bdsCTPX = new System.Windows.Forms.BindingSource(this.components);
            this.cTPXTableAdapter = new QLVT_DATHANG.DataSetTableAdapters.CTPXTableAdapter();
            this.bdsCTPN = new System.Windows.Forms.BindingSource(this.components);
            this.cTPNTableAdapter = new QLVT_DATHANG.DataSetTableAdapters.CTPNTableAdapter();
            this.bdsCTDDH = new System.Windows.Forms.BindingSource(this.components);
            this.cTDDHTableAdapter = new QLVT_DATHANG.DataSetTableAdapters.CTDDHTableAdapter();
            this.VatTuGc = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOLUONGTON = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelNhapXuat = new DevExpress.XtraEditors.PanelControl();
            this.SoLgTonSpE = new DevExpress.XtraEditors.SpinEdit();
            this.DvtTb = new System.Windows.Forms.TextBox();
            this.TenVTTb = new System.Windows.Forms.TextBox();
            this.MaVTTb = new System.Windows.Forms.TextBox();
            mAVTLabel = new System.Windows.Forms.Label();
            tENVTLabel = new System.Windows.Forms.Label();
            dVTLabel = new System.Windows.Forms.Label();
            sOLUONGTONLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelChiNhanh)).BeginInit();
            this.panelChiNhanh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsVT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTDDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VatTuGc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelNhapXuat)).BeginInit();
            this.panelNhapXuat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SoLgTonSpE.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // mAVTLabel
            // 
            mAVTLabel.AutoSize = true;
            mAVTLabel.Location = new System.Drawing.Point(75, 33);
            mAVTLabel.Name = "mAVTLabel";
            mAVTLabel.Size = new System.Drawing.Size(38, 13);
            mAVTLabel.TabIndex = 0;
            mAVTLabel.Text = "MAVT:";
            // 
            // tENVTLabel
            // 
            tENVTLabel.AutoSize = true;
            tENVTLabel.Location = new System.Drawing.Point(71, 90);
            tENVTLabel.Name = "tENVTLabel";
            tENVTLabel.Size = new System.Drawing.Size(42, 13);
            tENVTLabel.TabIndex = 2;
            tENVTLabel.Text = "TENVT:";
            // 
            // dVTLabel
            // 
            dVTLabel.AutoSize = true;
            dVTLabel.Location = new System.Drawing.Point(343, 33);
            dVTLabel.Name = "dVTLabel";
            dVTLabel.Size = new System.Drawing.Size(30, 13);
            dVTLabel.TabIndex = 4;
            dVTLabel.Text = "DVT:";
            // 
            // sOLUONGTONLabel
            // 
            sOLUONGTONLabel.AutoSize = true;
            sOLUONGTONLabel.Location = new System.Drawing.Point(293, 91);
            sOLUONGTONLabel.Name = "sOLUONGTONLabel";
            sOLUONGTONLabel.Size = new System.Drawing.Size(80, 13);
            sOLUONGTONLabel.TabIndex = 6;
            sOLUONGTONLabel.Text = "SOLUONGTON:";
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
            // 
            // XoaBtn
            // 
            this.XoaBtn.Caption = "Xóa";
            this.XoaBtn.Id = 1;
            this.XoaBtn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("XoaBtn.ImageOptions.SvgImage")));
            this.XoaBtn.Name = "XoaBtn";
            this.XoaBtn.Size = new System.Drawing.Size(90, 0);
            // 
            // GhiBtn
            // 
            this.GhiBtn.Caption = "Ghi";
            this.GhiBtn.Id = 2;
            this.GhiBtn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("GhiBtn.ImageOptions.SvgImage")));
            this.GhiBtn.Name = "GhiBtn";
            this.GhiBtn.Size = new System.Drawing.Size(90, 0);
            // 
            // BoGhiBtn
            // 
            this.BoGhiBtn.Caption = "Bỏ ghi";
            this.BoGhiBtn.Id = 12;
            this.BoGhiBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BoGhiBtn.ImageOptions.Image")));
            this.BoGhiBtn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BoGhiBtn.ImageOptions.LargeImage")));
            this.BoGhiBtn.Name = "BoGhiBtn";
            this.BoGhiBtn.Size = new System.Drawing.Size(95, 0);
            // 
            // HoanTacBtn
            // 
            this.HoanTacBtn.Caption = "Hoàn tác";
            this.HoanTacBtn.Id = 3;
            this.HoanTacBtn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("HoanTacBtn.ImageOptions.SvgImage")));
            this.HoanTacBtn.Name = "HoanTacBtn";
            this.HoanTacBtn.Size = new System.Drawing.Size(105, 0);
            // 
            // LamMoiBtn
            // 
            this.LamMoiBtn.Caption = "Làm mới";
            this.LamMoiBtn.Id = 4;
            this.LamMoiBtn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("LamMoiBtn.ImageOptions.SvgImage")));
            this.LamMoiBtn.Name = "LamMoiBtn";
            this.LamMoiBtn.Size = new System.Drawing.Size(105, 0);
            // 
            // ThoatBtn
            // 
            this.ThoatBtn.Caption = "Thoát";
            this.ThoatBtn.Id = 6;
            this.ThoatBtn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ThoatBtn.ImageOptions.SvgImage")));
            this.ThoatBtn.Name = "ThoatBtn";
            this.ThoatBtn.Size = new System.Drawing.Size(90, 0);
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
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 438);
            this.barDockControlBottom.Manager = this.BarManager;
            this.barDockControlBottom.Size = new System.Drawing.Size(1256, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.BarManager;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 414);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1256, 24);
            this.barDockControlRight.Manager = this.BarManager;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 414);
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
            this.panelChiNhanh.TabIndex = 5;
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
            // bdsVT
            // 
            this.bdsVT.DataMember = "Vattu";
            this.bdsVT.DataSource = this.DataSet;
            // 
            // vattuTableAdapter
            // 
            this.vattuTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.CTDDHTableAdapter = null;
            this.tableAdapterManager.CTPNTableAdapter = null;
            this.tableAdapterManager.CTPXTableAdapter = null;
            this.tableAdapterManager.DatHangTableAdapter = null;
            this.tableAdapterManager.KhoTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLVT_DATHANG.DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = this.vattuTableAdapter;
            // 
            // bdsCTPX
            // 
            this.bdsCTPX.DataMember = "FK_CTPX_VatTu";
            this.bdsCTPX.DataSource = this.bdsVT;
            // 
            // cTPXTableAdapter
            // 
            this.cTPXTableAdapter.ClearBeforeFill = true;
            // 
            // bdsCTPN
            // 
            this.bdsCTPN.DataMember = "FK_CTPN_VatTu";
            this.bdsCTPN.DataSource = this.bdsVT;
            // 
            // cTPNTableAdapter
            // 
            this.cTPNTableAdapter.ClearBeforeFill = true;
            // 
            // bdsCTDDH
            // 
            this.bdsCTDDH.DataMember = "FK_CTDDH_VatTu";
            this.bdsCTDDH.DataSource = this.bdsVT;
            // 
            // cTDDHTableAdapter
            // 
            this.cTDDHTableAdapter.ClearBeforeFill = true;
            // 
            // VatTuGc
            // 
            this.VatTuGc.DataSource = this.bdsVT;
            this.VatTuGc.Dock = System.Windows.Forms.DockStyle.Top;
            this.VatTuGc.Location = new System.Drawing.Point(0, 82);
            this.VatTuGc.MainView = this.gridView1;
            this.VatTuGc.MenuManager = this.BarManager;
            this.VatTuGc.Name = "VatTuGc";
            this.VatTuGc.Size = new System.Drawing.Size(1256, 197);
            this.VatTuGc.TabIndex = 10;
            this.VatTuGc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAVT,
            this.colTENVT,
            this.colDVT,
            this.colSOLUONGTON});
            this.gridView1.GridControl = this.VatTuGc;
            this.gridView1.Name = "gridView1";
            // 
            // colMAVT
            // 
            this.colMAVT.FieldName = "MAVT";
            this.colMAVT.Name = "colMAVT";
            this.colMAVT.OptionsColumn.AllowEdit = false;
            this.colMAVT.Visible = true;
            this.colMAVT.VisibleIndex = 0;
            // 
            // colTENVT
            // 
            this.colTENVT.FieldName = "TENVT";
            this.colTENVT.Name = "colTENVT";
            this.colTENVT.OptionsColumn.AllowEdit = false;
            this.colTENVT.Visible = true;
            this.colTENVT.VisibleIndex = 1;
            // 
            // colDVT
            // 
            this.colDVT.FieldName = "DVT";
            this.colDVT.Name = "colDVT";
            this.colDVT.OptionsColumn.AllowEdit = false;
            this.colDVT.Visible = true;
            this.colDVT.VisibleIndex = 2;
            // 
            // colSOLUONGTON
            // 
            this.colSOLUONGTON.FieldName = "SOLUONGTON";
            this.colSOLUONGTON.Name = "colSOLUONGTON";
            this.colSOLUONGTON.OptionsColumn.AllowEdit = false;
            this.colSOLUONGTON.Visible = true;
            this.colSOLUONGTON.VisibleIndex = 3;
            // 
            // panelNhapXuat
            // 
            this.panelNhapXuat.Controls.Add(sOLUONGTONLabel);
            this.panelNhapXuat.Controls.Add(this.SoLgTonSpE);
            this.panelNhapXuat.Controls.Add(dVTLabel);
            this.panelNhapXuat.Controls.Add(this.DvtTb);
            this.panelNhapXuat.Controls.Add(tENVTLabel);
            this.panelNhapXuat.Controls.Add(this.TenVTTb);
            this.panelNhapXuat.Controls.Add(mAVTLabel);
            this.panelNhapXuat.Controls.Add(this.MaVTTb);
            this.panelNhapXuat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNhapXuat.Location = new System.Drawing.Point(0, 279);
            this.panelNhapXuat.Name = "panelNhapXuat";
            this.panelNhapXuat.Size = new System.Drawing.Size(1256, 159);
            this.panelNhapXuat.TabIndex = 11;
            // 
            // SoLgTonSpE
            // 
            this.SoLgTonSpE.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsVT, "SOLUONGTON", true));
            this.SoLgTonSpE.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.SoLgTonSpE.Location = new System.Drawing.Point(379, 88);
            this.SoLgTonSpE.MenuManager = this.BarManager;
            this.SoLgTonSpE.Name = "SoLgTonSpE";
            this.SoLgTonSpE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.SoLgTonSpE.Size = new System.Drawing.Size(100, 20);
            this.SoLgTonSpE.TabIndex = 7;
            this.SoLgTonSpE.Click += new System.EventHandler(this.TextBoxClicked);
            // 
            // DvtTb
            // 
            this.DvtTb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsVT, "DVT", true));
            this.DvtTb.Location = new System.Drawing.Point(379, 30);
            this.DvtTb.Name = "DvtTb";
            this.DvtTb.Size = new System.Drawing.Size(100, 21);
            this.DvtTb.TabIndex = 5;
            this.DvtTb.Click += new System.EventHandler(this.TextBoxClicked);
            // 
            // TenVTTb
            // 
            this.TenVTTb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsVT, "TENVT", true));
            this.TenVTTb.Location = new System.Drawing.Point(119, 87);
            this.TenVTTb.Name = "TenVTTb";
            this.TenVTTb.Size = new System.Drawing.Size(100, 21);
            this.TenVTTb.TabIndex = 3;
            this.TenVTTb.Click += new System.EventHandler(this.TextBoxClicked);
            // 
            // MaVTTb
            // 
            this.MaVTTb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsVT, "MAVT", true));
            this.MaVTTb.Enabled = false;
            this.MaVTTb.Location = new System.Drawing.Point(119, 30);
            this.MaVTTb.Name = "MaVTTb";
            this.MaVTTb.Size = new System.Drawing.Size(100, 21);
            this.MaVTTb.TabIndex = 1;
            this.MaVTTb.Click += new System.EventHandler(this.TextBoxClicked);
            // 
            // FormVatTu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 458);
            this.Controls.Add(this.panelNhapXuat);
            this.Controls.Add(this.VatTuGc);
            this.Controls.Add(this.panelChiNhanh);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FormVatTu";
            this.Text = "FormVatTu";
            this.Load += new System.EventHandler(this.FormVatTu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelChiNhanh)).EndInit();
            this.panelChiNhanh.ResumeLayout(false);
            this.panelChiNhanh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsVT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTDDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VatTuGc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelNhapXuat)).EndInit();
            this.panelNhapXuat.ResumeLayout(false);
            this.panelNhapXuat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SoLgTonSpE.Properties)).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem ChuyenCNBtn;
        private DevExpress.XtraBars.BarButtonItem ThoatBtn;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarHeaderItem barHeaderItem1;
        private DevExpress.XtraBars.BarMdiChildrenListItem barMdiChildrenListItem1;
        private DevExpress.XtraBars.SkinBarSubItem skinBarSubItem1;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraEditors.PanelControl panelChiNhanh;
        private System.Windows.Forms.ComboBox ChiNhanhCb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bdsVT;
        private DataSet DataSet;
        private DataSetTableAdapters.VattuTableAdapter vattuTableAdapter;
        private DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource bdsCTPX;
        private DataSetTableAdapters.CTPXTableAdapter cTPXTableAdapter;
        private System.Windows.Forms.BindingSource bdsCTPN;
        private DataSetTableAdapters.CTPNTableAdapter cTPNTableAdapter;
        private System.Windows.Forms.BindingSource bdsCTDDH;
        private DataSetTableAdapters.CTDDHTableAdapter cTDDHTableAdapter;
        private DevExpress.XtraGrid.GridControl VatTuGc;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAVT;
        private DevExpress.XtraGrid.Columns.GridColumn colTENVT;
        private DevExpress.XtraGrid.Columns.GridColumn colDVT;
        private DevExpress.XtraGrid.Columns.GridColumn colSOLUONGTON;
        private DevExpress.XtraEditors.PanelControl panelNhapXuat;
        private DevExpress.XtraEditors.SpinEdit SoLgTonSpE;
        private System.Windows.Forms.TextBox DvtTb;
        private System.Windows.Forms.TextBox TenVTTb;
        private System.Windows.Forms.TextBox MaVTTb;
    }
}
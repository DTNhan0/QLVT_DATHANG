namespace QLVT_DATHANG.SubForm
{
    partial class FormChonNhanVien
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
            this.panelChiNhanh = new DevExpress.XtraEditors.PanelControl();
            this.ChiNhanhCb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DataSet = new QLVT_DATHANG.DataSet();
            this.bdsNV = new System.Windows.Forms.BindingSource(this.components);
            this.nhanVienTableAdapter = new QLVT_DATHANG.DataSetTableAdapters.NhanVienTableAdapter();
            this.tableAdapterManager = new QLVT_DATHANG.DataSetTableAdapters.TableAdapterManager();
            this.NhanVienGc = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOCMND = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYSINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTrangThaiXoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ThoatBtn = new System.Windows.Forms.Button();
            this.ChonBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.panelChiNhanh)).BeginInit();
            this.panelChiNhanh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NhanVienGc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelChiNhanh
            // 
            this.panelChiNhanh.Controls.Add(this.ChiNhanhCb);
            this.panelChiNhanh.Controls.Add(this.label1);
            this.panelChiNhanh.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelChiNhanh.Location = new System.Drawing.Point(0, 0);
            this.panelChiNhanh.Name = "panelChiNhanh";
            this.panelChiNhanh.Size = new System.Drawing.Size(732, 58);
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
            // bdsNV
            // 
            this.bdsNV.DataMember = "NhanVien";
            this.bdsNV.DataSource = this.DataSet;
            // 
            // nhanVienTableAdapter
            // 
            this.nhanVienTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.NhanVienTableAdapter = this.nhanVienTableAdapter;
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLVT_DATHANG.DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = null;
            // 
            // NhanVienGc
            // 
            this.NhanVienGc.DataSource = this.bdsNV;
            this.NhanVienGc.Dock = System.Windows.Forms.DockStyle.Top;
            this.NhanVienGc.Location = new System.Drawing.Point(0, 58);
            this.NhanVienGc.MainView = this.gridView1;
            this.NhanVienGc.Name = "NhanVienGc";
            this.NhanVienGc.Size = new System.Drawing.Size(732, 245);
            this.NhanVienGc.TabIndex = 6;
            this.NhanVienGc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMANV,
            this.colHO,
            this.colTEN,
            this.colSOCMND,
            this.colDIACHI,
            this.colNGAYSINH,
            this.colLUONG,
            this.colMACN,
            this.colTrangThaiXoa});
            this.gridView1.GridControl = this.NhanVienGc;
            this.gridView1.Name = "gridView1";
            // 
            // colMANV
            // 
            this.colMANV.FieldName = "MANV";
            this.colMANV.Name = "colMANV";
            this.colMANV.OptionsColumn.AllowEdit = false;
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 0;
            // 
            // colHO
            // 
            this.colHO.FieldName = "HO";
            this.colHO.Name = "colHO";
            this.colHO.OptionsColumn.AllowEdit = false;
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 1;
            // 
            // colTEN
            // 
            this.colTEN.FieldName = "TEN";
            this.colTEN.Name = "colTEN";
            this.colTEN.OptionsColumn.AllowEdit = false;
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 2;
            // 
            // colSOCMND
            // 
            this.colSOCMND.FieldName = "SOCMND";
            this.colSOCMND.Name = "colSOCMND";
            this.colSOCMND.OptionsColumn.AllowEdit = false;
            this.colSOCMND.Visible = true;
            this.colSOCMND.VisibleIndex = 3;
            // 
            // colDIACHI
            // 
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.OptionsColumn.AllowEdit = false;
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 4;
            // 
            // colNGAYSINH
            // 
            this.colNGAYSINH.FieldName = "NGAYSINH";
            this.colNGAYSINH.Name = "colNGAYSINH";
            this.colNGAYSINH.OptionsColumn.AllowEdit = false;
            this.colNGAYSINH.Visible = true;
            this.colNGAYSINH.VisibleIndex = 5;
            // 
            // colLUONG
            // 
            this.colLUONG.FieldName = "LUONG";
            this.colLUONG.Name = "colLUONG";
            this.colLUONG.OptionsColumn.AllowEdit = false;
            this.colLUONG.Visible = true;
            this.colLUONG.VisibleIndex = 6;
            // 
            // colMACN
            // 
            this.colMACN.FieldName = "MACN";
            this.colMACN.Name = "colMACN";
            this.colMACN.OptionsColumn.AllowEdit = false;
            this.colMACN.Visible = true;
            this.colMACN.VisibleIndex = 7;
            // 
            // colTrangThaiXoa
            // 
            this.colTrangThaiXoa.FieldName = "TrangThaiXoa";
            this.colTrangThaiXoa.Name = "colTrangThaiXoa";
            this.colTrangThaiXoa.OptionsColumn.AllowEdit = false;
            this.colTrangThaiXoa.Visible = true;
            this.colTrangThaiXoa.VisibleIndex = 8;
            // 
            // ThoatBtn
            // 
            this.ThoatBtn.BackColor = System.Drawing.Color.OrangeRed;
            this.ThoatBtn.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThoatBtn.ForeColor = System.Drawing.Color.White;
            this.ThoatBtn.Location = new System.Drawing.Point(419, 330);
            this.ThoatBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ThoatBtn.Name = "ThoatBtn";
            this.ThoatBtn.Size = new System.Drawing.Size(131, 40);
            this.ThoatBtn.TabIndex = 10;
            this.ThoatBtn.Text = "THOÁT";
            this.ThoatBtn.UseVisualStyleBackColor = false;
            this.ThoatBtn.Click += new System.EventHandler(this.ThoatBtn_Click);
            // 
            // ChonBtn
            // 
            this.ChonBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.ChonBtn.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChonBtn.ForeColor = System.Drawing.Color.White;
            this.ChonBtn.Location = new System.Drawing.Point(179, 330);
            this.ChonBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ChonBtn.Name = "ChonBtn";
            this.ChonBtn.Size = new System.Drawing.Size(131, 40);
            this.ChonBtn.TabIndex = 9;
            this.ChonBtn.Text = "CHỌN";
            this.ChonBtn.UseVisualStyleBackColor = false;
            this.ChonBtn.Click += new System.EventHandler(this.ChonBtn_Click);
            // 
            // FormChonNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 397);
            this.Controls.Add(this.ThoatBtn);
            this.Controls.Add(this.ChonBtn);
            this.Controls.Add(this.NhanVienGc);
            this.Controls.Add(this.panelChiNhanh);
            this.Name = "FormChonNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormChonNhanVien";
            this.Load += new System.EventHandler(this.FormChonNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelChiNhanh)).EndInit();
            this.panelChiNhanh.ResumeLayout(false);
            this.panelChiNhanh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NhanVienGc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelChiNhanh;
        private System.Windows.Forms.ComboBox ChiNhanhCb;
        private System.Windows.Forms.Label label1;
        private DataSet DataSet;
        private System.Windows.Forms.BindingSource bdsNV;
        private DataSetTableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
        private DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl NhanVienGc;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colSOCMND;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYSINH;
        private DevExpress.XtraGrid.Columns.GridColumn colLUONG;
        private DevExpress.XtraGrid.Columns.GridColumn colMACN;
        private DevExpress.XtraGrid.Columns.GridColumn colTrangThaiXoa;
        private System.Windows.Forms.Button ThoatBtn;
        private System.Windows.Forms.Button ChonBtn;
    }
}
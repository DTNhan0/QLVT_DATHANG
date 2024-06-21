namespace QLVT_DATHANG.ReportForm
{
    partial class FormDanhSachVatTu
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
            this.label1 = new System.Windows.Forms.Label();
            this.XuatBanBtn = new System.Windows.Forms.Button();
            this.XemTruocBtn = new System.Windows.Forms.Button();
            this.dataSet = new QLVT_DATHANG.DataSet();
            this.vattuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vattuTableAdapter = new QLVT_DATHANG.DataSetTableAdapters.VattuTableAdapter();
            this.tableAdapterManager = new QLVT_DATHANG.DataSetTableAdapters.TableAdapterManager();
            this.VatTuGc = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOLUONGTON = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vattuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VatTuGc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(185, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh sách vật tư";
            // 
            // XuatBanBtn
            // 
            this.XuatBanBtn.BackColor = System.Drawing.Color.OrangeRed;
            this.XuatBanBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XuatBanBtn.ForeColor = System.Drawing.Color.White;
            this.XuatBanBtn.Location = new System.Drawing.Point(360, 73);
            this.XuatBanBtn.Margin = new System.Windows.Forms.Padding(2);
            this.XuatBanBtn.Name = "XuatBanBtn";
            this.XuatBanBtn.Size = new System.Drawing.Size(144, 37);
            this.XuatBanBtn.TabIndex = 4;
            this.XuatBanBtn.Text = "XUẤT BẢN";
            this.XuatBanBtn.UseVisualStyleBackColor = false;
            this.XuatBanBtn.Click += new System.EventHandler(this.XuatBanBtn_Click);
            // 
            // XemTruocBtn
            // 
            this.XemTruocBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.XemTruocBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XemTruocBtn.ForeColor = System.Drawing.Color.White;
            this.XemTruocBtn.Location = new System.Drawing.Point(93, 73);
            this.XemTruocBtn.Margin = new System.Windows.Forms.Padding(2);
            this.XemTruocBtn.Name = "XemTruocBtn";
            this.XemTruocBtn.Size = new System.Drawing.Size(144, 37);
            this.XemTruocBtn.TabIndex = 3;
            this.XemTruocBtn.Text = "XEM TRƯỚC";
            this.XemTruocBtn.UseVisualStyleBackColor = false;
            this.XemTruocBtn.Click += new System.EventHandler(this.XemTruocBtn_Click);
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vattuBindingSource
            // 
            this.vattuBindingSource.DataMember = "Vattu";
            this.vattuBindingSource.DataSource = this.dataSet;
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
            // VatTuGc
            // 
            this.VatTuGc.DataSource = this.vattuBindingSource;
            this.VatTuGc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.VatTuGc.Location = new System.Drawing.Point(0, 149);
            this.VatTuGc.MainView = this.gridView1;
            this.VatTuGc.Name = "VatTuGc";
            this.VatTuGc.Size = new System.Drawing.Size(640, 220);
            this.VatTuGc.TabIndex = 5;
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
            // FormDanhSachVatTu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 369);
            this.Controls.Add(this.VatTuGc);
            this.Controls.Add(this.XuatBanBtn);
            this.Controls.Add(this.XemTruocBtn);
            this.Controls.Add(this.label1);
            this.Name = "FormDanhSachVatTu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDanhSachVatTu";
            this.Load += new System.EventHandler(this.FormDanhSachVatTu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vattuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VatTuGc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button XuatBanBtn;
        private System.Windows.Forms.Button XemTruocBtn;
        private DataSet dataSet;
        private System.Windows.Forms.BindingSource vattuBindingSource;
        private DataSetTableAdapters.VattuTableAdapter vattuTableAdapter;
        private DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl VatTuGc;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAVT;
        private DevExpress.XtraGrid.Columns.GridColumn colTENVT;
        private DevExpress.XtraGrid.Columns.GridColumn colDVT;
        private DevExpress.XtraGrid.Columns.GridColumn colSOLUONGTON;
    }
}
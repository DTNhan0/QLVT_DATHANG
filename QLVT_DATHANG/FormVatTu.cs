using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

        private void vattuBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsVT.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DataSet);

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

            HoanTacBtn.Enabled = false;

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
                TempData = CopyDataRowView((DataRowView)bdsVT.Current);
        }
    }
}
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

namespace QLVT_DATHANG.SubForm
{
    public partial class FormChonDonHang : DevExpress.XtraEditors.XtraForm
    {
        public FormChonDonHang()
        {
            InitializeComponent();
        }

        private void datHangBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsDH.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DataSet);

        }

        private void FormChonDonHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet.DatHang' table. You can move, or remove it, as needed.
            this.datHangTableAdapter.Fill(this.DataSet.DatHang);

        }
    }
}
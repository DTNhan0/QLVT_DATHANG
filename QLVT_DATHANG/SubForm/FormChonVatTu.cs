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
    public partial class FormChonVatTu : DevExpress.XtraEditors.XtraForm
    {
        public FormChonVatTu()
        {
            InitializeComponent();
        }

        private void FormChonVatTu_Load(object sender, EventArgs e)
        {
            DataSet.EnforceConstraints = false;
            this.vattuTableAdapter.Connection.ConnectionString = Program.connstr;
            this.vattuTableAdapter.Fill(this.DataSet.Vattu);
        }

        private void ChonBtn_Click(object sender, EventArgs e)
        {
            string maVatTu = ((DataRowView)bdsVT.Current)["MAVT"].ToString();

            Program.maVatTuDuocChon = maVatTu;

            this.Close();
        }

        private void ThoatBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
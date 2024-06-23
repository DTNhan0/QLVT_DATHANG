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
    public partial class FormChonKhoHang : DevExpress.XtraEditors.XtraForm
    {
        public FormChonKhoHang()
        {
            InitializeComponent();
        }

        private void FormChonKhoHang_Load(object sender, EventArgs e)
        {
            DataSet.EnforceConstraints = false;
            this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
            this.khoTableAdapter.Fill(this.DataSet.Kho);

        }

        private void ChonBtn_Click(object sender, EventArgs e)
        {
            string maKhoHang = ((DataRowView)bdsKH.Current)["MAKHO"].ToString();

            Program.maKhoDuocChon = maKhoHang;
            this.Close();
        }

        private void ThoatBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
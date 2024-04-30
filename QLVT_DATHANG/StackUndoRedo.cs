using DevExpress.Xpo.DB.Helpers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QLVT_DATHANG
{
    internal class StackUndoRedo
    {
        private Stack Data;

        private Stack Undo;

        private Stack Index;

        private BindingSource Bds;

        public StackUndoRedo(BindingSource bds)
        {
            this.Bds = bds;

            this.Data = new Stack();

            this.Undo = new Stack();

            this.Index = new Stack();
        }

        public StackUndoRedo()
        {
            this.Data = new Stack();

            this.Undo = new Stack();

            this.Index = new Stack();
        }

        public void setBds(BindingSource bds)
        {
            this.Bds = bds;
        }

        public void InsertStack(DataRowView dataRowView, String type, int index)
        {
            Data.Push(CopyDataRowView(dataRowView));
            Index.Push(index);
            Undo.Push(type);
        }

        public void DoUndo()
        {
            Console.WriteLine(Undo.Count);
            if (Undo.Count > 0 && Index.Count > 0)
            {
                int index = (int)Index.Pop();
                if(index != -1)
                    Bds.Position = index;
                String Type = (string)Undo.Pop();
                switch (Type)
                {
                    case "Add":
                        Bds.RemoveCurrent();
                        Bds.EndEdit();
                        break;
                    case "Delete":
                        Bds.AddNew();
                        DataRowView currentRow = (DataRowView)Bds.Current;
                        currentRow.BeginEdit();

                        DataRowView copiedRow = (DataRowView)Data.Pop();

                        for (int i = 0; i < currentRow.Row.ItemArray.Length; i++)
                            currentRow.Row[i] = copiedRow.Row[i];

                        currentRow.EndEdit();
                        Bds.EndEdit();
                        break;
                    case "Update Old":
                        DataRowView CurrentRow = (DataRowView)Bds.Current;
                        CurrentRow.BeginEdit();

                        DataRowView CopiedRow = (DataRowView)Data.Pop();
                        for (int i = 1; i < CurrentRow.Row.ItemArray.Length; i++)
                            CurrentRow.Row[i] = CopiedRow.Row[i];

                        CurrentRow.EndEdit();
                        Bds.EndEdit();
                        break;
                }
            }
            else
            {
                MessageBox.Show("Không còn dữ liệu để hoàn tác!");
            }
        }

        private DataRowView CopyDataRowView(DataRowView original)
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
    }
}

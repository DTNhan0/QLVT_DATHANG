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
    public class UndoRedoItem
    {
        public string ActionType { get; set; } // Add, Delete, Update
        public DataRowView DataRow { get; set; }
        public int Index { get; set; }
    }

    internal class StackUndoRedo
    {
        private Stack<UndoRedoItem> DataStack;
        private BindingSource Bds;

        public StackUndoRedo(BindingSource bds)
        {
            this.Bds = bds;
            this.DataStack = new Stack<UndoRedoItem>();
        }

        public void InsertStack(DataRowView dataRowView, string type, int index)
        {
            UndoRedoItem item = new UndoRedoItem
            {
                ActionType = type,
                DataRow = dataRowView,
                Index = index
            };
            DataStack.Push(item);
        }

        public int DoUndo()
        {
            if (DataStack.Count > 0)
            {
                UndoRedoItem item = DataStack.Pop();
                int index = item.Index;
                switch (item.ActionType)
                {
                    case "Add":

                        Bds.RemoveAt(index);

                        return index;

                    case "Delete":

                        Bds.AddNew();
                        DataRowView CurrentRow = (DataRowView)Bds.Current;

                        CurrentRow.BeginEdit();

                        DataRowView CopiedRow = item.DataRow;

                        for (int i = 0; i < CurrentRow.Row.ItemArray.Length; i++)
                            CurrentRow.Row[i] = CopiedRow.Row[i];

                        CurrentRow.EndEdit();

                        return index;

                    case "Update":

                        DataRowView currentRow = (DataRowView)Bds[item.Index];
                        currentRow.BeginEdit();

                        DataRowView copiedRow = item.DataRow;

                        for (int i = 1; i < currentRow.Row.ItemArray.Length; i++)
                            currentRow.Row[i] = copiedRow.Row[i];

                        currentRow.EndEdit();

                        return index;
                }
            }

            return -1;
        }


    }

}

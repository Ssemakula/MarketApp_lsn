using MarketApp_lsn.Method2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketApp_lsn.Method3
{
    public partial class Method3Main : Form
    {
        public Method3Main()
        {
            InitializeComponent();
        }

        private void SaveToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.goods_listBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.market);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            

        }

        private void Method3Main_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'market.goods_list' table. You can move, or remove it, as needed.
            try
            {
                this.goods_listTableAdapter.FillAll(this.market.goods_list);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void EditToolStripButton_Click(object sender, EventArgs e)
        {
            Method3.Method3Child child = new Method3Child();
            // child.toolStripLabel.Text = "Add Record";
            child.CurrentRecord = Convert.ToInt32(GetValue(goods_listDataGridView, "_ID"));
            child.ShowDialog();
            child.Dispose();
            ReloadData();
        }

        private void ReloadData()
        {
            try
            {
                this.goods_listTableAdapter.FillAll(this.market.goods_list);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void ExitToolStripButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private object GetValue(DataGridView _dataGridView, string _columnIndex) //Get value using column name
        {
            int rowIndex = 0; //int columnIndex = 0;
            int countMess = _dataGridView.RowCount; //Check whether there are any records in grid
            if (countMess < 1)  //if none return null (alsways check if it returns null)
            {
                return null;
            }
            DataGridViewRow row = _dataGridView.Rows[rowIndex];
            DataGridViewCell cell = row.Cells[_columnIndex];
            object cellValue = cell.Value;
            if (_dataGridView.SelectedRows.Count > 0) //have to select a full row...
            {
                int selectedRow = _dataGridView.SelectedRows[0].Index; //Get the index of the first selected row
                object rowValue = GetCellValue(_dataGridView, _columnIndex, selectedRow);
                cellValue = rowValue;
            }
            else if (_dataGridView.SelectedCells.Count > 0) //Selected a cell
            {
                int selectedRow = _dataGridView.SelectedCells[0].RowIndex; //Get the row index of the first selected cell
                object rowValue = GetCellValue(_dataGridView, _columnIndex, selectedRow);
                cellValue = rowValue;
            }
            else
            {
                cellValue = null;
            }
            return cellValue;
        }

        private object GetCellValue(DataGridView _dataGridView, string _columnName, int _rowIndex)
        {
            object cellValue = _dataGridView.Rows[_rowIndex].Cells[_columnName].Value;
            return cellValue;
        }

        private bool IsEmptyGrid(DataGridView grid)  //Useful. Should Resuse
        {
            return grid.Rows.Count == 0;
        }
    }
}

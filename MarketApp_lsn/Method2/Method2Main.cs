using MarketApp_lsn.DataSets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketApp_lsn.Method2
{
    public partial class Method2Main : Form
    {
        public Method2Main()
        {
            InitializeComponent();
        }

        private void Method2Main_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'market.goods_list' table. You can move, or remove it, as needed.
            this.goods_listTableAdapter.FillAll(this.market.goods_list); //Ignored the load all button in lesson
            this.goods_listBindingSource.Sort = "goods_name ASC"; //Set default sort property

        }

        private void ReloadData()
        {
            this.goods_listTableAdapter.FillAll(this.market.goods_list);
        }

        void ButtonController(bool _status = true)
        {

            //-------------Note: Find a way of expand contract grid -----------------------//
            if (_status) //Editing
            {
                this.newToolStripButton.Enabled = false;
                this.editToolStripButton.Enabled = false;
                this.deleteToolStripButton.Enabled = false;

                this.exitToolStripButton.Enabled = false;
                //this.groupBox1.Enabled = true;
                this.goods_listDataGridView.Enabled = false; //Prevent inadvertent changes
            }
            else //Not editing
            {
                this.newToolStripButton.Enabled = true;
                this.editToolStripButton.Enabled = true;
                this.deleteToolStripButton.Enabled = true;

                this.exitToolStripButton.Enabled = true;
                //this.groupBox1.Enabled = false;
                this.goods_listDataGridView.Enabled = true;
            }

        }

        private void BindingNav_Control(bool _status = true)
        {
            if (_status) //disable prevs etc
            {
                this.bindingNavigatorMoveFirstItem.Enabled = false;
                this.bindingNavigatorMoveNextItem.Enabled = false;
                this.bindingNavigatorMovePreviousItem.Enabled = false;
                this.bindingNavigatorMoveLastItem.Enabled = false;
            }
            else //Restore status
            {
                this.bindingNavigatorMoveFirstItem.Enabled = true;
                this.bindingNavigatorMoveNextItem.Enabled = true;
                this.bindingNavigatorMovePreviousItem.Enabled = true;
                this.bindingNavigatorMoveLastItem.Enabled = true;

                if (this.goods_listDataGridView.CurrentRow.Index <= 0)
                {
                    this.bindingNavigatorMovePreviousItem.Enabled = false;
                    this.bindingNavigatorMoveFirstItem.Enabled = false;
                }
                if (this.goods_listDataGridView.CurrentRow.Index == this.goods_listDataGridView.RowCount - 1)
                {
                    this.bindingNavigatorMoveNextItem.Enabled = false;
                    this.bindingNavigatorMoveLastItem.Enabled = false;
                }
            }
        }

        /*-----------------------Grid routines----------------------------
         * These next two are not in the lessons
         * I am using them from a previously developed idea
         * They return a value of a specific chosen cell (only one) 
         * from the currently selected row in grid
         * Expects grid, and cell name as defined in grid
         * I was too lasy to make it specific
         * t's however a good lesson on how to manipulate grids
         * A bit of an overkill but better than hidden lables
         * --------------------------------------------------------------*/

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

      private void ExitToolStripButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NewToolStripButton_Click(object sender, EventArgs e)
        {
            Method2.Method2Child child = new Method2Child();
            child.toolStripLabel.Text = "Add Record";
            child.ShowDialog();
            child.Dispose();
            if (child.DialogResult == DialogResult.OK)
                ReloadData();
        }

        private void EditToolStripButton_Click(object sender, EventArgs e)
        {
            if (IsEmptyGrid(goods_listDataGridView))
                return;
            Method2.Method2Child child = new Method2Child();
            child.toolStripLabel.Text = "Edit Record";
            child.CurrentRecord = Convert.ToInt32(GetValue(goods_listDataGridView, "_ID"));
            child.ShowDialog();
            child.Dispose();
            if (child.DialogResult == DialogResult.OK)
                ReloadData();
        }

        private void DeleteToolStripButton_Click(object sender, EventArgs e)
        {
            if (IsEmptyGrid(goods_listDataGridView))
                return;
            Method2.Method2Child child = new Method2Child();
            child.toolStripLabel.Text = "Delete Record";
            child.CurrentRecord = Convert.ToInt32(GetValue(goods_listDataGridView, "_ID"));
            child.ShowDialog();
            child.Dispose();
            if (child.DialogResult == DialogResult.OK)
                ReloadData();
        }
    }
}

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
            this.goods_listTableAdapter.FillAll(this.market.goods_list);

        }

        void ButtonController(bool _status = true)
        {

            //-------------Note: Find a wat ot expand contract grid -----------------------//
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
        }

        private void EditToolStripButton_Click(object sender, EventArgs e)
        {
            Method2.Method2Child child = new Method2Child();
            child.toolStripLabel.Text = "Edit Record";
            child.ShowDialog();
            child.Dispose();
        }

        private void DeleteToolStripButton_Click(object sender, EventArgs e)
        {
            Method2.Method2Child child = new Method2Child();
            child.toolStripLabel.Text = "Delete Record";
            child.ShowDialog();
            child.Dispose();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MarketApp_lsn
{
    public partial class Method1 : Form
    {

        private const int WS_SYSMENU = 0x80000;
        private const int SC_CLOSE = 0xF060;

        [DllImport("user32.dll")]
        private static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);

        [DllImport("user32.dll")]
        private static extern int EnableMenuItem(IntPtr hMenu, int uIDEnableItem, int uEnable);

        private const int MF_BYCOMMAND = 0x00000000;
        private const int MF_GRAYED = 0x00000001;


        public Method1()
        {
            InitializeComponent();
            DisableCloseButton();
        }

        private void goods_listBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.goods_listBindingSource.EndEdit();
                // this.goods_listTableAdapter.Update(this.market.goods_list);
                if (this.goods_listTableAdapter.Update(this.market.goods_list) == 0)
                {
                    MessageBox.Show("Failed to update records");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            
            ButtonController(false);
            BindingNav_Control(false);
        }

        private void Method1_Load(object sender, EventArgs e)
        {
            ButtonController(false);
            // TODO: This line of code loads data into the 'market.goods_list' table. You can move, or remove it, as needed.
            try
            {
                this.goods_listTableAdapter.FillAll(this.market.goods_list);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            this.groupBox1.Enabled = false;
        }

        private void NewToolStripButton_Click(object sender, EventArgs e)
        {
            ButtonController();
            this.goods_listBindingSource.AddNew();
            BindingNav_Control();
        }

        private void EditToolStripButton_Click(object sender, EventArgs e)
        {
            if(this.market.goods_list.Rows.Count == 0)
            {
                return;
            }
            ButtonController();
            BindingNav_Control();
        }

        private void DeleteToolStripButton_Click(object sender, EventArgs e)
        {
            if (this.market.goods_list.Rows.Count == 0)
            {
                return;
            }
            ButtonController();
            BindingNav_Control();
            this.groupBox1.Enabled = false;
            this.goods_listBindingSource.RemoveCurrent();
        }

        void ButtonController(bool _status = true)
        {

            //-------------Note: Find a wat ot expand contract grid -----------------------//
            if (_status) //Editing
            {
                this.newToolStripButton.Enabled = false;
                this.editToolStripButton.Enabled = false;
                this.deleteToolStripButton.Enabled = false;

                this.saveToolStripButton.Enabled = true;
                this.cancelToolStripButton.Enabled = true;
                this.exitToolStripButton.Enabled=false;
                this.groupBox1.Enabled = true;
                this.goods_listDataGridView.Enabled = false; //Prevent inadvertent changes
            }
            else //Not editing
            {
                this.newToolStripButton.Enabled = true;
                this.editToolStripButton.Enabled = true;
                this.deleteToolStripButton.Enabled = true;

                this.saveToolStripButton.Enabled = false;
                this.cancelToolStripButton.Enabled = false;
                this.exitToolStripButton.Enabled = true;
                this.groupBox1.Enabled = false;
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

                if(this.goods_listDataGridView.CurrentRow.Index <= 0)
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

        private void CancelToolStripButton_Click(object sender, EventArgs e)
        {
            ButtonController(false);
            BindingNav_Control(false);
            try
            {
                this.goods_listBindingSource.CancelEdit();
                this.market.goods_list.RejectChanges();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void ExitToolStripButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            // Disable the close button whenever the form is resized
            DisableCloseButton();
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == 0x0210) // WM_SYSCOMMAND
            {
                // Prevent the system from processing the SC_CLOSE command
                if ((int)m.WParam == SC_CLOSE)
                {
                    m.Result = IntPtr.Zero;
                }
            }
        }


        private void DisableCloseButton()
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);

            if (hMenu != IntPtr.Zero)
            {
                // Disable the close button in the control box
                EnableMenuItem(hMenu, SC_CLOSE, MF_BYCOMMAND | MF_GRAYED);
            }
        }
    }
}

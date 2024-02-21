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
    public partial class Method3Child : Form
    {
        private int _currentRecord;

        public Method3Child()
        {
            InitializeComponent();
        }

        public int CurrentRecord
        {
            get { return _currentRecord; }
            set { _currentRecord = value; }
        }

        private void Method3Child_Load(object sender, EventArgs e)
        {
            try
            {
                this.goods_listTableAdapter.Fillby_ID(this.market.goods_list, _currentRecord);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ButtonController(false);

        }

        private void ReloadCurr(int currec)
        {
            try
            {
                this.goods_listTableAdapter.Fillby_ID(this.market.goods_list, currec);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ExitToolStripButton_Click(object sender, EventArgs e)
        {
            this.Close();
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
                this.exitToolStripButton.Enabled = false;
                this.groupBox1.Enabled = true;
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
            }

        }

        private void NewToolStripButton_Click(object sender, EventArgs e)
        {
            ButtonController();
            try
            {
                this.goods_listBindingSource.AddNew();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            
        }

        private void EditToolStripButton_Click(object sender, EventArgs e)
        {
            if (this.CurrentRecord == 0)
            {
                return;
            }
            ButtonController();
        }

        private void DeleteToolStripButton_Click(object sender, EventArgs e)
        {
            if (this.CurrentRecord == 0)
            {
                return;
            }
            this.groupBox1.Enabled = false;
            try
            {
                this.goods_listBindingSource.RemoveCurrent();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            ButtonController();
        }

        private void SaveToolStripButton_Click(object sender, EventArgs e)
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

            int.TryParse(this.idTextBox.Text, out int _currRec);
            ReloadCurr(_currRec);
            this.CurrentRecord = _currRec;
            ButtonController(false);
        }

        private void CancelToolStripButton_Click(object sender, EventArgs e)
        {
            ButtonController(false);
            this.goods_listBindingSource.CancelEdit();
            this.market.goods_list.RejectChanges();
        }
    }
}

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
    public partial class Method2Child : Form
    {
        /* Method declares a label as public
         * This is the approach the lesson takes
         * I am a bit uncomfortable with that
         * Mayhaps a different way?
         */

        private int _currentRecord;

        public Method2Child()
        {
            InitializeComponent();
        }

        public int CurrentRecord {
            get {  return _currentRecord; } 
            set { _currentRecord = value;}
            }

        private void Method2Child_Load(object sender, EventArgs e)
        {
            if (this.toolStripLabel.Text == "Add Record")
            {
                this.goods_listBindingSource.AddNew();
            }
            else
            {
                try
                {
                    this.goods_listTableAdapter.Fillby_ID(this.market.goods_list, _currentRecord);
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
                if (this.toolStripLabel.Text == "Edit Record")
                {
                    //No code necessary
                }
                else if(this.toolStripLabel.Text == "Delete Record")
                {
                    this.infoGroupBox.Enabled = false;
                }
            }
        }

        private void SaveToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.goods_listBindingSource.EndEdit();
                // this.goods_listTableAdapter.Update(this.market.goods_list);
                 if (this.toolStripLabel.Text == "Delete Record")
                {
                    this.goods_listBindingSource.RemoveCurrent();
                }

               if (this.goods_listTableAdapter.Update(this.market.goods_list) == 0)
                {
                    MessageBox.Show("Failed to update records");
                }
                else
                {
                    this.DialogResult = DialogResult.OK;
                    //this.Close();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void CancelToolStripButton_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.Cancel;
        }
    }
}

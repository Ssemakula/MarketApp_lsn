namespace MarketApp_lsn.Method3
{
    partial class Method3Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Method3Main));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.market = new MarketApp_lsn.DataSets.Market();
            this.goods_listBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.goods_listTableAdapter = new MarketApp_lsn.DataSets.MarketTableAdapters.goods_listTableAdapter();
            this.tableAdapterManager = new MarketApp_lsn.DataSets.MarketTableAdapters.TableAdapterManager();
            this.goods_listBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.firstToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.prevToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.nextToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.lastToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.editToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.exitToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.goods_listDataGridView = new System.Windows.Forms.DataGridView();
            this._ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._goods_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._QTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._reg_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.market)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goods_listBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goods_listBindingNavigator)).BeginInit();
            this.goods_listBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.goods_listDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // market
            // 
            this.market.DataSetName = "Market";
            this.market.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // goods_listBindingSource
            // 
            this.goods_listBindingSource.DataMember = "goods_list";
            this.goods_listBindingSource.DataSource = this.market;
            // 
            // goods_listTableAdapter
            // 
            this.goods_listTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.goods_listTableAdapter = this.goods_listTableAdapter;
            this.tableAdapterManager.UpdateOrder = MarketApp_lsn.DataSets.MarketTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // goods_listBindingNavigator
            // 
            this.goods_listBindingNavigator.AddNewItem = null;
            this.goods_listBindingNavigator.BindingSource = this.goods_listBindingSource;
            this.goods_listBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.goods_listBindingNavigator.DeleteItem = null;
            this.goods_listBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.firstToolStripButton,
            this.prevToolStripButton,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.nextToolStripButton,
            this.lastToolStripButton,
            this.bindingNavigatorSeparator2,
            this.editToolStripButton,
            this.exitToolStripButton});
            this.goods_listBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.goods_listBindingNavigator.MoveFirstItem = this.firstToolStripButton;
            this.goods_listBindingNavigator.MoveLastItem = this.lastToolStripButton;
            this.goods_listBindingNavigator.MoveNextItem = this.nextToolStripButton;
            this.goods_listBindingNavigator.MovePreviousItem = this.prevToolStripButton;
            this.goods_listBindingNavigator.Name = "goods_listBindingNavigator";
            this.goods_listBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.goods_listBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.goods_listBindingNavigator.TabIndex = 0;
            this.goods_listBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // firstToolStripButton
            // 
            this.firstToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.firstToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("firstToolStripButton.Image")));
            this.firstToolStripButton.Name = "firstToolStripButton";
            this.firstToolStripButton.RightToLeftAutoMirrorImage = true;
            this.firstToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.firstToolStripButton.Text = "Move first";
            // 
            // prevToolStripButton
            // 
            this.prevToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.prevToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("prevToolStripButton.Image")));
            this.prevToolStripButton.Name = "prevToolStripButton";
            this.prevToolStripButton.RightToLeftAutoMirrorImage = true;
            this.prevToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.prevToolStripButton.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // nextToolStripButton
            // 
            this.nextToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.nextToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("nextToolStripButton.Image")));
            this.nextToolStripButton.Name = "nextToolStripButton";
            this.nextToolStripButton.RightToLeftAutoMirrorImage = true;
            this.nextToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.nextToolStripButton.Text = "Move next";
            // 
            // lastToolStripButton
            // 
            this.lastToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.lastToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("lastToolStripButton.Image")));
            this.lastToolStripButton.Name = "lastToolStripButton";
            this.lastToolStripButton.RightToLeftAutoMirrorImage = true;
            this.lastToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.lastToolStripButton.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // editToolStripButton
            // 
            this.editToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.editToolStripButton.Image = global::MarketApp_lsn.Properties.Resources.edit_button;
            this.editToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editToolStripButton.Name = "editToolStripButton";
            this.editToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.editToolStripButton.Text = "Edit";
            this.editToolStripButton.ToolTipText = "View/Add/Edit Record";
            this.editToolStripButton.Click += new System.EventHandler(this.EditToolStripButton_Click);
            // 
            // exitToolStripButton
            // 
            this.exitToolStripButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.exitToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.exitToolStripButton.Image = global::MarketApp_lsn.Properties.Resources.exit;
            this.exitToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.exitToolStripButton.Name = "exitToolStripButton";
            this.exitToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.exitToolStripButton.Text = "exitToolStripButton";
            this.exitToolStripButton.ToolTipText = "Exit Window";
            this.exitToolStripButton.Click += new System.EventHandler(this.ExitToolStripButton_Click);
            // 
            // goods_listDataGridView
            // 
            this.goods_listDataGridView.AllowUserToAddRows = false;
            this.goods_listDataGridView.AllowUserToDeleteRows = false;
            this.goods_listDataGridView.AutoGenerateColumns = false;
            this.goods_listDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.goods_listDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.goods_listDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._ID,
            this._goods_name,
            this._price,
            this._QTY,
            this._reg_date,
            this._comment});
            this.goods_listDataGridView.DataSource = this.goods_listBindingSource;
            this.goods_listDataGridView.Location = new System.Drawing.Point(7, 28);
            this.goods_listDataGridView.Name = "goods_listDataGridView";
            this.goods_listDataGridView.ReadOnly = true;
            this.goods_listDataGridView.Size = new System.Drawing.Size(788, 410);
            this.goods_listDataGridView.TabIndex = 1;
            // 
            // _ID
            // 
            this._ID.DataPropertyName = "id";
            this._ID.HeaderText = "ID";
            this._ID.Name = "_ID";
            this._ID.ReadOnly = true;
            this._ID.Width = 50;
            // 
            // _goods_name
            // 
            this._goods_name.DataPropertyName = "goods_name";
            this._goods_name.HeaderText = "Name";
            this._goods_name.Name = "_goods_name";
            this._goods_name.ReadOnly = true;
            this._goods_name.Width = 200;
            // 
            // _price
            // 
            this._price.DataPropertyName = "price";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N2";
            this._price.DefaultCellStyle = dataGridViewCellStyle1;
            this._price.HeaderText = "Price";
            this._price.Name = "_price";
            this._price.ReadOnly = true;
            this._price.Width = 75;
            // 
            // _QTY
            // 
            this._QTY.DataPropertyName = "QTY";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N0";
            this._QTY.DefaultCellStyle = dataGridViewCellStyle2;
            this._QTY.HeaderText = "Quantity";
            this._QTY.Name = "_QTY";
            this._QTY.ReadOnly = true;
            this._QTY.Width = 75;
            // 
            // _reg_date
            // 
            this._reg_date.DataPropertyName = "reg_date";
            this._reg_date.HeaderText = "Reg. Date";
            this._reg_date.Name = "_reg_date";
            this._reg_date.ReadOnly = true;
            // 
            // _comment
            // 
            this._comment.DataPropertyName = "comment";
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._comment.DefaultCellStyle = dataGridViewCellStyle3;
            this._comment.HeaderText = "Comment";
            this._comment.Name = "_comment";
            this._comment.ReadOnly = true;
            this._comment.Width = 200;
            // 
            // Method3Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.goods_listDataGridView);
            this.Controls.Add(this.goods_listBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Method3Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Method3Main";
            this.Load += new System.EventHandler(this.Method3Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.market)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goods_listBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goods_listBindingNavigator)).EndInit();
            this.goods_listBindingNavigator.ResumeLayout(false);
            this.goods_listBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.goods_listDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSets.Market market;
        private System.Windows.Forms.BindingSource goods_listBindingSource;
        private DataSets.MarketTableAdapters.goods_listTableAdapter goods_listTableAdapter;
        private DataSets.MarketTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator goods_listBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton firstToolStripButton;
        private System.Windows.Forms.ToolStripButton prevToolStripButton;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton nextToolStripButton;
        private System.Windows.Forms.ToolStripButton lastToolStripButton;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView goods_listDataGridView;
        private System.Windows.Forms.ToolStripButton editToolStripButton;
        private System.Windows.Forms.ToolStripButton exitToolStripButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn _ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn _goods_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn _price;
        private System.Windows.Forms.DataGridViewTextBoxColumn _QTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn _reg_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn _comment;
    }
}
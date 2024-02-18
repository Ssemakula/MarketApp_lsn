namespace MarketApp_lsn.Method2
{
    partial class Method2Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Method2Main));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.market = new MarketApp_lsn.DataSets.Market();
            this.goods_listBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.goods_listTableAdapter = new MarketApp_lsn.DataSets.MarketTableAdapters.goods_listTableAdapter();
            this.tableAdapterManager = new MarketApp_lsn.DataSets.MarketTableAdapters.TableAdapterManager();
            this.goods_listBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.editToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.deleteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.exitToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.goods_listDataGridView = new System.Windows.Forms.DataGridView();
            this._ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._RegDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._Comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.goods_listBindingSource.Sort = "";
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
            this.goods_listBindingNavigator.AutoSize = false;
            this.goods_listBindingNavigator.BindingSource = this.goods_listBindingSource;
            this.goods_listBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.goods_listBindingNavigator.DeleteItem = null;
            this.goods_listBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.newToolStripButton,
            this.editToolStripButton,
            this.deleteToolStripButton,
            this.exitToolStripButton});
            this.goods_listBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.goods_listBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.goods_listBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.goods_listBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.goods_listBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.goods_listBindingNavigator.Name = "goods_listBindingNavigator";
            this.goods_listBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.goods_listBindingNavigator.Size = new System.Drawing.Size(688, 44);
            this.goods_listBindingNavigator.TabIndex = 0;
            this.goods_listBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 41);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.AutoSize = false;
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 41);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 44);
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
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 44);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 41);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 41);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 44);
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newToolStripButton.Image = global::MarketApp_lsn.Properties.Resources.new_button;
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(23, 41);
            this.newToolStripButton.Text = "Edit";
            this.newToolStripButton.ToolTipText = "Add New Item";
            this.newToolStripButton.Click += new System.EventHandler(this.NewToolStripButton_Click);
            // 
            // editToolStripButton
            // 
            this.editToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.editToolStripButton.Image = global::MarketApp_lsn.Properties.Resources.edit_button;
            this.editToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editToolStripButton.Name = "editToolStripButton";
            this.editToolStripButton.Size = new System.Drawing.Size(23, 41);
            this.editToolStripButton.Text = "Edit";
            this.editToolStripButton.ToolTipText = "Edit Record";
            this.editToolStripButton.Click += new System.EventHandler(this.EditToolStripButton_Click);
            // 
            // deleteToolStripButton
            // 
            this.deleteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deleteToolStripButton.Image = global::MarketApp_lsn.Properties.Resources.Delete_butt;
            this.deleteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteToolStripButton.Name = "deleteToolStripButton";
            this.deleteToolStripButton.Size = new System.Drawing.Size(23, 41);
            this.deleteToolStripButton.Text = "deleteToolStripButton";
            this.deleteToolStripButton.ToolTipText = "Delete Item";
            this.deleteToolStripButton.Click += new System.EventHandler(this.DeleteToolStripButton_Click);
            // 
            // exitToolStripButton
            // 
            this.exitToolStripButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.exitToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.exitToolStripButton.Image = global::MarketApp_lsn.Properties.Resources.exit;
            this.exitToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.exitToolStripButton.Name = "exitToolStripButton";
            this.exitToolStripButton.Size = new System.Drawing.Size(23, 41);
            this.exitToolStripButton.Text = "exitToolStripButton";
            this.exitToolStripButton.ToolTipText = "Exit Window";
            this.exitToolStripButton.Click += new System.EventHandler(this.ExitToolStripButton_Click);
            // 
            // goods_listDataGridView
            // 
            this.goods_listDataGridView.AllowUserToAddRows = false;
            this.goods_listDataGridView.AllowUserToDeleteRows = false;
            this.goods_listDataGridView.AutoGenerateColumns = false;
            this.goods_listDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.goods_listDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._ID,
            this._Name,
            this._Quantity,
            this._Price,
            this._RegDate,
            this._Comment});
            this.goods_listDataGridView.DataSource = this.goods_listBindingSource;
            this.goods_listDataGridView.Location = new System.Drawing.Point(12, 47);
            this.goods_listDataGridView.Name = "goods_listDataGridView";
            this.goods_listDataGridView.ReadOnly = true;
            this.goods_listDataGridView.RowHeadersWidth = 25;
            this.goods_listDataGridView.Size = new System.Drawing.Size(668, 391);
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
            // _Name
            // 
            this._Name.DataPropertyName = "goods_name";
            this._Name.HeaderText = "Name";
            this._Name.Name = "_Name";
            this._Name.ReadOnly = true;
            this._Name.Width = 150;
            // 
            // _Quantity
            // 
            this._Quantity.DataPropertyName = "QTY";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.Format = "N0";
            this._Quantity.DefaultCellStyle = dataGridViewCellStyle9;
            this._Quantity.HeaderText = "Quantity";
            this._Quantity.Name = "_Quantity";
            this._Quantity.ReadOnly = true;
            this._Quantity.Width = 75;
            // 
            // _Price
            // 
            this._Price.DataPropertyName = "price";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle10.Format = "N2";
            this._Price.DefaultCellStyle = dataGridViewCellStyle10;
            this._Price.HeaderText = "Price";
            this._Price.Name = "_Price";
            this._Price.ReadOnly = true;
            this._Price.Width = 75;
            // 
            // _RegDate
            // 
            this._RegDate.DataPropertyName = "reg_date";
            this._RegDate.HeaderText = "Reg Date";
            this._RegDate.Name = "_RegDate";
            this._RegDate.ReadOnly = true;
            // 
            // _Comment
            // 
            this._Comment.DataPropertyName = "comment";
            this._Comment.HeaderText = "Comment";
            this._Comment.Name = "_Comment";
            this._Comment.ReadOnly = true;
            this._Comment.Width = 150;
            // 
            // Method2Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(688, 450);
            this.ControlBox = false;
            this.Controls.Add(this.goods_listDataGridView);
            this.Controls.Add(this.goods_listBindingNavigator);
            this.Name = "Method2Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Second Method (Main)";
            this.Load += new System.EventHandler(this.Method2Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.market)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goods_listBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goods_listBindingNavigator)).EndInit();
            this.goods_listBindingNavigator.ResumeLayout(false);
            this.goods_listBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.goods_listDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataSets.Market market;
        private System.Windows.Forms.BindingSource goods_listBindingSource;
        private DataSets.MarketTableAdapters.goods_listTableAdapter goods_listTableAdapter;
        private DataSets.MarketTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator goods_listBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView goods_listDataGridView;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton editToolStripButton;
        private System.Windows.Forms.ToolStripButton deleteToolStripButton;
        private System.Windows.Forms.ToolStripButton exitToolStripButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn _ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn _Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn _Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn _Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn _RegDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn _Comment;
    }
}
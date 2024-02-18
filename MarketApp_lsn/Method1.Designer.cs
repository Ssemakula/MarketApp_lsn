namespace MarketApp_lsn
{
    partial class Method1
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label goods_nameLabel;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label qTYLabel;
            System.Windows.Forms.Label reg_dateLabel;
            System.Windows.Forms.Label commentLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Method1));
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
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cancelToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.exitToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.goods_listDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.goods_nameTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.qTYTextBox = new System.Windows.Forms.TextBox();
            this.reg_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.commentTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            goods_nameLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            qTYLabel = new System.Windows.Forms.Label();
            reg_dateLabel = new System.Windows.Forms.Label();
            commentLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.market)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goods_listBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goods_listBindingNavigator)).BeginInit();
            this.goods_listBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.goods_listDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(24, 22);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(21, 13);
            idLabel.TabIndex = 0;
            idLabel.Text = "ID:";
            // 
            // goods_nameLabel
            // 
            goods_nameLabel.AutoSize = true;
            goods_nameLabel.Location = new System.Drawing.Point(196, 22);
            goods_nameLabel.Name = "goods_nameLabel";
            goods_nameLabel.Size = new System.Drawing.Size(63, 13);
            goods_nameLabel.TabIndex = 2;
            goods_nameLabel.Text = "Description:";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(271, 57);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(34, 13);
            priceLabel.TabIndex = 4;
            priceLabel.Text = "Price:";
            // 
            // qTYLabel
            // 
            qTYLabel.AutoSize = true;
            qTYLabel.Location = new System.Drawing.Point(24, 57);
            qTYLabel.Name = "qTYLabel";
            qTYLabel.Size = new System.Drawing.Size(49, 13);
            qTYLabel.TabIndex = 6;
            qTYLabel.Text = "Quantity:";
            // 
            // reg_dateLabel
            // 
            reg_dateLabel.AutoSize = true;
            reg_dateLabel.Location = new System.Drawing.Point(24, 84);
            reg_dateLabel.Name = "reg_dateLabel";
            reg_dateLabel.Size = new System.Drawing.Size(56, 13);
            reg_dateLabel.TabIndex = 8;
            reg_dateLabel.Text = "Reg Date:";
            // 
            // commentLabel
            // 
            commentLabel.AutoSize = true;
            commentLabel.Location = new System.Drawing.Point(24, 118);
            commentLabel.Name = "commentLabel";
            commentLabel.Size = new System.Drawing.Size(54, 13);
            commentLabel.TabIndex = 10;
            commentLabel.Text = "Comment:";
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
            this.goods_listBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
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
            this.saveToolStripButton,
            this.toolStripSeparator1,
            this.cancelToolStripButton,
            this.exitToolStripButton});
            this.goods_listBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.goods_listBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.goods_listBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.goods_listBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.goods_listBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.goods_listBindingNavigator.Name = "goods_listBindingNavigator";
            this.goods_listBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.goods_listBindingNavigator.Size = new System.Drawing.Size(524, 25);
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
            // bindingNavigatorMoveFirstItem
            // 
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
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
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
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
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
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newToolStripButton.Image = global::MarketApp_lsn.Properties.Resources.new_button;
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(23, 22);
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
            this.editToolStripButton.Size = new System.Drawing.Size(23, 22);
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
            this.deleteToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.deleteToolStripButton.Text = "deleteToolStripButton";
            this.deleteToolStripButton.ToolTipText = "Delete Item";
            this.deleteToolStripButton.Click += new System.EventHandler(this.DeleteToolStripButton_Click);
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveToolStripButton.Text = "Save Data";
            this.saveToolStripButton.ToolTipText = "Save Item";
            this.saveToolStripButton.Click += new System.EventHandler(this.goods_listBindingNavigatorSaveItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // cancelToolStripButton
            // 
            this.cancelToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cancelToolStripButton.Image = global::MarketApp_lsn.Properties.Resources.cancel_butt;
            this.cancelToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cancelToolStripButton.Name = "cancelToolStripButton";
            this.cancelToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.cancelToolStripButton.Text = "cancelToolStripButton";
            this.cancelToolStripButton.ToolTipText = "Cancel";
            this.cancelToolStripButton.Click += new System.EventHandler(this.CancelToolStripButton_Click);
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
            this.goods_listDataGridView.AllowUserToOrderColumns = true;
            this.goods_listDataGridView.AutoGenerateColumns = false;
            this.goods_listDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.goods_listDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.goods_listDataGridView.DataSource = this.goods_listBindingSource;
            this.goods_listDataGridView.Location = new System.Drawing.Point(11, 253);
            this.goods_listDataGridView.Name = "goods_listDataGridView";
            this.goods_listDataGridView.ReadOnly = true;
            this.goods_listDataGridView.RowHeadersWidth = 25;
            this.goods_listDataGridView.Size = new System.Drawing.Size(496, 181);
            this.goods_listDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "goods_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "goods_name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "price";
            this.dataGridViewTextBoxColumn3.HeaderText = "price";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 75;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "QTY";
            this.dataGridViewTextBoxColumn4.HeaderText = "QTY";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 75;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "reg_date";
            this.dataGridViewTextBoxColumn5.HeaderText = "reg_date";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "comment";
            this.dataGridViewTextBoxColumn6.HeaderText = "comment";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(idLabel);
            this.groupBox1.Controls.Add(this.idTextBox);
            this.groupBox1.Controls.Add(goods_nameLabel);
            this.groupBox1.Controls.Add(this.goods_nameTextBox);
            this.groupBox1.Controls.Add(priceLabel);
            this.groupBox1.Controls.Add(this.priceTextBox);
            this.groupBox1.Controls.Add(qTYLabel);
            this.groupBox1.Controls.Add(this.qTYTextBox);
            this.groupBox1.Controls.Add(reg_dateLabel);
            this.groupBox1.Controls.Add(this.reg_dateDateTimePicker);
            this.groupBox1.Controls.Add(commentLabel);
            this.groupBox1.Controls.Add(this.commentTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(495, 218);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.goods_listBindingSource, "id", true));
            this.idTextBox.Location = new System.Drawing.Point(98, 19);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(75, 20);
            this.idTextBox.TabIndex = 1;
            // 
            // goods_nameTextBox
            // 
            this.goods_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.goods_listBindingSource, "goods_name", true));
            this.goods_nameTextBox.Location = new System.Drawing.Point(270, 19);
            this.goods_nameTextBox.Name = "goods_nameTextBox";
            this.goods_nameTextBox.Size = new System.Drawing.Size(200, 20);
            this.goods_nameTextBox.TabIndex = 3;
            // 
            // priceTextBox
            // 
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.goods_listBindingSource, "price", true));
            this.priceTextBox.Location = new System.Drawing.Point(345, 54);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(125, 20);
            this.priceTextBox.TabIndex = 5;
            // 
            // qTYTextBox
            // 
            this.qTYTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.goods_listBindingSource, "QTY", true));
            this.qTYTextBox.Location = new System.Drawing.Point(98, 54);
            this.qTYTextBox.Name = "qTYTextBox";
            this.qTYTextBox.Size = new System.Drawing.Size(141, 20);
            this.qTYTextBox.TabIndex = 7;
            // 
            // reg_dateDateTimePicker
            // 
            this.reg_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.goods_listBindingSource, "reg_date", true));
            this.reg_dateDateTimePicker.Location = new System.Drawing.Point(98, 80);
            this.reg_dateDateTimePicker.Name = "reg_dateDateTimePicker";
            this.reg_dateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.reg_dateDateTimePicker.TabIndex = 9;
            // 
            // commentTextBox
            // 
            this.commentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.goods_listBindingSource, "comment", true));
            this.commentTextBox.Location = new System.Drawing.Point(98, 115);
            this.commentTextBox.Multiline = true;
            this.commentTextBox.Name = "commentTextBox";
            this.commentTextBox.Size = new System.Drawing.Size(372, 77);
            this.commentTextBox.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "label1";
            // 
            // Method1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 453);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.goods_listDataGridView);
            this.Controls.Add(this.goods_listBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Method1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "First Method";
            this.Load += new System.EventHandler(this.Method1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.market)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goods_listBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goods_listBindingNavigator)).EndInit();
            this.goods_listBindingNavigator.ResumeLayout(false);
            this.goods_listBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.goods_listDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.DataGridView goods_listDataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox goods_nameTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox qTYTextBox;
        private System.Windows.Forms.DateTimePicker reg_dateDateTimePicker;
        private System.Windows.Forms.TextBox commentTextBox;
        private System.Windows.Forms.ToolStripButton editToolStripButton;
        private System.Windows.Forms.ToolStripButton cancelToolStripButton;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton deleteToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton exitToolStripButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Label label1;
    }
}
namespace MarketApp_lsn.Method3
{
    partial class Method3Child
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Method3Child));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.market = new MarketApp_lsn.DataSets.Market();
            this.goods_listBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.goods_listTableAdapter = new MarketApp_lsn.DataSets.MarketTableAdapters.goods_listTableAdapter();
            this.tableAdapterManager = new MarketApp_lsn.DataSets.MarketTableAdapters.TableAdapterManager();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.goods_nameTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.qTYTextBox = new System.Windows.Forms.TextBox();
            this.reg_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.commentTextBox = new System.Windows.Forms.TextBox();
            this.childToolStrip = new System.Windows.Forms.ToolStrip();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.editToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.deleteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.cancelToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.exitToolStripButton = new System.Windows.Forms.ToolStripButton();
            idLabel = new System.Windows.Forms.Label();
            goods_nameLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            qTYLabel = new System.Windows.Forms.Label();
            reg_dateLabel = new System.Windows.Forms.Label();
            commentLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.market)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goods_listBindingSource)).BeginInit();
            this.childToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
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
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 377);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
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
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(82, 47);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(21, 13);
            idLabel.TabIndex = 0;
            idLabel.Text = "ID:";
            // 
            // idTextBox
            // 
            this.idTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.goods_listBindingSource, "id", true));
            this.idTextBox.Location = new System.Drawing.Point(105, 44);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(200, 20);
            this.idTextBox.TabIndex = 1;
            // 
            // goods_nameLabel
            // 
            goods_nameLabel.AutoSize = true;
            goods_nameLabel.Location = new System.Drawing.Point(31, 73);
            goods_nameLabel.Name = "goods_nameLabel";
            goods_nameLabel.Size = new System.Drawing.Size(72, 13);
            goods_nameLabel.TabIndex = 2;
            goods_nameLabel.Text = "Goods Name:";
            // 
            // goods_nameTextBox
            // 
            this.goods_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.goods_listBindingSource, "goods_name", true));
            this.goods_nameTextBox.Location = new System.Drawing.Point(105, 70);
            this.goods_nameTextBox.Name = "goods_nameTextBox";
            this.goods_nameTextBox.Size = new System.Drawing.Size(200, 20);
            this.goods_nameTextBox.TabIndex = 3;
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(69, 99);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(34, 13);
            priceLabel.TabIndex = 4;
            priceLabel.Text = "Price:";
            // 
            // priceTextBox
            // 
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.goods_listBindingSource, "price", true));
            this.priceTextBox.Location = new System.Drawing.Point(105, 96);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(200, 20);
            this.priceTextBox.TabIndex = 5;
            // 
            // qTYLabel
            // 
            qTYLabel.AutoSize = true;
            qTYLabel.Location = new System.Drawing.Point(54, 125);
            qTYLabel.Name = "qTYLabel";
            qTYLabel.Size = new System.Drawing.Size(49, 13);
            qTYLabel.TabIndex = 6;
            qTYLabel.Text = "Quantity:";
            // 
            // qTYTextBox
            // 
            this.qTYTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.goods_listBindingSource, "QTY", true));
            this.qTYTextBox.Location = new System.Drawing.Point(105, 122);
            this.qTYTextBox.Name = "qTYTextBox";
            this.qTYTextBox.Size = new System.Drawing.Size(200, 20);
            this.qTYTextBox.TabIndex = 7;
            // 
            // reg_dateLabel
            // 
            reg_dateLabel.AutoSize = true;
            reg_dateLabel.Location = new System.Drawing.Point(44, 152);
            reg_dateLabel.Name = "reg_dateLabel";
            reg_dateLabel.Size = new System.Drawing.Size(59, 13);
            reg_dateLabel.TabIndex = 8;
            reg_dateLabel.Text = "Reg. Date:";
            // 
            // reg_dateDateTimePicker
            // 
            this.reg_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.goods_listBindingSource, "reg_date", true));
            this.reg_dateDateTimePicker.Location = new System.Drawing.Point(105, 148);
            this.reg_dateDateTimePicker.Name = "reg_dateDateTimePicker";
            this.reg_dateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.reg_dateDateTimePicker.TabIndex = 9;
            // 
            // commentLabel
            // 
            commentLabel.AutoSize = true;
            commentLabel.Location = new System.Drawing.Point(34, 177);
            commentLabel.Name = "commentLabel";
            commentLabel.Size = new System.Drawing.Size(51, 13);
            commentLabel.TabIndex = 10;
            commentLabel.Text = "Comment";
            // 
            // commentTextBox
            // 
            this.commentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.goods_listBindingSource, "comment", true));
            this.commentTextBox.Location = new System.Drawing.Point(34, 193);
            this.commentTextBox.Multiline = true;
            this.commentTextBox.Name = "commentTextBox";
            this.commentTextBox.Size = new System.Drawing.Size(271, 172);
            this.commentTextBox.TabIndex = 11;
            // 
            // childToolStrip
            // 
            this.childToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.editToolStripButton,
            this.deleteToolStripButton,
            this.saveToolStripButton,
            this.cancelToolStripButton,
            this.exitToolStripButton});
            this.childToolStrip.Location = new System.Drawing.Point(0, 0);
            this.childToolStrip.Name = "childToolStrip";
            this.childToolStrip.Size = new System.Drawing.Size(380, 25);
            this.childToolStrip.TabIndex = 1;
            this.childToolStrip.Text = "toolStrip1";
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
            this.editToolStripButton.ToolTipText = "View/Add/Edit Record";
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
            this.saveToolStripButton.Click += new System.EventHandler(this.SaveToolStripButton_Click);
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
            // Method3Child
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 422);
            this.Controls.Add(this.childToolStrip);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Method3Child";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Entry";
            this.Load += new System.EventHandler(this.Method3Child_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.market)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goods_listBindingSource)).EndInit();
            this.childToolStrip.ResumeLayout(false);
            this.childToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DataSets.Market market;
        private System.Windows.Forms.BindingSource goods_listBindingSource;
        private DataSets.MarketTableAdapters.goods_listTableAdapter goods_listTableAdapter;
        private DataSets.MarketTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox goods_nameTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox qTYTextBox;
        private System.Windows.Forms.DateTimePicker reg_dateDateTimePicker;
        private System.Windows.Forms.TextBox commentTextBox;
        private System.Windows.Forms.ToolStrip childToolStrip;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton editToolStripButton;
        private System.Windows.Forms.ToolStripButton deleteToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton cancelToolStripButton;
        private System.Windows.Forms.ToolStripButton exitToolStripButton;
    }
}
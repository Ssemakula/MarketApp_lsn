namespace MarketApp_lsn.Method2
{
    partial class Method2Child
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Method2Child));
            this.infoGroupBox = new System.Windows.Forms.GroupBox();
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.cancelToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel = new System.Windows.Forms.ToolStripLabel();
            idLabel = new System.Windows.Forms.Label();
            goods_nameLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            qTYLabel = new System.Windows.Forms.Label();
            reg_dateLabel = new System.Windows.Forms.Label();
            commentLabel = new System.Windows.Forms.Label();
            this.infoGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.market)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goods_listBindingSource)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // infoGroupBox
            // 
            this.infoGroupBox.Controls.Add(idLabel);
            this.infoGroupBox.Controls.Add(this.idTextBox);
            this.infoGroupBox.Controls.Add(goods_nameLabel);
            this.infoGroupBox.Controls.Add(this.goods_nameTextBox);
            this.infoGroupBox.Controls.Add(priceLabel);
            this.infoGroupBox.Controls.Add(this.priceTextBox);
            this.infoGroupBox.Controls.Add(qTYLabel);
            this.infoGroupBox.Controls.Add(this.qTYTextBox);
            this.infoGroupBox.Controls.Add(reg_dateLabel);
            this.infoGroupBox.Controls.Add(this.reg_dateDateTimePicker);
            this.infoGroupBox.Controls.Add(commentLabel);
            this.infoGroupBox.Controls.Add(this.commentTextBox);
            this.infoGroupBox.Location = new System.Drawing.Point(12, 49);
            this.infoGroupBox.Name = "infoGroupBox";
            this.infoGroupBox.Size = new System.Drawing.Size(368, 299);
            this.infoGroupBox.TabIndex = 0;
            this.infoGroupBox.TabStop = false;
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
            idLabel.Location = new System.Drawing.Point(57, 23);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(21, 13);
            idLabel.TabIndex = 0;
            idLabel.Text = "ID:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.goods_listBindingSource, "id", true));
            this.idTextBox.Location = new System.Drawing.Point(84, 19);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(264, 20);
            this.idTextBox.TabIndex = 1;
            // 
            // goods_nameLabel
            // 
            goods_nameLabel.AutoSize = true;
            goods_nameLabel.Location = new System.Drawing.Point(6, 49);
            goods_nameLabel.Name = "goods_nameLabel";
            goods_nameLabel.Size = new System.Drawing.Size(72, 13);
            goods_nameLabel.TabIndex = 2;
            goods_nameLabel.Text = "Goods Name:";
            // 
            // goods_nameTextBox
            // 
            this.goods_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.goods_listBindingSource, "goods_name", true));
            this.goods_nameTextBox.Location = new System.Drawing.Point(84, 45);
            this.goods_nameTextBox.Name = "goods_nameTextBox";
            this.goods_nameTextBox.Size = new System.Drawing.Size(264, 20);
            this.goods_nameTextBox.TabIndex = 3;
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(44, 75);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(34, 13);
            priceLabel.TabIndex = 4;
            priceLabel.Text = "Price:";
            // 
            // priceTextBox
            // 
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.goods_listBindingSource, "price", true));
            this.priceTextBox.Location = new System.Drawing.Point(84, 71);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(264, 20);
            this.priceTextBox.TabIndex = 5;
            this.priceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // qTYLabel
            // 
            qTYLabel.AutoSize = true;
            qTYLabel.Location = new System.Drawing.Point(29, 101);
            qTYLabel.Name = "qTYLabel";
            qTYLabel.Size = new System.Drawing.Size(49, 13);
            qTYLabel.TabIndex = 6;
            qTYLabel.Text = "Quantity:";
            // 
            // qTYTextBox
            // 
            this.qTYTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.goods_listBindingSource, "QTY", true));
            this.qTYTextBox.Location = new System.Drawing.Point(84, 97);
            this.qTYTextBox.Name = "qTYTextBox";
            this.qTYTextBox.Size = new System.Drawing.Size(264, 20);
            this.qTYTextBox.TabIndex = 7;
            this.qTYTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // reg_dateLabel
            // 
            reg_dateLabel.AutoSize = true;
            reg_dateLabel.Location = new System.Drawing.Point(19, 127);
            reg_dateLabel.Name = "reg_dateLabel";
            reg_dateLabel.Size = new System.Drawing.Size(59, 13);
            reg_dateLabel.TabIndex = 8;
            reg_dateLabel.Text = "Reg. Date:";
            // 
            // reg_dateDateTimePicker
            // 
            this.reg_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.goods_listBindingSource, "reg_date", true));
            this.reg_dateDateTimePicker.Location = new System.Drawing.Point(84, 123);
            this.reg_dateDateTimePicker.Name = "reg_dateDateTimePicker";
            this.reg_dateDateTimePicker.Size = new System.Drawing.Size(264, 20);
            this.reg_dateDateTimePicker.TabIndex = 9;
            // 
            // commentLabel
            // 
            commentLabel.AutoSize = true;
            commentLabel.Location = new System.Drawing.Point(24, 149);
            commentLabel.Name = "commentLabel";
            commentLabel.Size = new System.Drawing.Size(54, 13);
            commentLabel.TabIndex = 10;
            commentLabel.Text = "Comment:";
            // 
            // commentTextBox
            // 
            this.commentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.goods_listBindingSource, "comment", true));
            this.commentTextBox.Location = new System.Drawing.Point(84, 149);
            this.commentTextBox.Multiline = true;
            this.commentTextBox.Name = "commentTextBox";
            this.commentTextBox.Size = new System.Drawing.Size(264, 132);
            this.commentTextBox.TabIndex = 11;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripButton,
            this.cancelToolStripButton,
            this.toolStripLabel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(395, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveToolStripButton.Text = "Save Data";
            this.saveToolStripButton.ToolTipText = "Save Item";
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
            // 
            // toolStripLabel
            // 
            this.toolStripLabel.Name = "toolStripLabel";
            this.toolStripLabel.Size = new System.Drawing.Size(42, 22);
            this.toolStripLabel.Text = "Status:";
            // 
            // Method2Child
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(395, 356);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.infoGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Method2Child";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Child Form";
            this.Load += new System.EventHandler(this.Method2Child_Load);
            this.infoGroupBox.ResumeLayout(false);
            this.infoGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.market)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goods_listBindingSource)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox infoGroupBox;
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
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton cancelToolStripButton;
        public System.Windows.Forms.ToolStripLabel toolStripLabel;
    }
}
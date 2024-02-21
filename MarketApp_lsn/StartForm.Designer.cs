namespace MarketApp_lsn
{
    partial class StartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.startToolStrip = new System.Windows.Forms.ToolStrip();
            this.m1_toolstripButton = new System.Windows.Forms.ToolStripButton();
            this.m2_toolstripButton = new System.Windows.Forms.ToolStripButton();
            this.m3_toolstripButton = new System.Windows.Forms.ToolStripButton();
            this.exitToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.startToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // startToolStrip
            // 
            this.startToolStrip.AutoSize = false;
            this.startToolStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m1_toolstripButton,
            this.m2_toolstripButton,
            this.m3_toolstripButton,
            this.exitToolStripButton});
            this.startToolStrip.Location = new System.Drawing.Point(0, 0);
            this.startToolStrip.Name = "startToolStrip";
            this.startToolStrip.Size = new System.Drawing.Size(351, 160);
            this.startToolStrip.TabIndex = 0;
            // 
            // m1_toolstripButton
            // 
            this.m1_toolstripButton.AutoSize = false;
            this.m1_toolstripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.m1_toolstripButton.Image = ((System.Drawing.Image)(resources.GetObject("m1_toolstripButton.Image")));
            this.m1_toolstripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.m1_toolstripButton.Name = "m1_toolstripButton";
            this.m1_toolstripButton.Size = new System.Drawing.Size(62, 40);
            this.m1_toolstripButton.Text = "Method 1";
            this.m1_toolstripButton.Click += new System.EventHandler(this.M1_toolstripButton_Click);
            // 
            // m2_toolstripButton
            // 
            this.m2_toolstripButton.AutoSize = false;
            this.m2_toolstripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.m2_toolstripButton.Image = ((System.Drawing.Image)(resources.GetObject("m2_toolstripButton.Image")));
            this.m2_toolstripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.m2_toolstripButton.Name = "m2_toolstripButton";
            this.m2_toolstripButton.Size = new System.Drawing.Size(62, 40);
            this.m2_toolstripButton.Text = "Method 2";
            this.m2_toolstripButton.Click += new System.EventHandler(this.M2_toolstripButton_Click);
            // 
            // m3_toolstripButton
            // 
            this.m3_toolstripButton.AutoSize = false;
            this.m3_toolstripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.m3_toolstripButton.Image = ((System.Drawing.Image)(resources.GetObject("m3_toolstripButton.Image")));
            this.m3_toolstripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.m3_toolstripButton.Name = "m3_toolstripButton";
            this.m3_toolstripButton.Size = new System.Drawing.Size(62, 40);
            this.m3_toolstripButton.Text = "Method 3";
            this.m3_toolstripButton.Click += new System.EventHandler(this.M3_toolstripButton_Click);
            // 
            // exitToolStripButton
            // 
            this.exitToolStripButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.exitToolStripButton.AutoSize = false;
            this.exitToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.exitToolStripButton.Image = global::MarketApp_lsn.Properties.Resources.exit;
            this.exitToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.exitToolStripButton.Name = "exitToolStripButton";
            this.exitToolStripButton.Size = new System.Drawing.Size(23, 40);
            this.exitToolStripButton.Text = "Exit";
            this.exitToolStripButton.Click += new System.EventHandler(this.exitToolStripButton_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 160);
            this.Controls.Add(this.startToolStrip);
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Start";
            this.startToolStrip.ResumeLayout(false);
            this.startToolStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip startToolStrip;
        private System.Windows.Forms.ToolStripButton m1_toolstripButton;
        private System.Windows.Forms.ToolStripButton m2_toolstripButton;
        private System.Windows.Forms.ToolStripButton m3_toolstripButton;
        private System.Windows.Forms.ToolStripButton exitToolStripButton;
    }
}


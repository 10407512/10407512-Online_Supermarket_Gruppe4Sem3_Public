namespace DesktopApp
{
    partial class OrderOverviewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderOverviewForm));
            this.pnlOrderOverview = new System.Windows.Forms.Panel();
            this.cklOrders = new System.Windows.Forms.CheckedListBox();
            this.lblOrderOverview = new System.Windows.Forms.Label();
            this.picBackArrow = new System.Windows.Forms.PictureBox();
            this.btnHandleOrder = new System.Windows.Forms.Button();
            this.pnlOrderOverview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBackArrow)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlOrderOverview
            // 
            this.pnlOrderOverview.Controls.Add(this.btnHandleOrder);
            this.pnlOrderOverview.Controls.Add(this.picBackArrow);
            this.pnlOrderOverview.Controls.Add(this.lblOrderOverview);
            this.pnlOrderOverview.Controls.Add(this.cklOrders);
            this.pnlOrderOverview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOrderOverview.Location = new System.Drawing.Point(0, 0);
            this.pnlOrderOverview.Name = "pnlOrderOverview";
            this.pnlOrderOverview.Size = new System.Drawing.Size(800, 450);
            this.pnlOrderOverview.TabIndex = 0;
            // 
            // cklOrders
            // 
            this.cklOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cklOrders.FormattingEnabled = true;
            this.cklOrders.Location = new System.Drawing.Point(12, 65);
            this.cklOrders.Name = "cklOrders";
            this.cklOrders.ScrollAlwaysVisible = true;
            this.cklOrders.Size = new System.Drawing.Size(776, 334);
            this.cklOrders.TabIndex = 0;
            // 
            // lblOrderOverview
            // 
            this.lblOrderOverview.AutoSize = true;
            this.lblOrderOverview.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOrderOverview.Location = new System.Drawing.Point(294, 9);
            this.lblOrderOverview.Name = "lblOrderOverview";
            this.lblOrderOverview.Size = new System.Drawing.Size(214, 41);
            this.lblOrderOverview.TabIndex = 1;
            this.lblOrderOverview.Text = "Ordre Oversigt";
            // 
            // picBackArrow
            // 
            this.picBackArrow.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.picBackArrow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBackArrow.BackgroundImage")));
            this.picBackArrow.Location = new System.Drawing.Point(12, 9);
            this.picBackArrow.Name = "picBackArrow";
            this.picBackArrow.Size = new System.Drawing.Size(44, 37);
            this.picBackArrow.TabIndex = 3;
            this.picBackArrow.TabStop = false;
            // 
            // btnHandleOrder
            // 
            this.btnHandleOrder.Location = new System.Drawing.Point(654, 409);
            this.btnHandleOrder.Name = "btnHandleOrder";
            this.btnHandleOrder.Size = new System.Drawing.Size(134, 29);
            this.btnHandleOrder.TabIndex = 4;
            this.btnHandleOrder.Text = "Behandl ordre";
            this.btnHandleOrder.UseVisualStyleBackColor = true;
            this.btnHandleOrder.Click += new System.EventHandler(this.btnHandleOrder_Click);
            // 
            // OrderOverviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlOrderOverview);
            this.Name = "OrderOverviewForm";
            this.Text = "OrderForm";
            this.pnlOrderOverview.ResumeLayout(false);
            this.pnlOrderOverview.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBackArrow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlOrderOverview;
        private CheckedListBox cklOrders;
        private Label lblOrderOverview;
        private PictureBox picBackArrow;
        private Button btnHandleOrder;
    }
}
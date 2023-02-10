namespace DesktopApp
{
    partial class OrderDetailsForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lvwOrderLines = new System.Windows.Forms.ListView();
            this.BarcodeHead = new System.Windows.Forms.ColumnHeader();
            this.NameHead = new System.Windows.Forms.ColumnHeader();
            this.BrandHead = new System.Windows.Forms.ColumnHeader();
            this.QuantityHead = new System.Windows.Forms.ColumnHeader();
            this.DescriptionHead = new System.Windows.Forms.ColumnHeader();
            this.btnDone = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblOrderNumber = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lvwOrderLines);
            this.panel1.Controls.Add(this.btnDone);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.lblOrderNumber);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // lvwOrderLines
            // 
            this.lvwOrderLines.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.BarcodeHead,
            this.NameHead,
            this.BrandHead,
            this.QuantityHead,
            this.DescriptionHead});
            this.lvwOrderLines.GridLines = true;
            this.lvwOrderLines.Location = new System.Drawing.Point(27, 80);
            this.lvwOrderLines.Name = "lvwOrderLines";
            this.lvwOrderLines.Size = new System.Drawing.Size(747, 312);
            this.lvwOrderLines.TabIndex = 4;
            this.lvwOrderLines.UseCompatibleStateImageBehavior = false;
            // 
            // BarcodeHead
            // 
            this.BarcodeHead.Text = "Barcode";
            // 
            // NameHead
            // 
            this.NameHead.Text = "Name";
            // 
            // BrandHead
            // 
            this.BrandHead.Text = "Brand";
            // 
            // QuantityHead
            // 
            this.QuantityHead.Text = "Quantity";
            // 
            // DescriptionHead
            // 
            this.DescriptionHead.Text = "Description";
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(637, 409);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(137, 29);
            this.btnDone.TabIndex = 3;
            this.btnDone.Text = "Færdigbehandlet";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(418, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(187, 27);
            this.textBox1.TabIndex = 2;
            // 
            // lblOrderNumber
            // 
            this.lblOrderNumber.AutoSize = true;
            this.lblOrderNumber.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOrderNumber.Location = new System.Drawing.Point(198, 17);
            this.lblOrderNumber.Name = "lblOrderNumber";
            this.lblOrderNumber.Size = new System.Drawing.Size(214, 41);
            this.lblOrderNumber.TabIndex = 1;
            this.lblOrderNumber.Text = "Ordrenummer:";
            // 
            // OrderDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "OrderDetailsForm";
            this.Text = "OrderDetailsForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button btnDone;
        private TextBox textBox1;
        private Label lblOrderNumber;
        private ListView lvwOrderLines;
        private ColumnHeader BarcodeHead;
        private ColumnHeader NameHead;
        private ColumnHeader BrandHead;
        private ColumnHeader QuantityHead;
        private ColumnHeader DescriptionHead;
    }
}
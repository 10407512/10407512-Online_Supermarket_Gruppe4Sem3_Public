namespace DesktopApp
{
    partial class UpdateProductForm
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
            this.pnlUpdateProduct = new System.Windows.Forms.Panel();
            this.splUpdateProduct = new System.Windows.Forms.SplitContainer();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.lblBarcode = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.lblBrand = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnAddImage = new System.Windows.Forms.Button();
            this.txtImage = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblUpdateProduct = new System.Windows.Forms.Label();
            this.pnlUpdateProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splUpdateProduct)).BeginInit();
            this.splUpdateProduct.Panel1.SuspendLayout();
            this.splUpdateProduct.Panel2.SuspendLayout();
            this.splUpdateProduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlUpdateProduct
            // 
            this.pnlUpdateProduct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlUpdateProduct.Controls.Add(this.splUpdateProduct);
            this.pnlUpdateProduct.Controls.Add(this.btnCancel);
            this.pnlUpdateProduct.Controls.Add(this.btnUpdate);
            this.pnlUpdateProduct.Controls.Add(this.lblUpdateProduct);
            this.pnlUpdateProduct.Location = new System.Drawing.Point(0, 0);
            this.pnlUpdateProduct.Name = "pnlUpdateProduct";
            this.pnlUpdateProduct.Size = new System.Drawing.Size(800, 450);
            this.pnlUpdateProduct.TabIndex = 0;
            // 
            // splUpdateProduct
            // 
            this.splUpdateProduct.Location = new System.Drawing.Point(0, 64);
            this.splUpdateProduct.Name = "splUpdateProduct";
            // 
            // splUpdateProduct.Panel1
            // 
            this.splUpdateProduct.Panel1.Controls.Add(this.txtBarcode);
            this.splUpdateProduct.Panel1.Controls.Add(this.lblBarcode);
            this.splUpdateProduct.Panel1.Controls.Add(this.txtStock);
            this.splUpdateProduct.Panel1.Controls.Add(this.lblStock);
            this.splUpdateProduct.Panel1.Controls.Add(this.txtPrice);
            this.splUpdateProduct.Panel1.Controls.Add(this.lblPrice);
            this.splUpdateProduct.Panel1.Controls.Add(this.txtBrand);
            this.splUpdateProduct.Panel1.Controls.Add(this.lblBrand);
            this.splUpdateProduct.Panel1.Controls.Add(this.txtName);
            this.splUpdateProduct.Panel1.Controls.Add(this.lblName);
            // 
            // splUpdateProduct.Panel2
            // 
            this.splUpdateProduct.Panel2.Controls.Add(this.btnAddImage);
            this.splUpdateProduct.Panel2.Controls.Add(this.txtImage);
            this.splUpdateProduct.Panel2.Controls.Add(this.txtDescription);
            this.splUpdateProduct.Panel2.Controls.Add(this.lblDescription);
            this.splUpdateProduct.Size = new System.Drawing.Size(800, 339);
            this.splUpdateProduct.SplitterDistance = 266;
            this.splUpdateProduct.TabIndex = 3;
            // 
            // txtBarcode
            // 
            this.txtBarcode.Location = new System.Drawing.Point(12, 302);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(125, 27);
            this.txtBarcode.TabIndex = 9;
            // 
            // lblBarcode
            // 
            this.lblBarcode.AutoSize = true;
            this.lblBarcode.Location = new System.Drawing.Point(12, 279);
            this.lblBarcode.Name = "lblBarcode";
            this.lblBarcode.Size = new System.Drawing.Size(77, 20);
            this.lblBarcode.TabIndex = 8;
            this.lblBarcode.Text = "Stregkode";
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(12, 239);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(125, 27);
            this.txtStock.TabIndex = 7;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(12, 216);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(122, 20);
            this.lblStock.TabIndex = 6;
            this.lblStock.Text = "Lagerbeholdning";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(12, 168);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(125, 27);
            this.txtPrice.TabIndex = 5;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(12, 145);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(32, 20);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Pris";
            // 
            // txtBrand
            // 
            this.txtBrand.Location = new System.Drawing.Point(12, 102);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(125, 27);
            this.txtBrand.TabIndex = 3;
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Location = new System.Drawing.Point(12, 79);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(54, 20);
            this.lblBrand.TabIndex = 2;
            this.lblBrand.Text = "Mærke";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(12, 35);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(125, 27);
            this.txtName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 12);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(43, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Navn";
            // 
            // btnAddImage
            // 
            this.btnAddImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddImage.Location = new System.Drawing.Point(387, 132);
            this.btnAddImage.Name = "btnAddImage";
            this.btnAddImage.Size = new System.Drawing.Size(119, 30);
            this.btnAddImage.TabIndex = 13;
            this.btnAddImage.Text = "Tilføj billede";
            this.btnAddImage.UseVisualStyleBackColor = true;
            // 
            // txtImage
            // 
            this.txtImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtImage.Location = new System.Drawing.Point(21, 31);
            this.txtImage.Multiline = true;
            this.txtImage.Name = "txtImage";
            this.txtImage.Size = new System.Drawing.Size(485, 100);
            this.txtImage.TabIndex = 12;
            this.txtImage.Text = "*Placeholder for billede*";
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDescription.Location = new System.Drawing.Point(21, 216);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(485, 113);
            this.txtDescription.TabIndex = 11;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(21, 197);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(81, 20);
            this.lblDescription.TabIndex = 10;
            this.lblDescription.Text = "Beskrivelse";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(694, 409);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 29);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Annuller";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.Location = new System.Drawing.Point(604, 408);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(83, 30);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Opdater";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // lblUpdateProduct
            // 
            this.lblUpdateProduct.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblUpdateProduct.AutoSize = true;
            this.lblUpdateProduct.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUpdateProduct.Location = new System.Drawing.Point(313, 9);
            this.lblUpdateProduct.Name = "lblUpdateProduct";
            this.lblUpdateProduct.Size = new System.Drawing.Size(195, 41);
            this.lblUpdateProduct.TabIndex = 0;
            this.lblUpdateProduct.Text = "Opdater Produkt";
            // 
            // UpdateProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlUpdateProduct);
            this.Name = "UpdateProductForm";
            this.Text = "UpdateProductForm";
            this.pnlUpdateProduct.ResumeLayout(false);
            this.pnlUpdateProduct.PerformLayout();
            this.splUpdateProduct.Panel1.ResumeLayout(false);
            this.splUpdateProduct.Panel1.PerformLayout();
            this.splUpdateProduct.Panel2.ResumeLayout(false);
            this.splUpdateProduct.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splUpdateProduct)).EndInit();
            this.splUpdateProduct.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlUpdateProduct;
        private Label lblUpdateProduct;
        private SplitContainer splUpdateProduct;
        private TextBox txtBarcode;
        private Label lblBarcode;
        private TextBox txtStock;
        private Label lblStock;
        private TextBox txtPrice;
        private Label lblPrice;
        private TextBox txtBrand;
        private Label lblBrand;
        private TextBox txtName;
        private Label lblName;
        private Button btnCancel;
        private Button btnUpdate;
        private TextBox txtDescription;
        private Label lblDescription;
        private Button btnAddImage;
        private TextBox txtImage;
    }
}
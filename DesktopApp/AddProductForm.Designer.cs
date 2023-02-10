namespace DesktopApp
{
    partial class AddProductForm
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
            this.pnlAddProduct = new System.Windows.Forms.Panel();
            this.splAddProduct = new System.Windows.Forms.SplitContainer();
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblAddProduct = new System.Windows.Forms.Label();
            this.pnlAddProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splAddProduct)).BeginInit();
            this.splAddProduct.Panel1.SuspendLayout();
            this.splAddProduct.Panel2.SuspendLayout();
            this.splAddProduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAddProduct
            // 
            this.pnlAddProduct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAddProduct.Controls.Add(this.splAddProduct);
            this.pnlAddProduct.Controls.Add(this.btnCancel);
            this.pnlAddProduct.Controls.Add(this.btnAdd);
            this.pnlAddProduct.Controls.Add(this.lblAddProduct);
            this.pnlAddProduct.Location = new System.Drawing.Point(0, 0);
            this.pnlAddProduct.Name = "pnlAddProduct";
            this.pnlAddProduct.Size = new System.Drawing.Size(800, 450);
            this.pnlAddProduct.TabIndex = 0;
            // 
            // splAddProduct
            // 
            this.splAddProduct.Location = new System.Drawing.Point(0, 64);
            this.splAddProduct.Name = "splAddProduct";
            // 
            // splAddProduct.Panel1
            // 
            this.splAddProduct.Panel1.Controls.Add(this.txtBarcode);
            this.splAddProduct.Panel1.Controls.Add(this.lblBarcode);
            this.splAddProduct.Panel1.Controls.Add(this.txtStock);
            this.splAddProduct.Panel1.Controls.Add(this.lblStock);
            this.splAddProduct.Panel1.Controls.Add(this.txtPrice);
            this.splAddProduct.Panel1.Controls.Add(this.lblPrice);
            this.splAddProduct.Panel1.Controls.Add(this.txtBrand);
            this.splAddProduct.Panel1.Controls.Add(this.lblBrand);
            this.splAddProduct.Panel1.Controls.Add(this.txtName);
            this.splAddProduct.Panel1.Controls.Add(this.lblName);
            // 
            // splAddProduct.Panel2
            // 
            this.splAddProduct.Panel2.Controls.Add(this.btnAddImage);
            this.splAddProduct.Panel2.Controls.Add(this.txtImage);
            this.splAddProduct.Panel2.Controls.Add(this.txtDescription);
            this.splAddProduct.Panel2.Controls.Add(this.lblDescription);
            this.splAddProduct.Size = new System.Drawing.Size(800, 339);
            this.splAddProduct.SplitterDistance = 266;
            this.splAddProduct.TabIndex = 3;
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
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(604, 408);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(83, 30);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Tilføj";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // lblAddProduct
            // 
            this.lblAddProduct.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAddProduct.AutoSize = true;
            this.lblAddProduct.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAddProduct.Location = new System.Drawing.Point(313, 9);
            this.lblAddProduct.Name = "lblAddProduct";
            this.lblAddProduct.Size = new System.Drawing.Size(195, 41);
            this.lblAddProduct.TabIndex = 0;
            this.lblAddProduct.Text = "Tilføj Produkt";
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlAddProduct);
            this.Name = "AddProductForm";
            this.Text = "AddProductForm";
            this.pnlAddProduct.ResumeLayout(false);
            this.pnlAddProduct.PerformLayout();
            this.splAddProduct.Panel1.ResumeLayout(false);
            this.splAddProduct.Panel1.PerformLayout();
            this.splAddProduct.Panel2.ResumeLayout(false);
            this.splAddProduct.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splAddProduct)).EndInit();
            this.splAddProduct.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlAddProduct;
        private Label lblAddProduct;
        private SplitContainer splAddProduct;
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
        private Button btnAdd;
        private TextBox txtDescription;
        private Label lblDescription;
        private Button btnAddImage;
        private TextBox txtImage;
    }
}
namespace DesktopApp
{
    partial class ProductMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductMenuForm));
            this.pnlProductMenu = new System.Windows.Forms.Panel();
            this.picSearchLoop = new System.Windows.Forms.PictureBox();
            this.pnlSearchAndList = new System.Windows.Forms.Panel();
            this.cklProduct = new System.Windows.Forms.CheckedListBox();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnUpdateProduct = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.cmbSearchProduct = new System.Windows.Forms.ComboBox();
            this.picBackArrow = new System.Windows.Forms.PictureBox();
            this.lblProductMenu = new System.Windows.Forms.Label();
            this.pnlProductMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSearchLoop)).BeginInit();
            this.pnlSearchAndList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBackArrow)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlProductMenu
            // 
            this.pnlProductMenu.Controls.Add(this.picSearchLoop);
            this.pnlProductMenu.Controls.Add(this.pnlSearchAndList);
            this.pnlProductMenu.Controls.Add(this.picBackArrow);
            this.pnlProductMenu.Controls.Add(this.lblProductMenu);
            this.pnlProductMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlProductMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlProductMenu.Name = "pnlProductMenu";
            this.pnlProductMenu.Size = new System.Drawing.Size(800, 450);
            this.pnlProductMenu.TabIndex = 0;
            // 
            // picSearchLoop
            // 
            this.picSearchLoop.BackColor = System.Drawing.SystemColors.Window;
            this.picSearchLoop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picSearchLoop.Enabled = false;
            this.picSearchLoop.Image = ((System.Drawing.Image)(resources.GetObject("picSearchLoop.Image")));
            this.picSearchLoop.Location = new System.Drawing.Point(43, 77);
            this.picSearchLoop.Name = "picSearchLoop";
            this.picSearchLoop.Size = new System.Drawing.Size(48, 28);
            this.picSearchLoop.TabIndex = 1;
            this.picSearchLoop.TabStop = false;
            // 
            // pnlSearchAndList
            // 
            this.pnlSearchAndList.Controls.Add(this.cklProduct);
            this.pnlSearchAndList.Controls.Add(this.btnDeleteProduct);
            this.pnlSearchAndList.Controls.Add(this.btnUpdateProduct);
            this.pnlSearchAndList.Controls.Add(this.btnAddProduct);
            this.pnlSearchAndList.Controls.Add(this.cmbSearchProduct);
            this.pnlSearchAndList.Location = new System.Drawing.Point(43, 77);
            this.pnlSearchAndList.Name = "pnlSearchAndList";
            this.pnlSearchAndList.Size = new System.Drawing.Size(709, 343);
            this.pnlSearchAndList.TabIndex = 3;
            // 
            // cklProduct
            // 
            this.cklProduct.FormattingEnabled = true;
            this.cklProduct.Location = new System.Drawing.Point(0, 34);
            this.cklProduct.Name = "cklProduct";
            this.cklProduct.ScrollAlwaysVisible = true;
            this.cklProduct.Size = new System.Drawing.Size(709, 268);
            this.cklProduct.TabIndex = 4;
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Location = new System.Drawing.Point(597, 309);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(109, 29);
            this.btnDeleteProduct.TabIndex = 3;
            this.btnDeleteProduct.Text = "Slet produkt";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.Location = new System.Drawing.Point(135, 309);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Size = new System.Drawing.Size(129, 29);
            this.btnUpdateProduct.TabIndex = 0;
            this.btnUpdateProduct.Text = "Opdater produkt";
            this.btnUpdateProduct.UseVisualStyleBackColor = true;
            this.btnUpdateProduct.Click += new System.EventHandler(this.btnUpdateProduct_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(3, 309);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(126, 30);
            this.btnAddProduct.TabIndex = 2;
            this.btnAddProduct.Text = "Tilføj produkt";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // cmbSearchProduct
            // 
            this.cmbSearchProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbSearchProduct.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbSearchProduct.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSearchProduct.FormattingEnabled = true;
            this.cmbSearchProduct.Location = new System.Drawing.Point(48, 0);
            this.cmbSearchProduct.Name = "cmbSearchProduct";
            this.cmbSearchProduct.Size = new System.Drawing.Size(661, 28);
            this.cmbSearchProduct.TabIndex = 0;
            // 
            // picBackArrow
            // 
            this.picBackArrow.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.picBackArrow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBackArrow.BackgroundImage")));
            this.picBackArrow.Location = new System.Drawing.Point(12, 9);
            this.picBackArrow.Name = "picBackArrow";
            this.picBackArrow.Size = new System.Drawing.Size(44, 37);
            this.picBackArrow.TabIndex = 2;
            this.picBackArrow.TabStop = false;
            this.picBackArrow.Click += new System.EventHandler(this.picBackArrow_Click);
            // 
            // lblProductMenu
            // 
            this.lblProductMenu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblProductMenu.AutoSize = true;
            this.lblProductMenu.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProductMenu.Location = new System.Drawing.Point(295, 9);
            this.lblProductMenu.Name = "lblProductMenu";
            this.lblProductMenu.Size = new System.Drawing.Size(208, 41);
            this.lblProductMenu.TabIndex = 0;
            this.lblProductMenu.Text = "Produkt Menu";
            this.lblProductMenu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ProductMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlProductMenu);
            this.Name = "ProductMenuForm";
            this.Text = "ProductMenuForm";
            this.pnlProductMenu.ResumeLayout(false);
            this.pnlProductMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSearchLoop)).EndInit();
            this.pnlSearchAndList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBackArrow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlProductMenu;
        private Label lblProductMenu;
        private PictureBox picBackArrow;
        private Panel pnlSearchAndList;
        private ComboBox cmbSearchProduct;
        private PictureBox picSearchLoop;
        private Button btnDeleteProduct;
        private Button btnUpdateProduct;
        private Button btnAddProduct;
        private CheckedListBox cklProduct;
    }
}
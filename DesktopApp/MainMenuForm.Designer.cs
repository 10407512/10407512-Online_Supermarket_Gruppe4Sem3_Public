namespace DesktopApp
{
    partial class MainMenuForm
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
            this.pnlMainMenu = new System.Windows.Forms.Panel();
            this.lblMainMenu = new System.Windows.Forms.Label();
            this.BtnOrderMenu = new System.Windows.Forms.Button();
            this.btnProductMenu = new System.Windows.Forms.Button();
            this.pnlMainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMainMenu
            // 
            this.pnlMainMenu.Controls.Add(this.lblMainMenu);
            this.pnlMainMenu.Controls.Add(this.BtnOrderMenu);
            this.pnlMainMenu.Controls.Add(this.btnProductMenu);
            this.pnlMainMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMainMenu.Name = "pnlMainMenu";
            this.pnlMainMenu.Size = new System.Drawing.Size(800, 451);
            this.pnlMainMenu.TabIndex = 0;
            // 
            // lblMainMenu
            // 
            this.lblMainMenu.AutoSize = true;
            this.lblMainMenu.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMainMenu.Location = new System.Drawing.Point(275, 84);
            this.lblMainMenu.Name = "lblMainMenu";
            this.lblMainMenu.Size = new System.Drawing.Size(253, 57);
            this.lblMainMenu.TabIndex = 2;
            this.lblMainMenu.Text = "Hovedmenu";
            // 
            // BtnOrderMenu
            // 
            this.BtnOrderMenu.Location = new System.Drawing.Point(321, 233);
            this.BtnOrderMenu.Name = "BtnOrderMenu";
            this.BtnOrderMenu.Size = new System.Drawing.Size(143, 43);
            this.BtnOrderMenu.TabIndex = 1;
            this.BtnOrderMenu.Text = "Ordreoversigt";
            this.BtnOrderMenu.UseVisualStyleBackColor = true;
            this.BtnOrderMenu.Click += new System.EventHandler(this.btnOrderOverview_Click);
            // 
            // btnProductMenu
            // 
            this.btnProductMenu.Location = new System.Drawing.Point(321, 187);
            this.btnProductMenu.Name = "btnProductMenu";
            this.btnProductMenu.Size = new System.Drawing.Size(143, 41);
            this.btnProductMenu.TabIndex = 0;
            this.btnProductMenu.Text = "Produkt Menu";
            this.btnProductMenu.UseVisualStyleBackColor = true;
            this.btnProductMenu.Click += new System.EventHandler(this.btnProductMenu_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.pnlMainMenu);
            this.Name = "MainMenuForm";
            this.Text = "MainMenuForm";
            this.pnlMainMenu.ResumeLayout(false);
            this.pnlMainMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlMainMenu;
        private Button BtnOrderMenu;
        private Button btnProductMenu;
        private Label lblMainMenu;
    }
}
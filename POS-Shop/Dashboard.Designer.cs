
namespace POS_Shop.Sales
{
    partial class Dashboard
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
            this.panelShowWelcome = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.labelCountProduct = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.labelCountSale = new System.Windows.Forms.Label();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.btnDetailSale = new System.Windows.Forms.Button();
            this.btnStartSale = new System.Windows.Forms.Button();
            this.panelShowWelcome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panelChildForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelShowWelcome
            // 
            this.panelShowWelcome.Controls.Add(this.label1);
            this.panelShowWelcome.Controls.Add(this.pictureBox3);
            this.panelShowWelcome.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShowWelcome.Location = new System.Drawing.Point(0, 0);
            this.panelShowWelcome.Name = "panelShowWelcome";
            this.panelShowWelcome.Size = new System.Drawing.Size(898, 120);
            this.panelShowWelcome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Fira Mono", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(320, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "Welcome to POS-Shop";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox3.Image = global::POS_Shop.Properties.Resources.dashboard_img;
            this.pictureBox3.Location = new System.Drawing.Point(399, 16);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // panel8
            // 
            this.panel8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel8.AutoSize = true;
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.Controls.Add(this.label6);
            this.panel8.Controls.Add(this.labelCountProduct);
            this.panel8.Location = new System.Drawing.Point(473, 135);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(200, 84);
            this.panel8.TabIndex = 4;
            this.panel8.Click += new System.EventHandler(this.panel8_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.Location = new System.Drawing.Point(56, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Total Items";
            // 
            // labelCountProduct
            // 
            this.labelCountProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCountProduct.Font = new System.Drawing.Font("Fira Mono", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCountProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(93)))), ((int)(((byte)(93)))));
            this.labelCountProduct.Location = new System.Drawing.Point(86, 20);
            this.labelCountProduct.Name = "labelCountProduct";
            this.labelCountProduct.Size = new System.Drawing.Size(34, 24);
            this.labelCountProduct.TabIndex = 0;
            this.labelCountProduct.Text = "60";
            // 
            // panel9
            // 
            this.panel9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel9.AutoSize = true;
            this.panel9.BackColor = System.Drawing.Color.White;
            this.panel9.Controls.Add(this.label3);
            this.panel9.Controls.Add(this.labelCountSale);
            this.panel9.Location = new System.Drawing.Point(214, 135);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(200, 84);
            this.panel9.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.Location = new System.Drawing.Point(54, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Total Sales";
            // 
            // labelCountSale
            // 
            this.labelCountSale.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCountSale.AutoSize = true;
            this.labelCountSale.Font = new System.Drawing.Font("Fira Mono", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCountSale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(158)))), ((int)(((byte)(231)))));
            this.labelCountSale.Location = new System.Drawing.Point(84, 20);
            this.labelCountSale.Name = "labelCountSale";
            this.labelCountSale.Size = new System.Drawing.Size(22, 24);
            this.labelCountSale.TabIndex = 0;
            this.labelCountSale.Text = "0";
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.panelChildForm.Controls.Add(this.panel8);
            this.panelChildForm.Controls.Add(this.btnDetailSale);
            this.panelChildForm.Controls.Add(this.btnStartSale);
            this.panelChildForm.Controls.Add(this.panel9);
            this.panelChildForm.Controls.Add(this.panelShowWelcome);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Font = new System.Drawing.Font("Fira Mono", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelChildForm.Location = new System.Drawing.Point(0, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(898, 500);
            this.panelChildForm.TabIndex = 3;
            // 
            // btnDetailSale
            // 
            this.btnDetailSale.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDetailSale.BackColor = System.Drawing.Color.White;
            this.btnDetailSale.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnDetailSale.FlatAppearance.BorderSize = 0;
            this.btnDetailSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetailSale.Location = new System.Drawing.Point(473, 260);
            this.btnDetailSale.Name = "btnDetailSale";
            this.btnDetailSale.Size = new System.Drawing.Size(200, 40);
            this.btnDetailSale.TabIndex = 0;
            this.btnDetailSale.Text = "Today\'s detailed sales report";
            this.btnDetailSale.UseVisualStyleBackColor = false;
            this.btnDetailSale.MouseLeave += new System.EventHandler(this.btnDetailSale_MouseLeave);
            this.btnDetailSale.MouseHover += new System.EventHandler(this.btnDetailSale_MouseHover);
            // 
            // btnStartSale
            // 
            this.btnStartSale.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnStartSale.BackColor = System.Drawing.Color.White;
            this.btnStartSale.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnStartSale.FlatAppearance.BorderSize = 0;
            this.btnStartSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartSale.Location = new System.Drawing.Point(214, 260);
            this.btnStartSale.Name = "btnStartSale";
            this.btnStartSale.Size = new System.Drawing.Size(200, 40);
            this.btnStartSale.TabIndex = 0;
            this.btnStartSale.Text = "Start New Sale";
            this.btnStartSale.UseVisualStyleBackColor = false;
            this.btnStartSale.Click += new System.EventHandler(this.btnStartSale_Click);
            this.btnStartSale.MouseLeave += new System.EventHandler(this.btnStartSale_MouseLeave);
            this.btnStartSale.MouseHover += new System.EventHandler(this.btnStartSale_MouseHover);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 500);
            this.Controls.Add(this.panelChildForm);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panelShowWelcome.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panelChildForm.ResumeLayout(false);
            this.panelChildForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelShowWelcome;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelCountSale;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Button btnDetailSale;
        private System.Windows.Forms.Button btnStartSale;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelCountProduct;
    }
}
﻿
using System.Drawing;

namespace POS_Shop.Utils.MyUserControl
{
    partial class ItemProductControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelItem = new System.Windows.Forms.Panel();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelProductName = new System.Windows.Forms.Label();
            this.picProImage = new System.Windows.Forms.PictureBox();
            this.picOrder = new System.Windows.Forms.PictureBox();
            this.panelItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // panelItem
            // 
            this.panelItem.BackColor = System.Drawing.Color.White;
            this.panelItem.Controls.Add(this.labelPrice);
            this.panelItem.Controls.Add(this.labelProductName);
            this.panelItem.Controls.Add(this.picProImage);
            this.panelItem.Location = new System.Drawing.Point(4, 0);
            this.panelItem.Name = "panelItem";
            this.panelItem.Size = new System.Drawing.Size(157, 211);
            this.panelItem.TabIndex = 0;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Kh Battambang", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.ForeColor = System.Drawing.Color.Red;
            this.labelPrice.Location = new System.Drawing.Point(59, 181);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(47, 19);
            this.labelPrice.TabIndex = 7;
            this.labelPrice.Text = "$12.00";
            // 
            // labelProductName
            // 
            this.labelProductName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelProductName.AutoSize = true;
            this.labelProductName.Location = new System.Drawing.Point(35, 162);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(78, 19);
            this.labelProductName.TabIndex = 5;
            this.labelProductName.Text = "Product Name";
            // 
            // picProImage
            // 
            this.picProImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.picProImage.Image = global::POS_Shop.Properties.Resources.notfound;
            this.picProImage.Location = new System.Drawing.Point(0, 0);
            this.picProImage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picProImage.Name = "picProImage";
            this.picProImage.Size = new System.Drawing.Size(157, 155);
            this.picProImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picProImage.TabIndex = 4;
            this.picProImage.TabStop = false;
            // 
            // picOrder
            // 
            this.picOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picOrder.BackColor = System.Drawing.Color.Transparent;
            this.picOrder.Image = global::POS_Shop.Properties.Resources.add_11;
            this.picOrder.Location = new System.Drawing.Point(116, 193);
            this.picOrder.Name = "picOrder";
            this.picOrder.Size = new System.Drawing.Size(37, 27);
            this.picOrder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picOrder.TabIndex = 6;
            this.picOrder.TabStop = false;
            // 
            // ItemProductControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelItem);
            this.Controls.Add(this.picOrder);
            this.Font = new System.Drawing.Font("Kh Battambang", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ItemProductControl";
            this.Size = new System.Drawing.Size(180, 223);
            this.Load += new System.EventHandler(this.ItemProductControl_Load);
            this.panelItem.ResumeLayout(false);
            this.panelItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelItem;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.PictureBox picProImage;
        private System.Windows.Forms.PictureBox picOrder;

        public Image ProImage { get => picProImage.Image; set => picProImage.Image = value; }
        public string LabelProductName { get => labelProductName.Text; set => labelProductName.Text = value; }
        public string LabelPrice { get => labelPrice.Text; set => labelPrice.Text = value; }
    }
}
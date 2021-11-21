
using POS_Shop.Models;
using System.Drawing;
using System.Windows.Forms;

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
            this.label3 = new System.Windows.Forms.Label();
            this.labelItems = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelBarcode = new System.Windows.Forms.Label();
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
            this.panelItem.Controls.Add(this.label3);
            this.panelItem.Controls.Add(this.labelItems);
            this.panelItem.Controls.Add(this.labelPrice);
            this.panelItem.Controls.Add(this.labelBarcode);
            this.panelItem.Controls.Add(this.labelProductName);
            this.panelItem.Controls.Add(this.picProImage);
            this.panelItem.Location = new System.Drawing.Point(4, 0);
            this.panelItem.Name = "panelItem";
            this.panelItem.Size = new System.Drawing.Size(157, 251);
            this.panelItem.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Kh Battambang", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SeaGreen;
            this.label3.Location = new System.Drawing.Point(73, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "items:";
            // 
            // labelItems
            // 
            this.labelItems.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelItems.AutoSize = true;
            this.labelItems.Font = new System.Drawing.Font("Kh Battambang", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelItems.ForeColor = System.Drawing.Color.Red;
            this.labelItems.Location = new System.Drawing.Point(112, 160);
            this.labelItems.Name = "labelItems";
            this.labelItems.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelItems.Size = new System.Drawing.Size(38, 25);
            this.labelItems.TabIndex = 8;
            this.labelItems.Text = "100";
            this.labelItems.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Kh Battambang", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.ForeColor = System.Drawing.Color.Red;
            this.labelPrice.Location = new System.Drawing.Point(49, 216);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(47, 19);
            this.labelPrice.TabIndex = 7;
            this.labelPrice.Text = "$12.00";
            // 
            // labelBarcode
            // 
            this.labelBarcode.AutoSize = true;
            this.labelBarcode.Font = new System.Drawing.Font("Kh Battambang", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBarcode.Location = new System.Drawing.Point(-1, 163);
            this.labelBarcode.Name = "labelBarcode";
            this.labelBarcode.Size = new System.Drawing.Size(57, 19);
            this.labelBarcode.TabIndex = 5;
            this.labelBarcode.Text = "Barcode";
            this.labelBarcode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.Location = new System.Drawing.Point(3, 191);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(78, 19);
            this.labelProductName.TabIndex = 5;
            this.labelProductName.Text = "Product Name";
            this.labelProductName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.picOrder.Location = new System.Drawing.Point(106, 236);
            this.picOrder.Name = "picOrder";
            this.picOrder.Size = new System.Drawing.Size(37, 27);
            this.picOrder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picOrder.TabIndex = 6;
            this.picOrder.TabStop = false;
            this.picOrder.Click += new System.EventHandler(this.picOrder_Click);
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
            this.Size = new System.Drawing.Size(165, 266);
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
        private System.Windows.Forms.Label labelBarcode;
        private Label label3;
        private Label labelItems;

        public Image ProImage { get => picProImage.Image; set => picProImage.Image = value; }
        public string LabelProductName { get => labelProductName.Text; set => labelProductName.Text = value; }
        public string LabelPrice { get => labelPrice.Text; set => labelPrice.Text = FormatUtils.ConvertStringToCurrency(value); }
        public int ProductId { get; set; }
        public int Qty { get; set; }
        public string LabelBarcode { get => labelBarcode.Text; set => labelBarcode.Text = value; }
        public static DataGridViewRowCollection Rows { get; set; }
        public OrderDetails ItemDetails { get; set; }
        public static OrderDetails ItemDetailsStatic { get; set; }
        public PictureBox PicOrder { get => picOrder; set => picOrder = value; }
        public string LableItems { get => labelItems.Text; set => labelItems.Text = value; }
        public static int LableItemsStatic { get; set; }
    }
}

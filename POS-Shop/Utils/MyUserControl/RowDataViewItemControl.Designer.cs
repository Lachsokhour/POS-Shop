
using POS_Shop.Models;
using System.Windows.Forms;

namespace POS_Shop.Utils.MyUserControl
{
    partial class RowDataViewItemControl
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
            this.RowTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.picRemove = new System.Windows.Forms.PictureBox();
            this.picAdd = new System.Windows.Forms.PictureBox();
            this.labelProductName = new System.Windows.Forms.Label();
            this.labelUnitPrice = new System.Windows.Forms.Label();
            this.labelQty = new System.Windows.Forms.Label();
            this.labelTotalAmount = new System.Windows.Forms.Label();
            this.RowTablePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRemove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // RowTablePanel
            // 
            this.RowTablePanel.BackColor = System.Drawing.SystemColors.Control;
            this.RowTablePanel.ColumnCount = 7;
            this.RowTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.RowTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.RowTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.RowTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.RowTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.RowTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.RowTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.RowTablePanel.Controls.Add(this.picRemove, 1, 0);
            this.RowTablePanel.Controls.Add(this.picAdd, 3, 0);
            this.RowTablePanel.Controls.Add(this.labelProductName, 0, 0);
            this.RowTablePanel.Controls.Add(this.labelUnitPrice, 4, 0);
            this.RowTablePanel.Controls.Add(this.labelQty, 2, 0);
            this.RowTablePanel.Controls.Add(this.labelTotalAmount, 5, 0);
            this.RowTablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RowTablePanel.Font = new System.Drawing.Font("Kh Battambang", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RowTablePanel.Location = new System.Drawing.Point(0, 0);
            this.RowTablePanel.Name = "RowTablePanel";
            this.RowTablePanel.RowCount = 1;
            this.RowTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.RowTablePanel.Size = new System.Drawing.Size(455, 35);
            this.RowTablePanel.TabIndex = 1;
            // 
            // picRemove
            // 
            this.picRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picRemove.Image = global::POS_Shop.Properties.Resources.icon_remove;
            this.picRemove.Location = new System.Drawing.Point(153, 3);
            this.picRemove.Name = "picRemove";
            this.picRemove.Size = new System.Drawing.Size(19, 29);
            this.picRemove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRemove.TabIndex = 1;
            this.picRemove.TabStop = false;
            this.picRemove.Click += new System.EventHandler(this.picRemove_Click);
            // 
            // picAdd
            // 
            this.picAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picAdd.Image = global::POS_Shop.Properties.Resources.add_1;
            this.picAdd.Location = new System.Drawing.Point(208, 3);
            this.picAdd.Name = "picAdd";
            this.picAdd.Size = new System.Drawing.Size(19, 29);
            this.picAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAdd.TabIndex = 2;
            this.picAdd.TabStop = false;
            this.picAdd.Click += new System.EventHandler(this.picAdd_Click);
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelProductName.Location = new System.Drawing.Point(3, 0);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(144, 35);
            this.labelProductName.TabIndex = 0;
            this.labelProductName.Text = "Product Name";
            this.labelProductName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelUnitPrice
            // 
            this.labelUnitPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelUnitPrice.AutoSize = true;
            this.labelUnitPrice.Location = new System.Drawing.Point(233, 0);
            this.labelUnitPrice.Name = "labelUnitPrice";
            this.labelUnitPrice.Size = new System.Drawing.Size(84, 35);
            this.labelUnitPrice.TabIndex = 3;
            this.labelUnitPrice.Text = "Unit price";
            this.labelUnitPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelQty
            // 
            this.labelQty.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelQty.AutoSize = true;
            this.labelQty.Location = new System.Drawing.Point(178, 0);
            this.labelQty.Name = "labelQty";
            this.labelQty.Size = new System.Drawing.Size(24, 35);
            this.labelQty.TabIndex = 5;
            this.labelQty.Text = "Qty";
            this.labelQty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTotalAmount
            // 
            this.labelTotalAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTotalAmount.AutoSize = true;
            this.labelTotalAmount.Location = new System.Drawing.Point(323, 0);
            this.labelTotalAmount.Name = "labelTotalAmount";
            this.labelTotalAmount.Size = new System.Drawing.Size(84, 35);
            this.labelTotalAmount.TabIndex = 4;
            this.labelTotalAmount.Text = "Total";
            this.labelTotalAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RowDataViewItemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.RowTablePanel);
            this.Name = "RowDataViewItemControl";
            this.Size = new System.Drawing.Size(455, 35);
            this.RowTablePanel.ResumeLayout(false);
            this.RowTablePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRemove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAdd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel RowTablePanel;
        private System.Windows.Forms.PictureBox picRemove;
        private System.Windows.Forms.PictureBox picAdd;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.Label labelUnitPrice;
        private System.Windows.Forms.Label labelTotalAmount;
        private System.Windows.Forms.Label labelQty;

        public OrderDetails ItemDetails { 
            get {
                labelProductName.Text = ItemDetails.ProductName;
                labelQty.Text = ItemDetails.Qty.ToString();
                labelUnitPrice.Text = ItemDetails.UnitPrice.ToString();
                labelTotalAmount.Text = ItemDetails.Amount.ToString();
                return ItemDetails;
            } set { } }
        public string ProName { get => labelProductName.Text; set => labelProductName.Text = value; }
        public int ProId { get; set; }
        public string UnitPrice { get => labelUnitPrice.Text; set => labelUnitPrice.Text = value; }
        public int Qty { get => int.Parse(labelQty.Text); set => labelQty.Text = value.ToString(); }
        public string TotalAmount { get => labelTotalAmount.Text; set => labelTotalAmount.Text = value; }
        
    }
}

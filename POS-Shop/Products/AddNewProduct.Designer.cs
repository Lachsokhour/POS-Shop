
using POS_Shop.Models;

namespace POS_Shop.Products
{
    partial class AddNewProduct
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelProductForm = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtNameEn = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtPriceOut = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtNameKh = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.uploadImageControl = new POS_Shop.Utils.UploadImageControl();
            this.panelProductForm.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Fira Mono", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(23, 34);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(127, 15);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Add New Product";
            // 
            // panelProductForm
            // 
            this.panelProductForm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelProductForm.Controls.Add(this.btnSave);
            this.panelProductForm.Controls.Add(this.txtNote);
            this.panelProductForm.Controls.Add(this.label4);
            this.panelProductForm.Controls.Add(this.panel6);
            this.panelProductForm.Controls.Add(this.label8);
            this.panelProductForm.Controls.Add(this.panel2);
            this.panelProductForm.Controls.Add(this.panel5);
            this.panelProductForm.Controls.Add(this.panel3);
            this.panelProductForm.Controls.Add(this.label3);
            this.panelProductForm.Controls.Add(this.label5);
            this.panelProductForm.Controls.Add(this.label2);
            this.panelProductForm.Controls.Add(this.uploadImageControl);
            this.panelProductForm.Location = new System.Drawing.Point(26, 65);
            this.panelProductForm.Name = "panelProductForm";
            this.panelProductForm.Size = new System.Drawing.Size(880, 450);
            this.panelProductForm.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(158)))), ((int)(((byte)(231)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(781, 364);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSave.MaximumSize = new System.Drawing.Size(70, 40);
            this.btnSave.MinimumSize = new System.Drawing.Size(70, 40);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(70, 40);
            this.btnSave.TabIndex = 42;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(33, 299);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(322, 105);
            this.txtNote.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 15);
            this.label4.TabIndex = 40;
            this.label4.Text = "Description";
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.comboBoxCategory);
            this.panel6.Location = new System.Drawing.Point(510, 299);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(339, 40);
            this.panel6.TabIndex = 16;
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(9, 8);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(327, 23);
            this.comboBoxCategory.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Cursor = System.Windows.Forms.Cursors.Default;
            this.label8.Location = new System.Drawing.Point(507, 274);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "Category*";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.txtNameEn);
            this.panel2.Location = new System.Drawing.Point(510, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(341, 40);
            this.panel2.TabIndex = 6;
            // 
            // txtNameEn
            // 
            this.txtNameEn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNameEn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNameEn.Location = new System.Drawing.Point(9, 12);
            this.txtNameEn.Name = "txtNameEn";
            this.txtNameEn.Size = new System.Drawing.Size(330, 16);
            this.txtNameEn.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.txtPriceOut);
            this.panel5.Location = new System.Drawing.Point(510, 207);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(341, 40);
            this.panel5.TabIndex = 6;
            // 
            // txtPriceOut
            // 
            this.txtPriceOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPriceOut.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPriceOut.Location = new System.Drawing.Point(9, 12);
            this.txtPriceOut.Name = "txtPriceOut";
            this.txtPriceOut.Size = new System.Drawing.Size(330, 16);
            this.txtPriceOut.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.txtNameKh);
            this.panel3.Location = new System.Drawing.Point(510, 116);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(341, 40);
            this.panel3.TabIndex = 6;
            // 
            // txtNameKh
            // 
            this.txtNameKh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNameKh.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNameKh.Location = new System.Drawing.Point(9, 12);
            this.txtNameKh.Name = "txtNameKh";
            this.txtNameKh.Size = new System.Drawing.Size(330, 16);
            this.txtNameKh.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(507, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Product Name* (En)";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(507, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Proce Out*";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(507, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Product Name (Kh)";
            // 
            // uploadImageControl
            // 
            this.uploadImageControl.FileName = null;
            this.uploadImageControl.FilePath = null;
            this.uploadImageControl.Font = new System.Drawing.Font("Fira Mono", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadImageControl.IsAddMode = true;
            this.uploadImageControl.Location = new System.Drawing.Point(33, 0);
            this.uploadImageControl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.uploadImageControl.Name = "uploadImageControl";
            this.uploadImageControl.PicImage = null;
            this.uploadImageControl.Size = new System.Drawing.Size(322, 244);
            this.uploadImageControl.TabIndex = 0;
            // 
            // AddNewProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 569);
            this.Controls.Add(this.panelProductForm);
            this.Controls.Add(this.labelTitle);
            this.Font = new System.Drawing.Font("Fira Mono", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "AddNewProduct";
            this.Text = "AddNewProduct";
            this.panelProductForm.ResumeLayout(false);
            this.panelProductForm.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelProductForm;
        private Utils.UploadImageControl uploadImageControl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtNameEn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtNameKh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtPriceOut;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label label4;
    }
}
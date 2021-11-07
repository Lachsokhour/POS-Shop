
namespace POS_Shop.Stock
{
    partial class FormStockIn
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
            this.label2 = new System.Windows.Forms.Label();
            this.groupFormStockIn = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dateExpired = new System.Windows.Forms.DateTimePicker();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dateIn = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtPriceIn = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.comboBoxProduct = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupFormStockIn.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 5;
            // 
            // groupFormStockIn
            // 
            this.groupFormStockIn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupFormStockIn.Controls.Add(this.panel4);
            this.groupFormStockIn.Controls.Add(this.btnBack);
            this.groupFormStockIn.Controls.Add(this.btnClear);
            this.groupFormStockIn.Controls.Add(this.btnSave);
            this.groupFormStockIn.Controls.Add(this.txtNote);
            this.groupFormStockIn.Controls.Add(this.label7);
            this.groupFormStockIn.Controls.Add(this.panel3);
            this.groupFormStockIn.Controls.Add(this.label6);
            this.groupFormStockIn.Controls.Add(this.panel1);
            this.groupFormStockIn.Controls.Add(this.label5);
            this.groupFormStockIn.Controls.Add(this.panel2);
            this.groupFormStockIn.Controls.Add(this.label4);
            this.groupFormStockIn.Controls.Add(this.label3);
            this.groupFormStockIn.Controls.Add(this.panel6);
            this.groupFormStockIn.Controls.Add(this.label1);
            this.groupFormStockIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupFormStockIn.Location = new System.Drawing.Point(28, 75);
            this.groupFormStockIn.Name = "groupFormStockIn";
            this.groupFormStockIn.Size = new System.Drawing.Size(892, 386);
            this.groupFormStockIn.TabIndex = 6;
            this.groupFormStockIn.TabStop = false;
            this.groupFormStockIn.Text = "Add New Stock";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.dateExpired);
            this.panel4.Location = new System.Drawing.Point(535, 63);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(341, 40);
            this.panel4.TabIndex = 62;
            // 
            // dateExpired
            // 
            this.dateExpired.CustomFormat = "dd-MM-yyyy";
            this.dateExpired.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateExpired.Location = new System.Drawing.Point(8, 9);
            this.dateExpired.Name = "dateExpired";
            this.dateExpired.Size = new System.Drawing.Size(332, 23);
            this.dateExpired.TabIndex = 62;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.BackColor = System.Drawing.Color.Red;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(650, 317);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBack.MaximumSize = new System.Drawing.Size(70, 40);
            this.btnBack.MinimumSize = new System.Drawing.Size(70, 40);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(70, 40);
            this.btnBack.TabIndex = 59;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(158)))), ((int)(((byte)(231)))));
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(728, 317);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnClear.MaximumSize = new System.Drawing.Size(70, 40);
            this.btnClear.MinimumSize = new System.Drawing.Size(70, 40);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(70, 40);
            this.btnClear.TabIndex = 60;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(158)))), ((int)(((byte)(231)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(806, 317);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSave.MaximumSize = new System.Drawing.Size(70, 40);
            this.btnSave.MinimumSize = new System.Drawing.Size(70, 40);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(70, 40);
            this.btnSave.TabIndex = 61;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtNote
            // 
            this.txtNote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNote.Location = new System.Drawing.Point(535, 148);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(341, 125);
            this.txtNote.TabIndex = 58;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(532, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 15);
            this.label7.TabIndex = 57;
            this.label7.Text = "Description";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.dateIn);
            this.panel3.Location = new System.Drawing.Point(17, 317);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(341, 40);
            this.panel3.TabIndex = 54;
            // 
            // dateIn
            // 
            this.dateIn.CalendarTrailingForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dateIn.CustomFormat = "dd-MM-yyyy";
            this.dateIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateIn.Location = new System.Drawing.Point(8, 9);
            this.dateIn.Name = "dateIn";
            this.dateIn.Size = new System.Drawing.Size(332, 23);
            this.dateIn.TabIndex = 62;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(532, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 15);
            this.label6.TabIndex = 49;
            this.label6.Text = "Date Expired*";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txtQty);
            this.panel1.Location = new System.Drawing.Point(17, 233);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 40);
            this.panel1.TabIndex = 55;
            // 
            // txtQty
            // 
            this.txtQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQty.Location = new System.Drawing.Point(9, 12);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(330, 16);
            this.txtQty.TabIndex = 0;
            this.txtQty.TextChanged += new System.EventHandler(this.txtQty_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 15);
            this.label5.TabIndex = 50;
            this.label5.Text = "Date In*";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.txtPriceIn);
            this.panel2.Location = new System.Drawing.Point(17, 148);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(341, 40);
            this.panel2.TabIndex = 56;
            // 
            // txtPriceIn
            // 
            this.txtPriceIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPriceIn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPriceIn.Location = new System.Drawing.Point(9, 12);
            this.txtPriceIn.Name = "txtPriceIn";
            this.txtPriceIn.Size = new System.Drawing.Size(330, 16);
            this.txtPriceIn.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 51;
            this.label4.Text = "QTY*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 15);
            this.label3.TabIndex = 52;
            this.label3.Text = "Price In* ($)";
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.comboBoxProduct);
            this.panel6.Location = new System.Drawing.Point(17, 63);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(339, 40);
            this.panel6.TabIndex = 48;
            // 
            // comboBoxProduct
            // 
            this.comboBoxProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxProduct.FormattingEnabled = true;
            this.comboBoxProduct.Location = new System.Drawing.Point(9, 9);
            this.comboBoxProduct.Name = "comboBoxProduct";
            this.comboBoxProduct.Size = new System.Drawing.Size(327, 23);
            this.comboBoxProduct.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 47;
            this.label1.Text = "Product*";
            // 
            // FormStockIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 503);
            this.Controls.Add(this.groupFormStockIn);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Fira Mono", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormStockIn";
            this.Text = "FormStockIn";
            this.Load += new System.EventHandler(this.FormStockIn_Load);
            this.groupFormStockIn.ResumeLayout(false);
            this.groupFormStockIn.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupFormStockIn;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtPriceIn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ComboBox comboBoxProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DateTimePicker dateExpired;
        private System.Windows.Forms.DateTimePicker dateIn;
    }
}
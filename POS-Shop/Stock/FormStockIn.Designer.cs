
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
            this.panelDateExpired = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dateExpired = new System.Windows.Forms.DateTimePicker();
            this.labelDateExpired = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioBtnNo = new System.Windows.Forms.RadioButton();
            this.radioBtnYes = new System.Windows.Forms.RadioButton();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dateIn = new System.Windows.Forms.DateTimePicker();
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
            this.panelDateExpired.SuspendLayout();
            this.panel5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 24);
            this.label2.TabIndex = 5;
            // 
            // groupFormStockIn
            // 
            this.groupFormStockIn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupFormStockIn.Controls.Add(this.panelDateExpired);
            this.groupFormStockIn.Controls.Add(this.groupBox1);
            this.groupFormStockIn.Controls.Add(this.btnBack);
            this.groupFormStockIn.Controls.Add(this.btnClear);
            this.groupFormStockIn.Controls.Add(this.btnSave);
            this.groupFormStockIn.Controls.Add(this.txtNote);
            this.groupFormStockIn.Controls.Add(this.label7);
            this.groupFormStockIn.Controls.Add(this.panel3);
            this.groupFormStockIn.Controls.Add(this.panel1);
            this.groupFormStockIn.Controls.Add(this.label5);
            this.groupFormStockIn.Controls.Add(this.panel2);
            this.groupFormStockIn.Controls.Add(this.label4);
            this.groupFormStockIn.Controls.Add(this.label3);
            this.groupFormStockIn.Controls.Add(this.panel6);
            this.groupFormStockIn.Controls.Add(this.label1);
            this.groupFormStockIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupFormStockIn.Location = new System.Drawing.Point(26, 42);
            this.groupFormStockIn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupFormStockIn.Name = "groupFormStockIn";
            this.groupFormStockIn.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupFormStockIn.Size = new System.Drawing.Size(780, 469);
            this.groupFormStockIn.TabIndex = 6;
            this.groupFormStockIn.TabStop = false;
            this.groupFormStockIn.Text = "Add New Stock";
            // 
            // panelDateExpired
            // 
            this.panelDateExpired.Controls.Add(this.panel5);
            this.panelDateExpired.Controls.Add(this.labelDateExpired);
            this.panelDateExpired.Location = new System.Drawing.Point(453, 129);
            this.panelDateExpired.Name = "panelDateExpired";
            this.panelDateExpired.Size = new System.Drawing.Size(310, 80);
            this.panelDateExpired.TabIndex = 64;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.dateExpired);
            this.panel5.Location = new System.Drawing.Point(-1, 35);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(310, 40);
            this.panel5.TabIndex = 64;
            // 
            // dateExpired
            // 
            this.dateExpired.CustomFormat = "dd-MM-yyyy";
            this.dateExpired.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateExpired.Location = new System.Drawing.Point(2, 4);
            this.dateExpired.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dateExpired.Name = "dateExpired";
            this.dateExpired.Size = new System.Drawing.Size(305, 32);
            this.dateExpired.TabIndex = 62;
            // 
            // labelDateExpired
            // 
            this.labelDateExpired.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDateExpired.AutoSize = true;
            this.labelDateExpired.Location = new System.Drawing.Point(0, 6);
            this.labelDateExpired.Name = "labelDateExpired";
            this.labelDateExpired.Size = new System.Drawing.Size(90, 24);
            this.labelDateExpired.TabIndex = 63;
            this.labelDateExpired.Text = "Date Expired*";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioBtnNo);
            this.groupBox1.Controls.Add(this.radioBtnYes);
            this.groupBox1.Location = new System.Drawing.Point(455, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 81);
            this.groupBox1.TabIndex = 63;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Defind date expired.";
            // 
            // radioBtnNo
            // 
            this.radioBtnNo.AutoSize = true;
            this.radioBtnNo.Location = new System.Drawing.Point(158, 33);
            this.radioBtnNo.Name = "radioBtnNo";
            this.radioBtnNo.Size = new System.Drawing.Size(44, 28);
            this.radioBtnNo.TabIndex = 0;
            this.radioBtnNo.TabStop = true;
            this.radioBtnNo.Text = "No";
            this.radioBtnNo.UseVisualStyleBackColor = true;
            this.radioBtnNo.CheckedChanged += new System.EventHandler(this.radioBtnNo_CheckedChanged);
            // 
            // radioBtnYes
            // 
            this.radioBtnYes.AutoSize = true;
            this.radioBtnYes.Location = new System.Drawing.Point(25, 33);
            this.radioBtnYes.Name = "radioBtnYes";
            this.radioBtnYes.Size = new System.Drawing.Size(50, 28);
            this.radioBtnYes.TabIndex = 0;
            this.radioBtnYes.TabStop = true;
            this.radioBtnYes.Text = "Yes";
            this.radioBtnYes.UseVisualStyleBackColor = true;
            this.radioBtnYes.CheckedChanged += new System.EventHandler(this.radioBtnYes_CheckedChanged);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.BackColor = System.Drawing.Color.Red;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(535, 413);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
            this.btnClear.Location = new System.Drawing.Point(613, 413);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
            this.btnSave.Location = new System.Drawing.Point(693, 413);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
            this.txtNote.Font = new System.Drawing.Font("Kh Battambang", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNote.Location = new System.Drawing.Point(453, 253);
            this.txtNote.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(310, 137);
            this.txtNote.TabIndex = 58;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(449, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 24);
            this.label7.TabIndex = 57;
            this.label7.Text = "Description";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.dateIn);
            this.panel3.Location = new System.Drawing.Point(12, 358);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(310, 40);
            this.panel3.TabIndex = 54;
            // 
            // dateIn
            // 
            this.dateIn.CalendarTrailingForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dateIn.CustomFormat = "dd-MM-yyyy";
            this.dateIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateIn.Location = new System.Drawing.Point(4, 4);
            this.dateIn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dateIn.Name = "dateIn";
            this.dateIn.Size = new System.Drawing.Size(303, 32);
            this.dateIn.TabIndex = 62;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txtQty);
            this.panel1.Location = new System.Drawing.Point(15, 266);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 40);
            this.panel1.TabIndex = 55;
            // 
            // txtQty
            // 
            this.txtQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQty.Location = new System.Drawing.Point(9, 8);
            this.txtQty.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(298, 25);
            this.txtQty.TabIndex = 0;
            this.txtQty.TextChanged += new System.EventHandler(this.txtQty_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 24);
            this.label5.TabIndex = 50;
            this.label5.Text = "Date In*";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.txtPriceIn);
            this.panel2.Location = new System.Drawing.Point(15, 169);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(310, 40);
            this.panel2.TabIndex = 56;
            // 
            // txtPriceIn
            // 
            this.txtPriceIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPriceIn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPriceIn.Location = new System.Drawing.Point(9, 8);
            this.txtPriceIn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtPriceIn.Name = "txtPriceIn";
            this.txtPriceIn.Size = new System.Drawing.Size(298, 25);
            this.txtPriceIn.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 24);
            this.label4.TabIndex = 51;
            this.label4.Text = "QTY*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 24);
            this.label3.TabIndex = 52;
            this.label3.Text = "Price In* ($)";
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.comboBoxProduct);
            this.panel6.Location = new System.Drawing.Point(15, 71);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(310, 40);
            this.panel6.TabIndex = 48;
            // 
            // comboBoxProduct
            // 
            this.comboBoxProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxProduct.FormattingEnabled = true;
            this.comboBoxProduct.Location = new System.Drawing.Point(8, 4);
            this.comboBoxProduct.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.comboBoxProduct.Name = "comboBoxProduct";
            this.comboBoxProduct.Size = new System.Drawing.Size(299, 32);
            this.comboBoxProduct.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 24);
            this.label1.TabIndex = 47;
            this.label1.Text = "Product*";
            // 
            // FormStockIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 541);
            this.Controls.Add(this.groupFormStockIn);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Kh Battambang", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormStockIn";
            this.Text = "FormStockIn";
            this.Load += new System.EventHandler(this.FormStockIn_Load);
            this.groupFormStockIn.ResumeLayout(false);
            this.groupFormStockIn.PerformLayout();
            this.panelDateExpired.ResumeLayout(false);
            this.panelDateExpired.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.DateTimePicker dateIn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioBtnNo;
        private System.Windows.Forms.RadioButton radioBtnYes;
        private System.Windows.Forms.Panel panelDateExpired;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DateTimePicker dateExpired;
        private System.Windows.Forms.Label labelDateExpired;
    }
}
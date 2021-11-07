
namespace POS_Shop.Settings
{
    partial class ExchangeForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.labelInfo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDollar = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtRiel = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panelAddExchange = new System.Windows.Forms.Panel();
            this.panelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelAddExchange.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Exchange";
            // 
            // panelInfo
            // 
            this.panelInfo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelInfo.Controls.Add(this.labelInfo);
            this.panelInfo.Controls.Add(this.pictureBox1);
            this.panelInfo.Location = new System.Drawing.Point(28, 305);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(786, 50);
            this.panelInfo.TabIndex = 2;
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(42, 18);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(0, 15);
            this.labelInfo.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::POS_Shop.Properties.Resources.icon_info;
            this.pictureBox1.Location = new System.Drawing.Point(0, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(28, 178);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(786, 93);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Example for input:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(207, 15);
            this.label9.TabIndex = 18;
            this.label9.Text = "For riel: 4000 not 4,000.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(239, 15);
            this.label8.TabIndex = 19;
            this.label8.Text = "For dollar: 1 or 1.00 not $1.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Dollar ($)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(361, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Riel (៛)";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txtDollar);
            this.panel3.Location = new System.Drawing.Point(6, 33);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(320, 40);
            this.panel3.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "$";
            // 
            // txtDollar
            // 
            this.txtDollar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDollar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDollar.Location = new System.Drawing.Point(24, 12);
            this.txtDollar.Name = "txtDollar";
            this.txtDollar.Size = new System.Drawing.Size(293, 16);
            this.txtDollar.TabIndex = 0;
            this.txtDollar.TextChanged += new System.EventHandler(this.txtDollar_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txtRiel);
            this.panel1.Location = new System.Drawing.Point(364, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 40);
            this.panel1.TabIndex = 7;
            // 
            // txtRiel
            // 
            this.txtRiel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRiel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRiel.Location = new System.Drawing.Point(9, 12);
            this.txtRiel.Name = "txtRiel";
            this.txtRiel.Size = new System.Drawing.Size(308, 16);
            this.txtRiel.TabIndex = 0;
            this.txtRiel.TextChanged += new System.EventHandler(this.txtRiel_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(158)))), ((int)(((byte)(231)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(704, 32);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(69, 40);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(335, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "To";
            // 
            // panelAddExchange
            // 
            this.panelAddExchange.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelAddExchange.Controls.Add(this.label4);
            this.panelAddExchange.Controls.Add(this.btnSave);
            this.panelAddExchange.Controls.Add(this.panel1);
            this.panelAddExchange.Controls.Add(this.panel3);
            this.panelAddExchange.Controls.Add(this.label3);
            this.panelAddExchange.Controls.Add(this.label2);
            this.panelAddExchange.Location = new System.Drawing.Point(28, 64);
            this.panelAddExchange.Name = "panelAddExchange";
            this.panelAddExchange.Size = new System.Drawing.Size(786, 97);
            this.panelAddExchange.TabIndex = 1;
            // 
            // ExchangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 508);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.panelAddExchange);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Fira Mono", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ExchangeForm";
            this.Text = "Exchange";
            this.Load += new System.EventHandler(this.ExchangeForm_Load);
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelAddExchange.ResumeLayout(false);
            this.panelAddExchange.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDollar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtRiel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelAddExchange;
    }
}
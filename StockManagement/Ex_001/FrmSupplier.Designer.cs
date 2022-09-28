
namespace Ex_001
{
    partial class FrmSupplier
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
            this.grdSupplier = new System.Windows.Forms.DataGridView();
            this.btnShowSupplier = new System.Windows.Forms.Button();
            this.btnSupplierInsert = new System.Windows.Forms.Button();
            this.txtSupplierAddress = new System.Windows.Forms.TextBox();
            this.txtSupplierName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdSupplier)).BeginInit();
            this.SuspendLayout();
            // 
            // grdSupplier
            // 
            this.grdSupplier.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdSupplier.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grdSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSupplier.Location = new System.Drawing.Point(196, 309);
            this.grdSupplier.Name = "grdSupplier";
            this.grdSupplier.RowHeadersWidth = 62;
            this.grdSupplier.RowTemplate.Height = 28;
            this.grdSupplier.Size = new System.Drawing.Size(760, 262);
            this.grdSupplier.TabIndex = 19;
            // 
            // btnShowSupplier
            // 
            this.btnShowSupplier.Location = new System.Drawing.Point(588, 229);
            this.btnShowSupplier.Name = "btnShowSupplier";
            this.btnShowSupplier.Size = new System.Drawing.Size(133, 55);
            this.btnShowSupplier.TabIndex = 3;
            this.btnShowSupplier.Text = "Show Data";
            this.btnShowSupplier.UseVisualStyleBackColor = true;
            this.btnShowSupplier.Click += new System.EventHandler(this.btnShowSupplier_Click);
            // 
            // btnSupplierInsert
            // 
            this.btnSupplierInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupplierInsert.Location = new System.Drawing.Point(449, 229);
            this.btnSupplierInsert.Name = "btnSupplierInsert";
            this.btnSupplierInsert.Size = new System.Drawing.Size(133, 55);
            this.btnSupplierInsert.TabIndex = 2;
            this.btnSupplierInsert.Text = "Insert";
            this.btnSupplierInsert.UseVisualStyleBackColor = true;
            this.btnSupplierInsert.Click += new System.EventHandler(this.btnSupplierInsert_Click);
            // 
            // txtSupplierAddress
            // 
            this.txtSupplierAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupplierAddress.Location = new System.Drawing.Point(429, 173);
            this.txtSupplierAddress.Multiline = true;
            this.txtSupplierAddress.Name = "txtSupplierAddress";
            this.txtSupplierAddress.Size = new System.Drawing.Size(342, 38);
            this.txtSupplierAddress.TabIndex = 1;
            // 
            // txtSupplierName
            // 
            this.txtSupplierName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupplierName.Location = new System.Drawing.Point(429, 125);
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.Size = new System.Drawing.Size(342, 35);
            this.txtSupplierName.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(191, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 29);
            this.label3.TabIndex = 12;
            this.label3.Text = "Supplier Address : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(215, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 29);
            this.label2.TabIndex = 11;
            this.label2.Text = "Supplier Name : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(498, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 32);
            this.label1.TabIndex = 10;
            this.label1.Text = "Supplier";
            // 
            // FrmSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 657);
            this.Controls.Add(this.grdSupplier);
            this.Controls.Add(this.btnShowSupplier);
            this.Controls.Add(this.btnSupplierInsert);
            this.Controls.Add(this.txtSupplierAddress);
            this.Controls.Add(this.txtSupplierName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmSupplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSupplier";
            ((System.ComponentModel.ISupportInitialize)(this.grdSupplier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdSupplier;
        private System.Windows.Forms.Button btnShowSupplier;
        private System.Windows.Forms.Button btnSupplierInsert;
        private System.Windows.Forms.TextBox txtSupplierAddress;
        private System.Windows.Forms.TextBox txtSupplierName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
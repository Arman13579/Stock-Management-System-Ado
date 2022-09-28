
namespace Ex_001
{
    partial class FrmCustomer
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
            this.grdCustomer = new System.Windows.Forms.DataGridView();
            this.btnShowCustomer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // grdCustomer
            // 
            this.grdCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdCustomer.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grdCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCustomer.Location = new System.Drawing.Point(69, 253);
            this.grdCustomer.Name = "grdCustomer";
            this.grdCustomer.RowHeadersWidth = 62;
            this.grdCustomer.RowTemplate.Height = 28;
            this.grdCustomer.Size = new System.Drawing.Size(999, 357);
            this.grdCustomer.TabIndex = 23;
            // 
            // btnShowCustomer
            // 
            this.btnShowCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowCustomer.Location = new System.Drawing.Point(458, 146);
            this.btnShowCustomer.Name = "btnShowCustomer";
            this.btnShowCustomer.Size = new System.Drawing.Size(148, 58);
            this.btnShowCustomer.TabIndex = 3;
            this.btnShowCustomer.Text = "Show Data";
            this.btnShowCustomer.UseVisualStyleBackColor = true;
            this.btnShowCustomer.Click += new System.EventHandler(this.btnShowCustomer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(464, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 32);
            this.label1.TabIndex = 12;
            this.label1.Text = "Customer";
            // 
            // FrmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1126, 622);
            this.Controls.Add(this.grdCustomer);
            this.Controls.Add(this.btnShowCustomer);
            this.Controls.Add(this.label1);
            this.Name = "FrmCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCustomer";
            ((System.ComponentModel.ISupportInitialize)(this.grdCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdCustomer;
        private System.Windows.Forms.Button btnShowCustomer;
        private System.Windows.Forms.Label label1;
    }
}
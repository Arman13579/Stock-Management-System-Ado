
namespace Ex_001
{
    partial class FrmCategory
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
            this.grdCategory = new System.Windows.Forms.DataGridView();
            this.btnShowCategory = new System.Windows.Forms.Button();
            this.btnInsetCategory = new System.Windows.Forms.Button();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // grdCategory
            // 
            this.grdCategory.AllowUserToOrderColumns = true;
            this.grdCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdCategory.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grdCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCategory.Location = new System.Drawing.Point(176, 321);
            this.grdCategory.Name = "grdCategory";
            this.grdCategory.RowHeadersWidth = 62;
            this.grdCategory.RowTemplate.Height = 28;
            this.grdCategory.Size = new System.Drawing.Size(767, 242);
            this.grdCategory.TabIndex = 22;
            // 
            // btnShowCategory
            // 
            this.btnShowCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowCategory.Location = new System.Drawing.Point(603, 233);
            this.btnShowCategory.Name = "btnShowCategory";
            this.btnShowCategory.Size = new System.Drawing.Size(166, 60);
            this.btnShowCategory.TabIndex = 19;
            this.btnShowCategory.Text = "Show Category";
            this.btnShowCategory.UseVisualStyleBackColor = true;
            this.btnShowCategory.Click += new System.EventHandler(this.btnShowCategory_Click);
            // 
            // btnInsetCategory
            // 
            this.btnInsetCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsetCategory.Location = new System.Drawing.Point(453, 233);
            this.btnInsetCategory.Name = "btnInsetCategory";
            this.btnInsetCategory.Size = new System.Drawing.Size(128, 60);
            this.btnInsetCategory.TabIndex = 18;
            this.btnInsetCategory.Text = "Insert";
            this.btnInsetCategory.UseVisualStyleBackColor = true;
            this.btnInsetCategory.Click += new System.EventHandler(this.btnInsetCategory_Click);
            // 
            // txtCategory
            // 
            this.txtCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategory.Location = new System.Drawing.Point(424, 151);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(362, 35);
            this.txtCategory.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(219, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 29);
            this.label2.TabIndex = 15;
            this.label2.Text = "Category Name : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(496, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 32);
            this.label1.TabIndex = 16;
            this.label1.Text = "Category";
            // 
            // FrmCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 661);
            this.Controls.Add(this.grdCategory);
            this.Controls.Add(this.btnShowCategory);
            this.Controls.Add(this.btnInsetCategory);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCategory";
            ((System.ComponentModel.ISupportInitialize)(this.grdCategory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdCategory;
        private System.Windows.Forms.Button btnShowCategory;
        private System.Windows.Forms.Button btnInsetCategory;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
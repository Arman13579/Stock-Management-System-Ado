
namespace Ex_001
{
    partial class FrmEmployee
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
            this.grdEmployee = new System.Windows.Forms.DataGridView();
            this.btnShowEmp = new System.Windows.Forms.Button();
            this.btnEmpInsert = new System.Windows.Forms.Button();
            this.txtEmpAddress = new System.Windows.Forms.TextBox();
            this.txtEmpPhone = new System.Windows.Forms.TextBox();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // grdEmployee
            // 
            this.grdEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdEmployee.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grdEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdEmployee.Location = new System.Drawing.Point(77, 399);
            this.grdEmployee.Name = "grdEmployee";
            this.grdEmployee.RowHeadersWidth = 62;
            this.grdEmployee.RowTemplate.Height = 28;
            this.grdEmployee.Size = new System.Drawing.Size(999, 240);
            this.grdEmployee.TabIndex = 35;
            // 
            // btnShowEmp
            // 
            this.btnShowEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowEmp.Location = new System.Drawing.Point(602, 299);
            this.btnShowEmp.Name = "btnShowEmp";
            this.btnShowEmp.Size = new System.Drawing.Size(158, 58);
            this.btnShowEmp.TabIndex = 4;
            this.btnShowEmp.Text = "Show Data";
            this.btnShowEmp.UseVisualStyleBackColor = true;
            this.btnShowEmp.Click += new System.EventHandler(this.btnShowEmp_Click);
            // 
            // btnEmpInsert
            // 
            this.btnEmpInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpInsert.Location = new System.Drawing.Point(448, 299);
            this.btnEmpInsert.Name = "btnEmpInsert";
            this.btnEmpInsert.Size = new System.Drawing.Size(126, 58);
            this.btnEmpInsert.TabIndex = 3;
            this.btnEmpInsert.Text = "Insert";
            this.btnEmpInsert.UseVisualStyleBackColor = true;
            this.btnEmpInsert.Click += new System.EventHandler(this.btnEmpInsert_Click);
            // 
            // txtEmpAddress
            // 
            this.txtEmpAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpAddress.Location = new System.Drawing.Point(430, 173);
            this.txtEmpAddress.Name = "txtEmpAddress";
            this.txtEmpAddress.Size = new System.Drawing.Size(330, 35);
            this.txtEmpAddress.TabIndex = 1;
            // 
            // txtEmpPhone
            // 
            this.txtEmpPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpPhone.Location = new System.Drawing.Point(430, 224);
            this.txtEmpPhone.Name = "txtEmpPhone";
            this.txtEmpPhone.Size = new System.Drawing.Size(330, 35);
            this.txtEmpPhone.TabIndex = 2;
            // 
            // txtEmpName
            // 
            this.txtEmpName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpName.Location = new System.Drawing.Point(430, 122);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(330, 35);
            this.txtEmpName.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(320, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 29);
            this.label4.TabIndex = 27;
            this.label4.Text = "Phone :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(289, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 29);
            this.label3.TabIndex = 26;
            this.label3.Text = "Address :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(203, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 29);
            this.label2.TabIndex = 25;
            this.label2.Text = "Employee Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(511, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 37);
            this.label1.TabIndex = 24;
            this.label1.Text = "Employee";
            // 
            // FrmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1152, 700);
            this.Controls.Add(this.grdEmployee);
            this.Controls.Add(this.btnShowEmp);
            this.Controls.Add(this.btnEmpInsert);
            this.Controls.Add(this.txtEmpAddress);
            this.Controls.Add(this.txtEmpPhone);
            this.Controls.Add(this.txtEmpName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEmployee";
            ((System.ComponentModel.ISupportInitialize)(this.grdEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdEmployee;
        private System.Windows.Forms.Button btnShowEmp;
        private System.Windows.Forms.Button btnEmpInsert;
        private System.Windows.Forms.TextBox txtEmpAddress;
        private System.Windows.Forms.TextBox txtEmpPhone;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
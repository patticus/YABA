namespace YABA
{
    partial class Form2
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
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAccNumber = new System.Windows.Forms.TextBox();
            this.lblAccNumber = new System.Windows.Forms.Label();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.lblBalance = new System.Windows.Forms.Label();
            this.txtOverdraft = new System.Windows.Forms.TextBox();
            this.lblOverdraft = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSaveForm2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(48, 32);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(103, 29);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(181, 22);
            this.txtName.TabIndex = 1;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(103, 57);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(181, 22);
            this.txtAddress.TabIndex = 3;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(33, 60);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(64, 17);
            this.lblAddress.TabIndex = 2;
            this.lblAddress.Text = "Address:";
            // 
            // txtAccNumber
            // 
            this.txtAccNumber.Location = new System.Drawing.Point(103, 85);
            this.txtAccNumber.Name = "txtAccNumber";
            this.txtAccNumber.Size = new System.Drawing.Size(181, 22);
            this.txtAccNumber.TabIndex = 5;
            // 
            // lblAccNumber
            // 
            this.lblAccNumber.AutoSize = true;
            this.lblAccNumber.Location = new System.Drawing.Point(22, 88);
            this.lblAccNumber.Name = "lblAccNumber";
            this.lblAccNumber.Size = new System.Drawing.Size(75, 17);
            this.lblAccNumber.TabIndex = 4;
            this.lblAccNumber.Text = "Account #:";
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(103, 113);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(181, 22);
            this.txtBalance.TabIndex = 7;
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(34, 113);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(63, 17);
            this.lblBalance.TabIndex = 6;
            this.lblBalance.Text = "Balance:";
            // 
            // txtOverdraft
            // 
            this.txtOverdraft.Location = new System.Drawing.Point(103, 141);
            this.txtOverdraft.Name = "txtOverdraft";
            this.txtOverdraft.Size = new System.Drawing.Size(181, 22);
            this.txtOverdraft.TabIndex = 9;
            // 
            // lblOverdraft
            // 
            this.lblOverdraft.AutoSize = true;
            this.lblOverdraft.Location = new System.Drawing.Point(25, 141);
            this.lblOverdraft.Name = "lblOverdraft";
            this.lblOverdraft.Size = new System.Drawing.Size(72, 17);
            this.lblOverdraft.TabIndex = 8;
            this.lblOverdraft.Text = "Overdraft:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(209, 201);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 31);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSaveForm2
            // 
            this.btnSaveForm2.Location = new System.Drawing.Point(103, 201);
            this.btnSaveForm2.Name = "btnSaveForm2";
            this.btnSaveForm2.Size = new System.Drawing.Size(75, 31);
            this.btnSaveForm2.TabIndex = 11;
            this.btnSaveForm2.Text = "Save";
            this.btnSaveForm2.UseVisualStyleBackColor = true;
            this.btnSaveForm2.Click += new System.EventHandler(this.btnSaveForm2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 264);
            this.Controls.Add(this.btnSaveForm2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtOverdraft);
            this.Controls.Add(this.lblOverdraft);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.txtAccNumber);
            this.Controls.Add(this.lblAccNumber);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblAccNumber;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblOverdraft;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSaveForm2;
        public System.Windows.Forms.TextBox txtName;
        public System.Windows.Forms.TextBox txtAddress;
        public System.Windows.Forms.TextBox txtAccNumber;
        public System.Windows.Forms.TextBox txtBalance;
        public System.Windows.Forms.TextBox txtOverdraft;
    }
}
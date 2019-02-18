namespace YABA
{
    partial class Form3
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
            this.btnSaveForm2 = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtOverdraft = new System.Windows.Forms.TextBox();
            this.lblOverdraft = new System.Windows.Forms.Label();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.lblBalance = new System.Windows.Forms.Label();
            this.txtAccNumber = new System.Windows.Forms.TextBox();
            this.lblAccNumber = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAccountState = new System.Windows.Forms.Label();
            this.txtAccountState = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSaveForm2
            // 
            this.btnSaveForm2.Location = new System.Drawing.Point(120, 243);
            this.btnSaveForm2.Name = "btnSaveForm2";
            this.btnSaveForm2.Size = new System.Drawing.Size(75, 31);
            this.btnSaveForm2.TabIndex = 23;
            this.btnSaveForm2.Text = "Save";
            this.btnSaveForm2.UseVisualStyleBackColor = true;
            this.btnSaveForm2.Click += new System.EventHandler(this.btnSaveForm2_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(226, 243);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 31);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtOverdraft
            // 
            this.txtOverdraft.Location = new System.Drawing.Point(120, 183);
            this.txtOverdraft.Name = "txtOverdraft";
            this.txtOverdraft.Size = new System.Drawing.Size(181, 22);
            this.txtOverdraft.TabIndex = 21;
            // 
            // lblOverdraft
            // 
            this.lblOverdraft.AutoSize = true;
            this.lblOverdraft.Location = new System.Drawing.Point(42, 183);
            this.lblOverdraft.Name = "lblOverdraft";
            this.lblOverdraft.Size = new System.Drawing.Size(72, 17);
            this.lblOverdraft.TabIndex = 20;
            this.lblOverdraft.Text = "Overdraft:";
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(120, 155);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(181, 22);
            this.txtBalance.TabIndex = 19;
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(51, 155);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(63, 17);
            this.lblBalance.TabIndex = 18;
            this.lblBalance.Text = "Balance:";
            // 
            // txtAccNumber
            // 
            this.txtAccNumber.Location = new System.Drawing.Point(120, 127);
            this.txtAccNumber.Name = "txtAccNumber";
            this.txtAccNumber.Size = new System.Drawing.Size(181, 22);
            this.txtAccNumber.TabIndex = 17;
            // 
            // lblAccNumber
            // 
            this.lblAccNumber.AutoSize = true;
            this.lblAccNumber.Location = new System.Drawing.Point(39, 130);
            this.lblAccNumber.Name = "lblAccNumber";
            this.lblAccNumber.Size = new System.Drawing.Size(75, 17);
            this.lblAccNumber.TabIndex = 16;
            this.lblAccNumber.Text = "Account #:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(120, 99);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(181, 22);
            this.txtAddress.TabIndex = 15;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(50, 102);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(64, 17);
            this.lblAddress.TabIndex = 14;
            this.lblAddress.Text = "Address:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(120, 71);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(181, 22);
            this.txtName.TabIndex = 13;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(65, 74);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 17);
            this.lblName.TabIndex = 12;
            this.lblName.Text = "Name:";
            // 
            // lblAccountState
            // 
            this.lblAccountState.AutoSize = true;
            this.lblAccountState.Location = new System.Drawing.Point(14, 46);
            this.lblAccountState.Name = "lblAccountState";
            this.lblAccountState.Size = new System.Drawing.Size(100, 17);
            this.lblAccountState.TabIndex = 12;
            this.lblAccountState.Text = "Account State:";
            // 
            // txtAccountState
            // 
            this.txtAccountState.Location = new System.Drawing.Point(120, 43);
            this.txtAccountState.Name = "txtAccountState";
            this.txtAccountState.Size = new System.Drawing.Size(181, 22);
            this.txtAccountState.TabIndex = 13;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 306);
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
            this.Controls.Add(this.txtAccountState);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblAccountState);
            this.Controls.Add(this.lblName);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaveForm2;
        private System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.TextBox txtOverdraft;
        private System.Windows.Forms.Label lblOverdraft;
        public System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.Label lblBalance;
        public System.Windows.Forms.TextBox txtAccNumber;
        private System.Windows.Forms.Label lblAccNumber;
        public System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        public System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAccountState;
        public System.Windows.Forms.TextBox txtAccountState;
    }
}
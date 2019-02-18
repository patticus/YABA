namespace YABA
{
    partial class Form1
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
            this.btnShow = new System.Windows.Forms.Button();
            this.btnAddNewAccount = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnEditAccount = new System.Windows.Forms.Button();
            this.txtEditAccount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(477, 106);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 0;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnAddNewAccount
            // 
            this.btnAddNewAccount.Location = new System.Drawing.Point(254, 99);
            this.btnAddNewAccount.Name = "btnAddNewAccount";
            this.btnAddNewAccount.Size = new System.Drawing.Size(154, 36);
            this.btnAddNewAccount.TabIndex = 1;
            this.btnAddNewAccount.Text = "Add New Account";
            this.btnAddNewAccount.UseVisualStyleBackColor = true;
            this.btnAddNewAccount.Click += new System.EventHandler(this.btnAddNewAccount_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(43, 186);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(697, 228);
            this.listBox1.TabIndex = 2;
            // 
            // btnEditAccount
            // 
            this.btnEditAccount.Location = new System.Drawing.Point(255, 154);
            this.btnEditAccount.Name = "btnEditAccount";
            this.btnEditAccount.Size = new System.Drawing.Size(154, 23);
            this.btnEditAccount.TabIndex = 4;
            this.btnEditAccount.Text = "Edit Account";
            this.btnEditAccount.UseVisualStyleBackColor = true;
            this.btnEditAccount.Click += new System.EventHandler(this.btnEditAccount_Click);
            // 
            // txtEditAccount
            // 
            this.txtEditAccount.Location = new System.Drawing.Point(416, 154);
            this.txtEditAccount.Name = "txtEditAccount";
            this.txtEditAccount.Size = new System.Drawing.Size(31, 22);
            this.txtEditAccount.TabIndex = 5;
            this.txtEditAccount.TextChanged += new System.EventHandler(this.txtEditAccount_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtEditAccount);
            this.Controls.Add(this.btnEditAccount);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnAddNewAccount);
            this.Controls.Add(this.btnShow);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnShow;
        public System.Windows.Forms.Button btnAddNewAccount;
        public System.Windows.Forms.ListBox listBox1;
        public System.Windows.Forms.Button btnEditAccount;
        public System.Windows.Forms.TextBox txtEditAccount;
    }
}


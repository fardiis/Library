namespace LibraryUI.Forms.BaseInformation.Date
{
    partial class SabtAmanat
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnsabt = new System.Windows.Forms.Button();
            this.btncancrl = new System.Windows.Forms.Button();
            this.bindingSourceBookType = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceKarbar = new System.Windows.Forms.BindingSource(this.components);
            this.cmbUser = new System.Windows.Forms.ComboBox();
            this.cmbBook = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBookType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceKarbar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(283, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "نام ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(271, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "نام کتاب";
            // 
            // btnsabt
            // 
            this.btnsabt.Location = new System.Drawing.Point(258, 215);
            this.btnsabt.Name = "btnsabt";
            this.btnsabt.Size = new System.Drawing.Size(85, 29);
            this.btnsabt.TabIndex = 6;
            this.btnsabt.Text = "ثبت";
            this.btnsabt.UseVisualStyleBackColor = true;
            this.btnsabt.Click += new System.EventHandler(this.Btnsabt_Click);
            // 
            // btncancrl
            // 
            this.btncancrl.Location = new System.Drawing.Point(49, 215);
            this.btncancrl.Name = "btncancrl";
            this.btncancrl.Size = new System.Drawing.Size(82, 29);
            this.btncancrl.TabIndex = 7;
            this.btncancrl.Text = "انصراف";
            this.btncancrl.UseVisualStyleBackColor = true;
            // 
            // cmbUser
            // 
            this.cmbUser.FormattingEnabled = true;
            this.cmbUser.Location = new System.Drawing.Point(79, 39);
            this.cmbUser.Name = "cmbUser";
            this.cmbUser.Size = new System.Drawing.Size(121, 24);
            this.cmbUser.TabIndex = 9;
            // 
            // cmbBook
            // 
            this.cmbBook.FormattingEnabled = true;
            this.cmbBook.Location = new System.Drawing.Point(79, 121);
            this.cmbBook.Name = "cmbBook";
            this.cmbBook.Size = new System.Drawing.Size(121, 24);
            this.cmbBook.TabIndex = 10;
            // 
            // SabtAmanat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 363);
            this.Controls.Add(this.cmbBook);
            this.Controls.Add(this.cmbUser);
            this.Controls.Add(this.btncancrl);
            this.Controls.Add(this.btnsabt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "SabtAmanat";
            this.Text = "SabtAmanat";
            this.Load += new System.EventHandler(this.SabtAmanat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBookType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceKarbar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnsabt;
        private System.Windows.Forms.Button btncancrl;
        private System.Windows.Forms.BindingSource bindingSourceBookType;
        private System.Windows.Forms.BindingSource bindingSourceKarbar;
        private System.Windows.Forms.ComboBox cmbUser;
        private System.Windows.Forms.ComboBox cmbBook;
    }
}
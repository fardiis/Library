namespace LibraryUI.Forms
{
    partial class Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.اطلاعاتپایهنرمافزارToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBookType = new System.Windows.Forms.ToolStripMenuItem();
            this.ثبتکتابToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.لیستکاربرانToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.امانتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ثبتامانتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.لیستاماناتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.اطلاعاتپایهنرمافزارToolStripMenuItem,
            this.امانتToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // اطلاعاتپایهنرمافزارToolStripMenuItem
            // 
            this.اطلاعاتپایهنرمافزارToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBookType,
            this.ثبتکتابToolStripMenuItem,
            this.لیستکاربرانToolStripMenuItem});
            this.اطلاعاتپایهنرمافزارToolStripMenuItem.Name = "اطلاعاتپایهنرمافزارToolStripMenuItem";
            this.اطلاعاتپایهنرمافزارToolStripMenuItem.Size = new System.Drawing.Size(154, 24);
            this.اطلاعاتپایهنرمافزارToolStripMenuItem.Text = "اطلاعات پایه نرم افزار";
            // 
            // mnuBookType
            // 
            this.mnuBookType.Name = "mnuBookType";
            this.mnuBookType.Size = new System.Drawing.Size(216, 26);
            this.mnuBookType.Text = "انواع کتاب";
            this.mnuBookType.Click += new System.EventHandler(this.MnuBookType_Click);
            // 
            // ثبتکتابToolStripMenuItem
            // 
            this.ثبتکتابToolStripMenuItem.Name = "ثبتکتابToolStripMenuItem";
            this.ثبتکتابToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.ثبتکتابToolStripMenuItem.Text = "ثبت کتاب";
            this.ثبتکتابToolStripMenuItem.Click += new System.EventHandler(this.ثبتکتابToolStripMenuItem_Click);
            // 
            // لیستکاربرانToolStripMenuItem
            // 
            this.لیستکاربرانToolStripMenuItem.Name = "لیستکاربرانToolStripMenuItem";
            this.لیستکاربرانToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.لیستکاربرانToolStripMenuItem.Text = "لیست کاربران";
            this.لیستکاربرانToolStripMenuItem.Click += new System.EventHandler(this.لیستکاربرانToolStripMenuItem_Click);
            // 
            // امانتToolStripMenuItem
            // 
            this.امانتToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ثبتامانتToolStripMenuItem,
            this.لیستاماناتToolStripMenuItem});
            this.امانتToolStripMenuItem.Name = "امانتToolStripMenuItem";
            this.امانتToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.امانتToolStripMenuItem.Text = "امانت";
            // 
            // ثبتامانتToolStripMenuItem
            // 
            this.ثبتامانتToolStripMenuItem.Name = "ثبتامانتToolStripMenuItem";
            this.ثبتامانتToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.ثبتامانتToolStripMenuItem.Text = "ثبت امانت";
            this.ثبتامانتToolStripMenuItem.Click += new System.EventHandler(this.ثبتامانتToolStripMenuItem_Click);
            // 
            // لیستاماناتToolStripMenuItem
            // 
            this.لیستاماناتToolStripMenuItem.Name = "لیستاماناتToolStripMenuItem";
            this.لیستاماناتToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.لیستاماناتToolStripMenuItem.Text = "لیست امانات";
            this.لیستاماناتToolStripMenuItem.Click += new System.EventHandler(this.لیستاماناتToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Main";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem اطلاعاتپایهنرمافزارToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuBookType;
        private System.Windows.Forms.ToolStripMenuItem ثبتکتابToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem لیستکاربرانToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem امانتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ثبتامانتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem لیستاماناتToolStripMenuItem;
    }
}
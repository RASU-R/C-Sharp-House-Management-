namespace House
{
    partial class Home
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.masterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ledgersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblDate = new System.Windows.Forms.ToolStripMenuItem();
            this.lblWelcome = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masterToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.reportToolStripMenuItem,
            this.windowsToolStripMenuItem,
            this.itToolStripMenuItem,
            this.lblDate,
            this.lblWelcome});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.windowsToolStripMenuItem;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(863, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // masterToolStripMenuItem
            // 
            this.masterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ledgersToolStripMenuItem,
            this.transactionToolStripMenuItem});
            this.masterToolStripMenuItem.Name = "masterToolStripMenuItem";
            this.masterToolStripMenuItem.Size = new System.Drawing.Size(99, 19);
            this.masterToolStripMenuItem.Text = "House Manage";
            this.masterToolStripMenuItem.Click += new System.EventHandler(this.masterToolStripMenuItem_Click);
            // 
            // ledgersToolStripMenuItem
            // 
            this.ledgersToolStripMenuItem.Name = "ledgersToolStripMenuItem";
            this.ledgersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ledgersToolStripMenuItem.Text = "Family Members";
            this.ledgersToolStripMenuItem.Click += new System.EventHandler(this.ledgersToolStripMenuItem_Click);
            // 
            // transactionToolStripMenuItem
            // 
            this.transactionToolStripMenuItem.Name = "transactionToolStripMenuItem";
            this.transactionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.transactionToolStripMenuItem.Text = "Shopping Details";
            this.transactionToolStripMenuItem.Click += new System.EventHandler(this.transactionToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 19);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(54, 19);
            this.reportToolStripMenuItem.Text = "Report";
            this.reportToolStripMenuItem.Click += new System.EventHandler(this.reportToolStripMenuItem_Click);
            // 
            // windowsToolStripMenuItem
            // 
            this.windowsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeAllToolStripMenuItem});
            this.windowsToolStripMenuItem.Name = "windowsToolStripMenuItem";
            this.windowsToolStripMenuItem.Size = new System.Drawing.Size(68, 19);
            this.windowsToolStripMenuItem.Text = "Windows";
            // 
            // closeAllToolStripMenuItem
            // 
            this.closeAllToolStripMenuItem.Name = "closeAllToolStripMenuItem";
            this.closeAllToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.closeAllToolStripMenuItem.Text = "Close All";
            this.closeAllToolStripMenuItem.Click += new System.EventHandler(this.closeAllToolStripMenuItem_Click);
            // 
            // itToolStripMenuItem
            // 
            this.itToolStripMenuItem.Name = "itToolStripMenuItem";
            this.itToolStripMenuItem.Size = new System.Drawing.Size(38, 19);
            this.itToolStripMenuItem.Text = "Exit";
            this.itToolStripMenuItem.Click += new System.EventHandler(this.itToolStripMenuItem_Click);
            // 
            // lblDate
            // 
            this.lblDate.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(67, 19);
            this.lblDate.Text = "00:00:00";
            // 
            // lblWelcome
            // 
            this.lblWelcome.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(72, 19);
            this.lblWelcome.Text = "Welcome";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.Home_Load);
            // 
            // Home
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(863, 588);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Home";
            this.Text = "House Management System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Home_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem masterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ledgersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lblDate;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem windowsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lblWelcome;
    }
}
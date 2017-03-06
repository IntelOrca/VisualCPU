namespace VisualCPU
{
	partial class MainForm
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
			if (disposing && (components != null)) {
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
			this.tmrUpdate = new System.Windows.Forms.Timer(this.components);
			this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
			this.visualCPUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.refreshProcessesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.memoryProportionalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.threadsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.windowsOnlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.applicationWebsiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.checkForUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.aboutVisualCPUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.statusStrip = new System.Windows.Forms.StatusStrip();
			this.lblVisibleProcesses = new System.Windows.Forms.ToolStripStatusLabel();
			this.lblVisibleThreads = new System.Windows.Forms.ToolStripStatusLabel();
			this.lblMemoryPercentage = new System.Windows.Forms.ToolStripStatusLabel();
			this.tmrRefresh = new System.Windows.Forms.Timer(this.components);
			this.tmrDraw = new System.Windows.Forms.Timer(this.components);
			this.mainMenuStrip.SuspendLayout();
			this.statusStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// tmrUpdate
			// 
			this.tmrUpdate.Enabled = true;
			this.tmrUpdate.Tick += new System.EventHandler(this.tmrUpdate_Tick);
			// 
			// mainMenuStrip
			// 
			this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visualCPUToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
			this.mainMenuStrip.Name = "mainMenuStrip";
			this.mainMenuStrip.Size = new System.Drawing.Size(517, 24);
			this.mainMenuStrip.TabIndex = 0;
			this.mainMenuStrip.Text = "menuStrip1";
			// 
			// visualCPUToolStripMenuItem
			// 
			this.visualCPUToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem,
            this.refreshProcessesToolStripMenuItem,
            this.toolStripSeparator2,
            this.optionsToolStripMenuItem,
            this.toolStripSeparator3,
            this.exitToolStripMenuItem});
			this.visualCPUToolStripMenuItem.Name = "visualCPUToolStripMenuItem";
			this.visualCPUToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
			this.visualCPUToolStripMenuItem.Text = "VisualCPU";
			// 
			// clearToolStripMenuItem
			// 
			this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
			this.clearToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Delete)));
			this.clearToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
			this.clearToolStripMenuItem.Text = "Clear";
			this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
			// 
			// refreshProcessesToolStripMenuItem
			// 
			this.refreshProcessesToolStripMenuItem.Name = "refreshProcessesToolStripMenuItem";
			this.refreshProcessesToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
			this.refreshProcessesToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
			this.refreshProcessesToolStripMenuItem.Text = "Refresh Processes";
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(183, 6);
			// 
			// optionsToolStripMenuItem
			// 
			this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
			this.optionsToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
			this.optionsToolStripMenuItem.Text = "Options";
			this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(183, 6);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// viewToolStripMenuItem
			// 
			this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.memoryProportionalToolStripMenuItem,
            this.toolStripSeparator4,
            this.threadsToolStripMenuItem,
            this.usersToolStripMenuItem,
            this.windowsOnlyToolStripMenuItem});
			this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
			this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.viewToolStripMenuItem.Text = "View";
			// 
			// memoryProportionalToolStripMenuItem
			// 
			this.memoryProportionalToolStripMenuItem.Name = "memoryProportionalToolStripMenuItem";
			this.memoryProportionalToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
			this.memoryProportionalToolStripMenuItem.Size = new System.Drawing.Size(290, 22);
			this.memoryProportionalToolStripMenuItem.Text = "Proportional to Max Memory";
			this.memoryProportionalToolStripMenuItem.Click += new System.EventHandler(this.memoryProportionalToolStripMenuItem_Click);
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(287, 6);
			// 
			// threadsToolStripMenuItem
			// 
			this.threadsToolStripMenuItem.Name = "threadsToolStripMenuItem";
			this.threadsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
			this.threadsToolStripMenuItem.Size = new System.Drawing.Size(290, 22);
			this.threadsToolStripMenuItem.Text = "Show Threads";
			this.threadsToolStripMenuItem.Click += new System.EventHandler(this.threadsToolStripMenuItem_Click);
			// 
			// usersToolStripMenuItem
			// 
			this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
			this.usersToolStripMenuItem.Size = new System.Drawing.Size(290, 22);
			this.usersToolStripMenuItem.Text = "Show Users";
			// 
			// windowsOnlyToolStripMenuItem
			// 
			this.windowsOnlyToolStripMenuItem.Name = "windowsOnlyToolStripMenuItem";
			this.windowsOnlyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
			this.windowsOnlyToolStripMenuItem.Size = new System.Drawing.Size(290, 22);
			this.windowsOnlyToolStripMenuItem.Text = "Show Windowed Processes Only";
			this.windowsOnlyToolStripMenuItem.Click += new System.EventHandler(this.windowsOnlyToolStripMenuItem_Click);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applicationWebsiteToolStripMenuItem,
            this.checkForUpdatesToolStripMenuItem,
            this.toolStripSeparator1,
            this.aboutVisualCPUToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "Help";
			// 
			// applicationWebsiteToolStripMenuItem
			// 
			this.applicationWebsiteToolStripMenuItem.Name = "applicationWebsiteToolStripMenuItem";
			this.applicationWebsiteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.applicationWebsiteToolStripMenuItem.Text = "Application Website";
			this.applicationWebsiteToolStripMenuItem.Click += new System.EventHandler(this.applicationWebsiteToolStripMenuItem_Click);
			// 
			// checkForUpdatesToolStripMenuItem
			// 
			this.checkForUpdatesToolStripMenuItem.Name = "checkForUpdatesToolStripMenuItem";
			this.checkForUpdatesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.checkForUpdatesToolStripMenuItem.Text = "Check for Updates";
			this.checkForUpdatesToolStripMenuItem.Click += new System.EventHandler(this.checkForUpdatesToolStripMenuItem_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
			// 
			// aboutVisualCPUToolStripMenuItem
			// 
			this.aboutVisualCPUToolStripMenuItem.Name = "aboutVisualCPUToolStripMenuItem";
			this.aboutVisualCPUToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.aboutVisualCPUToolStripMenuItem.Text = "About VisualCPU";
			this.aboutVisualCPUToolStripMenuItem.Click += new System.EventHandler(this.aboutVisualCPUToolStripMenuItem_Click);
			// 
			// statusStrip
			// 
			this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblVisibleProcesses,
            this.lblVisibleThreads,
            this.lblMemoryPercentage});
			this.statusStrip.Location = new System.Drawing.Point(0, 242);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.Size = new System.Drawing.Size(517, 22);
			this.statusStrip.TabIndex = 1;
			this.statusStrip.Text = "statusStrip1";
			// 
			// lblVisibleProcesses
			// 
			this.lblVisibleProcesses.Name = "lblVisibleProcesses";
			this.lblVisibleProcesses.Size = new System.Drawing.Size(84, 17);
			this.lblVisibleProcesses.Text = "0 / 0 Processes";
			// 
			// lblVisibleThreads
			// 
			this.lblVisibleThreads.Name = "lblVisibleThreads";
			this.lblVisibleThreads.Size = new System.Drawing.Size(75, 17);
			this.lblVisibleThreads.Text = "0 / 0 Threads";
			// 
			// lblMemoryPercentage
			// 
			this.lblMemoryPercentage.Name = "lblMemoryPercentage";
			this.lblMemoryPercentage.Size = new System.Drawing.Size(23, 17);
			this.lblMemoryPercentage.Text = "0%";
			// 
			// tmrRefresh
			// 
			this.tmrRefresh.Enabled = true;
			this.tmrRefresh.Interval = 5000;
			this.tmrRefresh.Tick += new System.EventHandler(this.tmrRefresh_Tick);
			// 
			// tmrDraw
			// 
			this.tmrDraw.Enabled = true;
			this.tmrDraw.Tick += new System.EventHandler(this.tmrDraw_Tick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(517, 264);
			this.Controls.Add(this.statusStrip);
			this.Controls.Add(this.mainMenuStrip);
			this.DoubleBuffered = true;
			this.MainMenuStrip = this.mainMenuStrip;
			this.Name = "MainForm";
			this.Text = "VisualCPU";
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
			this.mainMenuStrip.ResumeLayout(false);
			this.mainMenuStrip.PerformLayout();
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Timer tmrUpdate;
		private System.Windows.Forms.MenuStrip mainMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem memoryProportionalToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem windowsOnlyToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem threadsToolStripMenuItem;
		private System.Windows.Forms.StatusStrip statusStrip;
		private System.Windows.Forms.ToolStripStatusLabel lblVisibleProcesses;
		private System.Windows.Forms.ToolStripStatusLabel lblVisibleThreads;
		private System.Windows.Forms.Timer tmrRefresh;
		private System.Windows.Forms.Timer tmrDraw;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutVisualCPUToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem checkForUpdatesToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem visualCPUToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem applicationWebsiteToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem refreshProcessesToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripStatusLabel lblMemoryPercentage;
		private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
	}
}


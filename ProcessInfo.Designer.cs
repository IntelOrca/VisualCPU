namespace VisualCPU
{
	partial class ProcessInfo
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
			this.lblProcessName = new System.Windows.Forms.Label();
			this.lblProcessId = new System.Windows.Forms.Label();
			this.lblMemoryUsage = new System.Windows.Forms.Label();
			this.lblThreads = new System.Windows.Forms.Label();
			this.lblFilename = new System.Windows.Forms.Label();
			this.lblRunningTime = new System.Windows.Forms.Label();
			this.lblMainWindow = new System.Windows.Forms.Label();
			this.tmrTimeUpdate = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// lblProcessName
			// 
			this.lblProcessName.AutoSize = true;
			this.lblProcessName.Location = new System.Drawing.Point(12, 14);
			this.lblProcessName.Name = "lblProcessName";
			this.lblProcessName.Size = new System.Drawing.Size(79, 13);
			this.lblProcessName.TabIndex = 0;
			this.lblProcessName.Text = "Process Name:";
			// 
			// lblProcessId
			// 
			this.lblProcessId.AutoSize = true;
			this.lblProcessId.Location = new System.Drawing.Point(12, 37);
			this.lblProcessId.Name = "lblProcessId";
			this.lblProcessId.Size = new System.Drawing.Size(60, 13);
			this.lblProcessId.TabIndex = 1;
			this.lblProcessId.Text = "Process Id:";
			// 
			// lblMemoryUsage
			// 
			this.lblMemoryUsage.AutoSize = true;
			this.lblMemoryUsage.Location = new System.Drawing.Point(12, 60);
			this.lblMemoryUsage.Name = "lblMemoryUsage";
			this.lblMemoryUsage.Size = new System.Drawing.Size(81, 13);
			this.lblMemoryUsage.TabIndex = 2;
			this.lblMemoryUsage.Text = "Memory Usage:";
			// 
			// lblThreads
			// 
			this.lblThreads.AutoSize = true;
			this.lblThreads.Location = new System.Drawing.Point(12, 83);
			this.lblThreads.Name = "lblThreads";
			this.lblThreads.Size = new System.Drawing.Size(49, 13);
			this.lblThreads.TabIndex = 3;
			this.lblThreads.Text = "Threads:";
			// 
			// lblFilename
			// 
			this.lblFilename.AutoSize = true;
			this.lblFilename.Location = new System.Drawing.Point(12, 106);
			this.lblFilename.Name = "lblFilename";
			this.lblFilename.Size = new System.Drawing.Size(52, 13);
			this.lblFilename.TabIndex = 4;
			this.lblFilename.Text = "Filename:";
			this.lblFilename.Click += new System.EventHandler(this.lblFilename_Click);
			// 
			// lblRunningTime
			// 
			this.lblRunningTime.AutoSize = true;
			this.lblRunningTime.Location = new System.Drawing.Point(12, 129);
			this.lblRunningTime.Name = "lblRunningTime";
			this.lblRunningTime.Size = new System.Drawing.Size(72, 13);
			this.lblRunningTime.TabIndex = 5;
			this.lblRunningTime.Text = "Running time:";
			// 
			// lblMainWindow
			// 
			this.lblMainWindow.AutoSize = true;
			this.lblMainWindow.Location = new System.Drawing.Point(12, 152);
			this.lblMainWindow.Name = "lblMainWindow";
			this.lblMainWindow.Size = new System.Drawing.Size(75, 13);
			this.lblMainWindow.TabIndex = 6;
			this.lblMainWindow.Text = "Main Window:";
			// 
			// tmrTimeUpdate
			// 
			this.tmrTimeUpdate.Enabled = true;
			this.tmrTimeUpdate.Interval = 1000;
			this.tmrTimeUpdate.Tick += new System.EventHandler(this.tmrTimeUpdate_Tick);
			// 
			// ProcessInfo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 180);
			this.Controls.Add(this.lblMainWindow);
			this.Controls.Add(this.lblRunningTime);
			this.Controls.Add(this.lblFilename);
			this.Controls.Add(this.lblThreads);
			this.Controls.Add(this.lblMemoryUsage);
			this.Controls.Add(this.lblProcessId);
			this.Controls.Add(this.lblProcessName);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "ProcessInfo";
			this.Text = "ProcessInfo";
			this.TopMost = true;
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblProcessName;
		private System.Windows.Forms.Label lblProcessId;
		private System.Windows.Forms.Label lblMemoryUsage;
		private System.Windows.Forms.Label lblThreads;
		private System.Windows.Forms.Label lblFilename;
		private System.Windows.Forms.Label lblRunningTime;
		private System.Windows.Forms.Label lblMainWindow;
		private System.Windows.Forms.Timer tmrTimeUpdate;
	}
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace VisualCPU
{
	partial class MainForm : Form
	{
		VCPU mVCPU = new VCPU();
		ProcessInfo mProcessInfo = new ProcessInfo();

		public MainForm()
		{
			InitializeComponent();

			//this.BackgroundImage = Image.FromFile("background.png");
			//randomBackgroundToolStripMenuItem_Click(null, EventArgs.Empty);

			Size = new Size(900, 700);

			RefreshSettings();

			UpdateUserFilterList();

			DoFullRefresh();
		}

		private void UpdateUserFilterList()
		{
			usersToolStripMenuItem.DropDownItems.Clear();

			string[] users = mVCPU.GetAllPossibleUsers();
			foreach (string user in users) {
				ToolStripMenuItem menuItem = new ToolStripMenuItem(user);
				menuItem.Click += new EventHandler(filterUserMenuItem_Click);
				menuItem.Checked = true;

				usersToolStripMenuItem.DropDownItems.Add(menuItem);
			}
		}

		void filterUserMenuItem_Click(object sender, EventArgs e)
		{
			ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;
			string user = menuItem.Text;

			menuItem.Checked = !menuItem.Checked;

			if (menuItem.Checked) {
				mVCPU.HideUsers.Remove(user);
			} else {
				mVCPU.HideUsers.Add(user);
			}

			DoFullRefresh();
		}

		private void tmrUpdate_Tick(object sender, EventArgs e)
		{
			mVCPU.Update();
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);

			mVCPU.Draw(e.Graphics);
		}

		protected override void OnResize(EventArgs e)
		{
			base.OnResize(e);

			mVCPU.Bounds = new Rectangle(0, 0, Width, Height);
			Settings.MainFormWidth = Width;
			Settings.MainFormHeight = Height;
		}

		protected override void OnLocationChanged(EventArgs e)
		{
			base.OnLocationChanged(e);

			Settings.MainFormLeft = Left;
			Settings.MainFormTop = Top;
		}

		protected override void OnResizeEnd(EventArgs e)
		{
			base.OnResizeEnd(e);

			DoFullRefresh();
		}

		private void memoryProportionalToolStripMenuItem_Click(object sender, EventArgs e)
		{
			memoryProportionalToolStripMenuItem.Checked = !memoryProportionalToolStripMenuItem.Checked;
			mVCPU.MaxMemProportional = memoryProportionalToolStripMenuItem.Checked;
			Settings.MemoryProportional = mVCPU.MaxMemProportional;

			DoFullRefresh();
		}

		private void windowsOnlyToolStripMenuItem_Click(object sender, EventArgs e)
		{
			windowsOnlyToolStripMenuItem.Checked = !windowsOnlyToolStripMenuItem.Checked;
			mVCPU.WindowsOnly = windowsOnlyToolStripMenuItem.Checked;
			Settings.ShowWindowsOnly = mVCPU.WindowsOnly;

			DoFullRefresh();
		}

		private void threadsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			threadsToolStripMenuItem.Checked = !threadsToolStripMenuItem.Checked;
			mVCPU.ShowThreads = threadsToolStripMenuItem.Checked;
			Settings.ShowThreads = mVCPU.ShowThreads;

			DoFullRefresh();
		}

		private void MainForm_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left) {
				TaskSnake task = mVCPU.GetTaskAt(e.X, e.Y);
				if (task != null) {
					if (mProcessInfo.IsDisposed)
						mProcessInfo = new ProcessInfo();

					mProcessInfo.SetProcess(task.Process);
					mProcessInfo.Show();
					mProcessInfo.Focus();
				}
			} else if (e.Button == MouseButtons.Right) {
				mVCPU.ProduceShockwave(e.X, e.Y);
			}
		}

		private void refreshProcessesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			DoFullRefresh();
		}

		private void RefreshSettings()
		{
			if (Settings.MemoryProportional != memoryProportionalToolStripMenuItem.Checked)
				memoryProportionalToolStripMenuItem_Click(null, EventArgs.Empty);

			if (Settings.ShowThreads != threadsToolStripMenuItem.Checked)
				threadsToolStripMenuItem_Click(null, EventArgs.Empty);

			if (Settings.ShowWindowsOnly != windowsOnlyToolStripMenuItem.Checked)
				windowsOnlyToolStripMenuItem_Click(null, EventArgs.Empty);

			tmrUpdate.Enabled = (Settings.UpdateSpeed > 0);
			tmrDraw.Enabled = (Settings.DrawSpeed > 0);
			tmrRefresh.Enabled = (Settings.RefreshSpeed > 0);

			if (Settings.UpdateSpeed > 0)
				tmrUpdate.Interval = Settings.UpdateSpeed;
			if (Settings.DrawSpeed > 0)
				tmrDraw.Interval = Settings.DrawSpeed;
			if (Settings.RefreshSpeed > 0)
				tmrRefresh.Interval = Settings.RefreshSpeed;

			//Set image
			MemoryStream ms = new MemoryStream();
			Image img1 = Image.FromFile("background.png");
			img1.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
			img1.Dispose();
			BackgroundImage = Image.FromStream(ms);
			img1.Dispose();
		}

		private void RefreshLabels()
		{
			lblVisibleProcesses.Text = String.Format("{0} / {1} Processes", mVCPU.VisibleProcesses, mVCPU.TotalProcesses);
			lblVisibleThreads.Text = String.Format("{0} / {1} Threads", mVCPU.VisibleThreads, mVCPU.TotalThreads);
			//lblMemoryPercentage.Text = String.Format(""
		}

		private void DoFullRefresh()
		{
			mVCPU.RefreshCPU();
			RefreshLabels();

			Invalidate();
		}

		private void tmrRefresh_Tick(object sender, EventArgs e)
		{
			mVCPU.RefreshCPU();
			RefreshLabels();
		}

		private void tmrDraw_Tick(object sender, EventArgs e)
		{
			Invalidate();
		}

		private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			OptionsForm form = new OptionsForm();
			form.ShowDialog();
			form.Dispose();

			RefreshSettings();

			DoFullRefresh();
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void clearToolStripMenuItem_Click(object sender, EventArgs e)
		{
			mVCPU.Clear();
		}

		private void applicationWebsiteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Process.Start("http://tedtycoon.co.uk/wiki/VisualCPU");
		}

		private void checkForUpdatesToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void aboutVisualCPUToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}
	}
}

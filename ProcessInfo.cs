using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace VisualCPU
{
	partial class ProcessInfo : Form
	{
		private Process mProcess;

		public ProcessInfo()
		{
			InitializeComponent();
		}

		public void SetProcess(Process process)
		{
			mProcess = process;

			lblProcessName.Text = "Process Name: " + process.ProcessName;
			lblProcessId.Text = "Process Id: " + process.Id;
			lblMemoryUsage.Text = "Memory Usage: " + process.WorkingSet64;
			lblThreads.Text = "Threads: " + process.Threads.Count;
			lblMainWindow.Text = "Main Window: " + process.MainWindowTitle;

			ProcessModule mainModule = null;
			try {
				mainModule = process.MainModule;
			} catch {
			}

			if (mainModule == null)
				lblFilename.Text = "Filename: N/A";
			else
				lblFilename.Text = "Filename: " + mainModule.FileName;

			try {
				SetTime(DateTime.Now - process.StartTime);
			} catch {
				SetTime(null);
			}

			UpdateSize();
		}

		private void SetTime(Nullable<TimeSpan> timeSpan)
		{
			if (!timeSpan.HasValue) {
				lblRunningTime.Text = "Running Time: N/A";
				return;
			}

			TimeSpan time = timeSpan.Value;
			string szTime = String.Empty;

			szTime += time.Hours + " hours ";
			szTime += time.Minutes + " minutes ";
			szTime += time.Seconds + " seconds";

			lblRunningTime.Text = "Running Time: " + szTime;

			UpdateSize();
		}

		private void UpdateSize()
		{
			int maxWidth = 0;
			foreach (Control c in this.Controls) {
				maxWidth = Math.Max(maxWidth, c.Width + (c.Left * 2));
			}

			Width = maxWidth;
		}

		private void tmrTimeUpdate_Tick(object sender, EventArgs e)
		{
			if (mProcess == null)
				return;

			SetProcess(Process.GetProcessById(mProcess.Id));

			try {
				SetTime(DateTime.Now - mProcess.StartTime);
			} catch {
				SetTime(null);
			}
		}

		private void lblFilename_Click(object sender, EventArgs e)
		{
			ProcessModule module = null;
			try {
				module = mProcess.MainModule;
			} catch {
			}

			if (module == null)
				return;

			string filePath = module.FileName;
			if (!File.Exists(filePath)) {
				return;
			}

			//Execute explorer file select
			string argument = @"/select, " + filePath;
			Process.Start("explorer.exe", argument);
		}
	}
}

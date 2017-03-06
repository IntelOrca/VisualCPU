using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace VisualCPU
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Settings.LoadValues();

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());

			Settings.SaveValues();
		}
	}
}

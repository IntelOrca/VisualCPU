using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace VisualCPU
{
	partial class OptionsForm : Form
	{
		public OptionsForm()
		{
			InitializeComponent();

			txtHue.Value = Settings.BackgroundHue;
			txtSat.Value = Settings.BackgroundSat;
			chkShowMemorySize.Checked = Settings.ShowMemorySize;

			txtAcceleration.Value = Settings.TaskAcceleration;
			txtResizeSpeed.Value = Settings.TaskResizeSpeed;
			txtDrag.Value = Settings.TaskDrag;
			txtAngularSpeed.Value = Settings.TaskAngularSpeed;
			txtTopSpeed.Value = Settings.TaskTopSpeed;
			txtRange.Value = Settings.ShockwaveRange;
			txtPower.Value = Settings.ShockwavePower;

			txtUpdateSpeed.Value = Settings.UpdateSpeed;
			txtDrawSpeed.Value = Settings.DrawSpeed;
			txtRefreshSpeed.Value = Settings.RefreshSpeed;

			chkAutoCheckForUpdates.Checked = Settings.AutoCheckForUpdates;
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			byte hue = Settings.BackgroundHue;
			byte sat = Settings.BackgroundSat;

			Settings.BackgroundHue = (byte)txtHue.Value;
			Settings.BackgroundSat = (byte)txtSat.Value;
			Settings.ShowMemorySize = chkShowMemorySize.Checked;

			Settings.TaskAcceleration = (float)txtAcceleration.Value;
			Settings.TaskResizeSpeed = (float)txtResizeSpeed.Value;
			Settings.TaskDrag = (float)txtDrag.Value;
			Settings.TaskAngularSpeed = (float)txtAngularSpeed.Value;
			Settings.TaskTopSpeed = (float)txtTopSpeed.Value;
			Settings.ShockwaveRange = (float)txtRange.Value;
			Settings.ShockwavePower = (float)txtPower.Value;

			Settings.UpdateSpeed = (int)txtUpdateSpeed.Value;
			Settings.DrawSpeed = (int)txtDrawSpeed.Value;
			Settings.RefreshSpeed = (int)txtRefreshSpeed.Value;

			Settings.AutoCheckForUpdates = chkAutoCheckForUpdates.Checked;

			Settings.SaveValues();

			if (hue != Settings.BackgroundHue || sat != Settings.BackgroundSat)
				BackgroundChange(Settings.BackgroundHue, Settings.BackgroundSat);

			Close();
		}

		private void BackgroundChange(int hue, int sat)
		{
			Bitmap img = (Bitmap)Image.FromFile("background.png");

			Bitmap bmp = new Bitmap(img.Width, img.Height);
			Graphics g = Graphics.FromImage(bmp);

			for (int y = 0; y < img.Height; y++) {
				for (int x = 0; x < img.Width; x++) {
					HSLColor c1 = new HSLColor(img.GetPixel(x, y));
					c1.Hue = hue;
					c1.Saturation = sat;

					g.FillRectangle(new SolidBrush(c1), x, y, 1, 1);
				}
			}

			g.Dispose();

			img.Dispose();

			bmp.Save("background.png");
		}

		private void btnSetColour_Click(object sender, EventArgs e)
		{
			ColorDialog dialog = new ColorDialog();
			dialog.Color = new HSLColor(txtHue.Value, txtSat.Value, 120);
			if (dialog.ShowDialog() == DialogResult.OK) {
				HSLColor hslc = new HSLColor(dialog.Color);
				txtHue.Value = hslc.Hue;
				txtSat.Value = hslc.Saturation;
			}
		}
	}
}

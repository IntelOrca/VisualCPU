using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace VisualCPU
{
	static class Settings
	{
		public static readonly string SettingsFile = Path.Combine(Application.StartupPath, "settings.cfg");

		public static byte BackgroundHue;
		public static byte BackgroundSat;
		public static bool MemoryProportional;
		public static bool ShowMemorySize;
		public static bool ShowThreads;
		public static bool ShowWindowsOnly;

		public static float TaskAcceleration;
		public static float TaskResizeSpeed;
		public static float TaskDrag;
		public static float TaskTopSpeed;
		public static float TaskAngularSpeed;
		public static float ShockwaveRange;
		public static float ShockwavePower;

		public static int UpdateSpeed;
		public static int DrawSpeed;
		public static int RefreshSpeed;

		public static bool AutoCheckForUpdates;
		public static int MainFormLeft;
		public static int MainFormTop;
		public static int MainFormWidth;
		public static int MainFormHeight;

		public static void SetDefaultValues()
		{
			BackgroundHue = 0;
			BackgroundSat = 0;
			MemoryProportional = true;
			ShowMemorySize = true;
			ShowThreads = true;
			ShowWindowsOnly = false;

			TaskAcceleration = 0.2f;
			TaskResizeSpeed = 2.0f;
			TaskDrag = 0.5f;
			TaskTopSpeed = 5.0f;
			TaskAngularSpeed = 0.05f;
			ShockwaveRange = 400.0f;
			ShockwavePower = 25.0f;

			UpdateSpeed = 100;
			DrawSpeed = 100;
			RefreshSpeed = 5000;

			AutoCheckForUpdates = false;
		}

		public static void LoadValues()
		{
			SetDefaultValues();

			FileStream fs = null;
			BinaryReader br = null;

			try {
				fs = new FileStream(SettingsFile, FileMode.Open);
				br = new BinaryReader(fs);

				BackgroundHue = br.ReadByte();
				BackgroundSat = br.ReadByte();
				MemoryProportional = br.ReadBoolean();
				ShowMemorySize = br.ReadBoolean();
				ShowThreads = br.ReadBoolean();
				ShowWindowsOnly = br.ReadBoolean();

				TaskAcceleration = br.ReadSingle();
				TaskResizeSpeed = br.ReadSingle();
				TaskDrag = br.ReadSingle();
				TaskTopSpeed = br.ReadSingle();
				TaskAngularSpeed = br.ReadSingle();
				ShockwaveRange = br.ReadSingle();
				ShockwavePower = br.ReadSingle();

				UpdateSpeed = br.ReadInt32();
				DrawSpeed = br.ReadInt32();
				RefreshSpeed = br.ReadInt32();

				AutoCheckForUpdates = br.ReadBoolean();

				MainFormLeft = br.ReadInt32();
				MainFormTop = br.ReadInt32();
				MainFormWidth = br.ReadInt32();
				MainFormHeight = br.ReadInt32();
			} catch {

			} finally {
				if (br != null)
					br.Close();
				if (fs != null)
					fs.Close();
			}
		}

		public static void SaveValues()
		{
			FileStream fs = null;
			BinaryWriter bw = null;

			try {
				fs = new FileStream(SettingsFile, FileMode.Create);
				bw = new BinaryWriter(fs);

				bw.Write(BackgroundHue);
				bw.Write(BackgroundSat);
				bw.Write(MemoryProportional);
				bw.Write(ShowMemorySize);
				bw.Write(ShowThreads);
				bw.Write(ShowWindowsOnly);

				bw.Write(TaskAcceleration);
				bw.Write(TaskResizeSpeed);
				bw.Write(TaskDrag);
				bw.Write(TaskTopSpeed);
				bw.Write(TaskAngularSpeed);
				bw.Write(ShockwaveRange);
				bw.Write(ShockwavePower);

				bw.Write(UpdateSpeed);
				bw.Write(DrawSpeed);
				bw.Write(RefreshSpeed);

				bw.Write(AutoCheckForUpdates);

				bw.Write(MainFormLeft);
				bw.Write(MainFormTop);
				bw.Write(MainFormWidth);
				bw.Write(MainFormHeight);
			} catch {

			} finally {
				if (bw != null)
					bw.Close();
				if (fs != null)
					fs.Close();
			}
		}
	}
}

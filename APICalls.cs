using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Security.Principal;

namespace VisualCPU
{
	static class APICalls
	{
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
		public class MEMORYSTATUSEX
		{
			public uint dwLength;
			public uint dwMemoryLoad;
			public ulong ullTotalPhys;
			public ulong ullAvailPhys;
			public ulong ullTotalPageFile;
			public ulong ullAvailPageFile;
			public ulong ullTotalVirtual;
			public ulong ullAvailVirtual;
			public ulong ullAvailExtendedVirtual;
			public MEMORYSTATUSEX()
			{
				this.dwLength = (uint)Marshal.SizeOf(typeof(MEMORYSTATUSEX));
			}
		}

		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool GlobalMemoryStatusEx([In, Out] MEMORYSTATUSEX lpBuffer);

		#region GetProcessOwner

		public const int TOKEN_QUERY = 0X00000008;

		const int ERROR_NO_MORE_ITEMS = 259;

		enum TOKEN_INFORMATION_CLASS
		{
			TokenUser = 1,
			TokenGroups,
			TokenPrivileges,
			TokenOwner,
			TokenPrimaryGroup,
			TokenDefaultDacl,
			TokenSource,
			TokenType,
			TokenImpersonationLevel,
			TokenStatistics,
			TokenRestrictedSids,
			TokenSessionId
		}

		[StructLayout(LayoutKind.Sequential)]
		struct TOKEN_USER
		{
			public _SID_AND_ATTRIBUTES User;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct _SID_AND_ATTRIBUTES
		{
			public IntPtr Sid;
			public int Attributes;
		}

		[DllImport("advapi32")]
		static extern bool OpenProcessToken(
			IntPtr ProcessHandle, // handle to process
			int DesiredAccess, // desired access to process
			ref IntPtr TokenHandle // handle to open access token
		);

		[DllImport("kernel32")]
		static extern bool CloseHandle(IntPtr handle);

		public static string GetProcessUser(Process process)
		{
			try {
				int Access = TOKEN_QUERY;
				IntPtr procToken = IntPtr.Zero;
				bool ret = false;
				IntPtr pToken = process.Handle;
				if (OpenProcessToken(pToken, Access, ref procToken)) {
					WindowsIdentity wi = new WindowsIdentity(procToken);
					NTAccount ntAccount = (NTAccount)wi.User.Translate(typeof(NTAccount));

					CloseHandle(procToken);

					return ntAccount.ToString();
				} else {
					return null;
				}
			} catch {
				return "Other";
			}
		}

		#endregion
	}
}

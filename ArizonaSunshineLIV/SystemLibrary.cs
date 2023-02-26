﻿using System;
using System.Runtime.InteropServices;

namespace ArizonaSunshineLIV
{
	internal static class SystemLibrary
	{
		[DllImport("kernel32", SetLastError = true, CharSet = CharSet.Unicode)]
		public static extern IntPtr LoadLibrary(string lpFileName);
	}
}
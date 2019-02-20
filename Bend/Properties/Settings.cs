using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace Bend.Properties
{
	// Token: 0x0200000A RID: 10
	public partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x06000078 RID: 120 RVA: 0x00005944 File Offset: 0x00003B44
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Settings()
		{
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00005954 File Offset: 0x00003B54
		[MethodImpl(MethodImplOptions.NoInlining)]
		static Settings()
		{
			Settings.defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00005974 File Offset: 0x00003B74
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool m000001()
		{
			return true;
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00005978 File Offset: 0x00003B78
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool m000002()
		{
			return false;
		}
	}
}

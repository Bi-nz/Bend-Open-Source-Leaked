using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Bend.Properties
{
	// Token: 0x02000009 RID: 9
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
	[CompilerGenerated]
	public class Resources
	{
		// Token: 0x06000070 RID: 112 RVA: 0x00005898 File Offset: 0x00003A98
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Resources()
		{
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000072 RID: 114 RVA: 0x000058FC File Offset: 0x00003AFC
		// (set) Token: 0x06000073 RID: 115 RVA: 0x00005914 File Offset: 0x00003B14
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static CultureInfo Culture
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return Resources.resourceCulture;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				Resources.resourceCulture = value;
			}
		}

		// Token: 0x06000074 RID: 116 RVA: 0x0000591C File Offset: 0x00003B1C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool m000001()
		{
			return true;
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00005920 File Offset: 0x00003B20
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool m000002()
		{
			return false;
		}


		// Token: 0x0400003B RID: 59
		public static ResourceManager resourceMan;

		// Token: 0x0400003C RID: 60
		public static CultureInfo resourceCulture;
	}
}

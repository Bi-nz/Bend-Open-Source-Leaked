using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Bend
{
	// Token: 0x02000007 RID: 7
	public abstract class Program
	{
		// Token: 0x0600004A RID: 74 RVA: 0x00003FBC File Offset: 0x000021BC
		[STAThread]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00003FE4 File Offset: 0x000021E4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool m000001()
		{
			return true;
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00003FE8 File Offset: 0x000021E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool m000002()
		{
			return false;
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00003FEC File Offset: 0x000021EC
		static Program()
		{
			//c00000f.ejrW12LnL();
		}
	}
}

using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Bend
{
	// Token: 0x02000005 RID: 5
	public partial class Form3 : Form
	{
		// Token: 0x06000025 RID: 37 RVA: 0x00002DA4 File Offset: 0x00000FA4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Form3()
		{
			InitializeComponent();
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002E10 File Offset: 0x00001010
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void InitializeComponent()
		{
			this.button1 = new Button();
			base.SuspendLayout();
			this.button1.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
			this.button1.FlatStyle = FlatStyle.Flat;
			this.button1.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.button1.Location = new Point(28, 25);
			this.button1.Name = "button1";
			this.button1.Size = new Size(134, 33);
			this.button1.TabIndex = 0;
			this.button1.Text = "Execute";
			this.button1.UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(800, 450);
			base.Controls.Add(this.button1);
			base.Name = "Form3";
			this.Text = "Form3";
			base.ResumeLayout(false);
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002F54 File Offset: 0x00001154
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool m000001()
		{
			return true;
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002F58 File Offset: 0x00001158
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool m000002()
		{
			return false;
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002F5C File Offset: 0x0000115C
		static Form3()
		{
			//c00000f.ejrW12LnL();
		}

		// Token: 0x04000011 RID: 17
		public Button button1;
	}
}

using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Bend
{
	// Token: 0x02000003 RID: 3
	public partial class Form1 : Form
	{
		// Token: 0x06000006 RID: 6
		[DllImport("Gdi32.dll")]
		public static extern IntPtr CreateRoundRectRgn(int p0, int p1, int p2, int p3, int p4, int p5);

		// Token: 0x06000007 RID: 7 RVA: 0x00002078 File Offset: 0x00000278
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Form1()
		{
            InitializeComponent();
		}

		// Token: 0x06000008 RID: 8 RVA: 0x000020C4 File Offset: 0x000002C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Form1_Load(object p0, EventArgs p1)
		{
			this.timer1.Start();
		}

		// Token: 0x06000009 RID: 9 RVA: 0x000020D4 File Offset: 0x000002D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void timer1_Tick(object p0, EventArgs p1)
		{
			this.progressBar1.Value++;
			bool flag = this.progressBar1.Value == 25;
			if (flag)
			{
				this.label2.Text = "Downloading Data...";
			}
			bool flag2 = this.progressBar1.Value == 35;
			if (flag2)
			{
				this.label2.Text = "Checking Data...";
			}
			bool flag3 = this.progressBar1.Value == 35;
			if (flag3)
			{
				this.label2.Text = "Checking Whitelist...";
			}
			bool flag4 = this.progressBar1.Value == 75;
			if (flag4)
			{
				this.label2.Text = "Downloading DLLs...";
			}
			bool flag5 = this.progressBar1.Value == 90;
			if (flag5)
			{
				this.label2.Text = "Ready to Launch!";
			}
			bool flag6 = this.progressBar1.Value == 100;
			if (flag6)
			{
				this.timer1.Stop();
				base.Hide();
				Form2 form = new Form2();
				form.ShowDialog();
				base.Close();
			}
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002220 File Offset: 0x00000420
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void panel1_MouseMove(object p0, MouseEventArgs p1)
		{
			bool flag = p1.Button == MouseButtons.Left;
			if (flag)
			{
				base.Left += p1.X - this.lastPoint.X;
				base.Top += p1.Y - this.lastPoint.Y;
			}
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002288 File Offset: 0x00000488
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void panel1_MouseDown(object p0, MouseEventArgs p1)
		{
			this.lastPoint = new Point(p1.X, p1.Y);
		}

		// Token: 0x0600000C RID: 12 RVA: 0x000022A4 File Offset: 0x000004A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void button1_Click(object p0, EventArgs p1)
		{
			base.Close();
		}

		// Token: 0x0600000D RID: 13 RVA: 0x000022AC File Offset: 0x000004AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void button2_Click(object p0, EventArgs p1)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000022B8 File Offset: 0x000004B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void progressBar1_Click(object p0, EventArgs p1)
		{
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000022BC File Offset: 0x000004BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void label2_Click(object p0, EventArgs p1)
		{
		}

		// Token: 0x06000010 RID: 16 RVA: 0x000022C0 File Offset: 0x000004C0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void panel1_Paint(object p0, PaintEventArgs p1)
		{
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002308 File Offset: 0x00000508
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void InitializeComponent()
		{
			this.components = new Container();
			//ComponentResourceManager componentResourceManager = new ComponentResourceManager(Type.GetTypeFromHandle(c000014.m000005(33554435)));
			this.panel1 = new Panel();
			this.progressBar1 = new ProgressBar();
			this.label2 = new Label();
			this.timer1 = new Timer(this.components);
			base.SuspendLayout();
			this.panel1.BackColor = SystemColors.ControlLight;
			this.panel1.Location = new Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new Size(339, 28);
			this.panel1.TabIndex = 0;
			this.panel1.Paint += this.panel1_Paint;
			this.panel1.MouseDown += this.panel1_MouseDown;
			this.panel1.MouseMove += this.panel1_MouseMove;
			this.progressBar1.Location = new Point(12, 68);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new Size(316, 23);
			this.progressBar1.TabIndex = 1;
			this.progressBar1.Click += this.progressBar1_Click;
			this.label2.AutoSize = true;
			this.label2.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label2.ForeColor = Color.Black;
			this.label2.Location = new Point(93, 45);
			this.label2.Name = "label2";
			this.label2.Size = new Size(88, 20);
			this.label2.TabIndex = 2;
			this.label2.Text = "initializing...";
			this.label2.Click += this.label2_Click;
			this.timer1.Tick += this.timer1_Tick;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.White;
			base.ClientSize = new Size(335, 103);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.progressBar1);
			base.Controls.Add(this.panel1);
			base.FormBorderStyle = FormBorderStyle.None;
			//base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "Form1";
			this.Text = "Form1";
			base.Load += this.Form1_Load;
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002604 File Offset: 0x00000804
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool m000001()
		{
			return true;
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002608 File Offset: 0x00000808
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool m000002()
		{
			return false;
		}

		// Token: 0x06000015 RID: 21 RVA: 0x0000260C File Offset: 0x0000080C
		static Form1()
		{
			//c00000f.ejrW12LnL();
		}

		// Token: 0x04000001 RID: 1
		public Point lastPoint;

		// Token: 0x04000003 RID: 3
		public Panel panel1;

		// Token: 0x04000004 RID: 4
		public ProgressBar progressBar1;

		// Token: 0x04000005 RID: 5
		public Label label2;

		// Token: 0x04000006 RID: 6
		public Timer timer1;
	}
}

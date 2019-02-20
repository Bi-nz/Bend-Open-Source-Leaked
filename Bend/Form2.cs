using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Bend
{
	// Token: 0x02000004 RID: 4
	public partial class Form2 : Form
	{
		// Token: 0x06000016 RID: 22
		[DllImport("Gdi32.dll")]
		public static extern IntPtr CreateRoundRectRgn(int p0, int p1, int p2, int p3, int p4, int p5);

		// Token: 0x06000017 RID: 23 RVA: 0x00002614 File Offset: 0x00000814
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Form2()
		{
			this.components = null;
            InitializeComponent();
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002660 File Offset: 0x00000860
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Form2_Load(object p0, EventArgs p1)
		{
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002664 File Offset: 0x00000864
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void button1_Click(object p0, EventArgs p1)
		{
			base.Close();
		}

		// Token: 0x0600001A RID: 26 RVA: 0x0000266C File Offset: 0x0000086C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void button3_Click(object p0, EventArgs p1)
		{
			bool flag = this.textBox1.Text == "qdrfrqtuiv1luafull";
			if (flag)
			{
				MessageBox.Show("Checking key");
				MessageBox.Show("Key Valid");
				base.Hide();
				Main main = new Main();
				main.ShowDialog();
				base.Close();
			}
			else
			{
				MessageBox.Show("Checking key");
				MessageBox.Show("Key Invalid");
			}
		}

		// Token: 0x0600001B RID: 27 RVA: 0x000026F0 File Offset: 0x000008F0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void button4_Click(object p0, EventArgs p1)
		{
			Process.Start("http://bit.ly/2SzDS3A");
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002700 File Offset: 0x00000900
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

		// Token: 0x0600001D RID: 29 RVA: 0x00002768 File Offset: 0x00000968
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void panel1_MouseDown(object p0, MouseEventArgs p1)
		{
			this.lastPoint = new Point(p1.X, p1.Y);
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002784 File Offset: 0x00000984
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void button2_Click(object p0, EventArgs p1)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002790 File Offset: 0x00000990
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void panel1_Paint(object p0, PaintEventArgs p1)
		{
		}

		// Token: 0x06000021 RID: 33 RVA: 0x000027E0 File Offset: 0x000009E0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void InitializeComponent()
		{
			//ComponentResourceManager componentResourceManager = new ComponentResourceManager(Type.GetTypeFromHandle(c000014.m000005(33554436)));
			this.panel1 = new Panel();
			this.button2 = new Button();
			this.button1 = new Button();
			this.textBox1 = new TextBox();
			this.button3 = new Button();
			this.button4 = new Button();
			this.textBox2 = new TextBox();
			this.panel1.SuspendLayout();
			base.SuspendLayout();
			this.panel1.BackColor = SystemColors.ControlLight;
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Location = new Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new Size(284, 27);
			this.panel1.TabIndex = 0;
			this.panel1.Paint += this.panel1_Paint;
			this.panel1.MouseDown += this.panel1_MouseDown;
			this.panel1.MouseMove += this.panel1_MouseMove;
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatStyle = FlatStyle.Flat;
			this.button2.Location = new Point(236, 0);
			this.button2.Name = "button2";
			this.button2.Size = new Size(21, 23);
			this.button2.TabIndex = 2;
			this.button2.Text = "_";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += this.button2_Click;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = FlatStyle.Flat;
			this.button1.Location = new Point(263, 0);
			this.button1.Name = "button1";
			this.button1.Size = new Size(21, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "X";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += this.button1_Click;
			this.textBox1.Location = new Point(12, 125);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new Size(258, 20);
			this.textBox1.TabIndex = 1;
			this.button3.BackColor = Color.FromArgb(50, 50, 50);
			this.button3.FlatAppearance.BorderSize = 0;
			this.button3.FlatStyle = FlatStyle.Flat;
			this.button3.ForeColor = Color.White;
			this.button3.Location = new Point(195, 151);
			this.button3.Name = "button3";
			this.button3.Size = new Size(75, 23);
			this.button3.TabIndex = 2;
			this.button3.Text = "Check Key";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += this.button3_Click;
			this.button4.BackColor = Color.FromArgb(50, 50, 50);
			this.button4.FlatAppearance.BorderSize = 0;
			this.button4.FlatStyle = FlatStyle.Flat;
			this.button4.ForeColor = Color.White;
			this.button4.Location = new Point(12, 151);
			this.button4.Name = "button4";
			this.button4.Size = new Size(75, 23);
			this.button4.TabIndex = 3;
			this.button4.Text = "Get Key";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += this.button4_Click;
			this.textBox2.Location = new Point(12, 33);
			this.textBox2.Multiline = true;
			this.textBox2.Name = "textBox2";
			this.textBox2.ReadOnly = true;
			this.textBox2.Size = new Size(258, 86);
			this.textBox2.TabIndex = 4;
			this.textBox2.Text = "2/16/19\r\nAdded Better Inject (Faster & Silent)\r\nAdded Ban Bypass (In beta)\r\nAdded Auto crash (Crashes incase of a ban wave)\r\nAdded New Tabs!\r\n*Fixed* Crashes and Injecting!!\r\n";
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(282, 182);
			base.Controls.Add(this.textBox2);
			base.Controls.Add(this.button4);
			base.Controls.Add(this.button3);
			base.Controls.Add(this.textBox1);
			base.Controls.Add(this.panel1);
			base.FormBorderStyle = FormBorderStyle.None;
			//base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "Form2";
			this.Text = "Form2";
			base.Load += this.Form2_Load;
			this.panel1.ResumeLayout(false);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002D94 File Offset: 0x00000F94
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool m000001()
		{
			return true;
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002D98 File Offset: 0x00000F98
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool m000002()
		{
			return false;
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002D9C File Offset: 0x00000F9C
		static Form2()
		{
			//c00000f.ejrW12LnL();
		}

		// Token: 0x04000007 RID: 7
		public Point lastPoint;

		// Token: 0x04000009 RID: 9
		public Panel panel1;

		// Token: 0x0400000A RID: 10
		public Button button2;

		// Token: 0x0400000B RID: 11
		public Button button1;

		// Token: 0x0400000C RID: 12
		public TextBox textBox1;

		// Token: 0x0400000D RID: 13
		public Button button3;

		// Token: 0x0400000E RID: 14
		public Button button4;

		// Token: 0x0400000F RID: 15
		public TextBox textBox2;
	}
}

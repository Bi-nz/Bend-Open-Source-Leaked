using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using FastColoredTextBoxNS;
using SpareApi;

namespace Bend
{
	// Token: 0x02000006 RID: 6
	public partial class Main : Form
	{
		// Token: 0x0600002B RID: 43
		[DllImport("Gdi32.dll")]
		public static extern IntPtr CreateRoundRectRgn(int p0, int p1, int p2, int p3, int p4, int p5);

		// Token: 0x0600002C RID: 44 RVA: 0x00002F64 File Offset: 0x00001164
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Main()
		{
			this.Bend = new SpareModule();
			this.components = null;
			this.InitializeComponent();
			base.Region = Region.FromHrgn(Main.CreateRoundRectRgn(0, 0, base.Width, base.Height, 20, 20));
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002FBC File Offset: 0x000011BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Main_Load(object p0, EventArgs p1)
		{
			int num = 0;
			string[] array = null;
			do
			{
				string path = array[num];
				this.listBox1.Items.Add(Path.GetFileName(path));
				num++;
			}
			while (num < array.Length);
			bool flag = this.listBox1.SelectedItem == null;
			if (!flag)
			{
				this.fastColoredTextBox1.Text = File.ReadAllText("Scripts\\" + this.listBox1.SelectedItem.ToString());
				this.fastColoredTextBox1.Refresh();
			}
		}

		// Token: 0x0600002E RID: 46 RVA: 0x000030A0 File Offset: 0x000012A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void label2_Click(object p0, EventArgs p1)
		{
		}

		// Token: 0x0600002F RID: 47 RVA: 0x000030A4 File Offset: 0x000012A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void label1_Click(object p0, EventArgs p1)
		{
			this.Bend.ExecuteScript(this.fastColoredTextBox1.Text);
		}

		// Token: 0x06000030 RID: 48 RVA: 0x000030BC File Offset: 0x000012BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void label6_Click(object p0, EventArgs p1)
		{
			this.fastColoredTextBox1.Text = "";
		}

		// Token: 0x06000031 RID: 49 RVA: 0x000030D0 File Offset: 0x000012D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void label7_Click(object p0, EventArgs p1)
		{
		}

		// Token: 0x06000032 RID: 50 RVA: 0x000030D4 File Offset: 0x000012D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void label8_Click(object p0, EventArgs p1)
		{
			this.Bend.LoadExploit();
		}

		// Token: 0x06000033 RID: 51 RVA: 0x000030E4 File Offset: 0x000012E4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void fastColoredTextBox1_Load(object p0, EventArgs p1)
		{
		}

		// Token: 0x06000034 RID: 52 RVA: 0x000030E8 File Offset: 0x000012E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void button1_Click(object p0, EventArgs p1)
		{
			MessageBox.Show("Thanks for using bend");
			base.Close();
		}

		// Token: 0x06000035 RID: 53 RVA: 0x000030FC File Offset: 0x000012FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void label3_Click(object p0, EventArgs p1)
		{
			Settings settings = new Settings();
			settings.Show();
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00003118 File Offset: 0x00001318
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void button2_Click_1(object p0, EventArgs p1)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00003124 File Offset: 0x00001324
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void button3_Click(object p0, EventArgs p1)
		{
			this.Bend.ExecuteScript(this.fastColoredTextBox1.Text);
		}

		// Token: 0x06000038 RID: 56 RVA: 0x0000313C File Offset: 0x0000133C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void button4_Click(object p0, EventArgs p1)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			bool flag = this.openFileDialog1.ShowDialog() == DialogResult.OK;
			if (flag)
			{
				bool flag2 = this.openFileDialog1.OpenFile() != null;
				if (flag2)
				{
					string fileName = this.openFileDialog1.FileName;
					string text = File.ReadAllText(fileName);
					this.fastColoredTextBox1.Text = text;
				}
			}
		}

		// Token: 0x06000039 RID: 57 RVA: 0x000031B4 File Offset: 0x000013B4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void button5_Click(object p0, EventArgs p1)
		{
			this.fastColoredTextBox1.Text = "";
		}

		// Token: 0x0600003A RID: 58 RVA: 0x000031C8 File Offset: 0x000013C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void button6_Click(object p0, EventArgs p1)
		{
		}

		// Token: 0x0600003B RID: 59 RVA: 0x000031CC File Offset: 0x000013CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void checkBox1_CheckedChanged(object p0, EventArgs p1)
		{
			bool @checked = this.checkBox1.Checked;
			bool flag = @checked;
			if (flag)
			{
				base.TopMost = true;
			}
			else
			{
				base.TopMost = false;
			}
		}

		// Token: 0x0600003C RID: 60 RVA: 0x0000320C File Offset: 0x0000140C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void button7_Click(object p0, EventArgs p1)
		{
			Settings settings = new Settings();
			settings.Show();
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00003228 File Offset: 0x00001428
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void panel1_MouseDown(object p0, MouseEventArgs p1)
		{
			this.lastPoint = new Point(p1.X, p1.Y);
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00003244 File Offset: 0x00001444
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Panel1_MouseDown(object p0, MouseEventArgs p1)
		{
			this.lastPoint = new Point(p1.X, p1.Y);
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00003260 File Offset: 0x00001460
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void panel1_Paint(object p0, PaintEventArgs p1)
		{
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00003264 File Offset: 0x00001464
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void richTextBox1_TextChanged(object p0, EventArgs p1)
		{
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00003268 File Offset: 0x00001468
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void button6_Click_1(object p0, EventArgs p1)
		{
			this.Bend.LoadExploit();
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00003278 File Offset: 0x00001478
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void listBox1_SelectedIndexChanged(object p0, EventArgs p1)
		{
			if (this.listBox1.SelectedItem != null)
			{
				this.fastColoredTextBox1.Text = File.ReadAllText("Scripts\\" + this.listBox1.SelectedItem.ToString());
				this.fastColoredTextBox1.Refresh();
			}
		}

		// Token: 0x06000043 RID: 67 RVA: 0x000032DC File Offset: 0x000014DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void button7_Click_1(object p0, EventArgs p1)
		{
			Settings settings = new Settings();
			settings.Show();
		}

		// Token: 0x06000045 RID: 69 RVA: 0x0000333C File Offset: 0x0000153C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void InitializeComponent()
		{
			this.components = new Container();
			//ComponentResourceManager componentResourceManager = new ComponentResourceManager(Type.GetTypeFromHandle(c000014.m000005(33554438)));
			this.button1 = new Button();
			this.fastColoredTextBox1 = new FastColoredTextBox();
			this.button2 = new Button();
			this.button3 = new Button();
			this.button4 = new Button();
			this.button5 = new Button();
			this.openFileDialog1 = new OpenFileDialog();
			this.checkBox1 = new CheckBox();
			this.panel1 = new Panel();
			this.button6 = new Button();
			this.listBox1 = new ListBox();
			this.button7 = new Button();
			((ISupportInitialize)this.fastColoredTextBox1).BeginInit();
			this.panel1.SuspendLayout();
			base.SuspendLayout();
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = FlatStyle.Flat;
			this.button1.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button1.Location = new Point(639, 3);
			this.button1.Name = "button1";
			this.button1.Size = new Size(33, 23);
			this.button1.TabIndex = 14;
			this.button1.Text = "X";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += this.button1_Click;
			this.fastColoredTextBox1.AutoCompleteBracketsList = new char[]
			{
				'(',
				')',
				'{',
				'}',
				'[',
				']',
				'"',
				'"',
				'\'',
				'\''
			};
			this.fastColoredTextBox1.AutoScrollMinSize = new Size(459, 238);
			this.fastColoredTextBox1.BackBrush = null;
			this.fastColoredTextBox1.BackColor = Color.FromArgb(40, 40, 40);
			this.fastColoredTextBox1.CharHeight = 14;
			this.fastColoredTextBox1.CharWidth = 8;
			this.fastColoredTextBox1.Cursor = Cursors.IBeam;
			this.fastColoredTextBox1.DisabledColor = Color.FromArgb(100, 180, 180, 180);
			this.fastColoredTextBox1.ForeColor = Color.White;
			this.fastColoredTextBox1.IndentBackColor = Color.FromArgb(30, 30, 30);
			this.fastColoredTextBox1.IsReplaceMode = false;
			this.fastColoredTextBox1.LineNumberColor = Color.White;
			this.fastColoredTextBox1.Location = new Point(12, 26);
			this.fastColoredTextBox1.Name = "fastColoredTextBox1";
			this.fastColoredTextBox1.Paddings = new Padding(0);
			this.fastColoredTextBox1.SelectionColor = Color.FromArgb(60, 0, 0, 255);
			//this.fastColoredTextBox1.ServiceColors = (ServiceColors)componentResourceManager.GetObject("fastColoredTextBox1.ServiceColors");
			this.fastColoredTextBox1.Size = new Size(547, 273);
			this.fastColoredTextBox1.TabIndex = 17;
			//this.fastColoredTextBox1.Text = componentResourceManager.GetString("fastColoredTextBox1.Text");
			this.fastColoredTextBox1.Zoom = 100;
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatStyle = FlatStyle.Flat;
			this.button2.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button2.Location = new Point(609, 2);
			this.button2.Name = "button2";
			this.button2.Size = new Size(33, 23);
			this.button2.TabIndex = 18;
			this.button2.Text = "_";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += this.button2_Click_1;
			this.button3.BackColor = Color.FromArgb(40, 40, 40);
			this.button3.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
			this.button3.FlatStyle = FlatStyle.Flat;
			this.button3.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.button3.ForeColor = Color.White;
			this.button3.Location = new Point(12, 305);
			this.button3.Name = "button3";
			this.button3.Size = new Size(134, 33);
			this.button3.TabIndex = 19;
			this.button3.Text = "Execute";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += this.button3_Click;
			this.button4.BackColor = Color.FromArgb(40, 40, 40);
			this.button4.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
			this.button4.FlatStyle = FlatStyle.Flat;
			this.button4.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.button4.ForeColor = Color.White;
			this.button4.Location = new Point(152, 305);
			this.button4.Name = "button4";
			this.button4.Size = new Size(134, 33);
			this.button4.TabIndex = 20;
			this.button4.Text = "Open";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += this.button4_Click;
			this.button5.BackColor = Color.FromArgb(40, 40, 40);
			this.button5.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
			this.button5.FlatStyle = FlatStyle.Flat;
			this.button5.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.button5.ForeColor = Color.White;
			this.button5.Location = new Point(292, 305);
			this.button5.Name = "button5";
			this.button5.Size = new Size(134, 33);
			this.button5.TabIndex = 21;
			this.button5.Text = "Clear";
			this.button5.UseVisualStyleBackColor = false;
			this.button5.Click += this.button5_Click;
			this.openFileDialog1.FileName = "openFileDialog1";
			this.checkBox1.AutoSize = true;
			this.checkBox1.BackColor = SystemColors.Control;
			this.checkBox1.Location = new Point(15, 7);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new Size(71, 17);
			this.checkBox1.TabIndex = 23;
			this.checkBox1.Text = "Top Most";
			this.checkBox1.UseVisualStyleBackColor = false;
			this.checkBox1.CheckedChanged += this.checkBox1_CheckedChanged;
			this.panel1.BackColor = SystemColors.Control;
			this.panel1.Controls.Add(this.checkBox1);
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Location = new Point(-3, -3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new Size(672, 23);
			this.panel1.TabIndex = 25;
			this.panel1.Paint += this.panel1_Paint;
			this.panel1.MouseDown += this.panel1_MouseDown;
			this.panel1.MouseMove += this.panel1_MouseMove;
			this.button6.BackColor = Color.FromArgb(40, 40, 40);
			this.button6.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
			this.button6.FlatStyle = FlatStyle.Flat;
			this.button6.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.button6.ForeColor = Color.White;
			this.button6.Location = new Point(432, 305);
			this.button6.Name = "button6";
			this.button6.Size = new Size(127, 33);
			this.button6.TabIndex = 26;
			this.button6.Text = "Inject";
			this.button6.UseVisualStyleBackColor = false;
			this.button6.Click += this.button6_Click_1;
			this.listBox1.BackColor = Color.FromArgb(40, 40, 40);
			this.listBox1.BorderStyle = BorderStyle.None;
			this.listBox1.ForeColor = Color.White;
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new Point(565, 26);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new Size(93, 273);
			this.listBox1.TabIndex = 27;
			this.listBox1.SelectedIndexChanged += this.listBox1_SelectedIndexChanged;
			this.button7.BackColor = Color.FromArgb(40, 40, 40);
			this.button7.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
			this.button7.FlatStyle = FlatStyle.Flat;
			this.button7.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.button7.ForeColor = Color.White;
			this.button7.Location = new Point(565, 305);
			this.button7.Name = "button7";
			this.button7.Size = new Size(93, 33);
			this.button7.TabIndex = 28;
			this.button7.Text = "Games";
			this.button7.UseVisualStyleBackColor = false;
			this.button7.Click += this.button7_Click_1;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.White;
			base.ClientSize = new Size(667, 346);
			base.Controls.Add(this.button7);
			base.Controls.Add(this.listBox1);
			base.Controls.Add(this.button6);
			base.Controls.Add(this.panel1);
			base.Controls.Add(this.button5);
			base.Controls.Add(this.button4);
			base.Controls.Add(this.button3);
			base.Controls.Add(this.fastColoredTextBox1);
			base.FormBorderStyle = FormBorderStyle.None;
			//base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "Main";
			base.Load += this.Main_Load;
			((ISupportInitialize)this.fastColoredTextBox1).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00003F44 File Offset: 0x00002144
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

		// Token: 0x06000047 RID: 71 RVA: 0x00003FAC File Offset: 0x000021AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool m000001()
		{
			return true;
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00003FB0 File Offset: 0x000021B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool m000002()
		{
			return false;
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00003FB4 File Offset: 0x000021B4
		static Main()
		{
			//c00000f.ejrW12LnL();
		}

		// Token: 0x04000012 RID: 18
		public SpareModule Bend;

		// Token: 0x04000013 RID: 19
		public Point lastPoint;

		// Token: 0x04000015 RID: 21
		public Button button1;

		// Token: 0x04000016 RID: 22
		public FastColoredTextBox fastColoredTextBox1;

		// Token: 0x04000017 RID: 23
		public Button button2;

		// Token: 0x04000018 RID: 24
		public Button button3;

		// Token: 0x04000019 RID: 25
		public Button button4;

		// Token: 0x0400001A RID: 26
		public Button button5;

		// Token: 0x0400001B RID: 27
		public OpenFileDialog openFileDialog1;

		// Token: 0x0400001C RID: 28
		public CheckBox checkBox1;

		// Token: 0x0400001D RID: 29
		public Panel panel1;

		// Token: 0x0400001E RID: 30
		public Button button6;

		// Token: 0x0400001F RID: 31
		public ListBox listBox1;

		// Token: 0x04000020 RID: 32
		public Button button7;
	}
}

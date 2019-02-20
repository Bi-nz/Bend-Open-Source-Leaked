using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using SpareApi;

namespace Bend
{
	// Token: 0x02000008 RID: 8
	public partial class Settings : Form
	{
		// Token: 0x0600004E RID: 78
		[DllImport("Gdi32.dll")]
		public static extern IntPtr CreateRoundRectRgn(int p0, int p1, int p2, int p3, int p4, int p5);

		// Token: 0x0600004F RID: 79 RVA: 0x00003FF4 File Offset: 0x000021F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Settings()
		{
			this.Bend = new SpareModule();
			this.components = null;
			this.InitializeComponent();
			base.Region = Region.FromHrgn(Settings.CreateRoundRectRgn(0, 0, base.Width, base.Height, 20, 20));
		}

		// Token: 0x06000050 RID: 80 RVA: 0x0000404C File Offset: 0x0000224C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Settings_Load(object p0, EventArgs p1)
		{
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00004050 File Offset: 0x00002250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void button1_Click(object p0, EventArgs p1)
		{
			Process.Start("https://discord.gg/ebdFTey");
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00004060 File Offset: 0x00002260
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void button3_Click(object p0, EventArgs p1)
		{
			this.Bend.ExecuteScript("local hit = game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.Position + Vector3.new(0,0,-3) a = Instance.new('Part', workspace) a.Anchored = true a.Position = game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.Position + Vector3.new(0,0,-3) a.CanCollide = false for i, v in pairs(game:GetService('Workspace').Givers:GetChildren()) do if v.Name == 'Station' then for a, b in pairs(v:GetChildren()) do if b:IsA('StringValue') then if b.Value == 'Pistol' then v.CFrame = CFrame.new(hit) end end end end end");
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00004074 File Offset: 0x00002274
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void button2_Click(object p0, EventArgs p1)
		{
			this.Bend.ExecuteScript("local hit = game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.Position + Vector3.new(0,0,-3) a = Instance.new('Part', workspace) a.Anchored = true a.Position = game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.Position + Vector3.new(0,0,-3) a.CanCollide = false for i, v in pairs(game:GetService('Workspace').Givers:GetChildren()) do if v.Name == 'Station' then for a, b in pairs(v:GetChildren()) do if b:IsA('StringValue') then if b.Value == 'Shotgun' then v.CFrame = CFrame.new(hit) end end end end end");
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00004088 File Offset: 0x00002288
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void button4_Click(object p0, EventArgs p1)
		{
			this.Bend.ExecuteScript("local hit = game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.Position + Vector3.new(0,0,-3) a = Instance.new('Part', workspace) a.Anchored = true a.Position = game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.Position + Vector3.new(0,0,-3) a.CanCollide = false for i, v in pairs(game:GetService('Workspace').Givers:GetChildren()) do if v.Name == 'ShootingRange' then for a, b in pairs(v:GetChildren()) do if b:IsA('StringValue') then if b.Value == 'AK47' then v.CFrame = CFrame.new(hit) end end end end end");
		}

		// Token: 0x06000055 RID: 85 RVA: 0x0000409C File Offset: 0x0000229C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void button14_Click(object p0, EventArgs p1)
		{
			this.Bend.ExecuteScript("game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(-174, 22, 1600) + Vector3.new(1,0,0)");
		}

		// Token: 0x06000056 RID: 86 RVA: 0x000040B0 File Offset: 0x000022B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void button17_Click(object p0, EventArgs p1)
		{
			this.Bend.ExecuteScript("game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(1637, 50, -1768) + Vector3.new(1,0,0)");
		}

		// Token: 0x06000057 RID: 87 RVA: 0x000040C4 File Offset: 0x000022C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void button1_Click_1(object p0, EventArgs p1)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		// Token: 0x06000058 RID: 88 RVA: 0x000040D0 File Offset: 0x000022D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void panel1_MouseDown(object p0, MouseEventArgs p1)
		{
			this.lastPoint = new Point(p1.X, p1.Y);
		}

		// Token: 0x06000059 RID: 89 RVA: 0x000040EC File Offset: 0x000022EC
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

		// Token: 0x0600005A RID: 90 RVA: 0x00004154 File Offset: 0x00002354
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void button7_Click(object p0, EventArgs p1)
		{
			this.Bend.ExecuteScript("local Plr = game:GetService('Players').LocalPlayer local Mouse = Plr:GetMouse() Mouse.Button1Down:connect(function() if not game:GetService('UserInputService'):IsKeyDown(Enum.KeyCode.LeftAlt) then return end if not Mouse.Target then return end Mouse.Target:Destroy() end)  ");
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00004168 File Offset: 0x00002368
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void button15_Click(object p0, EventArgs p1)
		{
			this.Bend.ExecuteScript("local InfiniteJumpEnabled = true\ngame:GetService('UserInputService').JumpRequest:connect(function()\nif InfiniteJumpEnabled then\ngame:GetService'Players'.LocalPlayer.Character:FindFirstChildOfClass'Humanoid':ChangeState('Jumping')\nend\nend)");
		}

		// Token: 0x0600005C RID: 92 RVA: 0x0000417C File Offset: 0x0000237C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void button19_Click(object p0, EventArgs p1)
		{
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00004180 File Offset: 0x00002380
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void button20_Click(object p0, EventArgs p1)
		{
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00004184 File Offset: 0x00002384
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void button21_Click(object p0, EventArgs p1)
		{
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00004188 File Offset: 0x00002388
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void button22_Click(object p0, EventArgs p1)
		{
		}

		// Token: 0x06000060 RID: 96 RVA: 0x0000418C File Offset: 0x0000238C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void button25_Click(object p0, EventArgs p1)
		{
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00004190 File Offset: 0x00002390
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void button27_Click(object p0, EventArgs p1)
		{
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00004194 File Offset: 0x00002394
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void button23_Click(object p0, EventArgs p1)
		{
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00004198 File Offset: 0x00002398
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void button26_Click(object p0, EventArgs p1)
		{
		}

		// Token: 0x06000064 RID: 100 RVA: 0x0000419C File Offset: 0x0000239C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void button28_Click(object p0, EventArgs p1)
		{
			this.Bend.ExecuteScript("getglobal game\ngetfield -1 GetService\npushvalue -2\npushstring Lighting\npcall 2 1 0\npushstring 00:00:00\nsetfield -2 TimeOfDay\nemptystack");
		}

		// Token: 0x06000065 RID: 101 RVA: 0x000041B0 File Offset: 0x000023B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void button24_Click(object p0, EventArgs p1)
		{
			this.Bend.ExecuteScript("AnimationId = '248263260'\nlocal Anim = Instance.new('Animation')\nAnim.AnimationId = 'rbxassetid://'..AnimationId\nlocal k = game.Players.LocalPlayer.Character.Humanoid:LoadAnimation(Anim)\nk:Play()\nk:AdjustSpeed(1)");
		}

		// Token: 0x06000066 RID: 102 RVA: 0x000041C4 File Offset: 0x000023C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void button18_Click(object p0, EventArgs p1)
		{
			this.Bend.ExecuteScript("-- RGT Control\n-- RobloxFan777\nlocal RGTControl = Instance.new('ScreenGui')\nlocal MainRGT = Instance.new('Frame')\nlocal SongButton = Instance.new('TextButton')\nlocal FakeVictoryButton = Instance.new('TextButton')\nlocal RepFarmButton = Instance.new('TextButton')\nlocal BtoolsButton = Instance.new('TextButton')\nlocal JudgeButton = Instance.new('TextButton')\nlocal HostButton = Instance.new('TextButton')\nlocal JudgeButton_2 = Instance.new('TextButton')\nlocal Text = Instance.new('TextLabel')\nlocal Text_2 = Instance.new('TextLabel')\nlocal MusicBox = Instance.new('TextBox')\n--Properties:\nRGTControl.Name = 'RGT Control'\nRGTControl.Parent = game.Players.LocalPlayer:WaitForChild('PlayerGui')\n\nMainRGT.Name = 'MainRGT'\nMainRGT.Parent = RGTControl\nMainRGT.BackgroundColor3 = Color3.new(0.937255, 0.937255, 0.160784)\nMainRGT.BorderSizePixel = 0\nMainRGT.Position = UDim2.new(0.00774793373, 0, 0.510968924, 0)\nMainRGT.Size = UDim2.new(0, 366, 0, 334)\n\n\nSongButton.Name = 'SongButton'\nSongButton.Parent = MainRGT\nSongButton.BackgroundColor3 = Color3.new(1, 1, 1)\nSongButton.Position = UDim2.new(0.273224056, 0, 0.541916192, 0)\nSongButton.Size = UDim2.new(0, 166, 0, 50)\nSongButton.Style = Enum.ButtonStyle.RobloxRoundButton\nSongButton.Font = Enum.Font.SourceSans\nSongButton.Text = 'Play song [JUDGES ONLY]'\nSongButton.TextColor3 = Color3.new(1, 1, 1)\nSongButton.TextSize = 14\nSongButton.MouseButton1Down:connect(function()\ngame.ReplicatedStorage.Network.RGT['Sounds'].PlaySong:FireServer('a824k124jahf',MusicBox.Text)\nend)\n\n\nFakeVictoryButton.Name = 'FakeVictoryButton'\nFakeVictoryButton.Parent = MainRGT\nFakeVictoryButton.BackgroundColor3 = Color3.new(1, 1, 1)\nFakeVictoryButton.Position = UDim2.new(0.0573770478, 0, 0.146706581, 0)\nFakeVictoryButton.Size = UDim2.new(0, 113, 0, 50)\nFakeVictoryButton.Style = Enum.ButtonStyle.RobloxRoundButton\nFakeVictoryButton.Font = Enum.Font.SourceSans\nFakeVictoryButton.Text = 'Fake Victory [JUDGES ONLY]'\nFakeVictoryButton.TextColor3 = Color3.new(1, 1, 1)\nFakeVictoryButton.TextSize = 10\nFakeVictoryButton.MouseButton1Down:connect(function()\nlocal remotevent = 'a824k124jahf'\nlocal music = 1673138318\nlocal Event = game:GetService('ReplicatedStorage').Network.RGT.Sounds.PlaySong\nEvent:FireServer(remotevent, music)\nend)\n\n\n\nRepFarmButton.Name = 'RepFarmButton'\nRepFarmButton.Parent = MainRGT\nRepFarmButton.BackgroundColor3 = Color3.new(1, 1, 1)\nRepFarmButton.Position = UDim2.new(0.401639342, 0, 0.146706581, 0)\nRepFarmButton.Size = UDim2.new(0, 113, 0, 50)\nRepFarmButton.Style = Enum.ButtonStyle.RobloxRoundButton\nRepFarmButton.Font = Enum.Font.SourceSans\nRepFarmButton.Text = 'AFK Rep farm'\nRepFarmButton.TextColor3 = Color3.new(1, 1, 1)\nRepFarmButton.TextSize = 14\nRepFarmButton.MouseButton1Down:connect(function()\ngame.Players.LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(199.212384, 117.585548, -198.380081)\nend)\n\n\nBtoolsButton.Name = 'BtoolsButton'\nBtoolsButton.Parent = MainRGT\nBtoolsButton.BackgroundColor3 = Color3.new(1, 1, 1)\nBtoolsButton.Position = UDim2.new(0.0573770404, 0, 0.359281421, 0)\nBtoolsButton.Size = UDim2.new(0, 113, 0, 50)\nBtoolsButton.Style = Enum.ButtonStyle.RobloxRoundButton\nBtoolsButton.Font = Enum.Font.SourceSans\nBtoolsButton.Text = 'Btools'\nBtoolsButton.TextColor3 = Color3.new(1, 1, 1)\nBtoolsButton.TextSize = 14\nBtoolsButton.MouseButton1Down:connect(function()\nlocal rawrxd = workspace.CurrentCamera:Clone()\nrawrxd:ClearAllChildren()\nworkspace.CurrentCamera:Destroy()\nrawrxd.Parent = workspace\nfor i=2,4 do\n   Instance.new('HopperBin', game:GetService'Players'.LocalPlayer.Backpack).BinType = i\nend\nend)\n\n\nJudgeButton.Name = 'JudgeButton'\nJudgeButton.Parent = MainRGT\nJudgeButton.BackgroundColor3 = Color3.new(1, 1, 1)\nJudgeButton.Position = UDim2.new(0.401639342, 0, 0.359281421, 0)\nJudgeButton.Size = UDim2.new(0, 113, 0, 50)\nJudgeButton.Style = Enum.ButtonStyle.RobloxRoundButton\nJudgeButton.Font = Enum.Font.SourceSans\nJudgeButton.Text = 'Become Judge'\nJudgeButton.TextColor3 = Color3.new(1, 1, 1)\nJudgeButton.TextSize = 14\nJudgeButton.MouseButton1Down:connect(function()\ngame.ReplicatedStorage.Network.RGT['Spawn Manager'].ChangeTeam:FireServer('Judge')\nend)\n\n\n\nHostButton.Name = 'HostButton'\nHostButton.Parent = MainRGT\nHostButton.BackgroundColor3 = Color3.new(1, 1, 1)\nHostButton.Position = UDim2.new(0.756830633, 0, 0.146706581, 0)\nHostButton.Size = UDim2.new(0, 81, 0, 50)\nHostButton.Style = Enum.ButtonStyle.RobloxRoundButton\nHostButton.Font = Enum.Font.SourceSans\nHostButton.Text = 'Become Host'\nHostButton.TextColor3 = Color3.new(1, 1, 1)\nHostButton.TextSize = 14\nHostButton.MouseButton1Down:connect(function()\ngame.ReplicatedStorage.Network.RGT['Spawn Manager'].ChangeTeam:FireServer('Host')\nend)\n\n\n\nJudgeButton_2.Name = 'JudgeButton'\nJudgeButton_2.Parent = MainRGT\nJudgeButton_2.BackgroundColor3 = Color3.new(1, 1, 1)\nJudgeButton_2.Position = UDim2.new(0.745901644, 0, 0.359281451, 0)\nJudgeButton_2.Size = UDim2.new(0, 85, 0, 50)\nJudgeButton_2.Style = Enum.ButtonStyle.RobloxRoundButton\nJudgeButton_2.Font = Enum.Font.SourceSans\nJudgeButton_2.Text = 'Stop stage music'\nJudgeButton_2.TextColor3 = Color3.new(1, 1, 1)\nJudgeButton_2.TextSize = 13\nJudgeButton_2.MouseButton1Down:connect(function()\ngame.ReplicatedStorage.Network.RGT['Sounds'].StopSong:FireServer('a824k124jahf')\nend)\n\n\nText.Name = 'Text'\nText.Parent = MainRGT\nText.BackgroundColor3 = Color3.new(1, 1, 1)\nText.BackgroundTransparency = 1\nText.Position = UDim2.new(0.227035627, 0, 0.00110018253, 0)\nText.Size = UDim2.new(0, 200, 0, 50)\nText.Font = Enum.Font.SourceSans\nText.Text = 'RGT Control'\nText.TextColor3 = Color3.new(1, 0.564706, 0.27451)\nText.TextSize = 30\n\nText_2.Name = 'Text'\nText_2.Parent = MainRGT\nText_2.BackgroundColor3 = Color3.new(1, 1, 1)\nText_2.BackgroundTransparency = 1\nText_2.Position = UDim2.new(0.210642204, 0, 0.851399601, 0)\nText_2.Size = UDim2.new(0, 200, 0, 50)\nText_2.Font = Enum.Font.SourceSans\nText_2.Text = 'RobloxFan777 - V1.0.0'\nText_2.TextColor3 = Color3.new(1, 0.564706, 0.27451)\nText_2.TextSize = 30\n\nMusicBox.Name = 'MusicBox'\nMusicBox.Parent = MainRGT\nMusicBox.BackgroundColor3 = Color3.new(1, 0.717647, 0)\nMusicBox.BorderSizePixel = 0\nMusicBox.Position = UDim2.new(0.0573770478, 0, 0.721556902, 0)\nMusicBox.Size = UDim2.new(0, 319, 0, 50)\nMusicBox.Font = Enum.Font.SourceSans\nMusicBox.PlaceholderColor3 = Color3.new(1, 1, 0.262745)\nMusicBox.Text = 'Music ID Here'\nMusicBox.TextColor3 = Color3.new(0, 0, 0)\nMusicBox.TextSize = 20\nMusicBox.TextWrapped = true\n-- Scripts:");
		}

		// Token: 0x06000067 RID: 103 RVA: 0x000041D8 File Offset: 0x000023D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void button30_Click(object p0, EventArgs p1)
		{
		}

		// Token: 0x06000068 RID: 104 RVA: 0x000041DC File Offset: 0x000023DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void button29_Click(object p0, EventArgs p1)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		// Token: 0x06000069 RID: 105 RVA: 0x000041E8 File Offset: 0x000023E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void button1_Click_2(object p0, EventArgs p1)
		{
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00004238 File Offset: 0x00002438
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void InitializeComponent()
		{
			//ComponentResourceManager componentResourceManager = new ComponentResourceManager(Type.GetTypeFromHandle(c000014.m000005(33554440)));
			this.tabControl1 = new TabControl();
			this.tabPage1 = new TabPage();
			this.button17 = new Button();
			this.button16 = new Button();
			this.button5 = new Button();
			this.button10 = new Button();
			this.button14 = new Button();
			this.button13 = new Button();
			this.button12 = new Button();
			this.button11 = new Button();
			this.button9 = new Button();
			this.button8 = new Button();
			this.button6 = new Button();
			this.button4 = new Button();
			this.button2 = new Button();
			this.button3 = new Button();
			this.tabPage2 = new TabPage();
			this.button15 = new Button();
			this.button7 = new Button();
			this.tabPage3 = new TabPage();
			this.button18 = new Button();
			this.panel1 = new Panel();
			this.button29 = new Button();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.panel1.SuspendLayout();
			base.SuspendLayout();
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Location = new Point(0, 28);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new Size(566, 230);
			this.tabControl1.TabIndex = 22;
			this.tabPage1.Controls.Add(this.button17);
			this.tabPage1.Controls.Add(this.button16);
			this.tabPage1.Controls.Add(this.button5);
			this.tabPage1.Controls.Add(this.button10);
			this.tabPage1.Controls.Add(this.button14);
			this.tabPage1.Controls.Add(this.button13);
			this.tabPage1.Controls.Add(this.button12);
			this.tabPage1.Controls.Add(this.button11);
			this.tabPage1.Controls.Add(this.button9);
			this.tabPage1.Controls.Add(this.button8);
			this.tabPage1.Controls.Add(this.button6);
			this.tabPage1.Controls.Add(this.button4);
			this.tabPage1.Controls.Add(this.button2);
			this.tabPage1.Controls.Add(this.button3);
			this.tabPage1.Location = new Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new Padding(3);
			this.tabPage1.Size = new Size(558, 204);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Jailbreak";
			this.tabPage1.UseVisualStyleBackColor = true;
			this.button17.BackColor = Color.FromArgb(40, 40, 40);
			this.button17.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
			this.button17.FlatStyle = FlatStyle.Flat;
			this.button17.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.button17.ForeColor = Color.White;
			this.button17.Location = new Point(429, 84);
			this.button17.Name = "button17";
			this.button17.Size = new Size(124, 33);
			this.button17.TabIndex = 44;
			this.button17.Text = "Crim base 2";
			this.button17.UseVisualStyleBackColor = false;
			this.button17.Click += this.button17_Click;
			this.button16.BackColor = Color.FromArgb(40, 40, 40);
			this.button16.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
			this.button16.FlatStyle = FlatStyle.Flat;
			this.button16.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.button16.ForeColor = Color.White;
			this.button16.Location = new Point(429, 45);
			this.button16.Name = "button16";
			this.button16.Size = new Size(124, 33);
			this.button16.TabIndex = 43;
			this.button16.Text = "Jewelry (IN)";
			this.button16.UseVisualStyleBackColor = false;
			this.button5.BackColor = Color.FromArgb(40, 40, 40);
			this.button5.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
			this.button5.FlatStyle = FlatStyle.Flat;
			this.button5.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.button5.ForeColor = Color.White;
			this.button5.Location = new Point(429, 6);
			this.button5.Name = "button5";
			this.button5.Size = new Size(124, 33);
			this.button5.TabIndex = 42;
			this.button5.Text = "Keycard";
			this.button5.UseVisualStyleBackColor = false;
			this.button10.BackColor = Color.FromArgb(40, 40, 40);
			this.button10.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
			this.button10.FlatStyle = FlatStyle.Flat;
			this.button10.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.button10.ForeColor = Color.White;
			this.button10.Location = new Point(9, 162);
			this.button10.Name = "button10";
			this.button10.Size = new Size(544, 33);
			this.button10.TabIndex = 41;
			this.button10.Text = "Remove Museum Lasers";
			this.button10.UseVisualStyleBackColor = false;
			this.button14.BackColor = Color.FromArgb(40, 40, 40);
			this.button14.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
			this.button14.FlatStyle = FlatStyle.Flat;
			this.button14.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.button14.ForeColor = Color.White;
			this.button14.Location = new Point(289, 84);
			this.button14.Name = "button14";
			this.button14.Size = new Size(134, 33);
			this.button14.TabIndex = 32;
			this.button14.Text = "Crim base 1";
			this.button14.UseVisualStyleBackColor = false;
			this.button14.Click += this.button14_Click;
			this.button13.BackColor = Color.FromArgb(40, 40, 40);
			this.button13.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
			this.button13.FlatStyle = FlatStyle.Flat;
			this.button13.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.button13.ForeColor = Color.White;
			this.button13.Location = new Point(149, 84);
			this.button13.Name = "button13";
			this.button13.Size = new Size(134, 33);
			this.button13.TabIndex = 31;
			this.button13.Text = "Museum (IN)";
			this.button13.UseVisualStyleBackColor = false;
			this.button12.BackColor = Color.FromArgb(40, 40, 40);
			this.button12.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
			this.button12.FlatStyle = FlatStyle.Flat;
			this.button12.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.button12.ForeColor = Color.White;
			this.button12.Location = new Point(289, 45);
			this.button12.Name = "button12";
			this.button12.Size = new Size(134, 33);
			this.button12.TabIndex = 30;
			this.button12.Text = "Jewelry";
			this.button12.UseVisualStyleBackColor = false;
			this.button11.BackColor = Color.FromArgb(40, 40, 40);
			this.button11.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
			this.button11.FlatStyle = FlatStyle.Flat;
			this.button11.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.button11.ForeColor = Color.White;
			this.button11.Location = new Point(149, 45);
			this.button11.Name = "button11";
			this.button11.Size = new Size(134, 33);
			this.button11.TabIndex = 29;
			this.button11.Text = "Bank (IN)";
			this.button11.UseVisualStyleBackColor = false;
			this.button9.BackColor = Color.FromArgb(40, 40, 40);
			this.button9.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
			this.button9.FlatStyle = FlatStyle.Flat;
			this.button9.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.button9.ForeColor = Color.White;
			this.button9.Location = new Point(9, 123);
			this.button9.Name = "button9";
			this.button9.Size = new Size(544, 33);
			this.button9.TabIndex = 27;
			this.button9.Text = "Remove Bank Lasers";
			this.button9.UseVisualStyleBackColor = false;
			this.button8.BackColor = Color.FromArgb(40, 40, 40);
			this.button8.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
			this.button8.FlatStyle = FlatStyle.Flat;
			this.button8.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.button8.ForeColor = Color.White;
			this.button8.Location = new Point(9, 84);
			this.button8.Name = "button8";
			this.button8.Size = new Size(134, 33);
			this.button8.TabIndex = 26;
			this.button8.Text = "Museum";
			this.button8.UseVisualStyleBackColor = false;
			this.button6.BackColor = Color.FromArgb(40, 40, 40);
			this.button6.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
			this.button6.FlatStyle = FlatStyle.Flat;
			this.button6.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.button6.ForeColor = Color.White;
			this.button6.Location = new Point(9, 45);
			this.button6.Name = "button6";
			this.button6.Size = new Size(134, 33);
			this.button6.TabIndex = 24;
			this.button6.Text = "Bank";
			this.button6.UseVisualStyleBackColor = false;
			this.button4.BackColor = Color.FromArgb(40, 40, 40);
			this.button4.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
			this.button4.FlatStyle = FlatStyle.Flat;
			this.button4.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.button4.ForeColor = Color.White;
			this.button4.Location = new Point(289, 6);
			this.button4.Name = "button4";
			this.button4.Size = new Size(134, 33);
			this.button4.TabIndex = 22;
			this.button4.Text = "AK47";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += this.button4_Click;
			this.button2.BackColor = Color.FromArgb(40, 40, 40);
			this.button2.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
			this.button2.FlatStyle = FlatStyle.Flat;
			this.button2.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.button2.ForeColor = Color.White;
			this.button2.Location = new Point(149, 6);
			this.button2.Name = "button2";
			this.button2.Size = new Size(134, 33);
			this.button2.TabIndex = 21;
			this.button2.Text = "Shotgun";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += this.button2_Click;
			this.button3.BackColor = Color.FromArgb(40, 40, 40);
			this.button3.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
			this.button3.FlatStyle = FlatStyle.Flat;
			this.button3.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.button3.ForeColor = Color.White;
			this.button3.Location = new Point(9, 6);
			this.button3.Name = "button3";
			this.button3.Size = new Size(134, 33);
			this.button3.TabIndex = 20;
			this.button3.Text = "Pistol";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += this.button3_Click;
			this.tabPage2.Controls.Add(this.button15);
			this.tabPage2.Controls.Add(this.button7);
			this.tabPage2.Location = new Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Size = new Size(561, 208);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Phantom Forces";
			this.tabPage2.UseVisualStyleBackColor = true;
			this.button15.BackColor = Color.FromArgb(40, 40, 40);
			this.button15.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
			this.button15.FlatStyle = FlatStyle.Flat;
			this.button15.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.button15.ForeColor = Color.White;
			this.button15.Location = new Point(3, 78);
			this.button15.Name = "button15";
			this.button15.Size = new Size(555, 118);
			this.button15.TabIndex = 22;
			this.button15.Text = "Inf Jump";
			this.button15.UseVisualStyleBackColor = false;
			this.button15.Click += this.button15_Click;
			this.button7.BackColor = Color.FromArgb(40, 40, 40);
			this.button7.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
			this.button7.FlatStyle = FlatStyle.Flat;
			this.button7.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.button7.ForeColor = Color.White;
			this.button7.Location = new Point(3, 3);
			this.button7.Name = "button7";
			this.button7.Size = new Size(555, 69);
			this.button7.TabIndex = 21;
			this.button7.Text = "Click Delete";
			this.button7.UseVisualStyleBackColor = false;
			this.button7.Click += this.button7_Click;
			this.tabPage3.Controls.Add(this.button18);
			this.tabPage3.Location = new Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Size = new Size(561, 208);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Roblox's Got Talent";
			this.tabPage3.UseVisualStyleBackColor = true;
			this.button18.BackColor = Color.FromArgb(40, 40, 40);
			this.button18.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
			this.button18.FlatStyle = FlatStyle.Flat;
			this.button18.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.button18.ForeColor = Color.White;
			this.button18.Location = new Point(3, 3);
			this.button18.Name = "button18";
			this.button18.Size = new Size(555, 200);
			this.button18.TabIndex = 22;
			this.button18.Text = "GUI";
			this.button18.UseVisualStyleBackColor = false;
			this.button18.Click += this.button18_Click;
			this.panel1.BackColor = SystemColors.ControlLight;
			this.panel1.Controls.Add(this.button29);
			this.panel1.Location = new Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new Size(569, 31);
			this.panel1.TabIndex = 23;
			this.panel1.MouseDown += this.panel1_MouseDown;
			this.panel1.MouseMove += this.panel1_MouseMove;
			this.button29.FlatAppearance.BorderSize = 0;
			this.button29.FlatStyle = FlatStyle.Flat;
			this.button29.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button29.Location = new Point(536, 0);
			this.button29.Name = "button29";
			this.button29.Size = new Size(33, 31);
			this.button29.TabIndex = 24;
			this.button29.Text = "_";
			this.button29.UseVisualStyleBackColor = true;
			this.button29.Click += this.button29_Click;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.White;
			base.ClientSize = new Size(568, 260);
			base.Controls.Add(this.panel1);
			base.Controls.Add(this.tabControl1);
			base.FormBorderStyle = FormBorderStyle.None;
			//base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "Settings";
			this.Text = "Settings";
			base.Load += this.Settings_Load;
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.tabPage3.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00005880 File Offset: 0x00003A80
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void richTextBox1_TextChanged(object p0, EventArgs p1)
		{
			throw new NotImplementedException();
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00005888 File Offset: 0x00003A88
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool m000001()
		{
			return true;
		}

		// Token: 0x0600006E RID: 110 RVA: 0x0000588C File Offset: 0x00003A8C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool m000002()
		{
			return false;
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00005890 File Offset: 0x00003A90
		static Settings()
		{
			//c00000f.ejrW12LnL();
		}

		// Token: 0x04000021 RID: 33
		public SpareModule Bend;

		// Token: 0x04000022 RID: 34
		public Point lastPoint;

		// Token: 0x04000024 RID: 36
		public TabControl tabControl1;

		// Token: 0x04000025 RID: 37
		public TabPage tabPage1;

		// Token: 0x04000026 RID: 38
		public Button button14;

		// Token: 0x04000027 RID: 39
		public Button button13;

		// Token: 0x04000028 RID: 40
		public Button button12;

		// Token: 0x04000029 RID: 41
		public Button button11;

		// Token: 0x0400002A RID: 42
		public Button button9;

		// Token: 0x0400002B RID: 43
		public Button button8;

		// Token: 0x0400002C RID: 44
		public Button button6;

		// Token: 0x0400002D RID: 45
		public Button button4;

		// Token: 0x0400002E RID: 46
		public Button button2;

		// Token: 0x0400002F RID: 47
		public Button button3;

		// Token: 0x04000030 RID: 48
		public Button button17;

		// Token: 0x04000031 RID: 49
		public Button button16;

		// Token: 0x04000032 RID: 50
		public Button button5;

		// Token: 0x04000033 RID: 51
		public Button button10;

		// Token: 0x04000034 RID: 52
		public Panel panel1;

		// Token: 0x04000035 RID: 53
		public TabPage tabPage2;

		// Token: 0x04000036 RID: 54
		public Button button15;

		// Token: 0x04000037 RID: 55
		public Button button7;

		// Token: 0x04000038 RID: 56
		public TabPage tabPage3;

		// Token: 0x04000039 RID: 57
		public Button button18;

		// Token: 0x0400003A RID: 58
		public Button button29;
	}
}

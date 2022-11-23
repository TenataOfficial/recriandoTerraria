'
' Created by SharpDevelop.
' User: Tenataz
' Date: 22/11/2022
' Time: 10:27
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class MainForm
	Inherits System.Windows.Forms.Form
	
	''' <summary>
	''' Designer variable used to keep track of non-visual components.
	''' </summary>
	Private components As System.ComponentModel.IContainer
	
	''' <summary>
	''' Disposes resources used by the form.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing Then
			If components IsNot Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(disposing)
	End Sub
	
	''' <summary>
	''' This method is required for Windows Forms designer support.
	''' Do not change the method contents inside the source code editor. The Forms designer might
	''' not be able to load this method if it was changed manually.
	''' </summary>
	Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
		Me.pictureBox1 = New System.Windows.Forms.PictureBox()
		Me.timer1 = New System.Windows.Forms.Timer(Me.components)
		Me.panel1 = New System.Windows.Forms.Panel()
		Me.button1 = New System.Windows.Forms.Button()
		Me.timer2 = New System.Windows.Forms.Timer(Me.components)
		Me.timer3 = New System.Windows.Forms.Timer(Me.components)
		Me.statusStrip1 = New System.Windows.Forms.StatusStrip()
		Me.toolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
		Me.toolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
		Me.toolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
		Me.tamanhoDaTelaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.toolStripTextBox2 = New System.Windows.Forms.ToolStripTextBox()
		Me.tamanhoDosBlocosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.toolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
		Me.toolStripSplitButton1 = New System.Windows.Forms.ToolStripSplitButton()
		Me.bLOCOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.toolStripComboBox1 = New System.Windows.Forms.ToolStripComboBox()
		CType(Me.pictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
		Me.panel1.SuspendLayout
		Me.statusStrip1.SuspendLayout
		Me.SuspendLayout
		'
		'pictureBox1
		'
		Me.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.pictureBox1.Location = New System.Drawing.Point(0, 0)
		Me.pictureBox1.Name = "pictureBox1"
		Me.pictureBox1.Size = New System.Drawing.Size(640, 380)
		Me.pictureBox1.TabIndex = 0
		Me.pictureBox1.TabStop = false
		AddHandler Me.pictureBox1.MouseClick, AddressOf Me.PictureBox1MouseClick
		'
		'timer1
		'
		Me.timer1.Enabled = true
		Me.timer1.Interval = 1
		AddHandler Me.timer1.Tick, AddressOf Me.Timer1Tick
		'
		'panel1
		'
		Me.panel1.Controls.Add(Me.button1)
		Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
		Me.panel1.Location = New System.Drawing.Point(0, 0)
		Me.panel1.Name = "panel1"
		Me.panel1.Size = New System.Drawing.Size(640, 25)
		Me.panel1.TabIndex = 1
		AddHandler Me.panel1.MouseMove, AddressOf Me.Panel1MouseMove
		'
		'button1
		'
		Me.button1.Location = New System.Drawing.Point(0, 0)
		Me.button1.Name = "button1"
		Me.button1.Size = New System.Drawing.Size(75, 23)
		Me.button1.TabIndex = 0
		Me.button1.Text = "button1"
		Me.button1.UseVisualStyleBackColor = true
		AddHandler Me.button1.Click, AddressOf Me.Button1Click
		'
		'timer2
		'
		Me.timer2.Enabled = true
		Me.timer2.Interval = 200
		AddHandler Me.timer2.Tick, AddressOf Me.Timer2Tick
		'
		'timer3
		'
		Me.timer3.Enabled = true
		Me.timer3.Interval = 1
		AddHandler Me.timer3.Tick, AddressOf Me.Timer3Tick
		'
		'statusStrip1
		'
		Me.statusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripProgressBar1, Me.toolStripDropDownButton1, Me.toolStripSplitButton1})
		Me.statusStrip1.Location = New System.Drawing.Point(0, 358)
		Me.statusStrip1.Name = "statusStrip1"
		Me.statusStrip1.Size = New System.Drawing.Size(640, 22)
		Me.statusStrip1.TabIndex = 2
		Me.statusStrip1.Text = "statusStrip1"
		'
		'toolStripProgressBar1
		'
		Me.toolStripProgressBar1.Name = "toolStripProgressBar1"
		Me.toolStripProgressBar1.Size = New System.Drawing.Size(100, 16)
		'
		'toolStripDropDownButton1
		'
		Me.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.toolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripMenuItem1})
		Me.toolStripDropDownButton1.Image = CType(resources.GetObject("toolStripDropDownButton1.Image"),System.Drawing.Image)
		Me.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.toolStripDropDownButton1.Name = "toolStripDropDownButton1"
		Me.toolStripDropDownButton1.Size = New System.Drawing.Size(29, 20)
		Me.toolStripDropDownButton1.Text = "toolStripDropDownButton1"
		'
		'toolStripMenuItem1
		'
		Me.toolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tamanhoDaTelaToolStripMenuItem, Me.tamanhoDosBlocosToolStripMenuItem})
		Me.toolStripMenuItem1.Name = "toolStripMenuItem1"
		Me.toolStripMenuItem1.Size = New System.Drawing.Size(100, 22)
		Me.toolStripMenuItem1.Text = "menu"
		'
		'tamanhoDaTelaToolStripMenuItem
		'
		Me.tamanhoDaTelaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripTextBox2})
		Me.tamanhoDaTelaToolStripMenuItem.Name = "tamanhoDaTelaToolStripMenuItem"
		Me.tamanhoDaTelaToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
		Me.tamanhoDaTelaToolStripMenuItem.Text = "tamanho da tela"
		'
		'toolStripTextBox2
		'
		Me.toolStripTextBox2.Name = "toolStripTextBox2"
		Me.toolStripTextBox2.Size = New System.Drawing.Size(100, 21)
		Me.toolStripTextBox2.Text = "11"
		AddHandler Me.toolStripTextBox2.KeyPress, AddressOf Me.ToolStripTextBox2KeyPress
		'
		'tamanhoDosBlocosToolStripMenuItem
		'
		Me.tamanhoDosBlocosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripTextBox1})
		Me.tamanhoDosBlocosToolStripMenuItem.Name = "tamanhoDosBlocosToolStripMenuItem"
		Me.tamanhoDosBlocosToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
		Me.tamanhoDosBlocosToolStripMenuItem.Text = "tamanho dos blocos"
		'
		'toolStripTextBox1
		'
		Me.toolStripTextBox1.Name = "toolStripTextBox1"
		Me.toolStripTextBox1.Size = New System.Drawing.Size(100, 21)
		Me.toolStripTextBox1.Text = "30"
		AddHandler Me.toolStripTextBox1.KeyPress, AddressOf Me.ToolStripTextBox1KeyPress
		'
		'toolStripSplitButton1
		'
		Me.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.toolStripSplitButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.bLOCOSToolStripMenuItem})
		Me.toolStripSplitButton1.Image = CType(resources.GetObject("toolStripSplitButton1.Image"),System.Drawing.Image)
		Me.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.toolStripSplitButton1.Name = "toolStripSplitButton1"
		Me.toolStripSplitButton1.Size = New System.Drawing.Size(32, 20)
		Me.toolStripSplitButton1.Text = "toolStripSplitButton1"
		'
		'bLOCOSToolStripMenuItem
		'
		Me.bLOCOSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripComboBox1})
		Me.bLOCOSToolStripMenuItem.Name = "bLOCOSToolStripMenuItem"
		Me.bLOCOSToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
		Me.bLOCOSToolStripMenuItem.Text = "BLOCOS"
		'
		'toolStripComboBox1
		'
		Me.toolStripComboBox1.AutoCompleteCustomSource.AddRange(New String() {"MADEIRA", "GRAMA", "TERRA", "AREIA", "PEDRA"})
		Me.toolStripComboBox1.Items.AddRange(New Object() {"MADEIRA", "GRAMA", "TERRA", "AREIA", "PEDRA"})
		Me.toolStripComboBox1.Name = "toolStripComboBox1"
		Me.toolStripComboBox1.Size = New System.Drawing.Size(121, 21)
		Me.toolStripComboBox1.Text = "GRAMA"
		AddHandler Me.toolStripComboBox1.TextChanged, AddressOf Me.ToolStripComboBox1TextChanged
		'
		'MainForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(640, 380)
		Me.Controls.Add(Me.statusStrip1)
		Me.Controls.Add(Me.panel1)
		Me.Controls.Add(Me.pictureBox1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Name = "MainForm"
		Me.Text = "nossojogo"
		AddHandler Load, AddressOf Me.MainFormLoad
		CType(Me.pictureBox1,System.ComponentModel.ISupportInitialize).EndInit
		Me.panel1.ResumeLayout(false)
		Me.statusStrip1.ResumeLayout(false)
		Me.statusStrip1.PerformLayout
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private toolStripComboBox1 As System.Windows.Forms.ToolStripComboBox
	Private bLOCOSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private toolStripSplitButton1 As System.Windows.Forms.ToolStripSplitButton
	Private toolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
	Private tamanhoDosBlocosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private toolStripTextBox2 As System.Windows.Forms.ToolStripTextBox
	Private tamanhoDaTelaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private toolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
	Private toolStripDropDownButton1 As System.Windows.Forms.ToolStripDropDownButton
	Private toolStripProgressBar1 As System.Windows.Forms.ToolStripProgressBar
	Private statusStrip1 As System.Windows.Forms.StatusStrip
	Private button1 As System.Windows.Forms.Button
	Private timer3 As System.Windows.Forms.Timer
	Private timer2 As System.Windows.Forms.Timer
	Private panel1 As System.Windows.Forms.Panel
	Private timer1 As System.Windows.Forms.Timer
	Private pictureBox1 As System.Windows.Forms.PictureBox
End Class

'
' Created by SharpDevelop.
' User: CEEP
' Date: 19/11/2021
' Time: 08:44
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
		Me.pictureBox1 = New System.Windows.Forms.PictureBox()
		Me.pictureBox2 = New System.Windows.Forms.PictureBox()
		Me.pc3 = New System.Windows.Forms.PictureBox()
		Me.pc4 = New System.Windows.Forms.PictureBox()
		Me.pc5 = New System.Windows.Forms.PictureBox()
		Me.pc6 = New System.Windows.Forms.PictureBox()
		Me.pc7 = New System.Windows.Forms.PictureBox()
		Me.pc8 = New System.Windows.Forms.PictureBox()
		Me.pc9 = New System.Windows.Forms.PictureBox()
		Me.pc10 = New System.Windows.Forms.PictureBox()
		Me.pc11 = New System.Windows.Forms.PictureBox()
		Me.pc12 = New System.Windows.Forms.PictureBox()
		Me.pc13 = New System.Windows.Forms.PictureBox()
		Me.pc14 = New System.Windows.Forms.PictureBox()
		Me.pc15 = New System.Windows.Forms.PictureBox()
		Me.pc16 = New System.Windows.Forms.PictureBox()
		Me.pc17 = New System.Windows.Forms.PictureBox()
		Me.pc18 = New System.Windows.Forms.PictureBox()
		Me.timer1 = New System.Windows.Forms.Timer(Me.components)
		Me.bola = New System.Windows.Forms.PictureBox()
		Me.pictureBox3 = New System.Windows.Forms.PictureBox()
		CType(Me.pictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.pictureBox2,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.pc3,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.pc4,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.pc5,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.pc6,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.pc7,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.pc8,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.pc9,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.pc10,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.pc11,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.pc12,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.pc13,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.pc14,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.pc15,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.pc16,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.pc17,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.pc18,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.bola,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.pictureBox3,System.ComponentModel.ISupportInitialize).BeginInit
		Me.SuspendLayout
		'
		'pictureBox1
		'
		Me.pictureBox1.BackColor = System.Drawing.Color.Lime
		Me.pictureBox1.Location = New System.Drawing.Point(71, 236)
		Me.pictureBox1.Name = "pictureBox1"
		Me.pictureBox1.Size = New System.Drawing.Size(100, 13)
		Me.pictureBox1.TabIndex = 0
		Me.pictureBox1.TabStop = false
		'
		'pictureBox2
		'
		Me.pictureBox2.BackColor = System.Drawing.Color.Lime
		Me.pictureBox2.Location = New System.Drawing.Point(329, 236)
		Me.pictureBox2.Name = "pictureBox2"
		Me.pictureBox2.Size = New System.Drawing.Size(100, 13)
		Me.pictureBox2.TabIndex = 1
		Me.pictureBox2.TabStop = false
		'
		'pc3
		'
		Me.pc3.BackColor = System.Drawing.Color.Cyan
		Me.pc3.Location = New System.Drawing.Point(12, 12)
		Me.pc3.Name = "pc3"
		Me.pc3.Size = New System.Drawing.Size(45, 27)
		Me.pc3.TabIndex = 2
		Me.pc3.TabStop = false
		Me.pc3.Tag = "peca"
		'
		'pc4
		'
		Me.pc4.BackColor = System.Drawing.Color.Cyan
		Me.pc4.Location = New System.Drawing.Point(58, 12)
		Me.pc4.Name = "pc4"
		Me.pc4.Size = New System.Drawing.Size(45, 27)
		Me.pc4.TabIndex = 3
		Me.pc4.TabStop = false
		Me.pc4.Tag = "peca"
		'
		'pc5
		'
		Me.pc5.BackColor = System.Drawing.Color.Cyan
		Me.pc5.Location = New System.Drawing.Point(104, 12)
		Me.pc5.Name = "pc5"
		Me.pc5.Size = New System.Drawing.Size(45, 27)
		Me.pc5.TabIndex = 4
		Me.pc5.TabStop = false
		Me.pc5.Tag = "peca"
		'
		'pc6
		'
		Me.pc6.BackColor = System.Drawing.Color.Cyan
		Me.pc6.Location = New System.Drawing.Point(150, 12)
		Me.pc6.Name = "pc6"
		Me.pc6.Size = New System.Drawing.Size(45, 27)
		Me.pc6.TabIndex = 5
		Me.pc6.TabStop = false
		Me.pc6.Tag = "peca"
		'
		'pc7
		'
		Me.pc7.BackColor = System.Drawing.Color.Cyan
		Me.pc7.Location = New System.Drawing.Point(196, 12)
		Me.pc7.Name = "pc7"
		Me.pc7.Size = New System.Drawing.Size(45, 27)
		Me.pc7.TabIndex = 6
		Me.pc7.TabStop = false
		Me.pc7.Tag = "peca"
		'
		'pc8
		'
		Me.pc8.BackColor = System.Drawing.Color.Cyan
		Me.pc8.Location = New System.Drawing.Point(0, 41)
		Me.pc8.Name = "pc8"
		Me.pc8.Size = New System.Drawing.Size(45, 27)
		Me.pc8.TabIndex = 7
		Me.pc8.TabStop = false
		Me.pc8.Tag = "peca"
		'
		'pc9
		'
		Me.pc9.BackColor = System.Drawing.Color.Cyan
		Me.pc9.Location = New System.Drawing.Point(184, 41)
		Me.pc9.Name = "pc9"
		Me.pc9.Size = New System.Drawing.Size(45, 27)
		Me.pc9.TabIndex = 11
		Me.pc9.TabStop = false
		Me.pc9.Tag = "peca"
		'
		'pc10
		'
		Me.pc10.BackColor = System.Drawing.Color.Cyan
		Me.pc10.Location = New System.Drawing.Point(138, 41)
		Me.pc10.Name = "pc10"
		Me.pc10.Size = New System.Drawing.Size(45, 27)
		Me.pc10.TabIndex = 10
		Me.pc10.TabStop = false
		Me.pc10.Tag = "peca"
		'
		'pc11
		'
		Me.pc11.BackColor = System.Drawing.Color.Cyan
		Me.pc11.Location = New System.Drawing.Point(92, 41)
		Me.pc11.Name = "pc11"
		Me.pc11.Size = New System.Drawing.Size(45, 27)
		Me.pc11.TabIndex = 9
		Me.pc11.TabStop = false
		Me.pc11.Tag = "peca"
		'
		'pc12
		'
		Me.pc12.BackColor = System.Drawing.Color.Cyan
		Me.pc12.Location = New System.Drawing.Point(46, 41)
		Me.pc12.Name = "pc12"
		Me.pc12.Size = New System.Drawing.Size(45, 27)
		Me.pc12.TabIndex = 8
		Me.pc12.TabStop = false
		Me.pc12.Tag = "peca"
		'
		'pc13
		'
		Me.pc13.BackColor = System.Drawing.Color.Cyan
		Me.pc13.Location = New System.Drawing.Point(171, 69)
		Me.pc13.Name = "pc13"
		Me.pc13.Size = New System.Drawing.Size(45, 27)
		Me.pc13.TabIndex = 15
		Me.pc13.TabStop = false
		Me.pc13.Tag = "peca"
		'
		'pc14
		'
		Me.pc14.BackColor = System.Drawing.Color.Cyan
		Me.pc14.Location = New System.Drawing.Point(125, 69)
		Me.pc14.Name = "pc14"
		Me.pc14.Size = New System.Drawing.Size(45, 27)
		Me.pc14.TabIndex = 14
		Me.pc14.TabStop = false
		Me.pc14.Tag = "peca"
		'
		'pc15
		'
		Me.pc15.BackColor = System.Drawing.Color.Cyan
		Me.pc15.Location = New System.Drawing.Point(79, 69)
		Me.pc15.Name = "pc15"
		Me.pc15.Size = New System.Drawing.Size(45, 27)
		Me.pc15.TabIndex = 13
		Me.pc15.TabStop = false
		Me.pc15.Tag = "peca"
		'
		'pc16
		'
		Me.pc16.BackColor = System.Drawing.Color.Cyan
		Me.pc16.Location = New System.Drawing.Point(33, 69)
		Me.pc16.Name = "pc16"
		Me.pc16.Size = New System.Drawing.Size(45, 27)
		Me.pc16.TabIndex = 12
		Me.pc16.TabStop = false
		Me.pc16.Tag = "peca"
		'
		'pc17
		'
		Me.pc17.BackColor = System.Drawing.Color.Cyan
		Me.pc17.Location = New System.Drawing.Point(217, 69)
		Me.pc17.Name = "pc17"
		Me.pc17.Size = New System.Drawing.Size(45, 27)
		Me.pc17.TabIndex = 16
		Me.pc17.TabStop = false
		Me.pc17.Tag = "peca"
		'
		'pc18
		'
		Me.pc18.BackColor = System.Drawing.Color.Cyan
		Me.pc18.Location = New System.Drawing.Point(230, 41)
		Me.pc18.Name = "pc18"
		Me.pc18.Size = New System.Drawing.Size(45, 27)
		Me.pc18.TabIndex = 17
		Me.pc18.TabStop = false
		Me.pc18.Tag = "peca"
		'
		'timer1
		'
		Me.timer1.Interval = 1
		AddHandler Me.timer1.Tick, AddressOf Me.Timer1Tick
		'
		'bola
		'
		Me.bola.BackColor = System.Drawing.Color.Red
		Me.bola.Location = New System.Drawing.Point(127, 170)
		Me.bola.Name = "bola"
		Me.bola.Size = New System.Drawing.Size(10, 10)
		Me.bola.TabIndex = 18
		Me.bola.TabStop = false
		'
		'pictureBox3
		'
		Me.pictureBox3.BackColor = System.Drawing.Color.Lime
		Me.pictureBox3.Location = New System.Drawing.Point(107, 231)
		Me.pictureBox3.Name = "pictureBox3"
		Me.pictureBox3.Size = New System.Drawing.Size(20, 13)
		Me.pictureBox3.TabIndex = 19
		Me.pictureBox3.TabStop = false
		Me.pictureBox3.Visible = false
		'
		'MainForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(284, 261)
		Me.Controls.Add(Me.pictureBox3)
		Me.Controls.Add(Me.bola)
		Me.Controls.Add(Me.pc18)
		Me.Controls.Add(Me.pc17)
		Me.Controls.Add(Me.pc13)
		Me.Controls.Add(Me.pc14)
		Me.Controls.Add(Me.pc15)
		Me.Controls.Add(Me.pc16)
		Me.Controls.Add(Me.pc9)
		Me.Controls.Add(Me.pc10)
		Me.Controls.Add(Me.pc11)
		Me.Controls.Add(Me.pc12)
		Me.Controls.Add(Me.pc8)
		Me.Controls.Add(Me.pc7)
		Me.Controls.Add(Me.pc6)
		Me.Controls.Add(Me.pc5)
		Me.Controls.Add(Me.pc4)
		Me.Controls.Add(Me.pc3)
		Me.Controls.Add(Me.pictureBox2)
		Me.Controls.Add(Me.pictureBox1)
		Me.Name = "MainForm"
		Me.Text = "eduardoemonica"
		AddHandler KeyDown, AddressOf Me.MainFormKeyDown
		CType(Me.pictureBox1,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.pictureBox2,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.pc3,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.pc4,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.pc5,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.pc6,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.pc7,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.pc8,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.pc9,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.pc10,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.pc11,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.pc12,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.pc13,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.pc14,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.pc15,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.pc16,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.pc17,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.pc18,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.bola,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.pictureBox3,System.ComponentModel.ISupportInitialize).EndInit
		Me.ResumeLayout(false)
	End Sub
	Private pictureBox3 As System.Windows.Forms.PictureBox
	Private bola As System.Windows.Forms.PictureBox
	Private timer1 As System.Windows.Forms.Timer
	Private pc18 As System.Windows.Forms.PictureBox
	Private pc17 As System.Windows.Forms.PictureBox
	Private pc16 As System.Windows.Forms.PictureBox
	Private pc15 As System.Windows.Forms.PictureBox
	Private pc14 As System.Windows.Forms.PictureBox
	Private pc13 As System.Windows.Forms.PictureBox
	Private pc12 As System.Windows.Forms.PictureBox
	Private pc11 As System.Windows.Forms.PictureBox
	Private pc10 As System.Windows.Forms.PictureBox
	Private pc9 As System.Windows.Forms.PictureBox
	Private pc8 As System.Windows.Forms.PictureBox
	Private pc7 As System.Windows.Forms.PictureBox
	Private pc6 As System.Windows.Forms.PictureBox
	Private pc5 As System.Windows.Forms.PictureBox
	Private pc4 As System.Windows.Forms.PictureBox
	Private pc3 As System.Windows.Forms.PictureBox
	Private pictureBox2 As System.Windows.Forms.PictureBox
	Private pictureBox1 As System.Windows.Forms.PictureBox
End Class

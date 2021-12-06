
Public Partial Class MainForm
	Public Sub New()
		
		Me.InitializeComponent()
		
	End Sub
	
	Sub MainFormKeyDown(sender As Object, e As KeyEventArgs)
		
		Me.Text = pictureBox1.Left
		
		
		If pictureBox1.Left < 0  Then
			
			pictureBox2.Left = pictureBox1.Left + Me.Width
			
		Else If pictureBox1.Left + pictureBox1.Width > Me.Width Then
			
			pictureBox2.Left = pictureBox1.Left - Me.Width
			
		Else 
			
			pictureBox2.Left = Me.Width + pictureBox2.Left + 50
			
		End If
		
		
		If pictureBox1.Left = 0 - pictureBox1.Width Then
				pictureBox1.Left = pictureBox2.Left
				Else If pictureBox1.Left >= Me.Width Then
				pictureBox1.Left = pictureBox2.Left
				End If
				
		
				
		Select e.KeyCode
			Case Keys.A
				pictureBox1.Left -= 1
			Case Keys.D
				pictureBox1.Left += 1
			Case Keys.Space
				If timer1.Enabled = false Then
					timer1.Enabled = true
				End If
		End Select
		
	End Sub
	
	Dim p As Control
	Dim i As Integer = 3
	Dim movimentoy As Boolean = True
	Dim movimentox As Integer = 0 
	
	Sub Timer1Tick(sender As Object, e As EventArgs)
		
		For Each y As control In Me.controls
			If y.tag is "peca" And y.bounds.IntersectsWith(bola.Bounds) = True Then
				
				Select movimentox
					Case 1
						movimentox = 2
					Case 2
						movimentox = 1
				End Select
				
					If movimentoy = True Then
						 movimentoy = False
					Else 
						movimentoy = true
					End If
				
				y.Visible = False
				y.Dispose()
				End if
			Next
			
			pictureBox3.Left = (pictureBox1.Left + pictureBox1.Width \ 2) - (pictureBox3.Width \ 2) 
			
			If movimentoy = True And bola.Bounds.IntersectsWith(pictureBox1.Bounds) = False Then
			bola.Top += 1 
		Else
			If bola.Top <= 0 Then
				
				movimentoy = True	
				
			Else If bola.Bounds.IntersectsWith(pictureBox1.Bounds) = True Or bola.Bounds.IntersectsWith(pictureBox3.Bounds) = True Then
				
				If bola.Bounds.IntersectsWith(pictureBox3.Bounds) Then
					movimentox = 0
					
				Else
					If bola.Left >= pictureBox3.Left + pictureBox3.Width Then
						movimentox = 1
					Else
						movimentox = 2
					End If
					
				End If
				
				movimentoy = False
				bola.Top -= 1
				
			Else movimentoy = False  
				
				bola.Top -= 1
				
			End If
		End If
		
	If bola.Left = 0 Then
		movimentox = 1
	Else If bola.Left + bola.Width = Me.Width - bola.Width Then
		movimentox = 2
	End If
	
	Select movimentox
		Case 1
			
			bola.Left += 1
			
		Case 2
			
			bola.Left -= 1
			
	    Case 0
			
	End Select
			
	End Sub
End Class

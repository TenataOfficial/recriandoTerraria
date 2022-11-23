
Public Partial Class MainForm
'Aqui estão as variaveis	
	#Region "Variaveis"
	Private Tam_Tela(2) As Integer
	Private Tam_Blocos As Integer = 25
	Private Bloco As nossojogo.bloco  
	Private blocos As List(Of bloco) = New List(Of bloco)
	Private Bloco_Escolhido As String = "GRAMA"
	#End Region
	
	Public Sub New()
		
		Me.InitializeComponent()
	
	End Sub'Aqui inicia 
	
	Private Sub Desenhar_Grade()
		Dim g As Graphics = pictureBox1.CreateGraphics
		Dim caneta As pen = New Pen(Color.Black,1)
		For x As Integer = 0 To CInt(Me.Width/Tam_Blocos)
			g.DrawLine(caneta,x * Tam_Blocos, 0, x * Tam_Blocos, Me.Height)
		Next
		For y As Integer = 0 To CInt(Me.Height/Tam_Blocos)
			g.DrawLine(caneta, 0, y  * Tam_Blocos, Me.Width, y * Tam_Blocos)
		Next
	End Sub 'Desenha a Grade 
	
	Private Sub Desenhar_blocos()
		Dim g As Graphics = pictureBox1.CreateGraphics
		Dim Brush As Brush
		For Each c As bloco In blocos
			Brush = New SolidBrush(c.GetCor)
			Dim rf As RectangleF = New RectangleF(c.GetX * Tam_Blocos,c.GetY * Tam_Blocos,Tam_Blocos,Tam_Blocos)
			g.FillRectangle(Brush,rf)
			Brush.Dispose
		Next
	End Sub 'Desenha os Blocos
	
	Sub Timer1Tick(sender As Object, e As EventArgs)
		Desenhar_Grade
		Desenhar_blocos
	End Sub 'Timer que chama o desenho da grade e dos blocos
	
	Sub PictureBox1MouseClick(sender As Object, e As MouseEventArgs)
		Dim x As Integer = CInt((MousePosition.X - Me.Left)/Tam_Blocos)
		If x > (MousePosition.X - Me.Left)/Tam_Blocos Then
			x -= 1
		End If
		
		Dim y As Integer = CInt((MousePosition.y - Me.top)/Tam_Blocos)
		If y > (MousePosition.y - me.top)/Tam_Blocos Then
			y -= 1
		End If
		
		If e.Button = MouseButtons.Left Then
			
		blocos.Add(Bloco_C(x,y))
		Else If e.Button = MouseButtons.Right then
			If removebloco(x,y) = True Then
				blocos.Remove(Bloco)
				'MsgBox(blocos.Count)
			End If
		End If 
		
	End Sub'Pega a posição do mouse e verifica se foi adicionado ou decrementado um bloco
	
	Private function removebloco(x As Integer, y As Integer) As Boolean
		For Each c As bloco In blocos
			If c.GetX = x And c.GetY = y Then
				Try
					Bloco = c
				Catch e As Exception
					MsgBox(e)
				End Try
			End If
		Next
		Return (True)
	End Function'Aqui remove o bloco
	
	Sub Panel1MouseMove(sender As Object, e As MouseEventArgs)
		If Not e.Button = MouseButtons.Left Then
			Tam_Tela(1) = MousePosition.X - Me.Left
			Tam_Tela(2) = MousePosition.Y - Me.top
		Else
			Me.Location = New Point(MousePosition.X - Tam_Tela(1),MousePosition.Y - Tam_Tela(2))
		End If	
		
	End Sub'Aqui move o formulario
	
	Sub Timer2Tick(sender As Object, e As EventArgs)
		pictureBox1.Invalidate
	End Sub'Timer que apaga o picture box para atualizar o frame
	
	Sub Timer3Tick(sender As Object, e As EventArgs)
		Dim t As Integer = CInt((Me.Height)/Tam_Blocos)
		Dim lista As New List(Of Integer)
		For Each b As bloco In blocos
			lista.Clear
			If b.GetGravity = True Then
				For Each c As bloco In blocos
					If b.GetY <> t -1 And blocos.IndexOf(c) <> blocos.IndexOf(b) And b.GetX = c.Getx Then
						lista.Add(c.GetY)
					End If
				Next
				If not lista.Contains(b.GetY+1) And b.GetY < t - 1 Then
					b.sety(b.GetY + 1)
				End If
			End If
		Next
	End Sub
	
	Sub ToolStripTextBox2KeyPress(sender As Object, e As KeyPressEventArgs)
		If IsNumeric(e.KeyChar) Or e.KeyChar = vbBack Then
			e.Handled = False
		Else
			e.Handled = True
		End If
		If e.KeyChar = vbCr Then
			Me.Width = (CInt(toolStripTextBox2.Text))* Tam_Blocos
			Me.Height = (CInt((CInt(toolStripTextBox2.Text))/2))* Tam_Blocos
		End If
	End Sub
	
	Sub Button1Click(sender As Object, e As EventArgs)
		If statusStrip1.Visible = True Then
			statusStrip1.Visible = False
		Else
			statusStrip1.Visible = True
End If
	End Sub
	
	Sub ToolStripTextBox1KeyPress(sender As Object, e As KeyPressEventArgs)
		If IsNumeric(e.KeyChar) Or e.KeyChar = vbBack Then
			e.Handled = False
		Else
			e.Handled = True
		End If
		If e.KeyChar = vbCr Then
			Tam_Blocos = CInt(toolStripTextBox1.Text) 
		End If
	End Sub
	
	Sub MainFormLoad(sender As Object, e As EventArgs)
		Me.Width = (30 * Tam_Blocos)
		Me.Height = (15 * Tam_Blocos)
	End Sub
	
	Sub ToolStripComboBox1TextChanged(sender As Object, e As EventArgs)
		Bloco_Escolhido = toolStripComboBox1.Text
	End Sub
	
	Public Function Bloco_C(x As Integer, y As Integer) As bloco
		Dim BC As bloco 
		Select Case Bloco_Escolhido
		    Case "MADEIRA"
				BC =  New bloco("MADEIRA",1,Color.Brown,x,y,false)
		  Case "GRAMA"
		  	BC =  New bloco("GRAMA",2,Color.Green,x,y,True)
		  Case "TERRA"
		  	BC =  New bloco("TERRA",3,Color.FromArgb(128, 64, 0),x,y,False)
		  Case "AREIA"
		  	BC =  New bloco("AREIA",4,Color.Yellow,x,y,True)
		  Case "PEDRA"
		  	BC =  New bloco("PEDRA",5,Color.DarkGray,x,y,false)
		  		
		End Select
		Return BC
	End Function
	
	
End Class

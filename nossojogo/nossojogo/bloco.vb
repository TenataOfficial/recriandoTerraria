Public Class bloco
	Private Nome As String = ""
	Private Id As Integer = 0
	Private Cor As Color = Color.Transparent
	Private X As Integer = 0
	Private Y As Integer = 0
	Private Gravidade As Boolean 
	
	Sub New(ByVal _Nome As String, ByVal _Id As Integer, ByVal _Cor As Color, ByVal _X As Integer, Byval _Y As Integer, Byval _Gravidade As Boolean)
		Nome = _Nome
		Id = _Id
		Cor = _Cor
		X = _X
		Y = _Y
		Gravidade = _Gravidade
	End Sub
	
	Public ReadOnly Property GetNome() As String 
		Get
			Return Nome
		End Get
	End Property
	
	Public ReadOnly Property GeId() As Integer
		Get
			Return Id
		End Get
	End Property		
	
	Public ReadOnly Property GetCor() As Color
		Get
			Return Cor
		End Get
	End Property
	
	Public ReadOnly Property GetX() As Integer
		Get
			Return X
		End Get
	End Property
	Public ReadOnly Property GetY() As Integer
		Get
			Return Y
		End Get
	End Property
	Public ReadOnly Property GetGravity() As Boolean
		Get
			Return Gravidade
		End Get
	End Property
	
	Public Sub sety(_Y As Integer)
		Y = _Y
	End Sub
	
	Public Sub setx(_X As Integer)
		X = _X
	End Sub
	
End Class

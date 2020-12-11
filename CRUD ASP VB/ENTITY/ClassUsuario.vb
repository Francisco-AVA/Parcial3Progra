Public Class ClassUsuario

#Region "CAMPOS"
    Private _id As Integer
    Private _nombre As String
    Private _apellido As String
    Private _edad As Integer
    Private _telefono As Integer
#End Region

#Region "PROPIEDADES"
    Public Property id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Public Property nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Property apellido As String
        Get
            Return _apellido
        End Get
        Set(value As String)
            _apellido = value
        End Set
    End Property

    Public Property edad As Integer
        Get
            Return _edad
        End Get
        Set(value As Integer)
            _edad = value
        End Set
    End Property

    Public Property telefono As Integer
        Get
            Return _telefono
        End Get
        Set(value As Integer)
            _telefono = value
        End Set
    End Property
#End Region

    Public Sub New()
    End Sub

    Public Sub New(ByVal id As Integer, ByVal nombre As String, ByVal apellido As String, ByVal edad As Integer, ByVal telefono As Integer)
        _id = id
        _nombre = nombre
        _apellido = apellido
        _edad = edad
        _telefono = telefono
    End Sub

End Class

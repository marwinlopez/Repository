Public Class Cliente
    Private _id As Integer
    Private _codigo As String
    Private _nombre As String
    Private _saldo As Double

    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Public Property Codigo As String
        Get
            Return _codigo
        End Get
        Set(value As String)
            _codigo = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Property Saldo As Double
        Get
            Return _saldo
        End Get
        Set(value As Double)
            _saldo = value
        End Set
    End Property
End Class

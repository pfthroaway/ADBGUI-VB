Public Class CDevice
    Private _serial As String
    Private _connStatus As String
    Private _modelName As String
    Private _modelNum As String
    Private _manuName As String
    Private _splashBlock As String
    Private _res As String

    Public Property serial As String
        Get
            Return _serial
        End Get
        Set(value As String)
            _serial = value
        End Set
    End Property

    Public Property connStatus As String
        Get
            Return _connStatus
        End Get
        Set(value As String)
            _connStatus = value
        End Set
    End Property

    Public Property modelName As String
        Get
            Return _modelName
        End Get
        Set(value As String)
            _modelName = value
        End Set
    End Property

    Public Property modelNum As String
        Get
            Return _modelNum
        End Get
        Set(value As String)
            _modelNum = value
        End Set
    End Property

    Public Property manuName As String
        Get
            Return _manuName
        End Get
        Set(value As String)
            _manuName = value
        End Set
    End Property

    Public Property res As String
        Get
            Return _res
        End Get
        Set(value As String)
            _res = value
        End Set
    End Property

    Public Property splashBlock As String
        Get
            Return _splashBlock
        End Get
        Set(value As String)
            _splashBlock = value
        End Set
    End Property

    Public Sub New()
        _serial = ""
        _connStatus = ""
        _modelName = ""
        _modelNum = ""
        _manuName = ""
        _splashBlock = ""
        _res = ""
    End Sub

    Public Sub New(ByVal ser As String, ByVal con As String)
        _serial = ser
        _connStatus = con
    End Sub
End Class

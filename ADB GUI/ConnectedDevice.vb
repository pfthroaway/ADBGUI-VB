Public Class ConnectedDevice
    Private _serial As String
    Private _connectionStatus As String
    Private _modelName As String
    Private _modelNumber As String
    Private _manufacturerName As String
    Private _splashBlock As String
    Private _resolution As String
    Private _canFlashRecovery As Boolean
    Private _hasRoot As Boolean
    Private _image As Image

    Public Property serial As String
        Get
            Return _serial
        End Get
        Set(value As String)
            _serial = value
        End Set
    End Property

    Public Property connectionStatus As String
        Get
            Return _connectionStatus
        End Get
        Set(value As String)
            _connectionStatus = value
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

    Public Property modelNumber As String
        Get
            Return _modelNumber
        End Get
        Set(value As String)
            _modelNumber = value
        End Set
    End Property

    Public Property manufacturerName As String
        Get
            Return _manufacturerName
        End Get
        Set(value As String)
            _manufacturerName = value
        End Set
    End Property

    Public Property res As String
        Get
            Return _resolution
        End Get
        Set(value As String)
            _resolution = value
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

    Public Property hasRoot As Boolean
        Get
            Return _hasRoot
        End Get
        Set(value As Boolean)
            _hasRoot = value
        End Set
    End Property
    Public Property canFlashRecovery As Boolean
        Get
            Return _canFlashRecovery
        End Get
        Set(value As Boolean)
            _canFlashRecovery = value
        End Set
    End Property


    Public Property image As Image
        Get
            Return _image
        End Get
        Set(value As Image)
            _image = value
        End Set
    End Property


    Public Sub New()
        _serial = ""
        _connectionStatus = ""
        _modelName = ""
        _modelNumber = ""
        _manufacturerName = ""
        _splashBlock = ""
        _resolution = ""
        _resolution = ""
        _canFlashRecovery = False
        _hasRoot = False
        _image = My.Resources.clear
    End Sub

    ''' <summary>
    ''' This method creates a new instance of the ConnectedDevice class with two parameters.
    ''' </summary>
    ''' <param name="ser">Serial Number</param>
    ''' <param name="con">Connection Status</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal ser As String, ByVal con As String)
        _serial = ser
        _connectionStatus = con
    End Sub

    ''' <summary>
    ''' This method creates a new instance of the ConnectedDevice class with all parameters filled.
    ''' </summary>
    ''' <param name="ser">Serial Number</param>
    ''' <param name="con">Connection Status</param>
    ''' <param name="modName">Model Name</param>
    ''' <param name="modNum">Model Number</param>
    ''' <param name="manName">Manufacturer Name</param>
    ''' <param name="splBlock">Splash Block</param>
    ''' <param name="res">Resolution</param>
    ''' <param name="root">Root Status</param>
    ''' <param name="canFlash">Can Flash Recovery</param>
    ''' <param name="img">Image</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal ser As String, ByVal con As String, ByVal modName As String, ByVal modNum As String, ByVal manName As String, _
                   ByVal splBlock As String, ByVal res As String, ByVal root As Boolean, ByVal canFlash As Boolean, ByVal img As Image)
        _serial = ser
        _connectionStatus = con
        _modelName = modName
        _modelNumber = modNum
        _manufacturerName = manName
        _splashBlock = splBlock
        _resolution = res
        _canFlashRecovery = canFlash
        _hasRoot = root
        _image = img
    End Sub

    ''' <summary>
    ''' This method determines if the current device is currently connected.
    ''' </summary>
    ''' <returns>This method determines if the current device is currently connected.</returns>
    ''' <remarks></remarks>
    Public Function isConnected() As Boolean
        Return frmMain.android.IsDeviceConnected(_serial)
    End Function
End Class

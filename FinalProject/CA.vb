Public Class CA
    Dim mName As String
    Dim mRevPerHour As Double
    Dim mNPS As Integer
    Dim mID As Integer
    Dim mExperience As Double
    Dim mType As String

    Dim adapter As New EmployeeDataSetTableAdapters.EmployeesTableAdapter


    Public Sub New(ByVal pId As Integer, ByVal pname As String, ByVal pType As String, ByVal pnps As Integer, ByVal pRevPerhour As Double, Optional ByVal pExperience As Double = 0)
        mID = pId
        mName = pname
        mRevPerHour = pRevPerhour
        mNPS = pnps
        mExperience = pExperience
        mType = pType

    End Sub
    Public Property Type As String
        Get
            Return mType

        End Get
        Set(value As String)
            value = mType

        End Set

    End Property


    Public Property Experience As Double
        Get
            Return mExperience

        End Get
        Set(value As Double)
            value = mExperience

        End Set
    End Property


    Public ReadOnly Property Name As String
        Get
            Return mName
        End Get

    End Property
    Public ReadOnly Property Id As String
        Get
            Return mID
        End Get

    End Property
    Public ReadOnly Property NPS As String
        Get
            Return mNPS
        End Get

    End Property
    Public ReadOnly Property RPH As String
        Get
            Return mRevPerHour
        End Get

    End Property

    Public Overrides Function ToString() As String

        Return "My Name is " & mName


    End Function


    Public Function Update(ByVal pId As Integer, ByVal pName As String, ByVal pType As String, ByVal PNPS As Integer, ByVal pRevPerhour As Double, Optional ByVal pExperience As Double = 0) As Boolean
        Try
            adapter.Update(pName, pType, PNPS, pRevPerhour, pId)


            Return True
        Catch ex As Exception
            'LastError = ex.Message
            Return False

        End Try

    End Function
End Class

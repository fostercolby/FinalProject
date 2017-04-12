Public Class ARA

    Dim mName As String
    Dim mTagsperHour As Double
    Dim mNPS As Integer
    Dim mID As Integer
    Dim mExperience As Double
    Dim adapter As New EmployeeDataSetTableAdapters.EmployeesTableAdapter


    Public Sub New(ByVal pId As Integer, ByVal pname As String, ByVal pnps As Integer, ByVal ptagsperhour As Double, Optional ByVal pExperience As Double = 0)
        mID = pId
        mName = pname
        mTagsperHour = ptagsperhour
        mNPS = pnps
        mExperience = pExperience
    End Sub

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
    Public ReadOnly Property TPH As String
        Get
            Return mTagsperHour
        End Get

    End Property
    Public Property Experience As Double
        Get
            Return mExperience

        End Get
        Set(value As Double)
            value = mExperience

        End Set


    End Property

    Public Overrides Function ToString() As String

        Return "My Name is " & mName


    End Function

    'Public Function Insert(ByVal name As String, ByVal Type As String, ByVal NPS As Integer, ByVal metric2 As Double) As Boolean
    '    Try
    '        adapter.Insert(name, Type, NPS, metric2)
    '        Return True
    '    Catch ex As Exception

    '        Return False
    '    End Try
    'End Function


End Class

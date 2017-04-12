﻿Public Class CA
    Dim mName As String
    Dim mRevPerHour As Double
    Dim mNPS As Integer
    Dim mID As Integer

    Dim adapter As New EmployeeDataSetTableAdapters.EmployeesTableAdapter


    Public Sub New(ByVal pId As Integer, ByVal pname As String, ByVal pnps As Integer, ByVal pRevPerhour As Double)
        mID = pId
        mName = pname
        mRevPerHour = pRevPerhour
        mNPS = pnps

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
    Public ReadOnly Property RPH As String
        Get
            Return mRevPerHour
        End Get

    End Property

    Public Overrides Function ToString() As String

        Return "My Name is " & mName


    End Function
End Class

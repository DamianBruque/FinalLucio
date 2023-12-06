Imports System.Data
Imports Models
Imports Persistence

Public Class UserService
    Dim database As UserDataAccess
    Public Sub New()
        database = New UserDataAccess
    End Sub
    Public Function GetAll() As List(Of User)
        Return database.GetAll()
    End Function
End Class

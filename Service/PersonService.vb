Imports Models
Imports Persistence

Public Class PersonService
    Dim database As PersonDataAccess
    Public Sub New()
        database = New PersonDataAccess
    End Sub
    Public Function GetAll() As List(Of Person)
        Return database.GetAll()
    End Function
End Class

Imports Models
Imports Persistence

Public Class PostService
    Dim database As PostDataAccess
    Public Sub New()
        database = New PostDataAccess
    End Sub
    Public Function GetAll() As List(Of Post)
        Return database.GetAll()
    End Function
End Class

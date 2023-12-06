Imports Models

Public Class PostDataAccess
    Public Function GetAll() As List(Of Post)
        Return ProjectContext.Instance.Posts.ToList()
    End Function
End Class

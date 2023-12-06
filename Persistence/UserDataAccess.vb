Imports System.Data
Imports Microsoft.EntityFrameworkCore
Imports Models

Public Class UserDataAccess
    Public Function GetAll() As List(Of User)
        Return ProjectContext.Instance.Users.ToList()
    End Function
End Class

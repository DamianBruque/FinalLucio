Imports System.Data
Imports Microsoft.EntityFrameworkCore
Imports Models

Public Class UserDataAccess
    Public Function GetAll() As List(Of User)
        Return ProjectContext.Instance.Users.ToList()
    End Function

    Public Function Register(user As User) As User
        ProjectContext.Instance.Users.Add(user)
        ProjectContext.Instance.SaveChanges()
        Return GetByEmailAddress(user.Email)
    End Function

    Public Function GetByEmailAddress(email As String) As User
        Return ProjectContext.Instance.Users.Where(Function(u) u.Email = email).FirstOrDefault()
    End Function
End Class

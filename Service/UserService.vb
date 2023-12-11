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

    Public Function Register(user As User) As User
        Dim returnUser As User
        Try
            user.Password = HashPassword(user.Password)
            returnUser = database.Register(user)
        Catch ex As Exception
            Throw New Exception("Error al registrar usuario:\n" & ex.Message)
        End Try
        Return returnUser
    End Function

    Public Function HashPassword(password As String) As String
        Return BCrypt.Net.BCrypt.HashPassword(password)
    End Function

    Public Function CheckPassword(password As String, hashedPassword As String) As Boolean
        Return BCrypt.Net.BCrypt.Verify(password, hashedPassword)
    End Function

    Public Function Login(user As User) As User
        Dim returnUser As User
        Try
            returnUser = database.GetByEmailAddress(user.Email)
            If Not CheckPassword(user.Password, returnUser.Password) Then
                Throw New Exception("Contraseña incorrecta")
            ElseIf Not returnUser.State Then
                Throw New Exception("Usuario deshabilitado")
            Else
                returnUser.Password = ""
            End If
        Catch ex As Exception
            Throw New Exception("Error al iniciar sesión:\n" & ex.Message)
        End Try
        Return returnUser
    End Function
End Class

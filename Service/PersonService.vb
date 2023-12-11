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

    Public Function Register(person As Person) As Person
        Dim returnPerson As Person

        Try
            returnPerson = database.Register(person)
        Catch ex As Exception
            Throw New Exception("Error al crear perfil:\n" & ex.Message)
        End Try
        Return returnPerson
    End Function

End Class

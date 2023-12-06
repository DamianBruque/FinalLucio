Imports Models

Public Class PersonDataAccess
    Public Function GetAll() As List(Of Person)
        Return ProjectContext.Instance.Persons.ToList()
    End Function
End Class

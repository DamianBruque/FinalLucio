Imports Models

Public Class PersonDataAccess
    Public Function GetAll() As List(Of Person)
        Return ProjectContext.Instance.Persons.ToList()
    End Function
    Public Function Register(person As Person) As Person
        ProjectContext.Instance.Persons.Add(person)
        ProjectContext.Instance.SaveChanges()
        Return GetByUserId(person.UserID)
    End Function
    Public Function GetByUserId(userId As Integer) As Person
        Return ProjectContext.Instance.Persons.Where(Function(p) p.UserID = userId).FirstOrDefault()
    End Function
End Class

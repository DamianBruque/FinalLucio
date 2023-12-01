Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Public Class User
    <Key>
    <DatabaseGenerated(DatabaseGeneratedOption.Identity)>
    Public Property UserId As Integer
    Public Property Email As String
    Public Property Password As String
    Public Property State As Boolean

End Class

Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Public Class Post
    <Key>
    <DatabaseGenerated(DatabaseGeneratedOption.Identity)>
    Public Property PostId As Integer
    Public Property PersonId As Integer
    <ForeignKey("PersonId")>
    Public Property Person As Person
    Public Property Title As String
    Public Property Content As String
    Public Property Image As String
    Public Property DatePost As Date
End Class

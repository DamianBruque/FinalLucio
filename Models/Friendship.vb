Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Public Class Friendship
    <Key>
    <DatabaseGenerated(DatabaseGeneratedOption.Identity)>
    Public Property FriendshipId As Integer

    Public Property Person1Id As Integer
    <ForeignKey("PersonId")>
    Public Property Person1 As Person

    Public Property Person2Id As Integer
    <ForeignKey("Person2Id")>
    Public Property Person2 As Person

End Class

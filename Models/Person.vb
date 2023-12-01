Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Public Class Person

    <Key>
    <DatabaseGenerated(DatabaseGeneratedOption.Identity)>
    Public Property PersonId As Integer
    Public Property UserID As Integer
    <ForeignKey("UserID")>
    Public Property User As User
    Public Property FullName As String
    Public Property BirthDate As Date
    Public Property Adress As String
    Public Property Phone As String
    Public Property AvatarImage As String
    Public Property State As Boolean
    ' Friendships
    Public Overridable Property Friends As ICollection(Of Friendship)
    Public Overridable Property FriendOf As ICollection(Of Friendship)
    ' Posts
    Public Overridable Property Posts As ICollection(Of Post)

End Class

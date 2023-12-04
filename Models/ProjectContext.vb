Imports System.Reflection
Imports Microsoft.EntityFrameworkCore

Public Class ProjectContext
    Inherits DbContext

    Private ConnectionString As String

    Public Sub New()
        ConnectionString = Environment.GetEnvironmentVariable("ConnectionString")
        Database.EnsureCreated() ' Crea la base de datos si no existe
        SaveChanges()
    End Sub

    Protected Overrides Sub OnConfiguring(optionsBuilder As DbContextOptionsBuilder)
        optionsBuilder.UseSqlServer(
            ConnectionString,
            Function(op)
                op.MigrationsAssembly(Assembly.GetExecutingAssembly().FullName)
                'op.MigrationsHistoryTable("Migrations")

            End Function
        )

        MyBase.OnConfiguring(optionsBuilder)
    End Sub

    Protected Overrides Sub OnModelCreating(modelBuilder As ModelBuilder)
        modelBuilder.Entity(Of User)(
            Function(ent)
                ent.ToTable("User")
                ent.HasKey(Function(e) e.UserId)
                ent.HasIndex(Function(e) e.Email).IsUnique()

            End Function
            )

        modelBuilder.Entity(Of Person)(
            Function(ent)
                ent.ToTable("Person")
                ent.HasKey(Function(e) e.PersonId)
                ent.HasIndex(Function(e) e.UserID).IsUnique()
            End Function
            )

        modelBuilder.Entity(Of Friendship)(
            Function(ent)
                ent.ToTable("Friendship")
                ent.HasKey(Function(e) e.FriendshipId)
                ent.HasOne(Function(e) e.Person1).WithMany(Function(e) e.Friends).HasForeignKey(Function(e) e.Person1Id).OnDelete(DeleteBehavior.NoAction)
                ent.HasOne(Function(p) p.Person2).WithMany(Function(b) b.FriendOf).HasForeignKey(Function(p) p.Person2Id).OnDelete(DeleteBehavior.NoAction)
            End Function
            )

        modelBuilder.Entity(Of Post)(
            Function(ent)
                ent.ToTable("Post")
                ent.HasKey(Function(e) e.PostId)
                ent.HasOne(Function(e) e.Person).WithMany(Function(e) e.Posts).HasForeignKey(Function(e) e.PersonId)
            End Function
            )

        MyBase.OnModelCreating(modelBuilder)
    End Sub

    Public Property Users As DbSet(Of User)
    Public Property Persons As DbSet(Of Person)
    Public Property Friendships As DbSet(Of Friendship)
    Public Property Posts As DbSet(Of Post)


End Class

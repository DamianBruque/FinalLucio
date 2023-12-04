Imports Models

Public Class LoginForm

    ' TODO: inserte el código para realizar autenticación personalizada usando el nombre de usuario y la contraseña proporcionada 
    ' (Consulte https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' El objeto principal personalizado se puede adjuntar al objeto principal del subproceso actual como se indica a continuación: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' donde CustomPrincipal es la implementación de IPrincipal utilizada para realizar la autenticación. 
    ' Posteriormente, My.User devolverá la información de identidad encapsulada en el objeto CustomPrincipal
    ' como el nombre de usuario, nombre para mostrar, etc.
    Private startForm As StartForm
    Public Sub SetStartForm(form As StartForm)
        startForm = form
    End Sub
    Private Sub OK_Click(sender As Object, e As EventArgs) Handles OK.Click
        ' validamos campos

        ' consultamos a base de datos

        ' en caso correcto pedimos el usuario

        ' enviamos el usuario al principal
        'startForm.SetUser(New User())
        Me.Close()
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LoginForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed

        startForm.MenuStrip1.Enabled = True
    End Sub
End Class

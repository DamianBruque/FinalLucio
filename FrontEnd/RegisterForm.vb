Imports Models

Public Class RegisterForm

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
        Dim user As User
        ' validamos campos

        ' enviamos a la base de datos

        ' enviamos el usuario en caso de crearlo exitosamente
        startForm.SetUser(user)
        Close()
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Close()
    End Sub

End Class

Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class AdminLogin

    ' TODO: inserte el código para realizar autenticación personalizada usando el nombre de usuario y la contraseña proporcionada 
    ' (Consulte https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' El objeto principal personalizado se puede adjuntar al objeto principal del subproceso actual como se indica a continuación: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' donde CustomPrincipal es la implementación de IPrincipal utilizada para realizar la autenticación. 
    ' Posteriormente, My.User devolverá la información de identidad encapsulada en el objeto CustomPrincipal
    ' como el nombre de usuario, nombre para mostrar, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click

        Me.Close()
        AdminPanel.Show()

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PasswordTextBox.PasswordChar = IIf(PasswordTextBox.PasswordChar <> "#", "#", "")
        'MsgBox("Password: " & PasswordTextBox.PasswordChar)
        Button1.BackgroundImage = IIf(PasswordTextBox.PasswordChar <> "#", My.Resources.tile001, My.Resources.tile000)
    End Sub

    Private Sub Button1_MouseMove(sender As Object, e As MouseEventArgs) Handles Button1.MouseMove
        ToolTip1.SetToolTip(Button1, IIf(PasswordTextBox.PasswordChar <> "#", "Ocultar contraseña", "Mostrar contraseña"))
    End Sub
End Class

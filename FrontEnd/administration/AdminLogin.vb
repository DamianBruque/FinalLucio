Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class AdminLogin

    ' TODO: inserte el c�digo para realizar autenticaci�n personalizada usando el nombre de usuario y la contrase�a proporcionada 
    ' (Consulte https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' El objeto principal personalizado se puede adjuntar al objeto principal del subproceso actual como se indica a continuaci�n: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' donde CustomPrincipal es la implementaci�n de IPrincipal utilizada para realizar la autenticaci�n. 
    ' Posteriormente, My.User devolver� la informaci�n de identidad encapsulada en el objeto CustomPrincipal
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
        ToolTip1.SetToolTip(Button1, IIf(PasswordTextBox.PasswordChar <> "#", "Ocultar contrase�a", "Mostrar contrase�a"))
    End Sub
End Class

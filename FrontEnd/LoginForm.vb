Imports Models
Imports Service

Public Class LoginForm
    Private userService As New UserService
    Private personService As New PersonService
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
        userService = New UserService()
        personService = New PersonService()
    End Sub
    Private Sub OK_Click(sender As Object, e As EventArgs) Handles OK.Click
        ' validamos campos
        If (ValidEmail() And ValidPassword()) Then
            Dim user As New User()
            user.Email = UsernameTextBox.Text
            user.Password = PasswordTextBox.Text
            user.State = True
            Try
                user = userService.Login(user)
                startForm.SetUser(personService.GetByUserID(user.UserId))
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            Me.Close()
        Else
            MsgBox("Campos inválidos")
        End If
    End Sub

    Private Function ValidEmail() As Boolean
        Return UsernameTextBox.BackColor = Color.FromArgb(160, 255, 160)
    End Function

    Private Function ValidPassword() As Boolean
        Return PasswordTextBox.BackColor = Color.FromArgb(160, 255, 160)
    End Function

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LoginForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed

        startForm.MenuStrip1.Enabled = True
    End Sub

    Private Sub UsernameTextBox_TextChanged(sender As Object, e As EventArgs) Handles UsernameTextBox.TextChanged
        If UsernameTextBox.Text <> "" And New Text.RegularExpressions.Regex("^[\w._%-]+@[\w.-]+\.[a-zA-Z]{2,4}$").IsMatch(UsernameTextBox.Text) Then
            UsernameTextBox.BackColor = Color.FromArgb(160, 255, 160)
        Else
            UsernameTextBox.BackColor = Color.FromArgb(255, 160, 160)
        End If
    End Sub

    Private Sub PasswordTextBox_TextChanged(sender As Object, e As EventArgs) Handles PasswordTextBox.TextChanged
        If PasswordTextBox.Text <> "" And New Text.RegularExpressions.Regex("^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,15}$").IsMatch(PasswordTextBox.Text) Then
            PasswordTextBox.BackColor = Color.FromArgb(160, 255, 160)
        Else
            PasswordTextBox.BackColor = Color.FromArgb(255, 160, 160)
        End If
    End Sub

    Private Sub Button2_MouseMove(sender As Object, e As MouseEventArgs) Handles Button2.MouseMove
        ActiveToolTip(sender, PasswordTextBox)
    End Sub

    Private Sub ActiveToolTip(sender As Object, passBox As TextBox)
        ToolTip1.SetToolTip(sender, IIf(passBox.PasswordChar <> "#", "Ocultar contraseña", "Mostrar contraseña"))
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        HideShowPassword(sender, PasswordTextBox)
    End Sub

    Private Sub HideShowPassword(sender As Object, passBox As TextBox)
        passBox.PasswordChar = IIf(passBox.PasswordChar <> "#", "#", "")
        sender.BackgroundImage = IIf(passBox.PasswordChar <> "#", My.Resources.tile001, My.Resources.tile000)
    End Sub
End Class

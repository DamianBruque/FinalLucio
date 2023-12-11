
Imports Models
Imports Service

Public Class RegisterForm
    Private personService As New PersonService
    Private userService As New UserService

    ' TODO: inserte el código para realizar autenticación personalizada usando el nombre de usuario y la contraseña proporcionada 
    ' (Consulte https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' El objeto principal personalizado se puede adjuntar al objeto principal del subproceso actual como se indica a continuación: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' donde CustomPrincipal es la implementación de IPrincipal utilizada para realizar la autenticación. 
    ' Posteriormente, My.User devolverá la información de identidad encapsulada en el objeto CustomPrincipal
    ' como el nombre de usuario, nombre para mostrar, etc.
    Private startForm As StartForm
    Private imagePath As String
    Public Sub SetStartForm(form As StartForm)
        startForm = form
    End Sub
    Private Sub OK_Click(sender As Object, e As EventArgs) Handles OK.Click
        'Dim user As User
        ' validamos campos
        Dim user As New User()
        Dim person As New Person()
        If (ValidName() And ValidEmail() And ValidPassword()) Then
            person.FullName = NameTextBox.Text
            user.Email = EmailTextBox1.Text
            user.Password = PasswordTextBox1.Text
            user.State = True
            person.AvatarImage = imagePath
            person.User = user
            person.Adress = AdressTextBox.Text
            person.BirthDate = MonthCalendar1.SelectionStart
            person.Phone = PhoneTextBox.Text
            person.State = True

            ' enviamos a la base de datos

            Try
                user = userService.Register(user)
                person.UserID = user.UserId
                person = personService.Register(person)
                person.User = user
                startForm.SetUser(person)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
        Close()
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Close()
    End Sub

    Private Sub RegisterForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        startForm.MenuStrip1.Enabled = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim fileDialog As New OpenFileDialog()
        fileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp"
        If fileDialog.ShowDialog() = DialogResult.OK Then
            imagePath = fileDialog.FileName
            PictureBox1.Image = Image.FromFile(imagePath)
        End If
    End Sub

    Private Sub RegisterForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ErrorProviderEmail1.SetError(EmailTextBox1, "Campo obligatorio")
        ErrorProviderEmail2.SetError(EmailTextBox2, "Campo obligatorio")
        ErrorProviderPass1.SetError(PasswordTextBox1, "Campo obligatorio")
        ErrorProviderPass2.SetError(PasswordTextBox2, "Campo obligatorio")
        ErrorProviderName.SetError(NameTextBox, "Campo obligatorio")

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        HideShowPassword(sender, PasswordTextBox1)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        HideShowPassword(sender, PasswordTextBox2)
    End Sub
    Private Sub HideShowPassword(sender As Object, passBox As TextBox)
        passBox.PasswordChar = IIf(passBox.PasswordChar <> "#", "#", "")
        sender.BackgroundImage = IIf(passBox.PasswordChar <> "#", My.Resources.tile001, My.Resources.tile000)
    End Sub
    Private Sub Button2_MouseMove(sender As Object, e As MouseEventArgs) Handles Button2.MouseMove
        ActiveToolTip(sender, PasswordTextBox1)
    End Sub
    Private Sub Button3_MouseMove(sender As Object, e As MouseEventArgs) Handles Button3.MouseMove
        ActiveToolTip(sender, PasswordTextBox2)
    End Sub
    Private Sub ActiveToolTip(sender As Object, passBox As TextBox)
        ToolTip1.SetToolTip(sender, IIf(passBox.PasswordChar <> "#", "Ocultar contraseña", "Mostrar contraseña"))
    End Sub


    Private Sub NameTextBox_TextChanged(sender As Object, e As EventArgs) Handles NameTextBox.TextChanged
        If (ValidName()) Then
            ErrorProviderName.Clear()
        Else
            ErrorProviderName.SetError(NameTextBox, "Campo obligatorio")
        End If
    End Sub

    Private Function ValidName() As Boolean
        Return NameTextBox.Text <> "" And NameTextBox.Text.Length > 3 And NameTextBox.Text.Length < 50 And New Text.RegularExpressions.Regex("^[a-zA-Z ]*$").IsMatch(NameTextBox.Text)
    End Function

    Private Sub EmailTextBox1_TextChanged(sender As Object, e As EventArgs) Handles EmailTextBox1.TextChanged
        If (ValidEmail()) Then
            ErrorProviderEmail1.Clear()
        Else
            ErrorProviderEmail1.SetError(EmailTextBox1, "Campo obligatorio")
        End If
    End Sub

    Private Function ValidEmail() As Boolean
        Return EmailTextBox1.Text <> "" And New Text.RegularExpressions.Regex("^[\w._%-]+@[\w.-]+\.[a-zA-Z]{2,4}$").IsMatch(EmailTextBox1.Text) And EmailTextBox1.Text = EmailTextBox2.Text
    End Function

    Private Sub EmailTextBox2_TextChanged(sender As Object, e As EventArgs) Handles EmailTextBox2.TextChanged
        If (EmailTextBox1.Text = EmailTextBox2.Text) Then
            ErrorProviderEmail2.Clear()
        Else
            ToolTip1.SetToolTip(EmailTextBox2, "Los correos no coinciden")
        End If
    End Sub

    Private Sub PasswordTextBox1_TextChanged(sender As Object, e As EventArgs) Handles PasswordTextBox1.TextChanged
        If (ValidPassword()) Then
            ErrorProviderPass1.Clear()
        Else
            ErrorProviderPass1.SetError(PasswordTextBox1, "Campo obligatorio")
        End If
    End Sub

    Private Function ValidPassword() As Boolean
        Return PasswordTextBox1.Text <> "" And New Text.RegularExpressions.Regex("^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,15}$").IsMatch(PasswordTextBox1.Text) And PasswordTextBox1.Text = PasswordTextBox2.Text
    End Function

    Private Sub PasswordTextBox2_TextChanged(sender As Object, e As EventArgs) Handles PasswordTextBox2.TextChanged
        If (PasswordTextBox1.Text = PasswordTextBox2.Text) Then
            ErrorProviderPass2.Clear()
        Else
            ToolTip1.SetToolTip(PasswordTextBox2, "Las contraseñas no coinciden")
        End If
    End Sub
End Class

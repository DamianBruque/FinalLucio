
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
    Private imagePath As String
    Public Sub SetStartForm(form As StartForm)
        startForm = form
    End Sub
    Private Sub OK_Click(sender As Object, e As EventArgs) Handles OK.Click
        'Dim user As User
        ' validamos campos

        ' enviamos a la base de datos

        ' enviamos el usuario en caso de crearlo exitosamente
        'startForm.SetUser(user)
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
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class RegisterForm
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        NameTextBox = New TextBox()
        MonthCalendar1 = New MonthCalendar()
        Label6 = New Label()
        PasswordTextBox2 = New TextBox()
        Label5 = New Label()
        PasswordTextBox1 = New TextBox()
        Label4 = New Label()
        EmailTextBox2 = New TextBox()
        Label3 = New Label()
        EmailTextBox1 = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        Button1 = New Button()
        Cancel = New Button()
        PictureBox1 = New PictureBox()
        OK = New Button()
        PhoneTextBox = New TextBox()
        Label7 = New Label()
        AdressTextBox = New TextBox()
        Label8 = New Label()
        Button2 = New Button()
        Button3 = New Button()
        ErrorProviderPass2 = New ErrorProvider(components)
        ErrorProviderPass1 = New ErrorProvider(components)
        ErrorProviderName = New ErrorProvider(components)
        ErrorProviderEmail1 = New ErrorProvider(components)
        ErrorProviderEmail2 = New ErrorProvider(components)
        ToolTip1 = New ToolTip(components)
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProviderPass2, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProviderPass1, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProviderName, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProviderEmail1, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProviderEmail2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' NameTextBox
        ' 
        NameTextBox.Location = New Point(289, 38)
        NameTextBox.Name = "NameTextBox"
        NameTextBox.Size = New Size(220, 23)
        NameTextBox.TabIndex = 29
        ' 
        ' MonthCalendar1
        ' 
        MonthCalendar1.Location = New Point(289, 306)
        MonthCalendar1.Name = "MonthCalendar1"
        MonthCalendar1.TabIndex = 39
        ' 
        ' Label6
        ' 
        Label6.Location = New Point(289, 274)
        Label6.Name = "Label6"
        Label6.Size = New Size(220, 23)
        Label6.TabIndex = 38
        Label6.Text = "Fecha de nacimiento:"
        Label6.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' PasswordTextBox2
        ' 
        PasswordTextBox2.Location = New Point(289, 246)
        PasswordTextBox2.Name = "PasswordTextBox2"
        PasswordTextBox2.PasswordChar = "#"c
        PasswordTextBox2.Size = New Size(220, 23)
        PasswordTextBox2.TabIndex = 37
        ' 
        ' Label5
        ' 
        Label5.Location = New Point(289, 220)
        Label5.Name = "Label5"
        Label5.Size = New Size(220, 23)
        Label5.TabIndex = 36
        Label5.Text = "Repetir Contraseña:"
        Label5.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' PasswordTextBox1
        ' 
        PasswordTextBox1.Location = New Point(289, 194)
        PasswordTextBox1.Name = "PasswordTextBox1"
        PasswordTextBox1.PasswordChar = "#"c
        PasswordTextBox1.Size = New Size(220, 23)
        PasswordTextBox1.TabIndex = 35
        ' 
        ' Label4
        ' 
        Label4.Location = New Point(289, 168)
        Label4.Name = "Label4"
        Label4.Size = New Size(220, 23)
        Label4.TabIndex = 34
        Label4.Text = "Contraseña:"
        Label4.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' EmailTextBox2
        ' 
        EmailTextBox2.Location = New Point(289, 142)
        EmailTextBox2.Name = "EmailTextBox2"
        EmailTextBox2.Size = New Size(220, 23)
        EmailTextBox2.TabIndex = 33
        ' 
        ' Label3
        ' 
        Label3.Location = New Point(289, 116)
        Label3.Name = "Label3"
        Label3.Size = New Size(220, 23)
        Label3.TabIndex = 32
        Label3.Text = "Repetir e-mail:"
        Label3.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' EmailTextBox1
        ' 
        EmailTextBox1.Location = New Point(289, 90)
        EmailTextBox1.Name = "EmailTextBox1"
        EmailTextBox1.Size = New Size(220, 23)
        EmailTextBox1.TabIndex = 31
        ' 
        ' Label2
        ' 
        Label2.Location = New Point(289, 64)
        Label2.Name = "Label2"
        Label2.Size = New Size(220, 23)
        Label2.TabIndex = 30
        Label2.Text = "E-mail:"
        Label2.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label1
        ' 
        Label1.Location = New Point(289, 12)
        Label1.Name = "Label1"
        Label1.Size = New Size(220, 23)
        Label1.TabIndex = 28
        Label1.Text = "Nombre Completo:"
        Label1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Button1
        ' 
        Button1.DialogResult = DialogResult.Cancel
        Button1.Location = New Point(12, 274)
        Button1.Name = "Button1"
        Button1.Size = New Size(256, 23)
        Button1.TabIndex = 27
        Button1.Text = "Seleccionar imagen"
        ' 
        ' Cancel
        ' 
        Cancel.DialogResult = DialogResult.Cancel
        Cancel.Location = New Point(112, 433)
        Cancel.Name = "Cancel"
        Cancel.Size = New Size(94, 23)
        Cancel.TabIndex = 25
        Cancel.Text = "&Cancelar"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(12, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(256, 256)
        PictureBox1.TabIndex = 26
        PictureBox1.TabStop = False
        ' 
        ' OK
        ' 
        OK.Location = New Point(12, 433)
        OK.Name = "OK"
        OK.Size = New Size(94, 23)
        OK.TabIndex = 24
        OK.Text = "&Registrarme"
        ' 
        ' PhoneTextBox
        ' 
        PhoneTextBox.Location = New Point(12, 384)
        PhoneTextBox.Name = "PhoneTextBox"
        PhoneTextBox.Size = New Size(220, 23)
        PhoneTextBox.TabIndex = 43
        ' 
        ' Label7
        ' 
        Label7.Location = New Point(12, 358)
        Label7.Name = "Label7"
        Label7.Size = New Size(220, 23)
        Label7.TabIndex = 42
        Label7.Text = "Teléfono:"
        Label7.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' AdressTextBox
        ' 
        AdressTextBox.Location = New Point(12, 332)
        AdressTextBox.Name = "AdressTextBox"
        AdressTextBox.Size = New Size(220, 23)
        AdressTextBox.TabIndex = 41
        ' 
        ' Label8
        ' 
        Label8.Location = New Point(12, 306)
        Label8.Name = "Label8"
        Label8.Size = New Size(220, 23)
        Label8.TabIndex = 40
        Label8.Text = "Domicilio:"
        Label8.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Button2
        ' 
        Button2.BackgroundImage = My.Resources.Resources.tile000
        Button2.BackgroundImageLayout = ImageLayout.Stretch
        Button2.Location = New Point(543, 194)
        Button2.Name = "Button2"
        Button2.Size = New Size(23, 23)
        Button2.TabIndex = 44
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.BackgroundImage = My.Resources.Resources.tile000
        Button3.BackgroundImageLayout = ImageLayout.Stretch
        Button3.Location = New Point(543, 246)
        Button3.Name = "Button3"
        Button3.Size = New Size(23, 23)
        Button3.TabIndex = 45
        Button3.UseVisualStyleBackColor = True
        ' 
        ' ErrorProviderPass2
        ' 
        ErrorProviderPass2.BlinkStyle = ErrorBlinkStyle.NeverBlink
        ErrorProviderPass2.ContainerControl = Me
        ' 
        ' ErrorProviderPass1
        ' 
        ErrorProviderPass1.BlinkStyle = ErrorBlinkStyle.NeverBlink
        ErrorProviderPass1.ContainerControl = Me
        ' 
        ' ErrorProviderName
        ' 
        ErrorProviderName.BlinkStyle = ErrorBlinkStyle.NeverBlink
        ErrorProviderName.ContainerControl = Me
        ' 
        ' ErrorProviderEmail1
        ' 
        ErrorProviderEmail1.BlinkStyle = ErrorBlinkStyle.NeverBlink
        ErrorProviderEmail1.ContainerControl = Me
        ' 
        ' ErrorProviderEmail2
        ' 
        ErrorProviderEmail2.BlinkStyle = ErrorBlinkStyle.NeverBlink
        ErrorProviderEmail2.ContainerControl = Me
        ' 
        ' RegisterForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        ClientSize = New Size(595, 392)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(PhoneTextBox)
        Controls.Add(Label7)
        Controls.Add(AdressTextBox)
        Controls.Add(Label8)
        Controls.Add(MonthCalendar1)
        Controls.Add(Label6)
        Controls.Add(PasswordTextBox2)
        Controls.Add(Label5)
        Controls.Add(PasswordTextBox1)
        Controls.Add(Label4)
        Controls.Add(EmailTextBox2)
        Controls.Add(Label3)
        Controls.Add(EmailTextBox1)
        Controls.Add(Label2)
        Controls.Add(NameTextBox)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Controls.Add(Cancel)
        Controls.Add(PictureBox1)
        Controls.Add(OK)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        MinimizeBox = False
        Name = "RegisterForm"
        SizeGripStyle = SizeGripStyle.Hide
        StartPosition = FormStartPosition.CenterParent
        Text = "Formulario de Registro"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProviderPass2, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProviderPass1, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProviderName, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProviderEmail1, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProviderEmail2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents Label6 As Label
    Friend WithEvents PasswordTextBox2 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents PasswordTextBox1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents EmailTextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents EmailTextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Cancel As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents OK As Button
    Friend WithEvents PhoneTextBox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents AdressTextBox As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ErrorProviderPass2 As ErrorProvider
    Friend WithEvents ErrorProviderPass1 As ErrorProvider
    Friend WithEvents ErrorProviderName As ErrorProvider
    Friend WithEvents ErrorProviderEmail1 As ErrorProvider
    Friend WithEvents ErrorProviderEmail2 As ErrorProvider
    Friend WithEvents ToolTip1 As ToolTip

End Class

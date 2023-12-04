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
    Friend WithEvents OK As System.Windows.Forms.Button
    Friend WithEvents Cancel As System.Windows.Forms.Button

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        OK = New Button()
        Cancel = New Button()
        SuspendLayout()
        ' 
        ' OK
        ' 
        OK.Location = New Point(197, 361)
        OK.Name = "OK"
        OK.Size = New Size(94, 23)
        OK.TabIndex = 4
        OK.Text = "&Registrarme"
        ' 
        ' Cancel
        ' 
        Cancel.DialogResult = DialogResult.Cancel
        Cancel.Location = New Point(300, 361)
        Cancel.Name = "Cancel"
        Cancel.Size = New Size(94, 23)
        Cancel.TabIndex = 5
        Cancel.Text = "&Cancelar"
        ' 
        ' RegisterForm
        ' 
        AcceptButton = OK
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        CancelButton = Cancel
        ClientSize = New Size(401, 392)
        Controls.Add(Cancel)
        Controls.Add(OK)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        MinimizeBox = False
        Name = "RegisterForm"
        SizeGripStyle = SizeGripStyle.Hide
        StartPosition = FormStartPosition.CenterParent
        Text = "RegisterForm"
        ResumeLayout(False)

    End Sub

End Class

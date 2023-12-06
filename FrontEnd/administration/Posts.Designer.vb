<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Posts
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
        totalReg = New Label()
        DataGridView1 = New DataGridView()
        SplitContainer1 = New SplitContainer()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer1.Panel1.SuspendLayout()
        SplitContainer1.Panel2.SuspendLayout()
        SplitContainer1.SuspendLayout()
        SuspendLayout()
        ' 
        ' totalReg
        ' 
        totalReg.Dock = DockStyle.Left
        totalReg.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        totalReg.Location = New Point(0, 0)
        totalReg.Name = "totalReg"
        totalReg.Size = New Size(256, 55)
        totalReg.TabIndex = 1
        totalReg.Text = "Registros totales:"
        totalReg.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Dock = DockStyle.Fill
        DataGridView1.Location = New Point(0, 0)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.Size = New Size(800, 391)
        DataGridView1.TabIndex = 0
        ' 
        ' SplitContainer1
        ' 
        SplitContainer1.Dock = DockStyle.Fill
        SplitContainer1.Location = New Point(0, 0)
        SplitContainer1.Name = "SplitContainer1"
        SplitContainer1.Orientation = Orientation.Horizontal
        ' 
        ' SplitContainer1.Panel1
        ' 
        SplitContainer1.Panel1.AutoScroll = True
        SplitContainer1.Panel1.Controls.Add(DataGridView1)
        ' 
        ' SplitContainer1.Panel2
        ' 
        SplitContainer1.Panel2.Controls.Add(totalReg)
        SplitContainer1.Size = New Size(800, 450)
        SplitContainer1.SplitterDistance = 391
        SplitContainer1.TabIndex = 1
        ' 
        ' Posts
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(SplitContainer1)
        Name = "Posts"
        Text = "Posts"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer1.Panel1.ResumeLayout(False)
        SplitContainer1.Panel2.ResumeLayout(False)
        CType(SplitContainer1, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents totalReg As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SplitContainer1 As SplitContainer
End Class

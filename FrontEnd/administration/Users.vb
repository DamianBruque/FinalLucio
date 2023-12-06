Imports Service

Public Class Users
    Private service As UserService
    Private Sub Users_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        service = New UserService
        Try
            DataGridView1.DataSource = service.GetAll()
            totalReg.Text = "Registros Totales: " & DataGridView1.RowCount
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
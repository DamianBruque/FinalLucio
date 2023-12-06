Imports Service

Public Class People
    Private service As PersonService
    Private Sub People_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        service = New PersonService
        Try
            DataGridView1.DataSource = service.GetAll()
            totalReg.Text = "Registros Totales: " & DataGridView1.RowCount
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
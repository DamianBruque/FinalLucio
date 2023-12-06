Imports Service

Public Class Posts
    Private service As PostService

    Private Sub Posts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        service = New PostService
        Try
            DataGridView1.DataSource = service.GetAll()
            totalReg.Text = "Registros Totales: " & DataGridView1.RowCount
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
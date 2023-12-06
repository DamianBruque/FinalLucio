Imports System.Windows.Forms
Imports Microsoft.EntityFrameworkCore

Public Class AdminPanel

    Private m_ChildFormNumber As Integer

    Private Sub PosteosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PosteosToolStripMenuItem.Click
        CloseAllForms()
        Dim postsForm As New Posts
        postsForm.MdiParent = Me
        postsForm.WindowState = FormWindowState.Maximized
        postsForm.Show()
    End Sub

    Private Sub PersonasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PersonasToolStripMenuItem.Click
        CloseAllForms()
        Dim peopleForm As New People
        peopleForm.MdiParent = Me
        peopleForm.WindowState = FormWindowState.Maximized
        peopleForm.Show()
    End Sub

    Private Sub UsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuariosToolStripMenuItem.Click
        CloseAllForms()
        Dim usersForm As New Users
        usersForm.MdiParent = Me
        usersForm.WindowState = FormWindowState.Maximized
        usersForm.Show()
    End Sub

    Private Sub AdminPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CloseAllForms()
        For Each childForm As Form In MdiChildren
            childForm.Close()
        Next
    End Sub
End Class

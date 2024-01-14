Imports System.Data
Imports System.Data.SqlClient
Public Class Form8

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con = connectdb()(0)
        Dim cmd = connectdb()(1)
        Dim dt As New DataTable

        cmd = New SqlCommand("select*from book", con)
        Dim dr As SqlDataReader = cmd.ExecuteReader()
        DataGridView1.RowTemplate.Height = 80
        Do While dr.Read
            DataGridView1.Rows.Add(dr("bookname"), dr("bookdesc"), dr("booklink"), dr("regno"))
        Loop
        dr.Close()

        Try

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridView
            row = Me.DataGridView1
        End If
    End Sub

    Private Sub home_Click(sender As Object, e As EventArgs) Handles home.Click
        Form3.Show()
        Me.Hide()
    End Sub
End Class
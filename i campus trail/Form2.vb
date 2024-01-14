Imports System.IO
Imports System.Data.SqlClient
Public Class Form2

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form3.Show()
        Me.Hide()
    End Sub


    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridView
            row = Me.DataGridView1
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim con = connectdb()(0)
        Dim cmd = connectdb()(1)
        Dim dt As New DataTable
        DataGridView1.RowTemplate.Height = 400



        cmd = New SqlCommand("select*from PHOTOS", con)
        Dim dr As SqlDataReader = cmd.ExecuteReader()
        Do While dr.Read
            DataGridView1.Rows.Add(dr("photoid"), dr("photodesc"), dr("photolink"), dr("regno"))
        Loop
        dr.Close()

        Try

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Form3.Show()
        Me.Hide()
    End Sub
End Class
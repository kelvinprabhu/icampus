Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con = connectdb()(0)
        Dim cmd = connectdb()(1)
        Dim dt As New DataTable
        DataGridView1.RowTemplate.Height = 50
        cmd = New SqlCommand("select*from word", con)
        Dim dr As SqlDataReader = cmd.ExecuteReader()
        DataGridView1.RowTemplate.Height = 100
        Do While dr.Read
            DataGridView1.Rows.Add(dr("wordid"), dr("wordname"), dr("worddesc"), dr("wordlink"), dr("regno"))
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

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Form3.Show()
        Me.Hide()

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Form3.Show()
        Me.Hide()

    End Sub
End Class
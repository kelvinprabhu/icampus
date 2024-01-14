Imports System.Data.SqlClient

Public Class Form12

 


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form3.Show()
        Me.Close()
    End Sub



    Private Sub Form12_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con = connectdb()(0)
        Dim cmd = connectdb()(1)
        cmd = New SqlCommand("SELECT shareid FROM shared", con)
        Dim DR As SqlDataReader
        DR = cmd.ExecuteReader
        DR.Read()
        ID.Text = DR("shareid")
        DR.Close()
        Dim dt As New DataTable
        cmd = New SqlCommand("SELECT p.photodesc AS PD,p.photolink AS PL FROM PHOTOS p,shared s where s.shareid='" + ID.Text + "' AND p.regno='" + ID.Text + "'", con)
        DR = cmd.ExecuteReader
        DataGridView1.RowTemplate.Height = 400
        Do While DR.Read
            DataGridView1.Rows.Add(DR("PD"), DR("PL"))
        Loop
        DR.Close()
        cmd = New SqlCommand("SELECT b.bookname AS BN,b.bookdesc AS BD,b.booklink AS BL FROM book b,shared s where s.shareid='" + ID.Text + "' AND b.regno='" + ID.Text + "'", con)
        DR = cmd.ExecuteReader
        DataGridView2.RowTemplate.Height = 400
        Do While DR.Read
            DataGridView2.Rows.Add(DR("BN"), DR("BD"), DR("BL"))
        Loop
        DR.Close()
        cmd = New SqlCommand("SELECT w.wordname AS WN,w.worddesc AS WD ,w.wordlink WL FROM word w,shared s where s.shareid='" + ID.Text + "'AND w.regno='" + ID.Text + "'", con)
        DR = cmd.ExecuteReader

        DataGridView3.RowTemplate.Height = 400
        Do While DR.Read
            DataGridView3.Rows.Add(DR("WN"), DR("WD"), DR("WL"))
        Loop
        DR.Close()
  
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridView
            row = Me.DataGridView1
        End If
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridView
            row = Me.DataGridView2
        End If
    End Sub

    Private Sub DataGridView3_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView3.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridView
            row = Me.DataGridView3
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class

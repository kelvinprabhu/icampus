Imports System.Data
Imports System.Data.SqlClient
Public Class Form11

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub


    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridView
            row = Me.DataGridView1
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DataGridView1.Rows.Clear()
        Dim con = connectdb()(0)
        Dim cmd = connectdb()(1)

        cmd = New SqlCommand("select bookid,bookname,bookdesc,booklink from book WHERE bookid ='" + TextBox1.Text + "'", con)
        Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
        Dim dt As DataTable = New DataTable()
        sda.Fill(dt)
        If (dt.Rows.Count > 0) Then
            Dim dr As SqlDataReader = cmd.ExecuteReader()
            DataGridView1.RowTemplate.Height = 80
            Do While dr.Read
                DataGridView1.Rows.Add(dr("bookid"), dr("bookname"), dr("bookdesc"), dr("booklink"))
            Loop
            dr.Close()
        Else
            MsgBox("NOT AVAILABLE")
        End If
        Try

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        DataGridView1.Rows.Clear()
        Dim con = connectdb()(0)
        Dim cmd = connectdb()(1)


        cmd = New SqlCommand("select bookid,bookname,bookdesc,booklink from book WHERE bookdesc ='" + TextBox3.Text + "'", con)
        Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
        Dim dt As DataTable = New DataTable()
        sda.Fill(dt)
        If (dt.Rows.Count > 0) Then
            Dim dr As SqlDataReader = cmd.ExecuteReader()
            DataGridView1.RowTemplate.Height = 80
            Do While dr.Read
                DataGridView1.Rows.Add(dr("bookid"), dr("bookname"), dr("bookdesc"), dr("booklink"))
            Loop
            dr.Close()
        Else
            MsgBox("NOT AVAILABLE")
        End If
        Try

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        DataGridView1.Rows.Clear()
        Dim con = connectdb()(0)
        Dim cmd = connectdb()(1)


        cmd = New SqlCommand("select bookid,bookname,bookdesc,booklink from book WHERE bookname ='" + TextBox2.Text + "'", con)
        Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
        Dim dt As DataTable = New DataTable()
        sda.Fill(dt)
        If (dt.Rows.Count > 0) Then
            Dim dr As SqlDataReader = cmd.ExecuteReader()
            DataGridView1.RowTemplate.Height = 80
            Do While dr.Read
                DataGridView1.Rows.Add(dr("bookid"), dr("bookname"), dr("bookdesc"), dr("booklink"))
            Loop
            dr.Close()
        Else
            MsgBox("NOT AVAILABLE")
        End If

        Try

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        DataGridView1.Rows.Clear()
    End Sub
End Class
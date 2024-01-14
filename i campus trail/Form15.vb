Imports System.Data.SqlClient
Public Class Form15

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridView
            row = Me.DataGridView1
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        DataGridView1.Hide()

        DataGridView3.Hide()
        DataGridView4.Hide()
        Dim con = connectdb()(0)
        Dim cmd = connectdb()(1)

        cmd = New SqlCommand("select bookid,bookname,bookdesc,booklink from book WHERE bookid ='" + TextBox1.Text + "'", con)
        Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
        Dim dt As DataTable = New DataTable()
        Dim dr As SqlDataReader
        sda.Fill(dt)
        If (dt.Rows.Count > 0) Then
            dr = cmd.ExecuteReader()
            DataGridView2.RowTemplate.Height = 80
            Do While dr.Read
                DataGridView2.Rows.Add(dr("bookid"), dr("bookname"), dr("bookdesc"), dr("booklink"))
            Loop
            dr.Close()
        Else
            MsgBox("NOT AVAILABLE")
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        DataGridView1.Hide()
        DataGridView2.Hide()

        DataGridView4.Hide()
        Dim con = connectdb()(0)
        Dim cmd = connectdb()(1)

        cmd = New SqlCommand("select wordid,wordname,worddesc,wordlink,regno from word", con)
        Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
        Dim dt As DataTable = New DataTable()
        Dim dr As SqlDataReader
        sda.Fill(dt)
        If (dt.Rows.Count > 0) Then
            dr = cmd.ExecuteReader()
            DataGridView3.RowTemplate.Height = 80
            Do While dr.Read
                DataGridView3.Rows.Add(dr("wordid"), dr("wordname"), dr("worddesc"), dr("wordlink"), dr("regno"))
            Loop
            dr.Close()
        Else
            MsgBox("NOT AVAILABLE")
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged

        DataGridView2.Hide()
        DataGridView3.Hide()
        DataGridView4.Hide()
        Dim con = connectdb()(0)
        Dim cmd = connectdb()(1)
        Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        cmd = New SqlCommand("select photoid,photodesc,photolink,regno from PHOTOS WHERE photoid ='" + TextBox1.Text + "'", con)
        Dim dr As SqlDataReader
        sda.Fill(dt)
        If (dt.Rows.Count > 0) Then
            dr = cmd.ExecuteReader()
            DataGridView1.RowTemplate.Height = 400


            Do While dr.Read
                DataGridView1.Rows.Add(dr("photoid"), dr("photodesc"), dr("photolink"), dr("regno"))
            Loop
            dr.Close()
        Else
            MsgBox("NOT AVAILABLE")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DataGridView1.Hide()
        DataGridView2.Hide()
        DataGridView3.Hide()

        Dim con = connectdb()(0)
        Dim cmd = connectdb()(1)
        Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        Dim dr As SqlDataReader
        cmd = New SqlCommand("select username,userid,useremail,usertype,udesc,profilephoto from user_details WHERE userid ='" + TextBox2.Text + "'", con)
        sda.Fill(dt)
        If (dt.Rows.Count > 0) Then
            dr = cmd.ExecuteReader()
            DataGridView4.RowTemplate.Height = 400


            Do While dr.Read
                DataGridView4.Rows.Add(dr("username"), dr("userid"), dr("useremail"), dr("usertype"), dr("udesc"), dr("profilephoto"))
            Loop
            dr.Close()
        Else
            MsgBox("NOT AVAILABLE")
        End If
    End Sub

    Private Sub DataGridView3_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView3.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridView
            row = Me.DataGridView3
        End If
    End Sub

    Private Sub DataGridView4_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView4.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridView
            row = Me.DataGridView4
        End If
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridView
            row = Me.DataGridView2
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Form13.Show()
        Me.Hide()
    End Sub

    Private Sub Form15_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.Hide()
        DataGridView2.Hide()
        DataGridView3.Hide()
        DataGridView4.Hide()
    End Sub
End Class
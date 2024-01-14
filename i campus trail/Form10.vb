Imports System.Data.SqlClient
Imports System.IO
Imports System.Data
Public Class Form10
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Label2.Visible = True
        TextBox1.Visible = True
        Button1.Visible = True
        Button2.Visible = True
        Button3.Visible = True
        Label4.Visible = False
        TextBox2.Visible = False
        Button4.Visible = False
        Button5.Visible = False
        Button6.Visible = False
        LinkLabel1.Visible = False
        Label5.Visible = False
        PictureBox1.Visible = False
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        PictureBox1.Visible = True
        Label5.Visible = True
        Dim con = connectdb()(0)
        Dim cmd = connectdb()(1)
        cmd = New SqlCommand("SELECT photolink from PHOTOS where photoId='" & TextBox2.Text & "'", con)
        Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
        Dim dt As DataTable = New DataTable()
        Dim rd As SqlDataReader
        sda.Fill(dt)
        If (dt.Rows.Count > 0) Then
            rd = cmd.ExecuteReader
            rd.Read()
            Dim pr() As Byte
            pr = rd("photolink")
            Dim MS As New MemoryStream(pr)
            PictureBox1.Image = Image.FromStream(MS)
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        Else
            MsgBox("invlid constrains")
        End If


    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Form3.Show()
    End Sub

    Private Sub Label3_Click_1(sender As Object, e As EventArgs) Handles Label3.Click
        Label4.Visible = True
        TextBox2.Visible = True
        Button4.Visible = True
        Button5.Visible = True
        Button6.Visible = True
        Label2.Visible = False
        TextBox1.Visible = False
        Button1.Visible = False
        Button2.Visible = False
        Button3.Visible = False
        LinkLabel1.Visible = False
        Label5.Visible = False
        PictureBox1.Visible = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        LinkLabel1.Visible = True
        Label5.Visible = True
        PictureBox1.Visible = False
        Dim con = connectdb()(0)
        Dim cmd = connectdb()(1)
        cmd = New SqlCommand("SELECT worddesc,wordlink FROM word WHERE wordid='" & TextBox2.Text & "'", con)
        Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
        Dim dt As DataTable = New DataTable()
        Dim srd As SqlDataReader
        sda.Fill(dt)
        If (dt.Rows.Count > 0) Then

            srd = cmd.ExecuteReader
            srd.Read()
            Label5.Text = srd("worddesc")
            LinkLabel1.Text = srd("wordlink")
        Else
            MsgBox("invlid constrains")
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        PictureBox1.Visible = True
        Label5.Visible = True
        LinkLabel1.Visible = False
        Dim con = connectdb()(0)
        Dim cmd = connectdb()(1)
        cmd = New SqlCommand("SELECT profilephoto,username from user_details where userid='" & TextBox2.Text & "'", con)
        Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
        Dim dt As DataTable = New DataTable()
        sda.Fill(dt)
        If (dt.Rows.Count > 0) Then
            Dim rd As SqlDataReader
            rd = cmd.ExecuteReader
            rd.Read()
            Dim pr() As Byte
            pr = rd("profilephoto")
            Dim MS As New MemoryStream(pr)
            PictureBox1.Image = Image.FromStream(MS)
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
            Label5.Text = rd("username")
        Else
            MsgBox("invalid constrains")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con = connectdb()(0)
        Dim cmd = connectdb()(1)
        cmd = New SqlCommand("DELETE from PHOTOS where photoid='" & TextBox1.Text & "' and regno='" & SR.Text & "'", con)
        cmd.ExecuteNonQuery()
        MsgBox("Successfully DELETED!", MsgBoxStyle.Information, "Success")
        TextBox1.Clear()
        If (TextBox1.Text = "") Then
            MsgBox("Please enter UID")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim con = connectdb()(0)
        Dim cmd = connectdb()(1)
        cmd = New SqlCommand("DELETE from word where wordid='" & TextBox1.Text & "' and regno='" & SR.Text & "'", con)
        Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
        Dim dt As DataTable = New DataTable()
        sda.Fill(dt)
        If (TextBox1.Text = "") Then
            MsgBox("Please enter UID")
        ElseIf (dt.Rows.Count < 0) Then
            MsgBox("invalid constrains")
        Else

            cmd.ExecuteNonQuery()
            MsgBox("Successfully DELETED!", MsgBoxStyle.Information, "Success")
            TextBox1.Clear()

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim con = connectdb()(0)
        Dim cmd = connectdb()(1)
        cmd = New SqlCommand("DELETE from book where bookid='" & TextBox1.Text & "' and regno='" & SR.Text & "'", con)
        Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
        Dim dt As DataTable = New DataTable()
        sda.Fill(dt)
        If (TextBox1.Text = "") Then
            MsgBox("Please enter UID")
        ElseIf (dt.Rows.Count < 0) Then
            MsgBox("invalid constrains")
        Else

            cmd.ExecuteNonQuery()
            MsgBox("Successfully DELETED!", MsgBoxStyle.Information, "Success")
            TextBox1.Clear()

        End If
    End Sub

    Private Sub Form10_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con = connectdb()(0)
        Dim cmd = connectdb()(1)
        cmd = New SqlCommand("SELECT shareid FROM shared", con)
        Dim srd As SqlDataReader
        srd = cmd.ExecuteReader
        srd.Read()
        SR.Text = srd("shareid")
    End Sub
End Class
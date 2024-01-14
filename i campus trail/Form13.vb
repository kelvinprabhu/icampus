Imports System.IO
Imports System.Data.SqlClient
Public Class Form13

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim con = connectdb()(0)
        Dim cmd = connectdb()(1)
        cmd = New SqlCommand("DELETE from user_details where userid='" & TextBox3.Text & "'", con)
        Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
        Dim dt As DataTable = New DataTable()


        sda.Fill(dt)
        If (TextBox3.Text = "") Then
            MsgBox("Please enter UID")
        ElseIf (dt.Rows.Count < 0) Then
            MsgBox("invalid constrains")
        Else
            cmd.ExecuteNonQuery()
            MsgBox("Successfully DELETED!", MsgBoxStyle.Information, "Success")
            TextBox1.Clear()
        End If
    End Sub


    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form13_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form3.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con = connectdb()(0)
        Dim cmd = connectdb()(1)

        
        If RadioButton3.Checked = True Then
            cmd = New SqlCommand("DELETE from book where bookid='" & TextBox1.Text & "'", con)
            If (TextBox1.Text = "") Then
                MsgBox("Please enter UID")
           
            Else
                cmd.ExecuteNonQuery()
                MsgBox("Successfully DELETED!", MsgBoxStyle.Information, "Success")
                TextBox1.Clear()
            End If
        ElseIf RadioButton2.Checked = True Then
            cmd = New SqlCommand("DELETE from word where wordid='" & TextBox1.Text & "'", con)
            If (TextBox1.Text = "") Then
                MsgBox("Please enter UID")
            Else

                cmd.ExecuteNonQuery()
                MsgBox("Successfully DELETED!", MsgBoxStyle.Information, "Success")
                TextBox1.Clear()
            End If
        ElseIf RadioButton1.Checked = True Then
            cmd = New SqlCommand("DELETE from PHOTOS where photoid='" & TextBox1.Text & "'", con)

            If (TextBox1.Text = "") Then
                MsgBox("Please enter UID")
        
            Else

                cmd.ExecuteNonQuery()
                MsgBox("Successfully DELETED!", MsgBoxStyle.Information, "Success")
                TextBox1.Clear()
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim con = connectdb()(0)
        Dim cmd = connectdb()(1)
        cmd = New SqlCommand("INSERT INTO logindetails values('" & TextBox2.Text & "','" & TextBox2.Text & "','" & TextBox4.Text & "')", con)
        Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
        Dim dt As DataTable = New DataTable()
        sda.Fill(dt)
        If (dt.Rows.Count = 0) Then
            cmd.ExecuteNonQuery()
            MsgBox(" registered Successfully !!", MsgBoxStyle.Information, "Success")
            TextBox2.Clear()

        ElseIf (TextBox2.Text = "") Then
            MsgBox("Please enter the  details")
        Else
            MsgBox("invalid")
        End If
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)
        Form15.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form14.Show()
        Me.Hide()
    End Sub
End Class
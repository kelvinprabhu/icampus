Imports System.Data.SqlClient
Public Class Form6

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles wdesc.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con = connectdb()(0)
        Dim cmd = connectdb()(1)
        cmd = New SqlCommand("INSERT INTO word values('" & wid.Text & "', '" & wdesc.Text & "', '" & wlink.Text & "', '" & wname.Text & "', '" & sid.Text & "')", con)

            If (wid.Text = "" And wdesc.Text = "" And wlink.Text = "") Then
                MsgBox("Please enter the  details")

            Else
            cmd.ExecuteNonQuery()
                MsgBox(" POSTED Successfully !!", MsgBoxStyle.Information, "Success")
                wid.Clear()
                wdesc.Clear()
                wname.Clear()
                wlink.Clear()
            End If

    End Sub




    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim dateAndTime As Date
        dateAndTime = Now
        wid.Text = Format(dateAndTime, "yyyyMMddHHmmss").ToString
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con = connectdb()(0)
        Dim cmd = connectdb()(1)
        cmd = New SqlCommand("SELECT shareid FROM shared", con)
        Dim srd As SqlDataReader
        srd = cmd.ExecuteReader
        srd.Read()
        sid.Text = srd("shareid")
    End Sub
End Class
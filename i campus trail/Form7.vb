Imports System.Data.SqlClient
Public Class Form7

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Dim con = connectdb()(0)
        Dim cmd = connectdb()(1)
        cmd = New SqlCommand("INSERT INTO book values('" & BID.Text & "', '" & bdesc.Text & "', '" & blink.Text & "', '" & bname.Text & "', '" & sid.Text & "')", con)

        If (bname.Text = "" And BID.Text = "" And bdesc.Text = "" And BID.Text = "") Then
            MsgBox("Please enter the details")
        Else
            cmd.ExecuteNonQuery()

            MsgBox("POSTED!!", MsgBoxStyle.Information, "Success")

            bname.Clear()
            BID.Clear()
            bdesc.Clear()
            blink.Clear()
        End If
        con.Close()
       

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim dateAndTime As Date
        dateAndTime = Now
        BID.Text = Format(dateAndTime, "yyyy/MM/dd:mmss").ToString
      
    End Sub

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con = connectdb()(0)
        Dim cmd = connectdb()(1)
        cmd = New SqlCommand("SELECT shareid FROM shared", con)
        Dim srd As SqlDataReader
        srd = cmd.ExecuteReader
        srd.Read()
        sid.Text = srd("shareid")
    End Sub
End Class
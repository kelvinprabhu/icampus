Imports System.Data.SqlClient
Public Class Form16

    Private Sub Form16_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con = connectdb()(0)
        Dim cmd = connectdb()(1)
        cmd = New SqlCommand("SELECT shareid FROM shared", con)
        Dim srd As SqlDataReader
        srd = cmd.ExecuteReader
        srd.Read()
        Label1.Text = srd("shareid")
    End Sub
End Class
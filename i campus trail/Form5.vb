Imports System.Data
Imports System.Data.SqlClient
Imports System.IO

Public Class Form5

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        With JPG
            If .ShowDialog Then
                PictureBox1.Image = Image.FromFile(.FileName)
                PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
            End If
        End With
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim dateAndTime As Date
        dateAndTime = Now
        PID.Text = Format(dateAndTime, "yyyyMMddHHmmss").ToString
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con = connectdb()(0)
        Dim cmd = connectdb()(1)
        Dim ms As New MemoryStream
        PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)

        cmd = New SqlCommand("INSERT INTO PHOTOS (photoid,photodesc,photolink,regno) values (@id,@de,@im,@ir)", con)
        cmd.parameters.addwithvalue("@id", PID.Text)
        cmd.parameters.addwithvalue("@de", pdesc.Text)
        cmd.parameters.addwithvalue("@im", ms.ToArray)
        cmd.parameters.addwithvalue("@ir", sid.Text)
        If (PID.Text = "" And pdesc.Text = "") Then

            MsgBox("Please enter the  details")
               
        Else

            cmd.ExecuteNonQuery()
            MsgBox("POSTED !!", MsgBoxStyle.Information, "Success")
            PID.Clear()
            pdesc.Clear()
            PictureBox1.Image = Nothing
        End If
            con.Close()
       


      



    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con = connectdb()(0)
        Dim cmd = connectdb()(1)
        cmd = New SqlCommand("SELECT shareid FROM shared", con)
        Dim srd As SqlDataReader
        srd = cmd.ExecuteReader
        srd.Read()
        sid.Text = srd("shareid")
    End Sub

    Private Sub sid_TextChanged(sender As Object, e As EventArgs) Handles sid.TextChanged

    End Sub
End Class
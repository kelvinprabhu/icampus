Imports System.Data.SqlClient
Imports System.IO
Imports System.Data
Public Class Form9



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim con = connectdb()(0)
        Dim cmd = connectdb()(1)

        Dim dr As SqlDataReader
     
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from User_details where userid='" & userid.Text & "' "

        dr = cmd.ExecuteReader
        If dr.HasRows Then
            MsgBox("User has Already registered", MsgBoxStyle.Critical)

        Else
            Dim ms As New MemoryStream
            PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)

            cmd = New SqlCommand("INSERT INTO User_details (username,userid,useremail,usertype,udesc,profilephoto) values(@un,@ui,@ue,@ut,@ud,@pp)", con)
            cmd.parameters.addwithvalue("@un", username.Text)
            cmd.parameters.addwithvalue("@ui", userid.Text)
            cmd.parameters.addwithvalue("@ue", useremail.Text)
            cmd.parameters.addwithvalue("@ut", usertype.Text)
            cmd.parameters.addwithvalue("@ud", udesc.Text)
            cmd.parameters.addwithvalue("@pp", MS.ToArray)
            If (username.Text = "" And userid.Text = "" And useremail.Text = "" And usertype.Text = "") Then
                MsgBox("Please enter the details")
            Else
                cmd.ExecuteNonQuery()
                MsgBox("Successfully registered!", MsgBoxStyle.Information, "Success")

                username.Clear()
                userid.Clear()
                useremail.Clear()
                usertype.Clear()
                PictureBox1 = Nothing


                
            End If

        End If


    End Sub




    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        usertype.Text = "student"
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        usertype.Text = "faculity"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        With JPG
            If .ShowDialog Then
                PictureBox1.Image = Image.FromFile(.FileName)
                PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
            End If
        End With
        Try

        Catch ex As ArgumentException
            MsgBox("N")
        End Try
    End Sub

    Private Sub udesc_TextChanged(sender As Object, e As EventArgs) Handles udesc.TextChanged

    End Sub
End Class




Imports System.Data.SqlClient
Class Form1
    Dim frm As Object

    Private Property Form2 As Object

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("WELCOME TO iCAMPUS ", MsgBoxStyle.Information)
        MsgBox("YOUR LOGIN PASSWORD AND LOGIN ID IS SAME AS YOUR COLLEGE GIVEN REGISTRATION NUMER ", MsgBoxStyle.Information)
        MsgBox("PLEASE CHANGE YOUR PASSWORD AS YOU LOGIN PASSWORD AS A SECURE ID", MsgBoxStyle.Critical)
        MsgBox("REGISTER BEFORE  YOUR FIRST TIME LOGIN TO iCAMPUS", MsgBoxStyle.Information)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        lrole.Text = "faculity"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form9.Show()
        Me.Hide()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        PASSCHECK.Visible = True
        ID.Visible = True
        PASS.Visible = True
        Button4.Visible = True
        Button6.Visible = True



    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim con = connectdb()(0)
        Dim cmd = connectdb()(1)
        Dim dr As SqlDataReader
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from logindetails where loginid='" & ID.Text & "' "

        dr = cmd.ExecuteReader
        If dr.HasRows Then
            MsgBox("USER HAS ALREADY REGISTERED PLEASE TRY UR REGISTRATION ID IN PASSWORD", MsgBoxStyle.Information)
            PASSCHECK.Visible = False
            ID.Visible = False
            PASS.Visible = False
            Button4.Visible = False
            Button6.Visible = False
            ID.Clear()
        End If


    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con = connectdb()(0)
        Dim cmd = connectdb()(1)

        cmd = New SqlCommand("select * from logindetails where loginid='" + LID.Text + "' and loginpassword='" + LPASSWORD.Text + "'and loginrole='" + lrole.Text + "' ", con)

            Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
            Dim dt As DataTable = New DataTable()
            sda.Fill(dt)
            If (dt.Rows.Count > 0) Then

                cmd = New SqlCommand("TRUNCATE TABLE shared", con)
                cmd.ExecuteNonQuery()


            cmd = New SqlCommand("INSERT INTO shared values('" & LID.Text & "')", con)
            cmd.ExecuteNonQuery()

        MsgBox(" LOGIN Successfully !!", MsgBoxStyle.Information, "Success")
        LID.Clear()
        LPASSWORD.Clear()
        lrole.Clear()
        Form3.Show()
        Me.Hide()
        Else
        MsgBox(" INVALID ID AND PASSWORD !!", MsgBoxStyle.Information, "INVALID")
        End If




    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged

        lrole.Text = "student"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        MsgBox(" EXIT !!", MsgBoxStyle.Information, "WARNING")
        Application.Exit()
    End Sub

    Private Sub lrole_TextChanged(sender As Object, e As EventArgs) Handles lrole.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles PASS.TextChanged

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim con = connectdb()(0)
        Dim cmd = connectdb()(1)
        cmd = New SqlCommand("UPDATE logindetails SET loginpassword = @pa WHERE loginid='" + ID.Text + "'", con)
        cmd.parameters.addwithvalue("@pa", PASS.Text)

        If (PASS.Text = "" And PASSCHECK.Text = "" And PASSCHECK.Text <> PASSCHECK.Text) Then
            MsgBox("Please enter the details or re-entered password does not match")
        Else
            cmd.ExecuteNonQuery()
            MsgBox(" PASSWORD CHANGED Successfully !!", MsgBoxStyle.Information, "Success")
            PASSCHECK.Visible = False
            ID.Visible = False
            PASS.Visible = False
            Button4.Visible = False
            Button6.Visible = False


        End If

    End Sub

    Private Sub LID_TextChanged(sender As Object, e As EventArgs) Handles LID.TextChanged

    End Sub
End Class






Imports System.Data.SqlClient
Imports System.IO
Public Class Form3

    Private Sub FEEDSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FEEDSToolStripMenuItem.Click
        Form2.Show()
        Me.Hide()
    End Sub



    Private Sub SEEWASSUPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SEEWASSUPToolStripMenuItem.Click
        Form4.Show()
        Me.Hide()
    End Sub

    Private Sub BEANERDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BEANERDToolStripMenuItem.Click
        Form8.Show()
        Me.Hide()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TELLUSWHATSNEWToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TELLUSWHATSNEWToolStripMenuItem.Click
        Form6.Show()
        Me.Hide()
    End Sub

    Private Sub SHAREURPOSTSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SHAREURPOSTSToolStripMenuItem.Click
        Form5.Show()
        Me.Hide()
    End Sub
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox(" USERS CAN GET INFORMATION OF THE APPLICATON ON ABOUT SECTION ", MsgBoxStyle.Information)
        Dim con = connectdb()(0)
        Dim cmd = connectdb()(1)
        cmd = New SqlCommand("SELECT shareid FROM shared", con)
        Dim srd As SqlDataReader
        srd = cmd.ExecuteReader
        srd.Read()
        SREG.Text = srd("shareid")
        If SREG.Text = "ADMIN" Then
            PROFILEToolStripMenuItem.Visible = False
            ADMINCORNERToolStripMenuItem.Visible = True
        Else
            ADMINCORNERToolStripMenuItem.Visible = False
        End If
    End Sub

    Private Sub CONTRIBUTETONERDSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CONTRIBUTETONERDSToolStripMenuItem.Click
        Form7.Show()
        Me.Hide()
    End Sub

    Private Sub EXITToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EXITToolStripMenuItem.Click

        Dim con = connectdb()(0)
        Dim cmd = connectdb()(1)
        cmd = New SqlCommand("TRUNCATE TABLE shared", con)
        MsgBox(" are u sure!!", MsgBoxStyle.Information, "Success")
        Application.Exit()
    End Sub

    Private Sub JOINTHEFAMToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JOINTHEFAMToolStripMenuItem.Click

    End Sub

    Private Sub SNAME_TextChanged(sender As Object, e As EventArgs) Handles SNAME.TextChanged

    End Sub

    Private Sub PROFILEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PROFILEToolStripMenuItem.Click
        SNAME.Visible = True
        stype.Visible = True
        SREG.Visible = True
        DESC.Visible = True
        PictureBox1.Visible = True
        Label5.Visible = False

        Dim con = connectdb()(0)
        Dim cmd = connectdb()(1)
        cmd = New SqlCommand("SELECT * from user_details where userid='" & SREG.Text & "'", con)
        Dim rd As SqlDataReader
        rd = cmd.ExecuteReader
        rd.Read()
        Dim pr() As Byte
        pr = rd("profilephoto")
        Dim MS As New MemoryStream(pr)
        PictureBox1.Image = Image.FromStream(MS)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        SNAME.Text = rd("username")
        stype.Text = rd("usertype")
        DESC.Text = rd("udesc")
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
 
    End Sub

    Private Sub ABOUTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ABOUTToolStripMenuItem.Click
        SNAME.Visible = False
        stype.Visible = False
        SREG.Visible = False
        DESC.Visible = False
        Label5.Visible = True

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub DROPPOSTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DROPPOSTToolStripMenuItem.Click
        Form10.Show()
        Me.Hide()
    End Sub

    Private Sub BOOKSEARCHToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BOOKSEARCHToolStripMenuItem.Click
        Form11.Show()
        Me.Hide()
    End Sub

    Private Sub MYCORNERToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MYCORNERToolStripMenuItem.Click
        Form12.Show()
        Me.Hide()
    End Sub

    Private Sub ADMINCORNERToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ADMINCORNERToolStripMenuItem.Click
        Form13.Show()
        Me.Hide()
    End Sub
End Class
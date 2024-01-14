<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PASS = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.lrole = New System.Windows.Forms.TextBox()
        Me.LPASSWORD = New System.Windows.Forms.TextBox()
        Me.LID = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.ID = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.PASSCHECK = New System.Windows.Forms.TextBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Goudy Stout", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(66, 382)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(181, 27)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "LOGIN ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Goudy Stout", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(837, 383)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(208, 27)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "PASSWORD"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte), True)
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(885, 460)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(216, 52)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "LOG IN"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte), True)
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(1186, 460)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(216, 52)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "REGISTER "
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Location = New System.Drawing.Point(96, 460)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(216, 58)
        Me.Button3.TabIndex = 15
        Me.Button3.Text = "forget password"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'PASS
        '
        Me.PASS.Location = New System.Drawing.Point(86, 568)
        Me.PASS.Name = "PASS"
        Me.PASS.Size = New System.Drawing.Size(294, 28)
        Me.PASS.TabIndex = 16
        Me.PASS.Visible = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button4.Font = New System.Drawing.Font("Poor Richard", 13.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(417, 665)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(372, 45)
        Me.Button4.TabIndex = 17
        Me.Button4.Text = "CHECK IF ALREADY REGISTERED"
        Me.Button4.UseVisualStyleBackColor = False
        Me.Button4.Visible = False
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.RadioButton2.Location = New System.Drawing.Point(528, 511)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(107, 26)
        Me.RadioButton2.TabIndex = 6
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "STUDENT"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.RadioButton1.Location = New System.Drawing.Point(530, 476)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(116, 26)
        Me.RadioButton1.TabIndex = 5
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "FACULITY"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'lrole
        '
        Me.lrole.Location = New System.Drawing.Point(1129, 568)
        Me.lrole.Name = "lrole"
        Me.lrole.Size = New System.Drawing.Size(294, 28)
        Me.lrole.TabIndex = 18
        Me.lrole.Visible = False
        '
        'LPASSWORD
        '
        Me.LPASSWORD.Location = New System.Drawing.Point(1149, 382)
        Me.LPASSWORD.Name = "LPASSWORD"
        Me.LPASSWORD.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.LPASSWORD.Size = New System.Drawing.Size(294, 28)
        Me.LPASSWORD.TabIndex = 19
        '
        'LID
        '
        Me.LID.Location = New System.Drawing.Point(301, 382)
        Me.LID.Name = "LID"
        Me.LID.Size = New System.Drawing.Size(294, 28)
        Me.LID.TabIndex = 20
        '
        'Button5
        '
        Me.Button5.BackgroundImage = CType(resources.GetObject("Button5.BackgroundImage"), System.Drawing.Image)
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button5.Location = New System.Drawing.Point(1340, 32)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(83, 53)
        Me.Button5.TabIndex = 21
        Me.Button5.UseVisualStyleBackColor = True
        '
        'ID
        '
        Me.ID.Location = New System.Drawing.Point(86, 682)
        Me.ID.Name = "ID"
        Me.ID.Size = New System.Drawing.Size(294, 28)
        Me.ID.TabIndex = 22
        Me.ID.Visible = False
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(1090, 348)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(294, 28)
        Me.TextBox3.TabIndex = 23
        Me.TextBox3.Visible = False
        '
        'PASSCHECK
        '
        Me.PASSCHECK.Location = New System.Drawing.Point(86, 626)
        Me.PASSCHECK.Name = "PASSCHECK"
        Me.PASSCHECK.Size = New System.Drawing.Size(294, 28)
        Me.PASSCHECK.TabIndex = 24
        Me.PASSCHECK.Visible = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button6.Location = New System.Drawing.Point(417, 624)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(229, 30)
        Me.Button6.TabIndex = 25
        Me.Button6.Text = "CHANGE PASSWORD"
        Me.Button6.UseVisualStyleBackColor = False
        Me.Button6.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1644, 932)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.PASSCHECK)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.ID)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.LID)
        Me.Controls.Add(Me.LPASSWORD)
        Me.Controls.Add(Me.lrole)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.PASS)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Poor Richard", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents PASS As System.Windows.Forms.TextBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents lrole As System.Windows.Forms.TextBox
    Friend WithEvents LPASSWORD As System.Windows.Forms.TextBox
    Friend WithEvents LID As System.Windows.Forms.TextBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents ID As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents PASSCHECK As System.Windows.Forms.TextBox
    Friend WithEvents Button6 As System.Windows.Forms.Button

End Class

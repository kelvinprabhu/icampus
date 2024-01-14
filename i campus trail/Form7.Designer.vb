<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form7))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.bname = New System.Windows.Forms.TextBox()
        Me.bdesc = New System.Windows.Forms.TextBox()
        Me.blink = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BID = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.sid = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(669, 797)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(190, 75)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "PUBLISH"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(1228, 817)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(101, 34)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "HOME"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'bname
        '
        Me.bname.Location = New System.Drawing.Point(702, 408)
        Me.bname.Name = "bname"
        Me.bname.Size = New System.Drawing.Size(584, 34)
        Me.bname.TabIndex = 2
        '
        'bdesc
        '
        Me.bdesc.Location = New System.Drawing.Point(702, 526)
        Me.bdesc.Name = "bdesc"
        Me.bdesc.Size = New System.Drawing.Size(584, 34)
        Me.bdesc.TabIndex = 3
        '
        'blink
        '
        Me.blink.Location = New System.Drawing.Point(702, 653)
        Me.blink.Name = "blink"
        Me.blink.Size = New System.Drawing.Size(584, 34)
        Me.blink.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(334, 408)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 28)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "BOOK NAME"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(334, 526)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 28)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "BOOK DESC"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(334, 659)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(164, 28)
        Me.Label3.TabIndex = 7
        Me.Label3.Tag = ""
        Me.Label3.Text = "G-DRIVE LINK"
        '
        'BID
        '
        Me.BID.Location = New System.Drawing.Point(853, 243)
        Me.BID.Name = "BID"
        Me.BID.Size = New System.Drawing.Size(204, 34)
        Me.BID.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(485, 249)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 28)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "BOOK ID"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(1102, 249)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(97, 28)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "GEN"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'sid
        '
        Me.sid.Location = New System.Drawing.Point(786, 326)
        Me.sid.Name = "sid"
        Me.sid.ReadOnly = True
        Me.sid.Size = New System.Drawing.Size(319, 34)
        Me.sid.TabIndex = 11
        '
        'Form7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 27.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1639, 928)
        Me.Controls.Add(Me.sid)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BID)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.blink)
        Me.Controls.Add(Me.bdesc)
        Me.Controls.Add(Me.bname)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Perpetua", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "Form7"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form7"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents bname As System.Windows.Forms.TextBox
    Friend WithEvents bdesc As System.Windows.Forms.TextBox
    Friend WithEvents blink As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BID As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents sid As System.Windows.Forms.TextBox
End Class

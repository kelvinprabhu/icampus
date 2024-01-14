<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form6))
        Me.wdesc = New System.Windows.Forms.RichTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.wlink = New System.Windows.Forms.TextBox()
        Me.wid = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.wname = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.sid = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'wdesc
        '
        Me.wdesc.Font = New System.Drawing.Font("Poor Richard", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wdesc.Location = New System.Drawing.Point(477, 335)
        Me.wdesc.Margin = New System.Windows.Forms.Padding(4)
        Me.wdesc.Name = "wdesc"
        Me.wdesc.Size = New System.Drawing.Size(742, 233)
        Me.wdesc.TabIndex = 0
        Me.wdesc.Text = ""
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(751, 778)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(182, 70)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "POST"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(1552, 1051)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(103, 33)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "home"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(531, 647)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 23)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "link"
        '
        'wlink
        '
        Me.wlink.Location = New System.Drawing.Point(780, 633)
        Me.wlink.Multiline = True
        Me.wlink.Name = "wlink"
        Me.wlink.Size = New System.Drawing.Size(403, 46)
        Me.wlink.TabIndex = 6
        '
        'wid
        '
        Me.wid.Location = New System.Drawing.Point(780, 139)
        Me.wid.Name = "wid"
        Me.wid.Size = New System.Drawing.Size(348, 30)
        Me.wid.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(523, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 23)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = " UNIQUE ID"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(1188, 139)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(106, 30)
        Me.Button4.TabIndex = 10
        Me.Button4.Text = "GEN"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Poor Richard", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(530, 235)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "TITTLE"
        '
        'wname
        '
        Me.wname.Font = New System.Drawing.Font("Poor Richard", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wname.Location = New System.Drawing.Point(780, 231)
        Me.wname.Margin = New System.Windows.Forms.Padding(4)
        Me.wname.Multiline = True
        Me.wname.Name = "wname"
        Me.wname.Size = New System.Drawing.Size(403, 44)
        Me.wname.TabIndex = 2
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(1367, 818)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(106, 30)
        Me.Button5.TabIndex = 11
        Me.Button5.Text = "home"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'sid
        '
        Me.sid.Location = New System.Drawing.Point(780, 77)
        Me.sid.Name = "sid"
        Me.sid.ReadOnly = True
        Me.sid.Size = New System.Drawing.Size(250, 30)
        Me.sid.TabIndex = 12
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1727, 1041)
        Me.Controls.Add(Me.sid)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.wid)
        Me.Controls.Add(Me.wlink)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.wname)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.wdesc)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Poor Richard", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form6"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form6"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents wdesc As System.Windows.Forms.RichTextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents wlink As System.Windows.Forms.TextBox
    Friend WithEvents wid As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents wname As System.Windows.Forms.TextBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents sid As System.Windows.Forms.TextBox
End Class

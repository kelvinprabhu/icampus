<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SEEWASSUPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FEEDSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BEANERDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JOINTHEFAMToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TELLUSWHATSNEWToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SHAREURPOSTSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CONTRIBUTETONERDSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PROFILEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ABOUTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OTHERSOPTIONSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DROPPOSTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BOOKSEARCHToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MYCORNERToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EXITToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SREG = New System.Windows.Forms.TextBox()
        Me.SNAME = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.stype = New System.Windows.Forms.TextBox()
        Me.JPG = New System.Windows.Forms.OpenFileDialog()
        Me.DESC = New System.Windows.Forms.RichTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ADMINCORNERToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.BackgroundImage = CType(resources.GetObject("MenuStrip1.BackgroundImage"), System.Drawing.Image)
        Me.MenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MenuStrip1.Font = New System.Drawing.Font("Lucida Handwriting", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SEEWASSUPToolStripMenuItem, Me.FEEDSToolStripMenuItem, Me.BEANERDToolStripMenuItem, Me.JOINTHEFAMToolStripMenuItem, Me.PROFILEToolStripMenuItem, Me.OTHERSOPTIONSToolStripMenuItem, Me.ABOUTToolStripMenuItem, Me.EXITToolStripMenuItem, Me.ADMINCORNERToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1848, 35)
        Me.MenuStrip1.Stretch = False
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SEEWASSUPToolStripMenuItem
        '
        Me.SEEWASSUPToolStripMenuItem.Image = CType(resources.GetObject("SEEWASSUPToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SEEWASSUPToolStripMenuItem.Name = "SEEWASSUPToolStripMenuItem"
        Me.SEEWASSUPToolStripMenuItem.Size = New System.Drawing.Size(211, 31)
        Me.SEEWASSUPToolStripMenuItem.Text = "SEE WASSUP    "
        '
        'FEEDSToolStripMenuItem
        '
        Me.FEEDSToolStripMenuItem.Image = CType(resources.GetObject("FEEDSToolStripMenuItem.Image"), System.Drawing.Image)
        Me.FEEDSToolStripMenuItem.Name = "FEEDSToolStripMenuItem"
        Me.FEEDSToolStripMenuItem.Size = New System.Drawing.Size(244, 31)
        Me.FEEDSToolStripMenuItem.Text = "LOOK AT FEEDS   "
        '
        'BEANERDToolStripMenuItem
        '
        Me.BEANERDToolStripMenuItem.Image = CType(resources.GetObject("BEANERDToolStripMenuItem.Image"), System.Drawing.Image)
        Me.BEANERDToolStripMenuItem.Name = "BEANERDToolStripMenuItem"
        Me.BEANERDToolStripMenuItem.Size = New System.Drawing.Size(182, 31)
        Me.BEANERDToolStripMenuItem.Text = "BE A NERD  "
        '
        'JOINTHEFAMToolStripMenuItem
        '
        Me.JOINTHEFAMToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TELLUSWHATSNEWToolStripMenuItem, Me.SHAREURPOSTSToolStripMenuItem, Me.CONTRIBUTETONERDSToolStripMenuItem})
        Me.JOINTHEFAMToolStripMenuItem.Image = CType(resources.GetObject("JOINTHEFAMToolStripMenuItem.Image"), System.Drawing.Image)
        Me.JOINTHEFAMToolStripMenuItem.Name = "JOINTHEFAMToolStripMenuItem"
        Me.JOINTHEFAMToolStripMenuItem.Size = New System.Drawing.Size(279, 31)
        Me.JOINTHEFAMToolStripMenuItem.Text = "JOIN THE FAMILY    "
        '
        'TELLUSWHATSNEWToolStripMenuItem
        '
        Me.TELLUSWHATSNEWToolStripMenuItem.Name = "TELLUSWHATSNEWToolStripMenuItem"
        Me.TELLUSWHATSNEWToolStripMenuItem.Size = New System.Drawing.Size(363, 32)
        Me.TELLUSWHATSNEWToolStripMenuItem.Text = "TELL US WHATS NEW"
        '
        'SHAREURPOSTSToolStripMenuItem
        '
        Me.SHAREURPOSTSToolStripMenuItem.Name = "SHAREURPOSTSToolStripMenuItem"
        Me.SHAREURPOSTSToolStripMenuItem.Size = New System.Drawing.Size(363, 32)
        Me.SHAREURPOSTSToolStripMenuItem.Text = "SHARE UR POSTS"
        '
        'CONTRIBUTETONERDSToolStripMenuItem
        '
        Me.CONTRIBUTETONERDSToolStripMenuItem.Name = "CONTRIBUTETONERDSToolStripMenuItem"
        Me.CONTRIBUTETONERDSToolStripMenuItem.Size = New System.Drawing.Size(363, 32)
        Me.CONTRIBUTETONERDSToolStripMenuItem.Text = "CONTRIBUTE TO NERDS"
        '
        'PROFILEToolStripMenuItem
        '
        Me.PROFILEToolStripMenuItem.Image = CType(resources.GetObject("PROFILEToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PROFILEToolStripMenuItem.Name = "PROFILEToolStripMenuItem"
        Me.PROFILEToolStripMenuItem.Size = New System.Drawing.Size(173, 31)
        Me.PROFILEToolStripMenuItem.Text = " PROFILE   "
        '
        'ABOUTToolStripMenuItem
        '
        Me.ABOUTToolStripMenuItem.Image = CType(resources.GetObject("ABOUTToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ABOUTToolStripMenuItem.Name = "ABOUTToolStripMenuItem"
        Me.ABOUTToolStripMenuItem.Size = New System.Drawing.Size(146, 31)
        Me.ABOUTToolStripMenuItem.Text = "ABOUT   "
        '
        'OTHERSOPTIONSToolStripMenuItem
        '
        Me.OTHERSOPTIONSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DROPPOSTToolStripMenuItem, Me.BOOKSEARCHToolStripMenuItem, Me.MYCORNERToolStripMenuItem})
        Me.OTHERSOPTIONSToolStripMenuItem.Image = CType(resources.GetObject("OTHERSOPTIONSToolStripMenuItem.Image"), System.Drawing.Image)
        Me.OTHERSOPTIONSToolStripMenuItem.Name = "OTHERSOPTIONSToolStripMenuItem"
        Me.OTHERSOPTIONSToolStripMenuItem.Size = New System.Drawing.Size(270, 31)
        Me.OTHERSOPTIONSToolStripMenuItem.Text = "OTHERS OPTIONS   "
        '
        'DROPPOSTToolStripMenuItem
        '
        Me.DROPPOSTToolStripMenuItem.Name = "DROPPOSTToolStripMenuItem"
        Me.DROPPOSTToolStripMenuItem.Size = New System.Drawing.Size(333, 32)
        Me.DROPPOSTToolStripMenuItem.Text = "DROP\SEARCH POSTS"
        '
        'BOOKSEARCHToolStripMenuItem
        '
        Me.BOOKSEARCHToolStripMenuItem.Name = "BOOKSEARCHToolStripMenuItem"
        Me.BOOKSEARCHToolStripMenuItem.Size = New System.Drawing.Size(333, 32)
        Me.BOOKSEARCHToolStripMenuItem.Text = "BOOK SEARCH"
        '
        'MYCORNERToolStripMenuItem
        '
        Me.MYCORNERToolStripMenuItem.Name = "MYCORNERToolStripMenuItem"
        Me.MYCORNERToolStripMenuItem.Size = New System.Drawing.Size(333, 32)
        Me.MYCORNERToolStripMenuItem.Text = "MY CORNER"
        '
        'EXITToolStripMenuItem
        '
        Me.EXITToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.EXITToolStripMenuItem.Image = CType(resources.GetObject("EXITToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EXITToolStripMenuItem.Name = "EXITToolStripMenuItem"
        Me.EXITToolStripMenuItem.Size = New System.Drawing.Size(110, 31)
        Me.EXITToolStripMenuItem.Text = "EXIT  "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Papyrus", 19.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(48, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(968, 52)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = """If you don't like the road you're walking, start paving another one."""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Papyrus", 19.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(1351, 895)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(313, 52)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = """Keep looking up…"
        '
        'SREG
        '
        Me.SREG.Font = New System.Drawing.Font("Poor Richard", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SREG.Location = New System.Drawing.Point(821, 666)
        Me.SREG.Name = "SREG"
        Me.SREG.ReadOnly = True
        Me.SREG.Size = New System.Drawing.Size(297, 45)
        Me.SREG.TabIndex = 3
        Me.SREG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.SREG.Visible = False
        '
        'SNAME
        '
        Me.SNAME.Font = New System.Drawing.Font("Poor Richard", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SNAME.Location = New System.Drawing.Point(731, 441)
        Me.SNAME.Name = "SNAME"
        Me.SNAME.ReadOnly = True
        Me.SNAME.Size = New System.Drawing.Size(481, 45)
        Me.SNAME.TabIndex = 4
        Me.SNAME.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.SNAME.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(867, 168)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(206, 252)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'stype
        '
        Me.stype.Font = New System.Drawing.Font("Poor Richard", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stype.Location = New System.Drawing.Point(851, 745)
        Me.stype.Name = "stype"
        Me.stype.ReadOnly = True
        Me.stype.Size = New System.Drawing.Size(235, 45)
        Me.stype.TabIndex = 6
        Me.stype.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.stype.Visible = False
        '
        'JPG
        '
        Me.JPG.Filter = "image file*|*.jpg"
        '
        'DESC
        '
        Me.DESC.Font = New System.Drawing.Font("Poor Richard", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DESC.Location = New System.Drawing.Point(699, 510)
        Me.DESC.Name = "DESC"
        Me.DESC.Size = New System.Drawing.Size(547, 103)
        Me.DESC.TabIndex = 7
        Me.DESC.Text = ""
        Me.DESC.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Poor Richard", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(482, 185)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 23)
        Me.Label3.TabIndex = 8
        Me.Label3.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(-15, -15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 17)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Label4"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(137, 423)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(1578, 1168)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = resources.GetString("Label5.Text")
        Me.Label5.Visible = False
        '
        'ADMINCORNERToolStripMenuItem
        '
        Me.ADMINCORNERToolStripMenuItem.Name = "ADMINCORNERToolStripMenuItem"
        Me.ADMINCORNERToolStripMenuItem.Size = New System.Drawing.Size(212, 31)
        Me.ADMINCORNERToolStripMenuItem.Text = "ADMIN CORNER"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1869, 1023)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DESC)
        Me.Controls.Add(Me.stype)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.SNAME)
        Me.Controls.Add(Me.SREG)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.ForeColor = System.Drawing.SystemColors.Control
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form3"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents SEEWASSUPToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FEEDSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BEANERDToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents JOINTHEFAMToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TELLUSWHATSNEWToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SHAREURPOSTSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CONTRIBUTETONERDSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EXITToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ABOUTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PROFILEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SREG As System.Windows.Forms.TextBox
    Friend WithEvents SNAME As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents stype As System.Windows.Forms.TextBox
    Friend WithEvents JPG As System.Windows.Forms.OpenFileDialog
    Friend WithEvents DESC As System.Windows.Forms.RichTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents OTHERSOPTIONSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DROPPOSTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BOOKSEARCHToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MYCORNERToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ADMINCORNERToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form14
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
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.UsernameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UseridDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UseremailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsertypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UdescDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProfilephotoDataGridViewImageColumn = New System.Windows.Forms.DataGridViewImageColumn()
        Me.UserdetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IcampusDataSet7 = New WindowsApplication1.icampusDataSet7()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.User_detailsTableAdapter = New WindowsApplication1.icampusDataSet7TableAdapters.user_detailsTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserdetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IcampusDataSet7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UsernameDataGridViewTextBoxColumn, Me.UseridDataGridViewTextBoxColumn, Me.UseremailDataGridViewTextBoxColumn, Me.UsertypeDataGridViewTextBoxColumn, Me.UdescDataGridViewTextBoxColumn, Me.ProfilephotoDataGridViewImageColumn})
        Me.DataGridView1.DataSource = Me.UserdetailsBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1924, 1055)
        Me.DataGridView1.TabIndex = 0
        '
        'UsernameDataGridViewTextBoxColumn
        '
        Me.UsernameDataGridViewTextBoxColumn.DataPropertyName = "username"
        Me.UsernameDataGridViewTextBoxColumn.FillWeight = 200.0!
        Me.UsernameDataGridViewTextBoxColumn.HeaderText = "username"
        Me.UsernameDataGridViewTextBoxColumn.MinimumWidth = 200
        Me.UsernameDataGridViewTextBoxColumn.Name = "UsernameDataGridViewTextBoxColumn"
        Me.UsernameDataGridViewTextBoxColumn.Width = 200
        '
        'UseridDataGridViewTextBoxColumn
        '
        Me.UseridDataGridViewTextBoxColumn.DataPropertyName = "userid"
        Me.UseridDataGridViewTextBoxColumn.FillWeight = 200.0!
        Me.UseridDataGridViewTextBoxColumn.HeaderText = "userid"
        Me.UseridDataGridViewTextBoxColumn.MinimumWidth = 200
        Me.UseridDataGridViewTextBoxColumn.Name = "UseridDataGridViewTextBoxColumn"
        Me.UseridDataGridViewTextBoxColumn.Width = 200
        '
        'UseremailDataGridViewTextBoxColumn
        '
        Me.UseremailDataGridViewTextBoxColumn.DataPropertyName = "useremail"
        Me.UseremailDataGridViewTextBoxColumn.FillWeight = 200.0!
        Me.UseremailDataGridViewTextBoxColumn.HeaderText = "useremail"
        Me.UseremailDataGridViewTextBoxColumn.MinimumWidth = 200
        Me.UseremailDataGridViewTextBoxColumn.Name = "UseremailDataGridViewTextBoxColumn"
        Me.UseremailDataGridViewTextBoxColumn.Width = 200
        '
        'UsertypeDataGridViewTextBoxColumn
        '
        Me.UsertypeDataGridViewTextBoxColumn.DataPropertyName = "usertype"
        Me.UsertypeDataGridViewTextBoxColumn.FillWeight = 200.0!
        Me.UsertypeDataGridViewTextBoxColumn.HeaderText = "usertype"
        Me.UsertypeDataGridViewTextBoxColumn.MinimumWidth = 200
        Me.UsertypeDataGridViewTextBoxColumn.Name = "UsertypeDataGridViewTextBoxColumn"
        Me.UsertypeDataGridViewTextBoxColumn.Width = 200
        '
        'UdescDataGridViewTextBoxColumn
        '
        Me.UdescDataGridViewTextBoxColumn.DataPropertyName = "udesc"
        Me.UdescDataGridViewTextBoxColumn.FillWeight = 300.0!
        Me.UdescDataGridViewTextBoxColumn.HeaderText = "udesc"
        Me.UdescDataGridViewTextBoxColumn.MinimumWidth = 300
        Me.UdescDataGridViewTextBoxColumn.Name = "UdescDataGridViewTextBoxColumn"
        Me.UdescDataGridViewTextBoxColumn.Width = 300
        '
        'ProfilephotoDataGridViewImageColumn
        '
        Me.ProfilephotoDataGridViewImageColumn.DataPropertyName = "profilephoto"
        Me.ProfilephotoDataGridViewImageColumn.FillWeight = 400.0!
        Me.ProfilephotoDataGridViewImageColumn.HeaderText = "profilephoto"
        Me.ProfilephotoDataGridViewImageColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
        Me.ProfilephotoDataGridViewImageColumn.MinimumWidth = 400
        Me.ProfilephotoDataGridViewImageColumn.Name = "ProfilephotoDataGridViewImageColumn"
        Me.ProfilephotoDataGridViewImageColumn.Width = 400
        '
        'UserdetailsBindingSource
        '
        Me.UserdetailsBindingSource.DataMember = "user_details"
        Me.UserdetailsBindingSource.DataSource = Me.IcampusDataSet7
        '
        'IcampusDataSet7
        '
        Me.IcampusDataSet7.DataSetName = "icampusDataSet7"
        Me.IcampusDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LinkLabel1.Font = New System.Drawing.Font("Modern No. 20", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(0, 1025)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(88, 30)
        Me.LinkLabel1.TabIndex = 1
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "BACK"
        '
        'User_detailsTableAdapter
        '
        Me.User_detailsTableAdapter.ClearBeforeFill = True
        '
        'Form14
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1924, 1055)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form14"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form14"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserdetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IcampusDataSet7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents IcampusDataSet7 As WindowsApplication1.icampusDataSet7
    Friend WithEvents UserdetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents User_detailsTableAdapter As WindowsApplication1.icampusDataSet7TableAdapters.user_detailsTableAdapter
    Friend WithEvents UsernameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UseridDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UseremailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UsertypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UdescDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProfilephotoDataGridViewImageColumn As System.Windows.Forms.DataGridViewImageColumn
End Class

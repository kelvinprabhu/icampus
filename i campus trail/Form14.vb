Public Class Form14

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Form13.Show()
        Me.Hide()

    End Sub

    Private Sub Form14_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'IcampusDataSet7.user_details' table. You can move, or remove it, as needed.
        DataGridView1.RowTemplate.Height = 500
        Me.User_detailsTableAdapter.Fill(Me.IcampusDataSet7.user_details)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridView
            row = Me.DataGridView1
        End If
    End Sub
End Class
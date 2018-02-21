Public Class Grupe

    Private Sub Grupe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OrganizacijaTurniraDataSet1.GRUPA_B' table. You can move, or remove it, as needed.
        Me.GRUPA_BTableAdapter.Fill(Me.OrganizacijaTurniraDataSet1.GRUPA_B)
        'TODO: This line of code loads data into the 'OrganizacijaTurniraDataSet1.GRUPA_A' table. You can move, or remove it, as needed.
        Me.GRUPA_ATableAdapter.Fill(Me.OrganizacijaTurniraDataSet1.GRUPA_A)

    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.GRUPA_ATableAdapter.FillBy(Me.OrganizacijaTurniraDataSet1.GRUPA_A)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillByToolStripButton1_Click(sender As Object, e As EventArgs)
        Try
            Me.GRUPA_BTableAdapter.FillBy(Me.OrganizacijaTurniraDataSet1.GRUPA_B)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillBy1ToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.GRUPA_BTableAdapter.FillBy1(Me.OrganizacijaTurniraDataSet1.GRUPA_B)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillByToolStrip_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles FillByToolStrip.ItemClicked

    End Sub
End Class
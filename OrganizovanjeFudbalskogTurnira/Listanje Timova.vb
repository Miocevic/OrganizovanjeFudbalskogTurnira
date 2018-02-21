Public Class Listanje_Timova

    Private Sub Listanje_Timova_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OrganizacijaTurniraDataSet1.TIMOVI' table. You can move, or remove it, as needed.
        Me.TIMOVITableAdapter.Fill(Me.OrganizacijaTurniraDataSet1.TIMOVI)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim cmd As SqlClient.SqlCommand
        Dim conn As SqlClient.SqlConnection
        Dim strConn As String
        strConn = "Data Source=MIOCHEVIC;Initial Catalog=OrganizacijaTurnira;Integrated Security=True"
        conn = New SqlClient.SqlConnection(strConn)
        conn.Open()
        cmd = New SqlClient.SqlCommand()
        cmd.CommandText = "select NazivTima From TIMOVI"
        cmd.CommandType = CommandType.Text
        cmd.Connection = conn
        Dim source As New BindingSource
        source.DataSource = cmd.ExecuteReader
        DataGridView1.DataSource = source
        conn.Close()

    End Sub
End Class
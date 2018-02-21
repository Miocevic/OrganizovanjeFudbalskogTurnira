Public Class POBEDNIK


    Private Sub POBEDNIK_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OrganizacijaTurniraDataSet11.POLUFINALE' table. You can move, or remove it, as needed.
        Me.POLUFINALETableAdapter.Fill(Me.OrganizacijaTurniraDataSet11.POLUFINALE)
        Dim cmd As SqlClient.SqlCommand
        Dim conn As SqlClient.SqlConnection
        Dim strConn As String
        strConn = "Data Source=MIOCHEVIC;Initial Catalog=OrganizacijaTurnira;Integrated Security=True"
        conn = New SqlClient.SqlConnection(strConn)
        conn.Open()
        cmd = New SqlClient.SqlCommand()
        cmd.CommandText = "select TOP 1 (NazivTima) From POLUFINALE order by BrojBodova DESC"
        cmd.CommandType = CommandType.Text
        cmd.Connection = conn
        Dim source As New BindingSource
        source.DataSource = cmd.ExecuteReader
        DataGridView1.DataSource = source
        conn.Close()
    End Sub


End Class
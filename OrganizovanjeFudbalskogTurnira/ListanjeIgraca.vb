Public Class ListanjeIgraca

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cmd As SqlClient.SqlCommand
        Dim conn As SqlClient.SqlConnection
        Dim strConn As String
        strConn = "Data Source=MIOCHEVIC;Initial Catalog=OrganizacijaTurnira;Integrated Security=True"
        conn = New SqlClient.SqlConnection(strConn)
        conn.Open()
        cmd = New SqlClient.SqlCommand()


        cmd.CommandText = "select ImeIgraca,PrezimeIgraca,GodineIgraca From IGRACI where id_igraca IN (select id_igraca from " + ComboBox1.Text + ")"
        cmd.CommandType = CommandType.Text
        cmd.Connection = conn
        Dim source As New BindingSource
        source.DataSource = cmd.ExecuteReader
        DataGridView1.DataSource = source
        conn.Close()
    End Sub

    Private Sub ListanjeIgraca_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OrganizacijaTurniraDataSet1.TIMOVI' table. You can move, or remove it, as needed.
        Me.TIMOVITableAdapter.Fill(Me.OrganizacijaTurniraDataSet1.TIMOVI)

    End Sub
End Class
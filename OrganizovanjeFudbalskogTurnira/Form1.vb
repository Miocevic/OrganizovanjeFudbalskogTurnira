Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Listanje_Timova.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListanjeIgraca.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        BiranjeGrupa.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Grupe.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Rezultati.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Polufinale.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        POBEDNIK.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dim cmd As SqlClient.SqlCommand
        Dim conn As SqlClient.SqlConnection
        Dim strConn As String
        strConn = "Data Source=MIOCHEVIC;Initial Catalog=OrganizacijaTurnira;Integrated Security=True"
        conn = New SqlClient.SqlConnection(strConn)
        conn.Open()
        cmd = New SqlClient.SqlCommand()
        cmd.CommandText = "DELETE FROM GRUPA_A"
        cmd.CommandType = CommandType.Text
        cmd.Connection = conn
        Dim source As New BindingSource
        source.DataSource = cmd.ExecuteReader
        conn.Close()

        conn.Open()
        cmd = New SqlClient.SqlCommand()
        cmd.CommandText = "DELETE FROM GRUPA_B"
        cmd.CommandType = CommandType.Text
        cmd.Connection = conn
        source.DataSource = cmd.ExecuteReader
        conn.Close()

        conn.Open()
        cmd = New SqlClient.SqlCommand()
        cmd.CommandText = "DELETE FROM POLUFINALE"
        cmd.CommandType = CommandType.Text
        cmd.Connection = conn
        source.DataSource = cmd.ExecuteReader
        conn.Close()


    End Sub
End Class

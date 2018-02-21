Public Class Polufinale
    Dim status1 As Integer
    Dim status2 As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim t1 As Integer
        Dim t2 As Integer
        Dim t3 As Integer
        Dim t4 As Integer
       
        t1 = Int(TextBox1.Text)
        t2 = Int(TextBox2.Text)
        t3 = Int(TextBox3.Text)
        t4 = Int(TextBox4.Text)

        Dim cmd As SqlClient.SqlCommand
        Dim conn As SqlClient.SqlConnection
        Dim strConn As String
        strConn = "Data Source=MIOCHEVIC;Initial Catalog=OrganizacijaTurnira;Integrated Security=True"
        conn = New SqlClient.SqlConnection(strConn)


        If (t1 > t2) Then
            status1 = 1
            conn.Open()
            cmd = New SqlClient.SqlCommand()
            cmd.CommandText = "Update POLUFINALE set BrojBodova=3 WHERE id_poz = (Select min(id_poz) from POLUFINALE)"
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn
            Dim source As New BindingSource
            source.DataSource = cmd.ExecuteReader
            conn.Close()

            conn.Open()
            cmd = New SqlClient.SqlCommand()
            cmd.CommandText = "Update POLUFINALE set BrojBodova=0 WHERE id_poz = (Select min(id_poz)+3 from POLUFINALE)"
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn
            Dim source2 As New BindingSource
            source2.DataSource = cmd.ExecuteReader
            conn.Close()

            conn.Open()
            cmd.CommandText = "Select NazivTima from TIMOVI where id_tima=(SELECT id_tima from POLUFINALE where id_poz=(select min(id_poz) from POLUFINALE))"
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn
            Label6.Text = Trim((cmd.ExecuteScalar()))
            conn.Close()

        Else
            status1 = 0
            conn.Open()
            cmd = New SqlClient.SqlCommand()
            cmd.CommandText = "Update POLUFINALE set BrojBodova=3 WHERE id_poz = (Select min(id_poz)+3 from POLUFINALE)"
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn
            Dim source As New BindingSource
            source.DataSource = cmd.ExecuteReader
            conn.Close()

            conn.Open()
            cmd = New SqlClient.SqlCommand()
            cmd.CommandText = "Update POLUFINALE set BrojBodova=0 WHERE id_poz = (Select min(id_poz) from POLUFINALE)"
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn
            Dim source2 As New BindingSource
            source2.DataSource = cmd.ExecuteReader
            conn.Close()

            conn.Open()
            cmd.CommandText = "Select NazivTima from TIMOVI where id_tima=(SELECT id_tima from POLUFINALE where id_poz=(select min(id_poz)+3 from POLUFINALE))"
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn
            Label6.Text = Trim((cmd.ExecuteScalar()))
            conn.Close()


        End If

        If (t3 > t4) Then
            status2 = 1
            conn.Open()
            cmd = New SqlClient.SqlCommand()
            cmd.CommandText = "Update POLUFINALE set BrojBodova=3 WHERE id_poz = (Select min(id_poz)+2 from POLUFINALE)"
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn
            Dim source As New BindingSource
            source.DataSource = cmd.ExecuteReader
            conn.Close()

            conn.Open()
            cmd = New SqlClient.SqlCommand()
            cmd.CommandText = "Update POLUFINALE set BrojBodova=0 WHERE id_poz = (Select min(id_poz)+1 from POLUFINALE)"
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn
            Dim source2 As New BindingSource
            source2.DataSource = cmd.ExecuteReader
            conn.Close()

            conn.Open()
            cmd.CommandText = "Select NazivTima from TIMOVI where id_tima=(SELECT id_tima from POLUFINALE where id_poz=(select min(id_poz)+2 from POLUFINALE))"
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn
            Label7.Text = Trim((cmd.ExecuteScalar()))
            conn.Close()


        Else
            status2 = 0
            conn.Open()
            cmd = New SqlClient.SqlCommand()
            cmd.CommandText = "Update POLUFINALE set BrojBodova=3 WHERE id_poz = (Select min(id_poz)+1 from POLUFINALE)"
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn
            Dim source As New BindingSource
            source.DataSource = cmd.ExecuteReader
            conn.Close()

            conn.Open()
            cmd = New SqlClient.SqlCommand()
            cmd.CommandText = "Update POLUFINALE set BrojBodova=0 WHERE id_poz = (Select min(id_poz)+2 from POLUFINALE)"
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn
            Dim source2 As New BindingSource
            source2.DataSource = cmd.ExecuteReader
            conn.Close()

            conn.Open()
            cmd.CommandText = "Select NazivTima from TIMOVI where id_tima=(SELECT id_tima from POLUFINALE where id_poz=(select min(id_poz)+1 from POLUFINALE))"
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn
            Label7.Text = Trim((cmd.ExecuteScalar()))
            conn.Close()


        End If

    End Sub

    Private Sub Polufinale_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cmd1 As SqlClient.SqlCommand
        Dim conn1 As SqlClient.SqlConnection
        Dim strConn1 As String
        strConn1 = "Data Source=MIOCHEVIC;Initial Catalog=OrganizacijaTurnira;Integrated Security=True"
        conn1 = New SqlClient.SqlConnection(strConn1)
        conn1.Open()
        cmd1 = New SqlClient.SqlCommand()
        cmd1.CommandText = "Select NazivTima from TIMOVI where id_tima=(SELECT id_tima from POLUFINALE where id_poz=(select min(id_poz) from POLUFINALE))"
        cmd1.CommandType = CommandType.Text
        cmd1.Connection = conn1
        Label1.Text = Trim((cmd1.ExecuteScalar()))

        cmd1.CommandText = "Select NazivTima from TIMOVI where id_tima=(SELECT id_tima from POLUFINALE where id_poz=(select min(id_poz)+3 from POLUFINALE))"
        cmd1.CommandType = CommandType.Text
        cmd1.Connection = conn1
        Label2.Text = Trim((cmd1.ExecuteScalar()))

        cmd1.CommandText = "Select NazivTima from TIMOVI where id_tima=(SELECT id_tima from POLUFINALE where id_poz=(select min(id_poz)+2 from POLUFINALE))"
        cmd1.CommandType = CommandType.Text
        cmd1.Connection = conn1
        Label3.Text = Trim((cmd1.ExecuteScalar()))

        cmd1.CommandText = "Select NazivTima from TIMOVI where id_tima=(SELECT id_tima from POLUFINALE where id_poz=(select min(id_poz)+1 from POLUFINALE))"
        cmd1.CommandType = CommandType.Text
        cmd1.Connection = conn1
        Label4.Text = Trim((cmd1.ExecuteScalar()))


        conn1.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim t5 As Integer
        Dim t6 As Integer
        Dim status1 As Integer
        Dim status2 As Integer
        t5 = Int(TextBox5.Text)
        t6 = Int(TextBox6.Text)

        Dim cmd As SqlClient.SqlCommand
        Dim conn As SqlClient.SqlConnection
        Dim strConn As String
        strConn = "Data Source=MIOCHEVIC;Initial Catalog=OrganizacijaTurnira;Integrated Security=True"
        conn = New SqlClient.SqlConnection(strConn)


        If (t5 > t6) Then
            If (status1) Then
                conn.Open()
                cmd = New SqlClient.SqlCommand()
                cmd.CommandText = "Update POLUFINALE set BrojBodova=BrojBodova+3 WHERE id_poz = (Select min(id_poz) from POLUFINALE)"
                cmd.CommandType = CommandType.Text
                cmd.Connection = conn
                Dim source As New BindingSource
                source.DataSource = cmd.ExecuteReader
                conn.Close()
            Else
                conn.Open()
                cmd = New SqlClient.SqlCommand()
                cmd.CommandText = "Update POLUFINALE set BrojBodova=BrojBodova+3 WHERE id_poz = (Select min(id_poz)+3 from POLUFINALE)"
                cmd.CommandType = CommandType.Text
                cmd.Connection = conn
                Dim source As New BindingSource
                source.DataSource = cmd.ExecuteReader
                conn.Close()
            End If
        Else
            If (status2) Then
                conn.Open()
                cmd = New SqlClient.SqlCommand()
                cmd.CommandText = "Update POLUFINALE set BrojBodova=BrojBodova+3 WHERE id_poz = (Select min(id_poz)+2 from POLUFINALE)"
                cmd.CommandType = CommandType.Text
                cmd.Connection = conn
                Dim source As New BindingSource
                source.DataSource = cmd.ExecuteReader
                conn.Close()
            Else
                conn.Open()
                cmd = New SqlClient.SqlCommand()
                cmd.CommandText = "Update POLUFINALE set BrojBodova=BrojBodova+3 WHERE id_poz = (Select min(id_poz)+1 from POLUFINALE)"
                cmd.CommandType = CommandType.Text
                cmd.Connection = conn
                Dim source2 As New BindingSource
                source2.DataSource = cmd.ExecuteReader
                conn.Close()

            End If
        End If
        Me.Hide()
    End Sub
End Class
Public Class Rezultati

    Private Sub Rezultati_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim cmd1 As SqlClient.SqlCommand
        Dim conn1 As SqlClient.SqlConnection
        Dim strConn1 As String
        strConn1 = "Data Source=MIOCHEVIC;Initial Catalog=OrganizacijaTurnira;Integrated Security=True"
        conn1 = New SqlClient.SqlConnection(strConn1)
        conn1.Open()
        cmd1 = New SqlClient.SqlCommand()
        cmd1.CommandText = "Select NazivTima from TIMOVI where id_tima=(SELECT id_tima from GRUPA_A where id_tima=(select min(id_tima) from GRUPA_A))"
        cmd1.CommandType = CommandType.Text
        cmd1.Connection = conn1
        Label3.Text = Trim((cmd1.ExecuteScalar()))

        cmd1.CommandText = "Select NazivTima from TIMOVI where id_tima=(SELECT id_tima from GRUPA_A where id_poz=(select min(id_poz)+1 from GRUPA_A))"
        cmd1.CommandType = CommandType.Text
        cmd1.Connection = conn1
        Label4.Text = Trim((cmd1.ExecuteScalar()))

        cmd1.CommandText = "Select NazivTima from TIMOVI where id_tima=(SELECT id_tima from GRUPA_A where id_poz=(select min(id_poz) from GRUPA_A))"
        cmd1.CommandType = CommandType.Text
        cmd1.Connection = conn1
        Label5.Text = Trim((cmd1.ExecuteScalar()))

        cmd1.CommandText = "Select NazivTima from TIMOVI where id_tima=(SELECT id_tima from GRUPA_A where id_poz=(select min(id_poz)+2 from GRUPA_A))"
        cmd1.CommandType = CommandType.Text
        cmd1.Connection = conn1
        Label6.Text = Trim((cmd1.ExecuteScalar()))

        cmd1.CommandText = "Select NazivTima from TIMOVI where id_tima=(SELECT id_tima from GRUPA_A where id_poz=(select min(id_poz) from GRUPA_A))"
        cmd1.CommandType = CommandType.Text
        cmd1.Connection = conn1
        Label7.Text = Trim((cmd1.ExecuteScalar()))

        cmd1.CommandText = "Select NazivTima from TIMOVI where id_tima=(SELECT id_tima from GRUPA_A where id_poz=(select min(id_poz)+3 from GRUPA_A))"
        cmd1.CommandType = CommandType.Text
        cmd1.Connection = conn1
        Label8.Text = Trim((cmd1.ExecuteScalar()))

        cmd1.CommandText = "Select NazivTima from TIMOVI where id_tima=(SELECT id_tima from GRUPA_A where id_poz=(select min(id_poz)+1 from GRUPA_A))"
        cmd1.CommandType = CommandType.Text
        cmd1.Connection = conn1
        Label9.Text = Trim((cmd1.ExecuteScalar()))

        cmd1.CommandText = "Select NazivTima from TIMOVI where id_tima=(SELECT id_tima from GRUPA_A where id_poz=(select min(id_poz)+2 from GRUPA_A))"
        cmd1.CommandType = CommandType.Text
        cmd1.Connection = conn1
        Label10.Text = Trim((cmd1.ExecuteScalar()))

        cmd1.CommandText = "Select NazivTima from TIMOVI where id_tima=(SELECT id_tima from GRUPA_A where id_poz=(select min(id_poz)+1 from GRUPA_A))"
        cmd1.CommandType = CommandType.Text
        cmd1.Connection = conn1
        Label11.Text = Trim((cmd1.ExecuteScalar()))

        cmd1.CommandText = "Select NazivTima from TIMOVI where id_tima=(SELECT id_tima from GRUPA_A where id_poz=(select min(id_poz)+3 from GRUPA_A))"
        cmd1.CommandType = CommandType.Text
        cmd1.Connection = conn1
        Label12.Text = Trim((cmd1.ExecuteScalar()))

        cmd1.CommandText = "Select NazivTima from TIMOVI where id_tima=(SELECT id_tima from GRUPA_A where id_poz=(select min(id_poz)+2 from GRUPA_A))"
        cmd1.CommandType = CommandType.Text
        cmd1.Connection = conn1
        Label13.Text = Trim((cmd1.ExecuteScalar()))

        cmd1.CommandText = "Select NazivTima from TIMOVI where id_tima=(SELECT id_tima from GRUPA_A where id_poz=(select min(id_poz)+3 from GRUPA_A))"
        cmd1.CommandType = CommandType.Text
        cmd1.Connection = conn1
        Label14.Text = Trim((cmd1.ExecuteScalar()))

        cmd1.CommandText = "Select NazivTima from TIMOVI where id_tima=(SELECT id_tima from GRUPA_B where id_poz=(select min(id_poz) from GRUPA_B))"
        cmd1.CommandType = CommandType.Text
        cmd1.Connection = conn1
        Label15.Text = Trim((cmd1.ExecuteScalar()))

        cmd1.CommandText = "Select NazivTima from TIMOVI where id_tima=(SELECT id_tima from GRUPA_B where id_poz=(select min(id_poz)+1 from GRUPA_B))"
        cmd1.CommandType = CommandType.Text
        cmd1.Connection = conn1
        Label16.Text = Trim((cmd1.ExecuteScalar()))

        cmd1.CommandText = "Select NazivTima from TIMOVI where id_tima=(SELECT id_tima from GRUPA_B where id_poz=(select min(id_poz) from GRUPA_B))"
        cmd1.CommandType = CommandType.Text
        cmd1.Connection = conn1
        Label17.Text = Trim((cmd1.ExecuteScalar()))

        cmd1.CommandText = "Select NazivTima from TIMOVI where id_tima=(SELECT id_tima from GRUPA_B where id_poz=(select min(id_poz)+2 from GRUPA_B))"
        cmd1.CommandType = CommandType.Text
        cmd1.Connection = conn1
        Label18.Text = Trim((cmd1.ExecuteScalar()))

        cmd1.CommandText = "Select NazivTima from TIMOVI where id_tima=(SELECT id_tima from GRUPA_B where id_poz=(select min(id_poz) from GRUPA_B))"
        cmd1.CommandType = CommandType.Text
        cmd1.Connection = conn1
        Label19.Text = Trim((cmd1.ExecuteScalar()))

        cmd1.CommandText = "Select NazivTima from TIMOVI where id_tima=(SELECT id_tima from GRUPA_B where id_poz=(select min(id_poz)+3 from GRUPA_B))"
        cmd1.CommandType = CommandType.Text
        cmd1.Connection = conn1
        Label20.Text = Trim((cmd1.ExecuteScalar()))

        cmd1.CommandText = "Select NazivTima from TIMOVI where id_tima=(SELECT id_tima from GRUPA_B where id_poz=(select min(id_poz)+1 from GRUPA_B))"
        cmd1.CommandType = CommandType.Text
        cmd1.Connection = conn1
        Label21.Text = Trim((cmd1.ExecuteScalar()))

        cmd1.CommandText = "Select NazivTima from TIMOVI where id_tima=(SELECT id_tima from GRUPA_B where id_poz=(select min(id_poz)+2 from GRUPA_B))"
        cmd1.CommandType = CommandType.Text
        cmd1.Connection = conn1
        Label22.Text = Trim((cmd1.ExecuteScalar()))

        cmd1.CommandText = "Select NazivTima from TIMOVI where id_tima=(SELECT id_tima from GRUPA_B where id_poz=(select min(id_poz)+1 from GRUPA_B))"
        cmd1.CommandType = CommandType.Text
        cmd1.Connection = conn1
        Label23.Text = Trim((cmd1.ExecuteScalar()))

        cmd1.CommandText = "Select NazivTima from TIMOVI where id_tima=(SELECT id_tima from GRUPA_B where id_poz=(select min(id_poz)+3 from GRUPA_B))"
        cmd1.CommandType = CommandType.Text
        cmd1.Connection = conn1
        Label24.Text = Trim((cmd1.ExecuteScalar()))

        cmd1.CommandText = "Select NazivTima from TIMOVI where id_tima=(SELECT id_tima from GRUPA_B where id_poz=(select min(id_poz)+2 from GRUPA_B))"
        cmd1.CommandType = CommandType.Text
        cmd1.Connection = conn1
        Label25.Text = Trim((cmd1.ExecuteScalar()))

        cmd1.CommandText = "Select NazivTima from TIMOVI where id_tima=(SELECT id_tima from GRUPA_B where id_poz=(select min(id_poz)+3 from GRUPA_B))"
        cmd1.CommandType = CommandType.Text
        cmd1.Connection = conn1
        Label26.Text = Trim((cmd1.ExecuteScalar()))


        conn1.Close()





    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim t1 As Integer
        Dim t2 As Integer
        Dim t3 As Integer
        Dim t4 As Integer
        Dim t5 As Integer
        Dim t6 As Integer
        Dim t7 As Integer
        Dim t8 As Integer
        Dim t9 As Integer
        Dim t10 As Integer
        Dim t11 As Integer
        Dim t12 As Integer
        Dim t13 As Integer
        Dim t14 As Integer
        Dim t15 As Integer
        Dim t16 As Integer
        Dim t17 As Integer
        Dim t18 As Integer
        Dim t19 As Integer
        Dim t20 As Integer
        Dim t21 As Integer
        Dim t22 As Integer
        Dim t23 As Integer
        Dim t24 As Integer

        t1 = Int(TextBox1.Text)
        t2 = Int(TextBox2.Text)
        t3 = Int(TextBox3.Text)
        t4 = Int(TextBox4.Text)
        t5 = Int(TextBox5.Text)
        t6 = Int(TextBox6.Text)
        t7 = Int(TextBox7.Text)
        t8 = Int(TextBox8.Text)
        t9 = Int(TextBox9.Text)
        t10 = Int(TextBox10.Text)
        t11 = Int(TextBox11.Text)
        t12 = Int(TextBox12.Text)
        t13 = Int(TextBox13.Text)
        t14 = Int(TextBox14.Text)
        t15 = Int(TextBox15.Text)
        t16 = Int(TextBox16.Text)
        t17 = Int(TextBox17.Text)
        t18 = Int(TextBox18.Text)
        t19 = Int(TextBox19.Text)
        t20 = Int(TextBox20.Text)
        t21 = Int(TextBox21.Text)
        t22 = Int(TextBox22.Text)
        t23 = Int(TextBox23.Text)
        t24 = Int(TextBox24.Text)
        Dim cmd As SqlClient.SqlCommand
        Dim conn As SqlClient.SqlConnection
        Dim strConn As String
        strConn = "Data Source=MIOCHEVIC;Initial Catalog=OrganizacijaTurnira;Integrated Security=True"
        conn = New SqlClient.SqlConnection(strConn)

        If (t1 > t2) Then
            conn.Open()
            cmd = New SqlClient.SqlCommand()
            cmd.CommandText = "Update GRUPA_A set BrojBodova=BrojBodova+3 WHERE id_poz = (Select min(id_poz) from GRUPA_A)"
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn
            Dim source As New BindingSource
            source.DataSource = cmd.ExecuteReader
            conn.Close()
        ElseIf (t2 > t1) Then
            conn.Open()
            cmd = New SqlClient.SqlCommand()
            cmd.CommandText = "Update GRUPA_A set BrojBodova=BrojBodova+3 WHERE id_poz = (Select min(id_poz)+1 from GRUPA_A)"
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn
            Dim source As New BindingSource
            source.DataSource = cmd.ExecuteReader
            conn.Close()
        Else
            conn.Open()
            cmd = New SqlClient.SqlCommand()
            cmd.CommandText = "Update GRUPA_A set BrojBodova=BrojBodova+1 WHERE id_poz = (Select min(id_poz) from GRUPA_A)"
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn
            Dim source As New BindingSource
            source.DataSource = cmd.ExecuteReader
            conn.Close()

            conn.Open()
            cmd = New SqlClient.SqlCommand()
            cmd.CommandText = "Update GRUPA_A set BrojBodova=BrojBodova+1 WHERE id_poz = (Select min(id_poz)+1 from GRUPA_A)"
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn
            source.DataSource = cmd.ExecuteReader
            conn.Close()
        End If

        If (t3 > t4) Then
            conn.Open()
            cmd = New SqlClient.SqlCommand()
            cmd.CommandText = "Update GRUPA_A set BrojBodova=BrojBodova+3 WHERE id_poz = (Select min(id_poz) from GRUPA_A)"
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn
            Dim source As New BindingSource
            source.DataSource = cmd.ExecuteReader
            conn.Close()
        ElseIf (t4 > t3) Then
            conn.Open()
            cmd = New SqlClient.SqlCommand()
            cmd.CommandText = "Update GRUPA_A set BrojBodova=BrojBodova+3 WHERE id_poz = (Select min(id_poz)+2 from GRUPA_A)"
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn
            Dim source As New BindingSource
            source.DataSource = cmd.ExecuteReader
            conn.Close()
        Else
            conn.Open()
            cmd = New SqlClient.SqlCommand()
            cmd.CommandText = "Update GRUPA_A set BrojBodova=BrojBodova+1 WHERE id_poz = (Select min(id_poz) from GRUPA_A)"
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn
            Dim source As New BindingSource
            source.DataSource = cmd.ExecuteReader
            conn.Close()

            conn.Open()
            cmd = New SqlClient.SqlCommand()
            cmd.CommandText = "Update GRUPA_A set BrojBodova=BrojBodova+1 WHERE id_poz = (Select min(id_poz)+2 from GRUPA_A)"
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn
            source.DataSource = cmd.ExecuteReader
            conn.Close()
        End If

        If (t5 > t6) Then
            conn.Open()
            cmd = New SqlClient.SqlCommand()
            cmd.CommandText = "Update GRUPA_A set BrojBodova=BrojBodova+3 WHERE id_poz = (Select min(id_poz) from GRUPA_A)"
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn
            Dim source As New BindingSource
            source.DataSource = cmd.ExecuteReader
            conn.Close()
        ElseIf (t6 > t5) Then
            conn.Open()
            cmd = New SqlClient.SqlCommand()
            cmd.CommandText = "Update GRUPA_A set BrojBodova=BrojBodova+3 WHERE id_poz = (Select min(id_poz)+3 from GRUPA_A)"
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn
            Dim source As New BindingSource
            source.DataSource = cmd.ExecuteReader
            conn.Close()
        Else
            conn.Open()
            cmd = New SqlClient.SqlCommand()
            cmd.CommandText = "Update GRUPA_A set BrojBodova=BrojBodova+1 WHERE id_poz = (Select min(id_poz) from GRUPA_A)"
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn
            Dim source As New BindingSource
            source.DataSource = cmd.ExecuteReader
            conn.Close()

            conn.Open()
            cmd = New SqlClient.SqlCommand()
            cmd.CommandText = "Update GRUPA_A set BrojBodova=BrojBodova+1 WHERE id_poz = (Select min(id_poz)+3 from GRUPA_A)"
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn
            source.DataSource = cmd.ExecuteReader
            conn.Close()
        End If

        If (t7 > t8) Then
            conn.Open()
            cmd = New SqlClient.SqlCommand()
            cmd.CommandText = "Update GRUPA_A set BrojBodova=BrojBodova+3 WHERE id_poz = (Select min(id_poz)+1 from GRUPA_A)"
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn
            Dim source As New BindingSource
            source.DataSource = cmd.ExecuteReader
            conn.Close()
        ElseIf (t4 > t3) Then
            conn.Open()
            cmd = New SqlClient.SqlCommand()
            cmd.CommandText = "Update GRUPA_A set BrojBodova=BrojBodova+3 WHERE id_poz = (Select min(id_poz)+2 from GRUPA_A)"
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn
            Dim source As New BindingSource
            source.DataSource = cmd.ExecuteReader
            conn.Close()
        Else
            conn.Open()
            cmd = New SqlClient.SqlCommand()
            cmd.CommandText = "Update GRUPA_A set BrojBodova=BrojBodova+1 WHERE id_poz = (Select min(id_poz)+1 from GRUPA_A)"
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn
            Dim source As New BindingSource
            source.DataSource = cmd.ExecuteReader
            conn.Close()

            conn.Open()
            cmd = New SqlClient.SqlCommand()
            cmd.CommandText = "Update GRUPA_A set BrojBodova=BrojBodova+1 WHERE id_poz = (Select min(id_poz)+2 from GRUPA_A)"
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn
            source.DataSource = cmd.ExecuteReader
            conn.Close()
        End If

        If (t9 > t10) Then
            conn.Open()
            cmd = New SqlClient.SqlCommand()
            cmd.CommandText = "Update GRUPA_A set BrojBodova=BrojBodova+3 WHERE id_poz = (Select min(id_poz)+1 from GRUPA_A)"
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn
            Dim source As New BindingSource
            source.DataSource = cmd.ExecuteReader
            conn.Close()
        ElseIf (t10 > t9) Then
            conn.Open()
            cmd = New SqlClient.SqlCommand()
            cmd.CommandText = "Update GRUPA_A set BrojBodova=BrojBodova+3 WHERE id_poz = (Select min(id_poz)+3 from GRUPA_A)"
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn
            Dim source As New BindingSource
            source.DataSource = cmd.ExecuteReader
            conn.Close()
        Else
            conn.Open()
            cmd = New SqlClient.SqlCommand()
            cmd.CommandText = "Update GRUPA_A set BrojBodova=BrojBodova+1 WHERE id_poz = (Select min(id_poz)+1 from GRUPA_A)"
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn
            Dim source As New BindingSource
            source.DataSource = cmd.ExecuteReader
            conn.Close()

            conn.Open()
            cmd = New SqlClient.SqlCommand()
            cmd.CommandText = "Update GRUPA_A set BrojBodova=BrojBodova+1 WHERE id_poz = (Select min(id_poz)+3 from GRUPA_A)"
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn
            source.DataSource = cmd.ExecuteReader
            conn.Close()
        End If

        If (t11 > t12) Then
            conn.Open()
            cmd = New SqlClient.SqlCommand()
            cmd.CommandText = "Update GRUPA_A set BrojBodova=BrojBodova+3 WHERE id_poz = (Select min(id_poz)+2 from GRUPA_A)"
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn
            Dim source As New BindingSource
            source.DataSource = cmd.ExecuteReader
            conn.Close()
        ElseIf (t12 > t11) Then
            conn.Open()
            cmd = New SqlClient.SqlCommand()
            cmd.CommandText = "Update GRUPA_A set BrojBodova=BrojBodova+3 WHERE id_poz = (Select min(id_poz)+3 from GRUPA_A)"
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn
            Dim source As New BindingSource
            source.DataSource = cmd.ExecuteReader
            conn.Close()
        Else
            conn.Open()
            cmd = New SqlClient.SqlCommand()
            cmd.CommandText = "Update GRUPA_A set BrojBodova=BrojBodova+1 WHERE id_poz = (Select min(id_poz)+2 from GRUPA_A)"
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn
            Dim source As New BindingSource
            source.DataSource = cmd.ExecuteReader
            conn.Close()

            conn.Open()
            cmd = New SqlClient.SqlCommand()
            cmd.CommandText = "Update GRUPA_A set BrojBodova=BrojBodova+1 WHERE id_poz = (Select min(id_poz)+3 from GRUPA_A)"
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn
            source.DataSource = cmd.ExecuteReader
            conn.Close()
        End If

        If (t13 > t14) Then
            conn.Open()
            cmd = New SqlClient.SqlCommand()
            cmd.CommandText = "Update GRUPA_B set BrojBodova=BrojBodova+3 WHERE id_poz = (Select min(id_poz) from GRUPA_B)"
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn
            Dim source As New BindingSource
            source.DataSource = cmd.ExecuteReader
            conn.Close()
        ElseIf (t14 > t13) Then
            conn.Open()
            cmd = New SqlClient.SqlCommand()
            cmd.CommandText = "Update GRUPA_B set BrojBodova=BrojBodova+3 WHERE id_poz = (Select min(id_poz)+1 from GRUPA_B)"
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn
            Dim source As New BindingSource
            source.DataSource = cmd.ExecuteReader
            conn.Close()
        Else
            conn.Open()
            cmd = New SqlClient.SqlCommand()
            cmd.CommandText = "Update GRUPA_B set BrojBodova=BrojBodova+1 WHERE id_poz = (Select min(id_poz) from GRUPA_B)"
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn
            Dim source As New BindingSource
            source.DataSource = cmd.ExecuteReader
            conn.Close()

            conn.Open()
            cmd = New SqlClient.SqlCommand()
            cmd.CommandText = "Update GRUPA_B set BrojBodova=BrojBodova+1 WHERE id_poz = (Select min(id_poz)+1 from GRUPA_B)"
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn
            source.DataSource = cmd.ExecuteReader
            conn.Close()
        End If

        If (t15 > t16) Then
            conn.Open()
            cmd = New SqlClient.SqlCommand()
            cmd.CommandText = "Update GRUPA_B set BrojBodova=BrojBodova+3 WHERE id_poz = (Select min(id_poz) from GRUPA_B)"
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn
            Dim source As New BindingSource
            source.DataSource = cmd.ExecuteReader
            conn.Close()
        ElseIf (t16 > t15) Then
            conn.Open()
            cmd = New SqlClient.SqlCommand()
            cmd.CommandText = "Update GRUPA_B set BrojBodova=BrojBodova+3 WHERE id_poz = (Select min(id_poz)+2 from GRUPA_B)"
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn
            Dim source As New BindingSource
            source.DataSource = cmd.ExecuteReader
            conn.Close()
        Else
            conn.Open()
            cmd = New SqlClient.SqlCommand()
            cmd.CommandText = "Update GRUPA_B set BrojBodova=BrojBodova+1 WHERE id_poz = (Select min(id_poz) from GRUPA_B)"
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn
            Dim source As New BindingSource
            source.DataSource = cmd.ExecuteReader
            conn.Close()

            conn.Open()
            cmd = New SqlClient.SqlCommand()
            cmd.CommandText = "Update GRUPA_B set BrojBodova=BrojBodova+1 WHERE id_poz = (Select min(id_poz)+2 from GRUPA_B)"
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn
            source.DataSource = cmd.ExecuteReader
            conn.Close()
        End If

        If (t17 > t18) Then
            conn.Open()
            cmd = New SqlClient.SqlCommand()
            cmd.CommandText = "Update GRUPA_B set BrojBodova=BrojBodova+3 WHERE id_poz = (Select min(id_poz) from GRUPA_B)"
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn
            Dim source As New BindingSource
            source.DataSource = cmd.ExecuteReader
            conn.Close()
        ElseIf (t14 > t13) Then
            conn.Open()
            cmd = New SqlClient.SqlCommand()
            cmd.CommandText = "Update GRUPA_B set BrojBodova=BrojBodova+3 WHERE id_poz = (Select min(id_poz)+3 from GRUPA_B)"
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn
            Dim source As New BindingSource
            source.DataSource = cmd.ExecuteReader
            conn.Close()
        Else
            conn.Open()
            cmd = New SqlClient.SqlCommand()
            cmd.CommandText = "Update GRUPA_B set BrojBodova=BrojBodova+1 WHERE id_poz = (Select min(id_poz) from GRUPA_B)"
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn
            Dim source As New BindingSource
            source.DataSource = cmd.ExecuteReader
            conn.Close()

            conn.Open()
            cmd = New SqlClient.SqlCommand()
            cmd.CommandText = "Update GRUPA_B set BrojBodova=BrojBodova+1 WHERE id_poz = (Select min(id_poz)+3 from GRUPA_B)"
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn
            source.DataSource = cmd.ExecuteReader
            conn.Close()
        End If

        If (t19 > t20) Then
            conn.Open()
            cmd = New SqlClient.SqlCommand()
            cmd.CommandText = "Update GRUPA_B set BrojBodova=BrojBodova+3 WHERE id_poz = (Select min(id_poz)+1 from GRUPA_B)"
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn
            Dim source As New BindingSource
            source.DataSource = cmd.ExecuteReader
            conn.Close()
        ElseIf (t20 > t19) Then
            conn.Open()
            cmd = New SqlClient.SqlCommand()
            cmd.CommandText = "Update GRUPA_B set BrojBodova=BrojBodova+3 WHERE id_poz = (Select min(id_poz)+2 from GRUPA_B)"
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn
            Dim source As New BindingSource
            source.DataSource = cmd.ExecuteReader
            conn.Close()
        Else
            conn.Open()
            cmd = New SqlClient.SqlCommand()
            cmd.CommandText = "Update GRUPA_B set BrojBodova=BrojBodova+1 WHERE id_poz = (Select min(id_poz)+1 from GRUPA_B)"
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn
            Dim source As New BindingSource
            source.DataSource = cmd.ExecuteReader
            conn.Close()

            conn.Open()
            cmd = New SqlClient.SqlCommand()
            cmd.CommandText = "Update GRUPA_B set BrojBodova=BrojBodova+1 WHERE id_poz = (Select min(id_poz)+2 from GRUPA_B)"
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn
            source.DataSource = cmd.ExecuteReader
            conn.Close()
        End If

        If (t21 > t22) Then
            conn.Open()
            cmd = New SqlClient.SqlCommand()
            cmd.CommandText = "Update GRUPA_B set BrojBodova=BrojBodova+3 WHERE id_poz = (Select min(id_poz)+1 from GRUPA_B)"
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn
            Dim source As New BindingSource
            source.DataSource = cmd.ExecuteReader
            conn.Close()
        ElseIf (t22 > t21) Then
            conn.Open()
            cmd = New SqlClient.SqlCommand()
            cmd.CommandText = "Update GRUPA_B set BrojBodova=BrojBodova+3 WHERE id_poz = (Select min(id_poz)+3 from GRUPA_B)"
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn
            Dim source As New BindingSource
            source.DataSource = cmd.ExecuteReader
            conn.Close()
        Else
            conn.Open()
            cmd = New SqlClient.SqlCommand()
            cmd.CommandText = "Update GRUPA_B set BrojBodova=BrojBodova+1 WHERE id_poz = (Select min(id_poz)+1 from GRUPA_B)"
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn
            Dim source As New BindingSource
            source.DataSource = cmd.ExecuteReader
            conn.Close()

            conn.Open()
            cmd = New SqlClient.SqlCommand()
            cmd.CommandText = "Update GRUPA_B set BrojBodova=BrojBodova+1 WHERE id_poz = (Select min(id_poz)+3 from GRUPA_B)"
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn
            source.DataSource = cmd.ExecuteReader
            conn.Close()
        End If

        If (t23 > t24) Then
            conn.Open()
            cmd = New SqlClient.SqlCommand()
            cmd.CommandText = "Update GRUPA_B set BrojBodova=BrojBodova+3 WHERE id_poz = (Select min(id_poz)+2 from GRUPA_B)"
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn
            Dim source As New BindingSource
            source.DataSource = cmd.ExecuteReader
            conn.Close()
        ElseIf (t24 > t23) Then
            conn.Open()
            cmd = New SqlClient.SqlCommand()
            cmd.CommandText = "Update GRUPA_B set BrojBodova=BrojBodova+3 WHERE id_poz = (Select min(id_poz)+3 from GRUPA_B)"
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn
            Dim source As New BindingSource
            source.DataSource = cmd.ExecuteReader
            conn.Close()
        Else
            conn.Open()
            cmd = New SqlClient.SqlCommand()
            cmd.CommandText = "Update GRUPA_B set BrojBodova=BrojBodova+1 WHERE id_poz = (Select min(id_poz)+2 from GRUPA_B)"
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn
            Dim source As New BindingSource
            source.DataSource = cmd.ExecuteReader
            conn.Close()

            conn.Open()
            cmd = New SqlClient.SqlCommand()
            cmd.CommandText = "Update GRUPA_B set BrojBodova=BrojBodova+1 WHERE id_poz = (Select min(id_poz)+3 from GRUPA_B)"
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn
            source.DataSource = cmd.ExecuteReader
            conn.Close()
        End If

        conn.Open()
        cmd = New SqlClient.SqlCommand()
        cmd.CommandText = "INSERT INTO POLUFINALE (id_tima,NazivTima,BrojBodova) SELECT id_tima,NazivTima,BrojBodova FROM GRUPA_A WHERE id_tima IN( Select TOP 2(id_tima) FROM GRUPA_A ORDER BY BrojBodova DESC)"
        cmd.CommandType = CommandType.Text
        cmd.Connection = conn
        Dim source2 As New BindingSource
        source2.DataSource = cmd.ExecuteReader
        conn.Close()

        conn.Open()
        cmd = New SqlClient.SqlCommand()
        cmd.CommandText = "INSERT INTO POLUFINALE (id_tima,NazivTima,BrojBodova) SELECT id_tima,NazivTima,BrojBodova FROM GRUPA_B WHERE id_tima IN( Select TOP 2(id_tima) FROM GRUPA_B ORDER BY BrojBodova DESC)"
        cmd.CommandType = CommandType.Text
        cmd.Connection = conn
        Dim source3 As New BindingSource
        source3.DataSource = cmd.ExecuteReader
        conn.Close()

        Me.Hide()

    End Sub
End Class
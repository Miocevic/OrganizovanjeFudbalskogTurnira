Public Class BiranjeGrupa

    Private Sub BiranjeGrupa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OrganizacijaTurniraDataSet1.TIMOVI' table. You can move, or remove it, as needed.
        Me.TIMOVITableAdapter.Fill(Me.OrganizacijaTurniraDataSet1.TIMOVI)
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cmd As SqlClient.SqlCommand
        Dim conn As SqlClient.SqlConnection
        Dim strConn As String
        strConn = "Data Source=MIOCHEVIC;Initial Catalog=OrganizacijaTurnira;Integrated Security=True"
        conn = New SqlClient.SqlConnection(strConn)



        If (CheckBox1.Checked = True) Then
            conn.Open()
            cmd = New SqlClient.SqlCommand()
            cmd.CommandText = "Insert into GRUPA_A VALUES(1,'Arsenal',0)"
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn
            Dim source As New BindingSource
            source.DataSource = cmd.ExecuteReader
            conn.Close()
        Else
            conn.Open()
            cmd = New SqlClient.SqlCommand()
            cmd.CommandText = "Insert into GRUPA_B VALUES(1,'Arsenal',0)"
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn
            Dim source As New BindingSource
            source.DataSource = cmd.ExecuteReader
            conn.Close()
        End If

        If (CheckBox2.Checked = True) Then
            conn.Open()
            cmd = New SqlClient.SqlCommand()
            cmd.CommandText = "Insert into GRUPA_A VALUES(2,'Chelsea',0)"
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn
            Dim source As New BindingSource
            source.DataSource = cmd.ExecuteReader
            conn.Close()
        Else
            conn.Open()
            cmd = New SqlClient.SqlCommand()
            cmd.CommandText = "Insert into GRUPA_B VALUES(2,'Chelsea',0)"
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn
            Dim source As New BindingSource
            source.DataSource = cmd.ExecuteReader
            conn.Close()
        End If

        If (CheckBox3.Checked = True) Then
            conn.Open()
            cmd = New SqlClient.SqlCommand()
            cmd.CommandText = "Insert into GRUPA_A VALUES(3,'Everton',0)"
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn
            Dim source As New BindingSource
            source.DataSource = cmd.ExecuteReader
            conn.Close()
        Else
            conn.Open()
            cmd = New SqlClient.SqlCommand()
            cmd.CommandText = "Insert into GRUPA_B VALUES(3,'Everton',0)"
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn
            Dim source As New BindingSource
            source.DataSource = cmd.ExecuteReader
            conn.Close()
        End If

        If (CheckBox4.Checked = True) Then
            conn.Open()
            cmd = New SqlClient.SqlCommand()
            cmd.CommandText = "Insert into GRUPA_A VALUES(4,'Liverpool',0)"
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn
            Dim source As New BindingSource
            source.DataSource = cmd.ExecuteReader
            conn.Close()
        Else
            conn.Open()
            cmd = New SqlClient.SqlCommand()
            cmd.CommandText = "Insert into GRUPA_B VALUES(4,'Liverpool',0)"
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn
            Dim source As New BindingSource
            source.DataSource = cmd.ExecuteReader
            conn.Close()
        End If

        If (CheckBox5.Checked = True) Then
            conn.Open()
            cmd = New SqlClient.SqlCommand()
            cmd.CommandText = "Insert into GRUPA_A VALUES(5,'Manchester_City',0)"
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn
            Dim source As New BindingSource
            source.DataSource = cmd.ExecuteReader
            conn.Close()
        Else
            conn.Open()
            cmd = New SqlClient.SqlCommand()
            cmd.CommandText = "Insert into GRUPA_B VALUES(5,'Manchester_City',0)"
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn
            Dim source As New BindingSource
            source.DataSource = cmd.ExecuteReader
            conn.Close()
        End If

        If (CheckBox6.Checked = True) Then
            conn.Open()
            cmd = New SqlClient.SqlCommand()
            cmd.CommandText = "Insert into GRUPA_A VALUES(6,'Manchester_United',0)"
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn
            Dim source As New BindingSource
            source.DataSource = cmd.ExecuteReader
            conn.Close()
        Else
            conn.Open()
            cmd = New SqlClient.SqlCommand()
            cmd.CommandText = "Insert into GRUPA_B VALUES(6,'Manchester_United',0)"
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn
            Dim source As New BindingSource
            source.DataSource = cmd.ExecuteReader
            conn.Close()
        End If

        If (CheckBox7.Checked = True) Then
            conn.Open()
            cmd = New SqlClient.SqlCommand()
            cmd.CommandText = "Insert into GRUPA_A VALUES(7,'Southampton',0)"
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn
            Dim source As New BindingSource
            source.DataSource = cmd.ExecuteReader
            conn.Close()
        Else
            conn.Open()
            cmd = New SqlClient.SqlCommand()
            cmd.CommandText = "Insert into GRUPA_B VALUES(7,'Southampton',0)"
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn
            Dim source As New BindingSource
            source.DataSource = cmd.ExecuteReader
            conn.Close()
        End If

        If (CheckBox8.Checked = True) Then
            conn.Open()
            cmd = New SqlClient.SqlCommand()
            cmd.CommandText = "Insert into GRUPA_A VALUES(8,'Tottenham',0)"
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn
            Dim source As New BindingSource
            source.DataSource = cmd.ExecuteReader
            conn.Close()
        Else
            conn.Open()
            cmd = New SqlClient.SqlCommand()
            cmd.CommandText = "Insert into GRUPA_B VALUES(8,'Tottenham',0)"
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn
            Dim source As New BindingSource
            source.DataSource = cmd.ExecuteReader
            conn.Close()
        End If
        Me.Hide()
    End Sub
End Class
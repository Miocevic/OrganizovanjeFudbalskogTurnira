<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BiranjeGrupa
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
        Me.OrganizacijaTurniraDataSet1 = New OrganizovanjeFudbalskogTurnira.OrganizacijaTurniraDataSet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TIMOVIBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TIMOVITableAdapter = New OrganizovanjeFudbalskogTurnira.OrganizacijaTurniraDataSetTableAdapters.TIMOVITableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.CheckBox5 = New System.Windows.Forms.CheckBox()
        Me.CheckBox6 = New System.Windows.Forms.CheckBox()
        Me.CheckBox7 = New System.Windows.Forms.CheckBox()
        Me.CheckBox8 = New System.Windows.Forms.CheckBox()
        CType(Me.OrganizacijaTurniraDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TIMOVIBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OrganizacijaTurniraDataSet1
        '
        Me.OrganizacijaTurniraDataSet1.DataSetName = "OrganizacijaTurniraDataSet"
        Me.OrganizacijaTurniraDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(93, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "IZABERITE TIMOVE ZA GRUPU A"
        '
        'TIMOVIBindingSource
        '
        Me.TIMOVIBindingSource.DataMember = "TIMOVI"
        Me.TIMOVIBindingSource.DataSource = Me.OrganizacijaTurniraDataSet1
        '
        'TIMOVITableAdapter
        '
        Me.TIMOVITableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(117, 247)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(127, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "IZABERI"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(56, 76)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(76, 17)
        Me.CheckBox1.TabIndex = 3
        Me.CheckBox1.Text = "ARSENAL"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(56, 116)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(75, 17)
        Me.CheckBox2.TabIndex = 4
        Me.CheckBox2.Text = "CHELSEA"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(56, 159)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(78, 17)
        Me.CheckBox3.TabIndex = 5
        Me.CheckBox3.Text = "EVERTON"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Location = New System.Drawing.Point(56, 200)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(78, 17)
        Me.CheckBox4.TabIndex = 6
        Me.CheckBox4.Text = "LIVERPUL"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'CheckBox5
        '
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.Location = New System.Drawing.Point(214, 76)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(128, 17)
        Me.CheckBox5.TabIndex = 10
        Me.CheckBox5.Text = "MANCHESTER CITY"
        Me.CheckBox5.UseVisualStyleBackColor = True
        '
        'CheckBox6
        '
        Me.CheckBox6.AutoSize = True
        Me.CheckBox6.Location = New System.Drawing.Point(214, 116)
        Me.CheckBox6.Name = "CheckBox6"
        Me.CheckBox6.Size = New System.Drawing.Size(145, 17)
        Me.CheckBox6.TabIndex = 9
        Me.CheckBox6.Text = "MANCHESTER UNITED"
        Me.CheckBox6.UseVisualStyleBackColor = True
        '
        'CheckBox7
        '
        Me.CheckBox7.AutoSize = True
        Me.CheckBox7.Location = New System.Drawing.Point(214, 159)
        Me.CheckBox7.Name = "CheckBox7"
        Me.CheckBox7.Size = New System.Drawing.Size(110, 17)
        Me.CheckBox7.TabIndex = 8
        Me.CheckBox7.Text = "SOUTHAMPTON"
        Me.CheckBox7.UseVisualStyleBackColor = True
        '
        'CheckBox8
        '
        Me.CheckBox8.AutoSize = True
        Me.CheckBox8.Location = New System.Drawing.Point(214, 200)
        Me.CheckBox8.Name = "CheckBox8"
        Me.CheckBox8.Size = New System.Drawing.Size(94, 17)
        Me.CheckBox8.TabIndex = 7
        Me.CheckBox8.Text = "TOTTENHAM"
        Me.CheckBox8.UseVisualStyleBackColor = True
        '
        'BiranjeGrupa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(371, 300)
        Me.Controls.Add(Me.CheckBox5)
        Me.Controls.Add(Me.CheckBox6)
        Me.Controls.Add(Me.CheckBox7)
        Me.Controls.Add(Me.CheckBox8)
        Me.Controls.Add(Me.CheckBox4)
        Me.Controls.Add(Me.CheckBox3)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "BiranjeGrupa"
        Me.Text = "BiranjeGrupa"
        CType(Me.OrganizacijaTurniraDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TIMOVIBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OrganizacijaTurniraDataSet1 As OrganizovanjeFudbalskogTurnira.OrganizacijaTurniraDataSet
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TIMOVIBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TIMOVITableAdapter As OrganizovanjeFudbalskogTurnira.OrganizacijaTurniraDataSetTableAdapters.TIMOVITableAdapter
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox4 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox5 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox6 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox7 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox8 As System.Windows.Forms.CheckBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListanjeIgraca
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TIMOVIBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TIMOVITableAdapter = New OrganizovanjeFudbalskogTurnira.OrganizacijaTurniraDataSetTableAdapters.TIMOVITableAdapter()
        CType(Me.OrganizacijaTurniraDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TIMOVIBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OrganizacijaTurniraDataSet1
        '
        Me.OrganizacijaTurniraDataSet1.DataSetName = "OrganizacijaTurniraDataSet"
        Me.OrganizacijaTurniraDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(32, 83)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(336, 150)
        Me.DataGridView1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Ime Tima:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(262, 35)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(106, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Prikazi Igrace"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.TIMOVIBindingSource
        Me.ComboBox1.DisplayMember = "NazivTima"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(112, 35)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 4
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
        'ListanjeIgraca
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(413, 291)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "ListanjeIgraca"
        Me.Text = "ListanjeIgraca"
        CType(Me.OrganizacijaTurniraDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TIMOVIBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OrganizacijaTurniraDataSet1 As OrganizovanjeFudbalskogTurnira.OrganizacijaTurniraDataSet
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents TIMOVIBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TIMOVITableAdapter As OrganizovanjeFudbalskogTurnira.OrganizacijaTurniraDataSetTableAdapters.TIMOVITableAdapter
End Class

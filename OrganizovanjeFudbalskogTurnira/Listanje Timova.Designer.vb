<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Listanje_Timova
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
        Me.TIMOVIBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TIMOVITableAdapter = New OrganizovanjeFudbalskogTurnira.OrganizacijaTurniraDataSetTableAdapters.TIMOVITableAdapter()
        Me.NazivTimaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NazivTimaDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TIMOVIBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(44, 24)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(245, 232)
        Me.DataGridView1.TabIndex = 0
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
        'NazivTimaDataGridViewTextBoxColumn
        '
        Me.NazivTimaDataGridViewTextBoxColumn.DataPropertyName = "NazivTima"
        Me.NazivTimaDataGridViewTextBoxColumn.HeaderText = "NazivTima"
        Me.NazivTimaDataGridViewTextBoxColumn.Name = "NazivTimaDataGridViewTextBoxColumn"
        Me.NazivTimaDataGridViewTextBoxColumn.Width = 200
        '
        'Listanje_Timova
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(348, 287)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Listanje_Timova"
        Me.Text = "Listanje_Timova"
        CType(Me.OrganizacijaTurniraDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TIMOVIBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OrganizacijaTurniraDataSet1 As OrganizovanjeFudbalskogTurnira.OrganizacijaTurniraDataSet
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents TIMOVIBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TIMOVITableAdapter As OrganizovanjeFudbalskogTurnira.OrganizacijaTurniraDataSetTableAdapters.TIMOVITableAdapter
    Friend WithEvents NazivTimaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Grupe
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.FillByToolStrip = New System.Windows.Forms.ToolStrip()
        Me.GRUPABBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrganizacijaTurniraDataSet1 = New OrganizovanjeFudbalskogTurnira.OrganizacijaTurniraDataSet()
        Me.GRUPAABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GRUPA_ATableAdapter = New OrganizovanjeFudbalskogTurnira.OrganizacijaTurniraDataSetTableAdapters.GRUPA_ATableAdapter()
        Me.GRUPA_BTableAdapter = New OrganizovanjeFudbalskogTurnira.OrganizacijaTurniraDataSetTableAdapters.GRUPA_BTableAdapter()
        Me.NazivTimaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BrojBodovaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NazivTimaDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BrojBodovaDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GRUPABBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrganizacijaTurniraDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GRUPAABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(96, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "GRUPA A"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(424, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "GRUPA B"
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToOrderColumns = True
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NazivTimaDataGridViewTextBoxColumn1, Me.BrojBodovaDataGridViewTextBoxColumn1})
        Me.DataGridView2.DataSource = Me.GRUPABBindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(331, 72)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(243, 162)
        Me.DataGridView2.TabIndex = 3
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NazivTimaDataGridViewTextBoxColumn, Me.BrojBodovaDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.GRUPAABindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 72)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(254, 162)
        Me.DataGridView1.TabIndex = 2
        '
        'FillByToolStrip
        '
        Me.FillByToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.FillByToolStrip.Name = "FillByToolStrip"
        Me.FillByToolStrip.Size = New System.Drawing.Size(618, 25)
        Me.FillByToolStrip.TabIndex = 4
        Me.FillByToolStrip.Text = "FillByToolStrip"
        '
        'GRUPABBindingSource
        '
        Me.GRUPABBindingSource.DataMember = "GRUPA_B"
        Me.GRUPABBindingSource.DataSource = Me.OrganizacijaTurniraDataSet1
        '
        'OrganizacijaTurniraDataSet1
        '
        Me.OrganizacijaTurniraDataSet1.DataSetName = "OrganizacijaTurniraDataSet"
        Me.OrganizacijaTurniraDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GRUPAABindingSource
        '
        Me.GRUPAABindingSource.DataMember = "GRUPA_A"
        Me.GRUPAABindingSource.DataSource = Me.OrganizacijaTurniraDataSet1
        '
        'GRUPA_ATableAdapter
        '
        Me.GRUPA_ATableAdapter.ClearBeforeFill = True
        '
        'GRUPA_BTableAdapter
        '
        Me.GRUPA_BTableAdapter.ClearBeforeFill = True
        '
        'NazivTimaDataGridViewTextBoxColumn
        '
        Me.NazivTimaDataGridViewTextBoxColumn.DataPropertyName = "NazivTima"
        Me.NazivTimaDataGridViewTextBoxColumn.HeaderText = "NazivTima"
        Me.NazivTimaDataGridViewTextBoxColumn.Name = "NazivTimaDataGridViewTextBoxColumn"
        '
        'BrojBodovaDataGridViewTextBoxColumn
        '
        Me.BrojBodovaDataGridViewTextBoxColumn.DataPropertyName = "BrojBodova"
        Me.BrojBodovaDataGridViewTextBoxColumn.HeaderText = "BrojBodova"
        Me.BrojBodovaDataGridViewTextBoxColumn.Name = "BrojBodovaDataGridViewTextBoxColumn"
        Me.BrojBodovaDataGridViewTextBoxColumn.Width = 80
        '
        'NazivTimaDataGridViewTextBoxColumn1
        '
        Me.NazivTimaDataGridViewTextBoxColumn1.DataPropertyName = "NazivTima"
        Me.NazivTimaDataGridViewTextBoxColumn1.HeaderText = "NazivTima"
        Me.NazivTimaDataGridViewTextBoxColumn1.Name = "NazivTimaDataGridViewTextBoxColumn1"
        '
        'BrojBodovaDataGridViewTextBoxColumn1
        '
        Me.BrojBodovaDataGridViewTextBoxColumn1.DataPropertyName = "BrojBodova"
        Me.BrojBodovaDataGridViewTextBoxColumn1.HeaderText = "BrojBodova"
        Me.BrojBodovaDataGridViewTextBoxColumn1.Name = "BrojBodovaDataGridViewTextBoxColumn1"
        Me.BrojBodovaDataGridViewTextBoxColumn1.Width = 70
        '
        'Grupe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(618, 330)
        Me.Controls.Add(Me.FillByToolStrip)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Grupe"
        Me.Text = "Grupe"
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GRUPABBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrganizacijaTurniraDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GRUPAABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OrganizacijaTurniraDataSet1 As OrganizovanjeFudbalskogTurnira.OrganizacijaTurniraDataSet
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GRUPAABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GRUPA_ATableAdapter As OrganizovanjeFudbalskogTurnira.OrganizacijaTurniraDataSetTableAdapters.GRUPA_ATableAdapter
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents GRUPABBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GRUPA_BTableAdapter As OrganizovanjeFudbalskogTurnira.OrganizacijaTurniraDataSetTableAdapters.GRUPA_BTableAdapter
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents FillByToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents NazivTimaDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BrojBodovaDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NazivTimaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BrojBodovaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class

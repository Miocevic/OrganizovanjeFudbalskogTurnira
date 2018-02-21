<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class POBEDNIK
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
        Me.OrganizacijaTurniraDataSet11 = New OrganizovanjeFudbalskogTurnira.OrganizacijaTurniraDataSet1()
        Me.POLUFINALEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.POLUFINALETableAdapter = New OrganizovanjeFudbalskogTurnira.OrganizacijaTurniraDataSet1TableAdapters.POLUFINALETableAdapter()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.OrganizacijaTurniraDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrganizacijaTurniraDataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.POLUFINALEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OrganizacijaTurniraDataSet1
        '
        Me.OrganizacijaTurniraDataSet1.DataSetName = "OrganizacijaTurniraDataSet"
        Me.OrganizacijaTurniraDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OrganizacijaTurniraDataSet11
        '
        Me.OrganizacijaTurniraDataSet11.DataSetName = "OrganizacijaTurniraDataSet1"
        Me.OrganizacijaTurniraDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'POLUFINALEBindingSource
        '
        Me.POLUFINALEBindingSource.DataMember = "POLUFINALE"
        Me.POLUFINALEBindingSource.DataSource = Me.OrganizacijaTurniraDataSet11
        '
        'POLUFINALETableAdapter
        '
        Me.POLUFINALETableAdapter.ClearBeforeFill = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(98, 90)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(174, 104)
        Me.DataGridView1.TabIndex = 0
        '
        'POBEDNIK
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(370, 324)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "POBEDNIK"
        Me.Text = "POBEDNIK"
        CType(Me.OrganizacijaTurniraDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrganizacijaTurniraDataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.POLUFINALEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OrganizacijaTurniraDataSet1 As OrganizovanjeFudbalskogTurnira.OrganizacijaTurniraDataSet
    Friend WithEvents OrganizacijaTurniraDataSet11 As OrganizovanjeFudbalskogTurnira.OrganizacijaTurniraDataSet1
    Friend WithEvents POLUFINALEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents POLUFINALETableAdapter As OrganizovanjeFudbalskogTurnira.OrganizacijaTurniraDataSet1TableAdapters.POLUFINALETableAdapter
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
End Class

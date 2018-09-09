<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_relatorio_bens
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.sistemaContabilDataSet1 = New sistemaContabil.sistemaContabilDataSet1()
        Me.tb_empresaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tb_empresaTableAdapter = New sistemaContabil.sistemaContabilDataSet1TableAdapters.tb_empresaTableAdapter()
        Me.bensBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.bensTableAdapter = New sistemaContabil.sistemaContabilDataSet1TableAdapters.bensTableAdapter()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me.sistemaContabilDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tb_empresaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bensBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'sistemaContabilDataSet1
        '
        Me.sistemaContabilDataSet1.DataSetName = "sistemaContabilDataSet1"
        Me.sistemaContabilDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tb_empresaBindingSource
        '
        Me.tb_empresaBindingSource.DataMember = "tb_empresa"
        Me.tb_empresaBindingSource.DataSource = Me.sistemaContabilDataSet1
        '
        'tb_empresaTableAdapter
        '
        Me.tb_empresaTableAdapter.ClearBeforeFill = True
        '
        'bensBindingSource
        '
        Me.bensBindingSource.DataMember = "bens"
        Me.bensBindingSource.DataSource = Me.sistemaContabilDataSet1
        '
        'bensTableAdapter
        '
        Me.bensTableAdapter.ClearBeforeFill = True
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "bens"
        ReportDataSource1.Value = Me.bensBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "sistemaContabil.rv_bens.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(800, 450)
        Me.ReportViewer1.TabIndex = 0
        '
        'frm_relatorio_bens
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frm_relatorio_bens"
        Me.Text = "frm_relatorio_bens"
        CType(Me.sistemaContabilDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tb_empresaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bensBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tb_empresaBindingSource As BindingSource
    Friend WithEvents sistemaContabilDataSet1 As sistemaContabilDataSet1
    Friend WithEvents tb_empresaTableAdapter As sistemaContabilDataSet1TableAdapters.tb_empresaTableAdapter
    Friend WithEvents bensBindingSource As BindingSource
    Friend WithEvents bensTableAdapter As sistemaContabilDataSet1TableAdapters.bensTableAdapter
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
End Class

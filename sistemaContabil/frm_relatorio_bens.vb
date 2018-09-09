Public Class frm_relatorio_bens
    Private Sub frm_relatorio_bens_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'sistemaContabilDataSet1.bens'. Você pode movê-la ou removê-la conforme necessário.
        Me.bensTableAdapter.Fill(Me.sistemaContabilDataSet1.bens)
        'TODO: esta linha de código carrega dados na tabela 'sistemaContabilDataSet1.tb_empresa'. Você pode movê-la ou removê-la conforme necessário.
        Me.tb_empresaTableAdapter.Fill(Me.sistemaContabilDataSet1.tb_empresa)

        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.RefreshReport
    End Sub
End Class
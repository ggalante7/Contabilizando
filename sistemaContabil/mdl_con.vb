Imports System.Data
Imports System.Data.OleDb
Module mdl_con
    Public db As New ADODB.Connection
    Public rs As New ADODB.Recordset
    Public conexao = Application.StartupPath & "\db\sistemaContabil.mdb"
    Public sql, user_logado, classificacao As String
    Public id, ultimaConta, clicado, cont As Integer
    Public valoratual, valorantigo, valorTotal As Double

    Sub user_login()
        With frm_menu
            .btn_show_user.selected = False
            .btn_show_contas.selected = True
            .btn_show_bens.selected = False
            .btn_show_report.selected = False
            .pn_contas.Visible = True
            .pn_bens.Visible = False
            .pn_acesso.Visible = False
            .pn_relatorio.Visible = False
            sql = "select * from tb_user where login_user='" & user_logado & "'"
            rs = db.Execute(sql)
            .lbl_user_logado.Text = rs.Fields(2).Value
        End With

    End Sub

    Sub limpar_acessoadm()
        With frm_menu
            .txt_acessoadm_cpf.Clear()
            .txt_acessoadm_email.Clear()
            .txt_acessoadm_login.Clear()
            .txt_acessoadm_nome.Clear()
            .txt_acessoadm_senha1.Clear()
            .txt_acessoadm_senha2.Clear()
            .chk_acessoadm_admin.Checked = False
            .txt_acessoadm_nome.Select()
        End With
    End Sub

    Sub limpar_acessoop()
        With frm_menu
            .txt_acessoop_login.Clear()
            .txt_acessoop_senha1.Clear()
            .txt_acessoop_senha2.Clear()
            .txt_acessoop_senha3.Clear()
            .txt_acessoop_login.Select()
        End With
    End Sub

    Sub limpar_tudo()
        limpar_acessoadm()
        limpar_acessoop()
    End Sub

    Sub registro_acesso()
        Dim hoje As DateTime = Now
        sql = "UPDATE tb_user SET ultimo_acesso ='" & hoje & "' where login_user ='" & user_logado & "'"
        rs = db.Execute(sql)
    End Sub

    Sub conexao_banco()
        Try
            db = CreateObject("ADODB.Connection")
            db.Open("Provider=Microsoft.jet.OLEDB.4.0;data source=" & conexao)
        Catch ex As Exception
            MsgBox("Conexão falhou")
        End Try
    End Sub
End Module

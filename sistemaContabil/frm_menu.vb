Public Class frm_menu

#Region "BLOCO - FORM PRINCIPAL"
    Private Sub btn_show_menu_Click(sender As Object, e As EventArgs) Handles btn_show_menu.Click
        If (pn_menu.Width = 195) Then
            pn_menu.Width = 50
            pic_logomin.Visible = True
            pic_logomax.Visible = False
        Else
            pn_menu.Width = 195
            pic_logomin.Visible = False
            pic_logomax.Visible = True
        End If
    End Sub
    Private Sub btn_fecha_Click(sender As Object, e As EventArgs) Handles btn_fecha.Click
        Me.Close()
    End Sub

    Private Sub btn_minimiza_Click(sender As Object, e As EventArgs) Handles btn_minimiza.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
        Dim resp = MsgBox("Tem certeza que deseja sair?", vbYesNo)
        If resp = MsgBoxResult.Yes Then
            user_logado = vbEmpty
            limpar_tudo()
            frm_login.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub btn_show_contas_Click(sender As Object, e As EventArgs) Handles btn_show_contas.Click
        pn_acesso.Visible = False
        pn_relatorio.Visible = False
        pn_bens.Visible = False
        pn_contas.Visible = True
        pn_cadastroempresa.Visible = False

        sql = "select * from conta order by classificacaoInterna ASC"
        rs = db.Execute(sql)

        With dgv_conta
            .Rows.Clear()
            Do While rs.EOF = False
                .Rows.Add(rs.Fields(4).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value)
                rs.MoveNext()
            Loop
        End With
    End Sub

    Private Sub btn_show_bens_Click(sender As Object, e As EventArgs) Handles btn_show_bens.Click
        pn_acesso.Visible = False
        pn_relatorio.Visible = False
        pn_bens.Visible = True
        pn_contas.Visible = False
        pn_cadastroempresa.Visible = False

        sql = "select * from bens order by codigo ASC"
        rs = db.Execute(sql)

        With dgv_bens
            .Rows.Clear()
            Do While rs.EOF = False
                .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(4).Value, rs.Fields(5).Value)
                rs.MoveNext()
            Loop
        End With

    End Sub
    Private Sub btn_show_empresa_Click(sender As Object, e As EventArgs) Handles btn_show_empresa.Click
        pn_acesso.Visible = False
        pn_relatorio.Visible = False
        pn_bens.Visible = False
        pn_contas.Visible = False
        pn_cadastroempresa.Visible = True

        sql = "select * from empresa order by Código ASC"
        rs = db.Execute(sql)

        With dgv_empresa
            .Rows.Clear()
            Do While rs.EOF = False
                .Rows.Add(rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(4).Value, rs.Fields(5).Value)
                rs.MoveNext()
            Loop
        End With
    End Sub

    Private Sub btn_show_report_Click(sender As Object, e As EventArgs) Handles btn_show_report.Click
        pn_acesso.Visible = False
        pn_relatorio.Visible = True
        pn_bens.Visible = False
        pn_contas.Visible = False
        pn_cadastroempresa.Visible = False
    End Sub

    Private Sub btn_show_user_Click(sender As Object, e As EventArgs) Handles btn_show_user.Click
        pn_acesso.Visible = True
        pn_relatorio.Visible = False
        pn_bens.Visible = False
        pn_contas.Visible = False
        pn_cadastroempresa.Visible = False

        sql = "select * from tb_user where login_user='" & user_logado & "'"
        rs = db.Execute(sql)

        If rs.EOF() = False Then
            If rs.Fields(6).Value <> "Administrador" Then
                tab_admin.TabPages.Remove(tab_adm)
            End If
        End If
        clicado = 0

    End Sub

    Private Sub frm_menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexao_banco()
        Dim toolTip1 As New ToolTip()
        toolTip1.AutoPopDelay = 5000
        toolTip1.InitialDelay = 1000
        toolTip1.ReshowDelay = 500
        ' Força a o texto da ToolTip a ser exibido mesmo que o form não esta ativo
        toolTip1.ShowAlways = True
        ' Define o texto da ToolTip para o Button, TextBox, Checkbox e Label
        toolTip1.SetToolTip(Me.btn_fecha, "Fechar")
        toolTip1.SetToolTip(Me.btn_minimiza, "Minimizar")
        toolTip1.SetToolTip(Me.btn_logout, "Fazer Logoff")
        toolTip1.SetToolTip(Me.btn_acessoadm_relatorio, "Relatório de funcionários")
        cmb_conta_1c.Items.Clear()
        cmb_conta_1c.Items.Add("ATIVO")
        cmb_conta_1c.Items.Add("PASSIVO")
        cmb_bens_tipo.Items.Clear()
        cmb_bens_tipo.Items.Add("AUTOMÓVEL")
        cmb_bens_tipo.Items.Add("IMÓVEL")
        cmb_bens_tipo.Items.Add("MÓVEL")
        cmb_bens_tipo.Items.Add("COMPUTADORES")
        dtp_bens_final.Value = Now.Date



        sql = "select * from conta order by classificacaoInterna ASC"
        rs = db.Execute(sql)

        With dgv_conta
            .Rows.Clear()
            Do While rs.EOF = False
                .Rows.Add(rs.Fields(4).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, Nothing, Nothing, Nothing)
                rs.MoveNext()
            Loop
        End With



    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbl_hora.Text = (DateTime.Now.ToString("HH:mm"))
        lbl_data.Text = (DateTime.Now.ToString("dd/MM/yyyy"))
    End Sub
#End Region

#Region "BLOCO - ACESSO"

#Region "BLOCO - ADM"
    Private Sub btn_acessoadm_salvar_Click(sender As Object, e As EventArgs) Handles btn_acessoadm_salvar.Click
        Dim acesso As String

        If txt_acessoadm_login.Text = "" Or txt_acessoadm_email.Text = "" Or txt_acessoadm_cpf.Text = "" Or txt_acessoadm_nome.Text = "" Or txt_acessoadm_senha1.Text = "" Then
            MsgBox("Preencha todos os campos", vbOKOnly, "Atenção!")
        Else
            If chk_acessoadm_admin.Checked = True Then
                acesso = "Administrador"
            Else
                acesso = "Operador"
            End If
            If txt_acessoadm_senha1.Text <> txt_acessoadm_senha2.Text Then
                MsgBox("Senhas não conferem", vbOKOnly, "Erro!")
                txt_acessoadm_senha1.Clear()
                txt_acessoadm_senha2.Clear()
                txt_acessoadm_senha1.Select()
            Else
                sql = "select * from tb_user where login_user='" & txt_acessoadm_login.Text & "'"
                rs = db.Execute(sql)

                If rs.EOF = False Then
                    MsgBox("Nome de usuário já em uso", vbOKOnly, "Atenção!")
                Else
                    Dim hoje As DateTime = Now
                    Dim limpo As String = "00/00/00 00:00:00"
                    sql = "insert into tb_user (cpf_user, nome_user, login_user, senha_user, email_user, tipo_user, criacao_acesso, ultimo_acesso) values ('" & txt_acessoadm_cpf.Text & "','" & txt_acessoadm_nome.Text & "','" & txt_acessoadm_login.Text & "','" & txt_acessoadm_senha1.Text & "','" & txt_acessoadm_email.Text & "','" & acesso & "','" & hoje & "','" & limpo & "')"
                    rs = db.Execute(sql)
                    MsgBox("Funcionário cadastrado com sucesso!", vbOKOnly, "Sucesso!")
                    limpar_acessoadm()
                End If
            End If
        End If
    End Sub

    Private Sub btn_acessoadm_cancel_Click(sender As Object, e As EventArgs) Handles btn_acessoadm_cancel.Click
        limpar_acessoadm()
    End Sub

#Region "SUBBLOCO - EFEITO VISUAL"
    Private Sub btn_acessoadm_hide_Click(sender As Object, e As EventArgs) Handles btn_acessoadm_hide.Click
        If clicado = 0 Then
            btn_acessoadm_hide.Image = My.Resources.Resources.Hide_48px
            txt_acessoadm_senha1.PasswordChar = "•"
            txt_acessoadm_senha2.PasswordChar = "•"
            clicado = 1
        ElseIf clicado = 1 Then
            btn_acessoadm_hide.Image = My.Resources.Resources.Eye_48px
            txt_acessoadm_senha1.PasswordChar = ""
            txt_acessoadm_senha2.PasswordChar = ""
            clicado = 0
        End If
    End Sub

    Private Sub txt_acessoadm_nome_Leave(sender As Object, e As EventArgs) Handles txt_acessoadm_nome.Leave
        If (txt_acessoadm_nome.Text = "") Then
            txt_acessoadm_nome.Text = "Nome"
        End If
    End Sub

    Private Sub txt_acessoadm_nome_Enter(sender As Object, e As EventArgs) Handles txt_acessoadm_nome.Enter
        If (txt_acessoadm_nome.Text = "Nome") Then
            txt_acessoadm_nome.Text = ""
        End If
    End Sub

    Private Sub txt_acessoadm_login_Leave(sender As Object, e As EventArgs) Handles txt_acessoadm_login.Leave
        If (txt_acessoadm_login.Text = "") Then
            txt_acessoadm_login.Text = "Login"
        End If
    End Sub

    Private Sub txt_acessoadm_login_Enter(sender As Object, e As EventArgs) Handles txt_acessoadm_login.Enter
        If (txt_acessoadm_login.Text = "Login") Then
            txt_acessoadm_login.Text = ""
        End If
    End Sub

    Private Sub txt_acessoadm_email_Leave(sender As Object, e As EventArgs) Handles txt_acessoadm_email.Leave
        If (txt_acessoadm_email.Text = "") Then
            txt_acessoadm_email.Text = "E-mail"
        End If
    End Sub

    Private Sub txt_acessoadm_email_Enter(sender As Object, e As EventArgs) Handles txt_acessoadm_email.Enter
        If (txt_acessoadm_email.Text = "E-mail") Then
            txt_acessoadm_email.Text = ""
        End If
    End Sub

    Private Sub txt_acessoadm_Senha1_Leave(sender As Object, e As EventArgs) Handles txt_acessoadm_senha1.Leave
        If (txt_acessoadm_senha1.Text = "") Then
            txt_acessoadm_senha1.Text = "Senha"
        End If
    End Sub

    Private Sub txt_acessoadm_Senha1_Enter(sender As Object, e As EventArgs) Handles txt_acessoadm_senha1.Enter
        If (txt_acessoadm_senha1.Text = "Senha") Then
            txt_acessoadm_senha1.PasswordChar = "•"
            txt_acessoadm_senha1.Text = ""
        End If
    End Sub

    Private Sub txt_acessoadm_Senha2_Leave(sender As Object, e As EventArgs) Handles txt_acessoadm_senha2.Leave
        If (txt_acessoadm_senha2.Text = "") Then
            txt_acessoadm_senha2.Text = "Confirmar Senha"
        End If
    End Sub

    Private Sub txt_acessoadm_Senha2_Enter(sender As Object, e As EventArgs) Handles txt_acessoadm_senha2.Enter
        If (txt_acessoadm_senha2.Text = "Confirmar Senha") Then
            txt_acessoadm_senha2.PasswordChar = "•"
            txt_acessoadm_senha2.Text = ""
        End If
    End Sub
#End Region

#End Region

#Region "BLOCO - OPERADOR"
    Private Sub btn_acessoop_salvar_Click(sender As Object, e As EventArgs) Handles btn_acessoop_salvar.Click
        If txt_acessoop_login.Text = "" Then
            MsgBox("Campo login não pode ficar vazio!", vbOKOnly, "Atenção!")
        Else
            If txt_acessoop_senha2.Text <> txt_acessoop_senha3.Text Then
                MsgBox("As senhas diferem!", vbOKOnly, "Atenção!")
                txt_acessoop_senha2.Clear()
                txt_acessoop_senha3.Clear()
                txt_acessoop_senha2.Select()
            Else
                sql = "select * from tb_user where login_user='" & txt_acessoop_login.Text & "'"
                rs = db.Execute(sql)

                If rs.EOF = False Then
                    If txt_acessoop_senha1.Text = rs.Fields(4).Value Then
                        sql = "update tb_user set senha_user='" & txt_acessoop_senha2.Text & "' where login_user='" & txt_acessoop_login.Text & "'"
                        rs = db.Execute(sql)
                        MsgBox("Senha Alterada com sucesso!", vbOKOnly, "Sucesso!")
                        limpar_acessoop()
                    Else
                        MsgBox("Senha incorreta!", vbOKOnly, "Erro!")
                    End If
                Else
                    MsgBox("Usuário não localizado!", vbOKOnly, "Erro!")
                End If
            End If
        End If


    End Sub

    Private Sub btn_acessoop_cancel_Click(sender As Object, e As EventArgs) Handles btn_acessoop_cancel.Click
        limpar_acessoop()
    End Sub

#Region "SUBBLOCO - EFEITO VISUAL"
    Private Sub btn_acessoop_hide_Click(sender As Object, e As EventArgs) Handles btn_acessoop_hide.Click
        If clicado = 0 Then
            btn_acessoop_hide.Image = My.Resources.Resources.Hide_48px
            txt_acessoop_senha1.PasswordChar = "•"
            txt_acessoop_senha2.PasswordChar = "•"
            txt_acessoop_senha3.PasswordChar = "•"
            clicado = 1
        ElseIf clicado = 1 Then
            btn_acessoop_hide.Image = My.Resources.Resources.Eye_48px
            txt_acessoop_senha1.PasswordChar = ""
            txt_acessoop_senha2.PasswordChar = ""
            txt_acessoop_senha3.PasswordChar = ""
            clicado = 0
        End If
    End Sub


    Private Sub txt_acessoop_login_Leave(sender As Object, e As EventArgs) Handles txt_acessoop_login.Leave
        If (txt_acessoop_login.Text = "") Then
            txt_acessoop_login.Text = "Login"
        End If
    End Sub

    Private Sub txt_acessoop_login_Enter(sender As Object, e As EventArgs) Handles txt_acessoop_login.Enter
        If (txt_acessoop_login.Text = "Login") Then
            txt_acessoop_login.Text = ""
        End If
    End Sub



    Private Sub txt_acessoop_senha1_Leave(sender As Object, e As EventArgs) Handles txt_acessoop_senha1.Leave
        If (txt_acessoop_senha1.Text = "") Then
            txt_acessoop_senha1.Text = "Senha"
        End If
    End Sub

    Private Sub txt_acessoop_senha1_Enter(sender As Object, e As EventArgs) Handles txt_acessoop_senha1.Enter
        If (txt_acessoop_senha1.Text = "Senha") Then
            txt_acessoop_senha1.PasswordChar = "•"
            txt_acessoop_senha1.Text = ""
        End If
    End Sub

    Private Sub txt_acessoop_senha2_Leave(sender As Object, e As EventArgs) Handles txt_acessoop_senha2.Leave
        If (txt_acessoop_senha2.Text = "") Then
            txt_acessoop_senha2.Text = "Nova senha"
        End If
    End Sub

    Private Sub txt_acessoop_senha2_Enter(sender As Object, e As EventArgs) Handles txt_acessoop_senha2.Enter
        If (txt_acessoop_senha2.Text = "Nova senha") Then
            txt_acessoop_senha2.PasswordChar = "•"
            txt_acessoop_senha2.Text = ""
        End If
    End Sub

    Private Sub txt_acessoop_senha3_Leave(sender As Object, e As EventArgs) Handles txt_acessoop_senha3.Leave
        If (txt_acessoop_senha3.Text = "") Then
            txt_acessoop_senha3.Text = "Confirmar Senha"
        End If
    End Sub

    Private Sub txt_acessoop_senha3_Enter(sender As Object, e As EventArgs) Handles txt_acessoop_senha3.Enter
        If (txt_acessoop_senha3.Text = "Confirmar Senha") Then
            txt_acessoop_senha3.PasswordChar = "•"
            txt_acessoop_senha3.Text = ""
        End If
    End Sub



#End Region

#End Region


#End Region

#Region "BLOCO - CONTAS"
    Private Sub cmb_conta_1c_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_conta_1c.SelectedIndexChanged
        cmb_conta_2c.Text = ""
        cmb_conta_3c.Text = ""
        If cmb_conta_3c.Text = "" Then
            txt_conta_nome.Enabled = False
            txt_conta_valor.Enabled = False
            txt_conta_nome.Clear()
            txt_conta_valor.Clear()
        Else
            txt_conta_nome.Enabled = True
            txt_conta_valor.Enabled = True
        End If

        cmb_conta_2c.Items.Clear()
        cmb_conta_3c.Items.Clear()
        If (cmb_conta_1c.Text = "ATIVO") Then
            cmb_conta_2c.Items.Clear()
            cmb_conta_2c.Items.Add("ATIVO CIRCULANTE")
            cmb_conta_2c.Items.Add("ATIVO NÃO CIRCULANTE")
        ElseIf (cmb_conta_1c.Text = "PASSIVO") Then
            cmb_conta_2c.Items.Clear()
            cmb_conta_2c.Items.Add("PASSIVO CIRCULANTE")
            cmb_conta_2c.Items.Add("PASSIVO NÃO CIRCULANTE")
            cmb_conta_2c.Items.Add("PATRIMÔNIO LÍQUIDO")
        End If

        If (cmb_conta_1c.Text = "ATIVO") Then
            classificacao = "1"
        ElseIf (cmb_conta_1c.Text = "PASSIVO") Then
            classificacao = "2"
        End If

        sql = "select * from conta where classificacaoInterna like '" & classificacao & "%' order by classificacaoInterna ASC"
        rs = db.Execute(sql)

        With dgv_conta
            .Rows.Clear()
            Do While rs.EOF = False
                .Rows.Add(rs.Fields(4).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value)
                rs.MoveNext()
            Loop
        End With
    End Sub

    Private Sub cmb_conta_2c_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_conta_2c.SelectedIndexChanged
        cmb_conta_3c.Text = ""
        cmb_conta_3c.Items.Clear()
        If cmb_conta_3c.Text = "" Then
            txt_conta_nome.Enabled = False
            txt_conta_valor.Enabled = False
            txt_conta_nome.Clear()
            txt_conta_valor.Clear()
        Else
            txt_conta_nome.Enabled = True
            txt_conta_valor.Enabled = True
        End If

        If (cmb_conta_2c.Text = "ATIVO CIRCULANTE") Then
            cmb_conta_3c.Items.Clear()
            cmb_conta_3c.Items.Add("Disponível")
            cmb_conta_3c.Items.Add("Direitos a Receber C.P.")
            cmb_conta_3c.Items.Add("Estoque")
            cmb_conta_3c.Items.Add("Despesas Diferidas")
        ElseIf (cmb_conta_2c.Text = "ATIVO NÃO CIRCULANTE") Then
            cmb_conta_3c.Items.Clear()
            cmb_conta_3c.Items.Add("Direitos a Receber L.P.")
            cmb_conta_3c.Items.Add("Investimentos")
            cmb_conta_3c.Items.Add("Imobilizado")
            cmb_conta_3c.Items.Add("Intangível")
        ElseIf (cmb_conta_2c.Text = "PASSIVO CIRCULANTE") Then
            cmb_conta_3c.Items.Clear()
            cmb_conta_3c.Items.Add("Obrigações C.P.")
        ElseIf (cmb_conta_2c.Text = "PASSIVO NÃO CIRCULANTE") Then
            cmb_conta_3c.Items.Clear()
            cmb_conta_3c.Items.Add("Obrigações L.P.")
            cmb_conta_3c.Items.Add("Receitas recebidas antecipadamente")
        ElseIf (cmb_conta_2c.Text = "PATRIMÔNIO LÍQUIDO") Then
            cmb_conta_3c.Items.Clear()
            cmb_conta_3c.Items.Add("Capital Social")
            cmb_conta_3c.Items.Add("Prejuízos Acumulados")
            cmb_conta_3c.Items.Add("Reservas")
        End If

        If (cmb_conta_2c.Text = "ATIVO CIRCULANTE") Then
            classificacao = "1.1"
        ElseIf (cmb_conta_2c.Text = "ATIVO NÃO CIRCULANTE") Then
            classificacao = "1.2"
        ElseIf (cmb_conta_2c.Text = "PASSIVO CIRCULANTE") Then
            classificacao = "2.1"
        ElseIf (cmb_conta_2c.Text = "PASSIVO NÃO CIRCULANTE") Then
            classificacao = "2.2"
        ElseIf (cmb_conta_2c.Text = "PATRIMÔNIO LÍQUIDO") Then
            classificacao = "2.2"
        End If

        sql = "select * from conta where classificacaoInterna like '" & classificacao & "%' order by classificacaoInterna ASC"
        rs = db.Execute(sql)

        With dgv_conta
            .Rows.Clear()
            Do While rs.EOF = False
                .Rows.Add(rs.Fields(4).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value)
                rs.MoveNext()
            Loop
        End With

    End Sub
    Private Sub cmb_conta_3c_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_conta_3c.SelectedIndexChanged
        If cmb_conta_3c.Text = "" Then
            txt_conta_nome.Enabled = False
            txt_conta_valor.Enabled = False
            txt_conta_nome.Clear()
            txt_conta_valor.Clear()
        Else
            txt_conta_nome.Enabled = True
            txt_conta_valor.Enabled = True
        End If

        If (cmb_conta_3c.Text = "Disponível") Then
            classificacao = "1.1.1"
        ElseIf (cmb_conta_3c.Text = "Direitos a Receber C.P.") Then
            classificacao = "1.1.2"
        ElseIf (cmb_conta_3c.Text = "Estoque") Then
            classificacao = "1.1.3"
        ElseIf (cmb_conta_3c.Text = "Despesas Diferidas") Then
            classificacao = "1.1.4"
        ElseIf (cmb_conta_3c.Text = "Direitos a Receber L.P.") Then
            classificacao = "1.2.1"
        ElseIf (cmb_conta_3c.Text = "Investimentos") Then
            classificacao = "1.2.2"
        ElseIf (cmb_conta_3c.Text = "Imobilizado") Then
            classificacao = "1.2.3"
        ElseIf (cmb_conta_3c.Text = "Intangível") Then
            classificacao = "1.2.4"
        ElseIf (cmb_conta_3c.Text = "Obrigações C.P.") Then
            classificacao = "2.1.1"
        ElseIf (cmb_conta_3c.Text = "Obrigações L.P.") Then
            classificacao = "2.2.1"
        ElseIf (cmb_conta_3c.Text = "Receitas recebidas antecipadamente") Then
            classificacao = "2.2.2"
        ElseIf (cmb_conta_3c.Text = "Capital Social") Then
            classificacao = "2.3.1"
        ElseIf (cmb_conta_3c.Text = "Prejuízos Acumulados") Then
            classificacao = "2.3.2"
        ElseIf (cmb_conta_3c.Text = "Reservas") Then
            classificacao = "2.3.3"
        End If

        sql = "select * from conta where classificacaoInterna like '" & classificacao & "%' order by classificacaoInterna ASC"
        rs = db.Execute(sql)

        With dgv_conta
            .Rows.Clear()
            Do While rs.EOF = False
                .Rows.Add(rs.Fields(4).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value)
                rs.MoveNext()
            Loop
        End With
    End Sub

    Private Sub btn_conta_add_Click(sender As Object, e As EventArgs) Handles btn_conta_add.Click
        Dim codigo, ordem As Integer
        If (cmb_conta_1c.Text = "" Or cmb_conta_2c.Text = "" Or cmb_conta_3c.Text = "" Or txt_conta_valor.Text = "" Or txt_conta_nome.Text = "") Then
            MsgBox("Preencha todos os campos", vbOKOnly, "Atenção!")
        Else
            sql = "select*from conta"
            rs = db.Execute(sql)
            cont = 1
            Do While rs.EOF = False
                cont = cont + 1
                rs.MoveNext()
            Loop
            codigo = cont

            sql = "select * from conta where classificacaoInterna like '" & classificacao & "%'  order by classificacaoInterna ASC"
            rs = db.Execute(sql)
            cont = 1
            Do While rs.EOF = False
                cont = cont + 1
                rs.MoveNext()
            Loop

            ordem = cont - 1

            sql = "insert into conta (codigo, classificacaoInterna, classificacaoExterna, saldo, nome_conta) values (" & codigo & ",'" & classificacao & "." & ordem & "' , '" & cmb_conta_3c.Text & "' , '" & txt_conta_valor.Text & "','" & txt_conta_nome.Text & "')"
            rs = db.Execute(sql)
            MsgBox("Conta adicionada com sucesso!", vbOKOnly, "Sucesso!")
            sql = "select * from conta where classificacaoInterna like '" & classificacao & "%' order by classificacaoInterna ASC"
            rs = db.Execute(sql)

            With dgv_conta
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(rs.Fields(4).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value)
                    rs.MoveNext()
                Loop
            End With
        End If


    End Sub

    Private Sub txt_conta_nome_TextChanged(sender As Object, e As EventArgs) Handles txt_conta_nome.TextChanged
        sql = "select * from conta where classificacaoInterna like '" & classificacao & "%'  order by classificacaoInterna ASC"
        rs = db.Execute(sql)

        With dgv_conta
            .Rows.Clear()
            Do While rs.EOF = False
                .Rows.Add(rs.Fields(4).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, Nothing, Nothing, Nothing)
                rs.MoveNext()
            Loop
        End With
    End Sub

#End Region

#Region "BLOCO - BENS"
    Private Sub btn_bens_add_Click(sender As Object, e As EventArgs) Handles btn_bens_add.Click
        Dim cont, ordem, codigo As Integer
        classificacao = "1.2.3"

        sql = "select*from conta"
        rs = db.Execute(sql)
        cont = 1
        Do While rs.EOF = False
            cont = cont + 1
            rs.MoveNext()
        Loop
        codigo = cont

        sql = "select * from conta where classificacaoInterna like '" & classificacao & "%'  order by classificacaoInterna ASC"
        rs = db.Execute(sql)
        cont = 1
        Do While rs.EOF = False
            cont = cont + 1
            rs.MoveNext()
        Loop

        ordem = cont - 1

        sql = "insert into conta (codigo, classificacaoInterna, classificacaoExterna, saldo, nome_conta) values (" & codigo & ",'" & classificacao & "." & ordem & "' , 'Imobilizado' , '" & txt_bens_valorfi.Text & "','" & txt_bens_nome.Text & "')"
        rs = db.Execute(sql)

        sql = "select*from bens"
        rs = db.Execute(sql)
        cont = 1
        Do While rs.EOF = False
            cont = cont + 1
            rs.MoveNext()
        Loop
        codigo = cont

        sql = "insert into bens (codigo, nome, tipo, dataCompra, valorInicial, valorAtual, valorDepreciado, taxaDepreciacao, id_conta) values (" & codigo & ",'" & txt_bens_nome.Text & "','" & cmb_bens_tipo.Text & "','" & dtp_bens_inicial.Value & "'," & txt_bens_valorini.Text & "," & txt_bens_depreciacao.Text & "," & txt_bens_taxa.Value & ")"
        rs = db.Execute(sql)

        sql = "select * from bens order by codigo asc"
        rs = db.Execute(sql)

        With dgv_bens
            .Rows.Clear()
            Do While rs.EOF = False
                .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(4).Value, rs.Fields(5).Value)
                rs.MoveNext()
            Loop
        End With

    End Sub

    Private Sub dtp_bens_inicial_Leave(sender As Object, e As EventArgs) Handles dtp_bens_inicial.Leave
        Dim dtini As DateTime = dtp_bens_inicial.Value
        Dim dtfim As DateTime = dtp_bens_final.Value
        Dim diferencaano As String
        Dim depreciacao As Double
        diferencaano = DateDiff(DateInterval.Year, dtini, dtfim).ToString() + vbCrLf

        depreciacao = CDbl(txt_bens_valorini.Text) * ((txt_bens_taxa.Value / 100) * diferencaano)
        txt_bens_depreciacao.Text = depreciacao
        txt_bens_valorfi.Text = CDbl(txt_bens_valorini.Text) - depreciacao

    End Sub


#End Region
#Region "BLOCO - EMPRESA"
    Private Sub btn_empresa_add_Click(sender As Object, e As EventArgs) Handles btn_empresa_add.Click
        If txt_empres_respo.Text = "" Or txt_empres_nome.Text = "" Or txt_empresa_enderaco.Text = "" Or txt_empresa_cnpj.Text = "" Or txt_empresa_cep.Text = "" Then
            MsgBox("Preencha todos os campos", vbOKOnly, "Atenção!")
        Else
            sql = "insert into empresa (nome_empresa, CEP_empresa, CNPJ_empresa, endereco, Responsavel_empresa) values ('" & txt_empres_nome.Text & "','" & txt_empresa_cep.Text & "','" & txt_empresa_cnpj.Text & "','" & txt_empresa_enderaco.Text & "','" & txt_empres_respo.Text & "')"
            rs = db.Execute(sql)
            MsgBox("Empresa cadastrada", vbOKOnly, "Sucesso!")

            sql = "select * from empresa"
            rs = db.Execute(sql)

            With dgv_empresa
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(4).Value, rs.Fields(5).Value)
                    rs.MoveNext()
                Loop
            End With
        End If

    End Sub



#End Region

    Private Sub lbl_bens_Click(sender As Object, e As EventArgs) Handles lbl_bens.Click
        Panel9.Visible = False
    End Sub

    Private Sub lbl_empresa_Click(sender As Object, e As EventArgs) Handles lbl_empresa.Click
        Panel8.Visible = False
    End Sub

    Private Sub bt_relatorio_empresa_Click(sender As Object, e As EventArgs) Handles bt_relatorio_empresa.Click
        Panel8.Visible = True
    End Sub

    Private Sub bt_relatorio_bens_Click(sender As Object, e As EventArgs) Handles bt_relatorio_bens.Click
        Panel9.Visible = True
    End Sub

    Private Sub lbl_usuario_Click(sender As Object, e As EventArgs) Handles lbl_usuario.Click
        Panel13.Visible = False
    End Sub

    Private Sub btn_acessoadm_relatorio_Click(sender As Object, e As EventArgs) Handles btn_acessoadm_relatorio.Click
        Panel13.Visible = True
    End Sub
End Class

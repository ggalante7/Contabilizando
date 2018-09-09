Imports System
Imports System.Net
Imports System.Net.Mail
Imports System.Net.Mail.MailMessage

Public Class frm_login
    Private Sub btn_fecha_Click(sender As Object, e As EventArgs) Handles btn_fecha.Click
        Me.Close()
    End Sub

    Private Sub btn_minimiza_Click(sender As Object, e As EventArgs) Handles btn_minimiza.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbl_hora.Text = (DateTime.Now.ToString("HH:mm"))
        lbl_data.Text = (DateTime.Now.ToString("dd/MM/yyyy"))
    End Sub

    Private Sub txt_user_Leave(sender As Object, e As EventArgs) Handles txt_user.Leave
        If (txt_user.Text = "") Then
            txt_user.Text = "usuario"
        End If
    End Sub

    Private Sub txt_user_Enter(sender As Object, e As EventArgs) Handles txt_user.Enter
        If (txt_user.Text = "usuario") Then
            txt_user.Text = ""
        End If
    End Sub

    Private Sub lbl_recuperar_MouseEnter(sender As Object, e As EventArgs) Handles lbl_recuperar.MouseEnter
        lbl_recuperar.ForeColor = Color.FromArgb(40, 174, 192)
    End Sub

    Private Sub lbl_recuperar_MouseLeave(sender As Object, e As EventArgs) Handles lbl_recuperar.MouseLeave
        lbl_recuperar.ForeColor = Color.Black
    End Sub

    Private Sub frm_login_Load(sender As Object, e As EventArgs) Handles Me.Load
        conexao_banco()
    End Sub

#Region "BLOCO - LOGIN"
    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        If txt_user.Text = "" Or txt_senha.Text = "" Then
            MsgBox("Preencha os campos corretamente")
            Exit Sub
        Else
            sql = "select * from tb_user where login_user = '" & txt_user.Text & "'"
            rs = db.Execute(sql)

            If rs.EOF = False Then
                If txt_senha.Text = rs.Fields(4).Value Then
                    user_logado = rs.Fields(3).Value

                    frm_menu.Show()
                    txt_user.Text = ""
                    txt_senha.Text = ""
                    Me.Hide()
                    user_login()
                    registro_acesso()
                Else
                    MsgBox("Senha Incorreta")
                End If
            Else
                MsgBox("Usuário não localizado")
            End If
        End If
    End Sub

    Private Sub lbl_recuperar_Click(sender As Object, e As EventArgs) Handles lbl_recuperar.Click
        pn_login.Visible = False
        pn_email.Visible = True
    End Sub
#End Region


#Region "BLOCO - EMAIL"

    Private Sub btn_enviar_Click(sender As Object, e As EventArgs) Handles btn_enviar.Click
        Dim senha, nome As String

        If (txtEmail.Text = "") Then
            MsgBox("Preencha os campos corretamente")
            Exit Sub
        End If

        sql = "Select * from tb_user where email_user = '" & txtEmail.Text & "'"
        rs = db.Execute(sql)

        If rs.EOF = False Then

            senha = rs.Fields(4).Value
            nome = rs.Fields(2).Value

            Dim SmtpServer As New SmtpClient()
            Dim mail As New MailMessage()
            SmtpServer.UseDefaultCredentials = False
            SmtpServer.Credentials = New Net.NetworkCredential("ctbzcontato@gmail.com", "1berto444")
            SmtpServer.Host = "smtp.gmail.com"
            SmtpServer.Port = 587 'server para gmail
            SmtpServer.EnableSsl = True
            mail.From = New MailAddress("ctbzcontato@gmail.com") 'mail from ou seja de quem manda o e-mail
            mail.Subject = "[CONTABILIZANDO] Estamos enviando sua senha"
            mail.To.Add(txtEmail.Text)

            mail.Body = "<h3>Sr(a) " + nome + "</h3><p>Você, solicitou o envio da senha. </p><p>Sua senha é : " + senha + "</p><p>Att.Contabilizando</p>"

            mail.IsBodyHtml = True
            SmtpServer.Send(mail)
            MsgBox("E-mail enviado com sucesso", vbInformation + vbOKOnly, "Atenção!")
            pn_login.Visible = True
            pn_email.Visible = False
        Else
            MsgBox("E-mail não cadastrado")
            Exit Sub
        End If
    End Sub

    Private Sub txtEmail_Leave(sender As Object, e As EventArgs) Handles txtEmail.Leave
        If (txtEmail.Text = "") Then
            txtEmail.Text = "e-mail"
        End If
    End Sub

    Private Sub txtEmail_Enter(sender As Object, e As EventArgs) Handles txtEmail.Enter
        If (txtEmail.Text = "e-mail") Then
            txtEmail.Text = ""
        End If
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        pn_email.Visible = False
        pn_login.Visible = True
    End Sub
#End Region


End Class
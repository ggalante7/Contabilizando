<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_login
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_login))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.pn_header = New System.Windows.Forms.Panel()
        Me.btn_minimiza = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btn_fecha = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.img_pass = New Bunifu.Framework.UI.BunifuImageButton()
        Me.txt_senha = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.img_login = New Bunifu.Framework.UI.BunifuImageButton()
        Me.txt_user = New System.Windows.Forms.TextBox()
        Me.BunifuElipse2 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuElipse3 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.btn_login = New System.Windows.Forms.Button()
        Me.BunifuElipse4 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.pn_login = New System.Windows.Forms.Panel()
        Me.lbl_recuperar = New System.Windows.Forms.Label()
        Me.lbl_hora = New System.Windows.Forms.Label()
        Me.lbl_data = New System.Windows.Forms.Label()
        Me.pic_logo = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.pn_email = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_enviar = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.BunifuElipse5 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuElipse6 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuElipse7 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.pn_header.SuspendLayout()
        CType(Me.btn_minimiza, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_fecha, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.img_pass, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.img_login, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pn_login.SuspendLayout()
        CType(Me.pic_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pn_email.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 25
        Me.BunifuElipse1.TargetControl = Me
        '
        'pn_header
        '
        Me.pn_header.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.pn_header.Controls.Add(Me.btn_minimiza)
        Me.pn_header.Controls.Add(Me.btn_fecha)
        Me.pn_header.Dock = System.Windows.Forms.DockStyle.Top
        Me.pn_header.Location = New System.Drawing.Point(0, 0)
        Me.pn_header.Name = "pn_header"
        Me.pn_header.Size = New System.Drawing.Size(299, 40)
        Me.pn_header.TabIndex = 0
        '
        'btn_minimiza
        '
        Me.btn_minimiza.BackColor = System.Drawing.Color.Transparent
        Me.btn_minimiza.Image = Global.sistemaContabil.My.Resources.Resources.Minimize_Window_48px1
        Me.btn_minimiza.ImageActive = Nothing
        Me.btn_minimiza.Location = New System.Drawing.Point(222, 7)
        Me.btn_minimiza.Name = "btn_minimiza"
        Me.btn_minimiza.Size = New System.Drawing.Size(29, 29)
        Me.btn_minimiza.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_minimiza.TabIndex = 0
        Me.btn_minimiza.TabStop = False
        Me.btn_minimiza.Zoom = 10
        '
        'btn_fecha
        '
        Me.btn_fecha.BackColor = System.Drawing.Color.Transparent
        Me.btn_fecha.Image = Global.sistemaContabil.My.Resources.Resources.Close_Window_48px
        Me.btn_fecha.ImageActive = Nothing
        Me.btn_fecha.Location = New System.Drawing.Point(259, 8)
        Me.btn_fecha.Name = "btn_fecha"
        Me.btn_fecha.Size = New System.Drawing.Size(28, 28)
        Me.btn_fecha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_fecha.TabIndex = 0
        Me.btn_fecha.TabStop = False
        Me.btn_fecha.Zoom = 10
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.Panel2.Controls.Add(Me.img_pass)
        Me.Panel2.Controls.Add(Me.txt_senha)
        Me.Panel2.Location = New System.Drawing.Point(49, 194)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 40)
        Me.Panel2.TabIndex = 57
        '
        'img_pass
        '
        Me.img_pass.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.img_pass.Image = Global.sistemaContabil.My.Resources.Resources.Password_48px
        Me.img_pass.ImageActive = Nothing
        Me.img_pass.Location = New System.Drawing.Point(2, 3)
        Me.img_pass.Name = "img_pass"
        Me.img_pass.Size = New System.Drawing.Size(35, 35)
        Me.img_pass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.img_pass.TabIndex = 52
        Me.img_pass.TabStop = False
        Me.img_pass.Zoom = 10
        '
        'txt_senha
        '
        Me.txt_senha.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.txt_senha.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_senha.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_senha.Location = New System.Drawing.Point(19, 10)
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.Size = New System.Drawing.Size(166, 20)
        Me.txt_senha.TabIndex = 1
        Me.txt_senha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_senha.UseSystemPasswordChar = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.Panel1.Controls.Add(Me.img_login)
        Me.Panel1.Controls.Add(Me.txt_user)
        Me.Panel1.Location = New System.Drawing.Point(49, 127)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 40)
        Me.Panel1.TabIndex = 56
        '
        'img_login
        '
        Me.img_login.BackColor = System.Drawing.Color.Transparent
        Me.img_login.Image = Global.sistemaContabil.My.Resources.Resources.User_Male_48px
        Me.img_login.ImageActive = Nothing
        Me.img_login.Location = New System.Drawing.Point(2, 3)
        Me.img_login.Name = "img_login"
        Me.img_login.Size = New System.Drawing.Size(35, 35)
        Me.img_login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.img_login.TabIndex = 52
        Me.img_login.TabStop = False
        Me.img_login.Zoom = 10
        '
        'txt_user
        '
        Me.txt_user.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.txt_user.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_user.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_user.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txt_user.Location = New System.Drawing.Point(19, 11)
        Me.txt_user.Name = "txt_user"
        Me.txt_user.Size = New System.Drawing.Size(166, 19)
        Me.txt_user.TabIndex = 0
        Me.txt_user.Text = "usuario"
        Me.txt_user.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BunifuElipse2
        '
        Me.BunifuElipse2.ElipseRadius = 10
        Me.BunifuElipse2.TargetControl = Me.Panel1
        '
        'BunifuElipse3
        '
        Me.BunifuElipse3.ElipseRadius = 10
        Me.BunifuElipse3.TargetControl = Me.Panel2
        '
        'btn_login
        '
        Me.btn_login.AutoEllipsis = True
        Me.btn_login.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_login.FlatAppearance.BorderSize = 0
        Me.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_login.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_login.ForeColor = System.Drawing.Color.White
        Me.btn_login.Location = New System.Drawing.Point(49, 261)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(200, 40)
        Me.btn_login.TabIndex = 59
        Me.btn_login.Text = "Login"
        Me.btn_login.UseVisualStyleBackColor = False
        '
        'BunifuElipse4
        '
        Me.BunifuElipse4.ElipseRadius = 10
        Me.BunifuElipse4.TargetControl = Me.btn_login
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.pn_header
        Me.BunifuDragControl1.Vertical = True
        '
        'pn_login
        '
        Me.pn_login.Controls.Add(Me.lbl_recuperar)
        Me.pn_login.Controls.Add(Me.lbl_hora)
        Me.pn_login.Controls.Add(Me.lbl_data)
        Me.pn_login.Controls.Add(Me.pic_logo)
        Me.pn_login.Controls.Add(Me.btn_login)
        Me.pn_login.Controls.Add(Me.Panel1)
        Me.pn_login.Controls.Add(Me.Panel2)
        Me.pn_login.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pn_login.Location = New System.Drawing.Point(0, 40)
        Me.pn_login.Name = "pn_login"
        Me.pn_login.Size = New System.Drawing.Size(299, 369)
        Me.pn_login.TabIndex = 60
        '
        'lbl_recuperar
        '
        Me.lbl_recuperar.AutoSize = True
        Me.lbl_recuperar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_recuperar.Location = New System.Drawing.Point(97, 303)
        Me.lbl_recuperar.Name = "lbl_recuperar"
        Me.lbl_recuperar.Size = New System.Drawing.Size(104, 13)
        Me.lbl_recuperar.TabIndex = 62
        Me.lbl_recuperar.Text = "Esqueceu a Senha?"
        '
        'lbl_hora
        '
        Me.lbl_hora.AutoSize = True
        Me.lbl_hora.BackColor = System.Drawing.Color.Transparent
        Me.lbl_hora.Location = New System.Drawing.Point(247, 342)
        Me.lbl_hora.Name = "lbl_hora"
        Me.lbl_hora.Size = New System.Drawing.Size(26, 13)
        Me.lbl_hora.TabIndex = 60
        Me.lbl_hora.Text = "time"
        '
        'lbl_data
        '
        Me.lbl_data.AutoSize = True
        Me.lbl_data.BackColor = System.Drawing.Color.Transparent
        Me.lbl_data.Location = New System.Drawing.Point(176, 342)
        Me.lbl_data.Name = "lbl_data"
        Me.lbl_data.Size = New System.Drawing.Size(28, 13)
        Me.lbl_data.TabIndex = 61
        Me.lbl_data.Text = "date"
        '
        'pic_logo
        '
        Me.pic_logo.Image = Global.sistemaContabil.My.Resources.Resources.LOGO01
        Me.pic_logo.Location = New System.Drawing.Point(-1, 36)
        Me.pic_logo.Name = "pic_logo"
        Me.pic_logo.Size = New System.Drawing.Size(299, 64)
        Me.pic_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_logo.TabIndex = 58
        Me.pic_logo.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'pn_email
        '
        Me.pn_email.Controls.Add(Me.PictureBox1)
        Me.pn_email.Controls.Add(Me.btn_cancelar)
        Me.pn_email.Controls.Add(Me.btn_enviar)
        Me.pn_email.Controls.Add(Me.Panel3)
        Me.pn_email.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pn_email.Location = New System.Drawing.Point(0, 40)
        Me.pn_email.Name = "pn_email"
        Me.pn_email.Size = New System.Drawing.Size(299, 369)
        Me.pn_email.TabIndex = 64
        Me.pn_email.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.sistemaContabil.My.Resources.Resources.LOGO01
        Me.PictureBox1.Location = New System.Drawing.Point(-1, 36)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(299, 64)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 62
        Me.PictureBox1.TabStop = False
        '
        'btn_cancelar
        '
        Me.btn_cancelar.AutoEllipsis = True
        Me.btn_cancelar.BackColor = System.Drawing.Color.IndianRed
        Me.btn_cancelar.FlatAppearance.BorderSize = 0
        Me.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancelar.ForeColor = System.Drawing.Color.White
        Me.btn_cancelar.Location = New System.Drawing.Point(156, 260)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(93, 40)
        Me.btn_cancelar.TabIndex = 63
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = False
        '
        'btn_enviar
        '
        Me.btn_enviar.AutoEllipsis = True
        Me.btn_enviar.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_enviar.FlatAppearance.BorderSize = 0
        Me.btn_enviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_enviar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_enviar.ForeColor = System.Drawing.Color.White
        Me.btn_enviar.Location = New System.Drawing.Point(49, 261)
        Me.btn_enviar.Name = "btn_enviar"
        Me.btn_enviar.Size = New System.Drawing.Size(90, 40)
        Me.btn_enviar.TabIndex = 63
        Me.btn_enviar.Text = "Enviar"
        Me.btn_enviar.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.Panel3.Controls.Add(Me.BunifuImageButton1)
        Me.Panel3.Controls.Add(Me.txtEmail)
        Me.Panel3.Location = New System.Drawing.Point(49, 160)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(200, 40)
        Me.Panel3.TabIndex = 60
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton1.Image = Global.sistemaContabil.My.Resources.Resources.Gmail_48px
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.Location = New System.Drawing.Point(2, 3)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(35, 35)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton1.TabIndex = 52
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 10
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtEmail.Location = New System.Drawing.Point(19, 11)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(166, 19)
        Me.txtEmail.TabIndex = 0
        Me.txtEmail.Text = "e-mail"
        Me.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BunifuElipse5
        '
        Me.BunifuElipse5.ElipseRadius = 10
        Me.BunifuElipse5.TargetControl = Me.Panel3
        '
        'BunifuElipse6
        '
        Me.BunifuElipse6.ElipseRadius = 10
        Me.BunifuElipse6.TargetControl = Me.btn_enviar
        '
        'BunifuElipse7
        '
        Me.BunifuElipse7.ElipseRadius = 10
        Me.BunifuElipse7.TargetControl = Me.btn_cancelar
        '
        'frm_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(299, 409)
        Me.Controls.Add(Me.pn_login)
        Me.Controls.Add(Me.pn_email)
        Me.Controls.Add(Me.pn_header)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_login"
        Me.pn_header.ResumeLayout(False)
        CType(Me.btn_minimiza, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_fecha, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.img_pass, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.img_login, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pn_login.ResumeLayout(False)
        Me.pn_login.PerformLayout()
        CType(Me.pic_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pn_email.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents pn_header As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents img_pass As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents txt_senha As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents img_login As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents txt_user As TextBox
    Friend WithEvents BunifuElipse2 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuElipse3 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents pic_logo As PictureBox
    Friend WithEvents btn_login As Button
    Friend WithEvents BunifuElipse4 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents btn_fecha As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btn_minimiza As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents pn_login As Panel
    Friend WithEvents lbl_recuperar As Label
    Friend WithEvents lbl_hora As Label
    Friend WithEvents lbl_data As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents pn_email As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btn_enviar As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents BunifuElipse5 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuElipse6 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents btn_cancelar As Button
    Friend WithEvents BunifuElipse7 As Bunifu.Framework.UI.BunifuElipse
End Class

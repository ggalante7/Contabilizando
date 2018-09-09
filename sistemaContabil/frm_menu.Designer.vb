<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_menu
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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_menu))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.pn_header = New System.Windows.Forms.Panel()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.pn_relatorio = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.lbl_bens = New System.Windows.Forms.Label()
        Me.ReportViewer3 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.lbl_empresa = New System.Windows.Forms.Label()
        Me.ReportViewer2 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.bt_relatorio_empresa = New System.Windows.Forms.Button()
        Me.bt_relatorio_bens = New System.Windows.Forms.Button()
        Me.pn_contas = New System.Windows.Forms.Panel()
        Me.btn_conta_add = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmb_conta_3c = New System.Windows.Forms.ComboBox()
        Me.cmb_conta_2c = New System.Windows.Forms.ComboBox()
        Me.cmb_conta_1c = New System.Windows.Forms.ComboBox()
        Me.txt_conta_nome = New System.Windows.Forms.TextBox()
        Me.txt_conta_valor = New System.Windows.Forms.TextBox()
        Me.dgv_conta = New System.Windows.Forms.DataGridView()
        Me.nome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.classificacaoExterna = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.classificacaoInterna = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.saldo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pn_bens = New System.Windows.Forms.Panel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_bens_taxa = New System.Windows.Forms.NumericUpDown()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btn_bens_cancelar = New System.Windows.Forms.Button()
        Me.btn_bens_add = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_bens_depreciacao = New System.Windows.Forms.TextBox()
        Me.txt_bens_valorfi = New System.Windows.Forms.TextBox()
        Me.txt_bens_valorini = New System.Windows.Forms.TextBox()
        Me.dtp_bens_final = New System.Windows.Forms.DateTimePicker()
        Me.dtp_bens_inicial = New System.Windows.Forms.DateTimePicker()
        Me.cmb_bens_tipo = New System.Windows.Forms.ComboBox()
        Me.txt_bens_nome = New System.Windows.Forms.TextBox()
        Me.dgv_bens = New System.Windows.Forms.DataGridView()
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.preco = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.depreciado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pn_acesso = New System.Windows.Forms.Panel()
        Me.tab_admin = New System.Windows.Forms.TabControl()
        Me.tab_operador = New System.Windows.Forms.TabPage()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_acessoop_cancel = New System.Windows.Forms.Button()
        Me.btn_acessoop_salvar = New System.Windows.Forms.Button()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.txt_acessoop_senha2 = New System.Windows.Forms.TextBox()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.txt_acessoop_senha3 = New System.Windows.Forms.TextBox()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.txt_acessoop_senha1 = New System.Windows.Forms.TextBox()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.txt_acessoop_login = New System.Windows.Forms.TextBox()
        Me.tab_adm = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chk_acessoadm_admin = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.Administrador = New System.Windows.Forms.Label()
        Me.btn_acessoadm_cancel = New System.Windows.Forms.Button()
        Me.btn_acessoadm_salvar = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.txt_acessoadm_senha1 = New System.Windows.Forms.TextBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.txt_acessoadm_senha2 = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txt_acessoadm_email = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txt_acessoadm_login = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txt_acessoadm_cpf = New System.Windows.Forms.MaskedTextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txt_acessoadm_nome = New System.Windows.Forms.TextBox()
        Me.pn_status = New System.Windows.Forms.Panel()
        Me.lbl_hora = New System.Windows.Forms.Label()
        Me.lbl_data = New System.Windows.Forms.Label()
        Me.lbl_user_logado = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.pn_cadastroempresa = New System.Windows.Forms.Panel()
        Me.btn_empresa_add = New System.Windows.Forms.Button()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txt_empresa_enderaco = New System.Windows.Forms.TextBox()
        Me.txt_empres_respo = New System.Windows.Forms.TextBox()
        Me.txt_empres_nome = New System.Windows.Forms.TextBox()
        Me.txt_empresa_cnpj = New System.Windows.Forms.TextBox()
        Me.txt_empresa_cep = New System.Windows.Forms.TextBox()
        Me.dgv_empresa = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.ReportViewer4 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.lbl_usuario = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_acessoop_hide = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuImageButton7 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuImageButton6 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuImageButton8 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuImageButton11 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btn_acessoadm_relatorio = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuImageButton4 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuImageButton5 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuImageButton3 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuImageButton2 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.img_login = New Bunifu.Framework.UI.BunifuImageButton()
        Me.pic_logo = New System.Windows.Forms.PictureBox()
        Me.btn_acessoadm_hide = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btn_logout = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btn_minimiza = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btn_fecha = New Bunifu.Framework.UI.BunifuImageButton()
        Me.pn_menu = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.pic_logomin = New System.Windows.Forms.PictureBox()
        Me.pic_logomax = New System.Windows.Forms.PictureBox()
        Me.btn_show_user = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btn_show_empresa = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btn_show_report = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btn_show_bens = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btn_show_contas = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btn_show_menu = New Bunifu.Framework.UI.BunifuImageButton()
        Me.tb_bensBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tb_userBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.sistemaContabilDataSet = New sistemaContabil.sistemaContabilDataSet()
        Me.empresaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.bensBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.bensTableAdapter = New sistemaContabil.sistemaContabilDataSetTableAdapters.bensTableAdapter()
        Me.empresaTableAdapter = New sistemaContabil.sistemaContabilDataSetTableAdapters.empresaTableAdapter()
        Me.tb_userTableAdapter = New sistemaContabil.sistemaContabilDataSetTableAdapters.tb_userTableAdapter()
        Me.pn_header.SuspendLayout()
        Me.pn_relatorio.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.pn_contas.SuspendLayout()
        CType(Me.dgv_conta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pn_bens.SuspendLayout()
        CType(Me.txt_bens_taxa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_bens, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pn_acesso.SuspendLayout()
        Me.tab_admin.SuspendLayout()
        Me.tab_operador.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.tab_adm.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.pn_status.SuspendLayout()
        Me.pn_cadastroempresa.SuspendLayout()
        CType(Me.dgv_empresa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel13.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_acessoop_hide, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_acessoadm_relatorio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img_login, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_acessoadm_hide, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_logout, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_minimiza, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_fecha, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pn_menu.SuspendLayout()
        CType(Me.pic_logomin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_logomax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_show_menu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tb_bensBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tb_userBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sistemaContabilDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.empresaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bensBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.pn_header.Location = New System.Drawing.Point(50, 0)
        Me.pn_header.Name = "pn_header"
        Me.pn_header.Size = New System.Drawing.Size(845, 40)
        Me.pn_header.TabIndex = 1
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.pn_header
        Me.BunifuDragControl1.Vertical = True
        '
        'pn_relatorio
        '
        Me.pn_relatorio.Controls.Add(Me.Panel9)
        Me.pn_relatorio.Controls.Add(Me.Panel8)
        Me.pn_relatorio.Controls.Add(Me.bt_relatorio_empresa)
        Me.pn_relatorio.Controls.Add(Me.bt_relatorio_bens)
        Me.pn_relatorio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pn_relatorio.Location = New System.Drawing.Point(50, 40)
        Me.pn_relatorio.Name = "pn_relatorio"
        Me.pn_relatorio.Size = New System.Drawing.Size(845, 457)
        Me.pn_relatorio.TabIndex = 2
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.lbl_bens)
        Me.Panel9.Controls.Add(Me.ReportViewer3)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel9.Location = New System.Drawing.Point(0, 0)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(845, 457)
        Me.Panel9.TabIndex = 25
        Me.Panel9.Visible = False
        '
        'lbl_bens
        '
        Me.lbl_bens.AutoSize = True
        Me.lbl_bens.Location = New System.Drawing.Point(821, 6)
        Me.lbl_bens.Name = "lbl_bens"
        Me.lbl_bens.Size = New System.Drawing.Size(12, 13)
        Me.lbl_bens.TabIndex = 1
        Me.lbl_bens.Text = "x"
        '
        'ReportViewer3
        '
        Me.ReportViewer3.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource2.Name = "empresas"
        ReportDataSource2.Value = Me.empresaBindingSource
        Me.ReportViewer3.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer3.LocalReport.ReportEmbeddedResource = "sistemaContabil.Report2.rdlc"
        Me.ReportViewer3.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer3.Name = "ReportViewer3"
        Me.ReportViewer3.ServerReport.BearerToken = Nothing
        Me.ReportViewer3.Size = New System.Drawing.Size(845, 457)
        Me.ReportViewer3.TabIndex = 0
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.lbl_empresa)
        Me.Panel8.Controls.Add(Me.ReportViewer2)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(845, 457)
        Me.Panel8.TabIndex = 24
        Me.Panel8.Visible = False
        '
        'lbl_empresa
        '
        Me.lbl_empresa.AutoSize = True
        Me.lbl_empresa.Location = New System.Drawing.Point(821, 6)
        Me.lbl_empresa.Name = "lbl_empresa"
        Me.lbl_empresa.Size = New System.Drawing.Size(12, 13)
        Me.lbl_empresa.TabIndex = 1
        Me.lbl_empresa.Text = "x"
        '
        'ReportViewer2
        '
        Me.ReportViewer2.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource3.Name = "DataSet1"
        ReportDataSource3.Value = Me.bensBindingSource
        Me.ReportViewer2.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer2.LocalReport.ReportEmbeddedResource = "sistemaContabil.Report1.rdlc"
        Me.ReportViewer2.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer2.Name = "ReportViewer2"
        Me.ReportViewer2.ServerReport.BearerToken = Nothing
        Me.ReportViewer2.Size = New System.Drawing.Size(845, 457)
        Me.ReportViewer2.TabIndex = 0
        '
        'bt_relatorio_empresa
        '
        Me.bt_relatorio_empresa.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.bt_relatorio_empresa.AutoEllipsis = True
        Me.bt_relatorio_empresa.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.bt_relatorio_empresa.FlatAppearance.BorderSize = 0
        Me.bt_relatorio_empresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_relatorio_empresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_relatorio_empresa.ForeColor = System.Drawing.Color.White
        Me.bt_relatorio_empresa.Location = New System.Drawing.Point(192, 180)
        Me.bt_relatorio_empresa.Name = "bt_relatorio_empresa"
        Me.bt_relatorio_empresa.Size = New System.Drawing.Size(121, 100)
        Me.bt_relatorio_empresa.TabIndex = 23
        Me.bt_relatorio_empresa.Text = "Relatório de empresa"
        Me.bt_relatorio_empresa.UseVisualStyleBackColor = False
        '
        'bt_relatorio_bens
        '
        Me.bt_relatorio_bens.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.bt_relatorio_bens.AutoEllipsis = True
        Me.bt_relatorio_bens.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.bt_relatorio_bens.FlatAppearance.BorderSize = 0
        Me.bt_relatorio_bens.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_relatorio_bens.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_relatorio_bens.ForeColor = System.Drawing.Color.White
        Me.bt_relatorio_bens.Location = New System.Drawing.Point(452, 180)
        Me.bt_relatorio_bens.Name = "bt_relatorio_bens"
        Me.bt_relatorio_bens.Size = New System.Drawing.Size(121, 100)
        Me.bt_relatorio_bens.TabIndex = 23
        Me.bt_relatorio_bens.Text = "Relatório de Bens"
        Me.bt_relatorio_bens.UseVisualStyleBackColor = False
        '
        'pn_contas
        '
        Me.pn_contas.Controls.Add(Me.btn_conta_add)
        Me.pn_contas.Controls.Add(Me.Label7)
        Me.pn_contas.Controls.Add(Me.Label6)
        Me.pn_contas.Controls.Add(Me.Label5)
        Me.pn_contas.Controls.Add(Me.Label4)
        Me.pn_contas.Controls.Add(Me.Label3)
        Me.pn_contas.Controls.Add(Me.cmb_conta_3c)
        Me.pn_contas.Controls.Add(Me.cmb_conta_2c)
        Me.pn_contas.Controls.Add(Me.cmb_conta_1c)
        Me.pn_contas.Controls.Add(Me.txt_conta_nome)
        Me.pn_contas.Controls.Add(Me.txt_conta_valor)
        Me.pn_contas.Controls.Add(Me.dgv_conta)
        Me.pn_contas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pn_contas.Location = New System.Drawing.Point(50, 40)
        Me.pn_contas.Name = "pn_contas"
        Me.pn_contas.Size = New System.Drawing.Size(845, 457)
        Me.pn_contas.TabIndex = 1
        '
        'btn_conta_add
        '
        Me.btn_conta_add.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_conta_add.AutoEllipsis = True
        Me.btn_conta_add.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_conta_add.FlatAppearance.BorderSize = 0
        Me.btn_conta_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_conta_add.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_conta_add.ForeColor = System.Drawing.Color.White
        Me.btn_conta_add.Location = New System.Drawing.Point(557, 97)
        Me.btn_conta_add.Name = "btn_conta_add"
        Me.btn_conta_add.Size = New System.Drawing.Size(121, 22)
        Me.btn_conta_add.TabIndex = 10
        Me.btn_conta_add.Text = "Adicionar"
        Me.btn_conta_add.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(358, 83)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Valor da conta"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(162, 83)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Nome da conta"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(554, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Terceira camada"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(358, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Segunda camada"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(162, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Primeira camada"
        '
        'cmb_conta_3c
        '
        Me.cmb_conta_3c.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmb_conta_3c.FormattingEnabled = True
        Me.cmb_conta_3c.Location = New System.Drawing.Point(557, 51)
        Me.cmb_conta_3c.Name = "cmb_conta_3c"
        Me.cmb_conta_3c.Size = New System.Drawing.Size(121, 21)
        Me.cmb_conta_3c.TabIndex = 7
        '
        'cmb_conta_2c
        '
        Me.cmb_conta_2c.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmb_conta_2c.FormattingEnabled = True
        Me.cmb_conta_2c.Location = New System.Drawing.Point(361, 51)
        Me.cmb_conta_2c.Name = "cmb_conta_2c"
        Me.cmb_conta_2c.Size = New System.Drawing.Size(121, 21)
        Me.cmb_conta_2c.TabIndex = 6
        '
        'cmb_conta_1c
        '
        Me.cmb_conta_1c.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmb_conta_1c.FormattingEnabled = True
        Me.cmb_conta_1c.Location = New System.Drawing.Point(165, 51)
        Me.cmb_conta_1c.Name = "cmb_conta_1c"
        Me.cmb_conta_1c.Size = New System.Drawing.Size(121, 21)
        Me.cmb_conta_1c.TabIndex = 5
        '
        'txt_conta_nome
        '
        Me.txt_conta_nome.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_conta_nome.Enabled = False
        Me.txt_conta_nome.Location = New System.Drawing.Point(165, 99)
        Me.txt_conta_nome.Name = "txt_conta_nome"
        Me.txt_conta_nome.Size = New System.Drawing.Size(121, 20)
        Me.txt_conta_nome.TabIndex = 8
        '
        'txt_conta_valor
        '
        Me.txt_conta_valor.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_conta_valor.Enabled = False
        Me.txt_conta_valor.Location = New System.Drawing.Point(361, 99)
        Me.txt_conta_valor.Name = "txt_conta_valor"
        Me.txt_conta_valor.Size = New System.Drawing.Size(121, 20)
        Me.txt_conta_valor.TabIndex = 9
        '
        'dgv_conta
        '
        Me.dgv_conta.AllowUserToAddRows = False
        Me.dgv_conta.AllowUserToDeleteRows = False
        Me.dgv_conta.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgv_conta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_conta.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nome, Me.classificacaoExterna, Me.classificacaoInterna, Me.saldo})
        Me.dgv_conta.Location = New System.Drawing.Point(165, 137)
        Me.dgv_conta.Name = "dgv_conta"
        Me.dgv_conta.ReadOnly = True
        Me.dgv_conta.Size = New System.Drawing.Size(513, 269)
        Me.dgv_conta.TabIndex = 2
        Me.dgv_conta.Tag = "13"
        '
        'nome
        '
        Me.nome.HeaderText = "Nome"
        Me.nome.Name = "nome"
        Me.nome.ReadOnly = True
        '
        'classificacaoExterna
        '
        Me.classificacaoExterna.HeaderText = "Descrição"
        Me.classificacaoExterna.Name = "classificacaoExterna"
        Me.classificacaoExterna.ReadOnly = True
        '
        'classificacaoInterna
        '
        Me.classificacaoInterna.HeaderText = "Classifição"
        Me.classificacaoInterna.Name = "classificacaoInterna"
        Me.classificacaoInterna.ReadOnly = True
        Me.classificacaoInterna.Width = 170
        '
        'saldo
        '
        Me.saldo.HeaderText = "Saldo"
        Me.saldo.Name = "saldo"
        Me.saldo.ReadOnly = True
        '
        'pn_bens
        '
        Me.pn_bens.Controls.Add(Me.Label15)
        Me.pn_bens.Controls.Add(Me.txt_bens_taxa)
        Me.pn_bens.Controls.Add(Me.Label8)
        Me.pn_bens.Controls.Add(Me.btn_bens_cancelar)
        Me.pn_bens.Controls.Add(Me.btn_bens_add)
        Me.pn_bens.Controls.Add(Me.Label14)
        Me.pn_bens.Controls.Add(Me.Label16)
        Me.pn_bens.Controls.Add(Me.Label13)
        Me.pn_bens.Controls.Add(Me.Label12)
        Me.pn_bens.Controls.Add(Me.Label11)
        Me.pn_bens.Controls.Add(Me.Label10)
        Me.pn_bens.Controls.Add(Me.Label9)
        Me.pn_bens.Controls.Add(Me.txt_bens_depreciacao)
        Me.pn_bens.Controls.Add(Me.txt_bens_valorfi)
        Me.pn_bens.Controls.Add(Me.txt_bens_valorini)
        Me.pn_bens.Controls.Add(Me.dtp_bens_final)
        Me.pn_bens.Controls.Add(Me.dtp_bens_inicial)
        Me.pn_bens.Controls.Add(Me.cmb_bens_tipo)
        Me.pn_bens.Controls.Add(Me.txt_bens_nome)
        Me.pn_bens.Controls.Add(Me.dgv_bens)
        Me.pn_bens.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pn_bens.Location = New System.Drawing.Point(50, 40)
        Me.pn_bens.Name = "pn_bens"
        Me.pn_bens.Size = New System.Drawing.Size(845, 457)
        Me.pn_bens.TabIndex = 0
        '
        'Label15
        '
        Me.Label15.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(321, 111)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(108, 13)
        Me.Label15.TabIndex = 48
        Me.Label15.Text = "Taxa de depreciação"
        '
        'txt_bens_taxa
        '
        Me.txt_bens_taxa.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_bens_taxa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_bens_taxa.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.txt_bens_taxa.Location = New System.Drawing.Point(324, 127)
        Me.txt_bens_taxa.Name = "txt_bens_taxa"
        Me.txt_bens_taxa.ReadOnly = True
        Me.txt_bens_taxa.Size = New System.Drawing.Size(63, 20)
        Me.txt_bens_taxa.TabIndex = 46
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(386, 130)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(36, 13)
        Me.Label8.TabIndex = 47
        Me.Label8.Text = "% a.a."
        '
        'btn_bens_cancelar
        '
        Me.btn_bens_cancelar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_bens_cancelar.AutoEllipsis = True
        Me.btn_bens_cancelar.BackColor = System.Drawing.Color.IndianRed
        Me.btn_bens_cancelar.FlatAppearance.BorderSize = 0
        Me.btn_bens_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_bens_cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_bens_cancelar.ForeColor = System.Drawing.Color.White
        Me.btn_bens_cancelar.Location = New System.Drawing.Point(546, 176)
        Me.btn_bens_cancelar.Name = "btn_bens_cancelar"
        Me.btn_bens_cancelar.Size = New System.Drawing.Size(100, 22)
        Me.btn_bens_cancelar.TabIndex = 45
        Me.btn_bens_cancelar.Text = "Cancelar"
        Me.btn_bens_cancelar.UseVisualStyleBackColor = False
        '
        'btn_bens_add
        '
        Me.btn_bens_add.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_bens_add.AutoEllipsis = True
        Me.btn_bens_add.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_bens_add.FlatAppearance.BorderSize = 0
        Me.btn_bens_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_bens_add.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_bens_add.ForeColor = System.Drawing.Color.White
        Me.btn_bens_add.Location = New System.Drawing.Point(435, 176)
        Me.btn_bens_add.Name = "btn_bens_add"
        Me.btn_bens_add.Size = New System.Drawing.Size(100, 22)
        Me.btn_bens_add.TabIndex = 44
        Me.btn_bens_add.Text = "Adicionar"
        Me.btn_bens_add.UseVisualStyleBackColor = False
        '
        'Label14
        '
        Me.Label14.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(545, 111)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(68, 13)
        Me.Label14.TabIndex = 43
        Me.Label14.Text = "Data de hoje"
        '
        'Label16
        '
        Me.Label16.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(321, 162)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(108, 13)
        Me.Label16.TabIndex = 43
        Me.Label16.Text = "Valor da depreciacao"
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(210, 162)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(56, 13)
        Me.Label13.TabIndex = 43
        Me.Label13.Text = "Valor Final"
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(210, 111)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(60, 13)
        Me.Label12.TabIndex = 43
        Me.Label12.Text = "Valor inicial"
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(432, 111)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(83, 13)
        Me.Label11.TabIndex = 43
        Me.Label11.Text = "Data da compra"
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(321, 60)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 13)
        Me.Label10.TabIndex = 43
        Me.Label10.Text = "Tipo do bem"
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(210, 60)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 13)
        Me.Label9.TabIndex = 43
        Me.Label9.Text = "Nome do Bem"
        '
        'txt_bens_depreciacao
        '
        Me.txt_bens_depreciacao.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_bens_depreciacao.Enabled = False
        Me.txt_bens_depreciacao.Location = New System.Drawing.Point(324, 177)
        Me.txt_bens_depreciacao.Name = "txt_bens_depreciacao"
        Me.txt_bens_depreciacao.Size = New System.Drawing.Size(100, 20)
        Me.txt_bens_depreciacao.TabIndex = 42
        '
        'txt_bens_valorfi
        '
        Me.txt_bens_valorfi.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_bens_valorfi.Enabled = False
        Me.txt_bens_valorfi.Location = New System.Drawing.Point(213, 177)
        Me.txt_bens_valorfi.Name = "txt_bens_valorfi"
        Me.txt_bens_valorfi.Size = New System.Drawing.Size(100, 20)
        Me.txt_bens_valorfi.TabIndex = 42
        '
        'txt_bens_valorini
        '
        Me.txt_bens_valorini.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_bens_valorini.Location = New System.Drawing.Point(213, 127)
        Me.txt_bens_valorini.Name = "txt_bens_valorini"
        Me.txt_bens_valorini.Size = New System.Drawing.Size(100, 20)
        Me.txt_bens_valorini.TabIndex = 42
        '
        'dtp_bens_final
        '
        Me.dtp_bens_final.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dtp_bens_final.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtp_bens_final.Enabled = False
        Me.dtp_bens_final.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_bens_final.Location = New System.Drawing.Point(548, 127)
        Me.dtp_bens_final.MaxDate = New Date(2018, 6, 29, 0, 0, 0, 0)
        Me.dtp_bens_final.MinDate = New Date(1918, 6, 29, 0, 0, 0, 0)
        Me.dtp_bens_final.Name = "dtp_bens_final"
        Me.dtp_bens_final.Size = New System.Drawing.Size(100, 20)
        Me.dtp_bens_final.TabIndex = 41
        Me.dtp_bens_final.Value = New Date(2018, 6, 29, 0, 0, 0, 0)
        '
        'dtp_bens_inicial
        '
        Me.dtp_bens_inicial.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dtp_bens_inicial.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtp_bens_inicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_bens_inicial.Location = New System.Drawing.Point(435, 127)
        Me.dtp_bens_inicial.MaxDate = New Date(2018, 6, 29, 0, 0, 0, 0)
        Me.dtp_bens_inicial.Name = "dtp_bens_inicial"
        Me.dtp_bens_inicial.Size = New System.Drawing.Size(100, 20)
        Me.dtp_bens_inicial.TabIndex = 41
        Me.dtp_bens_inicial.Value = New Date(1999, 1, 1, 0, 0, 0, 0)
        '
        'cmb_bens_tipo
        '
        Me.cmb_bens_tipo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmb_bens_tipo.FormattingEnabled = True
        Me.cmb_bens_tipo.Location = New System.Drawing.Point(324, 76)
        Me.cmb_bens_tipo.Name = "cmb_bens_tipo"
        Me.cmb_bens_tipo.Size = New System.Drawing.Size(100, 21)
        Me.cmb_bens_tipo.TabIndex = 38
        '
        'txt_bens_nome
        '
        Me.txt_bens_nome.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_bens_nome.Location = New System.Drawing.Point(213, 76)
        Me.txt_bens_nome.Name = "txt_bens_nome"
        Me.txt_bens_nome.Size = New System.Drawing.Size(100, 20)
        Me.txt_bens_nome.TabIndex = 37
        '
        'dgv_bens
        '
        Me.dgv_bens.AllowUserToAddRows = False
        Me.dgv_bens.AllowUserToDeleteRows = False
        Me.dgv_bens.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgv_bens.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgv_bens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_bens.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codigo, Me.DataGridViewTextBoxColumn1, Me.preco, Me.depreciado})
        Me.dgv_bens.EnableHeadersVisualStyles = False
        Me.dgv_bens.GridColor = System.Drawing.Color.Black
        Me.dgv_bens.Location = New System.Drawing.Point(213, 228)
        Me.dgv_bens.Name = "dgv_bens"
        Me.dgv_bens.ReadOnly = True
        Me.dgv_bens.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgv_bens.RowHeadersVisible = False
        Me.dgv_bens.Size = New System.Drawing.Size(435, 182)
        Me.dgv_bens.TabIndex = 36
        '
        'codigo
        '
        Me.codigo.HeaderText = "Codigo"
        Me.codigo.Name = "codigo"
        Me.codigo.ReadOnly = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Nome"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'preco
        '
        Me.preco.HeaderText = "Valor Inicial"
        Me.preco.Name = "preco"
        Me.preco.ReadOnly = True
        '
        'depreciado
        '
        Me.depreciado.FillWeight = 130.0!
        Me.depreciado.HeaderText = "Val. Depreciado"
        Me.depreciado.Name = "depreciado"
        Me.depreciado.ReadOnly = True
        Me.depreciado.Width = 130
        '
        'pn_acesso
        '
        Me.pn_acesso.Controls.Add(Me.tab_admin)
        Me.pn_acesso.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pn_acesso.Location = New System.Drawing.Point(50, 40)
        Me.pn_acesso.Name = "pn_acesso"
        Me.pn_acesso.Size = New System.Drawing.Size(845, 457)
        Me.pn_acesso.TabIndex = 0
        '
        'tab_admin
        '
        Me.tab_admin.Controls.Add(Me.tab_operador)
        Me.tab_admin.Controls.Add(Me.tab_adm)
        Me.tab_admin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tab_admin.Location = New System.Drawing.Point(0, 0)
        Me.tab_admin.Name = "tab_admin"
        Me.tab_admin.SelectedIndex = 0
        Me.tab_admin.Size = New System.Drawing.Size(845, 457)
        Me.tab_admin.TabIndex = 7
        '
        'tab_operador
        '
        Me.tab_operador.BackColor = System.Drawing.SystemColors.Control
        Me.tab_operador.Controls.Add(Me.Label2)
        Me.tab_operador.Controls.Add(Me.PictureBox1)
        Me.tab_operador.Controls.Add(Me.btn_acessoop_hide)
        Me.tab_operador.Controls.Add(Me.btn_acessoop_cancel)
        Me.tab_operador.Controls.Add(Me.btn_acessoop_salvar)
        Me.tab_operador.Controls.Add(Me.Panel12)
        Me.tab_operador.Controls.Add(Me.Panel11)
        Me.tab_operador.Controls.Add(Me.Panel7)
        Me.tab_operador.Controls.Add(Me.Panel10)
        Me.tab_operador.Location = New System.Drawing.Point(4, 22)
        Me.tab_operador.Name = "tab_operador"
        Me.tab_operador.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_operador.Size = New System.Drawing.Size(837, 431)
        Me.tab_operador.TabIndex = 0
        Me.tab_operador.Text = "Operador"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(359, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 24)
        Me.Label2.TabIndex = 76
        Me.Label2.Text = "Alterar Senha"
        '
        'btn_acessoop_cancel
        '
        Me.btn_acessoop_cancel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_acessoop_cancel.AutoEllipsis = True
        Me.btn_acessoop_cancel.BackColor = System.Drawing.Color.IndianRed
        Me.btn_acessoop_cancel.FlatAppearance.BorderSize = 0
        Me.btn_acessoop_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_acessoop_cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_acessoop_cancel.ForeColor = System.Drawing.Color.White
        Me.btn_acessoop_cancel.Location = New System.Drawing.Point(461, 369)
        Me.btn_acessoop_cancel.Name = "btn_acessoop_cancel"
        Me.btn_acessoop_cancel.Size = New System.Drawing.Size(200, 40)
        Me.btn_acessoop_cancel.TabIndex = 5
        Me.btn_acessoop_cancel.Text = "Cancelar"
        Me.btn_acessoop_cancel.UseVisualStyleBackColor = False
        '
        'btn_acessoop_salvar
        '
        Me.btn_acessoop_salvar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_acessoop_salvar.AutoEllipsis = True
        Me.btn_acessoop_salvar.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_acessoop_salvar.FlatAppearance.BorderSize = 0
        Me.btn_acessoop_salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_acessoop_salvar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_acessoop_salvar.ForeColor = System.Drawing.Color.White
        Me.btn_acessoop_salvar.Location = New System.Drawing.Point(194, 369)
        Me.btn_acessoop_salvar.Name = "btn_acessoop_salvar"
        Me.btn_acessoop_salvar.Size = New System.Drawing.Size(200, 40)
        Me.btn_acessoop_salvar.TabIndex = 4
        Me.btn_acessoop_salvar.Text = "Salvar"
        Me.btn_acessoop_salvar.UseVisualStyleBackColor = False
        '
        'Panel12
        '
        Me.Panel12.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel12.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.Panel12.Controls.Add(Me.BunifuImageButton7)
        Me.Panel12.Controls.Add(Me.txt_acessoop_senha2)
        Me.Panel12.Location = New System.Drawing.Point(194, 253)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(200, 40)
        Me.Panel12.TabIndex = 1
        '
        'txt_acessoop_senha2
        '
        Me.txt_acessoop_senha2.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.txt_acessoop_senha2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_acessoop_senha2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_acessoop_senha2.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txt_acessoop_senha2.Location = New System.Drawing.Point(19, 11)
        Me.txt_acessoop_senha2.Name = "txt_acessoop_senha2"
        Me.txt_acessoop_senha2.Size = New System.Drawing.Size(166, 19)
        Me.txt_acessoop_senha2.TabIndex = 0
        Me.txt_acessoop_senha2.Text = "Nova senha"
        Me.txt_acessoop_senha2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel11
        '
        Me.Panel11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel11.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.Panel11.Controls.Add(Me.BunifuImageButton6)
        Me.Panel11.Controls.Add(Me.txt_acessoop_senha3)
        Me.Panel11.Location = New System.Drawing.Point(461, 253)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(200, 40)
        Me.Panel11.TabIndex = 3
        '
        'txt_acessoop_senha3
        '
        Me.txt_acessoop_senha3.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.txt_acessoop_senha3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_acessoop_senha3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_acessoop_senha3.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txt_acessoop_senha3.Location = New System.Drawing.Point(22, 11)
        Me.txt_acessoop_senha3.Name = "txt_acessoop_senha3"
        Me.txt_acessoop_senha3.Size = New System.Drawing.Size(166, 19)
        Me.txt_acessoop_senha3.TabIndex = 0
        Me.txt_acessoop_senha3.Text = "Confirmar Senha"
        Me.txt_acessoop_senha3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel7
        '
        Me.Panel7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.Panel7.Controls.Add(Me.BunifuImageButton8)
        Me.Panel7.Controls.Add(Me.txt_acessoop_senha1)
        Me.Panel7.Location = New System.Drawing.Point(461, 137)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(200, 40)
        Me.Panel7.TabIndex = 2
        '
        'txt_acessoop_senha1
        '
        Me.txt_acessoop_senha1.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.txt_acessoop_senha1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_acessoop_senha1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_acessoop_senha1.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txt_acessoop_senha1.Location = New System.Drawing.Point(19, 11)
        Me.txt_acessoop_senha1.Name = "txt_acessoop_senha1"
        Me.txt_acessoop_senha1.Size = New System.Drawing.Size(166, 19)
        Me.txt_acessoop_senha1.TabIndex = 0
        Me.txt_acessoop_senha1.Text = "Senha"
        Me.txt_acessoop_senha1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel10
        '
        Me.Panel10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel10.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.Panel10.Controls.Add(Me.BunifuImageButton11)
        Me.Panel10.Controls.Add(Me.txt_acessoop_login)
        Me.Panel10.Location = New System.Drawing.Point(194, 137)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(200, 40)
        Me.Panel10.TabIndex = 0
        '
        'txt_acessoop_login
        '
        Me.txt_acessoop_login.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.txt_acessoop_login.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_acessoop_login.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_acessoop_login.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txt_acessoop_login.Location = New System.Drawing.Point(19, 11)
        Me.txt_acessoop_login.Name = "txt_acessoop_login"
        Me.txt_acessoop_login.Size = New System.Drawing.Size(166, 19)
        Me.txt_acessoop_login.TabIndex = 0
        Me.txt_acessoop_login.Text = "Login"
        Me.txt_acessoop_login.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tab_adm
        '
        Me.tab_adm.BackColor = System.Drawing.SystemColors.Control
        Me.tab_adm.Controls.Add(Me.Panel13)
        Me.tab_adm.Controls.Add(Me.btn_acessoadm_relatorio)
        Me.tab_adm.Controls.Add(Me.Label1)
        Me.tab_adm.Controls.Add(Me.chk_acessoadm_admin)
        Me.tab_adm.Controls.Add(Me.Administrador)
        Me.tab_adm.Controls.Add(Me.btn_acessoadm_cancel)
        Me.tab_adm.Controls.Add(Me.btn_acessoadm_salvar)
        Me.tab_adm.Controls.Add(Me.Panel5)
        Me.tab_adm.Controls.Add(Me.Panel6)
        Me.tab_adm.Controls.Add(Me.Panel4)
        Me.tab_adm.Controls.Add(Me.Panel3)
        Me.tab_adm.Controls.Add(Me.Panel2)
        Me.tab_adm.Controls.Add(Me.Panel1)
        Me.tab_adm.Controls.Add(Me.pic_logo)
        Me.tab_adm.Controls.Add(Me.btn_acessoadm_hide)
        Me.tab_adm.Location = New System.Drawing.Point(4, 22)
        Me.tab_adm.Name = "tab_adm"
        Me.tab_adm.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_adm.Size = New System.Drawing.Size(837, 431)
        Me.tab_adm.TabIndex = 1
        Me.tab_adm.Text = "Administrador"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(307, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(242, 24)
        Me.Label1.TabIndex = 68
        Me.Label1.Text = "Cadastro de funcionários"
        '
        'chk_acessoadm_admin
        '
        Me.chk_acessoadm_admin.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chk_acessoadm_admin.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.chk_acessoadm_admin.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.chk_acessoadm_admin.Checked = False
        Me.chk_acessoadm_admin.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.chk_acessoadm_admin.ForeColor = System.Drawing.Color.White
        Me.chk_acessoadm_admin.Location = New System.Drawing.Point(374, 334)
        Me.chk_acessoadm_admin.Name = "chk_acessoadm_admin"
        Me.chk_acessoadm_admin.Size = New System.Drawing.Size(20, 20)
        Me.chk_acessoadm_admin.TabIndex = 14
        '
        'Administrador
        '
        Me.Administrador.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Administrador.AutoSize = True
        Me.Administrador.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Administrador.Location = New System.Drawing.Point(244, 334)
        Me.Administrador.Name = "Administrador"
        Me.Administrador.Size = New System.Drawing.Size(107, 20)
        Me.Administrador.TabIndex = 64
        Me.Administrador.Text = "Administrador"
        '
        'btn_acessoadm_cancel
        '
        Me.btn_acessoadm_cancel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_acessoadm_cancel.AutoEllipsis = True
        Me.btn_acessoadm_cancel.BackColor = System.Drawing.Color.IndianRed
        Me.btn_acessoadm_cancel.FlatAppearance.BorderSize = 0
        Me.btn_acessoadm_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_acessoadm_cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_acessoadm_cancel.ForeColor = System.Drawing.Color.White
        Me.btn_acessoadm_cancel.Location = New System.Drawing.Point(459, 369)
        Me.btn_acessoadm_cancel.Name = "btn_acessoadm_cancel"
        Me.btn_acessoadm_cancel.Size = New System.Drawing.Size(200, 40)
        Me.btn_acessoadm_cancel.TabIndex = 7
        Me.btn_acessoadm_cancel.Text = "Cancelar"
        Me.btn_acessoadm_cancel.UseVisualStyleBackColor = False
        '
        'btn_acessoadm_salvar
        '
        Me.btn_acessoadm_salvar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_acessoadm_salvar.AutoEllipsis = True
        Me.btn_acessoadm_salvar.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_acessoadm_salvar.FlatAppearance.BorderSize = 0
        Me.btn_acessoadm_salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_acessoadm_salvar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_acessoadm_salvar.ForeColor = System.Drawing.Color.White
        Me.btn_acessoadm_salvar.Location = New System.Drawing.Point(194, 369)
        Me.btn_acessoadm_salvar.Name = "btn_acessoadm_salvar"
        Me.btn_acessoadm_salvar.Size = New System.Drawing.Size(200, 40)
        Me.btn_acessoadm_salvar.TabIndex = 6
        Me.btn_acessoadm_salvar.Text = "Salvar"
        Me.btn_acessoadm_salvar.UseVisualStyleBackColor = False
        '
        'Panel5
        '
        Me.Panel5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.Panel5.Controls.Add(Me.BunifuImageButton4)
        Me.Panel5.Controls.Add(Me.txt_acessoadm_senha1)
        Me.Panel5.Location = New System.Drawing.Point(194, 265)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(200, 40)
        Me.Panel5.TabIndex = 4
        '
        'txt_acessoadm_senha1
        '
        Me.txt_acessoadm_senha1.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.txt_acessoadm_senha1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_acessoadm_senha1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_acessoadm_senha1.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txt_acessoadm_senha1.Location = New System.Drawing.Point(19, 11)
        Me.txt_acessoadm_senha1.Name = "txt_acessoadm_senha1"
        Me.txt_acessoadm_senha1.Size = New System.Drawing.Size(166, 19)
        Me.txt_acessoadm_senha1.TabIndex = 12
        Me.txt_acessoadm_senha1.Text = "Senha"
        Me.txt_acessoadm_senha1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel6
        '
        Me.Panel6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.Panel6.Controls.Add(Me.BunifuImageButton5)
        Me.Panel6.Controls.Add(Me.txt_acessoadm_senha2)
        Me.Panel6.Location = New System.Drawing.Point(461, 265)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(200, 40)
        Me.Panel6.TabIndex = 5
        '
        'txt_acessoadm_senha2
        '
        Me.txt_acessoadm_senha2.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.txt_acessoadm_senha2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_acessoadm_senha2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_acessoadm_senha2.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txt_acessoadm_senha2.Location = New System.Drawing.Point(22, 11)
        Me.txt_acessoadm_senha2.Name = "txt_acessoadm_senha2"
        Me.txt_acessoadm_senha2.Size = New System.Drawing.Size(166, 19)
        Me.txt_acessoadm_senha2.TabIndex = 13
        Me.txt_acessoadm_senha2.Text = "Confirmar Senha"
        Me.txt_acessoadm_senha2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel4
        '
        Me.Panel4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.Panel4.Controls.Add(Me.BunifuImageButton3)
        Me.Panel4.Controls.Add(Me.txt_acessoadm_email)
        Me.Panel4.Location = New System.Drawing.Point(459, 186)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(200, 40)
        Me.Panel4.TabIndex = 3
        '
        'txt_acessoadm_email
        '
        Me.txt_acessoadm_email.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.txt_acessoadm_email.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_acessoadm_email.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_acessoadm_email.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txt_acessoadm_email.Location = New System.Drawing.Point(19, 11)
        Me.txt_acessoadm_email.Name = "txt_acessoadm_email"
        Me.txt_acessoadm_email.Size = New System.Drawing.Size(166, 19)
        Me.txt_acessoadm_email.TabIndex = 11
        Me.txt_acessoadm_email.Text = "E-mail"
        Me.txt_acessoadm_email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel3
        '
        Me.Panel3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.Panel3.Controls.Add(Me.BunifuImageButton2)
        Me.Panel3.Controls.Add(Me.txt_acessoadm_login)
        Me.Panel3.Location = New System.Drawing.Point(194, 186)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(200, 40)
        Me.Panel3.TabIndex = 2
        '
        'txt_acessoadm_login
        '
        Me.txt_acessoadm_login.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.txt_acessoadm_login.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_acessoadm_login.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_acessoadm_login.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txt_acessoadm_login.Location = New System.Drawing.Point(19, 11)
        Me.txt_acessoadm_login.Name = "txt_acessoadm_login"
        Me.txt_acessoadm_login.Size = New System.Drawing.Size(166, 19)
        Me.txt_acessoadm_login.TabIndex = 10
        Me.txt_acessoadm_login.Text = "Login"
        Me.txt_acessoadm_login.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.Panel2.Controls.Add(Me.txt_acessoadm_cpf)
        Me.Panel2.Controls.Add(Me.BunifuImageButton1)
        Me.Panel2.Location = New System.Drawing.Point(459, 118)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 40)
        Me.Panel2.TabIndex = 1
        '
        'txt_acessoadm_cpf
        '
        Me.txt_acessoadm_cpf.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.txt_acessoadm_cpf.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_acessoadm_cpf.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txt_acessoadm_cpf.Location = New System.Drawing.Point(50, 11)
        Me.txt_acessoadm_cpf.Mask = "000.000.000-00"
        Me.txt_acessoadm_cpf.Name = "txt_acessoadm_cpf"
        Me.txt_acessoadm_cpf.Size = New System.Drawing.Size(124, 19)
        Me.txt_acessoadm_cpf.TabIndex = 9
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.Panel1.Controls.Add(Me.img_login)
        Me.Panel1.Controls.Add(Me.txt_acessoadm_nome)
        Me.Panel1.Location = New System.Drawing.Point(194, 118)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 40)
        Me.Panel1.TabIndex = 0
        '
        'txt_acessoadm_nome
        '
        Me.txt_acessoadm_nome.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.txt_acessoadm_nome.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_acessoadm_nome.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_acessoadm_nome.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txt_acessoadm_nome.Location = New System.Drawing.Point(19, 11)
        Me.txt_acessoadm_nome.Name = "txt_acessoadm_nome"
        Me.txt_acessoadm_nome.Size = New System.Drawing.Size(166, 19)
        Me.txt_acessoadm_nome.TabIndex = 8
        Me.txt_acessoadm_nome.Text = "Nome"
        Me.txt_acessoadm_nome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pn_status
        '
        Me.pn_status.Controls.Add(Me.lbl_hora)
        Me.pn_status.Controls.Add(Me.lbl_data)
        Me.pn_status.Controls.Add(Me.lbl_user_logado)
        Me.pn_status.Controls.Add(Me.Label26)
        Me.pn_status.Controls.Add(Me.btn_logout)
        Me.pn_status.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pn_status.Location = New System.Drawing.Point(50, 497)
        Me.pn_status.Name = "pn_status"
        Me.pn_status.Size = New System.Drawing.Size(845, 37)
        Me.pn_status.TabIndex = 0
        '
        'lbl_hora
        '
        Me.lbl_hora.AutoSize = True
        Me.lbl_hora.BackColor = System.Drawing.Color.Transparent
        Me.lbl_hora.Location = New System.Drawing.Point(94, 11)
        Me.lbl_hora.Name = "lbl_hora"
        Me.lbl_hora.Size = New System.Drawing.Size(26, 13)
        Me.lbl_hora.TabIndex = 52
        Me.lbl_hora.Text = "time"
        '
        'lbl_data
        '
        Me.lbl_data.AutoSize = True
        Me.lbl_data.BackColor = System.Drawing.Color.Transparent
        Me.lbl_data.Location = New System.Drawing.Point(23, 11)
        Me.lbl_data.Name = "lbl_data"
        Me.lbl_data.Size = New System.Drawing.Size(28, 13)
        Me.lbl_data.TabIndex = 53
        Me.lbl_data.Text = "date"
        '
        'lbl_user_logado
        '
        Me.lbl_user_logado.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_user_logado.AutoSize = True
        Me.lbl_user_logado.Location = New System.Drawing.Point(725, 11)
        Me.lbl_user_logado.Name = "lbl_user_logado"
        Me.lbl_user_logado.Size = New System.Drawing.Size(0, 13)
        Me.lbl_user_logado.TabIndex = 51
        '
        'Label26
        '
        Me.Label26.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(647, 11)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(75, 13)
        Me.Label26.TabIndex = 50
        Me.Label26.Text = "Logado como:"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'pn_cadastroempresa
        '
        Me.pn_cadastroempresa.Controls.Add(Me.btn_empresa_add)
        Me.pn_cadastroempresa.Controls.Add(Me.Label20)
        Me.pn_cadastroempresa.Controls.Add(Me.Label21)
        Me.pn_cadastroempresa.Controls.Add(Me.Label17)
        Me.pn_cadastroempresa.Controls.Add(Me.Label19)
        Me.pn_cadastroempresa.Controls.Add(Me.Label18)
        Me.pn_cadastroempresa.Controls.Add(Me.txt_empresa_enderaco)
        Me.pn_cadastroempresa.Controls.Add(Me.txt_empres_respo)
        Me.pn_cadastroempresa.Controls.Add(Me.txt_empres_nome)
        Me.pn_cadastroempresa.Controls.Add(Me.txt_empresa_cnpj)
        Me.pn_cadastroempresa.Controls.Add(Me.txt_empresa_cep)
        Me.pn_cadastroempresa.Controls.Add(Me.dgv_empresa)
        Me.pn_cadastroempresa.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pn_cadastroempresa.Location = New System.Drawing.Point(50, 40)
        Me.pn_cadastroempresa.Name = "pn_cadastroempresa"
        Me.pn_cadastroempresa.Size = New System.Drawing.Size(845, 457)
        Me.pn_cadastroempresa.TabIndex = 77
        Me.pn_cadastroempresa.Visible = False
        '
        'btn_empresa_add
        '
        Me.btn_empresa_add.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_empresa_add.AutoEllipsis = True
        Me.btn_empresa_add.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_empresa_add.FlatAppearance.BorderSize = 0
        Me.btn_empresa_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_empresa_add.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_empresa_add.ForeColor = System.Drawing.Color.White
        Me.btn_empresa_add.Location = New System.Drawing.Point(559, 105)
        Me.btn_empresa_add.Name = "btn_empresa_add"
        Me.btn_empresa_add.Size = New System.Drawing.Size(121, 22)
        Me.btn_empresa_add.TabIndex = 22
        Me.btn_empresa_add.Text = "Adicionar"
        Me.btn_empresa_add.UseVisualStyleBackColor = False
        '
        'Label20
        '
        Me.Label20.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(363, 89)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(135, 13)
        Me.Label20.TabIndex = 15
        Me.Label20.Text = "Responsável pela empresa"
        '
        'Label21
        '
        Me.Label21.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(554, 35)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(34, 13)
        Me.Label21.TabIndex = 15
        Me.Label21.Text = "CNPJ"
        '
        'Label17
        '
        Me.Label17.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(363, 35)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(28, 13)
        Me.Label17.TabIndex = 15
        Me.Label17.Text = "CEP"
        '
        'Label19
        '
        Me.Label19.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(167, 89)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(53, 13)
        Me.Label19.TabIndex = 16
        Me.Label19.Text = "Endereço"
        '
        'Label18
        '
        Me.Label18.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(167, 35)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(93, 13)
        Me.Label18.TabIndex = 16
        Me.Label18.Text = "Nome da empresa"
        '
        'txt_empresa_enderaco
        '
        Me.txt_empresa_enderaco.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_empresa_enderaco.Location = New System.Drawing.Point(170, 105)
        Me.txt_empresa_enderaco.Name = "txt_empresa_enderaco"
        Me.txt_empresa_enderaco.Size = New System.Drawing.Size(121, 20)
        Me.txt_empresa_enderaco.TabIndex = 20
        '
        'txt_empres_respo
        '
        Me.txt_empres_respo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_empres_respo.Location = New System.Drawing.Point(366, 105)
        Me.txt_empres_respo.Name = "txt_empres_respo"
        Me.txt_empres_respo.Size = New System.Drawing.Size(121, 20)
        Me.txt_empres_respo.TabIndex = 21
        '
        'txt_empres_nome
        '
        Me.txt_empres_nome.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_empres_nome.Location = New System.Drawing.Point(170, 51)
        Me.txt_empres_nome.Name = "txt_empres_nome"
        Me.txt_empres_nome.Size = New System.Drawing.Size(121, 20)
        Me.txt_empres_nome.TabIndex = 20
        '
        'txt_empresa_cnpj
        '
        Me.txt_empresa_cnpj.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_empresa_cnpj.Location = New System.Drawing.Point(557, 51)
        Me.txt_empresa_cnpj.Name = "txt_empresa_cnpj"
        Me.txt_empresa_cnpj.Size = New System.Drawing.Size(121, 20)
        Me.txt_empresa_cnpj.TabIndex = 21
        '
        'txt_empresa_cep
        '
        Me.txt_empresa_cep.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_empresa_cep.Location = New System.Drawing.Point(366, 51)
        Me.txt_empresa_cep.Name = "txt_empresa_cep"
        Me.txt_empresa_cep.Size = New System.Drawing.Size(121, 20)
        Me.txt_empresa_cep.TabIndex = 21
        '
        'dgv_empresa
        '
        Me.dgv_empresa.AllowUserToAddRows = False
        Me.dgv_empresa.AllowUserToDeleteRows = False
        Me.dgv_empresa.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgv_empresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_empresa.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.dgv_empresa.Location = New System.Drawing.Point(167, 145)
        Me.dgv_empresa.Name = "dgv_empresa"
        Me.dgv_empresa.ReadOnly = True
        Me.dgv_empresa.Size = New System.Drawing.Size(513, 269)
        Me.dgv_empresa.TabIndex = 11
        Me.dgv_empresa.Tag = "13"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nome"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "CEP"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Endereço"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 170
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Responsável"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'Panel13
        '
        Me.Panel13.Controls.Add(Me.lbl_usuario)
        Me.Panel13.Controls.Add(Me.ReportViewer4)
        Me.Panel13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel13.Location = New System.Drawing.Point(3, 3)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(831, 425)
        Me.Panel13.TabIndex = 70
        Me.Panel13.Visible = False
        '
        'ReportViewer4
        '
        Me.ReportViewer4.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.tb_userBindingSource
        Me.ReportViewer4.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer4.LocalReport.ReportEmbeddedResource = "sistemaContabil.Report3.rdlc"
        Me.ReportViewer4.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer4.Name = "ReportViewer4"
        Me.ReportViewer4.ServerReport.BearerToken = Nothing
        Me.ReportViewer4.Size = New System.Drawing.Size(831, 425)
        Me.ReportViewer4.TabIndex = 0
        '
        'lbl_usuario
        '
        Me.lbl_usuario.AutoSize = True
        Me.lbl_usuario.Location = New System.Drawing.Point(812, 6)
        Me.lbl_usuario.Name = "lbl_usuario"
        Me.lbl_usuario.Size = New System.Drawing.Size(12, 13)
        Me.lbl_usuario.TabIndex = 1
        Me.lbl_usuario.Text = "x"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.Image = Global.sistemaContabil.My.Resources.Resources.LOGO01
        Me.PictureBox1.Location = New System.Drawing.Point(270, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(299, 64)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 75
        Me.PictureBox1.TabStop = False
        '
        'btn_acessoop_hide
        '
        Me.btn_acessoop_hide.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_acessoop_hide.BackColor = System.Drawing.Color.Transparent
        Me.btn_acessoop_hide.Image = Global.sistemaContabil.My.Resources.Resources.Eye_48px
        Me.btn_acessoop_hide.ImageActive = Nothing
        Me.btn_acessoop_hide.Location = New System.Drawing.Point(618, 334)
        Me.btn_acessoop_hide.Name = "btn_acessoop_hide"
        Me.btn_acessoop_hide.Size = New System.Drawing.Size(43, 29)
        Me.btn_acessoop_hide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_acessoop_hide.TabIndex = 74
        Me.btn_acessoop_hide.TabStop = False
        Me.btn_acessoop_hide.Zoom = 10
        '
        'BunifuImageButton7
        '
        Me.BunifuImageButton7.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton7.Image = Global.sistemaContabil.My.Resources.Resources.Password_48px
        Me.BunifuImageButton7.ImageActive = Nothing
        Me.BunifuImageButton7.Location = New System.Drawing.Point(2, 3)
        Me.BunifuImageButton7.Name = "BunifuImageButton7"
        Me.BunifuImageButton7.Size = New System.Drawing.Size(35, 35)
        Me.BunifuImageButton7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton7.TabIndex = 52
        Me.BunifuImageButton7.TabStop = False
        Me.BunifuImageButton7.Zoom = 10
        '
        'BunifuImageButton6
        '
        Me.BunifuImageButton6.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton6.Image = Global.sistemaContabil.My.Resources.Resources.Validation_48px
        Me.BunifuImageButton6.ImageActive = Nothing
        Me.BunifuImageButton6.Location = New System.Drawing.Point(2, 3)
        Me.BunifuImageButton6.Name = "BunifuImageButton6"
        Me.BunifuImageButton6.Size = New System.Drawing.Size(35, 35)
        Me.BunifuImageButton6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton6.TabIndex = 52
        Me.BunifuImageButton6.TabStop = False
        Me.BunifuImageButton6.Zoom = 10
        '
        'BunifuImageButton8
        '
        Me.BunifuImageButton8.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton8.Image = Global.sistemaContabil.My.Resources.Resources.Password_48px
        Me.BunifuImageButton8.ImageActive = Nothing
        Me.BunifuImageButton8.Location = New System.Drawing.Point(2, 3)
        Me.BunifuImageButton8.Name = "BunifuImageButton8"
        Me.BunifuImageButton8.Size = New System.Drawing.Size(35, 35)
        Me.BunifuImageButton8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton8.TabIndex = 52
        Me.BunifuImageButton8.TabStop = False
        Me.BunifuImageButton8.Zoom = 10
        '
        'BunifuImageButton11
        '
        Me.BunifuImageButton11.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton11.Image = Global.sistemaContabil.My.Resources.Resources.Password_1_48px
        Me.BunifuImageButton11.ImageActive = Nothing
        Me.BunifuImageButton11.Location = New System.Drawing.Point(2, 3)
        Me.BunifuImageButton11.Name = "BunifuImageButton11"
        Me.BunifuImageButton11.Size = New System.Drawing.Size(35, 35)
        Me.BunifuImageButton11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton11.TabIndex = 52
        Me.BunifuImageButton11.TabStop = False
        Me.BunifuImageButton11.Zoom = 10
        '
        'btn_acessoadm_relatorio
        '
        Me.btn_acessoadm_relatorio.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_acessoadm_relatorio.BackColor = System.Drawing.Color.Transparent
        Me.btn_acessoadm_relatorio.Image = Global.sistemaContabil.My.Resources.Resources.Send_Hot_List_48px
        Me.btn_acessoadm_relatorio.ImageActive = Nothing
        Me.btn_acessoadm_relatorio.Location = New System.Drawing.Point(804, 6)
        Me.btn_acessoadm_relatorio.Name = "btn_acessoadm_relatorio"
        Me.btn_acessoadm_relatorio.Size = New System.Drawing.Size(30, 30)
        Me.btn_acessoadm_relatorio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_acessoadm_relatorio.TabIndex = 69
        Me.btn_acessoadm_relatorio.TabStop = False
        Me.btn_acessoadm_relatorio.Zoom = 10
        '
        'BunifuImageButton4
        '
        Me.BunifuImageButton4.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton4.Image = Global.sistemaContabil.My.Resources.Resources.Password_48px
        Me.BunifuImageButton4.ImageActive = Nothing
        Me.BunifuImageButton4.Location = New System.Drawing.Point(2, 3)
        Me.BunifuImageButton4.Name = "BunifuImageButton4"
        Me.BunifuImageButton4.Size = New System.Drawing.Size(35, 35)
        Me.BunifuImageButton4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton4.TabIndex = 52
        Me.BunifuImageButton4.TabStop = False
        Me.BunifuImageButton4.Zoom = 10
        '
        'BunifuImageButton5
        '
        Me.BunifuImageButton5.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton5.Image = Global.sistemaContabil.My.Resources.Resources.Validation_48px
        Me.BunifuImageButton5.ImageActive = Nothing
        Me.BunifuImageButton5.Location = New System.Drawing.Point(2, 3)
        Me.BunifuImageButton5.Name = "BunifuImageButton5"
        Me.BunifuImageButton5.Size = New System.Drawing.Size(35, 35)
        Me.BunifuImageButton5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton5.TabIndex = 52
        Me.BunifuImageButton5.TabStop = False
        Me.BunifuImageButton5.Zoom = 10
        '
        'BunifuImageButton3
        '
        Me.BunifuImageButton3.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton3.Image = Global.sistemaContabil.My.Resources.Resources.Gmail_48px
        Me.BunifuImageButton3.ImageActive = Nothing
        Me.BunifuImageButton3.Location = New System.Drawing.Point(2, 3)
        Me.BunifuImageButton3.Name = "BunifuImageButton3"
        Me.BunifuImageButton3.Size = New System.Drawing.Size(35, 35)
        Me.BunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton3.TabIndex = 52
        Me.BunifuImageButton3.TabStop = False
        Me.BunifuImageButton3.Zoom = 10
        '
        'BunifuImageButton2
        '
        Me.BunifuImageButton2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton2.Image = Global.sistemaContabil.My.Resources.Resources.Password_1_48px
        Me.BunifuImageButton2.ImageActive = Nothing
        Me.BunifuImageButton2.Location = New System.Drawing.Point(2, 3)
        Me.BunifuImageButton2.Name = "BunifuImageButton2"
        Me.BunifuImageButton2.Size = New System.Drawing.Size(35, 35)
        Me.BunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton2.TabIndex = 52
        Me.BunifuImageButton2.TabStop = False
        Me.BunifuImageButton2.Zoom = 10
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton1.Image = Global.sistemaContabil.My.Resources.Resources.Credit_Card_48px
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.Location = New System.Drawing.Point(2, 3)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(35, 35)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton1.TabIndex = 52
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 10
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
        'pic_logo
        '
        Me.pic_logo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pic_logo.Image = Global.sistemaContabil.My.Resources.Resources.LOGO01
        Me.pic_logo.Location = New System.Drawing.Point(270, 1)
        Me.pic_logo.Name = "pic_logo"
        Me.pic_logo.Size = New System.Drawing.Size(299, 64)
        Me.pic_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_logo.TabIndex = 67
        Me.pic_logo.TabStop = False
        '
        'btn_acessoadm_hide
        '
        Me.btn_acessoadm_hide.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_acessoadm_hide.BackColor = System.Drawing.Color.Transparent
        Me.btn_acessoadm_hide.Image = Global.sistemaContabil.My.Resources.Resources.Eye_48px
        Me.btn_acessoadm_hide.ImageActive = Nothing
        Me.btn_acessoadm_hide.Location = New System.Drawing.Point(616, 325)
        Me.btn_acessoadm_hide.Name = "btn_acessoadm_hide"
        Me.btn_acessoadm_hide.Size = New System.Drawing.Size(43, 29)
        Me.btn_acessoadm_hide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_acessoadm_hide.TabIndex = 66
        Me.btn_acessoadm_hide.TabStop = False
        Me.btn_acessoadm_hide.Zoom = 10
        '
        'btn_logout
        '
        Me.btn_logout.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_logout.BackColor = System.Drawing.Color.Transparent
        Me.btn_logout.Image = Global.sistemaContabil.My.Resources.Resources.Shutdown_48px
        Me.btn_logout.ImageActive = Nothing
        Me.btn_logout.Location = New System.Drawing.Point(809, 0)
        Me.btn_logout.Name = "btn_logout"
        Me.btn_logout.Size = New System.Drawing.Size(30, 35)
        Me.btn_logout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_logout.TabIndex = 49
        Me.btn_logout.TabStop = False
        Me.btn_logout.Zoom = 10
        '
        'btn_minimiza
        '
        Me.btn_minimiza.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_minimiza.BackColor = System.Drawing.Color.Transparent
        Me.btn_minimiza.Image = Global.sistemaContabil.My.Resources.Resources.Minimize_Window_48px1
        Me.btn_minimiza.ImageActive = Nothing
        Me.btn_minimiza.Location = New System.Drawing.Point(768, 6)
        Me.btn_minimiza.Name = "btn_minimiza"
        Me.btn_minimiza.Size = New System.Drawing.Size(29, 29)
        Me.btn_minimiza.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_minimiza.TabIndex = 1
        Me.btn_minimiza.TabStop = False
        Me.btn_minimiza.Zoom = 10
        '
        'btn_fecha
        '
        Me.btn_fecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_fecha.BackColor = System.Drawing.Color.Transparent
        Me.btn_fecha.Image = Global.sistemaContabil.My.Resources.Resources.Close_Window_48px
        Me.btn_fecha.ImageActive = Nothing
        Me.btn_fecha.Location = New System.Drawing.Point(805, 7)
        Me.btn_fecha.Name = "btn_fecha"
        Me.btn_fecha.Size = New System.Drawing.Size(28, 28)
        Me.btn_fecha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_fecha.TabIndex = 2
        Me.btn_fecha.TabStop = False
        Me.btn_fecha.Zoom = 10
        '
        'pn_menu
        '
        Me.pn_menu.BackColor = System.Drawing.SystemColors.Control
        Me.pn_menu.BackgroundImage = CType(resources.GetObject("pn_menu.BackgroundImage"), System.Drawing.Image)
        Me.pn_menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pn_menu.Controls.Add(Me.pic_logomin)
        Me.pn_menu.Controls.Add(Me.pic_logomax)
        Me.pn_menu.Controls.Add(Me.btn_show_user)
        Me.pn_menu.Controls.Add(Me.btn_show_empresa)
        Me.pn_menu.Controls.Add(Me.btn_show_report)
        Me.pn_menu.Controls.Add(Me.btn_show_bens)
        Me.pn_menu.Controls.Add(Me.btn_show_contas)
        Me.pn_menu.Controls.Add(Me.btn_show_menu)
        Me.pn_menu.Dock = System.Windows.Forms.DockStyle.Left
        Me.pn_menu.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.pn_menu.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.pn_menu.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.pn_menu.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.pn_menu.Location = New System.Drawing.Point(0, 0)
        Me.pn_menu.Name = "pn_menu"
        Me.pn_menu.Quality = 10
        Me.pn_menu.Size = New System.Drawing.Size(50, 534)
        Me.pn_menu.TabIndex = 0
        '
        'pic_logomin
        '
        Me.pic_logomin.BackColor = System.Drawing.Color.Transparent
        Me.pic_logomin.Image = Global.sistemaContabil.My.Resources.Resources.LOGO03_2
        Me.pic_logomin.Location = New System.Drawing.Point(7, 102)
        Me.pic_logomin.Name = "pic_logomin"
        Me.pic_logomin.Size = New System.Drawing.Size(35, 35)
        Me.pic_logomin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_logomin.TabIndex = 3
        Me.pic_logomin.TabStop = False
        '
        'pic_logomax
        '
        Me.pic_logomax.BackColor = System.Drawing.Color.Transparent
        Me.pic_logomax.Image = Global.sistemaContabil.My.Resources.Resources.LOGO03
        Me.pic_logomax.Location = New System.Drawing.Point(-46, 91)
        Me.pic_logomax.Name = "pic_logomax"
        Me.pic_logomax.Size = New System.Drawing.Size(287, 50)
        Me.pic_logomax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic_logomax.TabIndex = 2
        Me.pic_logomax.TabStop = False
        Me.pic_logomax.Visible = False
        '
        'btn_show_user
        '
        Me.btn_show_user.Activecolor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_show_user.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_show_user.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_show_user.BorderRadius = 0
        Me.btn_show_user.ButtonText = "    Painel do Usuário"
        Me.btn_show_user.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_show_user.DisabledColor = System.Drawing.Color.Gray
        Me.btn_show_user.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_show_user.Iconimage = Global.sistemaContabil.My.Resources.Resources.User_Menu_Male_48px
        Me.btn_show_user.Iconimage_right = Nothing
        Me.btn_show_user.Iconimage_right_Selected = Nothing
        Me.btn_show_user.Iconimage_Selected = Nothing
        Me.btn_show_user.IconMarginLeft = 0
        Me.btn_show_user.IconMarginRight = 0
        Me.btn_show_user.IconRightVisible = True
        Me.btn_show_user.IconRightZoom = 0.0R
        Me.btn_show_user.IconVisible = True
        Me.btn_show_user.IconZoom = 60.0R
        Me.btn_show_user.IsTab = True
        Me.btn_show_user.Location = New System.Drawing.Point(0, 463)
        Me.btn_show_user.Name = "btn_show_user"
        Me.btn_show_user.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_show_user.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_show_user.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_show_user.selected = False
        Me.btn_show_user.Size = New System.Drawing.Size(195, 48)
        Me.btn_show_user.TabIndex = 1
        Me.btn_show_user.Text = "    Painel do Usuário"
        Me.btn_show_user.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_show_user.Textcolor = System.Drawing.Color.White
        Me.btn_show_user.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btn_show_empresa
        '
        Me.btn_show_empresa.Activecolor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_show_empresa.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_show_empresa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_show_empresa.BorderRadius = 0
        Me.btn_show_empresa.ButtonText = "    Relatórios Gerais"
        Me.btn_show_empresa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_show_empresa.DisabledColor = System.Drawing.Color.Gray
        Me.btn_show_empresa.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_show_empresa.Iconimage = Global.sistemaContabil.My.Resources.Resources.Money_Bag_48px
        Me.btn_show_empresa.Iconimage_right = Nothing
        Me.btn_show_empresa.Iconimage_right_Selected = Nothing
        Me.btn_show_empresa.Iconimage_Selected = Nothing
        Me.btn_show_empresa.IconMarginLeft = 0
        Me.btn_show_empresa.IconMarginRight = 0
        Me.btn_show_empresa.IconRightVisible = True
        Me.btn_show_empresa.IconRightZoom = 0.0R
        Me.btn_show_empresa.IconVisible = True
        Me.btn_show_empresa.IconZoom = 60.0R
        Me.btn_show_empresa.IsTab = True
        Me.btn_show_empresa.Location = New System.Drawing.Point(0, 315)
        Me.btn_show_empresa.Name = "btn_show_empresa"
        Me.btn_show_empresa.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_show_empresa.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_show_empresa.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_show_empresa.selected = False
        Me.btn_show_empresa.Size = New System.Drawing.Size(195, 48)
        Me.btn_show_empresa.TabIndex = 1
        Me.btn_show_empresa.Text = "    Relatórios Gerais"
        Me.btn_show_empresa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_show_empresa.Textcolor = System.Drawing.Color.White
        Me.btn_show_empresa.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btn_show_report
        '
        Me.btn_show_report.Activecolor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_show_report.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_show_report.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_show_report.BorderRadius = 0
        Me.btn_show_report.ButtonText = "    Relatórios Gerais"
        Me.btn_show_report.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_show_report.DisabledColor = System.Drawing.Color.Gray
        Me.btn_show_report.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_show_report.Iconimage = Global.sistemaContabil.My.Resources.Resources.Combo_Chart_48px
        Me.btn_show_report.Iconimage_right = Nothing
        Me.btn_show_report.Iconimage_right_Selected = Nothing
        Me.btn_show_report.Iconimage_Selected = Nothing
        Me.btn_show_report.IconMarginLeft = 0
        Me.btn_show_report.IconMarginRight = 0
        Me.btn_show_report.IconRightVisible = True
        Me.btn_show_report.IconRightZoom = 0.0R
        Me.btn_show_report.IconVisible = True
        Me.btn_show_report.IconZoom = 60.0R
        Me.btn_show_report.IsTab = True
        Me.btn_show_report.Location = New System.Drawing.Point(0, 268)
        Me.btn_show_report.Name = "btn_show_report"
        Me.btn_show_report.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_show_report.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_show_report.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_show_report.selected = False
        Me.btn_show_report.Size = New System.Drawing.Size(195, 48)
        Me.btn_show_report.TabIndex = 1
        Me.btn_show_report.Text = "    Relatórios Gerais"
        Me.btn_show_report.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_show_report.Textcolor = System.Drawing.Color.White
        Me.btn_show_report.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btn_show_bens
        '
        Me.btn_show_bens.Activecolor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_show_bens.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_show_bens.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_show_bens.BorderRadius = 0
        Me.btn_show_bens.ButtonText = "    Cadastro de Bens"
        Me.btn_show_bens.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_show_bens.DisabledColor = System.Drawing.Color.Gray
        Me.btn_show_bens.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_show_bens.Iconimage = Global.sistemaContabil.My.Resources.Resources.Add_Property_48px
        Me.btn_show_bens.Iconimage_right = Nothing
        Me.btn_show_bens.Iconimage_right_Selected = Nothing
        Me.btn_show_bens.Iconimage_Selected = Nothing
        Me.btn_show_bens.IconMarginLeft = 0
        Me.btn_show_bens.IconMarginRight = 0
        Me.btn_show_bens.IconRightVisible = True
        Me.btn_show_bens.IconRightZoom = 0.0R
        Me.btn_show_bens.IconVisible = True
        Me.btn_show_bens.IconZoom = 60.0R
        Me.btn_show_bens.IsTab = True
        Me.btn_show_bens.Location = New System.Drawing.Point(0, 220)
        Me.btn_show_bens.Name = "btn_show_bens"
        Me.btn_show_bens.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_show_bens.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_show_bens.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_show_bens.selected = False
        Me.btn_show_bens.Size = New System.Drawing.Size(195, 48)
        Me.btn_show_bens.TabIndex = 1
        Me.btn_show_bens.Text = "    Cadastro de Bens"
        Me.btn_show_bens.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_show_bens.Textcolor = System.Drawing.Color.White
        Me.btn_show_bens.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btn_show_contas
        '
        Me.btn_show_contas.Activecolor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_show_contas.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_show_contas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_show_contas.BorderRadius = 0
        Me.btn_show_contas.ButtonText = "     Cadastro de Contas"
        Me.btn_show_contas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_show_contas.DisabledColor = System.Drawing.Color.Gray
        Me.btn_show_contas.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_show_contas.Iconimage = Global.sistemaContabil.My.Resources.Resources.Move_Stock_48px
        Me.btn_show_contas.Iconimage_right = Nothing
        Me.btn_show_contas.Iconimage_right_Selected = Nothing
        Me.btn_show_contas.Iconimage_Selected = Nothing
        Me.btn_show_contas.IconMarginLeft = 0
        Me.btn_show_contas.IconMarginRight = 0
        Me.btn_show_contas.IconRightVisible = True
        Me.btn_show_contas.IconRightZoom = 0.0R
        Me.btn_show_contas.IconVisible = True
        Me.btn_show_contas.IconZoom = 60.0R
        Me.btn_show_contas.IsTab = True
        Me.btn_show_contas.Location = New System.Drawing.Point(0, 172)
        Me.btn_show_contas.Name = "btn_show_contas"
        Me.btn_show_contas.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_show_contas.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_show_contas.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_show_contas.selected = True
        Me.btn_show_contas.Size = New System.Drawing.Size(195, 48)
        Me.btn_show_contas.TabIndex = 1
        Me.btn_show_contas.Text = "     Cadastro de Contas"
        Me.btn_show_contas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_show_contas.Textcolor = System.Drawing.Color.White
        Me.btn_show_contas.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btn_show_menu
        '
        Me.btn_show_menu.BackColor = System.Drawing.Color.Transparent
        Me.btn_show_menu.Image = Global.sistemaContabil.My.Resources.Resources.Menu_48px
        Me.btn_show_menu.ImageActive = Nothing
        Me.btn_show_menu.Location = New System.Drawing.Point(9, 10)
        Me.btn_show_menu.Name = "btn_show_menu"
        Me.btn_show_menu.Size = New System.Drawing.Size(30, 30)
        Me.btn_show_menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_show_menu.TabIndex = 0
        Me.btn_show_menu.TabStop = False
        Me.btn_show_menu.Zoom = 10
        '
        'tb_userBindingSource
        '
        Me.tb_userBindingSource.DataMember = "tb_user"
        Me.tb_userBindingSource.DataSource = Me.sistemaContabilDataSet
        '
        'sistemaContabilDataSet
        '
        Me.sistemaContabilDataSet.DataSetName = "sistemaContabilDataSet"
        Me.sistemaContabilDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'empresaBindingSource
        '
        Me.empresaBindingSource.DataMember = "empresa"
        Me.empresaBindingSource.DataSource = Me.sistemaContabilDataSet
        '
        'bensBindingSource
        '
        Me.bensBindingSource.DataMember = "bens"
        Me.bensBindingSource.DataSource = Me.sistemaContabilDataSet
        '
        'bensTableAdapter
        '
        Me.bensTableAdapter.ClearBeforeFill = True
        '
        'empresaTableAdapter
        '
        Me.empresaTableAdapter.ClearBeforeFill = True
        '
        'tb_userTableAdapter
        '
        Me.tb_userTableAdapter.ClearBeforeFill = True
        '
        'frm_menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(895, 534)
        Me.Controls.Add(Me.pn_cadastroempresa)
        Me.Controls.Add(Me.pn_acesso)
        Me.Controls.Add(Me.pn_relatorio)
        Me.Controls.Add(Me.pn_contas)
        Me.Controls.Add(Me.pn_bens)
        Me.Controls.Add(Me.pn_status)
        Me.Controls.Add(Me.pn_header)
        Me.Controls.Add(Me.pn_menu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_menu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Contabilizando"
        Me.pn_header.ResumeLayout(False)
        Me.pn_relatorio.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.pn_contas.ResumeLayout(False)
        Me.pn_contas.PerformLayout()
        CType(Me.dgv_conta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pn_bens.ResumeLayout(False)
        Me.pn_bens.PerformLayout()
        CType(Me.txt_bens_taxa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_bens, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pn_acesso.ResumeLayout(False)
        Me.tab_admin.ResumeLayout(False)
        Me.tab_operador.ResumeLayout(False)
        Me.tab_operador.PerformLayout()
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.tab_adm.ResumeLayout(False)
        Me.tab_adm.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pn_status.ResumeLayout(False)
        Me.pn_status.PerformLayout()
        Me.pn_cadastroempresa.ResumeLayout(False)
        Me.pn_cadastroempresa.PerformLayout()
        CType(Me.dgv_empresa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel13.ResumeLayout(False)
        Me.Panel13.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_acessoop_hide, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_acessoadm_relatorio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img_login, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_logo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_acessoadm_hide, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_logout, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_minimiza, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_fecha, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pn_menu.ResumeLayout(False)
        CType(Me.pic_logomin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_logomax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_show_menu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tb_bensBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tb_userBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sistemaContabilDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.empresaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bensBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents pn_menu As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents btn_show_menu As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btn_show_contas As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btn_show_user As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btn_show_report As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btn_show_bens As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents pn_header As Panel
    Friend WithEvents btn_minimiza As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btn_fecha As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents pic_logomax As PictureBox
    Friend WithEvents pic_logomin As PictureBox
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents pn_relatorio As Panel
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents tb_bensBindingSource As BindingSource
    Friend WithEvents pn_acesso As Panel
    Friend WithEvents pn_bens As Panel
    Friend WithEvents pn_contas As Panel
    Friend WithEvents pn_status As Panel
    Friend WithEvents lbl_hora As Label
    Friend WithEvents lbl_data As Label
    Friend WithEvents lbl_user_logado As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents btn_logout As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Timer1 As Timer
    Friend WithEvents tab_admin As TabControl
    Friend WithEvents tab_operador As TabPage
    Friend WithEvents tab_adm As TabPage
    Friend WithEvents chk_acessoadm_admin As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents Administrador As Label
    Friend WithEvents btn_acessoadm_salvar As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents BunifuImageButton4 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents txt_acessoadm_senha1 As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents BunifuImageButton3 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents txt_acessoadm_email As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents BunifuImageButton2 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents txt_acessoadm_login As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents img_login As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents txt_acessoadm_nome As TextBox
    Friend WithEvents btn_acessoadm_cancel As Button
    Friend WithEvents Panel6 As Panel
    Friend WithEvents BunifuImageButton5 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents txt_acessoadm_senha2 As TextBox
    Friend WithEvents btn_acessoadm_hide As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents txt_acessoadm_cpf As MaskedTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents pic_logo As PictureBox
    Friend WithEvents btn_acessoadm_relatorio As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btn_acessoop_hide As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btn_acessoop_cancel As Button
    Friend WithEvents btn_acessoop_salvar As Button
    Friend WithEvents Panel7 As Panel
    Friend WithEvents BunifuImageButton8 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents txt_acessoop_senha1 As TextBox
    Friend WithEvents Panel10 As Panel
    Friend WithEvents BunifuImageButton11 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents txt_acessoop_login As TextBox
    Friend WithEvents Panel12 As Panel
    Friend WithEvents BunifuImageButton7 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents txt_acessoop_senha2 As TextBox
    Friend WithEvents Panel11 As Panel
    Friend WithEvents BunifuImageButton6 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents txt_acessoop_senha3 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cmb_conta_3c As ComboBox
    Friend WithEvents cmb_conta_2c As ComboBox
    Friend WithEvents cmb_conta_1c As ComboBox
    Friend WithEvents txt_conta_nome As TextBox
    Friend WithEvents txt_conta_valor As TextBox
    Friend WithEvents dgv_conta As DataGridView
    Friend WithEvents nome As DataGridViewTextBoxColumn
    Friend WithEvents classificacaoExterna As DataGridViewTextBoxColumn
    Friend WithEvents classificacaoInterna As DataGridViewTextBoxColumn
    Friend WithEvents saldo As DataGridViewTextBoxColumn
    Friend WithEvents cmb_bens_tipo As ComboBox
    Friend WithEvents txt_bens_nome As TextBox
    Friend WithEvents dgv_bens As DataGridView
    Friend WithEvents dtp_bens_inicial As DateTimePicker
    Friend WithEvents txt_bens_valorfi As TextBox
    Friend WithEvents txt_bens_valorini As TextBox
    Friend WithEvents dtp_bens_final As DateTimePicker
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btn_conta_add As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents txt_bens_taxa As NumericUpDown
    Friend WithEvents Label8 As Label
    Friend WithEvents btn_bens_cancelar As Button
    Friend WithEvents btn_bens_add As Button
    Friend WithEvents codigo As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents preco As DataGridViewTextBoxColumn
    Friend WithEvents depreciado As DataGridViewTextBoxColumn
    Friend WithEvents Label16 As Label
    Friend WithEvents txt_bens_depreciacao As TextBox
    Friend WithEvents pn_cadastroempresa As Panel
    Friend WithEvents btn_empresa_add As Button
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents txt_empresa_enderaco As TextBox
    Friend WithEvents txt_empres_respo As TextBox
    Friend WithEvents txt_empres_nome As TextBox
    Friend WithEvents txt_empresa_cnpj As TextBox
    Friend WithEvents txt_empresa_cep As TextBox
    Friend WithEvents dgv_empresa As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents btn_show_empresa As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents bt_relatorio_bens As Button
    Friend WithEvents bt_relatorio_empresa As Button
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents ReportViewer2 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents bensBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents sistemaContabilDataSet As sistemaContabil.sistemaContabilDataSet
    Friend WithEvents bensTableAdapter As sistemaContabil.sistemaContabilDataSetTableAdapters.bensTableAdapter
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents lbl_bens As System.Windows.Forms.Label
    Friend WithEvents ReportViewer3 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents empresaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents lbl_empresa As System.Windows.Forms.Label
    Friend WithEvents empresaTableAdapter As sistemaContabil.sistemaContabilDataSetTableAdapters.empresaTableAdapter
    Friend WithEvents Panel13 As System.Windows.Forms.Panel
    Friend WithEvents ReportViewer4 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents tb_userBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents tb_userTableAdapter As sistemaContabil.sistemaContabilDataSetTableAdapters.tb_userTableAdapter
    Friend WithEvents lbl_usuario As System.Windows.Forms.Label
End Class

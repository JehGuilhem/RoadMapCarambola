<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadClientes
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
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.lbCodigo = New System.Windows.Forms.Label()
        Me.txtCodBusca = New System.Windows.Forms.TextBox()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BdCadastroDataSet = New ProjetoCadastroAcess.bdCadastroDataSet()
        Me.lbNome = New System.Windows.Forms.Label()
        Me.txtEndereco = New System.Windows.Forms.TextBox()
        Me.lbEndereco = New System.Windows.Forms.Label()
        Me.txtTelefone = New System.Windows.Forms.TextBox()
        Me.lbTelefone = New System.Windows.Forms.Label()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnLimpar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ClientesTableAdapter = New ProjetoCadastroAcess.bdCadastroDataSetTableAdapters.clientesTableAdapter()
        Me.txtCodCliente = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.NomecliDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EndcliDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelcliDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BdCadastroDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnNovo
        '
        Me.btnNovo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNovo.Location = New System.Drawing.Point(36, 148)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(75, 23)
        Me.btnNovo.TabIndex = 0
        Me.btnNovo.Text = "Novo"
        Me.btnNovo.UseVisualStyleBackColor = True
        '
        'lbCodigo
        '
        Me.lbCodigo.AutoSize = True
        Me.lbCodigo.Location = New System.Drawing.Point(12, 23)
        Me.lbCodigo.Name = "lbCodigo"
        Me.lbCodigo.Size = New System.Drawing.Size(40, 13)
        Me.lbCodigo.TabIndex = 1
        Me.lbCodigo.Text = "Codigo"
        '
        'txtCodBusca
        '
        Me.txtCodBusca.Location = New System.Drawing.Point(15, 40)
        Me.txtCodBusca.Name = "txtCodBusca"
        Me.txtCodBusca.Size = New System.Drawing.Size(66, 20)
        Me.txtCodBusca.TabIndex = 2
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(15, 93)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(250, 20)
        Me.txtNome.TabIndex = 4
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "clientes"
        Me.ClientesBindingSource.DataSource = Me.BdCadastroDataSet
        '
        'BdCadastroDataSet
        '
        Me.BdCadastroDataSet.DataSetName = "bdCadastroDataSet"
        Me.BdCadastroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lbNome
        '
        Me.lbNome.AutoSize = True
        Me.lbNome.Location = New System.Drawing.Point(12, 76)
        Me.lbNome.Name = "lbNome"
        Me.lbNome.Size = New System.Drawing.Size(35, 13)
        Me.lbNome.TabIndex = 3
        Me.lbNome.Text = "Nome"
        '
        'txtEndereco
        '
        Me.txtEndereco.Location = New System.Drawing.Point(281, 93)
        Me.txtEndereco.Name = "txtEndereco"
        Me.txtEndereco.Size = New System.Drawing.Size(237, 20)
        Me.txtEndereco.TabIndex = 6
        '
        'lbEndereco
        '
        Me.lbEndereco.AutoSize = True
        Me.lbEndereco.Location = New System.Drawing.Point(278, 76)
        Me.lbEndereco.Name = "lbEndereco"
        Me.lbEndereco.Size = New System.Drawing.Size(53, 13)
        Me.lbEndereco.TabIndex = 5
        Me.lbEndereco.Text = "Endereco"
        '
        'txtTelefone
        '
        Me.txtTelefone.Location = New System.Drawing.Point(534, 93)
        Me.txtTelefone.Name = "txtTelefone"
        Me.txtTelefone.Size = New System.Drawing.Size(101, 20)
        Me.txtTelefone.TabIndex = 8
        '
        'lbTelefone
        '
        Me.lbTelefone.AutoSize = True
        Me.lbTelefone.Location = New System.Drawing.Point(531, 76)
        Me.lbTelefone.Name = "lbTelefone"
        Me.lbTelefone.Size = New System.Drawing.Size(49, 13)
        Me.lbTelefone.TabIndex = 7
        Me.lbTelefone.Text = "Telefone"
        '
        'btnSalvar
        '
        Me.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalvar.Location = New System.Drawing.Point(117, 148)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(75, 23)
        Me.btnSalvar.TabIndex = 9
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'btnExcluir
        '
        Me.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExcluir.Location = New System.Drawing.Point(279, 148)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(75, 23)
        Me.btnExcluir.TabIndex = 10
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'btnLimpar
        '
        Me.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLimpar.Location = New System.Drawing.Point(360, 148)
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpar.TabIndex = 11
        Me.btnLimpar.Text = "Limpar"
        Me.btnLimpar.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NomecliDataGridViewTextBoxColumn, Me.EndcliDataGridViewTextBoxColumn, Me.TelcliDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ClientesBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(15, 228)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(620, 194)
        Me.DataGridView1.TabIndex = 12
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'txtCodCliente
        '
        Me.txtCodCliente.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "cod_cli", True))
        Me.txtCodCliente.Location = New System.Drawing.Point(575, 12)
        Me.txtCodCliente.Name = "txtCodCliente"
        Me.txtCodCliente.ReadOnly = True
        Me.txtCodCliente.Size = New System.Drawing.Size(60, 20)
        Me.txtCodCliente.TabIndex = 13
        '
        'btnBuscar
        '
        Me.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscar.Location = New System.Drawing.Point(100, 38)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 14
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditar.Location = New System.Drawing.Point(198, 148)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(75, 23)
        Me.btnEditar.TabIndex = 16
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'NomecliDataGridViewTextBoxColumn
        '
        Me.NomecliDataGridViewTextBoxColumn.DataPropertyName = "nome_cli"
        Me.NomecliDataGridViewTextBoxColumn.FillWeight = 130.0!
        Me.NomecliDataGridViewTextBoxColumn.HeaderText = "nome"
        Me.NomecliDataGridViewTextBoxColumn.Name = "NomecliDataGridViewTextBoxColumn"
        '
        'EndcliDataGridViewTextBoxColumn
        '
        Me.EndcliDataGridViewTextBoxColumn.DataPropertyName = "end_cli"
        Me.EndcliDataGridViewTextBoxColumn.FillWeight = 120.0!
        Me.EndcliDataGridViewTextBoxColumn.HeaderText = "endereco"
        Me.EndcliDataGridViewTextBoxColumn.Name = "EndcliDataGridViewTextBoxColumn"
        '
        'TelcliDataGridViewTextBoxColumn
        '
        Me.TelcliDataGridViewTextBoxColumn.DataPropertyName = "tel_cli"
        Me.TelcliDataGridViewTextBoxColumn.FillWeight = 50.0!
        Me.TelcliDataGridViewTextBoxColumn.HeaderText = "telefone"
        Me.TelcliDataGridViewTextBoxColumn.Name = "TelcliDataGridViewTextBoxColumn"
        '
        'frmCadClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(671, 450)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtCodCliente)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnLimpar)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.txtTelefone)
        Me.Controls.Add(Me.lbTelefone)
        Me.Controls.Add(Me.txtEndereco)
        Me.Controls.Add(Me.lbEndereco)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.lbNome)
        Me.Controls.Add(Me.txtCodBusca)
        Me.Controls.Add(Me.lbCodigo)
        Me.Controls.Add(Me.btnNovo)
        Me.Name = "frmCadClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Clientes"
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BdCadastroDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnNovo As Button
    Friend WithEvents lbCodigo As Label
    Friend WithEvents txtCodBusca As TextBox
    Friend WithEvents txtNome As TextBox
    Friend WithEvents lbNome As Label
    Friend WithEvents txtEndereco As TextBox
    Friend WithEvents lbEndereco As Label
    Friend WithEvents txtTelefone As TextBox
    Friend WithEvents lbTelefone As Label
    Friend WithEvents btnSalvar As Button
    Friend WithEvents btnExcluir As Button
    Friend WithEvents btnLimpar As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BdCadastroDataSet As bdCadastroDataSet
    Friend WithEvents ClientesBindingSource As BindingSource
    Friend WithEvents ClientesTableAdapter As bdCadastroDataSetTableAdapters.clientesTableAdapter
    Friend WithEvents txtCodCliente As TextBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents NomecliDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EndcliDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TelcliDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class

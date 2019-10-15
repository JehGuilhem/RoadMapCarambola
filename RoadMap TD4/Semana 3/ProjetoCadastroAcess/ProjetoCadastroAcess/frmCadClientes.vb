Public Class frmCadClientes
    Private Sub FrmCadClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'BdCadastroDataSet.clientes'. Você pode movê-la ou removê-la conforme necessário.
        Me.ClientesTableAdapter.Fill(Me.BdCadastroDataSet.clientes)

    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim cliList = From clientes In BdCadastroDataSet.clientes
                      Where (clientes.cod_cli = CInt(txtCodBusca.Text))
                      Select clientes.nome_cli, clientes.end_cli, clientes.tel_cli

        For Each cli In cliList
            txtNome.Text = cli.nome_cli
            txtEndereco.Text = cli.end_cli
            txtTelefone.Text = cli.tel_cli

        Next
    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Me.Validate()
        Me.ClientesBindingSource.EndEdit()
        Me.BdCadastroDataSet.AcceptChanges()
        Me.ClientesTableAdapter.Update_cli(txtNome.Text,
        txtEndereco.Text, txtTelefone.Text, txtCodBusca.Text)
    End Sub
End Class

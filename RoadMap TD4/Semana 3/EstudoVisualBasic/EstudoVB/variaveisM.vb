Module variaveisM

    Sub main()
        'Declarando uma variavel
        'nao precisa do ponto e virgula no final
        Dim info As String

        'Função para escrever algo no console
        Console.Write("Entre com a informação ")

        'Leitura da variavel no console
        info = Console.ReadLine()

        'Exibir a informação
        Console.WriteLine("A informação é {0} ", info)

        Console.ReadKey()

    End Sub


End Module

Module exemplo1

    Sub main()

        'DECLARANDO VARIAVEIS
        'nao precisa do ponto e virgula no final

        Dim num1, num2 As Integer
        Dim soma, subt, mult, div As Integer
        Dim dec As Decimal

        'Função para escrever algo no console
        Console.Write("Entre com o primeiro numero: ")
        num1 = Console.ReadLine()

        Console.Write("Entre com o segundo numero: ")
        num2 = Console.ReadLine()

        soma = num1 + num2
        '\ devolve uma variavel inteira
        div = num1 \ num2
        mult = num1 * num2
        subt = num1 - num2
        'variavel dec traz uma variavel decimal
        dec = num1 / num2

        Console.WriteLine("A soma sera: {0} + {1} = {2} ", num1, num2, soma)
        Console.WriteLine("A divisao sera: {0} ", div)
        Console.WriteLine("A multiplicacao sera: {0} ", mult)
        Console.WriteLine("A subtracao sera: {0} ", subt)
        Console.WriteLine("A divisao total sera: {0} ", dec)

        Console.ReadKey()

    End Sub
End Module

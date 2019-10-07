Module exemplo2

    Sub main()

        Dim nota As Integer
        Dim media As Integer

        media = 60

        Console.WriteLine("Entre com a nota: ")
        nota = Console.ReadLine()

        If nota > media Then
            Console.WriteLine("Nota: {0} e voce foi aprovado.", nota)
        Else
            Console.WriteLine("Nota: {0} e voce foi reprovado.", nota)
        End If

        Console.ReadKey()

    End Sub

End Module

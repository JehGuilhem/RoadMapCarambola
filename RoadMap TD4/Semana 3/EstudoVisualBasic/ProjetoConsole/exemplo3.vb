Module exemplo3
    Sub main()

        Dim nota As Integer
        Dim media As Integer
        Dim minima As Integer

        media = 60
        minima = 80

        Console.WriteLine("Entre com a nota: ")
        nota = Console.ReadLine()

        ''Estudo Switch Case
        Select Case (nota)
            Case 0 To 59
                Console.WriteLine("Reprovado")
            Case 60 To 70
                Console.WriteLine("Aprovado na Media")
            Case 71 To 80
                Console.WriteLine("Aprovado com boa nota")
            Case 81 To 100
                Console.WriteLine("Aprovado com nota excelente")
        End Select

        Console.ReadKey()

    End Sub
End Module

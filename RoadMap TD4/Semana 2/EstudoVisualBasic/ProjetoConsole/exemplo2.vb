﻿Module exemplo2

    Sub main()

        Dim nota As Integer
        Dim media As Integer
        Dim minima As Integer

        media = 60
        minima = 80

        Console.WriteLine("Entre com a nota: ")
        nota = Console.ReadLine()

        If nota > media And nota < minima Then
            Console.WriteLine("Nota: {0} e voce foi aprovado.", nota)
        ElseIf nota > 81 Then
            Console.WriteLine("Nota: {0} e voce foi aprovado com sucesso.", nota)
        Else
            Console.WriteLine("Nota: {0} e voce foi reprovado.", nota)
        End If

        Console.ReadKey()

    End Sub

End Module
Option Strict On
Module Module1

    Sub Main()
        Dim nota As Double = -4
        Dim otraVariableParaAlexandre As Integer = 0

        If nota < 5 And nota >= 0 Then
            Console.WriteLine("Suspenso")
        ElseIf nota < 0 Or nota > 10 Then
            Console.WriteLine("Error en la nota")
        Else
            Console.WriteLine("Aprobado")

        End If





        Dim condicionAprobado As Boolean
        'Suspenso si nota < 5
        condicionAprobado = nota >= 5






        If condicionAprobado Then
            Console.WriteLine("Aprobado")
        Else
            Console.WriteLine("Suspenso")
        End If

        If nota < 5 Then

            otraVariableParaAlexandre += 1
            Console.WriteLine("Suspenso")

        Else
            otraVariableParaAlexandre += 10
            Console.WriteLine("Aprobado")
        End If

        Console.ReadLine()


    End Sub

End Module

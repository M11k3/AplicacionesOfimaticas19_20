Option Strict On
Module Module1

    Sub Main()
        'Programa que indique si un número es par y superior a 100
        'O si solo es par pero inferior a 100

        Dim numero As Integer = 191

        If numero > 100 And numero Mod 2 = 0 Then
            Console.WriteLine("Número > 100 y par")
        Else
            Console.WriteLine("El número no es par y > 100")
        End If


        'Otra forma
        If numero > 100 Then
            If numero Mod 2 = 0 Then
                Console.WriteLine("Numero > 100 y Par")
            Else
                Console.WriteLine("Numero > 100 e impar")
            End If
        Else
            Console.WriteLine("Número <= 100")
        End If






        Console.ReadLine()

    End Sub

End Module

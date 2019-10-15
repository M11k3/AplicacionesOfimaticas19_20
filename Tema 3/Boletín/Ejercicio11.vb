Module Ejercicio11
    Sub Main()
        Dim numero As Integer = 17

        'Ver si es múltiplo de 2 o de 3

        If numero Mod 2 = 0 Or numero Mod 3 = 0 Then
            Console.WriteLine("Multiplo de 2 o de 3")
        End If

        If numero Mod 2 = 0 And numero Mod 3 = 0 Then
            Console.WriteLine("Múltiplo de 2 y de 3")

        Else
            If numero Mod 2 = 0 Then
                Console.WriteLine("Múltiplo de 2")

            Else
                If numero Mod 3 = 0 Then
                    Console.WriteLine("Múltiplo de 3")

                Else
                    Console.WriteLine("No es multiplo de ninguno")
                End If
            End If
        End If

        Console.ReadLine()

    End Sub
End Module

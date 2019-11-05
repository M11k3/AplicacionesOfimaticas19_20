Option Strict On
Module Module1

    Sub Main()
        'Encontrar el primer número divisible entre 7 , 13 en un rango determinado
        Dim n, m, i As Integer
        n = 190
        m = 1500

        'Inicializar variable de control
        i = n
        Dim contador As Integer
        Dim suma As Integer = 0
        While i <= m

            If i Mod 7 = 0 And i Mod 13 = 0 Then
                contador += 1

                'Salir del bucle
                Console.WriteLine(contador & "º " & i)
                Exit While


            End If
            'Incrementar la variable de control
            i += 1
        End While
        Console.WriteLine("Suma de múltiplos es : " & suma)
        Console.ReadLine()
    End Sub

End Module

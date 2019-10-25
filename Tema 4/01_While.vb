Option Strict On
Module Module1

    Sub Main()
        'Mostrar los números del 1 al 100 por pantalla
        Dim i As Integer
        'Inicializar la variable de control
        i = 1

        While i <= 100
            Console.Write(i & " ")

            'Modificar la variable de control
            i += 1
        End While

        'contar cuantos números multiplos de 3 y 11 hay por debajo de un número
        'n introducido por teclado

        Dim n As Integer = 2900000
        Dim contador As Integer = 0
        Console.WriteLine()
        Console.WriteLine("Múltiplos de 3 y de 11:")
        i = 33
        While i <= n

            If i Mod 3 = 0 And i Mod 11 = 0 Then
                ' Console.Write(i & " ")
                contador += 1

            End If


            i += 1
        End While

        If contador = 0 Then
            Console.WriteLine("No se encontraron múltiplos de 3 y de 11")
        Else
            Console.WriteLine("Hay " & contador & " múltiplos de 3 y de 11")
        End If

        Console.ReadLine()

    End Sub

End Module

Module Ejercicio9
    Sub Main()
        Dim n1, n2 As Integer
        Dim potencia As Long

        Console.WriteLine("Introduzca número 1:")
        n1 = Convert.ToInt32(Console.ReadLine())
        Console.WriteLine("Introduzca número 2:")
        n2 = Convert.ToInt32(Console.ReadLine())

        If n1 < n2 Then
            potencia = Math.Pow(n2, n1)
        Else
            potencia = Math.Pow(n1, n2)
        End If

        Console.WriteLine("El más pequeño elevado al más grande es : " & potencia)
        Console.ReadLine()
    End Sub
End Module

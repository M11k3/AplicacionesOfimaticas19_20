Module Ejercicio12
    Sub Main()
        Dim precio As Double = 900
        Dim precioFinal As Double

        If precio >= 100 Then
            precioFinal = precio - 0.15 * precio
        Else
            precioFinal = precio - 0.1 * precio
        End If
        Console.WriteLine("Precio inicial : " & precio)
        Console.WriteLine("Precio final : " & precioFinal)
        Console.ReadLine()
    End Sub
End Module

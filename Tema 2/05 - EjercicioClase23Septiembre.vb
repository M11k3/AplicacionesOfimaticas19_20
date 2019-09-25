Module Module1

    Sub Main()
        'Declarar las variables
        Dim precio As Single = 45
        Dim unidades As Integer = 10
        Dim precioFinal As Single = precio * unidades
        'Aplicar descuento del 15%
        Dim descuento As Single = (precioFinal * 15) / 100

        'precio = 15
        'unidades = 10

        'Mostrar el precio final por pantalla
        Console.WriteLine("Precio final: " & precioFinal)
        'Calcular precio final con descuento
        precioFinal = precioFinal - descuento
        'Otra forma alternativa
        'precioFinal = precioFinal * 0.85
        'precioFinal = precioFinal - precioFinal * 0.15
        Console.WriteLine("Descuento aplicado : " & descuento & " euros")
        Console.WriteLine("Precio final: " & precioFinal & " euros.")
        Console.ReadLine()

    End Sub

End Module

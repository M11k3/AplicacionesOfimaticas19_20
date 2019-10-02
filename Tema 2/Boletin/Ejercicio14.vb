Module Ejercicio14
    Sub Main()
        Dim precioInicial, descuento, ahorro, precioFinal As Double

        Console.WriteLine("Precio inicial ? : ")
        precioInicial = Convert.ToDouble(Console.ReadLine())

        Console.WriteLine("Descuento : ")
        descuento = Convert.ToDouble(Console.ReadLine())

        ahorro = (precioInicial * descuento) / 100

        precioFinal = precioInicial - ahorro

        Console.WriteLine("Precio inicial : " & precioInicial)
        Console.WriteLine("Ahorro : " & ahorro)
        Console.WriteLine("Precio final : " & precioFinal)

        Console.ReadLine()
    End Sub
End Module

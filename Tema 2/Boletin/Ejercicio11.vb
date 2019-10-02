
Module Ejercicio11
    Sub Main()
        Dim cateto1, cateto2, hipotenusa As Double

        cateto1 = 4
        cateto2 = 5

        hipotenusa = Math.Sqrt(Math.Pow(cateto1, 2) + Math.Pow(cateto2, 2))

        Console.WriteLine("Hipotenusa : " & hipotenusa)
        Console.ReadLine()
    End Sub
End Module

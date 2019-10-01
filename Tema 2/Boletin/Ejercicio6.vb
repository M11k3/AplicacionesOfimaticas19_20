Option Strict On
Module Ejercicio6
    Sub Main()
        Console.WriteLine("Ejercicio 6")
        'Solicitar 2 números
        Dim n1, n2 As Integer
        Dim suma, resta, multiplicacion As Integer
        Dim division As Double

        'Solicitar n1  y n2 por teclado
        Console.WriteLine("Introduzca n1")
        n1 = Convert.ToInt32(Console.ReadLine())
        Console.WriteLine("Introduzca n2")
        n2 = Convert.ToInt32(Console.ReadLine())

        'Calculamos suma resta y multiplicación
        suma = n1 + n2
        resta = n1 - n2
        multiplicacion = n1 * n2
        division = n1 / n2

        'Mostar resultados por pantalla
        Console.WriteLine(n1 & " + " & n2 & " = " & suma)
        Console.WriteLine("n1 - n2 = " & resta)
        Console.WriteLine("n1 * n2 = " & multiplicacion)
        Console.WriteLine("n1 / n2 = " & division)

        Console.ReadLine()
    End Sub
End Module

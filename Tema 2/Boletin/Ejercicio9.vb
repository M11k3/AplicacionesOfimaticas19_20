Module Ejercicio9
    Sub Main()
        'Intercambiar el valor de 2 variables
        Dim x, y, z As Integer
        'Damos valores iniciales a x e y
        x = 8
        y = 2
        'Mostramos mensaje con valores de x e y
        Console.WriteLine("x = " & x)
        Console.WriteLine("y = " & y)
        'Guardamos el valor de x en z
        z = x
        'Asignamos a x el valor de y
        x = y
        'Asignamos a y el valor de z (original de x)
        y = z

        'Mostramos por pantalla los valores de x e y
        Console.WriteLine()
        Console.WriteLine("Después del intercambio : ")
        Console.WriteLine("x = " & x)
        Console.WriteLine("y = " & y)
        Console.ReadLine()
    End Sub
End Module

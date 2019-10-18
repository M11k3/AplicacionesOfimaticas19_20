Option Strict On
Module Ejercicio7

    Sub Main()
        Dim num1, num2 As Double
        Dim suma As Double
        Dim raiz As Double

        'Solicito num1  y num2 por pantalla
        Console.WriteLine("Introduzca numero 1:")
        num1 = Convert.ToDouble(Console.ReadLine())

        Console.WriteLine("Introduzca numero 2:")
        num2 = Convert.ToDouble(Console.ReadLine())

        'Calculamos la suma
        suma = num1 + num2

        'Comprobar si suma >= 0
        If suma >= 0 Then
            raiz = Math.Sqrt(suma)
            Console.WriteLine("La raiz de " & suma & " es " & raiz)
        Else
            Console.WriteLine("No tiene raiz.")
        End If

        'Para calcular raices de orden superior
        ' num1 al cubo
        ' Math.Pow(num1, 1 / 3)


        Console.ReadLine()





    End Sub

End Module

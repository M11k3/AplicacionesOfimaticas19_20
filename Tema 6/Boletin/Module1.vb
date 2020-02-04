Module Module1

    Sub Main()
        'Probar función ejercicio 2
        Dim n As Integer
        Console.WriteLine("Introduce un número")
        n = Convert.ToInt32(Console.ReadLine())
        Dim raiz As Double = raizCuadrada(n)
        Console.WriteLine("La raíz cuadrad de " & n & " es " & raiz)
        Console.WriteLine("Raiz con 2 decimales: " & raizCuadrada(n, 2))
        Console.WriteLine("Raiz con 3 decimales: " & raizCuadrada(n, 3))

        Console.WriteLine("El más pequeño es: " & minimo(8, 3))
        Dim x As Integer = 9
        Dim y As Integer = 39
        Console.WriteLine("El más pequeño es: " & minimo(x, y))

        'Probar función ejercicio 4: is Primo

        If isPrimo(n) Then
            Console.WriteLine("Es primo")
        Else
            Console.WriteLine("No es primo.")
        End If


        Dim matriz() As Integer = {5, 7, 9, 8, 7, 2, 1}

        For Each numero As Integer In matriz
            If isPrimo(numero) Then
                e(numero & " es primo")
            End If
        Next

        'Probar ejercicio 6
        Dim n1 As Integer = 5
        Dim n2 As Integer = 9
        Console.WriteLine("n1 = " & n1)
        Console.WriteLine("n2 = " & n2)
        intercambiar(n1, n2)
        Console.WriteLine()
        e("intercambio: ")
        e("n1 = " & n1)
        e("n2 = " & n2)

        e("probando ejercicio 7")




        Console.ReadLine()
    End Sub

End Module

Imports MisFunciones.Class1
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

        e("Prueba ejercicio 8:")
        e("----------------------")

        Dim sum As Integer
        sumaReferencia(5, sum)

        e("La suma de los divisores de 5 es : " & sum)

        e(" ")
        e("************** EJERCICIO 9 ************")

        Dim m() As Integer = {9, 8, 10, 6, 2, 3}

        Dim posPrimerCero As Integer = buscaPrimerCero(m)

        If posPrimerCero = -1 Then
            e("no hay ceros")
        Else
            e("El primer cero está en la posición: " & posPrimerCero)
        End If

        e(" *********************** ")
        e("         EJERCICIO 13         ")

        Dim nombres(9) As String
        nombres(0) = "Alejandro"
        Console.WriteLine("Introduce un nombre")
        Dim name As String = Console.ReadLine()

        'Guardarlo en la primera pos vacia
        guardarString(nombres, name)

        'mostrar matriz por pantalla
        mostrarMatriz(nombres)


        'Prueba ejercicio 17
        Dim matrizNumeros() As Integer = {4, 5, -1, 9, -5, 8, -2}

        Dim negativos() As Integer = crearMatrizNumerosNegativos(matrizNumeros)

        e("matriz numeros negativos:")
        mostrarMatriz(negativos)

        'Explicacion redimensionado de matrices
        Dim m1() As String = {"Juan", "Lucía", "Sara", "Roberto"}



        guardarStringRedimensionando(m1, "Pablo")
        guardarStringRedimensionando(m1, "Ahí lo único que hiciste fue")
        Console.WriteLine("Matriz ejercicio 17")
        mostrarMatriz(m1)









        Console.ReadLine()
    End Sub

End Module

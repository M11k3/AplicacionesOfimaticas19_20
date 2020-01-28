Option Strict On
Module Module1

    'Función que recibe un número entero y devuelve
    'un boolean indicando si es par o no


    Function esPar(ByVal numero As Integer) As Boolean

        'Dim par As Boolean = False

        'If numero Mod 2 = 0 Then
        '    par = True

        'End If
        'Return par

        If numero Mod 2 = 0 Then
            Return True

        Else
            Return False
        End If
    End Function


    Sub Main()

        Dim valor As Integer = 8

        'Llamar a la función esPar
        Dim par As Boolean = esPar(valor)
        ' Console.WriteLine(esPar(328432))
        If esPar(398343) Then
            Console.WriteLine("Par")
        Else
            Console.WriteLine("Impar")
        End If


        Dim resultado As Integer = sumar2Numeros(4, 5)
        Dim x As Integer = 4
        Dim y As Integer = 9
        Dim resultado2 As Integer = FuncionesMatematicas.sumar2Numeros(x, y)

        'Probar función que genera matriz
        Dim numeroElementos As Integer = 10
        Dim matriz() As Integer = generarMatriz(numeroElementos)
        printaMatriz(matriz)
        Dim matriz2() As Integer = generarMatriz(10)
        printaMatriz(matriz2)
        Dim matriz3() As Integer = generarMatriz(10)
        printaMatriz(matriz3)
        Dim matriz4() As Integer = generarMatriz(10, -5, 900)
        printaMatriz(matriz4)
        Dim matriz5() As Integer = generarMatriz(10, 8, 90)
        printaMatriz(matriz5)

        Console.ReadLine()











    End Sub

End Module

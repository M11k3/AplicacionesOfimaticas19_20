Option Strict On
Module Module1

    Sub Main()
        Dim array1D(9) As Integer

        'Declarar e inicializar matriz 2d con valores
        Dim matriz2D(,) As Integer = {{4, 1, 9}, {0, 8, 1}, {2, 3, 10}, {1, 1, 1}}
        'La propiedad .length ahora nos dice el número de total de elementos de la matriz
        Dim cantidadElementos As Integer = matriz2D.Length
        Console.WriteLine("Número elementos matriz 3X3 : " & cantidadElementos)

        'Obtener último índice de fila accesible
        Dim ultimaFila As Integer = matriz2D.GetUpperBound(0)
        'Obtener último índice de columna
        Dim ultimaColumna As Integer = matriz2D.GetUpperBound(1)

        Console.WriteLine("Última índice de fila: " & ultimaFila)
        Console.WriteLine("Última índice de columna: " & ultimaColumna)

        'Mostrar todos los datos en forma de matriz
        Console.WriteLine("Datos de la matriz2D:")
        For i As Integer = 0 To matriz2D.GetUpperBound(0) Step 1
            For j As Integer = 0 To matriz2D.GetUpperBound(1) Step 1
                Console.Write(matriz2D(i, j) & " ")
            Next
            'Salto de fila
            Console.WriteLine()
        Next

        'Calcular la suma de los valores de la primera fila

        Dim suma As Integer

        For i As Integer = 0 To matriz2D.GetUpperBound(1) Step 1
            suma = suma + matriz2D(0, i)
        Next


        'Declarar matriz2d 3x3 sin inicializar
        Dim matriz2Dprima(2, 2) As Integer

        'Declarar matriz2D 4x20 sin inicializar
        Dim matriz2d4x20(3, 19) As Integer

        'Declarar e inicializar matriz 2x5
        Dim matriz2d2x5(,) As Integer = {{1, 2, 3, 4, 5}, {8, 4, 3, 2, 1}}
        Dim cantidadElementos2 As Integer = matriz2d2x5.Length
        Console.WriteLine("Número elementos matriz 2x5: " & cantidadElementos2)
        Console.WriteLine("Último índice de fila: " & matriz2d2x5.GetUpperBound(0))
        Console.WriteLine("Ultimo índice de columna: " & matriz2d2x5.GetUpperBound(1))






        'Matrices 3D

        Dim matriz3D(,,) As Integer = {{{1, 1, 1}}, {{2, 2, 2}}, {{3, 3, 3}}, {{4, 4, 4}}}
        Dim matriz3DConValores(2, 2, 2) As Integer


        Console.ReadLine()

    End Sub

End Module

Option Strict On
Module Module1

    Sub Main()
        'Declarar un array con capacidad para 10 enteros
        Dim arraySinValoresIniciales(12) As Integer
        'Dar otros valores
        arraySinValoresIniciales(0) = 3
        arraySinValoresIniciales(1) = 4
        arraySinValoresIniciales(2) = 9
        Console.Write(arraySinValoresIniciales(0) & " , " & arraySinValoresIniciales(1) & " , " & arraySinValoresIniciales(2))

        'Declarar el array e inicializarlo a valores distintos cero
        Dim arrayConValores() As Integer = {19, 26, 0, -4, 2, 6, 7, 8}

        'Recorrer matriz con un bucle
        Console.WriteLine()
        Console.WriteLine("El profesor no se equivoca, ahora verás lo que sucedía")
        For i As Integer = 0 To 12 Step 1
            Console.Write(arraySinValoresIniciales(i) & " ")
        Next

        'Si accedemos a una posición que no existe
        ' arraySinValoresIniciales(10) = 20

        'La propiedad length me indica el tamaño de la matriz
        Dim capacidad As Integer = arraySinValoresIniciales.Length
        Console.WriteLine("La capacidad es " & capacidad)


        'Debemos usar esta propiedad para recorrer una matriz segura
        For i As Integer = 0 To arraySinValoresIniciales.Length - 1 Step 1
            Console.Write(arraySinValoresIniciales(i) & " ")
        Next


        Dim chungo(99) As Integer

        'Primer índice de la matriz es 0
        'Si quier darle un valor en la primera posición de la matriz
        chungo(0) = 2
        'La última posición accesible es la indicada en la declaración
        chungo(99) = -1
        Console.WriteLine()
        'La propiedad .length me indica el tamaño de la matriz
        Console.WriteLine("EL tamaño de la matriz es" & chungo.Length)

        'Vamos a llenar una matriz con 100 números aleatorios entre 0 y 50
        Dim aleatorio As Random = New Random()
        For i As Integer = 0 To chungo.Length - 1 Step 1
            chungo(i) = aleatorio.Next(0, 51)
        Next
        Console.WriteLine()
        Console.WriteLine("Array con números aleatorios : ")
        For i As Integer = 0 To chungo.Length - 1 Step 1
            Console.Write(chungo(i) & " ")
        Next


        Console.ReadLine()
    End Sub

End Module

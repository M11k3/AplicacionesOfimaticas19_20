Option Strict On
Module Module1

    Sub Main()

        Dim ejercicio As Integer = 2

        Select Case ejercicio
            Case 1
                Dim matriz1(,) As Integer = {{1, 1, 1}, {2, 2, 2}, {3, 3, 3}, {4, 4, 4}}

                Dim fila As Integer
                Console.WriteLine("Escoja una fila de la matriz:")
                fila = Convert.ToInt32(Console.ReadLine())

                Console.WriteLine("Los valores de la fila : " & fila)
                For i As Integer = 0 To matriz1.GetUpperBound(1) Step 1
                    Console.Write(matriz1(fila - 1, i))
                Next
                Console.WriteLine()
                'Guardar un cero en la última columna
                Dim ultimoIndiceColumna As Integer = matriz1.GetUpperBound(1)

                'matriz 4x3
                'matriz1(0, 2) = 0
                'matriz1(1, 2) = 0
                'matriz1(2, 2) = 0
                'matriz1(3, 2) = 0

                Console.WriteLine("Matriz inicial: ")

                For i As Integer = 0 To matriz1.GetUpperBound(0) Step 1
                    For j As Integer = 0 To matriz1.GetUpperBound(1) Step 1
                        Console.Write(matriz1(i, j) & " ")
                    Next
                    Console.WriteLine()
                Next

                For i As Integer = 0 To matriz1.GetUpperBound(0) Step 1
                    matriz1(i, ultimoIndiceColumna) = 0
                Next

                Console.WriteLine("Matriz final: ")

                For i As Integer = 0 To matriz1.GetUpperBound(0) Step 1
                    For j As Integer = 0 To matriz1.GetUpperBound(1) Step 1
                        Console.Write(matriz1(i, j) & " ")
                    Next
                    Console.WriteLine()
                Next

                'apartado c sumar la primera fila
                Dim suma As Integer = 0

                For i As Integer = 0 To matriz1.GetUpperBound(1) Step 1
                    suma = suma + matriz1(0, i)
                Next

                'apartado d) Cuente los ceros

                Dim contador As Integer

                For i As Integer = 0 To matriz1.GetUpperBound(0) Step 1
                    If matriz1(i, 1) = 0 Then
                        contador += 1
                    End If
                Next
            Case 2
                'Declarar matriz 3x3
                Dim matriz2(2, 2) As Integer
                Dim aleatorio As Random = New Random

                For i As Integer = 0 To matriz2.GetUpperBound(0) Step 1
                    For j As Integer = 0 To matriz2.GetUpperBound(1) Step 1
                        matriz2(i, j) = aleatorio.Next(1, 101)
                    Next
                Next

                'Mostrar matriz
                For i As Integer = 0 To matriz2.GetUpperBound(0) Step 1
                    For j As Integer = 0 To matriz2.GetUpperBound(1) Step 1
                        Console.Write(matriz2(i, j) & " ")
                    Next
                    Console.WriteLine()
                Next

                Dim suma As Integer = 0
                Dim media As Double = 0

                For i As Integer = 0 To matriz2.GetUpperBound(0) Step 1
                    For j As Integer = 0 To matriz2.GetUpperBound(1) Step 1
                        suma = suma + matriz2(i, j)
                    Next
                    Console.WriteLine()
                Next

                media = suma / matriz2.Length

                Console.WriteLine("La media es : " & media)


        End Select
        'ejercicio 1



        Console.ReadLine()

    End Sub

End Module

Option Strict On
Module Module1

    Sub Main()

        Dim ejercicio As Integer = 8

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

            Case 3
                Dim matriz3(4, 4) As Integer
                Dim aleatorio As Random = New Random()
                Dim contador As Integer = 0
                For i As Integer = 0 To matriz3.GetUpperBound(0) Step 1
                    For j As Integer = 0 To matriz3.GetUpperBound(1) Step 1
                        matriz3(i, j) = aleatorio.Next(0, 31)
                    Next
                Next

                For i As Integer = 0 To matriz3.GetUpperBound(0) Step 1
                    For j As Integer = 0 To matriz3.GetUpperBound(1) Step 1
                        If matriz3(i, j) = 0 Then
                            contador += 1
                        End If
                    Next
                Next
                'Porcentaje de ceros
                Dim porcentaje As Double = (contador / matriz3.Length) * 100

            Case 4
                Dim matriz(,) As Integer = {{1, 2, 1}, {2, 3, 2}, {1, 0, 1}}

                'Declaro matriz de mismo tamaño
                Dim traspuesta(matriz.GetUpperBound(0), matriz.GetUpperBound(1)) As Integer


                'traspuesta(0, 0) = matriz(0, 0)
                'traspuesta(0, 1) = matriz(1, 0)
                'traspuesta(0, 2) = matriz(2, 0)
                'traspuesta(1, 1) = matriz(1, 1)
                'traspuesta(1, 2) = matriz(2, 1)


                For i As Integer = 0 To matriz.GetUpperBound(0) Step 1
                    For j As Integer = 0 To matriz.GetUpperBound(1) Step 1
                        traspuesta(i, j) = matriz(j, i)
                    Next
                Next

                'Ver si es simétrica: matriz = traspuesta

                Dim simetrica As Boolean = True

#Region "Algoritmo matriz simétrica"

                For i As Integer = 0 To matriz.GetUpperBound(0) Step 1
                    For j As Integer = 0 To matriz.GetUpperBound(1) Step 1
                        If matriz(i, j) <> traspuesta(i, j) Then
                            simetrica = False
                            Exit For
                        End If
                    Next
                    If simetrica = False Then
                        Exit For
                    End If

                Next

                If simetrica Then
                    Console.WriteLine("Matriz simetrica")
                Else
                    Console.WriteLine("Matriz no simetrica")
                End If

            Case 5
                Dim matriz5(,) As Integer = {{1, 2, 3}, {4, 5, 6}, {7, 8, 9}}

                Dim sumaFila0 As Integer = 0

                Console.WriteLine("Mostrar matriz: ")
                For i As Integer = 0 To matriz5.GetUpperBound(0) Step 1
                    For j As Integer = 0 To matriz5.GetUpperBound(1) Step 1
                        Console.Write(matriz5(i, j) & " ")
                    Next
                    Console.WriteLine()

                Next

                For i As Integer = 0 To matriz5.GetUpperBound(1) Step 1
                    sumaFila0 += matriz5(0, i)
                Next
                Console.WriteLine("Suma fila cero: " & sumaFila0)

            Case 6
                Dim matriz6(,) As Integer = {{1, 2, 3}, {4, 5, 6}, {9, 0, 9}}

                Dim sumaUltimaColumna As Integer

                For i As Integer = 0 To matriz6.GetUpperBound(0) Step 1
                    sumaUltimaColumna += matriz6(i, matriz6.GetUpperBound(1))
                Next

            Case 7
                Dim matriz7(,) As Integer = {{1, 2, 3}, {4, 5, 6}, {9, 0, 9}}

                Dim suma As Integer = 0
                Dim media As Double = 0

                For i As Integer = 0 To matriz7.GetUpperBound(0) Step 1
                    For j As Integer = 0 To matriz7.GetUpperBound(1) Step 1
                        suma += matriz7(i, j)
                    Next
                Next
                media = suma / matriz7.Length

                'Calculamos el mínimo y el máximo
                Dim minimo As Integer = matriz7(0, 0)
                Dim maximo As Integer = matriz7(0, 0)

                For i As Integer = 0 To matriz7.GetUpperBound(0) Step 1
                    For j As Integer = 0 To matriz7.GetUpperBound(1) Step 1
                        If matriz7(i, j) < minimo Then
                            minimo = matriz7(i, j)
                        End If
                    Next
                Next

                For i As Integer = 0 To matriz7.GetUpperBound(0) Step 1
                    For j As Integer = 0 To matriz7.GetUpperBound(1) Step 1
                        If matriz7(i, j) > maximo Then
                            maximo = matriz7(i, j)
                        End If
                    Next
                Next

                'La desviación media es la diferencia entre un valor y la media
                Dim desviacionMediaMinimo As Double = Math.Abs(minimo - media)
                Dim desviacionmediaMaxinmo As Double = Math.Abs(maximo - media)

            Case 8
                Dim matriz8(,) As Integer = {{1, 2, 3}, {4, 5, 6}, {9, 0, 9}}
                Dim contadorCeros As Integer

                For i As Integer = 0 To matriz8.GetUpperBound(0) Step 1
                    contadorCeros = 0
                    For j As Integer = 0 To matriz8.GetUpperBound(1) Step 1
                        If matriz8(i, j) = 0 Then
                            contadorCeros += 1
                        End If

                    Next
                    If contadorCeros = matriz8.GetUpperBound(1) + 1 Then
                        Console.WriteLine("Fila " & i & " solo tiene ceros")
                        Exit For
                    End If
                Next

            Case 9
                Dim m1(,) As Integer = {{3, 4, 5}, {4, 3, 2}, {5, 6, 7}}
                Dim m2(,) As Integer = {{5, 1, 2}, {3, 6, 7}, {1, 1, 1}}
                Dim suma(m1.GetUpperBound(0), m1.GetUpperBound(1)) As Integer
                For i As Integer = 0 To m1.GetUpperBound(0) Step 1
                    Console.WriteLine("Intro valores fila :" & i)
                    For j As Integer = 0 To m2.GetUpperBound(1) Step 1
                        Console.WriteLine("Columna: " & j)
                        m1(i, j) = Convert.ToInt32(Console.ReadLine())
                    Next
                Next


                For i As Integer = 0 To suma.GetUpperBound(0)
                    For j As Integer = 0 To suma.GetUpperBound(1)
                        suma(i, j) = m1(i, j) + m2(i, j)
                    Next
                Next

                Console.WriteLine("La suma de las dos matrices es:")

                escribirMatriz2D(suma)


                'For i As Integer = 0 To suma.GetUpperBound(0)
                '    For j As Integer = 0 To suma.GetUpperBound(1)
                '        Console.Write(suma(i, j) & " ")
                '    Next
                '    Console.WriteLine()
                'Next








#End Region















        End Select
        'ejercicio 1



        Console.ReadLine()

    End Sub


End Module

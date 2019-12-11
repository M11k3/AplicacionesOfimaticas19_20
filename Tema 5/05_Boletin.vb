Module Module1

    Sub Main()
        Dim ejercicio As Integer = 15


        Select Case ejercicio
            Case 1
                Dim array(4) As Short
                array(0) = 4
                array(1) = 8
                array(3) = 14

                'Mostrar todos los valores

                Console.WriteLine("Valores guardados en el array del ej 1")

                For i As Integer = 0 To array.Length - 1 Step 1
                    Console.Write(array(i) & " ")
                Next

                'Solicitar valor al usuario y guardarlo en la última posición
                Console.WriteLine("Intro valor para guardar en la última posicición")
                array(array.Length - 1) = Convert.ToInt16(Console.ReadLine())

                Console.WriteLine("ültima posición: " & array(array.Length - 1))

            Case 2
                Dim matriz() As Integer = {4, 7, 2, 7, 9}

                Dim suma As Integer = 0
                Dim media As Double = 0

                For i As Integer = 0 To matriz.Length - 1 Step 1
                    suma = suma + matriz(i)

                Next
                media = suma / matriz.Length


                Console.WriteLine("La media es : " & media)

                'solicitar al usuario 5 nuevos valores

                For i As Integer = 0 To matriz.Length - 1 Step 1
                    Console.WriteLine("Intro nuevo valor posición : " & i)
                    matriz(i) = Convert.ToInt32(Console.ReadLine())
                Next

                'resetear suma y media
                suma = 0
                media = 0

                For i As Integer = 0 To matriz.Length - 1 Step 1
                    suma = suma + matriz(i)

                Next
                media = suma / matriz.Length


                Console.WriteLine("La nueva media es : " & media)

            Case 3
                'Desviación media de cada elemento
                Dim temperaturas() As Double = {3.5, 10.9, 6.9, 9.3}

                'Calcular la media
                Dim suma As Double = 0
                Dim temperaturaMedia As Double = 0

                For i As Integer = 0 To temperaturas.Length - 1 Step 1
                    suma = suma + temperaturas(i)
                Next

                temperaturaMedia = suma / temperaturas.Length
                Console.WriteLine("La temperatura media es : " & temperaturaMedia)
                'Calcular las desviaciones
                Dim desviacion As Double
                Dim sumaDesviaciones As Double = 0
                Dim desviacionMedia As Double
                Console.WriteLine("Desviaciones respecto a la media:")
                For i As Integer = 0 To temperaturas.Length - 1 Step 1
                    desviacion = Math.Abs(temperaturas(i) - temperaturaMedia)
                    sumaDesviaciones = sumaDesviaciones + desviacion
                    Console.WriteLine("Desviacion elemento(" & i & ") = " & desviacion)
                Next


                desviacionMedia = sumaDesviaciones / temperaturas.Length

                Console.WriteLine("La desviacion media : " & desviacionMedia)

            Case 4
                Dim n As Integer
                'Solicitamos al usuario número de elementos
                Console.WriteLine("Intro número elementos")
                n = Convert.ToInt32(Console.ReadLine())
                'Declaramos matriz de tamaño n
                Dim matriz(n - 1) As Integer

                'Solicitamos al usuario que introduzca datos y los guardamos en la matriz
                For i As Integer = 0 To matriz.Length - 1 Step 1
                    Console.WriteLine("Intro valor posición : " & i)
                    matriz(i) = Convert.ToInt32(Console.ReadLine())
                Next

                'A continuación recorremos la matriz para comprobar si tiene números negativos
                'Declaro una booleana para detectar si tiene o no tiene negativos
                Dim tieneNegativos As Boolean = False

                For i As Integer = 0 To matriz.Length - 1 Step 1
                    If matriz(i) < 0 Then
                        Console.WriteLine("El valor " & matriz(i) & " ocupa la posición : " & i)
                        tieneNegativos = True
                    End If
                Next

                If Not tieneNegativos Then
                    Console.WriteLine("No tiene números negativoss")
                End If

            Case 5
                Dim a1(4), a2(4) As Integer

                'Solicitamos datos del primerp
                For i As Integer = 0 To a1.Length - 1 Step 1
                    Console.WriteLine("Intro valor posición : " & i)
                    a1(i) = Convert.ToInt32(Console.ReadLine())
                Next

                'Volcamos datos del primero al segundo

                For i As Integer = 0 To a1.Length - 1 Step 1
                    a2(i) = a1(i) + 10
                Next

                'Mostramos ambos arrays por pantalla : Usando un For each

                Console.WriteLine("Array 1")
                For Each valor As Integer In a1
                    Console.Write(valor & " ")
                Next
                Console.WriteLine()
                Console.WriteLine("Array 2")

                For Each valor As Integer In a2
                    Console.Write(valor & " ")
                Next
                Console.WriteLine()

            Case 6
                Dim n As Integer
                'Solicitamos al usuario número de elementos
                Console.WriteLine("Intro número elementos")
                n = Convert.ToInt32(Console.ReadLine())
                'Declaramos matriz de tamaño n
                Dim matriz(n - 1) As Integer
                Dim sumaMayores15 As Integer = 0

                'Solicitamos al usuario que introduzca datos y los guardamos en la matriz
                For i As Integer = 0 To matriz.Length - 1 Step 1
                    Console.WriteLine("Intro valor posición : " & i)
                    matriz(i) = Convert.ToInt32(Console.ReadLine())
                Next

                'Calculamos suma de los > 15
                'Mostramos los menores de 15 por pantalla
                Console.WriteLine("Los elementos < 15 son : ")
                For i As Integer = 0 To matriz.Length - 1 Step 1
                    If matriz(i) > 15 Then
                        sumaMayores15 += matriz(i)
                    Else
                        Console.WriteLine(matriz(i) & " posicion: " & i)
                    End If
                Next

                Console.WriteLine("La suma de los > 15 es " & sumaMayores15)

            Case 7
                Dim vector() As Integer = {6, 4, 3}

                Dim sumaCuadrados As Integer
                Dim modulo As Double

                For i As Integer = 0 To vector.Length - 1 Step 1
                    sumaCuadrados = sumaCuadrados + vector(i) * vector(i)
                Next

                modulo = Math.Sqrt(sumaCuadrados)
                Console.WriteLine("El módulo del vector es: " & modulo)

            Case 8
                Dim n As Integer
                'Solicitamos al usuario número de elementos
                Console.WriteLine("Intro número elementos")
                n = Convert.ToInt32(Console.ReadLine())
                'Declaramos matriz de tamaño n
                Dim matriz(n - 1) As Integer
                Dim sumaMayores15 As Integer = 0

                'Solicitamos al usuario que introduzca datos y los guardamos en la matriz
                For i As Integer = 0 To matriz.Length - 1 Step 1
                    Console.WriteLine("Intro valor posición : " & i)
                    matriz(i) = Convert.ToInt32(Console.ReadLine())
                Next

                Dim posicion As Integer
                Console.WriteLine("Intro posición que desea intercambiar por último elemento")
                posicion = Convert.ToInt32(Console.ReadLine())

                'Mostramos matriz antes de intercambio
                Console.WriteLine("Matriz introducida: ")
                For Each numero As Integer In matriz
                    Console.Write(numero & " ")
                Next
                Console.WriteLine()
                Console.WriteLine(" *************   ")
                'Intercambiamos posiciones
                Dim memoria As Integer = matriz(posicion)
                matriz(posicion) = matriz(matriz.Length - 1)
                matriz(matriz.Length - 1) = memoria

                'Mostramos matriz después de intercambio
                Console.WriteLine("Matriz modificada: ")
                For Each numero As Integer In matriz
                    Console.Write(numero & " ")
                Next

            Case 9
                Dim matriz() As Integer = {5, 6, 7, -3, 0, 9, 6}
                Dim negativos As Boolean = False

                For i As Integer = 0 To matriz.Length - 1 Step 1
                    If matriz(i) < 0 Then
                        negativos = True
                        Console.WriteLine(matriz(i) & " posición : " & i)
                        Exit For
                    End If
                Next

                If Not negativos Then
                    Console.WriteLine("No hay números negativos")
                End If

            Case 10
                Dim valores() As Integer = {5, 20, 8, 4, 5, 7}
                Dim valorBuscado As Integer
                Dim encontrado As Boolean = False

                Console.WriteLine("Introduzca el valor que desea buscar:")
                valorBuscado = Convert.ToInt32(Console.ReadLine())
                Console.WriteLine(valorBuscado & " está en las posiciones: ")
                For i As Integer = 0 To valores.Length - 1 Step 1
                    If valores(i) = valorBuscado Then
                        encontrado = True
                        Console.Write(i & " ")
                    End If
                Next
                Console.WriteLine()
                If Not encontrado Then
                    Console.WriteLine("No se ha encontrado el valor buscado")
                End If

            Case 12
                Dim matriz() As Integer = {80, 100, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13}

                'Mostrar matriz original
                Console.WriteLine("Matriz original: ")
                For Each valor As Integer In matriz
                    Console.Write(valor & " ")
                Next
                Console.WriteLine()
                'Bucle externo que se ejecuta matriz.length número de veces
                For i As Integer = 1 To matriz.Length Step 1
                    Dim ordenada As Boolean = True
                    For j As Integer = 0 To matriz.Length - 2 Step 1

                        If matriz(j) > matriz(j + 1) Then
                            'Intercambiar ambas posiciones
                            Dim auxiliar As Integer = matriz(j)
                            matriz(j) = matriz(j + 1)
                            matriz(j + 1) = auxiliar
                            ordenada = False
                        End If

                        '  Console.Write(matriz(j) & " ")
                    Next
                    ' Console.Write(matriz(matriz.Length - 1))

                    If ordenada Then
                        Exit For
                    Else
                        For Each valor As Integer In matriz
                            Console.Write(valor & " ")
                        Next
                    End If
                    Console.WriteLine()
                Next


                'Mostramos la matriz ordenada
                Console.WriteLine("Matriz ordenada: ")

                For Each valor As Integer In matriz
                    Console.Write(valor & " ")
                Next

            Case 13
                Dim matriz(49) As Integer
                Dim minimo, posMinimo As Integer
                Dim maximo, posMaximo As Integer
                Dim aleatorio As Random = New Random()

                For i As Integer = 0 To matriz.Length - 1 Step 1
                    matriz(i) = aleatorio.Next(0, 100)
                Next

                'Mostramos la matriz generada
                For Each valor As Integer In matriz
                    Console.Write(valor & " ")
                Next
                Console.WriteLine()
                'Inicializamos el minimo a la primera posicion de la matriz
                minimo = matriz(0)

                For i As Integer = 1 To matriz.Length - 1 Step 1
                    If matriz(i) < minimo Then
                        'actualizar la variable minimo
                        minimo = matriz(i)
                        posMinimo = i
                    End If

                Next

                maximo = matriz(0)

                For i As Integer = 1 To matriz.Length - 1 Step 1
                    If matriz(i) > maximo Then
                        maximo = matriz(i)
                        posMaximo = i
                    End If
                Next


                Console.WriteLine("Máximo : " & maximo & " Posicion: " & posMaximo)
                Console.WriteLine("Mínimo : " & minimo & " Posicion: " & posMinimo)

            Case 15
                Dim matriz() As Integer = {3, 5, 1, 2, 2, 6, 4, 4, 600, 700}
                Dim suma As Integer = 0
                Dim media As Double

                Dim contadorValores As Integer = 0
                Dim porcentaje As Double

                For i As Integer = 0 To matriz.Length - 1 Step 1
                    suma += matriz(i)
                Next

                media = suma / matriz.Length

                'Contar valores > media

                For Each valor As Integer In matriz
                    If valor > media Then
                        contadorValores += 1
                    End If
                Next

                porcentaje = (contadorValores / matriz.Length) * 100

                Console.WriteLine("Hay un " & porcentaje & "% por encima de la media")

        End Select
        Console.ReadLine()

    End Sub

End Module
